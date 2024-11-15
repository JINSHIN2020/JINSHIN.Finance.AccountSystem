using FinanceAccountProgram.FrmControl;
using FinanceAccountProgram.FrmControl.Business;
using FinanceAccountProgram.FrmControl.Business.Report;
using FinanceAccountProgram.VModel.Business;
using JINSHIN.BUSINESS.LIBARY.Events;
using JINSHIN.BUSINESS.LIBARY.Models;
using JINSHIN.BUSINESS.LIBARY.VModel;
using JINSHIN.FinanceAccount.Libary.Config;
using JINSHIN.FinanceAccount.Libary.Models.Base;
using JINSHIN.FinanceAccounting.DB;
using System;
using System.Linq;
using System.Windows.Forms;
using JINSHIN.Finance.AccountSystem;
using JINSHIN.BUSINESS.LIBARY.VModel.Frm;
using JINSHIN.FinanceAccounting.DB.VModel;
using JINSHIN.Finance.AccountSystem.FrmControl;
using JINSHIN.FinanceAccount.Libary.VModels.Config;
using JINSHIN.RegProcess.Liary.VModel;
using JINSHIN.Finance.AccountSystem.FrmControl.Invoice;
using JINSHIN.Finance.AccountSystem.FrmControl.Report;
using JINSHIN.Finance.AccountSystem.FrmControl.Business.SN;
using JINSHIN.Finance.AccountSystem.FrmControl.Business.Dialog;

namespace FinanceAccountProgram
{
    public partial class main : Form
    {
        public bool IsLogout { get; set; }
        public bool super_user { get; set; }
        public main()
        {
            InitializeComponent();
        }

        private void btnSysSetting_Click(object sender, EventArgs e)
        {
            FrmSysSetting syssetting = new FrmSysSetting();
            syssetting.Show();
        }

        
        private void BtnAccBookConvert_Click(object sender, EventArgs e)
        {
            using (FormControl  Fcontrol = new FormControl())
            {
                Form frm = new FrmBookConvert();
                Fcontrol.FormShow(frm);
               
            }
        }

        private void BtnAIAccount_Click(object sender, EventArgs e)
        {
            using (FormControl Fcontrol = new FormControl())
            {
                using (SysSettingCtl ctl = new SysSettingCtl())
                {
                    AccountingReso.accno_id = ctl.LoadData("AccNo");
                    AccountingReso.accnoLen = Convert.ToInt32(ctl.LoadData("AccNoNum"));
                }
                Form frm = new FrmDiaryBook();
                Fcontrol.FormShow(frm);
               
            }
        }

        private void btnAIBookMgt_Click(object sender, EventArgs e)
        {
            using (FormControl Fcontrol = new FormControl())
            {
                Form frm = new FrmDiaryVerify();
                Fcontrol.FormShow(frm);

            }
        }

        private void BtnLedgerSettle_Click(object sender, EventArgs e)
        {
            using (FormControl Fcontrol = new FormControl())
            {
                Form frm = new FrmAmountSettle();
                Fcontrol.FormShow(frm);

            }
        }

        private void btnInvClassMgt_Click(object sender, EventArgs e)
        {
            using (FormControl Fcontrol = new FormControl())
            {
                Form frm = new FrmSysSetting();
                Fcontrol.FormShow(frm);

            }
        }

        private void btnAccClassMgt_Click(object sender, EventArgs e)
        {
            using (FormControl Fcontrol = new FormControl())
            {
                Form frm = new FrmBookConvert();
                Fcontrol.FormShow(frm);

            }
        }

        private void btnAccDataMgt_Click(object sender, EventArgs e)
        {
            using (FormControl Fcontrol = new FormControl())
            {
                Form frm = new FrmInvManager();
                Fcontrol.FormShow(frm);               
            }
        }

        private void btnAccCheck_Click(object sender, EventArgs e)
        {
            using (FormControl Fcontrol = new FormControl())
            {
                Form frm = new FrmAffairs();
                Fcontrol.FormShow(frm);

            }
        }

        private void btnSysMgt_Click(object sender, EventArgs e)
        {
            using (FormControl Fcontrol = new FormControl())
            {
                Form frm = new FrmSysLedgerMgt();
                Fcontrol.FormShow(frm);

            }
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            using (FormControl Fcontrol = new FormControl())
            {
                Form frm = new FrmIncomeStatmentRpt();
                Fcontrol.FormShow(frm);
            }
        }

        private void btnBalanceRpt_Click(object sender, EventArgs e)
        {
            using (FormControl Fcontrol = new FormControl())
            {
                Form frm = new FrmFinanceBalanceRpt();
                Fcontrol.FormShow(frm);

            }
        }

