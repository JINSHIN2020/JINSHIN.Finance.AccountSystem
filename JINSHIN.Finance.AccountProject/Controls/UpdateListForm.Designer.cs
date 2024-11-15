using JINSHIN.FinanceAccounting.DB;

namespace FinanceAccountProgram.Controls
{
    partial class UpdateListForm
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

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txUpdateAcc = new System.Windows.Forms.TextBox();
            this.lblQueryAcc = new System.Windows.Forms.Label();
            this.btnIntegrate = new System.Windows.Forms.Button();
            this.dgControl = new System.Windows.Forms.DataGridView();
            this.BtnQuery = new System.Windows.Forms.Button();
            this.lblDetails = new System.Windows.Forms.Label();
            this.lblClassType = new System.Windows.Forms.Label();
            this.listContents = new System.Windows.Forms.ListBox();
            this.ListAccType = new System.Windows.Forms.ListBox();
            this.listMaster = new System.Windows.Forms.ListBox();
            this.lblAccType = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnVerify = new System.Windows.Forms.Button();
            this.lblVerifyDesc = new System.Windows.Forms.Label();
            this.txUpdateDesc = new System.Windows.Forms.TextBox();
            this.btnReserved = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txUpdateAccID = new System.Windows.Forms.TextBox();
            this.lstUpdateMonths = new System.Windows.Forms.ListBox();
            this.lblLstMonths = new System.Windows.Forms.Label();
            this.coUpdateAll = new System.Windows.Forms.CheckBox();
            this.btnUpdateExport = new System.Windows.Forms.Button();
            this.btnVerifyAccExport = new System.Windows.Forms.Button();
            this.lblVerifyTitle = new System.Windows.Forms.Label();
            this.txUpdateAmount = new System.Windows.Forms.TextBox();
            this.lblAccYear = new System.Windows.Forms.Label();
            this.txAccYear = new System.Windows.Forms.TextBox();
            this.lblAllCnt = new System.Windows.Forms.Label();
            this.lblDataAllCnt = new System.Windows.Forms.Label();
            this.lblSetupDataCnt = new System.Windows.Forms.Label();
            this.txtDataCnt = new System.Windows.Forms.TextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnTestEdit = new System.Windows.Forms.Button();
            this.btnInvCheck = new System.Windows.Forms.Button();
            this.lstList = new System.Windows.Forms.ListBox();
            this.btnMontnApply = new System.Windows.Forms.Button();
            this.lblInvocie = new System.Windows.Forms.Label();
            this.txtInvoice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgControl)).BeginInit();
            this.SuspendLayout();
            // 
            // txUpdateAcc
            // 
            this.txUpdateAcc.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txUpdateAcc.Location = new System.Drawing.Point(124, 14);
            this.txUpdateAcc.Margin = new System.Windows.Forms.Padding(4);
            this.txUpdateAcc.Name = "txUpdateAcc";
            this.txUpdateAcc.Size = new System.Drawing.Size(188, 30);
            this.txUpdateAcc.TabIndex = 34;
            // 
            // lblQueryAcc
            // 
            this.lblQueryAcc.AutoSize = true;
            this.lblQueryAcc.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblQueryAcc.Location = new System.Drawing.Point(-7, 21);
            this.lblQueryAcc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQueryAcc.Name = "lblQueryAcc";
            this.lblQueryAcc.Size = new System.Drawing.Size(85, 19);
            this.lblQueryAcc.TabIndex = 33;
            this.lblQueryAcc.Text = "會計傳票";
            // 
            // btnIntegrate
            // 
            this.btnIntegrate.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnIntegrate.Location = new System.Drawing.Point(1371, 201);
            this.btnIntegrate.Margin = new System.Windows.Forms.Padding(4);
            this.btnIntegrate.Name = "btnIntegrate";
            this.btnIntegrate.Size = new System.Drawing.Size(179, 68);
            this.btnIntegrate.TabIndex = 32;
            this.btnIntegrate.Text = "整合";
            this.btnIntegrate.UseVisualStyleBackColor = true;
            this.btnIntegrate.Visible = false;
            this.btnIntegrate.Click += new System.EventHandler(this.btnIntegrate_Click);
            // 
            // dgControl
            // 
            this.dgControl.AllowUserToOrderColumns = true;
            this.dgControl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgControl.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgControl.Location = new System.Drawing.Point(9, 279);
            this.dgControl.Margin = new System.Windows.Forms.Padding(4);
            this.dgControl.Name = "dgControl";
            this.dgControl.RowTemplate.Height = 24;
            this.dgControl.Size = new System.Drawing.Size(2263, 866);
            this.dgControl.TabIndex = 31;
            this.dgControl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgControl_CellClick);
            this.dgControl.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgControl_CellContentClick_1);
            this.dgControl.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgControl_CellFormatting);
            this.dgControl.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgControl_CellLeave);
            this.dgControl.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgControl_CellMouseClick);
            this.dgControl.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgControl_CellValueChanged);
            this.dgControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgControl_KeyDown);
            // 
            // BtnQuery
            // 
            this.BtnQuery.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnQuery.Location = new System.Drawing.Point(1371, 29);
            this.BtnQuery.Margin = new System.Windows.Forms.Padding(4);
            this.BtnQuery.Name = "BtnQuery";
            this.BtnQuery.Size = new System.Drawing.Size(179, 68);
            this.BtnQuery.TabIndex = 32;
            this.BtnQuery.Text = "查詢";
            this.BtnQuery.UseVisualStyleBackColor = true;
            this.BtnQuery.Click += new System.EventHandler(this.BtnQuery_Click);
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDetails.Location = new System.Drawing.Point(2611, 21);
            this.lblDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(85, 19);
            this.lblDetails.TabIndex = 39;
            this.lblDetails.Text = "帳目明細";
            this.lblDetails.Visible = false;
            // 
            // lblClassType
            // 
            this.lblClassType.AutoSize = true;
            this.lblClassType.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblClassType.Location = new System.Drawing.Point(2312, 375);
            this.lblClassType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClassType.Name = "lblClassType";
            this.lblClassType.Size = new System.Drawing.Size(85, 19);
            this.lblClassType.TabIndex = 40;
            this.lblClassType.Text = "帳目類別";
            this.lblClassType.Visible = false;
            // 
            // listContents
            // 
            this.listContents.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listContents.FormattingEnabled = true;
            this.listContents.ItemHeight = 19;
            this.listContents.Location = new System.Drawing.Point(2613, 50);
            this.listContents.Margin = new System.Windows.Forms.Padding(4);
            this.listContents.Name = "listContents";
            this.listContents.Size = new System.Drawing.Size(284, 821);
            this.listContents.TabIndex = 37;
            this.listContents.Visible = false;
            this.listContents.SelectedIndexChanged += new System.EventHandler(this.ListAccType_SelectedValueChanged);
            // 
            // ListAccType
            // 
            this.ListAccType.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ListAccType.FormattingEnabled = true;
            this.ListAccType.ItemHeight = 19;
            this.ListAccType.Location = new System.Drawing.Point(2316, 49);
            this.ListAccType.Margin = new System.Windows.Forms.Padding(4);
            this.ListAccType.Name = "ListAccType";
            this.ListAccType.Size = new System.Drawing.Size(284, 308);
            this.ListAccType.TabIndex = 38;
            this.ListAccType.Visible = false;
            this.ListAccType.SelectedIndexChanged += new System.EventHandler(this.ListAccType_SelectedIndexChanged);
            this.ListAccType.SelectedValueChanged += new System.EventHandler(this.ListAccType_SelectedValueChanged);
            // 
            // listMaster
            // 
            this.listMaster.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listMaster.FormattingEnabled = true;
            this.listMaster.ItemHeight = 19;
            this.listMaster.Location = new System.Drawing.Point(2315, 406);
            this.listMaster.Margin = new System.Windows.Forms.Padding(4);
            this.listMaster.Name = "listMaster";
            this.listMaster.Size = new System.Drawing.Size(284, 479);
            this.listMaster.TabIndex = 37;
            this.listMaster.Visible = false;
            this.listMaster.SelectedIndexChanged += new System.EventHandler(this.ListAccType_SelectedValueChanged);
            // 
            // lblAccType
            // 
            this.lblAccType.AutoSize = true;
            this.lblAccType.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAccType.Location = new System.Drawing.Point(2316, 21);
            this.lblAccType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccType.Name = "lblAccType";
            this.lblAccType.Size = new System.Drawing.Size(85, 19);
            this.lblAccType.TabIndex = 40;
            this.lblAccType.Text = "憑證類別";
            this.lblAccType.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUpdate.Location = new System.Drawing.Point(1164, 29);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(179, 68);
            this.btnUpdate.TabIndex = 32;
            this.btnUpdate.Text = "更新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnVerify
            // 
            this.btnVerify.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnVerify.Location = new System.Drawing.Point(2671, 894);
            this.btnVerify.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(179, 68);
            this.btnVerify.TabIndex = 32;
            this.btnVerify.Text = "稽核";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Visible = false;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // lblVerifyDesc
            // 
            this.lblVerifyDesc.AutoSize = true;
            this.lblVerifyDesc.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblVerifyDesc.Location = new System.Drawing.Point(321, 20);
            this.lblVerifyDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVerifyDesc.Name = "lblVerifyDesc";
            this.lblVerifyDesc.Size = new System.Drawing.Size(47, 19);
            this.lblVerifyDesc.TabIndex = 33;
            this.lblVerifyDesc.Text = "摘要";
            // 
            // txUpdateDesc
            // 
            this.txUpdateDesc.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txUpdateDesc.Location = new System.Drawing.Point(395, 14);
            this.txUpdateDesc.Margin = new System.Windows.Forms.Padding(4);
            this.txUpdateDesc.Name = "txUpdateDesc";
            this.txUpdateDesc.Size = new System.Drawing.Size(188, 30);
            this.txUpdateDesc.TabIndex = 34;
            // 
            // btnReserved
            // 
            this.btnReserved.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReserved.Location = new System.Drawing.Point(1164, 201);
            this.btnReserved.Margin = new System.Windows.Forms.Padding(4);
            this.btnReserved.Name = "btnReserved";
            this.btnReserved.Size = new System.Drawing.Size(179, 68);
            this.btnReserved.TabIndex = 32;
            this.btnReserved.Text = "沖帳";
            this.btnReserved.UseVisualStyleBackColor = true;
            this.btnReserved.Visible = false;
            this.btnReserved.Click += new System.EventHandler(this.btnReserved_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(-7, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 33;
            this.label1.Text = "會計科目";
            // 
            // txUpdateAccID
            // 
            this.txUpdateAccID.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txUpdateAccID.Location = new System.Drawing.Point(124, 66);
            this.txUpdateAccID.Margin = new System.Windows.Forms.Padding(4);
            this.txUpdateAccID.Name = "txUpdateAccID";
            this.txUpdateAccID.Size = new System.Drawing.Size(188, 30);
            this.txUpdateAccID.TabIndex = 34;
            // 
            // lstUpdateMonths
            // 
            this.lstUpdateMonths.ColumnWidth = 50;
            this.lstUpdateMonths.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lstUpdateMonths.FormattingEnabled = true;
            this.lstUpdateMonths.ItemHeight = 24;
            this.lstUpdateMonths.Items.AddRange(new object[] {
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
            this.lstUpdateMonths.Location = new System.Drawing.Point(393, 120);
            this.lstUpdateMonths.Margin = new System.Windows.Forms.Padding(4);
            this.lstUpdateMonths.MultiColumn = true;
            this.lstUpdateMonths.Name = "lstUpdateMonths";
            this.lstUpdateMonths.Size = new System.Drawing.Size(315, 76);
            this.lstUpdateMonths.TabIndex = 42;
            // 
            // lblLstMonths
            // 
            this.lblLstMonths.AutoSize = true;
            this.lblLstMonths.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblLstMonths.Location = new System.Drawing.Point(321, 121);
            this.lblLstMonths.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLstMonths.Name = "lblLstMonths";
            this.lblLstMonths.Size = new System.Drawing.Size(47, 19);
            this.lblLstMonths.TabIndex = 33;
            this.lblLstMonths.Text = "月份";
            // 
            // coUpdateAll
            // 
            this.coUpdateAll.AutoSize = true;
            this.coUpdateAll.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.coUpdateAll.Location = new System.Drawing.Point(225, 216);
            this.coUpdateAll.Margin = new System.Windows.Forms.Padding(4);
            this.coUpdateAll.Name = "coUpdateAll";
            this.coUpdateAll.Size = new System.Drawing.Size(104, 23);
            this.coUpdateAll.TabIndex = 43;
            this.coUpdateAll.Text = "全部月份";
            this.coUpdateAll.UseVisualStyleBackColor = true;
            // 
            // btnUpdateExport
            // 
            this.btnUpdateExport.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUpdateExport.Location = new System.Drawing.Point(960, 29);
            this.btnUpdateExport.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateExport.Name = "btnUpdateExport";
            this.btnUpdateExport.Size = new System.Drawing.Size(179, 68);
            this.btnUpdateExport.TabIndex = 32;
            this.btnUpdateExport.Text = "轉入";
            this.btnUpdateExport.UseVisualStyleBackColor = true;
            this.btnUpdateExport.Click += new System.EventHandler(this.btnUpdateExport_Click);
            // 
            // btnVerifyAccExport
            // 
            this.btnVerifyAccExport.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnVerifyAccExport.Location = new System.Drawing.Point(1164, 116);
            this.btnVerifyAccExport.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerifyAccExport.Name = "btnVerifyAccExport";
            this.btnVerifyAccExport.Size = new System.Drawing.Size(179, 68);
            this.btnVerifyAccExport.TabIndex = 32;
            this.btnVerifyAccExport.Text = "匯出";
            this.btnVerifyAccExport.UseVisualStyleBackColor = true;
            this.btnVerifyAccExport.Click += new System.EventHandler(this.btnVerifyAccExport_Click);
            // 
            // lblVerifyTitle
            // 
            this.lblVerifyTitle.AutoSize = true;
            this.lblVerifyTitle.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblVerifyTitle.Location = new System.Drawing.Point(320, 74);
            this.lblVerifyTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVerifyTitle.Name = "lblVerifyTitle";
            this.lblVerifyTitle.Size = new System.Drawing.Size(47, 19);
            this.lblVerifyTitle.TabIndex = 33;
            this.lblVerifyTitle.Text = "金額";
            // 
            // txUpdateAmount
            // 
            this.txUpdateAmount.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txUpdateAmount.Location = new System.Drawing.Point(395, 66);
            this.txUpdateAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txUpdateAmount.Name = "txUpdateAmount";
            this.txUpdateAmount.Size = new System.Drawing.Size(188, 30);
            this.txUpdateAmount.TabIndex = 34;
            // 
            // lblAccYear
            // 
            this.lblAccYear.AutoSize = true;
            this.lblAccYear.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAccYear.Location = new System.Drawing.Point(-7, 128);
            this.lblAccYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccYear.Name = "lblAccYear";
            this.lblAccYear.Size = new System.Drawing.Size(47, 19);
            this.lblAccYear.TabIndex = 33;
            this.lblAccYear.Text = "年份";
            // 
            // txAccYear
            // 
            this.txAccYear.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txAccYear.Location = new System.Drawing.Point(124, 120);
            this.txAccYear.Margin = new System.Windows.Forms.Padding(4);
            this.txAccYear.Name = "txAccYear";
            this.txAccYear.Size = new System.Drawing.Size(188, 30);
            this.txAccYear.TabIndex = 34;
            // 
            // lblAllCnt
            // 
            this.lblAllCnt.AutoSize = true;
            this.lblAllCnt.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAllCnt.Location = new System.Drawing.Point(717, 188);
            this.lblAllCnt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAllCnt.Name = "lblAllCnt";
            this.lblAllCnt.Size = new System.Drawing.Size(104, 19);
            this.lblAllCnt.TabIndex = 33;
            this.lblAllCnt.Text = "資料總筆數";
            // 
            // lblDataAllCnt
            // 
            this.lblDataAllCnt.AutoSize = true;
            this.lblDataAllCnt.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDataAllCnt.Location = new System.Drawing.Point(871, 188);
            this.lblDataAllCnt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataAllCnt.Name = "lblDataAllCnt";
            this.lblDataAllCnt.Size = new System.Drawing.Size(18, 19);
            this.lblDataAllCnt.TabIndex = 33;
            this.lblDataAllCnt.Text = "0";
            // 
            // lblSetupDataCnt
            // 
            this.lblSetupDataCnt.AutoSize = true;
            this.lblSetupDataCnt.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSetupDataCnt.Location = new System.Drawing.Point(717, 135);
            this.lblSetupDataCnt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSetupDataCnt.Name = "lblSetupDataCnt";
            this.lblSetupDataCnt.Size = new System.Drawing.Size(85, 19);
            this.lblSetupDataCnt.TabIndex = 33;
            this.lblSetupDataCnt.Text = "資料筆數";
            // 
            // txtDataCnt
            // 
            this.txtDataCnt.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDataCnt.Location = new System.Drawing.Point(844, 135);
            this.txtDataCnt.Margin = new System.Windows.Forms.Padding(4);
            this.txtDataCnt.Name = "txtDataCnt";
            this.txtDataCnt.Size = new System.Drawing.Size(92, 30);
            this.txtDataCnt.TabIndex = 34;
            this.txtDataCnt.Text = "150";
            this.txtDataCnt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDataCnt_KeyUp);
            // 
            // btnTest
            // 
            this.btnTest.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTest.Location = new System.Drawing.Point(960, 201);
            this.btnTest.Margin = new System.Windows.Forms.Padding(4);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(179, 68);
            this.btnTest.TabIndex = 32;
            this.btnTest.Text = "編碼";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Visible = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnTestEdit
            // 
            this.btnTestEdit.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTestEdit.Location = new System.Drawing.Point(9, 208);
            this.btnTestEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnTestEdit.Name = "btnTestEdit";
            this.btnTestEdit.Size = new System.Drawing.Size(179, 68);
            this.btnTestEdit.TabIndex = 44;
            this.btnTestEdit.Text = "編輯";
            this.btnTestEdit.UseVisualStyleBackColor = true;
            this.btnTestEdit.Visible = false;
            this.btnTestEdit.Click += new System.EventHandler(this.btnTestEdit_Click);
            // 
            // btnInvCheck
            // 
            this.btnInvCheck.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnInvCheck.Location = new System.Drawing.Point(1371, 115);
            this.btnInvCheck.Margin = new System.Windows.Forms.Padding(4);
            this.btnInvCheck.Name = "btnInvCheck";
            this.btnInvCheck.Size = new System.Drawing.Size(179, 68);
            this.btnInvCheck.TabIndex = 44;
            this.btnInvCheck.Text = "檢查傳票";
            this.btnInvCheck.UseVisualStyleBackColor = true;
            this.btnInvCheck.Click += new System.EventHandler(this.btnInvCheck_Click);
            // 
            // lstList
            // 
            this.lstList.FormattingEnabled = true;
            this.lstList.ItemHeight = 15;
            this.lstList.Location = new System.Drawing.Point(1576, 29);
            this.lstList.Margin = new System.Windows.Forms.Padding(4);
            this.lstList.MultiColumn = true;
            this.lstList.Name = "lstList";
            this.lstList.Size = new System.Drawing.Size(695, 229);
            this.lstList.TabIndex = 45;
            // 
            // btnMontnApply
            // 
            this.btnMontnApply.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMontnApply.Location = new System.Drawing.Point(961, 115);
            this.btnMontnApply.Margin = new System.Windows.Forms.Padding(4);
            this.btnMontnApply.Name = "btnMontnApply";
            this.btnMontnApply.Size = new System.Drawing.Size(179, 68);
            this.btnMontnApply.TabIndex = 46;
            this.btnMontnApply.Text = "營業稅申報";
            this.btnMontnApply.UseVisualStyleBackColor = true;
            this.btnMontnApply.Visible = false;
            this.btnMontnApply.Click += new System.EventHandler(this.btnMontnApply_Click);
            // 
            // lblInvocie
            // 
            this.lblInvocie.AutoSize = true;
            this.lblInvocie.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblInvocie.Location = new System.Drawing.Point(-7, 180);
            this.lblInvocie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInvocie.Name = "lblInvocie";
            this.lblInvocie.Size = new System.Drawing.Size(47, 19);
            this.lblInvocie.TabIndex = 47;
            this.lblInvocie.Text = "發票";
            // 
            // txtInvoice
            // 
            this.txtInvoice.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtInvoice.Location = new System.Drawing.Point(124, 172);
            this.txtInvoice.Margin = new System.Windows.Forms.Padding(4);
            this.txtInvoice.Name = "txtInvoice";
            this.txtInvoice.Size = new System.Drawing.Size(188, 30);
            this.txtInvoice.TabIndex = 48;
            // 
            // UpdateListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblInvocie);
            this.Controls.Add(this.txtInvoice);
            this.Controls.Add(this.btnMontnApply);
            this.Controls.Add(this.lstList);
            this.Controls.Add(this.btnInvCheck);
            this.Controls.Add(this.btnTestEdit);
            this.Controls.Add(this.coUpdateAll);
            this.Controls.Add(this.lstUpdateMonths);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.lblAccType);
            this.Controls.Add(this.lblClassType);
            this.Controls.Add(this.listMaster);
            this.Controls.Add(this.listContents);
            this.Controls.Add(this.ListAccType);
            this.Controls.Add(this.txtDataCnt);
            this.Controls.Add(this.txUpdateDesc);
            this.Controls.Add(this.lblAccYear);
            this.Controls.Add(this.lblLstMonths);
            this.Controls.Add(this.lblDataAllCnt);
            this.Controls.Add(this.lblSetupDataCnt);
            this.Controls.Add(this.lblAllCnt);
            this.Controls.Add(this.lblVerifyDesc);
            this.Controls.Add(this.txAccYear);
            this.Controls.Add(this.txUpdateAmount);
            this.Controls.Add(this.lblVerifyTitle);
            this.Controls.Add(this.txUpdateAccID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txUpdateAcc);
            this.Controls.Add(this.lblQueryAcc);
            this.Controls.Add(this.BtnQuery);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnReserved);
            this.Controls.Add(this.btnVerifyAccExport);
            this.Controls.Add(this.btnUpdateExport);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnIntegrate);
            this.Controls.Add(this.dgControl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UpdateListForm";
            this.Size = new System.Drawing.Size(2416, 1145);
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.TextBox txUpdateAcc;
        private System.Windows.Forms.Label lblQueryAcc;
        private System.Windows.Forms.Button btnIntegrate;
        private System.Windows.Forms.DataGridView dgControl;
        private System.Windows.Forms.Button BtnQuery;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Label lblClassType;
        private System.Windows.Forms.ListBox listContents;
        private System.Windows.Forms.ListBox ListAccType;
        private System.Windows.Forms.ListBox listMaster;
        private System.Windows.Forms.Label lblAccType;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Label lblVerifyDesc;
        private System.Windows.Forms.TextBox txUpdateDesc;
        private System.Windows.Forms.Button btnReserved;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txUpdateAccID;
        private System.Windows.Forms.ListBox lstUpdateMonths;
        private System.Windows.Forms.Label lblLstMonths;
        private System.Windows.Forms.CheckBox coUpdateAll;
        private System.Windows.Forms.Button btnUpdateExport;
        private System.Windows.Forms.Button btnVerifyAccExport;
        private System.Windows.Forms.Label lblVerifyTitle;
        private System.Windows.Forms.TextBox txUpdateAmount;
        private System.Windows.Forms.Label lblAccYear;
        private System.Windows.Forms.TextBox txAccYear;
        private System.Windows.Forms.Label lblAllCnt;
        private System.Windows.Forms.Label lblDataAllCnt;
        private System.Windows.Forms.Label lblSetupDataCnt;
        private System.Windows.Forms.TextBox txtDataCnt;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnTestEdit;
        private System.Windows.Forms.Button btnInvCheck;
        private System.Windows.Forms.ListBox lstList;
        private System.Windows.Forms.Button btnMontnApply;
        private System.Windows.Forms.Label lblInvocie;
        private System.Windows.Forms.TextBox txtInvoice;
    }
}
