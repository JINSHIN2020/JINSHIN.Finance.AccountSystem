using JINSHIN.BUSINESS.LIBARY.UIControls.GridView;
using JINSHIN.FinanceAccount.Libary.Models.Base;

namespace FinanceAccountProgram
{
    partial class frmFinancial
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            FinanceAccountProgram.VModel.AddQueryForm.Acc_VModel acc_VModel1 = new FinanceAccountProgram.VModel.AddQueryForm.Acc_VModel();
            JINSHIN.FinanceAccount.Libary.Models.Base.GridViewFinanceBase gridViewFinanceBase1 = new JINSHIN.FinanceAccount.Libary.Models.Base.GridViewFinanceBase();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFinancial));
            FinanceAccountProgram.Models.Config.PathModel pathModel1 = new FinanceAccountProgram.Models.Config.PathModel();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblYearNo = new System.Windows.Forms.TabControl();
            this.TPConvertDataPage = new System.Windows.Forms.TabPage();
            this.chUpdateDBResource = new System.Windows.Forms.CheckBox();
            this.rboption01 = new System.Windows.Forms.RadioButton();
            this.lstMsg = new System.Windows.Forms.ListBox();
            this.gbOPtionFile = new System.Windows.Forms.GroupBox();
            this.radioDB = new System.Windows.Forms.RadioButton();
            this.radioFile = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lblInvoiceLst = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rboptions02 = new System.Windows.Forms.RadioButton();
            this.btnGenrateData = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.Filelst3 = new System.Windows.Forms.ListBox();
            this.Filelst2 = new System.Windows.Forms.ListBox();
            this.Filelst = new System.Windows.Forms.ListBox();
            this.TPViewer = new System.Windows.Forms.TabPage();
            this.lblViewStatus = new System.Windows.Forms.Label();
            this.gpViewer = new System.Windows.Forms.GroupBox();
            this.radioBookItem = new System.Windows.Forms.RadioButton();
            this.radioBook = new System.Windows.Forms.RadioButton();
            this.btnBalance = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.dgTabView = new System.Windows.Forms.DataGridView();
            this.DiaryBook = new System.Windows.Forms.TabPage();
            this.txAccInputdgAcc = new System.Windows.Forms.TextBox();
            this.lblAccInputdgAcc = new System.Windows.Forms.Label();
            this.btnAccGenerate = new System.Windows.Forms.Button();
            this.lblAccInputYear = new System.Windows.Forms.Label();
            this.txAccYear = new System.Windows.Forms.TextBox();
            this.txAccMonth = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnInteliAccDelete = new System.Windows.Forms.Button();
            this.btnAccInputCost = new System.Windows.Forms.Button();
            this.btnAccConfirm = new System.Windows.Forms.Button();
            this.dgAccAccountsData = new System.Windows.Forms.DataGridView();
            this.plAccInputPanel = new System.Windows.Forms.Panel();
            this.btnAccInputNew = new System.Windows.Forms.Button();
            this.btnAccQuery = new System.Windows.Forms.Button();
            this.btnAccInputSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAccInputRecord = new System.Windows.Forms.Button();
            this.btnDiarySelection = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.lblInputPos = new System.Windows.Forms.ComboBox();
            this.txDiaAccNo = new System.Windows.Forms.TextBox();
            this.txDiaAccDesc = new System.Windows.Forms.TextBox();
            this.txAccDatatype = new System.Windows.Forms.TextBox();
            this.txDiaAmount = new System.Windows.Forms.TextBox();
            this.lblDiary = new System.Windows.Forms.Label();
            this.txDiaAccID = new System.Windows.Forms.TextBox();
            this.lblDiaryAmount = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblAccInputPos = new System.Windows.Forms.Label();
            this.lblSuggestResult = new System.Windows.Forms.Label();
            this.lblWhereInput = new System.Windows.Forms.Label();
            this.lblaccsuggest = new System.Windows.Forms.Label();
            this.lblDiaNoValue = new System.Windows.Forms.Label();
            this.lblDiaNo = new System.Windows.Forms.Label();
            this.lblDiaryDate = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dtAccPicker = new System.Windows.Forms.DateTimePicker();
            this.dgCostItemView = new System.Windows.Forms.DataGridView();
            this.TPQuery = new System.Windows.Forms.TabPage();
            this.lblBookLend = new System.Windows.Forms.Label();
            this.lblBookTitleGet = new System.Windows.Forms.Label();
            this.lblBookGet = new System.Windows.Forms.Label();
            this.lblBookTitleLend = new System.Windows.Forms.Label();
            this.chQueryAcc = new System.Windows.Forms.CheckBox();
            this.lblQueryAccYear = new System.Windows.Forms.Label();
            this.dgQueryData = new System.Windows.Forms.DataGridView();
            this.btnDiaryExport = new System.Windows.Forms.Button();
            this.btnDiaryCreate = new System.Windows.Forms.Button();
            this.btnDeleteQueryAcc = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.txQueryAccYear = new System.Windows.Forms.TextBox();
            this.txQueryAccMonth = new System.Windows.Forms.TextBox();
            this.lblQueryAccMonth = new System.Windows.Forms.Label();
            this.TPAccountLedger = new System.Windows.Forms.TabPage();
            this.btnALegerQuery = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblLedgerLend = new System.Windows.Forms.Label();
            this.lblLedgerResult = new System.Windows.Forms.Label();
            this.lblGet = new System.Windows.Forms.Label();
            this.lblLedgerGetVal = new System.Windows.Forms.Label();
            this.lblLend = new System.Windows.Forms.Label();
            this.dgLedger = new System.Windows.Forms.DataGridView();
            this.TPClassType = new System.Windows.Forms.TabPage();
            this.coClassType = new System.Windows.Forms.ComboBox();
            this.dgClassData = new System.Windows.Forms.DataGridView();
            this.btnClassUpdate = new System.Windows.Forms.Button();
            this.btnClassAdd = new System.Windows.Forms.Button();
            this.lblSN = new System.Windows.Forms.Label();
            this.lblClassTitle01 = new System.Windows.Forms.Label();
            this.lblClassName = new System.Windows.Forms.Label();
            this.txClassNO = new System.Windows.Forms.TextBox();
            this.txClassName = new System.Windows.Forms.TextBox();
            this.TPClassDetail = new System.Windows.Forms.TabPage();
            this.masterCtl01 = new FinanceAccountProgram.Controls.MasterUserControl();
            this.TPVerifyAcc = new System.Windows.Forms.TabPage();
            this.updateVerifyAcc = new FinanceAccountProgram.Controls.UpdateListForm();
            this.tbAccConfirm = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.lstAccConfirmMsg = new System.Windows.Forms.ListBox();
            this.chConfirmAll = new System.Windows.Forms.CheckBox();
            this.lstVerifyAccds = new System.Windows.Forms.ListBox();
            this.lblLstAccIDs = new System.Windows.Forms.Label();
            this.dgControl = new System.Windows.Forms.DataGridView();
            this.btnAnalyzeAccs = new System.Windows.Forms.Button();
            this.btnAccExport = new System.Windows.Forms.Button();
            this.btnConfirmQuery = new System.Windows.Forms.Button();
            this.btnVerify = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabReport = new System.Windows.Forms.TabPage();
            this.chDataFull = new System.Windows.Forms.CheckBox();
            this.lblsettleMsg = new System.Windows.Forms.Label();
            this.LstFinanacialMsg = new System.Windows.Forms.ListBox();
            this.dataFinancialLedger = new System.Windows.Forms.DataGridView();
            this.dgFinancialSettlGridView = new System.Windows.Forms.DataGridView();
            this.btnCheckAccounts = new System.Windows.Forms.Button();
            this.btnArrangeNew = new System.Windows.Forms.Button();
            this.btnCheckAccNo = new System.Windows.Forms.Button();
            this.btnReportExportData = new System.Windows.Forms.Button();
            this.btnSetttleQuery = new System.Windows.Forms.Button();
            this.btnSettle = new System.Windows.Forms.Button();
            this.tbFinancialIncome = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.lstMsgIncomeStatment = new System.Windows.Forms.ListBox();
            this.btnIncomeReport = new System.Windows.Forms.Button();
            this.btnReportExport = new System.Windows.Forms.Button();
            this.dgIncomeFinancial = new System.Windows.Forms.DataGridView();
            this.btnIncomeFinancial = new System.Windows.Forms.Button();
            this.lblFinancialRptCnt = new System.Windows.Forms.Label();
            this.lblIncomeStatement = new System.Windows.Forms.Label();
            this.TabBalanceRpt = new System.Windows.Forms.TabPage();
            this.btnBalanceReport = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.lstMsgFinanceBalance = new System.Windows.Forms.ListBox();
            this.btnBalanceReportData = new System.Windows.Forms.Button();
            this.dgBalanceFinancial = new System.Windows.Forms.DataGridView();
            this.btnFinanceBalance = new System.Windows.Forms.Button();
            this.lblBalanceSheetCnt = new System.Windows.Forms.Label();
            this.lblFinanceBalance = new System.Windows.Forms.Label();
            this.TabExport = new System.Windows.Forms.TabPage();
            this.chExportVerify = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.lstAccounting = new System.Windows.Forms.ListBox();
            this.btnExportAccounting = new System.Windows.Forms.Button();
            this.TbSetting = new System.Windows.Forms.TabPage();
            this.btnSetup = new System.Windows.Forms.Button();
            this.txtSYear = new System.Windows.Forms.TextBox();
            this.lblSYear = new System.Windows.Forms.Label();
            this.tbAccFunctions = new System.Windows.Forms.TabPage();
            this.button11 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TPAccAmount = new System.Windows.Forms.TabPage();
            this.addQueryDataForm4 = new FinanceAccountProgram.Controls.AddQueryDataForm();
            this.TPInvContract = new System.Windows.Forms.TabPage();
            this.addQueryInvContract = new FinanceAccountProgram.Controls.AddQueryDataForm();
            this.TPCost = new System.Windows.Forms.TabPage();
            this.CtlInvoice = new System.Windows.Forms.Panel();
            this.btnCostUpdate = new System.Windows.Forms.Button();
            this.btnCostAdd = new System.Windows.Forms.Button();
            this.txCostBuyID = new System.Windows.Forms.TextBox();
            this.txCostTaxAmount = new System.Windows.Forms.TextBox();
            this.txCostAmount = new System.Windows.Forms.TextBox();
            this.txCostInvoiceID = new System.Windows.Forms.TextBox();
            this.txCostSellID = new System.Windows.Forms.TextBox();
            this.chCostTax = new System.Windows.Forms.CheckBox();
            this.chCostAll = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lstCostMonthList = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTitle02 = new System.Windows.Forms.Label();
            this.lblSellID = new System.Windows.Forms.Label();
            this.lblTitle01 = new System.Windows.Forms.Label();
            this.cxCostDataType = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgCostData = new System.Windows.Forms.DataGridView();
            this.TPCostDataView = new System.Windows.Forms.TabPage();
            this.btnRebuildIndx = new System.Windows.Forms.Button();
            this.btnCostItemUpdate = new System.Windows.Forms.Button();
            this.AddQueryCostData = new FinanceAccountProgram.Controls.AddQueryDataForm();
            this.tbMoney = new System.Windows.Forms.TabPage();
            this.cokMonMALL = new System.Windows.Forms.CheckBox();
            this.txtValidMAccID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMCostAccID = new System.Windows.Forms.TextBox();
            this.lbl_Accid = new System.Windows.Forms.Label();
            this.txtValidDescData = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCostDescData = new System.Windows.Forms.TextBox();
            this.lblMoneyQuery = new System.Windows.Forms.Label();
            this.lblMonthTitle = new System.Windows.Forms.Label();
            this.lstMonths = new System.Windows.Forms.ListBox();
            this.goAccType = new System.Windows.Forms.GroupBox();
            this.rbType02 = new System.Windows.Forms.RadioButton();
            this.rbType01 = new System.Windows.Forms.RadioButton();
            this.btnVierfyAcc = new System.Windows.Forms.Button();
            this.btnCancelCheck = new System.Windows.Forms.Button();
            this.btnMoneyVeriy = new System.Windows.Forms.Button();
            this.btnMoney = new System.Windows.Forms.Button();
            this.lstMoneyMsg = new System.Windows.Forms.ListBox();
            this.dataMoney02 = new System.Windows.Forms.DataGridView();
            this.dataMoney01 = new System.Windows.Forms.DataGridView();
            this.TbAssets = new System.Windows.Forms.TabPage();
            this.btnAssetsVerify = new System.Windows.Forms.Button();
            this.frmAssets = new FinanceAccountProgram.Controls.FrmDataMaintain();
            this.tbViewData = new System.Windows.Forms.TabPage();
            this.lblAcc_NO_Wait = new System.Windows.Forms.Label();
            this.lblVerifyOK = new System.Windows.Forms.Label();
            this.lblAcc_Verifying = new System.Windows.Forms.Label();
            this.lstNoVerifyData = new System.Windows.Forms.ListBox();
            this.lstVerifing = new System.Windows.Forms.ListBox();
            this.lstVerifyData = new System.Windows.Forms.ListBox();
            this.btn_payfirstLaborInsurance = new System.Windows.Forms.Button();
            this.btnWorkCost = new System.Windows.Forms.Button();
            this.btn_prepay_product = new System.Windows.Forms.Button();
            this.btn_rate = new System.Windows.Forms.Button();
            this.btn_travel_income = new System.Windows.Forms.Button();
            this.btnOthersCost = new System.Windows.Forms.Button();
            this.btn_pre_payrate = new System.Windows.Forms.Button();
            this.btn_gift = new System.Windows.Forms.Button();
            this.btn_Cost_Income = new System.Windows.Forms.Button();
            this.btnViewRefresh = new System.Windows.Forms.Button();
            this.btn_Depreciation_Cost = new System.Windows.Forms.Button();
            this.btnAssets = new System.Windows.Forms.Button();
            this.btnpayableSalary = new System.Windows.Forms.Button();
            this.btnpayable = new System.Windows.Forms.Button();
            this.btndividend = new System.Windows.Forms.Button();
            this.btnInterest = new System.Windows.Forms.Button();
            this.btnFinance = new System.Windows.Forms.Button();
            this.btnPhone = new System.Windows.Forms.Button();
            this.btnOffice365 = new System.Windows.Forms.Button();
            this.btnSalary = new System.Windows.Forms.Button();
            this.tbVerifyAssetsInfo = new System.Windows.Forms.TabPage();
            this.chDisplayAssetCost = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblmsg = new System.Windows.Forms.Label();
            this.assetsVerifyMsg = new System.Windows.Forms.ListBox();
            this.datetimecontrol = new System.Windows.Forms.DateTimePicker();
            this.dgVerifyAssetsInfo = new System.Windows.Forms.DataGridView();
            this.btnAssetsExport = new System.Windows.Forms.Button();
            this.btnVerifyAssetsData = new System.Windows.Forms.Button();
            this.tbImports = new System.Windows.Forms.TabPage();
            this.plBalancePaper = new System.Windows.Forms.Panel();
            this.plIncomePaper = new System.Windows.Forms.Panel();
            this.plAiPaper = new System.Windows.Forms.Panel();
            this.btnBalanceSheet = new System.Windows.Forms.Button();
            this.btnFinancialIncome = new System.Windows.Forms.Button();
            this.btnImportVerItem = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.lstInvoice = new System.Windows.Forms.ListBox();
            this.lblYearNo.SuspendLayout();
            this.TPConvertDataPage.SuspendLayout();
            this.gbOPtionFile.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.TPViewer.SuspendLayout();
            this.gpViewer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTabView)).BeginInit();
            this.DiaryBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAccAccountsData)).BeginInit();
            this.plAccInputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCostItemView)).BeginInit();
            this.TPQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgQueryData)).BeginInit();
            this.TPAccountLedger.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLedger)).BeginInit();
            this.TPClassType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClassData)).BeginInit();
            this.TPClassDetail.SuspendLayout();
            this.TPVerifyAcc.SuspendLayout();
            this.tbAccConfirm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgControl)).BeginInit();
            this.tabReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFinancialLedger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgFinancialSettlGridView)).BeginInit();
            this.tbFinancialIncome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgIncomeFinancial)).BeginInit();
            this.TabBalanceRpt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBalanceFinancial)).BeginInit();
            this.TabExport.SuspendLayout();
            this.TbSetting.SuspendLayout();
            this.tbAccFunctions.SuspendLayout();
            this.TPAccAmount.SuspendLayout();
            this.TPInvContract.SuspendLayout();
            this.TPCost.SuspendLayout();
            this.CtlInvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCostData)).BeginInit();
            this.TPCostDataView.SuspendLayout();
            this.tbMoney.SuspendLayout();
            this.goAccType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMoney02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMoney01)).BeginInit();
            this.TbAssets.SuspendLayout();
            this.tbViewData.SuspendLayout();
            this.tbVerifyAssetsInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVerifyAssetsInfo)).BeginInit();
            this.tbImports.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblResult.Location = new System.Drawing.Point(396, 335);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 19);
            this.lblResult.TabIndex = 2;
            // 
            // lblYearNo
            // 
            this.lblYearNo.Controls.Add(this.TPConvertDataPage);
            this.lblYearNo.Controls.Add(this.TPViewer);
            this.lblYearNo.Controls.Add(this.DiaryBook);
            this.lblYearNo.Controls.Add(this.TPQuery);
            this.lblYearNo.Controls.Add(this.TPAccountLedger);
            this.lblYearNo.Controls.Add(this.TPClassType);
            this.lblYearNo.Controls.Add(this.TPClassDetail);
            this.lblYearNo.Controls.Add(this.TPVerifyAcc);
            this.lblYearNo.Controls.Add(this.tbAccConfirm);
            this.lblYearNo.Controls.Add(this.tabReport);
            this.lblYearNo.Controls.Add(this.tbFinancialIncome);
            this.lblYearNo.Controls.Add(this.TabBalanceRpt);
            this.lblYearNo.Controls.Add(this.TabExport);
            this.lblYearNo.Controls.Add(this.TbSetting);
            this.lblYearNo.Controls.Add(this.tbAccFunctions);
            this.lblYearNo.Controls.Add(this.TPAccAmount);
            this.lblYearNo.Controls.Add(this.TPInvContract);
            this.lblYearNo.Controls.Add(this.TPCost);
            this.lblYearNo.Controls.Add(this.TPCostDataView);
            this.lblYearNo.Controls.Add(this.tbMoney);
            this.lblYearNo.Controls.Add(this.TbAssets);
            this.lblYearNo.Controls.Add(this.tbViewData);
            this.lblYearNo.Controls.Add(this.tbVerifyAssetsInfo);
            this.lblYearNo.Controls.Add(this.tbImports);
            this.lblYearNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblYearNo.Location = new System.Drawing.Point(0, 0);
            this.lblYearNo.Name = "lblYearNo";
            this.lblYearNo.SelectedIndex = 0;
            this.lblYearNo.Size = new System.Drawing.Size(1804, 749);
            this.lblYearNo.TabIndex = 6;
            this.lblYearNo.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.lblYearNo.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabsCtls_Selected);
            // 
            // TPConvertDataPage
            // 
            this.TPConvertDataPage.Controls.Add(this.chUpdateDBResource);
            this.TPConvertDataPage.Controls.Add(this.rboption01);
            this.TPConvertDataPage.Controls.Add(this.lstMsg);
            this.TPConvertDataPage.Controls.Add(this.gbOPtionFile);
            this.TPConvertDataPage.Controls.Add(this.label2);
            this.TPConvertDataPage.Controls.Add(this.lblInvoiceLst);
            this.TPConvertDataPage.Controls.Add(this.label1);
            this.TPConvertDataPage.Controls.Add(this.groupBox1);
            this.TPConvertDataPage.Controls.Add(this.btnGenrateData);
            this.TPConvertDataPage.Controls.Add(this.btnRefresh);
            this.TPConvertDataPage.Controls.Add(this.Filelst3);
            this.TPConvertDataPage.Controls.Add(this.Filelst2);
            this.TPConvertDataPage.Controls.Add(this.Filelst);
            this.TPConvertDataPage.Location = new System.Drawing.Point(4, 22);
            this.TPConvertDataPage.Name = "TPConvertDataPage";
            this.TPConvertDataPage.Padding = new System.Windows.Forms.Padding(3);
            this.TPConvertDataPage.Size = new System.Drawing.Size(1362, 723);
            this.TPConvertDataPage.TabIndex = 0;
            this.TPConvertDataPage.Text = "帳簿轉換功能";
            this.TPConvertDataPage.UseVisualStyleBackColor = true;
            // 
            // chUpdateDBResource
            // 
            this.chUpdateDBResource.AutoSize = true;
            this.chUpdateDBResource.Location = new System.Drawing.Point(1384, 81);
            this.chUpdateDBResource.Name = "chUpdateDBResource";
            this.chUpdateDBResource.Size = new System.Drawing.Size(72, 16);
            this.chUpdateDBResource.TabIndex = 17;
            this.chUpdateDBResource.Text = "資料覆蓋";
            this.chUpdateDBResource.UseVisualStyleBackColor = true;
            // 
            // rboption01
            // 
            this.rboption01.AutoSize = true;
            this.rboption01.Location = new System.Drawing.Point(333, 358);
            this.rboption01.Name = "rboption01";
            this.rboption01.Size = new System.Drawing.Size(47, 16);
            this.rboption01.TabIndex = 4;
            this.rboption01.Text = "國稅";
            this.rboption01.UseVisualStyleBackColor = true;
            this.rboption01.Visible = false;
            // 
            // lstMsg
            // 
            this.lstMsg.FormattingEnabled = true;
            this.lstMsg.ItemHeight = 12;
            this.lstMsg.Location = new System.Drawing.Point(1237, 137);
            this.lstMsg.Name = "lstMsg";
            this.lstMsg.Size = new System.Drawing.Size(325, 352);
            this.lstMsg.TabIndex = 16;
            // 
            // gbOPtionFile
            // 
            this.gbOPtionFile.Controls.Add(this.radioDB);
            this.gbOPtionFile.Controls.Add(this.radioFile);
            this.gbOPtionFile.Location = new System.Drawing.Point(1237, 22);
            this.gbOPtionFile.Name = "gbOPtionFile";
            this.gbOPtionFile.Size = new System.Drawing.Size(141, 95);
            this.gbOPtionFile.TabIndex = 15;
            this.gbOPtionFile.TabStop = false;
            this.gbOPtionFile.Text = "匯出格式";
            // 
            // radioDB
            // 
            this.radioDB.AutoSize = true;
            this.radioDB.Location = new System.Drawing.Point(6, 58);
            this.radioDB.Name = "radioDB";
            this.radioDB.Size = new System.Drawing.Size(59, 16);
            this.radioDB.TabIndex = 5;
            this.radioDB.Text = "資料庫";
            this.radioDB.UseVisualStyleBackColor = true;
            // 
            // radioFile
            // 
            this.radioFile.AutoSize = true;
            this.radioFile.Checked = true;
            this.radioFile.Location = new System.Drawing.Point(6, 21);
            this.radioFile.Name = "radioFile";
            this.radioFile.Size = new System.Drawing.Size(71, 16);
            this.radioFile.TabIndex = 4;
            this.radioFile.TabStop = true;
            this.radioFile.Text = "輸出檔案";
            this.radioFile.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(12, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "比對資料";
            // 
            // lblInvoiceLst
            // 
            this.lblInvoiceLst.AutoSize = true;
            this.lblInvoiceLst.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblInvoiceLst.Location = new System.Drawing.Point(921, 379);
            this.lblInvoiceLst.Name = "lblInvoiceLst";
            this.lblInvoiceLst.Size = new System.Drawing.Size(123, 19);
            this.lblInvoiceLst.TabIndex = 14;
            this.lblInvoiceLst.Text = "發票原始資料";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(587, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "原始資料";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rboptions02);
            this.groupBox1.Location = new System.Drawing.Point(341, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 55);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "格式";
            // 
            // rboptions02
            // 
            this.rboptions02.AutoSize = true;
            this.rboptions02.Checked = true;
            this.rboptions02.Location = new System.Drawing.Point(6, 21);
            this.rboptions02.Name = "rboptions02";
            this.rboptions02.Size = new System.Drawing.Size(59, 16);
            this.rboptions02.TabIndex = 5;
            this.rboptions02.TabStop = true;
            this.rboptions02.Text = "公司帳";
            this.rboptions02.UseVisualStyleBackColor = true;
            // 
            // btnGenrateData
            // 
            this.btnGenrateData.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnGenrateData.Location = new System.Drawing.Point(333, 102);
            this.btnGenrateData.Name = "btnGenrateData";
            this.btnGenrateData.Size = new System.Drawing.Size(199, 63);
            this.btnGenrateData.TabIndex = 9;
            this.btnGenrateData.Text = "匯出公司帳冊資料";
            this.btnGenrateData.UseVisualStyleBackColor = true;
            this.btnGenrateData.Click += new System.EventHandler(this.btnGenrateData_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRefresh.Location = new System.Drawing.Point(333, 171);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(199, 39);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "更新檔案列表";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click_1);
            // 
            // Filelst3
            // 
            this.Filelst3.FormattingEnabled = true;
            this.Filelst3.ItemHeight = 12;
            this.Filelst3.Location = new System.Drawing.Point(912, 22);
            this.Filelst3.Name = "Filelst3";
            this.Filelst3.Size = new System.Drawing.Size(302, 352);
            this.Filelst3.TabIndex = 6;
            // 
            // Filelst2
            // 
            this.Filelst2.FormattingEnabled = true;
            this.Filelst2.ItemHeight = 12;
            this.Filelst2.Location = new System.Drawing.Point(582, 22);
            this.Filelst2.Name = "Filelst2";
            this.Filelst2.Size = new System.Drawing.Size(302, 352);
            this.Filelst2.TabIndex = 6;
            // 
            // Filelst
            // 
            this.Filelst.FormattingEnabled = true;
            this.Filelst.ItemHeight = 12;
            this.Filelst.Location = new System.Drawing.Point(6, 22);
            this.Filelst.Name = "Filelst";
            this.Filelst.Size = new System.Drawing.Size(302, 352);
            this.Filelst.TabIndex = 7;
            // 
            // TPViewer
            // 
            this.TPViewer.Controls.Add(this.lblViewStatus);
            this.TPViewer.Controls.Add(this.gpViewer);
            this.TPViewer.Controls.Add(this.btnBalance);
            this.TPViewer.Controls.Add(this.btnView);
            this.TPViewer.Controls.Add(this.dgTabView);
            this.TPViewer.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TPViewer.Location = new System.Drawing.Point(4, 22);
            this.TPViewer.Name = "TPViewer";
            this.TPViewer.Padding = new System.Windows.Forms.Padding(3);
            this.TPViewer.Size = new System.Drawing.Size(1362, 723);
            this.TPViewer.TabIndex = 5;
            this.TPViewer.Text = "資料匯入勾稽比對";
            this.TPViewer.UseVisualStyleBackColor = true;
            // 
            // lblViewStatus
            // 
            this.lblViewStatus.AutoSize = true;
            this.lblViewStatus.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblViewStatus.Location = new System.Drawing.Point(387, 148);
            this.lblViewStatus.Name = "lblViewStatus";
            this.lblViewStatus.Size = new System.Drawing.Size(55, 19);
            this.lblViewStatus.TabIndex = 4;
            this.lblViewStatus.Text = "描述:";
            // 
            // gpViewer
            // 
            this.gpViewer.Controls.Add(this.radioBookItem);
            this.gpViewer.Controls.Add(this.radioBook);
            this.gpViewer.Location = new System.Drawing.Point(180, 21);
            this.gpViewer.Name = "gpViewer";
            this.gpViewer.Size = new System.Drawing.Size(200, 150);
            this.gpViewer.TabIndex = 3;
            this.gpViewer.TabStop = false;
            // 
            // radioBookItem
            // 
            this.radioBookItem.AutoSize = true;
            this.radioBookItem.Location = new System.Drawing.Point(6, 50);
            this.radioBookItem.Name = "radioBookItem";
            this.radioBookItem.Size = new System.Drawing.Size(138, 23);
            this.radioBookItem.TabIndex = 3;
            this.radioBookItem.Text = "BookItemView";
            this.radioBookItem.UseVisualStyleBackColor = true;
            this.radioBookItem.Visible = false;
            // 
            // radioBook
            // 
            this.radioBook.AutoSize = true;
            this.radioBook.Checked = true;
            this.radioBook.Location = new System.Drawing.Point(6, 21);
            this.radioBook.Name = "radioBook";
            this.radioBook.Size = new System.Drawing.Size(103, 23);
            this.radioBook.TabIndex = 3;
            this.radioBook.TabStop = true;
            this.radioBook.Text = "檢視帳務";
            this.radioBook.UseVisualStyleBackColor = true;
            // 
            // btnBalance
            // 
            this.btnBalance.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBalance.Location = new System.Drawing.Point(33, 99);
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.Size = new System.Drawing.Size(141, 52);
            this.btnBalance.TabIndex = 1;
            this.btnBalance.Text = "平衡帳務";
            this.btnBalance.UseVisualStyleBackColor = true;
            this.btnBalance.Click += new System.EventHandler(this.btnBalance_Click);
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnView.Location = new System.Drawing.Point(33, 31);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(141, 52);
            this.btnView.TabIndex = 1;
            this.btnView.Text = "檢視差異帳務";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // dgTabView
            // 
            this.dgTabView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgTabView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTabView.Location = new System.Drawing.Point(6, 177);
            this.dgTabView.Name = "dgTabView";
            this.dgTabView.RowTemplate.Height = 24;
            this.dgTabView.Size = new System.Drawing.Size(1242, 529);
            this.dgTabView.TabIndex = 0;
            // 
            // DiaryBook
            // 
            this.DiaryBook.Controls.Add(this.txAccInputdgAcc);
            this.DiaryBook.Controls.Add(this.lblAccInputdgAcc);
            this.DiaryBook.Controls.Add(this.btnAccGenerate);
            this.DiaryBook.Controls.Add(this.lblAccInputYear);
            this.DiaryBook.Controls.Add(this.txAccYear);
            this.DiaryBook.Controls.Add(this.txAccMonth);
            this.DiaryBook.Controls.Add(this.label9);
            this.DiaryBook.Controls.Add(this.btnInteliAccDelete);
            this.DiaryBook.Controls.Add(this.btnAccInputCost);
            this.DiaryBook.Controls.Add(this.btnAccConfirm);
            this.DiaryBook.Controls.Add(this.dgAccAccountsData);
            this.DiaryBook.Controls.Add(this.plAccInputPanel);
            this.DiaryBook.Controls.Add(this.dgCostItemView);
            this.DiaryBook.Location = new System.Drawing.Point(4, 22);
            this.DiaryBook.Name = "DiaryBook";
            this.DiaryBook.Padding = new System.Windows.Forms.Padding(3);
            this.DiaryBook.Size = new System.Drawing.Size(1362, 723);
            this.DiaryBook.TabIndex = 20;
            this.DiaryBook.Text = "智慧帳冊";
            this.DiaryBook.UseVisualStyleBackColor = true;
            // 
            // txAccInputdgAcc
            // 
            this.txAccInputdgAcc.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txAccInputdgAcc.Location = new System.Drawing.Point(64, 428);
            this.txAccInputdgAcc.Name = "txAccInputdgAcc";
            this.txAccInputdgAcc.Size = new System.Drawing.Size(167, 30);
            this.txAccInputdgAcc.TabIndex = 40;
            // 
            // lblAccInputdgAcc
            // 
            this.lblAccInputdgAcc.AutoSize = true;
            this.lblAccInputdgAcc.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAccInputdgAcc.Location = new System.Drawing.Point(9, 434);
            this.lblAccInputdgAcc.Name = "lblAccInputdgAcc";
            this.lblAccInputdgAcc.Size = new System.Drawing.Size(49, 19);
            this.lblAccInputdgAcc.TabIndex = 39;
            this.lblAccInputdgAcc.Text = "傳票";
            // 
            // btnAccGenerate
            // 
            this.btnAccGenerate.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAccGenerate.Location = new System.Drawing.Point(1286, 416);
            this.btnAccGenerate.Name = "btnAccGenerate";
            this.btnAccGenerate.Size = new System.Drawing.Size(146, 52);
            this.btnAccGenerate.TabIndex = 38;
            this.btnAccGenerate.Text = "產生";
            this.btnAccGenerate.UseVisualStyleBackColor = true;
            this.btnAccGenerate.Click += new System.EventHandler(this.btnAccGenerate_Click);
            // 
            // lblAccInputYear
            // 
            this.lblAccInputYear.AutoSize = true;
            this.lblAccInputYear.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAccInputYear.Location = new System.Drawing.Point(1290, 474);
            this.lblAccInputYear.Name = "lblAccInputYear";
            this.lblAccInputYear.Size = new System.Drawing.Size(49, 19);
            this.lblAccInputYear.TabIndex = 37;
            this.lblAccInputYear.Text = "年份";
            // 
            // txAccYear
            // 
            this.txAccYear.Location = new System.Drawing.Point(1290, 499);
            this.txAccYear.Name = "txAccYear";
            this.txAccYear.Size = new System.Drawing.Size(142, 22);
            this.txAccYear.TabIndex = 35;
            // 
            // txAccMonth
            // 
            this.txAccMonth.Location = new System.Drawing.Point(1290, 546);
            this.txAccMonth.Name = "txAccMonth";
            this.txAccMonth.Size = new System.Drawing.Size(142, 22);
            this.txAccMonth.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(1290, 524);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 19);
            this.label9.TabIndex = 34;
            this.label9.Text = "月份";
            // 
            // btnInteliAccDelete
            // 
            this.btnInteliAccDelete.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnInteliAccDelete.Location = new System.Drawing.Point(365, 416);
            this.btnInteliAccDelete.Name = "btnInteliAccDelete";
            this.btnInteliAccDelete.Size = new System.Drawing.Size(120, 52);
            this.btnInteliAccDelete.TabIndex = 32;
            this.btnInteliAccDelete.Text = "刪除";
            this.btnInteliAccDelete.UseVisualStyleBackColor = true;
            this.btnInteliAccDelete.Click += new System.EventHandler(this.btnInteliAccDelete_Click);
            // 
            // btnAccInputCost
            // 
            this.btnAccInputCost.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAccInputCost.Location = new System.Drawing.Point(252, 416);
            this.btnAccInputCost.Name = "btnAccInputCost";
            this.btnAccInputCost.Size = new System.Drawing.Size(107, 52);
            this.btnAccInputCost.TabIndex = 32;
            this.btnAccInputCost.Text = "查詢傳票";
            this.btnAccInputCost.UseVisualStyleBackColor = true;
            this.btnAccInputCost.Click += new System.EventHandler(this.btnAccInputCost_Click);
            // 
            // btnAccConfirm
            // 
            this.btnAccConfirm.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAccConfirm.Location = new System.Drawing.Point(675, 416);
            this.btnAccConfirm.Name = "btnAccConfirm";
            this.btnAccConfirm.Size = new System.Drawing.Size(609, 52);
            this.btnAccConfirm.TabIndex = 32;
            this.btnAccConfirm.Text = "確認";
            this.btnAccConfirm.UseVisualStyleBackColor = true;
            this.btnAccConfirm.Click += new System.EventHandler(this.btnAccConfirm_Click);
            // 
            // dgAccAccountsData
            // 
            this.dgAccAccountsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAccAccountsData.Location = new System.Drawing.Point(6, 229);
            this.dgAccAccountsData.Name = "dgAccAccountsData";
            this.dgAccAccountsData.RowTemplate.Height = 24;
            this.dgAccAccountsData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAccAccountsData.Size = new System.Drawing.Size(1278, 181);
            this.dgAccAccountsData.TabIndex = 33;
            this.dgAccAccountsData.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgAccAccountsData_CellMouseClick);
            this.dgAccAccountsData.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAccAccountsData_RowEnter);
            this.dgAccAccountsData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgAccAccountsData_KeyDown);
            // 
            // plAccInputPanel
            // 
            this.plAccInputPanel.Controls.Add(this.btnAccInputNew);
            this.plAccInputPanel.Controls.Add(this.btnAccQuery);
            this.plAccInputPanel.Controls.Add(this.btnAccInputSave);
            this.plAccInputPanel.Controls.Add(this.btnDelete);
            this.plAccInputPanel.Controls.Add(this.btnClear);
            this.plAccInputPanel.Controls.Add(this.btnAccInputRecord);
            this.plAccInputPanel.Controls.Add(this.btnDiarySelection);
            this.plAccInputPanel.Controls.Add(this.label18);
            this.plAccInputPanel.Controls.Add(this.lblInputPos);
            this.plAccInputPanel.Controls.Add(this.txDiaAccNo);
            this.plAccInputPanel.Controls.Add(this.txDiaAccDesc);
            this.plAccInputPanel.Controls.Add(this.txAccDatatype);
            this.plAccInputPanel.Controls.Add(this.txDiaAmount);
            this.plAccInputPanel.Controls.Add(this.lblDiary);
            this.plAccInputPanel.Controls.Add(this.txDiaAccID);
            this.plAccInputPanel.Controls.Add(this.lblDiaryAmount);
            this.plAccInputPanel.Controls.Add(this.label17);
            this.plAccInputPanel.Controls.Add(this.label16);
            this.plAccInputPanel.Controls.Add(this.lblAccInputPos);
            this.plAccInputPanel.Controls.Add(this.lblSuggestResult);
            this.plAccInputPanel.Controls.Add(this.lblWhereInput);
            this.plAccInputPanel.Controls.Add(this.lblaccsuggest);
            this.plAccInputPanel.Controls.Add(this.lblDiaNoValue);
            this.plAccInputPanel.Controls.Add(this.lblDiaNo);
            this.plAccInputPanel.Controls.Add(this.lblDiaryDate);
            this.plAccInputPanel.Controls.Add(this.label15);
            this.plAccInputPanel.Controls.Add(this.dtAccPicker);
            this.plAccInputPanel.Location = new System.Drawing.Point(6, 6);
            this.plAccInputPanel.Name = "plAccInputPanel";
            this.plAccInputPanel.Size = new System.Drawing.Size(1278, 217);
            this.plAccInputPanel.TabIndex = 21;
            this.plAccInputPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnAccInputNew
            // 
            this.btnAccInputNew.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAccInputNew.Location = new System.Drawing.Point(7, 92);
            this.btnAccInputNew.Name = "btnAccInputNew";
            this.btnAccInputNew.Size = new System.Drawing.Size(251, 38);
            this.btnAccInputNew.TabIndex = 32;
            this.btnAccInputNew.Text = "新增";
            this.btnAccInputNew.UseVisualStyleBackColor = true;
            this.btnAccInputNew.Click += new System.EventHandler(this.btnAccInputNew_Click);
            // 
            // btnAccQuery
            // 
            this.btnAccQuery.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAccQuery.Location = new System.Drawing.Point(732, 92);
            this.btnAccQuery.Name = "btnAccQuery";
            this.btnAccQuery.Size = new System.Drawing.Size(217, 39);
            this.btnAccQuery.TabIndex = 32;
            this.btnAccQuery.Text = "查詢帳目";
            this.btnAccQuery.UseVisualStyleBackColor = true;
            this.btnAccQuery.Click += new System.EventHandler(this.btnAccQuery_Click);
            // 
            // btnAccInputSave
            // 
            this.btnAccInputSave.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAccInputSave.Location = new System.Drawing.Point(508, 92);
            this.btnAccInputSave.Name = "btnAccInputSave";
            this.btnAccInputSave.Size = new System.Drawing.Size(217, 39);
            this.btnAccInputSave.TabIndex = 32;
            this.btnAccInputSave.Text = "存檔";
            this.btnAccInputSave.UseVisualStyleBackColor = true;
            this.btnAccInputSave.Click += new System.EventHandler(this.btnAccInputSave_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelete.Location = new System.Drawing.Point(508, 144);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(217, 39);
            this.btnDelete.TabIndex = 32;
            this.btnDelete.Text = "刪除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClear.Location = new System.Drawing.Point(285, 143);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(217, 39);
            this.btnClear.TabIndex = 32;
            this.btnClear.Text = "清除";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAccInputRecord
            // 
            this.btnAccInputRecord.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAccInputRecord.Location = new System.Drawing.Point(285, 92);
            this.btnAccInputRecord.Name = "btnAccInputRecord";
            this.btnAccInputRecord.Size = new System.Drawing.Size(217, 39);
            this.btnAccInputRecord.TabIndex = 32;
            this.btnAccInputRecord.Text = "記錄";
            this.btnAccInputRecord.UseVisualStyleBackColor = true;
            this.btnAccInputRecord.Click += new System.EventHandler(this.btnAccInputSave_Click);
            // 
            // btnDiarySelection
            // 
            this.btnDiarySelection.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDiarySelection.Location = new System.Drawing.Point(669, 56);
            this.btnDiarySelection.Name = "btnDiarySelection";
            this.btnDiarySelection.Size = new System.Drawing.Size(67, 29);
            this.btnDiarySelection.TabIndex = 32;
            this.btnDiarySelection.Text = "...";
            this.btnDiarySelection.UseVisualStyleBackColor = true;
            this.btnDiarySelection.Click += new System.EventHandler(this.btnDiarySelection_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label18.Location = new System.Drawing.Point(975, 18);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 19);
            this.label18.TabIndex = 31;
            this.label18.Text = "種類";
            // 
            // lblInputPos
            // 
            this.lblInputPos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.lblInputPos.FormattingEnabled = true;
            this.lblInputPos.Items.AddRange(new object[] {
            "薪資",
            "辦公租金",
            "業務支出",
            "勞健保",
            "Office365",
            "營業地租金",
            "yes123人力銀行",
            "廣告費網站",
            "電話費",
            "有線電話"});
            this.lblInputPos.Location = new System.Drawing.Point(1030, 16);
            this.lblInputPos.Name = "lblInputPos";
            this.lblInputPos.Size = new System.Drawing.Size(200, 186);
            this.lblInputPos.TabIndex = 30;
            this.lblInputPos.SelectedIndexChanged += new System.EventHandler(this.coSelectLink_SelectedIndexChanged);
            // 
            // txDiaAccNo
            // 
            this.txDiaAccNo.Location = new System.Drawing.Point(336, 20);
            this.txDiaAccNo.Name = "txDiaAccNo";
            this.txDiaAccNo.Size = new System.Drawing.Size(125, 22);
            this.txDiaAccNo.TabIndex = 27;
            // 
            // txDiaAccDesc
            // 
            this.txDiaAccDesc.Location = new System.Drawing.Point(783, 16);
            this.txDiaAccDesc.Multiline = true;
            this.txDiaAccDesc.Name = "txDiaAccDesc";
            this.txDiaAccDesc.Size = new System.Drawing.Size(181, 70);
            this.txDiaAccDesc.TabIndex = 28;
            this.txDiaAccDesc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txDiaAccDesc_KeyDown);
            // 
            // txAccDatatype
            // 
            this.txAccDatatype.Location = new System.Drawing.Point(539, 62);
            this.txAccDatatype.Name = "txAccDatatype";
            this.txAccDatatype.Size = new System.Drawing.Size(124, 22);
            this.txAccDatatype.TabIndex = 29;
            // 
            // txDiaAmount
            // 
            this.txDiaAmount.Location = new System.Drawing.Point(336, 64);
            this.txDiaAmount.Name = "txDiaAmount";
            this.txDiaAmount.Size = new System.Drawing.Size(124, 22);
            this.txDiaAmount.TabIndex = 29;
            this.txDiaAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txDiaAmount_KeyDown);
            // 
            // lblDiary
            // 
            this.lblDiary.AutoSize = true;
            this.lblDiary.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDiary.Location = new System.Drawing.Point(482, 64);
            this.lblDiary.Name = "lblDiary";
            this.lblDiary.Size = new System.Drawing.Size(55, 19);
            this.lblDiary.TabIndex = 25;
            this.lblDiary.Text = "借/貸";
            // 
            // txDiaAccID
            // 
            this.txDiaAccID.Location = new System.Drawing.Point(574, 20);
            this.txDiaAccID.Name = "txDiaAccID";
            this.txDiaAccID.Size = new System.Drawing.Size(138, 22);
            this.txDiaAccID.TabIndex = 29;
            // 
            // lblDiaryAmount
            // 
            this.lblDiaryAmount.AutoSize = true;
            this.lblDiaryAmount.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDiaryAmount.Location = new System.Drawing.Point(283, 67);
            this.lblDiaryAmount.Name = "lblDiaryAmount";
            this.lblDiaryAmount.Size = new System.Drawing.Size(49, 19);
            this.lblDiaryAmount.TabIndex = 25;
            this.lblDiaryAmount.Text = "金額";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label17.Location = new System.Drawing.Point(728, 20);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 19);
            this.label17.TabIndex = 24;
            this.label17.Text = "摘要";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label16.Location = new System.Drawing.Point(479, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(89, 19);
            this.label16.TabIndex = 25;
            this.label16.Text = "會計科目";
            // 
            // lblAccInputPos
            // 
            this.lblAccInputPos.AutoSize = true;
            this.lblAccInputPos.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAccInputPos.Location = new System.Drawing.Point(59, 183);
            this.lblAccInputPos.Name = "lblAccInputPos";
            this.lblAccInputPos.Size = new System.Drawing.Size(69, 19);
            this.lblAccInputPos.TabIndex = 26;
            this.lblAccInputPos.Text = "          ";
            // 
            // lblSuggestResult
            // 
            this.lblSuggestResult.AutoSize = true;
            this.lblSuggestResult.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSuggestResult.Location = new System.Drawing.Point(58, 143);
            this.lblSuggestResult.Name = "lblSuggestResult";
            this.lblSuggestResult.Size = new System.Drawing.Size(69, 19);
            this.lblSuggestResult.TabIndex = 26;
            this.lblSuggestResult.Text = "          ";
            // 
            // lblWhereInput
            // 
            this.lblWhereInput.AutoSize = true;
            this.lblWhereInput.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblWhereInput.Location = new System.Drawing.Point(3, 183);
            this.lblWhereInput.Name = "lblWhereInput";
            this.lblWhereInput.Size = new System.Drawing.Size(55, 19);
            this.lblWhereInput.TabIndex = 26;
            this.lblWhereInput.Text = "位置:";
            // 
            // lblaccsuggest
            // 
            this.lblaccsuggest.AutoSize = true;
            this.lblaccsuggest.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblaccsuggest.Location = new System.Drawing.Point(3, 144);
            this.lblaccsuggest.Name = "lblaccsuggest";
            this.lblaccsuggest.Size = new System.Drawing.Size(55, 19);
            this.lblaccsuggest.TabIndex = 26;
            this.lblaccsuggest.Text = "建議:";
            // 
            // lblDiaNoValue
            // 
            this.lblDiaNoValue.AutoSize = true;
            this.lblDiaNoValue.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDiaNoValue.Location = new System.Drawing.Point(58, 61);
            this.lblDiaNoValue.Name = "lblDiaNoValue";
            this.lblDiaNoValue.Size = new System.Drawing.Size(46, 19);
            this.lblDiaNoValue.TabIndex = 26;
            this.lblDiaNoValue.Text = "New";
            // 
            // lblDiaNo
            // 
            this.lblDiaNo.AutoSize = true;
            this.lblDiaNo.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDiaNo.Location = new System.Drawing.Point(3, 62);
            this.lblDiaNo.Name = "lblDiaNo";
            this.lblDiaNo.Size = new System.Drawing.Size(49, 19);
            this.lblDiaNo.TabIndex = 26;
            this.lblDiaNo.Text = "編號";
            // 
            // lblDiaryDate
            // 
            this.lblDiaryDate.AutoSize = true;
            this.lblDiaryDate.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDiaryDate.Location = new System.Drawing.Point(3, 20);
            this.lblDiaryDate.Name = "lblDiaryDate";
            this.lblDiaryDate.Size = new System.Drawing.Size(49, 19);
            this.lblDiaryDate.TabIndex = 26;
            this.lblDiaryDate.Text = "日期";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label15.Location = new System.Drawing.Point(281, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 19);
            this.label15.TabIndex = 26;
            this.label15.Text = "傳票";
            // 
            // dtAccPicker
            // 
            this.dtAccPicker.Location = new System.Drawing.Point(58, 18);
            this.dtAccPicker.Name = "dtAccPicker";
            this.dtAccPicker.Size = new System.Drawing.Size(200, 22);
            this.dtAccPicker.TabIndex = 21;
            this.dtAccPicker.ValueChanged += new System.EventHandler(this.dtAccPicker_ValueChanged);
            // 
            // dgCostItemView
            // 
            this.dgCostItemView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCostItemView.Location = new System.Drawing.Point(3, 474);
            this.dgCostItemView.Name = "dgCostItemView";
            this.dgCostItemView.RowTemplate.Height = 24;
            this.dgCostItemView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCostItemView.Size = new System.Drawing.Size(1281, 464);
            this.dgCostItemView.TabIndex = 0;
            this.dgCostItemView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgCostItemView_CellMouseClick);
            this.dgCostItemView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCostItemView_RowEnter);
            this.dgCostItemView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgCostItemView_KeyDown);
            // 
            // TPQuery
            // 
            this.TPQuery.Controls.Add(this.lblBookLend);
            this.TPQuery.Controls.Add(this.lblBookTitleGet);
            this.TPQuery.Controls.Add(this.lblBookGet);
            this.TPQuery.Controls.Add(this.lblBookTitleLend);
            this.TPQuery.Controls.Add(this.chQueryAcc);
            this.TPQuery.Controls.Add(this.lblQueryAccYear);
            this.TPQuery.Controls.Add(this.dgQueryData);
            this.TPQuery.Controls.Add(this.btnDiaryExport);
            this.TPQuery.Controls.Add(this.btnDiaryCreate);
            this.TPQuery.Controls.Add(this.btnDeleteQueryAcc);
            this.TPQuery.Controls.Add(this.btnQuery);
            this.TPQuery.Controls.Add(this.txQueryAccYear);
            this.TPQuery.Controls.Add(this.txQueryAccMonth);
            this.TPQuery.Controls.Add(this.lblQueryAccMonth);
            this.TPQuery.Location = new System.Drawing.Point(4, 22);
            this.TPQuery.Name = "TPQuery";
            this.TPQuery.Size = new System.Drawing.Size(1362, 723);
            this.TPQuery.TabIndex = 2;
            this.TPQuery.Text = "智慧帳冊月管理";
            this.TPQuery.UseVisualStyleBackColor = true;
            // 
            // lblBookLend
            // 
            this.lblBookLend.AutoSize = true;
            this.lblBookLend.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblBookLend.Location = new System.Drawing.Point(1257, 86);
            this.lblBookLend.Name = "lblBookLend";
            this.lblBookLend.Size = new System.Drawing.Size(23, 19);
            this.lblBookLend.TabIndex = 30;
            this.lblBookLend.Text = "X";
            // 
            // lblBookTitleGet
            // 
            this.lblBookTitleGet.AutoSize = true;
            this.lblBookTitleGet.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblBookTitleGet.Location = new System.Drawing.Point(1213, 52);
            this.lblBookTitleGet.Name = "lblBookTitleGet";
            this.lblBookTitleGet.Size = new System.Drawing.Size(49, 19);
            this.lblBookTitleGet.TabIndex = 31;
            this.lblBookTitleGet.Text = "借：";
            // 
            // lblBookGet
            // 
            this.lblBookGet.AutoSize = true;
            this.lblBookGet.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblBookGet.Location = new System.Drawing.Point(1257, 52);
            this.lblBookGet.Name = "lblBookGet";
            this.lblBookGet.Size = new System.Drawing.Size(23, 19);
            this.lblBookGet.TabIndex = 32;
            this.lblBookGet.Text = "X";
            // 
            // lblBookTitleLend
            // 
            this.lblBookTitleLend.AutoSize = true;
            this.lblBookTitleLend.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblBookTitleLend.Location = new System.Drawing.Point(1213, 86);
            this.lblBookTitleLend.Name = "lblBookTitleLend";
            this.lblBookTitleLend.Size = new System.Drawing.Size(49, 19);
            this.lblBookTitleLend.TabIndex = 33;
            this.lblBookTitleLend.Text = "貸：";
            // 
            // chQueryAcc
            // 
            this.chQueryAcc.AutoSize = true;
            this.chQueryAcc.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chQueryAcc.Location = new System.Drawing.Point(1054, 52);
            this.chQueryAcc.Name = "chQueryAcc";
            this.chQueryAcc.Size = new System.Drawing.Size(104, 23);
            this.chQueryAcc.TabIndex = 29;
            this.chQueryAcc.Text = "強制清除";
            this.chQueryAcc.UseVisualStyleBackColor = true;
            this.chQueryAcc.Visible = false;
            // 
            // lblQueryAccYear
            // 
            this.lblQueryAccYear.AutoSize = true;
            this.lblQueryAccYear.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblQueryAccYear.Location = new System.Drawing.Point(17, 19);
            this.lblQueryAccYear.Name = "lblQueryAccYear";
            this.lblQueryAccYear.Size = new System.Drawing.Size(49, 19);
            this.lblQueryAccYear.TabIndex = 28;
            this.lblQueryAccYear.Text = "年份";
            // 
            // dgQueryData
            // 
            this.dgQueryData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgQueryData.Location = new System.Drawing.Point(21, 75);
            this.dgQueryData.Name = "dgQueryData";
            this.dgQueryData.RowTemplate.Height = 24;
            this.dgQueryData.Size = new System.Drawing.Size(1186, 710);
            this.dgQueryData.TabIndex = 21;
            // 
            // btnDiaryExport
            // 
            this.btnDiaryExport.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDiaryExport.Location = new System.Drawing.Point(901, 5);
            this.btnDiaryExport.Name = "btnDiaryExport";
            this.btnDiaryExport.Size = new System.Drawing.Size(146, 64);
            this.btnDiaryExport.TabIndex = 18;
            this.btnDiaryExport.Text = "匯出";
            this.btnDiaryExport.UseVisualStyleBackColor = true;
            this.btnDiaryExport.Click += new System.EventHandler(this.btnDiaryExport_Click);
            // 
            // btnDiaryCreate
            // 
            this.btnDiaryCreate.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDiaryCreate.Location = new System.Drawing.Point(749, 5);
            this.btnDiaryCreate.Name = "btnDiaryCreate";
            this.btnDiaryCreate.Size = new System.Drawing.Size(146, 64);
            this.btnDiaryCreate.TabIndex = 18;
            this.btnDiaryCreate.Text = "帳務建立";
            this.btnDiaryCreate.UseVisualStyleBackColor = true;
            this.btnDiaryCreate.Click += new System.EventHandler(this.btnDiaryCreate_Click);
            // 
            // btnDeleteQueryAcc
            // 
            this.btnDeleteQueryAcc.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDeleteQueryAcc.Location = new System.Drawing.Point(591, 5);
            this.btnDeleteQueryAcc.Name = "btnDeleteQueryAcc";
            this.btnDeleteQueryAcc.Size = new System.Drawing.Size(152, 64);
            this.btnDeleteQueryAcc.TabIndex = 18;
            this.btnDeleteQueryAcc.Text = "刪除";
            this.btnDeleteQueryAcc.UseVisualStyleBackColor = true;
            this.btnDeleteQueryAcc.Click += new System.EventHandler(this.btnDeleteQueryAcc_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnQuery.Location = new System.Drawing.Point(423, 5);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(162, 64);
            this.btnQuery.TabIndex = 18;
            this.btnQuery.Text = "查詢";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // txQueryAccYear
            // 
            this.txQueryAccYear.Location = new System.Drawing.Point(72, 16);
            this.txQueryAccYear.Name = "txQueryAccYear";
            this.txQueryAccYear.Size = new System.Drawing.Size(142, 22);
            this.txQueryAccYear.TabIndex = 17;
            // 
            // txQueryAccMonth
            // 
            this.txQueryAccMonth.Location = new System.Drawing.Point(275, 16);
            this.txQueryAccMonth.Name = "txQueryAccMonth";
            this.txQueryAccMonth.Size = new System.Drawing.Size(142, 22);
            this.txQueryAccMonth.TabIndex = 17;
            // 
            // lblQueryAccMonth
            // 
            this.lblQueryAccMonth.AutoSize = true;
            this.lblQueryAccMonth.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblQueryAccMonth.Location = new System.Drawing.Point(220, 19);
            this.lblQueryAccMonth.Name = "lblQueryAccMonth";
            this.lblQueryAccMonth.Size = new System.Drawing.Size(49, 19);
            this.lblQueryAccMonth.TabIndex = 16;
            this.lblQueryAccMonth.Text = "月份";
            // 
            // TPAccountLedger
            // 
            this.TPAccountLedger.Controls.Add(this.btnALegerQuery);
            this.TPAccountLedger.Controls.Add(this.btnGenerate);
            this.TPAccountLedger.Controls.Add(this.lblLedgerLend);
            this.TPAccountLedger.Controls.Add(this.lblLedgerResult);
            this.TPAccountLedger.Controls.Add(this.lblGet);
            this.TPAccountLedger.Controls.Add(this.lblLedgerGetVal);
            this.TPAccountLedger.Controls.Add(this.lblLend);
            this.TPAccountLedger.Controls.Add(this.dgLedger);
            this.TPAccountLedger.Location = new System.Drawing.Point(4, 22);
            this.TPAccountLedger.Name = "TPAccountLedger";
            this.TPAccountLedger.Padding = new System.Windows.Forms.Padding(3);
            this.TPAccountLedger.Size = new System.Drawing.Size(1362, 723);
            this.TPAccountLedger.TabIndex = 6;
            this.TPAccountLedger.Text = "會計金額結算";
            this.TPAccountLedger.UseVisualStyleBackColor = true;
            // 
            // btnALegerQuery
            // 
            this.btnALegerQuery.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnALegerQuery.Location = new System.Drawing.Point(847, 6);
            this.btnALegerQuery.Name = "btnALegerQuery";
            this.btnALegerQuery.Size = new System.Drawing.Size(125, 62);
            this.btnALegerQuery.TabIndex = 2;
            this.btnALegerQuery.Text = "查詢";
            this.btnALegerQuery.UseVisualStyleBackColor = true;
            this.btnALegerQuery.Click += new System.EventHandler(this.btnALegerQuery_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnGenerate.Location = new System.Drawing.Point(716, 6);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(125, 62);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "產生";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblLedgerLend
            // 
            this.lblLedgerLend.AutoSize = true;
            this.lblLedgerLend.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblLedgerLend.Location = new System.Drawing.Point(294, 42);
            this.lblLedgerLend.Name = "lblLedgerLend";
            this.lblLedgerLend.Size = new System.Drawing.Size(23, 19);
            this.lblLedgerLend.TabIndex = 1;
            this.lblLedgerLend.Text = "X";
            // 
            // lblLedgerResult
            // 
            this.lblLedgerResult.AutoSize = true;
            this.lblLedgerResult.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblLedgerResult.Location = new System.Drawing.Point(474, 42);
            this.lblLedgerResult.Name = "lblLedgerResult";
            this.lblLedgerResult.Size = new System.Drawing.Size(69, 19);
            this.lblLedgerResult.TabIndex = 1;
            this.lblLedgerResult.Text = "結果：";
            // 
            // lblGet
            // 
            this.lblGet.AutoSize = true;
            this.lblGet.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblGet.Location = new System.Drawing.Point(6, 42);
            this.lblGet.Name = "lblGet";
            this.lblGet.Size = new System.Drawing.Size(49, 19);
            this.lblGet.TabIndex = 1;
            this.lblGet.Text = "借：";
            // 
            // lblLedgerGetVal
            // 
            this.lblLedgerGetVal.AutoSize = true;
            this.lblLedgerGetVal.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblLedgerGetVal.Location = new System.Drawing.Point(50, 42);
            this.lblLedgerGetVal.Name = "lblLedgerGetVal";
            this.lblLedgerGetVal.Size = new System.Drawing.Size(23, 19);
            this.lblLedgerGetVal.TabIndex = 1;
            this.lblLedgerGetVal.Text = "X";
            // 
            // lblLend
            // 
            this.lblLend.AutoSize = true;
            this.lblLend.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblLend.Location = new System.Drawing.Point(246, 42);
            this.lblLend.Name = "lblLend";
            this.lblLend.Size = new System.Drawing.Size(49, 19);
            this.lblLend.TabIndex = 1;
            this.lblLend.Text = "貸：";
            // 
            // dgLedger
            // 
            this.dgLedger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLedger.Location = new System.Drawing.Point(20, 74);
            this.dgLedger.Name = "dgLedger";
            this.dgLedger.RowTemplate.Height = 24;
            this.dgLedger.Size = new System.Drawing.Size(1311, 617);
            this.dgLedger.TabIndex = 0;
            this.dgLedger.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgLedger_CellFormatting);
            this.dgLedger.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgLedger_RowsAdded);
            this.dgLedger.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgLedger_UserAddedRow);
            // 
            // TPClassType
            // 
            this.TPClassType.Controls.Add(this.coClassType);
            this.TPClassType.Controls.Add(this.dgClassData);
            this.TPClassType.Controls.Add(this.btnClassUpdate);
            this.TPClassType.Controls.Add(this.btnClassAdd);
            this.TPClassType.Controls.Add(this.lblSN);
            this.TPClassType.Controls.Add(this.lblClassTitle01);
            this.TPClassType.Controls.Add(this.lblClassName);
            this.TPClassType.Controls.Add(this.txClassNO);
            this.TPClassType.Controls.Add(this.txClassName);
            this.TPClassType.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TPClassType.Location = new System.Drawing.Point(4, 22);
            this.TPClassType.Name = "TPClassType";
            this.TPClassType.Padding = new System.Windows.Forms.Padding(3);
            this.TPClassType.Size = new System.Drawing.Size(1362, 723);
            this.TPClassType.TabIndex = 4;
            this.TPClassType.Text = "憑證類別管理";
            this.TPClassType.UseVisualStyleBackColor = true;
            // 
            // coClassType
            // 
            this.coClassType.FormattingEnabled = true;
            this.coClassType.Items.AddRange(new object[] {
            "會科類別",
            "憑證類別"});
            this.coClassType.Location = new System.Drawing.Point(241, 58);
            this.coClassType.Name = "coClassType";
            this.coClassType.Size = new System.Drawing.Size(121, 27);
            this.coClassType.TabIndex = 4;
            this.coClassType.SelectedValueChanged += new System.EventHandler(this.coClassType_SelectedValueChanged);
            // 
            // dgClassData
            // 
            this.dgClassData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgClassData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClassData.Location = new System.Drawing.Point(6, 94);
            this.dgClassData.Name = "dgClassData";
            this.dgClassData.RowTemplate.Height = 24;
            this.dgClassData.Size = new System.Drawing.Size(592, 576);
            this.dgClassData.TabIndex = 3;
            this.dgClassData.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgClassData_CellMouseDoubleClick);
            // 
            // btnClassUpdate
            // 
            this.btnClassUpdate.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClassUpdate.Location = new System.Drawing.Point(6, 50);
            this.btnClassUpdate.Name = "btnClassUpdate";
            this.btnClassUpdate.Size = new System.Drawing.Size(173, 38);
            this.btnClassUpdate.TabIndex = 2;
            this.btnClassUpdate.Text = "更新";
            this.btnClassUpdate.UseVisualStyleBackColor = true;
            this.btnClassUpdate.Click += new System.EventHandler(this.btnClassUpdate_Click);
            // 
            // btnClassAdd
            // 
            this.btnClassAdd.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClassAdd.Location = new System.Drawing.Point(6, 6);
            this.btnClassAdd.Name = "btnClassAdd";
            this.btnClassAdd.Size = new System.Drawing.Size(173, 38);
            this.btnClassAdd.TabIndex = 2;
            this.btnClassAdd.Text = "新增";
            this.btnClassAdd.UseVisualStyleBackColor = true;
            this.btnClassAdd.Click += new System.EventHandler(this.btnClassAdd_Click);
            // 
            // lblSN
            // 
            this.lblSN.AutoSize = true;
            this.lblSN.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSN.Location = new System.Drawing.Point(199, 20);
            this.lblSN.Name = "lblSN";
            this.lblSN.Size = new System.Drawing.Size(37, 19);
            this.lblSN.TabIndex = 1;
            this.lblSN.Text = "NO";
            // 
            // lblClassTitle01
            // 
            this.lblClassTitle01.AutoSize = true;
            this.lblClassTitle01.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblClassTitle01.Location = new System.Drawing.Point(186, 62);
            this.lblClassTitle01.Name = "lblClassTitle01";
            this.lblClassTitle01.Size = new System.Drawing.Size(49, 19);
            this.lblClassTitle01.TabIndex = 1;
            this.lblClassTitle01.Text = "型別";
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblClassName.Location = new System.Drawing.Point(368, 20);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(89, 19);
            this.lblClassName.TabIndex = 1;
            this.lblClassName.Text = "類別名稱";
            // 
            // txClassNO
            // 
            this.txClassNO.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txClassNO.Location = new System.Drawing.Point(241, 15);
            this.txClassNO.Name = "txClassNO";
            this.txClassNO.Size = new System.Drawing.Size(121, 27);
            this.txClassNO.TabIndex = 0;
            this.txClassNO.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txClassNO_KeyDown);
            // 
            // txClassName
            // 
            this.txClassName.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txClassName.Location = new System.Drawing.Point(463, 15);
            this.txClassName.Name = "txClassName";
            this.txClassName.Size = new System.Drawing.Size(119, 27);
            this.txClassName.TabIndex = 0;
            this.txClassName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txClassName_KeyDown);
            // 
            // TPClassDetail
            // 
            this.TPClassDetail.Controls.Add(this.masterCtl01);
            this.TPClassDetail.Location = new System.Drawing.Point(4, 22);
            this.TPClassDetail.Name = "TPClassDetail";
            this.TPClassDetail.Padding = new System.Windows.Forms.Padding(3);
            this.TPClassDetail.Size = new System.Drawing.Size(1362, 723);
            this.TPClassDetail.TabIndex = 10;
            this.TPClassDetail.Text = "帳務類別管理";
            this.TPClassDetail.UseVisualStyleBackColor = true;
            // 
            // masterCtl01
            // 
            this.masterCtl01.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.masterCtl01.dbclassctl = null;
            this.masterCtl01.Location = new System.Drawing.Point(6, 6);
            this.masterCtl01.Name = "masterCtl01";
            this.masterCtl01.Size = new System.Drawing.Size(1366, 737);
            this.masterCtl01.tab06 = null;
            this.masterCtl01.TabIndex = 0;
            // 
            // TPVerifyAcc
            // 
            this.TPVerifyAcc.Controls.Add(this.updateVerifyAcc);
            this.TPVerifyAcc.Location = new System.Drawing.Point(4, 22);
            this.TPVerifyAcc.Name = "TPVerifyAcc";
            this.TPVerifyAcc.Padding = new System.Windows.Forms.Padding(3);
            this.TPVerifyAcc.Size = new System.Drawing.Size(1362, 723);
            this.TPVerifyAcc.TabIndex = 8;
            this.TPVerifyAcc.Text = "帳目資料管理";
            this.TPVerifyAcc.UseVisualStyleBackColor = true;
            // 
            // updateVerifyAcc
            // 
            acc_VModel1.ctl01 = null;
            acc_VModel1.ctl02 = null;
            acc_VModel1.ctl03 = null;
            acc_VModel1.ctl05 = null;
            acc_VModel1.ctl06 = null;
            acc_VModel1.datatype = JINSHIN.FinanceAccount.Libary.Models.Base.AddQueryEnum.None;
            gridViewFinanceBase1.columns = null;
            gridViewFinanceBase1.datatype = JINSHIN.FinanceAccount.Libary.Models.Base.AddQueryEnum.None;
            gridViewFinanceBase1.gvComboList = null;
            acc_VModel1.gvb = gridViewFinanceBase1;
            acc_VModel1.ImportType = 0;
            this.updateVerifyAcc.Accctl = acc_VModel1;
            this.updateVerifyAcc.check = ((System.Collections.Generic.List<int>)(resources.GetObject("updateVerifyAcc.check")));
            this.updateVerifyAcc.Cnt = 150;
            this.updateVerifyAcc.comboli = ((System.Collections.Generic.List<int>)(resources.GetObject("updateVerifyAcc.comboli")));
            this.updateVerifyAcc.ctl01 = null;
            this.updateVerifyAcc.datatype = JINSHIN.FinanceAccount.Libary.Models.Base.AddQueryEnum.None;
            this.updateVerifyAcc.dataUpdateCenter = null;
            this.updateVerifyAcc.gvbase = null;
            this.updateVerifyAcc.gvdatatype = JINSHIN.FinanceAccount.Libary.Models.Base.AddQueryEnum.Acc_CostData;
            this.updateVerifyAcc.listboxSelect = ((System.Collections.Generic.List<int>)(resources.GetObject("updateVerifyAcc.listboxSelect")));
            this.updateVerifyAcc.Location = new System.Drawing.Point(6, 3);
            this.updateVerifyAcc.Name = "updateVerifyAcc";
            this.updateVerifyAcc.operations = null;
            this.updateVerifyAcc.Size = new System.Drawing.Size(1819, 919);
            this.updateVerifyAcc.TabIndex = 0;
            this.updateVerifyAcc.Load += new System.EventHandler(this.updateVerifyAcc_Load);
            // 
            // tbAccConfirm
            // 
            this.tbAccConfirm.Controls.Add(this.label12);
            this.tbAccConfirm.Controls.Add(this.lstAccConfirmMsg);
            this.tbAccConfirm.Controls.Add(this.chConfirmAll);
            this.tbAccConfirm.Controls.Add(this.lstVerifyAccds);
            this.tbAccConfirm.Controls.Add(this.lblLstAccIDs);
            this.tbAccConfirm.Controls.Add(this.dgControl);
            this.tbAccConfirm.Controls.Add(this.btnAnalyzeAccs);
            this.tbAccConfirm.Controls.Add(this.btnAccExport);
            this.tbAccConfirm.Controls.Add(this.btnConfirmQuery);
            this.tbAccConfirm.Controls.Add(this.btnVerify);
            this.tbAccConfirm.Controls.Add(this.btnCancel);
            this.tbAccConfirm.Location = new System.Drawing.Point(4, 22);
            this.tbAccConfirm.Name = "tbAccConfirm";
            this.tbAccConfirm.Padding = new System.Windows.Forms.Padding(3);
            this.tbAccConfirm.Size = new System.Drawing.Size(1362, 723);
            this.tbAccConfirm.TabIndex = 15;
            this.tbAccConfirm.Text = "會計科目勾稽功能";
            this.tbAccConfirm.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("新細明體", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(1508, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 20);
            this.label12.TabIndex = 48;
            this.label12.Text = "訊息";
            this.label12.Visible = false;
            // 
            // lstAccConfirmMsg
            // 
            this.lstAccConfirmMsg.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lstAccConfirmMsg.FormattingEnabled = true;
            this.lstAccConfirmMsg.ItemHeight = 19;
            this.lstAccConfirmMsg.Location = new System.Drawing.Point(1508, 104);
            this.lstAccConfirmMsg.Name = "lstAccConfirmMsg";
            this.lstAccConfirmMsg.Size = new System.Drawing.Size(284, 650);
            this.lstAccConfirmMsg.TabIndex = 47;
            this.lstAccConfirmMsg.Visible = false;
            // 
            // chConfirmAll
            // 
            this.chConfirmAll.AutoSize = true;
            this.chConfirmAll.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chConfirmAll.Location = new System.Drawing.Point(143, 9);
            this.chConfirmAll.Name = "chConfirmAll";
            this.chConfirmAll.Size = new System.Drawing.Size(104, 23);
            this.chConfirmAll.TabIndex = 46;
            this.chConfirmAll.Text = "全部顯示";
            this.chConfirmAll.UseVisualStyleBackColor = true;
            this.chConfirmAll.CheckedChanged += new System.EventHandler(this.chConfirmAll_CheckedChanged);
            // 
            // lstVerifyAccds
            // 
            this.lstVerifyAccds.ColumnWidth = 50;
            this.lstVerifyAccds.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lstVerifyAccds.FormattingEnabled = true;
            this.lstVerifyAccds.ItemHeight = 24;
            this.lstVerifyAccds.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.lstVerifyAccds.Location = new System.Drawing.Point(6, 37);
            this.lstVerifyAccds.Name = "lstVerifyAccds";
            this.lstVerifyAccds.Size = new System.Drawing.Size(238, 652);
            this.lstVerifyAccds.TabIndex = 45;
            // 
            // lblLstAccIDs
            // 
            this.lblLstAccIDs.AutoSize = true;
            this.lblLstAccIDs.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblLstAccIDs.Location = new System.Drawing.Point(6, 9);
            this.lblLstAccIDs.Name = "lblLstAccIDs";
            this.lblLstAccIDs.Size = new System.Drawing.Size(89, 19);
            this.lblLstAccIDs.TabIndex = 44;
            this.lblLstAccIDs.Text = "審核資訊";
            // 
            // dgControl
            // 
            this.dgControl.AllowUserToOrderColumns = true;
            this.dgControl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgControl.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgControl.Location = new System.Drawing.Point(250, 104);
            this.dgControl.Name = "dgControl";
            this.dgControl.RowTemplate.Height = 24;
            this.dgControl.Size = new System.Drawing.Size(1252, 662);
            this.dgControl.TabIndex = 43;
            // 
            // btnAnalyzeAccs
            // 
            this.btnAnalyzeAccs.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAnalyzeAccs.Location = new System.Drawing.Point(950, 18);
            this.btnAnalyzeAccs.Name = "btnAnalyzeAccs";
            this.btnAnalyzeAccs.Size = new System.Drawing.Size(165, 67);
            this.btnAnalyzeAccs.TabIndex = 38;
            this.btnAnalyzeAccs.Text = "分析";
            this.btnAnalyzeAccs.UseVisualStyleBackColor = true;
            this.btnAnalyzeAccs.Visible = false;
            this.btnAnalyzeAccs.Click += new System.EventHandler(this.btnAnalyzeAccs_Click);
            // 
            // btnAccExport
            // 
            this.btnAccExport.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAccExport.Location = new System.Drawing.Point(779, 18);
            this.btnAccExport.Name = "btnAccExport";
            this.btnAccExport.Size = new System.Drawing.Size(165, 67);
            this.btnAccExport.TabIndex = 38;
            this.btnAccExport.Text = "匯出";
            this.btnAccExport.UseVisualStyleBackColor = true;
            this.btnAccExport.Click += new System.EventHandler(this.btnAccExport_Click);
            // 
            // btnConfirmQuery
            // 
            this.btnConfirmQuery.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnConfirmQuery.Location = new System.Drawing.Point(608, 18);
            this.btnConfirmQuery.Name = "btnConfirmQuery";
            this.btnConfirmQuery.Size = new System.Drawing.Size(165, 67);
            this.btnConfirmQuery.TabIndex = 38;
            this.btnConfirmQuery.Text = "查詢";
            this.btnConfirmQuery.UseVisualStyleBackColor = true;
            this.btnConfirmQuery.Click += new System.EventHandler(this.btnConfirmQuery_Click);
            // 
            // btnVerify
            // 
            this.btnVerify.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnVerify.Location = new System.Drawing.Point(250, 19);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(165, 67);
            this.btnVerify.TabIndex = 37;
            this.btnVerify.Text = "確認";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancel.Location = new System.Drawing.Point(433, 19);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(165, 67);
            this.btnCancel.TabIndex = 37;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tabReport
            // 
            this.tabReport.Controls.Add(this.chDataFull);
            this.tabReport.Controls.Add(this.lblsettleMsg);
            this.tabReport.Controls.Add(this.LstFinanacialMsg);
            this.tabReport.Controls.Add(this.dataFinancialLedger);
            this.tabReport.Controls.Add(this.dgFinancialSettlGridView);
            this.tabReport.Controls.Add(this.btnCheckAccounts);
            this.tabReport.Controls.Add(this.btnArrangeNew);
            this.tabReport.Controls.Add(this.btnCheckAccNo);
            this.tabReport.Controls.Add(this.btnReportExportData);
            this.tabReport.Controls.Add(this.btnSetttleQuery);
            this.tabReport.Controls.Add(this.btnSettle);
            this.tabReport.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabReport.Location = new System.Drawing.Point(4, 22);
            this.tabReport.Name = "tabReport";
            this.tabReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabReport.Size = new System.Drawing.Size(1362, 723);
            this.tabReport.TabIndex = 17;
            this.tabReport.Text = "系統總帳管理";
            this.tabReport.UseVisualStyleBackColor = true;
            // 
            // chDataFull
            // 
            this.chDataFull.AutoSize = true;
            this.chDataFull.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chDataFull.Location = new System.Drawing.Point(456, 35);
            this.chDataFull.Name = "chDataFull";
            this.chDataFull.Size = new System.Drawing.Size(117, 26);
            this.chDataFull.TabIndex = 4;
            this.chDataFull.Text = "預先結算";
            this.chDataFull.UseVisualStyleBackColor = true;
            // 
            // lblsettleMsg
            // 
            this.lblsettleMsg.AutoSize = true;
            this.lblsettleMsg.Location = new System.Drawing.Point(850, 7);
            this.lblsettleMsg.Name = "lblsettleMsg";
            this.lblsettleMsg.Size = new System.Drawing.Size(47, 19);
            this.lblsettleMsg.TabIndex = 3;
            this.lblsettleMsg.Text = "訊息";
            // 
            // LstFinanacialMsg
            // 
            this.LstFinanacialMsg.FormattingEnabled = true;
            this.LstFinanacialMsg.ItemHeight = 19;
            this.LstFinanacialMsg.Location = new System.Drawing.Point(854, 32);
            this.LstFinanacialMsg.Name = "LstFinanacialMsg";
            this.LstFinanacialMsg.Size = new System.Drawing.Size(372, 726);
            this.LstFinanacialMsg.TabIndex = 2;
            // 
            // dataFinancialLedger
            // 
            this.dataFinancialLedger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFinancialLedger.Location = new System.Drawing.Point(6, 67);
            this.dataFinancialLedger.Name = "dataFinancialLedger";
            this.dataFinancialLedger.RowTemplate.Height = 24;
            this.dataFinancialLedger.Size = new System.Drawing.Size(842, 691);
            this.dataFinancialLedger.TabIndex = 1;
            this.dataFinancialLedger.Tag = "0,6";
            this.dataFinancialLedger.SelectionChanged += new System.EventHandler(this.dgSettleGridView_SelectionChanged);
            // 
            // dgFinancialSettlGridView
            // 
            this.dgFinancialSettlGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFinancialSettlGridView.Location = new System.Drawing.Point(1232, 68);
            this.dgFinancialSettlGridView.Name = "dgFinancialSettlGridView";
            this.dgFinancialSettlGridView.RowTemplate.Height = 24;
            this.dgFinancialSettlGridView.Size = new System.Drawing.Size(558, 690);
            this.dgFinancialSettlGridView.TabIndex = 1;
            this.dgFinancialSettlGridView.Tag = "0,6";
            this.dgFinancialSettlGridView.SelectionChanged += new System.EventHandler(this.dgSettleGridView_SelectionChanged);
            // 
            // btnCheckAccounts
            // 
            this.btnCheckAccounts.Location = new System.Drawing.Point(1516, 8);
            this.btnCheckAccounts.Name = "btnCheckAccounts";
            this.btnCheckAccounts.Size = new System.Drawing.Size(139, 54);
            this.btnCheckAccounts.TabIndex = 0;
            this.btnCheckAccounts.Text = "檢查資料";
            this.btnCheckAccounts.UseVisualStyleBackColor = true;
            this.btnCheckAccounts.Click += new System.EventHandler(this.btnCheckAccounts_Click);
            // 
            // btnArrangeNew
            // 
            this.btnArrangeNew.Location = new System.Drawing.Point(1371, 8);
            this.btnArrangeNew.Name = "btnArrangeNew";
            this.btnArrangeNew.Size = new System.Drawing.Size(139, 54);
            this.btnArrangeNew.TabIndex = 0;
            this.btnArrangeNew.Text = "重新排列";
            this.btnArrangeNew.UseVisualStyleBackColor = true;
            this.btnArrangeNew.Click += new System.EventHandler(this.btnArrangeNew_Click);
            // 
            // btnCheckAccNo
            // 
            this.btnCheckAccNo.Location = new System.Drawing.Point(1232, 7);
            this.btnCheckAccNo.Name = "btnCheckAccNo";
            this.btnCheckAccNo.Size = new System.Drawing.Size(133, 55);
            this.btnCheckAccNo.TabIndex = 0;
            this.btnCheckAccNo.Text = "檢查排序";
            this.btnCheckAccNo.UseVisualStyleBackColor = true;
            this.btnCheckAccNo.Click += new System.EventHandler(this.btnCheckAccNo_Click);
            // 
            // btnReportExportData
            // 
            this.btnReportExportData.Location = new System.Drawing.Point(309, 7);
            this.btnReportExportData.Name = "btnReportExportData";
            this.btnReportExportData.Size = new System.Drawing.Size(141, 55);
            this.btnReportExportData.TabIndex = 0;
            this.btnReportExportData.Text = "匯出";
            this.btnReportExportData.UseVisualStyleBackColor = true;
            this.btnReportExportData.Click += new System.EventHandler(this.btnReportExportData_Click);
            // 
            // btnSetttleQuery
            // 
            this.btnSetttleQuery.Location = new System.Drawing.Point(162, 6);
            this.btnSetttleQuery.Name = "btnSetttleQuery";
            this.btnSetttleQuery.Size = new System.Drawing.Size(141, 55);
            this.btnSetttleQuery.TabIndex = 0;
            this.btnSetttleQuery.Text = "查詢";
            this.btnSetttleQuery.UseVisualStyleBackColor = true;
            this.btnSetttleQuery.Click += new System.EventHandler(this.btnSetttleQuery_Click);
            // 
            // btnSettle
            // 
            this.btnSettle.Location = new System.Drawing.Point(6, 6);
            this.btnSettle.Name = "btnSettle";
            this.btnSettle.Size = new System.Drawing.Size(149, 55);
            this.btnSettle.TabIndex = 0;
            this.btnSettle.Text = "結算";
            this.btnSettle.UseVisualStyleBackColor = true;
            this.btnSettle.Click += new System.EventHandler(this.btnSettle_Click);
            // 
            // tbFinancialIncome
            // 
            this.tbFinancialIncome.Controls.Add(this.label13);
            this.tbFinancialIncome.Controls.Add(this.lstMsgIncomeStatment);
            this.tbFinancialIncome.Controls.Add(this.btnIncomeReport);
            this.tbFinancialIncome.Controls.Add(this.btnReportExport);
            this.tbFinancialIncome.Controls.Add(this.dgIncomeFinancial);
            this.tbFinancialIncome.Controls.Add(this.btnIncomeFinancial);
            this.tbFinancialIncome.Controls.Add(this.lblFinancialRptCnt);
            this.tbFinancialIncome.Controls.Add(this.lblIncomeStatement);
            this.tbFinancialIncome.Location = new System.Drawing.Point(4, 22);
            this.tbFinancialIncome.Name = "tbFinancialIncome";
            this.tbFinancialIncome.Padding = new System.Windows.Forms.Padding(3);
            this.tbFinancialIncome.Size = new System.Drawing.Size(1362, 723);
            this.tbFinancialIncome.TabIndex = 18;
            this.tbFinancialIncome.Text = "損益表";
            this.tbFinancialIncome.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.Location = new System.Drawing.Point(978, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 27);
            this.label13.TabIndex = 5;
            this.label13.Text = "訊息";
            // 
            // lstMsgIncomeStatment
            // 
            this.lstMsgIncomeStatment.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lstMsgIncomeStatment.FormattingEnabled = true;
            this.lstMsgIncomeStatment.ItemHeight = 19;
            this.lstMsgIncomeStatment.Location = new System.Drawing.Point(982, 63);
            this.lstMsgIncomeStatment.Name = "lstMsgIncomeStatment";
            this.lstMsgIncomeStatment.Size = new System.Drawing.Size(372, 726);
            this.lstMsgIncomeStatment.TabIndex = 4;
            // 
            // btnIncomeReport
            // 
            this.btnIncomeReport.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnIncomeReport.Location = new System.Drawing.Point(453, 8);
            this.btnIncomeReport.Name = "btnIncomeReport";
            this.btnIncomeReport.Size = new System.Drawing.Size(145, 50);
            this.btnIncomeReport.TabIndex = 3;
            this.btnIncomeReport.Text = "報表";
            this.btnIncomeReport.UseVisualStyleBackColor = true;
            this.btnIncomeReport.Click += new System.EventHandler(this.btnIncomeReport_Click);
            // 
            // btnReportExport
            // 
            this.btnReportExport.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReportExport.Location = new System.Drawing.Point(741, 5);
            this.btnReportExport.Name = "btnReportExport";
            this.btnReportExport.Size = new System.Drawing.Size(141, 55);
            this.btnReportExport.TabIndex = 3;
            this.btnReportExport.Text = "匯出";
            this.btnReportExport.UseVisualStyleBackColor = true;
            this.btnReportExport.Visible = false;
            this.btnReportExport.Click += new System.EventHandler(this.btnReportExport_Click);
            // 
            // dgIncomeFinancial
            // 
            this.dgIncomeFinancial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgIncomeFinancial.Location = new System.Drawing.Point(11, 64);
            this.dgIncomeFinancial.Name = "dgIncomeFinancial";
            this.dgIncomeFinancial.RowTemplate.Height = 24;
            this.dgIncomeFinancial.Size = new System.Drawing.Size(967, 702);
            this.dgIncomeFinancial.TabIndex = 2;
            // 
            // btnIncomeFinancial
            // 
            this.btnIncomeFinancial.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnIncomeFinancial.Location = new System.Drawing.Point(297, 8);
            this.btnIncomeFinancial.Name = "btnIncomeFinancial";
            this.btnIncomeFinancial.Size = new System.Drawing.Size(144, 52);
            this.btnIncomeFinancial.TabIndex = 1;
            this.btnIncomeFinancial.Text = "查詢";
            this.btnIncomeFinancial.UseVisualStyleBackColor = true;
            this.btnIncomeFinancial.Click += new System.EventHandler(this.btnIncomeFinancial_Click);
            // 
            // lblFinancialRptCnt
            // 
            this.lblFinancialRptCnt.AutoSize = true;
            this.lblFinancialRptCnt.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblFinancialRptCnt.Location = new System.Drawing.Point(464, 29);
            this.lblFinancialRptCnt.Name = "lblFinancialRptCnt";
            this.lblFinancialRptCnt.Size = new System.Drawing.Size(180, 27);
            this.lblFinancialRptCnt.TabIndex = 0;
            this.lblFinancialRptCnt.Text = "                        ";
            // 
            // lblIncomeStatement
            // 
            this.lblIncomeStatement.AutoSize = true;
            this.lblIncomeStatement.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblIncomeStatement.Location = new System.Drawing.Point(12, 27);
            this.lblIncomeStatement.Name = "lblIncomeStatement";
            this.lblIncomeStatement.Size = new System.Drawing.Size(93, 27);
            this.lblIncomeStatement.TabIndex = 0;
            this.lblIncomeStatement.Text = "損益表";
            // 
            // TabBalanceRpt
            // 
            this.TabBalanceRpt.Controls.Add(this.btnBalanceReport);
            this.TabBalanceRpt.Controls.Add(this.label14);
            this.TabBalanceRpt.Controls.Add(this.lstMsgFinanceBalance);
            this.TabBalanceRpt.Controls.Add(this.btnBalanceReportData);
            this.TabBalanceRpt.Controls.Add(this.dgBalanceFinancial);
            this.TabBalanceRpt.Controls.Add(this.btnFinanceBalance);
            this.TabBalanceRpt.Controls.Add(this.lblBalanceSheetCnt);
            this.TabBalanceRpt.Controls.Add(this.lblFinanceBalance);
            this.TabBalanceRpt.Location = new System.Drawing.Point(4, 22);
            this.TabBalanceRpt.Name = "TabBalanceRpt";
            this.TabBalanceRpt.Padding = new System.Windows.Forms.Padding(3);
            this.TabBalanceRpt.Size = new System.Drawing.Size(1362, 723);
            this.TabBalanceRpt.TabIndex = 19;
            this.TabBalanceRpt.Text = "資產負債表";
            this.TabBalanceRpt.UseVisualStyleBackColor = true;
            // 
            // btnBalanceReport
            // 
            this.btnBalanceReport.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBalanceReport.Location = new System.Drawing.Point(591, 26);
            this.btnBalanceReport.Name = "btnBalanceReport";
            this.btnBalanceReport.Size = new System.Drawing.Size(157, 50);
            this.btnBalanceReport.TabIndex = 9;
            this.btnBalanceReport.Text = "報表";
            this.btnBalanceReport.UseVisualStyleBackColor = true;
            this.btnBalanceReport.Click += new System.EventHandler(this.btnBalanceReport_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.Location = new System.Drawing.Point(1048, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 27);
            this.label14.TabIndex = 8;
            this.label14.Text = "訊息";
            // 
            // lstMsgFinanceBalance
            // 
            this.lstMsgFinanceBalance.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lstMsgFinanceBalance.FormattingEnabled = true;
            this.lstMsgFinanceBalance.ItemHeight = 19;
            this.lstMsgFinanceBalance.Location = new System.Drawing.Point(1052, 86);
            this.lstMsgFinanceBalance.Name = "lstMsgFinanceBalance";
            this.lstMsgFinanceBalance.Size = new System.Drawing.Size(372, 726);
            this.lstMsgFinanceBalance.TabIndex = 7;
            // 
            // btnBalanceReportData
            // 
            this.btnBalanceReportData.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBalanceReportData.Location = new System.Drawing.Point(1442, 87);
            this.btnBalanceReportData.Name = "btnBalanceReportData";
            this.btnBalanceReportData.Size = new System.Drawing.Size(141, 55);
            this.btnBalanceReportData.TabIndex = 6;
            this.btnBalanceReportData.Text = "匯出";
            this.btnBalanceReportData.UseVisualStyleBackColor = true;
            this.btnBalanceReportData.Visible = false;
            this.btnBalanceReportData.Click += new System.EventHandler(this.btnBalanceReportData_Click);
            // 
            // dgBalanceFinancial
            // 
            this.dgBalanceFinancial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBalanceFinancial.Location = new System.Drawing.Point(11, 87);
            this.dgBalanceFinancial.Name = "dgBalanceFinancial";
            this.dgBalanceFinancial.RowTemplate.Height = 24;
            this.dgBalanceFinancial.Size = new System.Drawing.Size(1032, 702);
            this.dgBalanceFinancial.TabIndex = 5;
            // 
            // btnFinanceBalance
            // 
            this.btnFinanceBalance.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFinanceBalance.Location = new System.Drawing.Point(423, 25);
            this.btnFinanceBalance.Name = "btnFinanceBalance";
            this.btnFinanceBalance.Size = new System.Drawing.Size(162, 53);
            this.btnFinanceBalance.TabIndex = 4;
            this.btnFinanceBalance.Text = "查詢";
            this.btnFinanceBalance.UseVisualStyleBackColor = true;
            this.btnFinanceBalance.Click += new System.EventHandler(this.btnFinanceBalance_Click);
            // 
            // lblBalanceSheetCnt
            // 
            this.lblBalanceSheetCnt.AutoSize = true;
            this.lblBalanceSheetCnt.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblBalanceSheetCnt.Location = new System.Drawing.Point(173, 48);
            this.lblBalanceSheetCnt.Name = "lblBalanceSheetCnt";
            this.lblBalanceSheetCnt.Size = new System.Drawing.Size(243, 27);
            this.lblBalanceSheetCnt.TabIndex = 3;
            this.lblBalanceSheetCnt.Text = "                                 ";
            // 
            // lblFinanceBalance
            // 
            this.lblFinanceBalance.AutoSize = true;
            this.lblFinanceBalance.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblFinanceBalance.Location = new System.Drawing.Point(6, 5);
            this.lblFinanceBalance.Name = "lblFinanceBalance";
            this.lblFinanceBalance.Size = new System.Drawing.Size(147, 27);
            this.lblFinanceBalance.TabIndex = 3;
            this.lblFinanceBalance.Text = "資產負債表";
            // 
            // TabExport
            // 
            this.TabExport.Controls.Add(this.chExportVerify);
            this.TabExport.Controls.Add(this.label19);
            this.TabExport.Controls.Add(this.lstAccounting);
            this.TabExport.Controls.Add(this.btnExportAccounting);
            this.TabExport.Location = new System.Drawing.Point(4, 22);
            this.TabExport.Name = "TabExport";
            this.TabExport.Padding = new System.Windows.Forms.Padding(3);
            this.TabExport.Size = new System.Drawing.Size(1362, 723);
            this.TabExport.TabIndex = 22;
            this.TabExport.Text = "資料匯出";
            this.TabExport.UseVisualStyleBackColor = true;
            // 
            // chExportVerify
            // 
            this.chExportVerify.AutoSize = true;
            this.chExportVerify.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chExportVerify.Location = new System.Drawing.Point(874, 71);
            this.chExportVerify.Name = "chExportVerify";
            this.chExportVerify.Size = new System.Drawing.Size(117, 26);
            this.chExportVerify.TabIndex = 14;
            this.chExportVerify.Text = "預先結算";
            this.chExportVerify.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label19.Location = new System.Drawing.Point(6, 119);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(66, 27);
            this.label19.TabIndex = 13;
            this.label19.Text = "訊息";
            // 
            // lstAccounting
            // 
            this.lstAccounting.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lstAccounting.FormattingEnabled = true;
            this.lstAccounting.ItemHeight = 19;
            this.lstAccounting.Location = new System.Drawing.Point(11, 157);
            this.lstAccounting.Name = "lstAccounting";
            this.lstAccounting.Size = new System.Drawing.Size(857, 631);
            this.lstAccounting.TabIndex = 12;
            // 
            // btnExportAccounting
            // 
            this.btnExportAccounting.Font = new System.Drawing.Font("新細明體", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnExportAccounting.Location = new System.Drawing.Point(6, 28);
            this.btnExportAccounting.Name = "btnExportAccounting";
            this.btnExportAccounting.Size = new System.Drawing.Size(862, 69);
            this.btnExportAccounting.TabIndex = 11;
            this.btnExportAccounting.Text = "匯出帳冊";
            this.btnExportAccounting.UseVisualStyleBackColor = true;
            this.btnExportAccounting.Click += new System.EventHandler(this.btnExportAccounting_Click);
            // 
            // TbSetting
            // 
            this.TbSetting.Controls.Add(this.btnSetup);
            this.TbSetting.Controls.Add(this.txtSYear);
            this.TbSetting.Controls.Add(this.lblSYear);
            this.TbSetting.Location = new System.Drawing.Point(4, 22);
            this.TbSetting.Name = "TbSetting";
            this.TbSetting.Size = new System.Drawing.Size(1362, 723);
            this.TbSetting.TabIndex = 23;
            this.TbSetting.Text = "系統設定";
            this.TbSetting.UseVisualStyleBackColor = true;
            // 
            // btnSetup
            // 
            this.btnSetup.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSetup.Location = new System.Drawing.Point(185, 11);
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.Size = new System.Drawing.Size(124, 52);
            this.btnSetup.TabIndex = 8;
            this.btnSetup.Text = "設定";
            this.btnSetup.UseVisualStyleBackColor = true;
            this.btnSetup.Click += new System.EventHandler(this.btnSetup_Click);
            // 
            // txtSYear
            // 
            this.txtSYear.Location = new System.Drawing.Point(65, 12);
            this.txtSYear.Name = "txtSYear";
            this.txtSYear.Size = new System.Drawing.Size(114, 22);
            this.txtSYear.TabIndex = 7;
            // 
            // lblSYear
            // 
            this.lblSYear.AutoSize = true;
            this.lblSYear.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSYear.Location = new System.Drawing.Point(3, 13);
            this.lblSYear.Name = "lblSYear";
            this.lblSYear.Size = new System.Drawing.Size(58, 24);
            this.lblSYear.TabIndex = 6;
            this.lblSYear.Text = "年度";
            // 
            // tbAccFunctions
            // 
            this.tbAccFunctions.Controls.Add(this.button11);
            this.tbAccFunctions.Controls.Add(this.button6);
            this.tbAccFunctions.Controls.Add(this.button10);
            this.tbAccFunctions.Controls.Add(this.button5);
            this.tbAccFunctions.Controls.Add(this.button14);
            this.tbAccFunctions.Controls.Add(this.button9);
            this.tbAccFunctions.Controls.Add(this.button13);
            this.tbAccFunctions.Controls.Add(this.button4);
            this.tbAccFunctions.Controls.Add(this.button12);
            this.tbAccFunctions.Controls.Add(this.button8);
            this.tbAccFunctions.Controls.Add(this.button7);
            this.tbAccFunctions.Controls.Add(this.button3);
            this.tbAccFunctions.Controls.Add(this.button2);
            this.tbAccFunctions.Location = new System.Drawing.Point(4, 22);
            this.tbAccFunctions.Name = "tbAccFunctions";
            this.tbAccFunctions.Padding = new System.Windows.Forms.Padding(3);
            this.tbAccFunctions.Size = new System.Drawing.Size(1362, 723);
            this.tbAccFunctions.TabIndex = 21;
            this.tbAccFunctions.Text = "AccFunctions";
            this.tbAccFunctions.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button11.Location = new System.Drawing.Point(767, 133);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(175, 69);
            this.button11.TabIndex = 1;
            this.button11.Text = "預算管理";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button6.Location = new System.Drawing.Point(767, 29);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(175, 69);
            this.button6.TabIndex = 1;
            this.button6.Text = "應收應付管理";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button10.Location = new System.Drawing.Point(586, 133);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(175, 69);
            this.button10.TabIndex = 1;
            this.button10.Text = "廠商管理";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button5.Location = new System.Drawing.Point(586, 29);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(175, 69);
            this.button5.TabIndex = 1;
            this.button5.Text = "發票管理 ";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button14.Location = new System.Drawing.Point(405, 235);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(175, 69);
            this.button14.TabIndex = 1;
            this.button14.Text = "IFRS區";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button9.Location = new System.Drawing.Point(405, 133);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(175, 69);
            this.button9.TabIndex = 1;
            this.button9.Text = "商品成本報表";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button13.Location = new System.Drawing.Point(214, 235);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(175, 69);
            this.button13.TabIndex = 1;
            this.button13.Text = "出納管理";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button4.Location = new System.Drawing.Point(405, 29);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(175, 69);
            this.button4.TabIndex = 1;
            this.button4.Text = "票據管理";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button12.Location = new System.Drawing.Point(23, 235);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(175, 69);
            this.button12.TabIndex = 1;
            this.button12.Text = "薪資管理";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button8.Location = new System.Drawing.Point(214, 133);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(175, 69);
            this.button8.TabIndex = 1;
            this.button8.Text = "商務報表查看";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button7.Location = new System.Drawing.Point(23, 133);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(175, 69);
            this.button7.TabIndex = 1;
            this.button7.Text = "採購管理";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.Location = new System.Drawing.Point(214, 29);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 69);
            this.button3.TabIndex = 1;
            this.button3.Text = "傳票輸入";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(23, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 69);
            this.button2.TabIndex = 1;
            this.button2.Text = "零用金管理";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // TPAccAmount
            // 
            this.TPAccAmount.Controls.Add(this.addQueryDataForm4);
            this.TPAccAmount.Location = new System.Drawing.Point(4, 22);
            this.TPAccAmount.Name = "TPAccAmount";
            this.TPAccAmount.Size = new System.Drawing.Size(1362, 723);
            this.TPAccAmount.TabIndex = 3;
            this.TPAccAmount.Text = "AccAmount";
            this.TPAccAmount.UseVisualStyleBackColor = true;
            // 
            // addQueryDataForm4
            // 
            this.addQueryDataForm4.ctl01 = null;
            this.addQueryDataForm4.ctl02 = null;
            this.addQueryDataForm4.datapath05 = null;
            this.addQueryDataForm4.datatype = JINSHIN.FinanceAccount.Libary.Models.Base.AddQueryEnum.None;
            this.addQueryDataForm4.Location = new System.Drawing.Point(3, 3);
            this.addQueryDataForm4.Name = "addQueryDataForm4";
            this.addQueryDataForm4.Size = new System.Drawing.Size(1720, 739);
            this.addQueryDataForm4.TabIndex = 0;
            // 
            // TPInvContract
            // 
            this.TPInvContract.Controls.Add(this.addQueryInvContract);
            this.TPInvContract.Location = new System.Drawing.Point(4, 22);
            this.TPInvContract.Name = "TPInvContract";
            this.TPInvContract.Padding = new System.Windows.Forms.Padding(3);
            this.TPInvContract.Size = new System.Drawing.Size(1362, 723);
            this.TPInvContract.TabIndex = 9;
            this.TPInvContract.Text = "Import_InvContract";
            this.TPInvContract.UseVisualStyleBackColor = true;
            // 
            // addQueryInvContract
            // 
            this.addQueryInvContract.ctl01 = null;
            this.addQueryInvContract.ctl02 = null;
            this.addQueryInvContract.datapath05 = null;
            this.addQueryInvContract.datatype = JINSHIN.FinanceAccount.Libary.Models.Base.AddQueryEnum.None;
            this.addQueryInvContract.Location = new System.Drawing.Point(6, 6);
            this.addQueryInvContract.Name = "addQueryInvContract";
            this.addQueryInvContract.Size = new System.Drawing.Size(1720, 739);
            this.addQueryInvContract.TabIndex = 0;
            // 
            // TPCost
            // 
            this.TPCost.Controls.Add(this.CtlInvoice);
            this.TPCost.Controls.Add(this.button1);
            this.TPCost.Controls.Add(this.label3);
            this.TPCost.Controls.Add(this.textBox1);
            this.TPCost.Controls.Add(this.dgCostData);
            this.TPCost.Location = new System.Drawing.Point(4, 22);
            this.TPCost.Name = "TPCost";
            this.TPCost.Padding = new System.Windows.Forms.Padding(3);
            this.TPCost.Size = new System.Drawing.Size(1362, 723);
            this.TPCost.TabIndex = 1;
            this.TPCost.Text = "Cost";
            this.TPCost.UseVisualStyleBackColor = true;
            // 
            // CtlInvoice
            // 
            this.CtlInvoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CtlInvoice.Controls.Add(this.btnCostUpdate);
            this.CtlInvoice.Controls.Add(this.btnCostAdd);
            this.CtlInvoice.Controls.Add(this.txCostBuyID);
            this.CtlInvoice.Controls.Add(this.txCostTaxAmount);
            this.CtlInvoice.Controls.Add(this.txCostAmount);
            this.CtlInvoice.Controls.Add(this.txCostInvoiceID);
            this.CtlInvoice.Controls.Add(this.txCostSellID);
            this.CtlInvoice.Controls.Add(this.chCostTax);
            this.CtlInvoice.Controls.Add(this.chCostAll);
            this.CtlInvoice.Controls.Add(this.label7);
            this.CtlInvoice.Controls.Add(this.lstCostMonthList);
            this.CtlInvoice.Controls.Add(this.label6);
            this.CtlInvoice.Controls.Add(this.label5);
            this.CtlInvoice.Controls.Add(this.label4);
            this.CtlInvoice.Controls.Add(this.lblTitle02);
            this.CtlInvoice.Controls.Add(this.lblSellID);
            this.CtlInvoice.Controls.Add(this.lblTitle01);
            this.CtlInvoice.Controls.Add(this.cxCostDataType);
            this.CtlInvoice.Location = new System.Drawing.Point(27, 35);
            this.CtlInvoice.Name = "CtlInvoice";
            this.CtlInvoice.Size = new System.Drawing.Size(1559, 156);
            this.CtlInvoice.TabIndex = 9;
            // 
            // btnCostUpdate
            // 
            this.btnCostUpdate.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCostUpdate.Location = new System.Drawing.Point(1069, 13);
            this.btnCostUpdate.Name = "btnCostUpdate";
            this.btnCostUpdate.Size = new System.Drawing.Size(85, 64);
            this.btnCostUpdate.TabIndex = 15;
            this.btnCostUpdate.Text = "更新";
            this.btnCostUpdate.UseVisualStyleBackColor = true;
            // 
            // btnCostAdd
            // 
            this.btnCostAdd.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCostAdd.Location = new System.Drawing.Point(978, 14);
            this.btnCostAdd.Name = "btnCostAdd";
            this.btnCostAdd.Size = new System.Drawing.Size(85, 64);
            this.btnCostAdd.TabIndex = 15;
            this.btnCostAdd.Text = "新增";
            this.btnCostAdd.UseVisualStyleBackColor = true;
            this.btnCostAdd.Click += new System.EventHandler(this.btnCostAdd_Click);
            // 
            // txCostBuyID
            // 
            this.txCostBuyID.Location = new System.Drawing.Point(487, 56);
            this.txCostBuyID.Name = "txCostBuyID";
            this.txCostBuyID.Size = new System.Drawing.Size(100, 22);
            this.txCostBuyID.TabIndex = 14;
            // 
            // txCostTaxAmount
            // 
            this.txCostTaxAmount.Location = new System.Drawing.Point(842, 55);
            this.txCostTaxAmount.Name = "txCostTaxAmount";
            this.txCostTaxAmount.Size = new System.Drawing.Size(100, 22);
            this.txCostTaxAmount.TabIndex = 14;
            // 
            // txCostAmount
            // 
            this.txCostAmount.Location = new System.Drawing.Point(683, 56);
            this.txCostAmount.Name = "txCostAmount";
            this.txCostAmount.Size = new System.Drawing.Size(100, 22);
            this.txCostAmount.TabIndex = 14;
            // 
            // txCostInvoiceID
            // 
            this.txCostInvoiceID.Location = new System.Drawing.Point(683, 15);
            this.txCostInvoiceID.Name = "txCostInvoiceID";
            this.txCostInvoiceID.Size = new System.Drawing.Size(100, 22);
            this.txCostInvoiceID.TabIndex = 14;
            // 
            // txCostSellID
            // 
            this.txCostSellID.Location = new System.Drawing.Point(487, 15);
            this.txCostSellID.Name = "txCostSellID";
            this.txCostSellID.Size = new System.Drawing.Size(100, 22);
            this.txCostSellID.TabIndex = 14;
            // 
            // chCostTax
            // 
            this.chCostTax.AutoSize = true;
            this.chCostTax.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chCostTax.Location = new System.Drawing.Point(598, 107);
            this.chCostTax.Name = "chCostTax";
            this.chCostTax.Size = new System.Drawing.Size(116, 23);
            this.chCostTax.TabIndex = 13;
            this.chCostTax.Text = "Tax/ NoTax";
            this.chCostTax.UseVisualStyleBackColor = true;
            // 
            // chCostAll
            // 
            this.chCostAll.AutoSize = true;
            this.chCostAll.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chCostAll.Location = new System.Drawing.Point(345, 107);
            this.chCostAll.Name = "chCostAll";
            this.chCostAll.Size = new System.Drawing.Size(63, 23);
            this.chCostAll.TabIndex = 13;
            this.chCostAll.Text = "ALL";
            this.chCostAll.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(787, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "稅額";
            // 
            // lstCostMonthList
            // 
            this.lstCostMonthList.ColumnWidth = 40;
            this.lstCostMonthList.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lstCostMonthList.FormattingEnabled = true;
            this.lstCostMonthList.ItemHeight = 19;
            this.lstCostMonthList.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.lstCostMonthList.Location = new System.Drawing.Point(237, 12);
            this.lstCostMonthList.MultiColumn = true;
            this.lstCostMonthList.Name = "lstCostMonthList";
            this.lstCostMonthList.Size = new System.Drawing.Size(102, 118);
            this.lstCostMonthList.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(594, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "金額";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(341, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "買方統一編號";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(594, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "發票號碼";
            // 
            // lblTitle02
            // 
            this.lblTitle02.AutoSize = true;
            this.lblTitle02.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTitle02.Location = new System.Drawing.Point(182, 14);
            this.lblTitle02.Name = "lblTitle02";
            this.lblTitle02.Size = new System.Drawing.Size(49, 19);
            this.lblTitle02.TabIndex = 10;
            this.lblTitle02.Text = "月份";
            // 
            // lblSellID
            // 
            this.lblSellID.AutoSize = true;
            this.lblSellID.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSellID.Location = new System.Drawing.Point(341, 15);
            this.lblSellID.Name = "lblSellID";
            this.lblSellID.Size = new System.Drawing.Size(149, 19);
            this.lblSellID.TabIndex = 11;
            this.lblSellID.Text = "銷售人統一編號";
            // 
            // lblTitle01
            // 
            this.lblTitle01.AutoSize = true;
            this.lblTitle01.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTitle01.Location = new System.Drawing.Point(5, 14);
            this.lblTitle01.Name = "lblTitle01";
            this.lblTitle01.Size = new System.Drawing.Size(49, 19);
            this.lblTitle01.TabIndex = 11;
            this.lblTitle01.Text = "種類";
            // 
            // cxCostDataType
            // 
            this.cxCostDataType.FormattingEnabled = true;
            this.cxCostDataType.Items.AddRange(new object[] {
            "薪資",
            "辦公租金",
            "業務支出",
            "勞健保",
            "Office365",
            "營業地租金",
            "yes123人力銀行",
            "廣告費網站",
            "電話費",
            "有線電話"});
            this.cxCostDataType.Location = new System.Drawing.Point(57, 12);
            this.cxCostDataType.Name = "cxCostDataType";
            this.cxCostDataType.Size = new System.Drawing.Size(121, 20);
            this.cxCostDataType.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(857, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "查詢";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(29, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "會計科目";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(119, 163);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(722, 30);
            this.textBox1.TabIndex = 3;
            // 
            // dgCostData
            // 
            this.dgCostData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCostData.Location = new System.Drawing.Point(27, 215);
            this.dgCostData.Name = "dgCostData";
            this.dgCostData.RowTemplate.Height = 24;
            this.dgCostData.Size = new System.Drawing.Size(1559, 491);
            this.dgCostData.TabIndex = 0;
            // 
            // TPCostDataView
            // 
            this.TPCostDataView.Controls.Add(this.btnRebuildIndx);
            this.TPCostDataView.Controls.Add(this.btnCostItemUpdate);
            this.TPCostDataView.Controls.Add(this.AddQueryCostData);
            this.TPCostDataView.Location = new System.Drawing.Point(4, 22);
            this.TPCostDataView.Name = "TPCostDataView";
            this.TPCostDataView.Padding = new System.Windows.Forms.Padding(3);
            this.TPCostDataView.Size = new System.Drawing.Size(1362, 723);
            this.TPCostDataView.TabIndex = 7;
            this.TPCostDataView.Text = "CostDataView";
            this.TPCostDataView.UseVisualStyleBackColor = true;
            // 
            // btnRebuildIndx
            // 
            this.btnRebuildIndx.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRebuildIndx.Location = new System.Drawing.Point(342, 14);
            this.btnRebuildIndx.Name = "btnRebuildIndx";
            this.btnRebuildIndx.Size = new System.Drawing.Size(137, 60);
            this.btnRebuildIndx.TabIndex = 1;
            this.btnRebuildIndx.Text = "重建";
            this.btnRebuildIndx.UseVisualStyleBackColor = true;
            this.btnRebuildIndx.Click += new System.EventHandler(this.btnRebuildIndx_Click);
            // 
            // btnCostItemUpdate
            // 
            this.btnCostItemUpdate.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCostItemUpdate.Location = new System.Drawing.Point(485, 14);
            this.btnCostItemUpdate.Name = "btnCostItemUpdate";
            this.btnCostItemUpdate.Size = new System.Drawing.Size(137, 60);
            this.btnCostItemUpdate.TabIndex = 1;
            this.btnCostItemUpdate.Text = "更新";
            this.btnCostItemUpdate.UseVisualStyleBackColor = true;
            this.btnCostItemUpdate.Click += new System.EventHandler(this.btnCostItemUpdate_Click);
            // 
            // AddQueryCostData
            // 
            this.AddQueryCostData.ctl01 = null;
            this.AddQueryCostData.ctl02 = null;
            this.AddQueryCostData.datapath05 = null;
            this.AddQueryCostData.datatype = JINSHIN.FinanceAccount.Libary.Models.Base.AddQueryEnum.None;
            this.AddQueryCostData.Location = new System.Drawing.Point(3, 6);
            this.AddQueryCostData.Name = "AddQueryCostData";
            this.AddQueryCostData.Size = new System.Drawing.Size(1720, 739);
            this.AddQueryCostData.TabIndex = 0;
            // 
            // tbMoney
            // 
            this.tbMoney.Controls.Add(this.cokMonMALL);
            this.tbMoney.Controls.Add(this.txtValidMAccID);
            this.tbMoney.Controls.Add(this.label11);
            this.tbMoney.Controls.Add(this.txtMCostAccID);
            this.tbMoney.Controls.Add(this.lbl_Accid);
            this.tbMoney.Controls.Add(this.txtValidDescData);
            this.tbMoney.Controls.Add(this.label10);
            this.tbMoney.Controls.Add(this.txtCostDescData);
            this.tbMoney.Controls.Add(this.lblMoneyQuery);
            this.tbMoney.Controls.Add(this.lblMonthTitle);
            this.tbMoney.Controls.Add(this.lstMonths);
            this.tbMoney.Controls.Add(this.goAccType);
            this.tbMoney.Controls.Add(this.btnVierfyAcc);
            this.tbMoney.Controls.Add(this.btnCancelCheck);
            this.tbMoney.Controls.Add(this.btnMoneyVeriy);
            this.tbMoney.Controls.Add(this.btnMoney);
            this.tbMoney.Controls.Add(this.lstMoneyMsg);
            this.tbMoney.Controls.Add(this.dataMoney02);
            this.tbMoney.Controls.Add(this.dataMoney01);
            this.tbMoney.Location = new System.Drawing.Point(4, 22);
            this.tbMoney.Name = "tbMoney";
            this.tbMoney.Padding = new System.Windows.Forms.Padding(3);
            this.tbMoney.Size = new System.Drawing.Size(1362, 723);
            this.tbMoney.TabIndex = 12;
            this.tbMoney.Text = "帳目智慧比對訊息提示";
            this.tbMoney.UseVisualStyleBackColor = true;
            // 
            // cokMonMALL
            // 
            this.cokMonMALL.AutoSize = true;
            this.cokMonMALL.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cokMonMALL.Location = new System.Drawing.Point(335, 89);
            this.cokMonMALL.Name = "cokMonMALL";
            this.cokMonMALL.Size = new System.Drawing.Size(66, 23);
            this.cokMonMALL.TabIndex = 7;
            this.cokMonMALL.Text = "全部";
            this.cokMonMALL.UseVisualStyleBackColor = true;
            // 
            // txtValidMAccID
            // 
            this.txtValidMAccID.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtValidMAccID.Location = new System.Drawing.Point(1054, 36);
            this.txtValidMAccID.Name = "txtValidMAccID";
            this.txtValidMAccID.Size = new System.Drawing.Size(159, 30);
            this.txtValidMAccID.TabIndex = 6;
            this.txtValidMAccID.Click += new System.EventHandler(this.txtValidMAccID_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(950, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 22);
            this.label11.TabIndex = 5;
            this.label11.Text = "會計編碼";
            // 
            // txtMCostAccID
            // 
            this.txtMCostAccID.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMCostAccID.Location = new System.Drawing.Point(778, 35);
            this.txtMCostAccID.Name = "txtMCostAccID";
            this.txtMCostAccID.Size = new System.Drawing.Size(159, 30);
            this.txtMCostAccID.TabIndex = 6;
            this.txtMCostAccID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMCostAccID_KeyDown);
            // 
            // lbl_Accid
            // 
            this.lbl_Accid.AutoSize = true;
            this.lbl_Accid.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_Accid.Location = new System.Drawing.Point(674, 38);
            this.lbl_Accid.Name = "lbl_Accid";
            this.lbl_Accid.Size = new System.Drawing.Size(98, 22);
            this.lbl_Accid.TabIndex = 5;
            this.lbl_Accid.Text = "會計編碼";
            // 
            // txtValidDescData
            // 
            this.txtValidDescData.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtValidDescData.Location = new System.Drawing.Point(1054, 76);
            this.txtValidDescData.Name = "txtValidDescData";
            this.txtValidDescData.Size = new System.Drawing.Size(159, 30);
            this.txtValidDescData.TabIndex = 6;
            this.txtValidDescData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValidDescData_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(998, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 22);
            this.label10.TabIndex = 5;
            this.label10.Text = "資料";
            // 
            // txtCostDescData
            // 
            this.txtCostDescData.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCostDescData.Location = new System.Drawing.Point(778, 77);
            this.txtCostDescData.Name = "txtCostDescData";
            this.txtCostDescData.Size = new System.Drawing.Size(159, 30);
            this.txtCostDescData.TabIndex = 6;
            // 
            // lblMoneyQuery
            // 
            this.lblMoneyQuery.AutoSize = true;
            this.lblMoneyQuery.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMoneyQuery.Location = new System.Drawing.Point(674, 82);
            this.lblMoneyQuery.Name = "lblMoneyQuery";
            this.lblMoneyQuery.Size = new System.Drawing.Size(54, 22);
            this.lblMoneyQuery.TabIndex = 5;
            this.lblMoneyQuery.Text = "資料";
            // 
            // lblMonthTitle
            // 
            this.lblMonthTitle.AutoSize = true;
            this.lblMonthTitle.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMonthTitle.Location = new System.Drawing.Point(331, 10);
            this.lblMonthTitle.Name = "lblMonthTitle";
            this.lblMonthTitle.Size = new System.Drawing.Size(54, 22);
            this.lblMonthTitle.TabIndex = 5;
            this.lblMonthTitle.Text = "月份";
            // 
            // lstMonths
            // 
            this.lstMonths.ColumnWidth = 70;
            this.lstMonths.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lstMonths.FormattingEnabled = true;
            this.lstMonths.ItemHeight = 24;
            this.lstMonths.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.lstMonths.Location = new System.Drawing.Point(403, 10);
            this.lstMonths.MultiColumn = true;
            this.lstMonths.Name = "lstMonths";
            this.lstMonths.Size = new System.Drawing.Size(257, 100);
            this.lstMonths.TabIndex = 4;
            // 
            // goAccType
            // 
            this.goAccType.Controls.Add(this.rbType02);
            this.goAccType.Controls.Add(this.rbType01);
            this.goAccType.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.goAccType.Location = new System.Drawing.Point(191, 4);
            this.goAccType.Name = "goAccType";
            this.goAccType.Size = new System.Drawing.Size(134, 86);
            this.goAccType.TabIndex = 3;
            this.goAccType.TabStop = false;
            this.goAccType.Text = "型式";
            // 
            // rbType02
            // 
            this.rbType02.AutoSize = true;
            this.rbType02.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbType02.Location = new System.Drawing.Point(15, 50);
            this.rbType02.Name = "rbType02";
            this.rbType02.Size = new System.Drawing.Size(107, 23);
            this.rbType02.TabIndex = 0;
            this.rbType02.TabStop = true;
            this.rbType02.Text = "會計分錄";
            this.rbType02.UseVisualStyleBackColor = true;
            // 
            // rbType01
            // 
            this.rbType01.AutoSize = true;
            this.rbType01.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbType01.Location = new System.Drawing.Point(15, 20);
            this.rbType01.Name = "rbType01";
            this.rbType01.Size = new System.Drawing.Size(107, 23);
            this.rbType01.TabIndex = 0;
            this.rbType01.TabStop = true;
            this.rbType01.Text = "會計科目";
            this.rbType01.UseVisualStyleBackColor = true;
            // 
            // btnVierfyAcc
            // 
            this.btnVierfyAcc.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnVierfyAcc.Location = new System.Drawing.Point(1380, 10);
            this.btnVierfyAcc.Name = "btnVierfyAcc";
            this.btnVierfyAcc.Size = new System.Drawing.Size(150, 55);
            this.btnVierfyAcc.TabIndex = 2;
            this.btnVierfyAcc.Text = "核定帳目";
            this.btnVierfyAcc.UseVisualStyleBackColor = true;
            this.btnVierfyAcc.Click += new System.EventHandler(this.btnVierfyAcc_Click);
            // 
            // btnCancelCheck
            // 
            this.btnCancelCheck.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancelCheck.Location = new System.Drawing.Point(1380, 71);
            this.btnCancelCheck.Name = "btnCancelCheck";
            this.btnCancelCheck.Size = new System.Drawing.Size(150, 55);
            this.btnCancelCheck.TabIndex = 2;
            this.btnCancelCheck.Text = "取消核定";
            this.btnCancelCheck.UseVisualStyleBackColor = true;
            this.btnCancelCheck.Click += new System.EventHandler(this.btnCancelCheck_Click);
            // 
            // btnMoneyVeriy
            // 
            this.btnMoneyVeriy.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMoneyVeriy.Location = new System.Drawing.Point(1224, 10);
            this.btnMoneyVeriy.Name = "btnMoneyVeriy";
            this.btnMoneyVeriy.Size = new System.Drawing.Size(150, 55);
            this.btnMoneyVeriy.TabIndex = 2;
            this.btnMoneyVeriy.Text = "智慧檢查";
            this.btnMoneyVeriy.UseVisualStyleBackColor = true;
            this.btnMoneyVeriy.Click += new System.EventHandler(this.btnMoneyVeriy_Click);
            // 
            // btnMoney
            // 
            this.btnMoney.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMoney.Location = new System.Drawing.Point(23, 10);
            this.btnMoney.Name = "btnMoney";
            this.btnMoney.Size = new System.Drawing.Size(162, 79);
            this.btnMoney.TabIndex = 2;
            this.btnMoney.Text = "顯示";
            this.btnMoney.UseVisualStyleBackColor = true;
            this.btnMoney.Click += new System.EventHandler(this.btnMoney_Click);
            // 
            // lstMoneyMsg
            // 
            this.lstMoneyMsg.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lstMoneyMsg.FormattingEnabled = true;
            this.lstMoneyMsg.HorizontalScrollbar = true;
            this.lstMoneyMsg.ItemHeight = 16;
            this.lstMoneyMsg.Location = new System.Drawing.Point(885, 134);
            this.lstMoneyMsg.Name = "lstMoneyMsg";
            this.lstMoneyMsg.Size = new System.Drawing.Size(389, 548);
            this.lstMoneyMsg.TabIndex = 1;
            // 
            // dataMoney02
            // 
            this.dataMoney02.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMoney02.Location = new System.Drawing.Point(1299, 134);
            this.dataMoney02.Name = "dataMoney02";
            this.dataMoney02.RowTemplate.Height = 24;
            this.dataMoney02.Size = new System.Drawing.Size(405, 548);
            this.dataMoney02.TabIndex = 0;
            // 
            // dataMoney01
            // 
            this.dataMoney01.AllowUserToOrderColumns = true;
            this.dataMoney01.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMoney01.Location = new System.Drawing.Point(19, 133);
            this.dataMoney01.Name = "dataMoney01";
            this.dataMoney01.RowTemplate.Height = 24;
            this.dataMoney01.Size = new System.Drawing.Size(850, 546);
            this.dataMoney01.TabIndex = 0;
            this.dataMoney01.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataMoney01_ColumnHeaderMouseClick);
            // 
            // TbAssets
            // 
            this.TbAssets.Controls.Add(this.btnAssetsVerify);
            this.TbAssets.Controls.Add(this.frmAssets);
            this.TbAssets.Location = new System.Drawing.Point(4, 22);
            this.TbAssets.Name = "TbAssets";
            this.TbAssets.Padding = new System.Windows.Forms.Padding(3);
            this.TbAssets.Size = new System.Drawing.Size(1362, 723);
            this.TbAssets.TabIndex = 14;
            this.TbAssets.Text = "資產及折舊產出";
            this.TbAssets.UseVisualStyleBackColor = true;
            // 
            // btnAssetsVerify
            // 
            this.btnAssetsVerify.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAssetsVerify.Location = new System.Drawing.Point(360, 12);
            this.btnAssetsVerify.Name = "btnAssetsVerify";
            this.btnAssetsVerify.Size = new System.Drawing.Size(110, 61);
            this.btnAssetsVerify.TabIndex = 1;
            this.btnAssetsVerify.Text = "產生帳目";
            this.btnAssetsVerify.UseVisualStyleBackColor = true;
            this.btnAssetsVerify.Click += new System.EventHandler(this.btnAssetsVerify_Click);
            // 
            // frmAssets
            // 
            this.frmAssets.assets_ctl = null;
            this.frmAssets.datapath06 = null;
            this.frmAssets.datapath07 = null;
            this.frmAssets.datapath09 = null;
            this.frmAssets.datapath10 = null;
            this.frmAssets.datatype = JINSHIN.FinanceAccount.Libary.Models.Base.AddQueryEnum.None;
            this.frmAssets.financial_balance = null;
            this.frmAssets.financial_income = null;
            this.frmAssets.ImportType = 0;
            this.frmAssets.Location = new System.Drawing.Point(0, -1);
            this.frmAssets.Name = "frmAssets";
            pathModel1.dataUpdateCenter = "C:\\Program Files\\Microsoft Visual Studio\\2022\\Community\\UpdateCenter\\";
            pathModel1.moneypath = "C:\\Program Files\\Microsoft Visual Studio\\2022\\Community\\Finance\\";
            this.frmAssets.pathmodel = pathModel1;
            this.frmAssets.Size = new System.Drawing.Size(1771, 700);
            this.frmAssets.TabIndex = 0;
            this.frmAssets.verifyitem_ctl = null;
            this.frmAssets.Load += new System.EventHandler(this.frmAssets_Load);
            // 
            // tbViewData
            // 
            this.tbViewData.Controls.Add(this.lblAcc_NO_Wait);
            this.tbViewData.Controls.Add(this.lblVerifyOK);
            this.tbViewData.Controls.Add(this.lblAcc_Verifying);
            this.tbViewData.Controls.Add(this.lstNoVerifyData);
            this.tbViewData.Controls.Add(this.lstVerifing);
            this.tbViewData.Controls.Add(this.lstVerifyData);
            this.tbViewData.Controls.Add(this.btn_payfirstLaborInsurance);
            this.tbViewData.Controls.Add(this.btnWorkCost);
            this.tbViewData.Controls.Add(this.btn_prepay_product);
            this.tbViewData.Controls.Add(this.btn_rate);
            this.tbViewData.Controls.Add(this.btn_travel_income);
            this.tbViewData.Controls.Add(this.btnOthersCost);
            this.tbViewData.Controls.Add(this.btn_pre_payrate);
            this.tbViewData.Controls.Add(this.btn_gift);
            this.tbViewData.Controls.Add(this.btn_Cost_Income);
            this.tbViewData.Controls.Add(this.btnViewRefresh);
            this.tbViewData.Controls.Add(this.btn_Depreciation_Cost);
            this.tbViewData.Controls.Add(this.btnAssets);
            this.tbViewData.Controls.Add(this.btnpayableSalary);
            this.tbViewData.Controls.Add(this.btnpayable);
            this.tbViewData.Controls.Add(this.btndividend);
            this.tbViewData.Controls.Add(this.btnInterest);
            this.tbViewData.Controls.Add(this.btnFinance);
            this.tbViewData.Controls.Add(this.btnPhone);
            this.tbViewData.Controls.Add(this.btnOffice365);
            this.tbViewData.Controls.Add(this.btnSalary);
            this.tbViewData.Location = new System.Drawing.Point(4, 22);
            this.tbViewData.Name = "tbViewData";
            this.tbViewData.Padding = new System.Windows.Forms.Padding(3);
            this.tbViewData.Size = new System.Drawing.Size(1362, 723);
            this.tbViewData.TabIndex = 13;
            this.tbViewData.Text = "帳務檢視";
            this.tbViewData.UseVisualStyleBackColor = true;
            // 
            // lblAcc_NO_Wait
            // 
            this.lblAcc_NO_Wait.AutoSize = true;
            this.lblAcc_NO_Wait.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAcc_NO_Wait.Location = new System.Drawing.Point(1526, 6);
            this.lblAcc_NO_Wait.Name = "lblAcc_NO_Wait";
            this.lblAcc_NO_Wait.Size = new System.Drawing.Size(82, 24);
            this.lblAcc_NO_Wait.TabIndex = 2;
            this.lblAcc_NO_Wait.Text = "待核對";
            // 
            // lblVerifyOK
            // 
            this.lblVerifyOK.AutoSize = true;
            this.lblVerifyOK.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblVerifyOK.Location = new System.Drawing.Point(1028, 5);
            this.lblVerifyOK.Name = "lblVerifyOK";
            this.lblVerifyOK.Size = new System.Drawing.Size(82, 24);
            this.lblVerifyOK.TabIndex = 2;
            this.lblVerifyOK.Text = "已核對";
            // 
            // lblAcc_Verifying
            // 
            this.lblAcc_Verifying.AutoSize = true;
            this.lblAcc_Verifying.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAcc_Verifying.Location = new System.Drawing.Point(1270, 6);
            this.lblAcc_Verifying.Name = "lblAcc_Verifying";
            this.lblAcc_Verifying.Size = new System.Drawing.Size(106, 24);
            this.lblAcc_Verifying.TabIndex = 2;
            this.lblAcc_Verifying.Text = "正在核對";
            // 
            // lstNoVerifyData
            // 
            this.lstNoVerifyData.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lstNoVerifyData.FormattingEnabled = true;
            this.lstNoVerifyData.ItemHeight = 19;
            this.lstNoVerifyData.Location = new System.Drawing.Point(1530, 34);
            this.lstNoVerifyData.Name = "lstNoVerifyData";
            this.lstNoVerifyData.Size = new System.Drawing.Size(257, 650);
            this.lstNoVerifyData.TabIndex = 1;
            // 
            // lstVerifing
            // 
            this.lstVerifing.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lstVerifing.FormattingEnabled = true;
            this.lstVerifing.ItemHeight = 19;
            this.lstVerifing.Location = new System.Drawing.Point(1274, 34);
            this.lstVerifing.Name = "lstVerifing";
            this.lstVerifing.Size = new System.Drawing.Size(249, 650);
            this.lstVerifing.TabIndex = 1;
            // 
            // lstVerifyData
            // 
            this.lstVerifyData.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lstVerifyData.FormattingEnabled = true;
            this.lstVerifyData.ItemHeight = 19;
            this.lstVerifyData.Location = new System.Drawing.Point(1030, 34);
            this.lstVerifyData.Name = "lstVerifyData";
            this.lstVerifyData.Size = new System.Drawing.Size(238, 650);
            this.lstVerifyData.TabIndex = 1;
            // 
            // btn_payfirstLaborInsurance
            // 
            this.btn_payfirstLaborInsurance.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_payfirstLaborInsurance.Location = new System.Drawing.Point(399, 253);
            this.btn_payfirstLaborInsurance.Name = "btn_payfirstLaborInsurance";
            this.btn_payfirstLaborInsurance.Size = new System.Drawing.Size(119, 67);
            this.btn_payfirstLaborInsurance.TabIndex = 0;
            this.btn_payfirstLaborInsurance.Text = "1281-暫付款-勞健保View";
            this.btn_payfirstLaborInsurance.UseVisualStyleBackColor = true;
            this.btn_payfirstLaborInsurance.Click += new System.EventHandler(this.btn_payfirstLaborInsurance_Click);
            // 
            // btnWorkCost
            // 
            this.btnWorkCost.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnWorkCost.Location = new System.Drawing.Point(268, 337);
            this.btnWorkCost.Name = "btnWorkCost";
            this.btnWorkCost.Size = new System.Drawing.Size(119, 67);
            this.btnWorkCost.TabIndex = 0;
            this.btnWorkCost.Text = "6112-辦公租金";
            this.btnWorkCost.UseVisualStyleBackColor = true;
            this.btnWorkCost.Click += new System.EventHandler(this.btnWorkCost_Click);
            // 
            // btn_prepay_product
            // 
            this.btn_prepay_product.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_prepay_product.Location = new System.Drawing.Point(268, 253);
            this.btn_prepay_product.Name = "btn_prepay_product";
            this.btn_prepay_product.Size = new System.Drawing.Size(119, 67);
            this.btn_prepay_product.TabIndex = 0;
            this.btn_prepay_product.Text = "1266-預付貨款";
            this.btn_prepay_product.UseVisualStyleBackColor = true;
            this.btn_prepay_product.Click += new System.EventHandler(this.btn_prepay_product_Click);
            // 
            // btn_rate
            // 
            this.btn_rate.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_rate.Location = new System.Drawing.Point(137, 337);
            this.btn_rate.Name = "btn_rate";
            this.btn_rate.Size = new System.Drawing.Size(119, 67);
            this.btn_rate.TabIndex = 0;
            this.btn_rate.Text = "6123-稅收";
            this.btn_rate.UseVisualStyleBackColor = true;
            this.btn_rate.Click += new System.EventHandler(this.btn_rate_Click);
            // 
            // btn_travel_income
            // 
            this.btn_travel_income.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_travel_income.Location = new System.Drawing.Point(6, 337);
            this.btn_travel_income.Name = "btn_travel_income";
            this.btn_travel_income.Size = new System.Drawing.Size(119, 67);
            this.btn_travel_income.TabIndex = 0;
            this.btn_travel_income.Text = "6114-旅費";
            this.btn_travel_income.UseVisualStyleBackColor = true;
            this.btn_travel_income.Click += new System.EventHandler(this.btn_travel_income_Click);
            // 
            // btnOthersCost
            // 
            this.btnOthersCost.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOthersCost.Location = new System.Drawing.Point(399, 172);
            this.btnOthersCost.Name = "btnOthersCost";
            this.btnOthersCost.Size = new System.Drawing.Size(119, 67);
            this.btnOthersCost.TabIndex = 0;
            this.btnOthersCost.Text = "6134-其他費用";
            this.btnOthersCost.UseVisualStyleBackColor = true;
            this.btnOthersCost.Click += new System.EventHandler(this.btnOthersCost_Click);
            // 
            // btn_pre_payrate
            // 
            this.btn_pre_payrate.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_pre_payrate.Location = new System.Drawing.Point(268, 172);
            this.btn_pre_payrate.Name = "btn_pre_payrate";
            this.btn_pre_payrate.Size = new System.Drawing.Size(119, 67);
            this.btn_pre_payrate.TabIndex = 0;
            this.btn_pre_payrate.Text = "1261-預付租金";
            this.btn_pre_payrate.UseVisualStyleBackColor = true;
            this.btn_pre_payrate.Click += new System.EventHandler(this.btn_pre_payrate_Click);
            // 
            // btn_gift
            // 
            this.btn_gift.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_gift.Location = new System.Drawing.Point(137, 253);
            this.btn_gift.Name = "btn_gift";
            this.btn_gift.Size = new System.Drawing.Size(119, 67);
            this.btn_gift.TabIndex = 0;
            this.btn_gift.Text = "6122-捐贈";
            this.btn_gift.UseVisualStyleBackColor = true;
            this.btn_gift.Click += new System.EventHandler(this.btn_gift_Click);
            // 
            // btn_Cost_Income
            // 
            this.btn_Cost_Income.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Cost_Income.Location = new System.Drawing.Point(6, 253);
            this.btn_Cost_Income.Name = "btn_Cost_Income";
            this.btn_Cost_Income.Size = new System.Drawing.Size(119, 67);
            this.btn_Cost_Income.TabIndex = 0;
            this.btn_Cost_Income.Text = "7236-手續費收入";
            this.btn_Cost_Income.UseVisualStyleBackColor = true;
            this.btn_Cost_Income.Click += new System.EventHandler(this.btn_Cost_Income_Click);
            // 
            // btnViewRefresh
            // 
            this.btnViewRefresh.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnViewRefresh.Location = new System.Drawing.Point(905, 6);
            this.btnViewRefresh.Name = "btnViewRefresh";
            this.btnViewRefresh.Size = new System.Drawing.Size(119, 55);
            this.btnViewRefresh.TabIndex = 0;
            this.btnViewRefresh.Text = "更新";
            this.btnViewRefresh.UseVisualStyleBackColor = true;
            this.btnViewRefresh.Click += new System.EventHandler(this.btnViewRefresh_Click);
            // 
            // btn_Depreciation_Cost
            // 
            this.btn_Depreciation_Cost.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Depreciation_Cost.Location = new System.Drawing.Point(137, 172);
            this.btn_Depreciation_Cost.Name = "btn_Depreciation_Cost";
            this.btn_Depreciation_Cost.Size = new System.Drawing.Size(119, 67);
            this.btn_Depreciation_Cost.TabIndex = 0;
            this.btn_Depreciation_Cost.Text = "6125-折舊";
            this.btn_Depreciation_Cost.UseVisualStyleBackColor = true;
            this.btn_Depreciation_Cost.Click += new System.EventHandler(this.btn_Depreciation_Cost_Click);
            // 
            // btnAssets
            // 
            this.btnAssets.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAssets.Location = new System.Drawing.Point(6, 172);
            this.btnAssets.Name = "btnAssets";
            this.btnAssets.Size = new System.Drawing.Size(119, 67);
            this.btnAssets.TabIndex = 0;
            this.btnAssets.Text = "1586-資產";
            this.btnAssets.UseVisualStyleBackColor = true;
            this.btnAssets.Click += new System.EventHandler(this.btnAssets_Click);
            // 
            // btnpayableSalary
            // 
            this.btnpayableSalary.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnpayableSalary.Location = new System.Drawing.Point(399, 89);
            this.btnpayableSalary.Name = "btnpayableSalary";
            this.btnpayableSalary.Size = new System.Drawing.Size(125, 67);
            this.btnpayableSalary.TabIndex = 0;
            this.btnpayableSalary.Text = "2191-應付薪資－薪資";
            this.btnpayableSalary.UseVisualStyleBackColor = true;
            this.btnpayableSalary.Click += new System.EventHandler(this.btnpayableSalary_Click);
            // 
            // btnpayable
            // 
            this.btnpayable.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnpayable.Location = new System.Drawing.Point(268, 89);
            this.btnpayable.Name = "btnpayable";
            this.btnpayable.Size = new System.Drawing.Size(125, 67);
            this.btnpayable.TabIndex = 0;
            this.btnpayable.Text = "2171-應付帳款－薪資";
            this.btnpayable.UseVisualStyleBackColor = true;
            this.btnpayable.Click += new System.EventHandler(this.btnpayable_Click);
            // 
            // btndividend
            // 
            this.btndividend.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btndividend.Location = new System.Drawing.Point(137, 89);
            this.btndividend.Name = "btndividend";
            this.btndividend.Size = new System.Drawing.Size(125, 67);
            this.btndividend.TabIndex = 0;
            this.btndividend.Text = "7141-股利收入";
            this.btndividend.UseVisualStyleBackColor = true;
            this.btndividend.Click += new System.EventHandler(this.btndividend_Click);
            // 
            // btnInterest
            // 
            this.btnInterest.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnInterest.Location = new System.Drawing.Point(6, 89);
            this.btnInterest.Name = "btnInterest";
            this.btnInterest.Size = new System.Drawing.Size(125, 67);
            this.btnInterest.TabIndex = 0;
            this.btnInterest.Text = "7111-利息收入";
            this.btnInterest.UseVisualStyleBackColor = true;
            this.btnInterest.Click += new System.EventHandler(this.btnInterest_Click);
            // 
            // btnFinance
            // 
            this.btnFinance.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFinance.Location = new System.Drawing.Point(399, 6);
            this.btnFinance.Name = "btnFinance";
            this.btnFinance.Size = new System.Drawing.Size(125, 67);
            this.btnFinance.TabIndex = 0;
            this.btnFinance.Text = "1121-金融資產";
            this.btnFinance.UseVisualStyleBackColor = true;
            this.btnFinance.Click += new System.EventHandler(this.btnFinance_Click);
            // 
            // btnPhone
            // 
            this.btnPhone.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPhone.Location = new System.Drawing.Point(268, 6);
            this.btnPhone.Name = "btnPhone";
            this.btnPhone.Size = new System.Drawing.Size(125, 67);
            this.btnPhone.TabIndex = 0;
            this.btnPhone.Text = "6116-電話費";
            this.btnPhone.UseVisualStyleBackColor = true;
            this.btnPhone.Click += new System.EventHandler(this.btnPhone_Click);
            // 
            // btnOffice365
            // 
            this.btnOffice365.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOffice365.Location = new System.Drawing.Point(137, 6);
            this.btnOffice365.Name = "btnOffice365";
            this.btnOffice365.Size = new System.Drawing.Size(125, 67);
            this.btnOffice365.TabIndex = 0;
            this.btnOffice365.Text = "6112-Office365";
            this.btnOffice365.UseVisualStyleBackColor = true;
            this.btnOffice365.Click += new System.EventHandler(this.btnOffice365_Click);
            // 
            // btnSalary
            // 
            this.btnSalary.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSalary.Location = new System.Drawing.Point(6, 6);
            this.btnSalary.Name = "btnSalary";
            this.btnSalary.Size = new System.Drawing.Size(125, 67);
            this.btnSalary.TabIndex = 0;
            this.btnSalary.Text = "6111-Salary";
            this.btnSalary.UseVisualStyleBackColor = true;
            this.btnSalary.Click += new System.EventHandler(this.btnSalary_Click);
            // 
            // tbVerifyAssetsInfo
            // 
            this.tbVerifyAssetsInfo.Controls.Add(this.chDisplayAssetCost);
            this.tbVerifyAssetsInfo.Controls.Add(this.label8);
            this.tbVerifyAssetsInfo.Controls.Add(this.lblmsg);
            this.tbVerifyAssetsInfo.Controls.Add(this.assetsVerifyMsg);
            this.tbVerifyAssetsInfo.Controls.Add(this.datetimecontrol);
            this.tbVerifyAssetsInfo.Controls.Add(this.dgVerifyAssetsInfo);
            this.tbVerifyAssetsInfo.Controls.Add(this.btnAssetsExport);
            this.tbVerifyAssetsInfo.Controls.Add(this.btnVerifyAssetsData);
            this.tbVerifyAssetsInfo.Location = new System.Drawing.Point(4, 22);
            this.tbVerifyAssetsInfo.Name = "tbVerifyAssetsInfo";
            this.tbVerifyAssetsInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbVerifyAssetsInfo.Size = new System.Drawing.Size(1796, 723);
            this.tbVerifyAssetsInfo.TabIndex = 16;
            this.tbVerifyAssetsInfo.Text = "資產折舊勾稽比對";
            this.tbVerifyAssetsInfo.UseVisualStyleBackColor = true;
            // 
            // chDisplayAssetCost
            // 
            this.chDisplayAssetCost.AutoSize = true;
            this.chDisplayAssetCost.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chDisplayAssetCost.Location = new System.Drawing.Point(1578, 39);
            this.chDisplayAssetCost.Name = "chDisplayAssetCost";
            this.chDisplayAssetCost.Size = new System.Drawing.Size(90, 20);
            this.chDisplayAssetCost.TabIndex = 6;
            this.chDisplayAssetCost.Text = "全部顯示";
            this.chDisplayAssetCost.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(1412, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 19);
            this.label8.TabIndex = 5;
            this.label8.Text = "年份";
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblmsg.Location = new System.Drawing.Point(1412, 40);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(47, 19);
            this.lblmsg.TabIndex = 5;
            this.lblmsg.Text = "訊息";
            // 
            // assetsVerifyMsg
            // 
            this.assetsVerifyMsg.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.assetsVerifyMsg.FormattingEnabled = true;
            this.assetsVerifyMsg.HorizontalScrollbar = true;
            this.assetsVerifyMsg.ItemHeight = 16;
            this.assetsVerifyMsg.Location = new System.Drawing.Point(1412, 64);
            this.assetsVerifyMsg.Name = "assetsVerifyMsg";
            this.assetsVerifyMsg.Size = new System.Drawing.Size(367, 676);
            this.assetsVerifyMsg.TabIndex = 4;
            // 
            // datetimecontrol
            // 
            this.datetimecontrol.Location = new System.Drawing.Point(1465, 6);
            this.datetimecontrol.Name = "datetimecontrol";
            this.datetimecontrol.Size = new System.Drawing.Size(200, 22);
            this.datetimecontrol.TabIndex = 3;
            // 
            // dgVerifyAssetsInfo
            // 
            this.dgVerifyAssetsInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVerifyAssetsInfo.Location = new System.Drawing.Point(33, 83);
            this.dgVerifyAssetsInfo.Name = "dgVerifyAssetsInfo";
            this.dgVerifyAssetsInfo.RowTemplate.Height = 24;
            this.dgVerifyAssetsInfo.Size = new System.Drawing.Size(1373, 657);
            this.dgVerifyAssetsInfo.TabIndex = 1;
            // 
            // btnAssetsExport
            // 
            this.btnAssetsExport.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAssetsExport.Location = new System.Drawing.Point(1116, 6);
            this.btnAssetsExport.Name = "btnAssetsExport";
            this.btnAssetsExport.Size = new System.Drawing.Size(290, 73);
            this.btnAssetsExport.TabIndex = 0;
            this.btnAssetsExport.Text = "匯出";
            this.btnAssetsExport.UseVisualStyleBackColor = true;
            this.btnAssetsExport.Click += new System.EventHandler(this.btnAssetsExport_Click);
            // 
            // btnVerifyAssetsData
            // 
            this.btnVerifyAssetsData.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnVerifyAssetsData.Location = new System.Drawing.Point(33, 6);
            this.btnVerifyAssetsData.Name = "btnVerifyAssetsData";
            this.btnVerifyAssetsData.Size = new System.Drawing.Size(1077, 73);
            this.btnVerifyAssetsData.TabIndex = 0;
            this.btnVerifyAssetsData.Text = "帳目比對";
            this.btnVerifyAssetsData.UseVisualStyleBackColor = true;
            this.btnVerifyAssetsData.Click += new System.EventHandler(this.btnVerifyAssetsData_Click);
            // 
            // tbImports
            // 
            this.tbImports.Controls.Add(this.plBalancePaper);
            this.tbImports.Controls.Add(this.plIncomePaper);
            this.tbImports.Controls.Add(this.plAiPaper);
            this.tbImports.Controls.Add(this.btnBalanceSheet);
            this.tbImports.Controls.Add(this.btnFinancialIncome);
            this.tbImports.Controls.Add(this.btnImportVerItem);
            this.tbImports.Location = new System.Drawing.Point(4, 22);
            this.tbImports.Name = "tbImports";
            this.tbImports.Padding = new System.Windows.Forms.Padding(3);
            this.tbImports.Size = new System.Drawing.Size(1362, 723);
            this.tbImports.TabIndex = 11;
            this.tbImports.Text = "公司帳務匯入";
            this.tbImports.UseVisualStyleBackColor = true;
            // 
            // plBalancePaper
            // 
            this.plBalancePaper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.plBalancePaper.Location = new System.Drawing.Point(473, 98);
            this.plBalancePaper.Name = "plBalancePaper";
            this.plBalancePaper.Size = new System.Drawing.Size(192, 165);
            this.plBalancePaper.TabIndex = 4;
            // 
            // plIncomePaper
            // 
            this.plIncomePaper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.plIncomePaper.Location = new System.Drawing.Point(292, 98);
            this.plIncomePaper.Name = "plIncomePaper";
            this.plIncomePaper.Size = new System.Drawing.Size(175, 165);
            this.plIncomePaper.TabIndex = 3;
            // 
            // plAiPaper
            // 
            this.plAiPaper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.plAiPaper.Location = new System.Drawing.Point(111, 98);
            this.plAiPaper.Name = "plAiPaper";
            this.plAiPaper.Size = new System.Drawing.Size(175, 165);
            this.plAiPaper.TabIndex = 2;
            // 
            // btnBalanceSheet
            // 
            this.btnBalanceSheet.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBalanceSheet.Location = new System.Drawing.Point(473, 23);
            this.btnBalanceSheet.Name = "btnBalanceSheet";
            this.btnBalanceSheet.Size = new System.Drawing.Size(192, 69);
            this.btnBalanceSheet.TabIndex = 0;
            this.btnBalanceSheet.Text = "資產負債表格式";
            this.btnBalanceSheet.UseVisualStyleBackColor = true;
            this.btnBalanceSheet.Click += new System.EventHandler(this.btnBalanceSheet_Click);
            // 
            // btnFinancialIncome
            // 
            this.btnFinancialIncome.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFinancialIncome.Location = new System.Drawing.Point(292, 23);
            this.btnFinancialIncome.Name = "btnFinancialIncome";
            this.btnFinancialIncome.Size = new System.Drawing.Size(175, 69);
            this.btnFinancialIncome.TabIndex = 0;
            this.btnFinancialIncome.Text = "損益表格式";
            this.btnFinancialIncome.UseVisualStyleBackColor = true;
            this.btnFinancialIncome.Click += new System.EventHandler(this.btnFinancialIncome_Click);
            // 
            // btnImportVerItem
            // 
            this.btnImportVerItem.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnImportVerItem.Location = new System.Drawing.Point(111, 23);
            this.btnImportVerItem.Name = "btnImportVerItem";
            this.btnImportVerItem.Size = new System.Drawing.Size(175, 69);
            this.btnImportVerItem.TabIndex = 0;
            this.btnImportVerItem.Text = "智慧比對帳務";
            this.btnImportVerItem.UseVisualStyleBackColor = true;
            this.btnImportVerItem.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(1197, 6);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 327);
            this.checkedListBox1.TabIndex = 1;
            // 
            // lstInvoice
            // 
            this.lstInvoice.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lstInvoice.FormattingEnabled = true;
            this.lstInvoice.ItemHeight = 19;
            this.lstInvoice.Items.AddRange(new object[] {
            "1:薪資",
            "2:辦公租金",
            "3:業務支出",
            "5:勞健保",
            "6:Office365",
            "7:營業地租金",
            "8:yes123人力銀行",
            "9:廣告費網站",
            "10:電話費",
            "11:有線電話"});
            this.lstInvoice.Location = new System.Drawing.Point(0, 0);
            this.lstInvoice.Name = "lstInvoice";
            this.lstInvoice.Size = new System.Drawing.Size(188, 289);
            this.lstInvoice.TabIndex = 1;
            // 
            // frmFinancial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1804, 749);
            this.Controls.Add(this.lblYearNo);
            this.Controls.Add(this.lblResult);
            this.Name = "frmFinancial";
            this.Text = "金心會計資訊系統";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FinancialFrm_FormClosed);
            this.Load += new System.EventHandler(this.Financefrm_Load);
            this.lblYearNo.ResumeLayout(false);
            this.TPConvertDataPage.ResumeLayout(false);
            this.TPConvertDataPage.PerformLayout();
            this.gbOPtionFile.ResumeLayout(false);
            this.gbOPtionFile.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.TPViewer.ResumeLayout(false);
            this.TPViewer.PerformLayout();
            this.gpViewer.ResumeLayout(false);
            this.gpViewer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTabView)).EndInit();
            this.DiaryBook.ResumeLayout(false);
            this.DiaryBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAccAccountsData)).EndInit();
            this.plAccInputPanel.ResumeLayout(false);
            this.plAccInputPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCostItemView)).EndInit();
            this.TPQuery.ResumeLayout(false);
            this.TPQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgQueryData)).EndInit();
            this.TPAccountLedger.ResumeLayout(false);
            this.TPAccountLedger.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLedger)).EndInit();
            this.TPClassType.ResumeLayout(false);
            this.TPClassType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClassData)).EndInit();
            this.TPClassDetail.ResumeLayout(false);
            this.TPVerifyAcc.ResumeLayout(false);
            this.tbAccConfirm.ResumeLayout(false);
            this.tbAccConfirm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgControl)).EndInit();
            this.tabReport.ResumeLayout(false);
            this.tabReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFinancialLedger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgFinancialSettlGridView)).EndInit();
            this.tbFinancialIncome.ResumeLayout(false);
            this.tbFinancialIncome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgIncomeFinancial)).EndInit();
            this.TabBalanceRpt.ResumeLayout(false);
            this.TabBalanceRpt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBalanceFinancial)).EndInit();
            this.TabExport.ResumeLayout(false);
            this.TabExport.PerformLayout();
            this.TbSetting.ResumeLayout(false);
            this.TbSetting.PerformLayout();
            this.tbAccFunctions.ResumeLayout(false);
            this.TPAccAmount.ResumeLayout(false);
            this.TPInvContract.ResumeLayout(false);
            this.TPCost.ResumeLayout(false);
            this.TPCost.PerformLayout();
            this.CtlInvoice.ResumeLayout(false);
            this.CtlInvoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCostData)).EndInit();
            this.TPCostDataView.ResumeLayout(false);
            this.tbMoney.ResumeLayout(false);
            this.tbMoney.PerformLayout();
            this.goAccType.ResumeLayout(false);
            this.goAccType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMoney02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMoney01)).EndInit();
            this.TbAssets.ResumeLayout(false);
            this.tbViewData.ResumeLayout(false);
            this.tbViewData.PerformLayout();
            this.tbVerifyAssetsInfo.ResumeLayout(false);
            this.tbVerifyAssetsInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVerifyAssetsInfo)).EndInit();
            this.tbImports.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TabControl lblYearNo;
        private System.Windows.Forms.TabPage TPConvertDataPage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rboptions02;
        private System.Windows.Forms.RadioButton rboption01;
        private System.Windows.Forms.Button btnGenrateData;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ListBox Filelst2;
        private System.Windows.Forms.ListBox Filelst;
        private System.Windows.Forms.TabPage TPCost;
        private System.Windows.Forms.TabPage TPQuery;
        private System.Windows.Forms.TabPage TPAccAmount;
        private System.Windows.Forms.DataGridView dgCostData;
        private System.Windows.Forms.GroupBox gbOPtionFile;
        private System.Windows.Forms.RadioButton radioDB;
        private System.Windows.Forms.RadioButton radioFile;
        private System.Windows.Forms.ListBox lstMsg;
        private System.Windows.Forms.Panel CtlInvoice;
        private System.Windows.Forms.TextBox txCostBuyID;
        private System.Windows.Forms.TextBox txCostSellID;
        private System.Windows.Forms.CheckBox chCostTax;
        private System.Windows.Forms.CheckBox chCostAll;
        private System.Windows.Forms.ListBox lstCostMonthList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTitle02;
        private System.Windows.Forms.Label lblSellID;
        private System.Windows.Forms.Label lblTitle01;
        private System.Windows.Forms.ComboBox cxCostDataType;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txCostTaxAmount;
        private System.Windows.Forms.TextBox txCostAmount;
        private System.Windows.Forms.TextBox txCostInvoiceID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCostAdd;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TextBox txQueryAccMonth;
        private System.Windows.Forms.Label lblQueryAccMonth;
        private System.Windows.Forms.DataGridView dgQueryData;
     //   private Controls.usrAccForm usrAccForm1;
        private System.Windows.Forms.TabPage TPClassType;
        private System.Windows.Forms.DataGridView dgClassData;
        private System.Windows.Forms.Button btnClassUpdate;
        private System.Windows.Forms.Button btnClassAdd;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.TextBox txClassName;
        private System.Windows.Forms.Label lblSN;
        private System.Windows.Forms.TextBox txClassNO;
        private System.Windows.Forms.Button btnCostUpdate;
        private System.Windows.Forms.Label lblInvoiceLst;
        private System.Windows.Forms.ListBox Filelst3;
        private System.Windows.Forms.TabPage TPViewer;
        private System.Windows.Forms.DataGridView dgTabView;
        private System.Windows.Forms.GroupBox gpViewer;
        private System.Windows.Forms.RadioButton radioBook;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.RadioButton radioBookItem;
        private System.Windows.Forms.TabPage TPAccountLedger;
        private System.Windows.Forms.Label lblLend;
        private System.Windows.Forms.DataGridView dgLedger;
        private System.Windows.Forms.Label lblLedgerLend;
        private System.Windows.Forms.Label lblGet;
        private System.Windows.Forms.Label lblLedgerGetVal;
        private System.Windows.Forms.Button btnALegerQuery;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblLedgerResult;
        private System.Windows.Forms.CheckBox chUpdateDBResource;
        private System.Windows.Forms.Label lblViewStatus;
        private System.Windows.Forms.TabPage TPCostDataView;
    //    private Controls.AddQueryDataForm addQueryDataForm1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TabPage TPVerifyAcc;
     //   private Controls.UpdateForm UpdateFormInvoice;
        private System.Windows.Forms.ListBox lstInvoice;
        private System.Windows.Forms.ComboBox coClassType;
        private System.Windows.Forms.Label lblClassTitle01;
    //    private Controls.usrAccForm usrAccForm2;
        private System.Windows.Forms.TabPage TPClassDetail;
        private System.Windows.Forms.TabPage tbImports;
        private System.Windows.Forms.Button btnImportVerItem;
        private System.Windows.Forms.TabPage tbMoney;
        private System.Windows.Forms.Button btnMoney;
        private System.Windows.Forms.ListBox lstMoneyMsg;
        private System.Windows.Forms.DataGridView dataMoney02;
        private System.Windows.Forms.DataGridView dataMoney01;
        private System.Windows.Forms.GroupBox goAccType;
        private System.Windows.Forms.RadioButton rbType01;
        private System.Windows.Forms.RadioButton rbType02;
        private System.Windows.Forms.Label lblMonthTitle;
        private System.Windows.Forms.ListBox lstMonths;
        private System.Windows.Forms.TextBox txtCostDescData;
        private System.Windows.Forms.Label lblMoneyQuery;
        private System.Windows.Forms.TextBox txtMCostAccID;
        private System.Windows.Forms.Label lbl_Accid;
        private System.Windows.Forms.CheckBox cokMonMALL;
        private System.Windows.Forms.Button btnMoneyVeriy;
        private System.Windows.Forms.TextBox txtValidDescData;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtValidMAccID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tbViewData;
        private System.Windows.Forms.Button btnSalary;
        private System.Windows.Forms.Button btnPhone;
        private System.Windows.Forms.Button btnOffice365;
        private System.Windows.Forms.TabPage TbAssets;
        private System.Windows.Forms.TabPage TPInvContract;
      //  private Controls.AddQueryDataForm addQueryDataForm2;
      //  private Controls.FrmDataMaintain frmMainAssets;
      //  private Controls.UpdateListForm updateListForm1;
        private Controls.UpdateListForm updateVerifyAcc;
        private Controls.AddQueryDataForm addQueryInvContract;
        private Controls.AddQueryDataForm AddQueryCostData;
        private Controls.MasterUserControl masterCtl01;
        private Controls.AddQueryDataForm addQueryDataForm4;
        private Controls.FrmDataMaintain frmAssets;
        private System.Windows.Forms.Button btnAssetsVerify;
        private System.Windows.Forms.Button btnpayableSalary;
        private System.Windows.Forms.Button btnpayable;
        private System.Windows.Forms.Button btndividend;
        private System.Windows.Forms.Button btnInterest;
        private System.Windows.Forms.Button btnFinance;
        private System.Windows.Forms.Button btnCostItemUpdate;
        private System.Windows.Forms.Button btnRebuildIndx;
        private System.Windows.Forms.Button btnBalance;
        private System.Windows.Forms.Button btn_Depreciation_Cost;
        private System.Windows.Forms.Button btnAssets;
        private System.Windows.Forms.Button btn_payfirstLaborInsurance;
        private System.Windows.Forms.Button btn_prepay_product;
        private System.Windows.Forms.Button btn_rate;
        private System.Windows.Forms.Button btn_travel_income;
        private System.Windows.Forms.Button btnOthersCost;
        private System.Windows.Forms.Button btn_pre_payrate;
        private System.Windows.Forms.Button btn_gift;
        private System.Windows.Forms.Button btn_Cost_Income;
        private System.Windows.Forms.Button btnVierfyAcc;
        private System.Windows.Forms.Button btnCancelCheck;
        private System.Windows.Forms.Label lblAcc_NO_Wait;
        private System.Windows.Forms.Label lblAcc_Verifying;
        private System.Windows.Forms.ListBox lstNoVerifyData;
        private System.Windows.Forms.ListBox lstVerifyData;
        private System.Windows.Forms.TabPage tbAccConfirm;
        private System.Windows.Forms.Button btnViewRefresh;
        private System.Windows.Forms.Label lblVerifyOK;
        private System.Windows.Forms.ListBox lstVerifing;
        private System.Windows.Forms.Button btnConfirmQuery;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox lstVerifyAccds;
        private System.Windows.Forms.Label lblLstAccIDs;
        private System.Windows.Forms.DataGridView dgControl;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.CheckBox chConfirmAll;
        private System.Windows.Forms.Button btnAccExport;
        private System.Windows.Forms.TabPage tbVerifyAssetsInfo;
        private System.Windows.Forms.DataGridView dgVerifyAssetsInfo;
        private System.Windows.Forms.Button btnVerifyAssetsData;
        private System.Windows.Forms.DateTimePicker datetimecontrol;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.ListBox assetsVerifyMsg;
        private System.Windows.Forms.CheckBox chDisplayAssetCost;
        private System.Windows.Forms.Button btnAssetsExport;
        private System.Windows.Forms.ListBox lstAccConfirmMsg;
        private System.Windows.Forms.Button btnAnalyzeAccs;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnWorkCost;
        private System.Windows.Forms.TabPage tabReport;
        private System.Windows.Forms.Button btnSettle;
        private System.Windows.Forms.Label lblsettleMsg;
        private System.Windows.Forms.ListBox LstFinanacialMsg;
        private System.Windows.Forms.DataGridView dgFinancialSettlGridView;
        private System.Windows.Forms.Button btnSetttleQuery;
        private System.Windows.Forms.TabPage tbFinancialIncome;
        private System.Windows.Forms.Button btnIncomeFinancial;
        private System.Windows.Forms.Label lblIncomeStatement;
        private System.Windows.Forms.DataGridView dgIncomeFinancial;
        private System.Windows.Forms.Button btnArrangeNew;
        private System.Windows.Forms.Button btnCheckAccNo;
        private System.Windows.Forms.Button btnCheckAccounts;
        private System.Windows.Forms.DataGridView dataFinancialLedger;
        private System.Windows.Forms.Button btnFinancialIncome;
        private System.Windows.Forms.Label lblFinancialRptCnt;
        private System.Windows.Forms.Button btnBalanceSheet;
        private System.Windows.Forms.TabPage TabBalanceRpt;
        private System.Windows.Forms.DataGridView dgBalanceFinancial;
        private System.Windows.Forms.Button btnFinanceBalance;
        private System.Windows.Forms.Label lblFinanceBalance;
        private System.Windows.Forms.Label lblBalanceSheetCnt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox lstMsgIncomeStatment;
        private System.Windows.Forms.Button btnReportExport;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListBox lstMsgFinanceBalance;
        private System.Windows.Forms.Button btnReportExportData;
        private System.Windows.Forms.Button btnIncomeReport;
        private System.Windows.Forms.Button btnBalanceReport;
        private System.Windows.Forms.TabPage DiaryBook;
        private System.Windows.Forms.DataGridView dgCostItemView;
        private System.Windows.Forms.Panel plAccInputPanel;
        private System.Windows.Forms.Button btnDiarySelection;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox lblInputPos;
        private System.Windows.Forms.TextBox txDiaAccNo;
        private System.Windows.Forms.TextBox txDiaAccDesc;
        private System.Windows.Forms.TextBox txAccDatatype;
        private System.Windows.Forms.TextBox txDiaAmount;
        private System.Windows.Forms.Label lblDiary;
        private System.Windows.Forms.TextBox txDiaAccID;
        private System.Windows.Forms.Label lblDiaryAmount;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblDiaryDate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtAccPicker;
        private System.Windows.Forms.DataGridView dgAccAccountsData;
        private System.Windows.Forms.TabPage tbAccFunctions;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAccConfirm;
        private System.Windows.Forms.Button btnAccInputRecord;
        private System.Windows.Forms.Label lblDiaNoValue;
        private System.Windows.Forms.Label lblDiaNo;
        private System.Windows.Forms.Button btnAccInputNew;
        private System.Windows.Forms.Label lblQueryAccYear;
        private System.Windows.Forms.TextBox txQueryAccYear;
        private System.Windows.Forms.Button btnDeleteQueryAcc;
        private System.Windows.Forms.Label lblAccInputYear;
        private System.Windows.Forms.TextBox txAccYear;
        private System.Windows.Forms.TextBox txAccMonth;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAccGenerate;
        private System.Windows.Forms.Button btnDiaryCreate;
        private System.Windows.Forms.Button btnDiaryExport;
        private System.Windows.Forms.CheckBox chQueryAcc;
        private System.Windows.Forms.Button btnAccInputSave;
        private System.Windows.Forms.Label lblSuggestResult;
        private System.Windows.Forms.Label lblaccsuggest;
        private System.Windows.Forms.Label lblWhereInput;
        private System.Windows.Forms.Label lblAccInputPos;
        private System.Windows.Forms.Button btnAccQuery;
        private System.Windows.Forms.TextBox txAccInputdgAcc;
        private System.Windows.Forms.Label lblAccInputdgAcc;
        private System.Windows.Forms.Button btnAccInputCost;
        private System.Windows.Forms.Panel plBalancePaper;
        private System.Windows.Forms.Panel plIncomePaper;
        private System.Windows.Forms.Panel plAiPaper;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage TabExport;
        private System.Windows.Forms.Button btnExportAccounting;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ListBox lstAccounting;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInteliAccDelete;
        private System.Windows.Forms.TabPage TbSetting;
        private System.Windows.Forms.Button btnSetup;
        private System.Windows.Forms.TextBox txtSYear;
        private System.Windows.Forms.Label lblSYear;
        private System.Windows.Forms.CheckBox chDataFull;
        private System.Windows.Forms.CheckBox chExportVerify;
        private System.Windows.Forms.Label lblBookLend;
        private System.Windows.Forms.Label lblBookTitleGet;
        private System.Windows.Forms.Label lblBookGet;
        private System.Windows.Forms.Label lblBookTitleLend;
        private System.Windows.Forms.Button btnBalanceReportData;
    }
}