        private void btnAccountIdVerify_Click(object sender, EventArgs e)
        {
            using (FormControl Fcontrol = new FormControl())
            {
                Form frm = new FrmEntryVerify();
                Fcontrol.FormShow(frm);

            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            using (FormControl Fcontrol = new FormControl())
            {
                Form frm = new FrmSysBookExport();
                Fcontrol.FormShow(frm);

            }
        }

        private void AccMain_Load(object sender, EventArgs e)
        {

            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    #region userdata
                        //var val = entity.UserInfo.Where(o => o.UserName == "andrew" && o.Pass == "1234").FirstOrDefault();
                        //DataClass.usrno = val.UsrNo;
                        //DataClass.OUID = val.OUID;
                    #endregion


                    var data = entity.JINSHINFINANCE032.ToList();
                    if (DateTime.Now.Year == 2022 && DateTime.Now.Month >= 12)
                    {
                        throw new Exception("版本已逾期，請聯絡蕭副總-0903-135755");
                    }
                }
            }
            ////if (((DateTime.Now.Subtract(val.Regdate.Value).Days > 8) || DateTime.Now.Day > 30)&& (Convert.ToInt32(Project.ProjectTrail) == 1))
            ////{
            ////    throw new Exception("版本已逾期，請洽蕭副總 0903-135755購買");
            ////}
            //using (AccountEntities entity = new AccountEntities())
            //{
            //    var val = entity.JINSHINFINANCE035.FirstOrDefault();
            //    if (val != null)
            //    {
            //        if (((DateTime.Now.Subtract(val.Cost_Date.Value).Days > 60) || (DateTime.Now.Day > 22)) && IsTrailVersion)
            //        {
            //            throw new Exception("版本請更新，請找蕭副總-0903-135755");
            //        }
            //    }
            //}
            SetPassInitData();
        }

        private void SetPassInitData() 
        {
            using (SysSettingCtl ctl = new SysSettingCtl())
            {
                AccountingReso.accno_id = ctl.LoadData("AccNo");
                AccountingReso.yearnow = Convert.ToInt32(ctl.LoadData("AccYear"));
                this.Text = accounting.FormDataTitle + " " + this.Text;
            }
            ControlModel.parpam03 = 0.9f;
        }

    

       

        private void btnProduct_Click(object sender, EventArgs e)
        {
            using (FormControl Fcontrol = new FormControl())
            {
                Form frm = new FrmBusinessRestaurant();
                Fcontrol.FormShow(frm);

            }
        }

        private void bntProductSetup_Click(object sender, EventArgs e)
        {
            using (FormControl Fcontrol = new FormControl())
            {
                Form frm = new FrmRestaurantFood();
                Fcontrol.FormShow(frm);

            }
        }

        private void btnProudctRpt_Click(object sender, EventArgs e)
        {
            using (FormControl Fcontrol = new FormControl())
            {
                Form frm = new FrmProductRpt();
                Fcontrol.FormShow(frm);

            }
        }

        private void btnOftenWords_Click(object sender, EventArgs e)
        {
            using (FormControl Fcontrol = new FormControl())
            {
                Form frm = new FrmOftenWords();
                Fcontrol.FormShow(frm);

            }        
        }

        private void btnaffairsSetup_Click(object sender, EventArgs e)
        {
            using (FormControl Fcontrol = new FormControl())
            {
                Form frm = new FrmAffairsAccountingControl();
                Fcontrol.FormShow(frm);

            }
        }

        private void btnBalanceSetup_Click(object sender, EventArgs e)
        {
            ImportDataFormControl(ImportQueryClass.Balance_Sheet);
        }


        private void ImportDataFormControl(int importType)
        {
            ImportDataFrm idatafrm = new ImportDataFrm();
            idatafrm.ImportType = importType;
            idatafrm.Show();
        }
        private void btnIncomeSetup_Click(object sender, EventArgs e)
        {
            ImportDataFormControl(ImportQueryClass.Financial_Income);
        }

        private void btnAIAffairs_Click(object sender, EventArgs e)
        {            
            using (FormControl Fcontrol = new FormControl())
            {
                Form frm = new FrmAffairsAccountSetup();
                Fcontrol.FormShow(frm);

            }
        }

        private void txt03_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ControlModel.parpam03 = float.Parse(txt03.Text);
            }
            catch (Exception)
            { }
        }

        private void txt01_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt02_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ControlModel.parpam02 = float.Parse(txt02.Text);
            }
            catch (Exception)
            { 
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            AccMain_Load(null, null);
        }

        private void main_Shown(object sender, EventArgs e)
        {

        }

        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (FormControlVModel frmcontrol = new FormControlVModel())
            {
                try
                {
                    Form mainfrm = frmcontrol.FindForm("frmLogin");
                    if (IsLogout)
                    {
                        if (mainfrm != null)
                          mainfrm.Show();
                    }
                    else
                    {
                        if (mainfrm != null)
                            mainfrm.Close();
                    }
                }
                catch (Exception ex)
                {
                    LogControl.LogAlarm(ex.ToString());
                }
            }
           
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            IsLogout = true;
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            using (FormControl Fcontrol = new FormControl())
            {
                Form frm = new SNForm();
                Fcontrol.FormShow(frm);

            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (FormControl Fcontrol = new FormControl())
            {
                Form frm = new frmLogin();
                Fcontrol.FormShow(frm);

            }
        }

        private void btnAccountsReview_Click(object sender, EventArgs e)
        {
            using (FormControl Fcontrol = new FormControl())
            {
                Form frm = new FrmEntryVerify();
                Fcontrol.FormShow(frm);
            }

        }

        private void btnInvFrm_Click(object sender, EventArgs e)
        {
            using (Frm_InvScan mgt = new Frm_InvScan())
            {
                mgt.ShowDialog();
            }
            //FrmInvoiceMgt invoicemgt = new FrmInvoiceMgt();
            //invoicemgt.Show();
        }

        private void btnTaxDetailReport_Click(object sender, EventArgs e)
        {
            FrmDetailReport rpt = new FrmDetailReport();
            rpt.Show();
        }

        private void btnRegisterForm_Click(object sender, EventArgs e)
        {
        }

        private void btnAccounting_Click(object sender, EventArgs e)
        {
            FrmAccountingData accdata = new FrmAccountingData();
            accdata.ShowDialog();
        }
    }
}
