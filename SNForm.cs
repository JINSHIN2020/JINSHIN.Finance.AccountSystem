using FinanceAccountProgram.Models.Config;
using JINSHIN.BUSINESS.LIBARY.FormPower;
using JINSHIN.BUSINESS.LIBARY.Models.UIControls;
using JINSHIN.BUSINESS.LIBARY.Sercurity;
using JINSHIN.FinanceAccount.Libary.VModels.Dialog;
using JINSHIN.FinanceAccount.Libary.VModels.UIControls;
using JINSHIN.FinanceAccounting.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JINSHIN.Finance.AccountSystem;
using JINSHIN.FinanceAccount.Libary.VModels;
using JINSHIN.FinanceAccounting.DB.VModel;
using JINSHIN.Interface.Data.Services;
using JINSHIN.BUSINESS.LIBARY.Base;
using JINSHIN.RegProcess.Liary.Content.Register.Sercurity;
using JINSHIN.RegProcess.Liary.Content.Register.VModel;
using JINSHIN.RegProcess.Liary.Content.Register.Model;
using JINSHIN.Interface.Data.Models.Register;
using DataClass = JINSHIN.BUSINESS.LIBARY.Base.DataClass;
using JINSHIN.FinanceAccount.Libary.VModels.AccControl;

namespace FinanceAccountProgram
{
    public partial class SNForm : Form
    {
        public SNService snservice { get; set; }
        private string contract { get; set; }
        public JINSHIN.FinanceAccount.Libary.VModels.Dialog.SNVModel snvmodel { get; set; }
        public string new_usr { get; set; }
        public bool IsLoginOut { get; set; }
        public JINSHINFINANCE018 user { get; set; }
        public string NwUserName { get; set; }
        public string UsrNo { get; set; }
        public string OUID { get; set; }
        public ChkVModel checkmodel { get; set; }
        public bool ServerCheckEnable { get; set; }
        public string ServerSupply { get; set; }
        public string ServerKey { get; set; }
        public List<JINSHINFINANCE016> rules { get; set; }
        public SNForm()
        {
            InitializeComponent();

            rules = new List<JINSHINFINANCE016>();

            checkmodel = new ChkVModel();
            checkmodel.RefreshServerIP(accounting.SrvDataName);
            snservice = new SNService();
            contract = @"一、授權條款：
    使用者同意授權予金心資訊科技有限公司，給予其廠商資訊及使用者資訊，包括廠商名稱、地址、電話、E-mail，使用者資訊包括姓名、地址、電話、電腦之IP Address及 Mac Address 作為申請註冊金心資訊中小型資訊系統使用，運用於使用金心中小型企業資訊系統業務範圍內，在使用此系統所發生之任何問題，金心資訊不負擔任何責任，不能對金心資訊有任何要求賠償之行為。
二、侵權行為：
    a.使用者不得有任何抄襲及反組譯之行為，意圖製造相同系統，破壞金心資訊中小型企業資訊系統
    b.不得租借予沒有授權之對象
    c.序號使用不得租借使用於他人
    若有以上行為，金心資訊科技有限公司將採取法律保護行為，使用者同意以上要求。";
            txtRegInfo.Text = contract;
            snvmodel = new JINSHIN.FinanceAccount.Libary.VModels.Dialog.SNVModel();
                
        }




        private void userdata(int? sno)
        {
            if (!checkmodel.ChkUser(txtUserNameVal.Text.Trim(), txtIDNameVal.Text.Trim(),
                FormCaption.RegInputError03, accounting.FormDataTitle))
                return;
            CTAInfoSysap val = new CTAInfoSysap()
            {
                usrno = DataClass.usrno,
                UserOUID = DataClass.OUID
            };
            FunctionControl func = new FunctionControl();
            List<NameValues> rs = new List<NameValues>();
            if (LoadUserControlToVal(val, func, rs))
                return;                 
            NwUserName = txtUserNameVal.Text;
            if (VerifyUserName(val,true))
                return;
            if (AgreeHintMessage())
                return;

            if (!checkmodel.ChkKey(txtSupKeyVal.Text.Trim(), FormCaption.SNKey, accounting.FormDataTitle))
                return;
          
            using (SNService snservice = new SNService())
            {
                val.power = Convert.ToInt32(comRule.SelectedValue);
                JINSHINFINANCE018 usr = snservice.CreateUser(val,sno.Value);
                val.UserOUID = usr.OUID;
                val.usrno = usr.UsrNo;
                usr.SupplyNo = DataClass.SupplyNo.Value;
         //       usr.Power = Convert.ToInt32(comRule.SelectedValue);

                UsrNo = usr.UsrNo;
                OUID = usr.OUID;         
            }
        }

