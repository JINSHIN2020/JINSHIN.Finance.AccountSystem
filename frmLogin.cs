#define DEBUG
using FinanceAccountProgram.Models.Config;
using FinanceAccountProgram.VModel.PlayerRound;
using JINSHIN.BUSINESS.LIBARY.Events;
using JINSHIN.BUSINESS.LIBARY.Sercurity;
using JINSHIN.FinanceAccounting.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JINSHIN.Finance.AccountSystem;
using JINSHIN.FinanceAccount.Libary.VModels;
using JINSHIN.FinanceAccounting.DB.VModel;
using JINSHIN.Interface.Data;
using JINSHIN.RegProcess.Liary.Content.Register.Model.Business;
using JINSHIN.RegProcess.Liary.Content.Register.VModel;
using JINSHIN.RegProcess.Liary.Content.Register.Sercurity;
using System.Diagnostics;
using JINSHIN.RegProcess.Liary.Content.Register;
using JINSHIN.RegProcess.Liary.VModel;
using JINSHIN.RegProcess.Liary.Content.Register.Model;
using JINSHIN.BUSINESS.LIBARY.UIControls;
using FinanceAccountProgram.Models;
using ChkVModel = JINSHIN.RegProcess.Liary.Content.Register.Model.ChkVModel;
using JINSHIN.Finance.AccountSystem.FrmControl.Invoice;
using JINSHIN.Finance.AccountSystem.FrmControl.Business.Money;
using FinanceAccountProgram.VModel.Business;
using JINSHIN.Work.TimeSystem.Dialog;
using JINSHIN.RegProcess.Liary.Content.Register.VModel.SN;
using JINSHIN.WORK.Resource;
using JINSHIN.Business.DataBase.VModel;
using System.Web.UI.WebControls;
using Image = System.Drawing.Image;
using JINSHIN.FinanceAccount.Libary.VModels.AccControl;
using JINSHIN.BUSINESS.LIBARY.Models.UIControls;
using JINSHIN.RegProcess.Liary.Content.Frm;
using JINSHIN.BUSINESS.LIBARY.Base;

namespace FinanceAccountProgram
{
    public partial class frmLogin : Form
    {
        public RegisterMachine regmachine { get; set; }
        public PlayVModel playvmodel { get; set; }
        public string path { get; set; }
        public int Pass { get; set; }
        public string SnNum { get; set; }
        public string idno { get; set; }
        public LicenseVModel licensemodel { get; set; }
        public LoginProcess loginprocess { get; set; }
        public SNService snservice { get; set; }
        public RegisterSys sysdata { get; set; }
        public JINSHINFINANCE018 jin18 { get; set; }
        public string supply { get; set; }
        public bool IsShow { get; set; }
        public frmLogin()
        {
            InitializeComponent();
            try
            {
                licensemodel = new LicenseVModel();
                regmachine = new RegisterMachine();
                regmachine.progressBar1 = progressBar1;
                regmachine.lprocess.progressBar1 = progressBar1;
                regmachine.picbox = picloginmsg;
                snservice = new SNService();
                path = Environment.CurrentDirectory;
                DirectoryInfo di = new DirectoryInfo(path);
#if (DEBUG)
                path = di.Parent.Parent.FullName;
#else
              path = di.FullName;
#endif
                picloginmsg.Image = Image.FromFile(path + @"\photos\1.gif");
                picloginmsg.BackColor = Color.Transparent;
                picloginmsg.Visible = false;
                loginprocess = new LoginProcess(new JINSHIN.Business.DataBase.VModel.UserCtlProcess());
                loginprocess.progressBar1 = progressBar1;
            
                }catch (Exception ex)
                {
				LogControl.LogAlarm(ex.ToString());
			}
}
        public string username = "jinshin";
        public string passpwd ="jinshin";
        public int idx = 0;
        private void timerLogin_Tick(object sender, EventArgs e)
        {
            try
            {
                AccVoiceSetting.VoiceSetting = ckVoice.Checked;
                if (idx == 14)
                {
                    idx = 0;
                    timerLogin.Enabled = false;
                    playvmodel.PlayMedialDataList(0, true);
                    System.Threading.Thread.Sleep(5000);
                    LoginSystem();
                }
                if (idx <= 6)
                {
                    txUserName.Text += username[idx];
                }
                else if (idx < 14)
                {
                    txPwd.Text += username[idx - 7];
                }
                idx++;
            }
            catch (Exception ex)
            {
			    LogControl.LogAlarm(ex.ToString());
		    }
      }

