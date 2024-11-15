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
using System.Drawing;
using FinanceAccountProgram;
using System.Collections.Generic;
using JINSHIN.Work.TimeSystem.Dialog;
using JINSHIN.Finance.AccountSystem.FrmControl.Business.Accounts;
using JINSHIN.Finance.AccountSystem.FrmControl.Business;
using JINSHIN.RegProcess.Liary.Content.Register.Users.Forms;
using JINSHIN.BUSINESS.LIBARY.Base;
using JINSHIN.Finance.AccountSystem.FrmControl.Business.YearIntegration;
using JINSHIN.Finance.AccountSystem.FrmControl.Assets;
using JINSHIN.Finance.AccountSystem.FrmControl.DataForm;
using JINSHIN.BUSINESS.LIBARY.Models.UControl.Frm;
using JINSHIN.FinanceAccount.Libary.VModels.AccControl;
using JINSHIN.FinanceAccount.Libary.VModels.Info;
using JINSHIN.FinanceAccount.Libary.Models;
using System.Web.UI;
using CardClick.FormControl;
using JINSHIN.Finance.AccountSystem.FrmControl.Verify;
using JINSHIN.BUSINESS.LIBARY.FormPower;
using JINSHIN.Finance.AccountSystem.FrmControl.Invoice.DBManagement;

namespace JINSHIN.Finance.AccountSystem
{
    public partial class FrmMenu : Form
    {
        public bool IsLogout { get; set; }
        public bool super_user { get; set; }
        public List<Button> btns { get; set; }
        public string idno { get; set; }
        public MenuControl menucontrol { get; set; }
        public FrmMenu()
        {
            InitializeComponent();
            btns = new List<Button>();
            btns.Add(btnFunction01);
            btns.Add(btnFunction03);
            btns.Add(btnFunction05);
            btns.Add(btnFunction06);
            btns.Add(btnFunction07);
            btns.Add(btnFunction09);
            //應收應付
            btns.Add(btnFunction08);
            btns.Add(btnAssetsMgt);
            menucontrol = new MenuControl();
            SysRescControlVModel.Let1366ToMaxWindowSize(this);

        }

        public void ControlButton(int idx)
        { 
            
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            ControlFunctions(0);
        }

        private void FrmMenu_Shown(object sender, EventArgs e)
        {
            flow01.Parent = plContent;
            flow01.BackColor = Color.Transparent;
            flow02.Parent = plContent;
            flow02.BackColor = Color.Transparent;
            
            //this.WindowState = FormWindowState.Maximized;
            SetPassInitData();
            //ControlFunctions(0);
            int pwr = DataClass.power.Value;
            menucontrol.LoadPowerControl(DataClass.SupplyNo.Value,  pwr);
            ControlFunctions(0);
         
        }

        private void PanelButtonsVisableControl(FlowLayoutPanel pl, int index)
        {
            menucontrol.PanelButtonsUnVisable(pl);
            List<PowerModel> models = menucontrol.GetModel(index);
            for (int i = 0; i < models.Count; i++)
            {
                menucontrol.PanelButtonsVisable(pl, models[i]);
            }
        }

        private void btnAccids_Click(object sender, EventArgs e)
        {
            using (FrmAccountingData accdata = new FrmAccountingData())
            {
                accdata.ShowDialog();
            }
        }

        private void btnLevel01_Click(object sender, EventArgs e)
        {
            using (FormControl Fcontrol = new FormControl())
            {
                Form frm = new FrmBookConvert();
                Fcontrol.FormShow(frm);
            }
        }

        private void btnAccidSettle_Click(object sender, EventArgs e)
        {
            using (FormControl Fcontrol = new FormControl())
            {
                Form frm = new FrmAmountSettle();
                Fcontrol.FormShow(frm);
            }
        }