        private bool VerifyUserName(CTAInfoSysap data,bool CreateUser)
        {            
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    var val = entity.JINSHINFINANCE018.Where(o => o.UserName == txtUserNameVal.Text.Trim()).FirstOrDefault();
                    if (val != null)
                    {
                        if (checkmodel.ChkUserInfoWhenExists(new usermodel() {
                            idname = txtIDNameVal.Text,
                            userphone = txtUserPhoneVal.Text,
                            pass = txtPassVal.Text,
                            username = txtUserNameVal.Text.Trim()
                        },
                            DataClass.Lock, data, CreateUser, val, new RegUserModel() {
                                RegUserMsg001 = FormCaption.RegUserMsg008,
                                UserNameTheSame = FormCaption.UserNameTheSame,
                                title = accounting.FormDataTitle,
                                LoginLock = FormCaption.LoginLock
                            })) { return true; };
                    }
                }
            }
            return false;
        }

 

        private bool ChkUserStatus()
        {
            if (NwUserName == txtUserNameVal.Text)
            {
                return false;
            }
            else
            {
                MessageBox.Show(FormCaption.UpdateServerAgain, accounting.FormDataTitle, MessageBoxButtons.OKCancel);
                return true;
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
         
            CTAInfoSysap val = new CTAInfoSysap()
            {
            };
            using (SercurityControl info = new SercurityControl())
            {
                DevInfo dev = info.GetPhyData();
                val.MacAdrNum = dev.devdata;
                val.SysName = dev.hostname;
            }
          
            //相同的使用者名稱
            if (VerifyUserName(val, false))
                return;
            if (AgreeHintMessage())
                return;
            FunctionControl func = new FunctionControl();
            List<NameValues> rs = new List<NameValues>();
            if (LoadUserControlToVal(val, func, rs))
                return;

            using (SercurityControl info = new SercurityControl())
            {
                DevInfo dev = info.GetPhyData();
                val.MacAdrNum = dev.devdata;
            }       
            
            RSModel usr = snservice.PostSNData(val);
            CheckSupplyData(val, func, rs, usr);
            if (val.GetSNData)
            {
                btnBuy.Enabled = false;
            }

            int? supplyno = 0;
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    var supply = entity.JINSHINFINANCE012.Where(o => o.IdNo == val.IdNo).FirstOrDefault();
                    if (supply != null)
                        supplyno = supply.No;
                }
            }

            DataClass.SupplyNo = supplyno;

            userdata(supplyno);

        }

        private bool CheckDataOnServer(CTAInfoSysap val, ChkVModel checkmodel)
        {
            if (checkmodel.ChkCompanyDataEmpty(val.SupKey, val.IdNo, val.Supply, FormCaption.RegInputError01,
               accounting.FormDataTitle))
            {
                return true;
            }
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                   RegUserModel chkmodel = 
                        new RegUserModel()
                    {
                        LoginMsg = FormCaption.LoginMsg,
                        RegInputError01 = FormCaption.RegInputError01,
                        RegUserMsg003 = FormCaption.RegUserMsg003,
                        RegUserMsg005 = FormCaption.RegUserMsg005,
                        RegUserMsg006 = FormCaption.RegUserMsg006,
                        RegUserMsg007 = FormCaption.RegUserMsg007,
                        title = accounting.FormDataTitle
                    };
                   
                    var user = entity.JINSHINFINANCE018.
                        Where(o => o.UserName == val.UserName).FirstOrDefault();
                    if (user != null)
                    {
                        if (checkmodel.CheckUserInfo(val, entity, user, chkmodel))
                            return true;
                    }
                    else
                    {
                        var supply = entity.JINSHINFINANCE012.
                            Where(o => o.IdNo == val.IdNo).FirstOrDefault();
                        if (supply != null)
                        {
                            if (checkmodel.CheckSupplyKey(val, supply,false, chkmodel))
                                return true;
                        }
                    }
                  
                }
            }
            return false;
        }



      

     
        private bool LoadUserControlToVal(CTAInfoSysap val, FunctionControl func, List<NameValues> rs)
        {
            List<NameValues> rs01 = snvmodel.GetGroupBoxTexts(gxSupply, FormCaption.BookAffairsAccountCaption03);
            List<NameValues> rs02 = snvmodel.GetGroupBoxTexts(gxUserInfo, FormCaption.BookAffairsAccountCaption03);
            if (rs01 == null)
                return true;
            if (rs02 == null)
                return true;
            rs.AddRange(rs01);
            rs.AddRange(rs02);
            func.SetClassObj<CTAInfoSysap>(val, rs);
            return false;
        }

        private void CheckSupplyData(CTAInfoSysap val, FunctionControl func, 
            List<NameValues> rs, RSModel usr)
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    try
                    {
                        var reg = default(JINSHINFINANCE012);
                        if (val.SupplyRight)
                            reg = entity.JINSHINFINANCE012.Where(o => o.IdNo == val.IdNo).FirstOrDefault();
                        else
                            reg = entity.JINSHINFINANCE012.Where(o => o.IdNo == val.IdNo && 
                            o.SupKey == val.SupKey).FirstOrDefault();
                        if (reg == null)
                        {
                            JINSHINFINANCE012 supply = new JINSHINFINANCE012();
                            supply.CDate = DateTime.Now;
                            func.SetClassObj<JINSHINFINANCE012>(supply, rs);                           
                            supply.No = val.SupplyNo.Value;
                            entity.JINSHINFINANCE012.Add(supply);
                            entity.SaveChanges();
                        }
                        else
                        {
                            if (usr != null)
                            {
                                reg.SupKey = val.SupKey;
                              // reg.UDATE = DateTime.Now;
                                entity.SaveChanges();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        string str =ex.ToString();
                    }
                }
            }
        }

        private bool AgreeHintMessage()
        {
            if (!(cxAgree.Checked))
            {
                MessageBox.Show(FormCaption.SNAgree, accounting.FormDataTitle, MessageBoxButtons.OKCancel);
                return true;
            }
            return false;
        }

        private void SNForm_Load(object sender, EventArgs e)
        {
          //  MessageBox.Show("不開放使用");
            using (FormControlVModel ctlmodel = new FormControlVModel())
            {
                ctlmodel.ControlResolution(this);
            }
            SetSNContent();
        }

        private void GetUser()
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    string username = txtUserNameVal.Text;
                    user = entity.JINSHINFINANCE018.Where(o => o.UserName == username).FirstOrDefault();

                }
            }
        }
        private void SetSNContent()
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    //string username = txtUserNameVal.Text;
                    user = entity.JINSHINFINANCE018.Where(o => o.UsrNo == DataClass.usrno).FirstOrDefault();
                    if (user != null)
                    {
                        DataClass.Lock = user.Enable.Value ? false : true;
                        NwUserName = user.UserName;
                        if (user.regSN != null)
                        {                         
                            txtUserNameVal.Text = user.UserName;
                        }
                    }
                }
            }
        }

        private void lblSupply_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void cxTheSame_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                if (!string.IsNullOrEmpty(txtSupAddressVal.Text))
                {
                    txtUserAddressVal.Text = txtSupAddressVal.Text;
                }
                if (!string.IsNullOrEmpty(txtSuppPhoneVal.Text))
                {
                    txtUserPhoneVal.Text = txtSuppPhoneVal.Text;
                }
            }
            else
            { 
            
            }
        }

        private void txtRegInfo_KeyUp(object sender, KeyEventArgs e)
        {
            txtRegInfo.Text = contract;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            IsLoginOut = true;
            this.Close();
        }

        private void SNForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!IsLoginOut)
            {
                using (FormControlVModel frmcontrol = new FormControlVModel())
                {
                    Form mainfrm = frmcontrol.FindForm("frmLogin");
                    if (mainfrm != null)
                      mainfrm.Close();
                }
            }
        }

        private void SNForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsLoginOut)
            {
                using (FormControlVModel frmcontrol = new FormControlVModel())
                {
                    Form mainfrm = frmcontrol.FindForm("frmLogin");
                    if (mainfrm != null)
                      mainfrm.Show();
                }
            }
        }

        private void txtUserNameVal_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SetSNContent();
            }
        }

        private void gxSupply_Enter(object sender, EventArgs e)
        {

        }

        private void cxAgree_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtIDNameVal_TextChanged(object sender, EventArgs e)
        {

        }

        private void SNForm_Shown(object sender, EventArgs e)
        {
            SysRescControlVModel.SetFixedWindow(this);
            using (AccountEntityDB dbentity = new AccountEntityDB())
            {
                using (AccountEntities db = dbentity.GetEntity())
                {
                    rules = db.JINSHINFINANCE016.ToList();
                    comRule.DataSource = null;
                    comRule.DataSource = rules;
                    comRule.DisplayMember = "PName";
                    comRule.ValueMember = "Power";
                }
            }

        }
    }
}