        public void SetDataClass(JINSHINFINANCE018 user)
        {
            //DataClass.OUID = user.OUID;
            //DataClass.usrno = user.UsrNo;
            //DataClass.empName = user.IDName;
            //DataClass.SupplyNo = user.SupplyNo.Value;
            //DataClass.username = user.UserName;
            //DataClass.power = user.Power;

            JINSHIN.BUSINESS.LIBARY.Base.DataClass.OUID = user.OUID;
            JINSHIN.BUSINESS.LIBARY.Base.DataClass.usrno = user.UsrNo;
            JINSHIN.BUSINESS.LIBARY.Base.DataClass.empName = user.IDName;
            JINSHIN.BUSINESS.LIBARY.Base.DataClass.SupplyNo = user.SupplyNo.Value;
            JINSHIN.BUSINESS.LIBARY.Base.DataClass.username = user.UserName;
            JINSHIN.BUSINESS.LIBARY.Base.DataClass.power = user.Power;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //string filepath = Application.StartupPath;
            //DirectoryInfo di = new DirectoryInfo(filepath);
            //filepath = di.Parent.Parent.FullName;
            //filepath = filepath + @"\\config\\moneyproduct.txt";
            //string vals02 = File.ReadAllText(filepath);
            //string valtext = SSTCryptographer.GetSSTCryLinkUTF8(vals02, ProjectData.VALPass);
            //string[] data = valtext.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            //List<NameValues> values = new List<NameValues>();
            //try
            //{
            //    for (int i = 0; i<data.Count(); i++)
            //    {
            //        string[] vdata = data[i].Split(',');
            //        if (vdata[0] == moneypay.productname)
            //        {
            //                values.Add(new NameValues()
            //                {                             
            //                    dbvalue = Convert.ToInt32(vdata[2]),
            //                    idx = Convert.ToInt32(vdata[1]),
            //                    datatype = "2",
            //                    name =  moneypay.productname
            //                });
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //}
            idno = txtIdno.Text;
            //載入DB的設定
            using (ChkVModel vmodel = new ChkVModel())
            {
                vmodel.RefreshServerIP(accounting.SrvDataName);
            }
            LoginSystem();
        }

        private void SNFormShow()
        {
            SNForm snform = new SNForm();
            snform.Show();
        }
        

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public LicenseDevData LoginRegister(string username,string pass,string snnum)
        {
          regmachine.username_data = username;
          regmachine.pass_data = pass;
          return regmachine.LoginRegister(snnum);
        }

