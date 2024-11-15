
using JINSHIN.Business.DataBase;
using JINSHIN.Business.DataBase.VModel;
using JINSHIN.BUSINESS.LIBARY.Base;
using JINSHIN.BUSINESS.LIBARY.Events;
using JINSHIN.BUSINESS.LIBARY.Models.UIControls;
using JINSHIN.BUSINESS.LIBARY.Sercurity;
using JINSHIN.BUSINESS.LIBARY.UIControls.FormUI;
using JINSHIN.Finance.AccountSystem.FrmControl.Business.Money;
using JINSHIN.FinanceAccount.Libary.VModels.AccControl;
using JINSHIN.FinanceAccounting.DB;
using JINSHIN.FinanceAccounting.DB.VModel;
using JINSHIN.Interface.Data.Models.Register;
using JINSHIN.Interface.Data.Services;
using JINSHIN.RegProcess.Liary.Content.Register;
using JINSHIN.RegProcess.Liary.Content.Register.Base;
using JINSHIN.RegProcess.Liary.Content.Register.Model;
using JINSHIN.RegProcess.Liary.Content.Register.Sercurity;
using JINSHIN.RegProcess.Liary.Content.Register.VModel;
using JINSHIN.RegProcess.Liary.Content.Register.VModel.SN;
using JINSHIN.Work.TimeSystem;
using JINSHIN.Work.TimeSystem.Dialog;
using JINSHIN.WORK.Resource;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JINSHIN.Finance.AccountSystem.RegisterForm
{
    public partial class GetSNFrm : Form
    {
        public SNService snservice { get; set; }
        public string contractmsg { get; set; }
        public SNVModel snvmodel { get; set; }
        public FormUICTL formevent { get; set; }
        public bool IsKeyMan { get; set; }
        public SNProcessModel snprocess { get; set; }
        public GNOModel gnomodel { get; set; }
        public ChkVModel checkmodel { get; set; }
        public string ServerSupply { get; set; }
        public string ServerKey { get; set; }
        public bool ServerCheckEnable { get; set; }
        public JINSHINFINANCE012 supply { get; set; }
        public GetSNFrm()
        {
            InitializeComponent();
            snservice = new SNService();
            snvmodel = new SNVModel();
            contractmsg = @"一、授權條款：
    使用者同意授權予金心資訊科技有限公司，給予其廠商資訊及使用者資訊，包括廠商名稱、地址、電話、E-mail，使用者資訊包括姓名、地址、電話、電腦之IP Address及 Mac Address 作為申請註冊金心資訊中小型資訊系統使用，運用於使用金心中小型企業資訊系統業務範圍內，在使用此系統所發生之任何問題，金心資訊不負擔任何責任，不能對金心資訊有任何要求賠償之行為。
二、侵權行為：
    a.使用者不得有任何抄襲及反組譯之行為，意圖製造相同系統，破壞金心資訊中小型企業資訊系統
    b.不得租借予沒有授權之對象
    c.序號使用不得租借使用於他人
    若有以上行為，金心資訊科技有限公司將採取法律保護行為，使用者同意以上要求。
三、法律訴訟：雙方若有任何爭議，將以桃園地方法院作為仲裁之地。";
            formevent = new FormUICTL();
            snprocess = new SNProcessModel();
            gnomodel = new GNOModel();
            checkmodel = new ChkVModel();
            //DataClass.OUID = "fc4c1d86-2e2e-4803-823a-3cef771c7e39";
            //DataClass.usrno = "EC2020092200006";
        }

        //改寫
        private bool CheckDataOnServer(CTAInfoSysap val, ChkVModel checkmodel)
        {
            //if (checkmodel.ChkCompanyDataEmpty(val.SupKey, val.IdNo, val.Supply, ProjectResource.RegInputError01,
            //   Project.FormDataTitle))
            //{
            //    return true;
            //}

            //using (AccountEntityDB content = new AccountEntityDB())
            //{
            //    using (AccountEntities entity = content.GetEntity())
            //    {
            //        int results = snservice.PostRegisterData(val, snprocess,
            //            entity,  new RegUserModel()
            //        {
            //            LoginMsg = ProjectResource.LoginMsg,
            //            RegInputError01 = ProjectResource.RegInputError01,
            //            RegUserMsg003 = ProjectResource.RegUserMsg003,
            //            RegUserMsg005 = ProjectResource.RegUserMsg005,
            //            RegUserMsg006 = ProjectResource.RegUserMsg006,
            //            RegUserMsg007 = ProjectResource.RegUserMsg007,
            //            title = Project.FormDataTitle
            //        });
            //        if (results != StatusData.Success)
            //        {
            //            return true;
            //        }
            //    }
            //}
            return false;
        }


        /// <summary>
        /// 有使用者註冊功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGenSN_Click(object sender, EventArgs e)
        {
            GetSnService();
        }


        public CTAInfoSysap check_rule() 
        {
            int rsdata = 0;
            bool result = false;
            CTAInfoSysap val = new CTAInfoSysap()
            {
                UserOUID = DataClass.OUID,
                usrno = DataClass.usrno
            };
            result = CheckSubKeyEmpty(val);
            try
            {
                if (GetCTAInfoSysap(val))
                    return val;
                rsdata = CheckServerData(val);
                result = CheckSupplyKey(val);
                if (rsdata != StatusData.Success || !result)
                {
                    return val;
                }
            }catch (Exception)
            {
                return val;
            }
            return val;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        private int CheckServerData(CTAInfoSysap val)
        {
            int rsdata = 0;
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    supply = entity.JINSHINFINANCE012.Where(o => o.IdNo == val.IdNo).FirstOrDefault();
                    if (supply == null)
                    {
                        var newsupply = entity.JINSHINFINANCE012.Where(o => o.Supply == txtSupplyVal.Text)
                            .FirstOrDefault();
                        if (newsupply != null)
                        {
                            MessageBox.Show(Project.RegSupplySame);
                            return rsdata;
                        }
                    }
                    var user = entity.JINSHINFINANCE018.Where(o => o.UsrNo == DataClass.usrno)
                        .FirstOrDefault();
                    val.PosNo = user.PosNo.Value;


                    //rsdata = snservice
                    //  .PostRegisterData(val, entity, new RegUserModel()
                    //  {
                    //      LoginMsg = ProjectResource.LoginMsg,
                    //      RegInputError01 = ProjectResource.RegInputError01,
                    //      RegUserMsg003 = ProjectResource.RegUserMsg003,
                    //      RegUserMsg005 = ProjectResource.RegUserMsg005,
                    //      RegUserMsg006 = ProjectResource.RegUserMsg006,
                    //      RegUserMsg007 = ProjectResource.RegUserMsg007,
                    //      title = Project.FormDataTitle
                    //  });

                    //增加訊息msg01
                    int results = snservice.PostRegisterData(val,  entity,
                   new RegUserModel()
                   {
                       LoginMsg = ProjectResource.LoginMsg,
                       RegInputError01 = ProjectResource.RegInputError01,
                       RegUserMsg003 = ProjectResource.RegUserMsg003,
                       RegUserMsg005 = ProjectResource.RegUserMsg005,
                       RegUserMsg006 = ProjectResource.RegUserMsg006,
                       RegUserMsg007 = ProjectResource.RegUserMsg007,
                       title = Project.FormDataTitle
                   });

                    //rsdata = snservice
                    //    .PostRegisterData(val,  entity, "",          
                    //    Project.FormDataTitle                        
                        //new RegUserModel()
                        //{
                        //    LoginMsg = ProjectResource.LoginMsg,
                        //    RegInputError01 = ProjectResource.RegInputError01,
                        //    RegUserMsg003 = ProjectResource.RegUserMsg003,
                        //    RegUserMsg005 = ProjectResource.RegUserMsg005,
                        //    RegUserMsg006 = ProjectResource.RegUserMsg006,
                        //    RegUserMsg007 = ProjectResource.RegUserMsg007,
                        //    title = Project.FormDataTitle
                        //}
                        
                }
            }
            ServerSupply = val.ServerSupply;
            ServerCheckEnable = val.SupplyRight;
            ServerKey = val.ServerSubKey;
            if (ServerCheckEnable)
            {
                if (checkmodel.ChkCompanyDataEmpty(val.SupKey, val.IdNo, val.Supply, 
                    ProjectResource.RegInputError08, Project.FormDataTitle))
                    return rsdata;
            }           
            if ((rsdata == StatusData.KeyError) || (rsdata == StatusData.SupplyNameError))
            {
                return rsdata;
            }
            return rsdata;
        }


        public CTAInfoSysrs GetSnService()
        {
            try
            {
                CTAInfoSysap val = check_rule();
                if (val == null)
                    return new CTAInfoSysrs();

                CTAInfoSysrs results = snservice.GetSNData(new CTAInfoSysap()
                {
                    UserOUID = DataClass.OUID,
                    usrno = DataClass.usrno,
                    classtype = DataClass.worktype,
                    SupAddress = val.SupAddress,
                    SupPhone = val.SupPhone,
                    SupEmail = val.SupEmail,
                    JobTitle = val.JobTitle
                });

                lblSerialSN.Text = results.regSN;
                return results;
            }
            catch (Exception ex)
            {
                LogControl.LogAlarm(ex.ToString());
                CTAInfoSysrs rs = new CTAInfoSysrs();
                return rs;
            }
        }

        private bool CheckSupplyKey(CTAInfoSysap val)
        {
            if (supply != null && val.SupplyRight)
            {
                //比較輸入方及 ServerSupply 伺服方
                //supply.Supply = txtSupplyVal.Text;
                if (checkmodel.CheckSupplyKey(val, supply, false, new RegUserModel()
                {
                    LoginMsg = ProjectResource.LoginMsg,
                    RegInputError01 = ProjectResource.RegInputError01,
                    RegUserMsg003 = ProjectResource.RegUserMsg003,
                    RegUserMsg005 = ProjectResource.RegUserMsg005,
                    RegUserMsg006 = ProjectResource.RegUserMsg006,
                    RegUserMsg007 = ProjectResource.RegUserMsg007,
                    title = Project.FormDataTitle
                }))
                       return false;
           }
           return true;
        }

        private bool GetCTAInfoSysap(CTAInfoSysap val)
        {
            List<NameValues> rs = new List<NameValues>();
            List<NameValues> rs01 = snvmodel.GetGroupBoxTexts(gxSupply, Screen_Cht.DataNotEnough);
            if (rs01 == null)
                return false;
            rs.AddRange(rs01);
            using (FunctionControl func = new FunctionControl())
            {
                func.SetClassObj<CTAInfoSysap>(val, rs);
            }
            return true;
        }

        private bool CheckSubKeyEmpty(CTAInfoSysap val)
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    int sn = entity.JINSHINFINANCE008.Where(o => o.FormTitle == Project.SnForm).FirstOrDefault().FormSn;
                    var code = entity.JINSHINFINANCE004.Where(o => o.FrmSn == sn && o.IDNo == val.IdNo).FirstOrDefault();
                    if (code != null)
                    {
                        if (code.IsBuild.Value)
                        {
                            if (string.IsNullOrEmpty(txtSupKeyVal.Text))
                            {
                                MessageModel.ShowMsg(Project.RegNoEmpty, MessageType.MsgBox).Wait();
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            //去除已註冊的序號
            RegisterModel registermodel;
            registermodel = new RegisterModel(WindowSetting.OnServiceWeb);
            registermodel.SetSNKey(ProjectData.SNName, ProjectData.SNValue, "");

            //registermodel.SetSNKey(ProjectData.SNDate,
            //                ProjectData.SNDateVal, "");

            CTAInfoSysap data = check_rule();
            if (data == null)
            {
                MessageModel.ShowMsg(Project.SNAgree, MessageType.MsgBox).Wait();
                return;
            }
            if (ChkSNExists())
                return;
            if (AgreeHintMessage())
                return;
            CTAInfoSysap val = new CTAInfoSysap()
            {
                SnNum = lblSerialSN.Text,
                UserOUID = DataClass.OUID,
                usrno = DataClass.usrno,
                PosNo = DataClass.PosNo,
                JobTitle = txtJobTitleVal.Text
            };
            FunctionControl func = new FunctionControl();
            List<NameValues> rs = new List<NameValues>();
            List<NameValues> rs01 = snvmodel.GetGroupBoxTexts(gxSupply, Screen_Cht.DataNotEnough);
            if (rs01 == null)
                return;
            rs.AddRange(rs01);
            func.SetClassObj<CTAInfoSysap>(val, rs);
            using (SercurityControl info = new SercurityControl())
            {
                DevInfo dev = info.GetPhyData();
                val.MacAdrNum = dev.devdata;
                val.SysName = dev.hostname;
            }
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    snprocess.supply = entity.JINSHINFINANCE012.Where(o => o.Supply == val.Supply 
                      && o.IdNo == val.IdNo).FirstOrDefault();
                    SetCodeConfig(val.SupKey != "", val, entity);
                    val.SupplyRight = ServerCheckEnable;
                    val.ServerSupply = ServerSupply;
                    val.ServerSubKey = ServerKey;
                    string GNo = snvmodel.GetGNo(Project.FormDataTitle,
                        ProjectResource.RegUserMsg005 ,snprocess, entity, val, func, Project.SnForm);
                    if (GNo == "NoSupplyRight")
                        return;                
                    snprocess.supply.Supply = val.Supply;
                    entity.SaveChanges();
                    //status == 1 empty GNO and change key
                    //status == 2 oldkey change to newkey
                    //status == 3 key contince to add
                    if (!string.IsNullOrEmpty(snprocess.SupplyOrgGNo))
                        snprocess.Status = 1;
                    else if (snprocess.OldKey == null && snprocess.NewKey == null)
                        snprocess.Status = 2;
                    else
                        snprocess.Status = 3;
                    var usr = entity.JINSHINFINANCE018.Where(o => o.UsrNo ==  DataClass.usrno).FirstOrDefault();
                    if (usr != null)
                    if (usr.NoCode != null)
                        val.NoCode = usr.NoCode.Value;
                    usr.dataDate = null;
                    if (string.IsNullOrEmpty(ServerSupply))
                    {
                        val.ServerSupply = ServerSupply;
                    }
                    //調整資料，GNO由空轉值
                    if ((!(string.IsNullOrEmpty(GNo)) || (snprocess.Status == null) || 
                        snprocess.Status == 1) && !string.IsNullOrEmpty(val.SupKey))
                    {                        
                        val.GNO = "";
                        snprocess.supply.UsrNo = val.usrno;
                        if (snprocess.SupplyOrgGNo != null)
                            if (snprocess.SupplyOrgGNo != "")
                            {
                                AdjustForms(entity, snprocess.supply.No, snprocess.SupplyOrgGNo, val.usrno, val.SupKey);
                                val.ChgKey = true;
                            }
                        usr = entity.JINSHINFINANCE018.Where(o => o.UsrNo == val.SupKey + DataClass.usrno).FirstOrDefault();
                      //  snprocess.supply.GNo = "";
                        snprocess.code.UsrNo = val.usrno;
                        snprocess.code.IsBuild = true;
                        val.GNO = "";

                        if (usr != null && ((snprocess.SupplyOrgGNo != null || snprocess.SupplyOrgGNo != "")))
                        {
                            snvmodel.SetUserInfo(snprocess, val, func, entity, GNo, usr);
                        }
                        if (usr.NoCode.Value)
                        {
                            snvmodel.KeyChangeKey(snprocess, val, func, entity, GNo, usr, Project.SnForm);
                            snprocess.IsUpdate = false;
                        }
                  //      snprocess.supply.GNo = "";
                        snprocess.IsUpdate = true;
                        entity.SaveChanges();
                    }
                    else
                    {
                        usr.JobTitle = txtJobTitleVal.Text;
                        usr.NoCode = false;
                        if ((snprocess.Change))
                        {
                            snvmodel.KeyChangeKey(snprocess, val, func, entity, GNo, usr, Project.SnForm);
                            snprocess.IsUpdate = false;
                        }
                        else
                        {
                            //加公司鍵值加入
                            snvmodel.SetCompanyUser(snprocess, val, func, entity, GNo, usr);
                            snprocess.IsUpdate = true;
                        }                      
                        entity.SaveChanges();
                    }

                    val.JobTitle = txtJobTitleVal.Text;
                    val.GNO = GNo;
                    val.RegSN = lblSerialSN.Text;
                    val.IdName = DataClass.empName;
                    val.UserAddress = txtUserAddressVal.Text;                    
                    //不更新原來的UserNo
                    if ((!val.ChgKey) && snprocess.SupplyOrgGNo != null && snprocess.SupplyOrgGNo != "" && !val.NoCode)
                        val.usrno = DataClass.usrno;        
                    
                    //使用者屬於有註冊登入，非註冊登入需修改
                    //RSModel result  = snservice.PostSNData(val, func, snprocess, entity);

                    RSModel result = snservice.PostSNData(val);
                    FrmMoneyPay pay = new FrmMoneyPay();
                    try
                    {
                        pay.paydata = new Payment();
                        pay.paydata.SupplyNo = result.user.SupplyNo.Value;
                        pay.paydata.OUID = result.user.OUID;
                        //if (DataClass.KeyId != null)
                        //    pay.paydata.snid = result.keyid;
                        pay.a02 = SSTCryptographer.
                            GetSSTCryLink(result.reg.A02, result.reg.A05);
                        pay.Show();
                        btnPay.Enabled = true;
                        btnBuy.Enabled = false;
                    //    StatusMsgClass.AddMsg(result.CTACode);
                    }
                    catch (Exception)
                    { 
                    }
                 
                }
            }

            func.Dispose();
            rs.Clear();
            val.Dispose();
         //   btnGenSN.Enabled = false;
         //   btnBuy.Enabled = false;
        }

    



        private static void AdjustForms(AccountEntities entity, int? supplyno ,string gno,string usrno,string key)
        {
            try
            {
                List<JINSHINFINANCE018> users = new List<JINSHINFINANCE018>();
                var lst05 = entity.JINSHINFINANCE018.Where(o => o.SupplyNo == supplyno ).ToList();
                var val = entity.JINSHINFINANCE018.Where(o => o.UsrNo == DataClass.usrno).FirstOrDefault();
                lst05.Add(val);
                foreach (var i in lst05)
                {
                    var lst01 = entity.JINSHINFINANCE021.Where(o => o.SupplyNo == supplyno && o.GNO == gno).ToList();
                    foreach (var item in lst01)
                    {
                        item.nameid = key + item.nameid;
                        item.GNO = "";
                    }
                    var lst02 = entity.JINSHINFINANCE022.Where(o => o.SupplyNo == supplyno && o.GNO == gno).ToList();
                    foreach (var item in lst02)
                    {
                        item.nameid = key + item.nameid;
                        item.GNO = "";
                    }
                    var lst03 = entity.JINSHINFINANCE023.Where(o => o.SupplyNo == supplyno && o.GNO == gno).ToList();
                    foreach (var item in lst03)
                    {
                        item.nameid = key + item.nameid;
                        item.GNO = "";
                    }
                    FunctionControl func = new FunctionControl();
                    JINSHINFINANCE018 usr = new JINSHINFINANCE018();
                    func.ClassCopyTo<JINSHINFINANCE018, JINSHINFINANCE018>(i, usr);
                    usr.UsrNo = key +i.UsrNo;
                    users.Add(usr);
                    entity.JINSHINFINANCE018.Remove(i);
                }           
                entity.SaveChanges();
                foreach (var item in users)
                {
                    entity.JINSHINFINANCE018.Add(item);
                }
                entity.SaveChanges();
            }
            catch (Exception ex)
            {
                string str = ex.ToString();
               // throw;
            }
        }


        private void SetCodeConfig(bool SetKey,CTAInfoSysap val, AccountEntities entity)
        {
            int sn = entity.JINSHINFINANCE008.Where(o => o.FormTitle == Project.SnForm).FirstOrDefault().FormSn;
            var clg = entity.JINSHINFINANCE010.Where(o => o.No == 1).FirstOrDefault();
            snprocess.code = entity.JINSHINFINANCE004.Where(o => o.FrmSn == sn && o.IDNo == val.IdNo).FirstOrDefault();
            if (snprocess.code == null)
            {
                snprocess.code = new JINSHINFINANCE004();
                snprocess.code.SName = val.Supply;
                snprocess.code.Num = 5;
                snprocess.code.UsrNo = DataClass.usrno;
                snprocess.code.Enable = true;
                snprocess.code.CDate = DateTime.Now;
                snprocess.code.ChgDate = DateTime.Now;
                snprocess.code.IDNo = val.IdNo;
                snprocess.code.SugKey = val.SupKey;
                snprocess.code.IsBuild = val.SupKey != "" && val.SupKey != null;
                snprocess.code.GNo = (clg.GnoTh.Value + 1).ToString();
                clg.GnoTh = clg.GnoTh + 1;
                snprocess.code.FrmSn = Convert.ToInt32(Project.WorkFrmSn);
                entity.JINSHINFINANCE004.Add(snprocess.code);
            }
            else if (SetKey)
            {
                snprocess.code.ChgDate = DateTime.Now;
                snprocess.code.EDate = DateTime.Now;
                snprocess.code.SugKey = val.SupKey;
                snprocess.code.CDate = DateTime.Now;
            }
            entity.SaveChanges();
        }

        private void GetSNFrm_Load(object sender, EventArgs e)
        {
            InitData();
            txtSupplyVal.KeyUp += formevent.txtevent;
            txtIDNoVal.KeyUp += formevent.txtevent;
            btnPay.Enabled = false;          
        }

        private void InitData()
        {

            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    var usr = entity.JINSHINFINANCE018.Where(o => o.UsrNo == DataClass.usrno).FirstOrDefault();

                    if (usr.regSN != null)
                    {
                        lblSerialSN.Text = usr.regSN;
                    }

                    bool ChkCompany = string.IsNullOrEmpty(usr.CompanyName) ? false : true;
                    if (ChkCompany)
                    {
                        txtSupplyVal.Text = usr.CompanyName;                       
                        var datacom = entity.JINSHINFINANCE012.Where(o => o.Supply == usr.CompanyName).FirstOrDefault();
                        if (datacom != null)
                            txtSupKeyVal.Text = datacom.SupKey ?? "";
                        if (usr.PosNo != 1)
                        {
                            txtSupKeyVal.KeyUp += formevent.txtevent;
                            IsKeyMan = false;
                        }
                        else
                        {
                            IsKeyMan = true;
                        }
                    }
                }
            }
        }

        private bool ChkSNExists()
        {
            if (string.IsNullOrEmpty(lblSerialSN.Text))
            {
                MessageModel.ShowMsg(ProjectResource.RegInputError008, MessageType.MsgBox).Wait();
                return true;
            }
            return false;
        }

        private bool AgreeHintMessage()
        {
            if (!(cxAgree.Checked))
            {
                MessageModel.ShowMsg(Project.SNAgree, MessageType.MsgBox).Wait();                
                return true;
            }
            return false;
        }

        private void txtContractData_KeyUp(object sender, KeyEventArgs e)
        {
            txtContractData.Text = contractmsg;
        }

        private void GetSNFrm_Shown(object sender, EventArgs e)
        {
            txtSupplyVal.Focus();
            SysRescControlVModel.SetFixedWindow(this);
        }

        private void GetSNFrm_KeyUp(object sender, KeyEventArgs e)
        {
            ShowPassFrm(e);
        }

        private static void ShowPassFrm(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F6)
            {
                PassOn passfrm = new PassOn();
                passfrm.ShowDialog();
                passfrm.Dispose();
            }
        }

        private void txtSupplyVal_KeyUp(object sender, KeyEventArgs e)
        {
            ShowPassFrm(e);
        }

        private void btnTesting_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            using (FrmMoneyPay moneypay = new FrmMoneyPay())
            {
                moneypay.paydata = new Payment();
                moneypay.paydata.SupplyNo = DataClass.SupplyNo.Value;
                moneypay.paydata.OUID = DataClass.OUID;
                //  moneypay.paydata.snid = Convert.ToUInt32(DataClass.KeyId);                               
                moneypay.a02 = SSTCryptographer.GetSSTCryLink(DataClass.A02, DataClass.A05);
                moneypay.ShowDialog();
            }
        }
    }
}