        private void btnLevel03_Click(object sender, EventArgs e)
        {
            using (FormControl Fcontrol = new FormControl())
            {
                Form frm = new FrmSysBookExport();
                Fcontrol.FormShow(frm);
            }
        }

        private void btnLevel02_Click(object sender, EventArgs e)
        {

        }

        private void btnInvScan_Click(object sender, EventArgs e)
        {
            using (Frm_InvScan mgt = new Frm_InvScan())
            {
                mgt.idno = idno;
                mgt.ShowDialog();
            }
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
        private void btnAIBookMgt_Click(object sender, EventArgs e)
        {
            using (FormControl Fcontrol = new FormControl())
            {
                Form frm = new FrmDiaryVerify();
                Fcontrol.FormShow(frm);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            PassDlg pass = new PassDlg();
            pass.frm = this;
            pass.ShowDialog();
            if (super_user)
            {
                FrmRegister reigster = new FrmRegister();
                reigster.ShowDialog();
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

        private void btnAIAffairs_Click(object sender, EventArgs e)
        {
            using (FormControl Fcontrol = new FormControl())
            {
                Form frm = new FrmAffairsAccountSetup();
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

        private void btnSysSetting_Click(object sender, EventArgs e)
        {
            using (FrmSysSetting syssetting = new FrmSysSetting())
            {
                syssetting.ShowDialog();
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

        private void btnOftenWords_Click(object sender, EventArgs e)
        {
            using (FormControl Fcontrol = new FormControl())
            {
                Form frm = new FrmOftenWords();
                Fcontrol.FormShow(frm);
            }
        }

        private void btnProductSetup_Click(object sender, EventArgs e)
        {
            using (FormControl Fcontrol = new FormControl())
            {
                Form frm = new FrmRestaurantFood();
                Fcontrol.FormShow(frm);
            }
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            using (FormControl Fcontrol = new FormControl())
            {
                Form frm = new FrmBusinessRestaurant();
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

        /// <summary>
        /// 沒有年份的匯入
        /// </summary>
        /// <param name="importType"></param>
        private void ImportFormControl(int importType)
        {
            using (ImportDataFrm idatafrm = new ImportDataFrm())
            {             
                idatafrm.ImportType = importType;
                idatafrm.ShowDialog();
            }
        }


        private void ImportDataFormControl(int importType)
        {
            using (FrmVerifyItemForm idatafrm = new FrmVerifyItemForm())
            {
                idatafrm.datatype = AddQueryEnum.JINSHINFINANCE047;
                idatafrm.ImportType = importType;
                idatafrm.ShowDialog();
            }
        }

        private void btnBalanceSetup_Click(object sender, EventArgs e)
        {
            //損益表
            ImportFormControl(ImportQueryClass.Balance_Sheet);
        }

        private void btnIncomeSetup_Click(object sender, EventArgs e)
        {
            //資產負債表
            ImportFormControl(ImportQueryClass.Financial_Income);
        }

        private void btnTaxDetailRpt_Click(object sender, EventArgs e)
        {
            using (FrmDetailReport rpt = new FrmDetailReport())
            {
                rpt.ShowDialog();
            }
        }

        private void btnFunction01_Click(object sender, EventArgs e)
        {
            int idx = Convert.ToInt32((sender as Button).Tag);
            ControlFunctions(idx);
            btnPowerControl.Visible = true;
            btnInv.Visible = true;
            btnInvProcess.Visible = true;
        }
        public void ControlFunctions(int idx)
        {
            flow02.Visible = false;
            flow03.Visible = false;
            flow05.Visible = false;
            flow06.Visible = false;
            flow07.Visible = false;
            flow08.Visible = false;
            flow111.Visible = false;
            flow10.Visible = false;
            btns.ForEach(x => {
                x.BackColor = Color.PaleTurquoise;            
            });
            btns[idx].BackColor = Color.Blue;
            switch (idx)
            {
                case 0: 
                    {
                        flow02.Visible = true;
                        PanelButtonsVisableControl(flow02, 1);
                    }break;
                case 1:
                    {
                        flow03.Visible = true;
                        PanelButtonsVisableControl(flow03, 2);
                    }
                    break;                                  
                case 2: {
                        flow05.Visible = true;
                        PanelButtonsVisableControl(flow05, 3);
                    }
                    break;
                case 3: {
                        flow06.Visible = true;
                        PanelButtonsVisableControl(flow06, 4);
                    }
                    break;
                case 4: {
                        flow07.Visible = true;
                        PanelButtonsVisableControl(flow07, 5);
                    }
                    break;
                case 5: {
                        flow111.Visible = true;
                        PanelButtonsVisableControl(flow111, 6);
                    }break;
                case 6: {
                        flow08.Visible =true;                        
                        PanelButtonsVisableControl(flow08, 7);
                    }break;
                case 7:
                    {
                        flow10.Visible = true;
                        PanelButtonsVisableControl(flow10, 8);
                    }
                    break;
            }
        }

        private void btnAIAccount_Click(object sender, EventArgs e)
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

        private void btnAccidsReview_Click(object sender, EventArgs e)
        {
            using (FormControl Fcontrol = new FormControl())
            {
                Form frm = new FrmEntryVerify();
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

        private void flow05_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            using (FinanceAccountProgram.VModel.FormMaintain.FormControlVModel frmcontrol = new FinanceAccountProgram.VModel.FormMaintain.FormControlVModel())
            {
                Form mainfrm = frmcontrol.FindForm("frmLogin");
                frmLogin login = mainfrm as frmLogin;
                login.progressBar1.Value = 0;
                mainfrm.Show();
                this.Close();
            }

        }

        private void flow08_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            FrmAboutLicense license = new FrmAboutLicense();
            license.ShowDialog();
        }

        private void btnBuySN_Click(object sender, EventArgs e)
        {
            FrmSNInput input = new FrmSNInput();
            input.ShowDialog();
        }

        private void btnAccountView_Click(object sender, EventArgs e)
        {
            FrmYearIntegration input = new FrmYearIntegration();
            input.ShowDialog();
        }

        private void btnMonthCostItemVerify_Click(object sender, EventArgs e)
        {
            FrmAssetsView input = new FrmAssetsView();
            input.ShowDialog();
        }

        private void flow06_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            FrmPayMgt frmpay = new FrmPayMgt();
            frmpay.ShowDialog();
        }

        private void btnRec_Click(object sender, EventArgs e)
        {
            FrmRecMgt frmpay = new FrmRecMgt();
            frmpay.ShowDialog();
        }

        private void btnPayTicket_Click(object sender, EventArgs e)
        {
            FrmPayTicketMgt frmpay = new FrmPayTicketMgt();
            frmpay.ShowDialog();
        }

        private void btnRecTicket_Click(object sender, EventArgs e)
        {
            FrmRecTicketMgt frmpay = new FrmRecTicketMgt();
            frmpay.ShowDialog();
        }

        private void btnPayVerify_Click(object sender, EventArgs e)
        {
            FrmPayVerifyMgt frmpay = new FrmPayVerifyMgt();
            frmpay.ShowDialog();
        }

        private void btnRecVerify_Click(object sender, EventArgs e)
        {
            FrmRecVerifyMgt frmpay = new FrmRecVerifyMgt();
            frmpay.ShowDialog();
        }

        private void btnPayTicketVerify_Click(object sender, EventArgs e)
        {
            FrmPayTicketVerifyMgt frmpay = new FrmPayTicketVerifyMgt();
            frmpay.ShowDialog();
        }

        private void btnRecTicketVerify_Click(object sender, EventArgs e)
        {
            FrmRecTicketVerifyMgt frmpay = new FrmRecTicketVerifyMgt();
            frmpay.ShowDialog();
        }

        private void btnCompany_Click(object sender, EventArgs e)
        {
            FrmSupplyMgt supply = new FrmSupplyMgt();
            supply.ShowDialog();
        }

        private void btnUserMgt_Click(object sender, EventArgs e)
        {
            using (FormControl Fcontrol = new FormControl())
            {
                UserMgtFrm frm = new UserMgtFrm();
                frm.supplyno = DataClass.SupplyNo.Value;
                Fcontrol.FormShow(frm);
            }
        }

        private void btnAccBalance_Click(object sender, EventArgs e)
        {
            FrmAccountsInfo info = new FrmAccountsInfo();
            info.ShowDialog();
        }

        private void btnAssetsCost_Click(object sender, EventArgs e)
        {
            FrmAssetsMgt assets = new FrmAssetsMgt();
            assets.ShowDialog();    
        }

        private void btnAssetsCostVerify_Click(object sender, EventArgs e)
        {
            FrmCostView costview = new FrmCostView();
            costview.ShowDialog();
        }

        private void btnAssetsSetup_Click(object sender, EventArgs e)
        {
            //ImportDataFrm idatafrm = new ImportDataFrm();
            //idatafrm.ImportType = ImportQueryClass.verifyImports;
            //idatafrm.Show();
        }

        private void btnAstCostSetting_Click(object sender, EventArgs e)
        {
            FrmAssetsSetting AssetsSetting = new FrmAssetsSetting();
            AssetsSetting.ShowDialog();
        }

        private void btnTtlAccount_Click(object sender, EventArgs e)
        {
            using (FormControl Fcontrol = new FormControl())
            {
                Form frm = new FrmDataTotalSum();
                Fcontrol.FormShow(frm);
            }
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            using (FormControl Fcontrol = new FormControl())
            {
                Form frm = new FrmDetailData();
                Fcontrol.FormShow(frm);
            }
        }

        private void btnAmountRemain_Click(object sender, EventArgs e)
        {
            using (FormControl Fcontrol = new FormControl())
            {
                Form frm = new FrmAccountsInfo();
                Fcontrol.FormShow(frm);
            }
        }

        private void btnSetup_Click(object sender, EventArgs e)
        {

        }

        private void btnPowerControl_Click(object sender, EventArgs e)
        {
            using (FrmFuncPwrControl funcpwr_control = new FrmFuncPwrControl())
            {
                using (AccountEntityDB dbentity = new AccountEntityDB())
                {
                    using (AccountEntities entity = dbentity.GetEntity())
                    {                        
                        var lst = entity.JINSHINFINANCE011.ToList();
                        foreach (var item in lst)
                        {
                            var data = lst.Where(v => v.ProName == item.ProName 
                                                && v.ClassNo != null).FirstOrDefault();
                            if (item.ClassNo == null)
                            {
                                item.ClassNo = data.ClassNo;
                            }
                        }
                        entity.SaveChanges();
                    }
                }
                funcpwr_control.ShowDialog();
            }
        }

        private void btnPowerSetting_Click(object sender, EventArgs e)
        {

        }

        private void btnPowerSetup_Click(object sender, EventArgs e)
        {
            using (FormControl Fcontrol = new FormControl())
            {
                Form frm = new FrmPowerSetting();
                Fcontrol.FormShow(frm);
            }
        }

        private void btnAccountImport_Click(object sender, EventArgs e)
        {
            //帳務匯入
            ImportDataFormControl(ImportQueryClass.verifyitem);
        }

        private void btnInv_Click(object sender, EventArgs e)
        {
            using (FormControl Fcontrol = new FormControl())
            {
                Form frm = new FrmDataForm();
                Fcontrol.FormShow(frm);
            }
        }

        private void btnInvProcess_Click(object sender, EventArgs e)
        {
            using (FormControl Fcontrol = new FormControl())
            {
                Form frm = new FrmMain();
                Fcontrol.FormShow(frm);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