        private void SetTraildate(string snnum)
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    var data01 = entity.JINSHINFINANCE028.Where(o => o.SnNum == snnum
                    && o.W02806 == true).OrderByDescending(v => v.CDate).FirstOrDefault();
                    var jin24 = entity.JINSHINFINANCE024.Where(v => v.SnNum == snnum).FirstOrDefault();
                    var data02 = entity.JINSHINFINANCE027.Where(o => o.SnNum == snnum
                    && o.IsCheck == true).FirstOrDefault();
                    if (data02 == null)
                    {
                        if (data01 != null)
                        {
                            DataClass.remaindate = Convert.ToDateTime(SSTCryptographer.GetSSTCryLink(data01.W02805,
                               jin24.A05   ));
                        }
                        else
                            DataClass.remaindate = DateTime.Now.AddDays(1);
                    }
                    else
                    {
                        DataClass.remaindate = DateTime.Now.AddDays(1);
                    }
                }
            }
        }
        private int CheckLicenseResult(bool takelicense, bool HasLicense, 
            SercurityControl scontrol, int checkpass, JINSHINFINANCE018 val)
        {
            if (val == null)
            {
            }
            else
            {
                if (!HasLicense)
                {
                    checkpass = ServerLicenseCheck(scontrol, val);
                }
                else if (HasLicense && takelicense)
                {
                    checkpass = ServerLicenseCheck(scontrol, val);
                }else if (HasLicense)
                    return 1;
            }
            return checkpass;
        }

        private int ServerLicenseCheck(SercurityControl scontrol, JINSHINFINANCE018 val)
        {
            int checkpass = scontrol.CheckLicense(val.OUID, val.SupplyNo.Value);
            if (checkpass == 1)
            {
                val.logincount = val.logincount ?? 0;
                val.logincount = val.logincount.Value + 1;
                string pass = ProjectData.DataPassValue;
                val.dataDate = SSTCryptographer.SetSSTCryLink(DateTime.Now.ToString("yyyy/MM/dd"), pass);
            }
            else if (checkpass == 2)
                return 7;
            return checkpass;
        }

        public void LoginSystemProcess()
        { 
           // processlogin.           
        }

        /// <summary>
        /// andrew andrew
        /// andrew11 andrew11
        /// </summary>
        private void LoginSystem()
        {
            //先註冊再登入
            licensemodel.License(idno);
            try
            {
                using (AccountEntityDB content = new AccountEntityDB())
                {
                    AccountEntities entity = content.GetEntity();
                    string uname = txUserName.Text.Trim();
                    string pass = txPwd.Text.Trim();
                    var val = entity.JINSHINFINANCE018.Where(o => o.UserName == uname 
                    && o.Pass == pass).FirstOrDefault();
                    if (val == null)
                    {
                        Pass = 1;
                        MessageBox.Show(FormCaption.LoginMsg, accounting.FormDataTitle,
                            MessageBoxButtons.OKCancel);
                        return;
                    }

                    jin18= val;
                    var supplydata = entity.JINSHINFINANCE012.Where(v => v.No == val.SupplyNo).FirstOrDefault();
                    if (supplydata!= null) {
                        supply = supplydata.Supply;
                    }
                    
                    SetDataClass(val);
                    if (val != null)
                    {
                        if (val.Enable == false)
                        {
                            DataClass.Lock = true;
                            Pass = 2;
                            MessageBox.Show(FormCaption.LoginLock, accounting.FormDataTitle,
                                MessageBoxButtons.OKCancel);
                            return;
                        }
                    }
                    
                    string snnum = "";
                    using (RegisterModel registermodel = new RegisterModel())
                    {
                      snnum =  registermodel.GetSNName(RegisterSys.JINSHIN_FINANCE);
                    }
                    LicenseDevData rsdata = LoginRegister(uname, pass,snnum);
                    IsShow = rsdata.IsShow;
                    JINSHINFINANCE024 sndata = entity.JINSHINFINANCE024.Where(o =>
                            o.Supply == DataClass.SupplyNo && o.SnNum == snnum
                            ).FirstOrDefault();
                    if (sndata != null)
                    {
                        DataClass.A02 = sndata.A02;
                        DataClass.A05 = sndata.A05;
                        DataClass.KeyId = sndata.A20;
                    }
                    SetTraildate(snnum); //暫不使用
                    int IsOEM = 0;
                    using (LoginProcess process = new LoginProcess(new UserCtlProcess()))
                    {
                        using (AccountEntityDB dcontent = new AccountEntityDB())
                        {
                            using (AccountEntities dentity = content.GetEntity())
                            {
                                DateTime license = default;
                                IsOEM = process.LoadEntityData(dentity, snnum,ref license);
                                DataClass.LicenseDate = license;
                            }
                        }
                    }
                    bool LicenseOver = DataClass.LicenseDate < DateTime.Now;
                    //IsOEM=0  
                    if (LicenseOver && IsOEM == 2 || IsOEM == 0)
                    {
                        CheckLicense_FromForm(rsdata.HasLicense);
                        return;
                    }

                    if (string.IsNullOrEmpty(snnum))
                    {
                      loginprocess.FinishTenPercent();
                      return;
                    }

                    //輸入序號對話框
                    if (rsdata.Pass == 7)
                    {
                        progressBar1.Value = 0;
                        progressBar1.Visible = false;
                        return;
                    }
                    //試用登入
                    if (rsdata.Pass == 66)
                    {
                        progressBar1.Value = 100;
                        DataClass.OUID = val.OUID;
                        DataClass.usrno = val.UsrNo;
                        DataClass.empName = val.UserName;
                        DataClass.Traildate = rsdata.TrailDate;
                        DataClass.TrailLicense = rsdata.TrailLicense;
                        FrmMenu mainform = new FrmMenu();
                        this.Hide();                
                        mainform.Show();
                        progressBar1.Visible = false;
                        return;
                    }
                    //有權限登入
                    if (rsdata.Pass == 6)
                    {
                        progressBar1.Value = 100;
                        DataClass.OUID = val.OUID;
                        DataClass.usrno = val.UsrNo;
                        DataClass.empName = val.UserName;
                        FrmMenu mainform = new FrmMenu();
                        this.Hide();                     
                        progressBar1.Visible = false;
                        mainform.Show();
                    }
                    else if (rsdata.Pass == 1)
                    {
                        progressBar1.Value = 0;
                        progressBar1.Visible = false;
                        MessageBox.Show(FormCaption.RegMsg, accounting.FormDataTitle,
                            MessageBoxButtons.OKCancel);
                    }
                    else if (rsdata.Pass == 8)
                    {
                        progressBar1.Value = 0;
                        progressBar1.Visible = false;
                        MessageBox.Show(FormCaption.LoginServerLock, accounting.FormDataTitle,
                            MessageBoxButtons.OKCancel);
                    }
                }
            }
            catch (Exception ex)
            {
                //DataClass.A05 有密碼變了
                LogControl.LogAlarm(ex.ToString());
                if (IsShow == false)
                  InputLicenseForm();
                IsShow = true;
            }
            finally
            {
              //  scontrol.Dispose();
            }
        }


        private void CheckLicense_FromForm(bool license)
        {
            if (IsShow == false)
                InputLicenseForm();
            IsShow = true;
        }

        private void InputLicenseForm()
        {
            FrmSNInput input = new FrmSNInput();
            input.jin18 = jin18;
            input.supply = supply;        
            input.ShowDialog();
            using (AccountEntityDB dcontent = new AccountEntityDB())
            {
                using (AccountEntities dentity = dcontent.GetEntity())
                {
                    //使用輸入序號                                           
                    var val = dentity.JINSHINFINANCE018.Where(o => o.UsrNo == DataClass.usrno
                              && o.SupplyNo == DataClass.SupplyNo).FirstOrDefault();
                    val.dataDate = null;
                    dentity.SaveChanges();
                }
            }
            FinishTenPercent();
        }

        private void FinishTenPercent()
        {
            progressBar1.Value = 100;
            progressBar1.Visible = false;
            timerLogin.Enabled = false;
        }

        private void lblLoginPwd_Click(object sender, EventArgs e)
        {

        }

        private void txUserName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txPwd.Focus();
            }
        }

        private void txPwd_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtIdno.Focus();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnReg_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            SNForm system = new SNForm();
            this.Hide();
            system.Show();
        }

        private void frmLogin_Shown(object sender, EventArgs e)
        {           
            txUserName.Focus();
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    entity.JINSHINFINANCE059.ToList();
                }
            }            
            SysRescControlVModel.SetFixedWindow(this);
        }

        private void btnInvoiceScan_Click(object sender, EventArgs e)
        {
            using (Frm_InvScan mgt = new Frm_InvScan())
            {
                mgt.idno=txtIdno.Text;
                mgt.ShowDialog();
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            using (FrmMoneyPay moneypay = new FrmMoneyPay())
            {
                moneypay.ShowDialog();
            }
        }

        private void txtIdno_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                btnLogin_Click(null, null);
            }
        }

        private void btnSnSerial_Click(object sender, EventArgs e)
        {
            using (FrmSNInput sninput = new FrmSNInput())
            {
                sninput.ShowDialog();
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (RegisterModel registermodel = new RegisterModel())
            {
                registermodel.buildSNKeyData("JINSHIN-5112S3DE-da12-123A");
                registermodel.SetSN_VALDATAKey(RegisterSys.JINSHIN_FINANCE, "");
                //registermodel.SetSNKey(ProjectData.SNName, ProjectData.SNValue, "");
                
            }

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
