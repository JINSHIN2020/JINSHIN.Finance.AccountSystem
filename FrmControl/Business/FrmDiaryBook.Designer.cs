namespace FinanceAccountProgram.FrmControl
{
    partial class FrmDiaryBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAccInputNew = new System.Windows.Forms.Button();
            this.btnAccInputSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDiarySelection = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.lblInputPos = new System.Windows.Forms.ComboBox();
            this.txDiaAccDesc = new System.Windows.Forms.TextBox();
            this.txAccDatatype = new System.Windows.Forms.TextBox();
            this.dgAccAccountsData = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAccInputRecord = new System.Windows.Forms.Button();
            this.btnInteliAccDelete = new System.Windows.Forms.Button();
            this.btnAccQuery = new System.Windows.Forms.Button();
            this.txDiaAccNo = new System.Windows.Forms.TextBox();
            this.txDiaAmount = new System.Windows.Forms.TextBox();
            this.txAccInputdgAcc = new System.Windows.Forms.TextBox();
            this.lblAccInputdgAcc = new System.Windows.Forms.Label();
            this.lblDiary = new System.Windows.Forms.Label();
            this.btnAccGenerate = new System.Windows.Forms.Button();
            this.lblAccInputYear = new System.Windows.Forms.Label();
            this.txAccYear = new System.Windows.Forms.TextBox();
            this.txAccMonth = new System.Windows.Forms.TextBox();
            this.btnAccInputCost = new System.Windows.Forms.Button();
            this.btnAccConfirm = new System.Windows.Forms.Button();
            this.dgCostItemView = new System.Windows.Forms.DataGridView();
            this.txDiaAccID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.plAccInputPanel = new System.Windows.Forms.Panel();
            this.btnEmpty = new System.Windows.Forms.Button();
            this.lblDiaryAmount = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblAccInputPos = new System.Windows.Forms.Label();
            this.lblSuggestResult = new System.Windows.Forms.Label();
            this.lblWhereInput = new System.Windows.Forms.Label();
            this.lblaccsuggest = new System.Windows.Forms.Label();
            this.lblDiaNoValue = new System.Windows.Forms.Label();
            this.lblDiaNo = new System.Windows.Forms.Label();
            this.lblDiaryDate = new System.Windows.Forms.Label();
            this.dtAccPicker = new System.Windows.Forms.DateTimePicker();
            this.chSaveAccount = new System.Windows.Forms.CheckBox();
            this.btnProfit = new System.Windows.Forms.Button();
            this.gbProfit = new System.Windows.Forms.GroupBox();
            this.btnUnprofit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAccAccountsData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCostItemView)).BeginInit();
            this.plAccInputPanel.SuspendLayout();
            this.gbProfit.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAccInputNew
            // 
            this.btnAccInputNew.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAccInputNew.Location = new System.Drawing.Point(19, 105);
            this.btnAccInputNew.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAccInputNew.Name = "btnAccInputNew";
            this.btnAccInputNew.Size = new System.Drawing.Size(335, 56);
            this.btnAccInputNew.TabIndex = 32;
            this.btnAccInputNew.Text = "新增";
            this.btnAccInputNew.UseVisualStyleBackColor = true;
            this.btnAccInputNew.Click += new System.EventHandler(this.btnAccInputNew_Click);
            // 
            // btnAccInputSave
            // 
            this.btnAccInputSave.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAccInputSave.Location = new System.Drawing.Point(692, 126);
            this.btnAccInputSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAccInputSave.Name = "btnAccInputSave";
            this.btnAccInputSave.Size = new System.Drawing.Size(289, 56);
            this.btnAccInputSave.TabIndex = 32;
            this.btnAccInputSave.Text = "存檔";
            this.btnAccInputSave.UseVisualStyleBackColor = true;
            this.btnAccInputSave.Click += new System.EventHandler(this.btnAccConfirm_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelete.Location = new System.Drawing.Point(395, 194);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(289, 56);
            this.btnDelete.TabIndex = 32;
            this.btnDelete.Text = "刪除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDiarySelection
            // 
            this.btnDiarySelection.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDiarySelection.Location = new System.Drawing.Point(996, 69);
            this.btnDiarySelection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDiarySelection.Name = "btnDiarySelection";
            this.btnDiarySelection.Size = new System.Drawing.Size(89, 44);
            this.btnDiarySelection.TabIndex = 32;
            this.btnDiarySelection.Text = "...";
            this.btnDiarySelection.UseVisualStyleBackColor = true;
            this.btnDiarySelection.Click += new System.EventHandler(this.btnDiarySelection_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label18.Location = new System.Drawing.Point(1356, 10);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 24);
            this.label18.TabIndex = 31;
            this.label18.Text = "種類";
            // 
            // lblInputPos
            // 
            this.lblInputPos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.lblInputPos.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
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
            this.lblInputPos.Location = new System.Drawing.Point(1425, 6);
            this.lblInputPos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblInputPos.Name = "lblInputPos";
            this.lblInputPos.Size = new System.Drawing.Size(265, 255);
            this.lblInputPos.TabIndex = 30;
            this.lblInputPos.SelectedIndexChanged += new System.EventHandler(this.lblInputPos_SelectedIndexChanged);
            // 
            // txDiaAccDesc
            // 
            this.txDiaAccDesc.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txDiaAccDesc.Location = new System.Drawing.Point(1101, 10);
            this.txDiaAccDesc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txDiaAccDesc.Multiline = true;
            this.txDiaAccDesc.Name = "txDiaAccDesc";
            this.txDiaAccDesc.Size = new System.Drawing.Size(240, 100);
            this.txDiaAccDesc.TabIndex = 28;
            this.txDiaAccDesc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txDiaAccDesc_KeyDown);
            this.txDiaAccDesc.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txDiaAccDesc_MouseDown);
            // 
            // txAccDatatype
            // 
            this.txAccDatatype.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txAccDatatype.Location = new System.Drawing.Point(803, 74);
            this.txAccDatatype.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txAccDatatype.Name = "txAccDatatype";
            this.txAccDatatype.Size = new System.Drawing.Size(180, 35);
            this.txAccDatatype.TabIndex = 29;
            // 
            // dgAccAccountsData
            // 
            this.dgAccAccountsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAccAccountsData.Location = new System.Drawing.Point(16, 291);
            this.dgAccAccountsData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgAccAccountsData.Name = "dgAccAccountsData";
            this.dgAccAccountsData.RowHeadersWidth = 51;
            this.dgAccAccountsData.RowTemplate.Height = 24;
            this.dgAccAccountsData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAccAccountsData.Size = new System.Drawing.Size(1707, 226);
            this.dgAccAccountsData.TabIndex = 46;
            this.dgAccAccountsData.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgAccAccountsData_CellMouseClick);
            this.dgAccAccountsData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgAccAccountsData_KeyDown);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClear.Location = new System.Drawing.Point(1296, 540);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(139, 49);
            this.btnClear.TabIndex = 32;
            this.btnClear.Text = "清除";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Visible = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAccInputRecord
            // 
            this.btnAccInputRecord.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAccInputRecord.Location = new System.Drawing.Point(395, 126);
            this.btnAccInputRecord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAccInputRecord.Name = "btnAccInputRecord";
            this.btnAccInputRecord.Size = new System.Drawing.Size(289, 56);
            this.btnAccInputRecord.TabIndex = 32;
            this.btnAccInputRecord.Text = "記錄";
            this.btnAccInputRecord.UseVisualStyleBackColor = true;
            this.btnAccInputRecord.Click += new System.EventHandler(this.btnAccInputRecord_Click);
            // 
            // btnInteliAccDelete
            // 
            this.btnInteliAccDelete.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnInteliAccDelete.Location = new System.Drawing.Point(497, 536);
            this.btnInteliAccDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInteliAccDelete.Name = "btnInteliAccDelete";
            this.btnInteliAccDelete.Size = new System.Drawing.Size(160, 56);
            this.btnInteliAccDelete.TabIndex = 43;
            this.btnInteliAccDelete.Text = "刪除";
            this.btnInteliAccDelete.UseVisualStyleBackColor = true;
            this.btnInteliAccDelete.Click += new System.EventHandler(this.btnInteliAccDelete_Click);
            // 
            // btnAccQuery
            // 
            this.btnAccQuery.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAccQuery.Location = new System.Drawing.Point(991, 126);
            this.btnAccQuery.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAccQuery.Name = "btnAccQuery";
            this.btnAccQuery.Size = new System.Drawing.Size(289, 56);
            this.btnAccQuery.TabIndex = 32;
            this.btnAccQuery.Text = "查詢帳目";
            this.btnAccQuery.UseVisualStyleBackColor = true;
            this.btnAccQuery.Click += new System.EventHandler(this.btnAccQuery_Click_1);
            // 
            // txDiaAccNo
            // 
            this.txDiaAccNo.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txDiaAccNo.Location = new System.Drawing.Point(463, 10);
            this.txDiaAccNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txDiaAccNo.Name = "txDiaAccNo";
            this.txDiaAccNo.Size = new System.Drawing.Size(212, 35);
            this.txDiaAccNo.TabIndex = 27;
            // 
            // txDiaAmount
            // 
            this.txDiaAmount.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txDiaAmount.Location = new System.Drawing.Point(463, 74);
            this.txDiaAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txDiaAmount.Name = "txDiaAmount";
            this.txDiaAmount.Size = new System.Drawing.Size(212, 35);
            this.txDiaAmount.TabIndex = 29;
            this.txDiaAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txDiaAmount_KeyDown);
            // 
            // txAccInputdgAcc
            // 
            this.txAccInputdgAcc.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txAccInputdgAcc.Location = new System.Drawing.Point(96, 545);
            this.txAccInputdgAcc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txAccInputdgAcc.Name = "txAccInputdgAcc";
            this.txAccInputdgAcc.Size = new System.Drawing.Size(221, 35);
            this.txAccInputdgAcc.TabIndex = 53;
            // 
            // lblAccInputdgAcc
            // 
            this.lblAccInputdgAcc.AutoSize = true;
            this.lblAccInputdgAcc.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAccInputdgAcc.Location = new System.Drawing.Point(23, 552);
            this.lblAccInputdgAcc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccInputdgAcc.Name = "lblAccInputdgAcc";
            this.lblAccInputdgAcc.Size = new System.Drawing.Size(60, 24);
            this.lblAccInputdgAcc.TabIndex = 52;
            this.lblAccInputdgAcc.Text = "傳票";
            // 
            // lblDiary
            // 
            this.lblDiary.AutoSize = true;
            this.lblDiary.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDiary.Location = new System.Drawing.Point(680, 74);
            this.lblDiary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiary.Name = "lblDiary";
            this.lblDiary.Size = new System.Drawing.Size(67, 24);
            this.lblDiary.TabIndex = 25;
            this.lblDiary.Text = "借/貸";
            // 
            // btnAccGenerate
            // 
            this.btnAccGenerate.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAccGenerate.Location = new System.Drawing.Point(1527, 878);
            this.btnAccGenerate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAccGenerate.Name = "btnAccGenerate";
            this.btnAccGenerate.Size = new System.Drawing.Size(195, 65);
            this.btnAccGenerate.TabIndex = 51;
            this.btnAccGenerate.Text = "產生";
            this.btnAccGenerate.UseVisualStyleBackColor = true;
            this.btnAccGenerate.Click += new System.EventHandler(this.btnAccGenerate_Click);
            // 
            // lblAccInputYear
            // 
            this.lblAccInputYear.AutoSize = true;
            this.lblAccInputYear.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAccInputYear.Location = new System.Drawing.Point(1532, 950);
            this.lblAccInputYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccInputYear.Name = "lblAccInputYear";
            this.lblAccInputYear.Size = new System.Drawing.Size(60, 24);
            this.lblAccInputYear.TabIndex = 50;
            this.lblAccInputYear.Text = "年份";
            // 
            // txAccYear
            // 
            this.txAccYear.Location = new System.Drawing.Point(1532, 981);
            this.txAccYear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txAccYear.Name = "txAccYear";
            this.txAccYear.Size = new System.Drawing.Size(188, 25);
            this.txAccYear.TabIndex = 48;
            // 
            // txAccMonth
            // 
            this.txAccMonth.Location = new System.Drawing.Point(1532, 1040);
            this.txAccMonth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txAccMonth.Name = "txAccMonth";
            this.txAccMonth.Size = new System.Drawing.Size(188, 25);
            this.txAccMonth.TabIndex = 49;
            // 
            // btnAccInputCost
            // 
            this.btnAccInputCost.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAccInputCost.Location = new System.Drawing.Point(347, 536);
            this.btnAccInputCost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAccInputCost.Name = "btnAccInputCost";
            this.btnAccInputCost.Size = new System.Drawing.Size(143, 56);
            this.btnAccInputCost.TabIndex = 44;
            this.btnAccInputCost.Text = "查詢傳票";
            this.btnAccInputCost.UseVisualStyleBackColor = true;
            this.btnAccInputCost.Click += new System.EventHandler(this.btnAccInputCost_Click);
            // 
            // btnAccConfirm
            // 
            this.btnAccConfirm.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAccConfirm.Location = new System.Drawing.Point(1439, 536);
            this.btnAccConfirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAccConfirm.Name = "btnAccConfirm";
            this.btnAccConfirm.Size = new System.Drawing.Size(281, 56);
            this.btnAccConfirm.TabIndex = 45;
            this.btnAccConfirm.Text = "存入帳冊";
            this.btnAccConfirm.UseVisualStyleBackColor = true;
            this.btnAccConfirm.Visible = false;
            this.btnAccConfirm.Click += new System.EventHandler(this.btnAccConfirm_Click);
            // 
            // dgCostItemView
            // 
            this.dgCostItemView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCostItemView.Location = new System.Drawing.Point(16, 610);
            this.dgCostItemView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgCostItemView.Name = "dgCostItemView";
            this.dgCostItemView.RowHeadersWidth = 51;
            this.dgCostItemView.RowTemplate.Height = 24;
            this.dgCostItemView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCostItemView.Size = new System.Drawing.Size(1708, 475);
            this.dgCostItemView.TabIndex = 41;
            this.dgCostItemView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgCostItemView_CellMouseClick);
            this.dgCostItemView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCostItemView_RowEnter);
            this.dgCostItemView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgCostItemView_KeyDown);
            this.dgCostItemView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgCostItemView_MouseClick);
            // 
            // txDiaAccID
            // 
            this.txDiaAccID.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txDiaAccID.Location = new System.Drawing.Point(803, 10);
            this.txDiaAccID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txDiaAccID.Name = "txDiaAccID";
            this.txDiaAccID.Size = new System.Drawing.Size(180, 35);
            this.txDiaAccID.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(1532, 1012);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 24);
            this.label9.TabIndex = 47;
            this.label9.Text = "月份";
            this.label9.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label16.Location = new System.Drawing.Point(680, 10);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(110, 24);
            this.label16.TabIndex = 25;
            this.label16.Text = "會計科目";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label15.Location = new System.Drawing.Point(389, 10);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 24);
            this.label15.TabIndex = 26;
            this.label15.Text = "傳票";
            // 
            // plAccInputPanel
            // 
            this.plAccInputPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.plAccInputPanel.Controls.Add(this.btnAccInputNew);
            this.plAccInputPanel.Controls.Add(this.btnAccQuery);
            this.plAccInputPanel.Controls.Add(this.btnAccInputSave);
            this.plAccInputPanel.Controls.Add(this.btnEmpty);
            this.plAccInputPanel.Controls.Add(this.btnDelete);
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
            this.plAccInputPanel.Location = new System.Drawing.Point(13, 15);
            this.plAccInputPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.plAccInputPanel.Name = "plAccInputPanel";
            this.plAccInputPanel.Size = new System.Drawing.Size(1708, 265);
            this.plAccInputPanel.TabIndex = 42;
            // 
            // btnEmpty
            // 
            this.btnEmpty.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnEmpty.Location = new System.Drawing.Point(692, 194);
            this.btnEmpty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEmpty.Name = "btnEmpty";
            this.btnEmpty.Size = new System.Drawing.Size(289, 56);
            this.btnEmpty.TabIndex = 32;
            this.btnEmpty.Text = "清空";
            this.btnEmpty.UseVisualStyleBackColor = true;
            this.btnEmpty.Click += new System.EventHandler(this.btnEmpty_Click);
            // 
            // lblDiaryAmount
            // 
            this.lblDiaryAmount.AutoSize = true;
            this.lblDiaryAmount.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDiaryAmount.Location = new System.Drawing.Point(389, 74);
            this.lblDiaryAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiaryAmount.Name = "lblDiaryAmount";
            this.lblDiaryAmount.Size = new System.Drawing.Size(60, 24);
            this.lblDiaryAmount.TabIndex = 25;
            this.lblDiaryAmount.Text = "金額";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label17.Location = new System.Drawing.Point(1028, 10);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 24);
            this.label17.TabIndex = 24;
            this.label17.Text = "摘要";
            // 
            // lblAccInputPos
            // 
            this.lblAccInputPos.AutoSize = true;
            this.lblAccInputPos.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAccInputPos.Location = new System.Drawing.Point(93, 219);
            this.lblAccInputPos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccInputPos.Name = "lblAccInputPos";
            this.lblAccInputPos.Size = new System.Drawing.Size(80, 24);
            this.lblAccInputPos.TabIndex = 26;
            this.lblAccInputPos.Text = "          ";
            // 
            // lblSuggestResult
            // 
            this.lblSuggestResult.AutoSize = true;
            this.lblSuggestResult.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSuggestResult.Location = new System.Drawing.Point(92, 169);
            this.lblSuggestResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSuggestResult.Name = "lblSuggestResult";
            this.lblSuggestResult.Size = new System.Drawing.Size(80, 24);
            this.lblSuggestResult.TabIndex = 26;
            this.lblSuggestResult.Text = "          ";
            // 
            // lblWhereInput
            // 
            this.lblWhereInput.AutoSize = true;
            this.lblWhereInput.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblWhereInput.Location = new System.Drawing.Point(19, 219);
            this.lblWhereInput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWhereInput.Name = "lblWhereInput";
            this.lblWhereInput.Size = new System.Drawing.Size(67, 24);
            this.lblWhereInput.TabIndex = 26;
            this.lblWhereInput.Text = "位置:";
            // 
            // lblaccsuggest
            // 
            this.lblaccsuggest.AutoSize = true;
            this.lblaccsuggest.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblaccsuggest.Location = new System.Drawing.Point(19, 170);
            this.lblaccsuggest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblaccsuggest.Name = "lblaccsuggest";
            this.lblaccsuggest.Size = new System.Drawing.Size(67, 24);
            this.lblaccsuggest.TabIndex = 26;
            this.lblaccsuggest.Text = "建議:";
            // 
            // lblDiaNoValue
            // 
            this.lblDiaNoValue.AutoSize = true;
            this.lblDiaNoValue.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDiaNoValue.Location = new System.Drawing.Point(92, 66);
            this.lblDiaNoValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiaNoValue.Name = "lblDiaNoValue";
            this.lblDiaNoValue.Size = new System.Drawing.Size(55, 24);
            this.lblDiaNoValue.TabIndex = 26;
            this.lblDiaNoValue.Text = "New";
            // 
            // lblDiaNo
            // 
            this.lblDiaNo.AutoSize = true;
            this.lblDiaNo.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDiaNo.Location = new System.Drawing.Point(19, 68);
            this.lblDiaNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiaNo.Name = "lblDiaNo";
            this.lblDiaNo.Size = new System.Drawing.Size(60, 24);
            this.lblDiaNo.TabIndex = 26;
            this.lblDiaNo.Text = "編號";
            // 
            // lblDiaryDate
            // 
            this.lblDiaryDate.AutoSize = true;
            this.lblDiaryDate.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDiaryDate.Location = new System.Drawing.Point(19, 15);
            this.lblDiaryDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiaryDate.Name = "lblDiaryDate";
            this.lblDiaryDate.Size = new System.Drawing.Size(60, 24);
            this.lblDiaryDate.TabIndex = 26;
            this.lblDiaryDate.Text = "日期";
            // 
            // dtAccPicker
            // 
            this.dtAccPicker.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtAccPicker.Location = new System.Drawing.Point(92, 12);
            this.dtAccPicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtAccPicker.Name = "dtAccPicker";
            this.dtAccPicker.Size = new System.Drawing.Size(265, 35);
            this.dtAccPicker.TabIndex = 21;
            this.dtAccPicker.ValueChanged += new System.EventHandler(this.dtAccPicker_ValueChanged);
            // 
            // chSaveAccount
            // 
            this.chSaveAccount.AutoSize = true;
            this.chSaveAccount.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chSaveAccount.Location = new System.Drawing.Point(668, 549);
            this.chSaveAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chSaveAccount.Name = "chSaveAccount";
            this.chSaveAccount.Size = new System.Drawing.Size(142, 31);
            this.chSaveAccount.TabIndex = 33;
            this.chSaveAccount.Text = "儲存帳目";
            this.chSaveAccount.UseVisualStyleBackColor = true;
            this.chSaveAccount.Visible = false;
            // 
            // btnProfit
            // 
            this.btnProfit.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnProfit.Location = new System.Drawing.Point(20, 16);
            this.btnProfit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProfit.Name = "btnProfit";
            this.btnProfit.Size = new System.Drawing.Size(152, 51);
            this.btnProfit.TabIndex = 54;
            this.btnProfit.Text = "盈餘分配";
            this.btnProfit.UseVisualStyleBackColor = true;
            this.btnProfit.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // gbProfit
            // 
            this.gbProfit.Controls.Add(this.btnUnprofit);
            this.gbProfit.Controls.Add(this.btnProfit);
            this.gbProfit.Location = new System.Drawing.Point(832, 525);
            this.gbProfit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbProfit.Name = "gbProfit";
            this.gbProfit.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbProfit.Size = new System.Drawing.Size(347, 78);
            this.gbProfit.TabIndex = 55;
            this.gbProfit.TabStop = false;
            // 
            // btnUnprofit
            // 
            this.btnUnprofit.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUnprofit.Location = new System.Drawing.Point(181, 16);
            this.btnUnprofit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUnprofit.Name = "btnUnprofit";
            this.btnUnprofit.Size = new System.Drawing.Size(152, 51);
            this.btnUnprofit.TabIndex = 55;
            this.btnUnprofit.Text = "不認列盈餘";
            this.btnUnprofit.UseVisualStyleBackColor = true;
            this.btnUnprofit.Click += new System.EventHandler(this.btnUnprofit_click);
            // 
            // FrmDiaryBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1775, 1051);
            this.Controls.Add(this.gbProfit);
            this.Controls.Add(this.chSaveAccount);
            this.Controls.Add(this.dgAccAccountsData);
            this.Controls.Add(this.btnInteliAccDelete);
            this.Controls.Add(this.txAccInputdgAcc);
            this.Controls.Add(this.lblAccInputdgAcc);
            this.Controls.Add(this.btnAccGenerate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblAccInputYear);
            this.Controls.Add(this.txAccYear);
            this.Controls.Add(this.txAccMonth);
            this.Controls.Add(this.btnAccInputCost);
            this.Controls.Add(this.btnAccConfirm);
            this.Controls.Add(this.dgCostItemView);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.plAccInputPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmDiaryBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "帳冊管理";
            this.Load += new System.EventHandler(this.FrmDiaryBook_Load);
            this.Shown += new System.EventHandler(this.FrmDiaryBook_Shown);
            this.SizeChanged += new System.EventHandler(this.FrmDiaryBook_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgAccAccountsData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCostItemView)).EndInit();
            this.plAccInputPanel.ResumeLayout(false);
            this.plAccInputPanel.PerformLayout();
            this.gbProfit.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAccInputNew;
        private System.Windows.Forms.Button btnAccInputSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDiarySelection;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox lblInputPos;
        private System.Windows.Forms.TextBox txDiaAccDesc;
        private System.Windows.Forms.TextBox txAccDatatype;
        private System.Windows.Forms.DataGridView dgAccAccountsData;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAccInputRecord;
        private System.Windows.Forms.Button btnInteliAccDelete;
        private System.Windows.Forms.Button btnAccQuery;
        private System.Windows.Forms.TextBox txDiaAccNo;
        private System.Windows.Forms.TextBox txDiaAmount;
        private System.Windows.Forms.TextBox txAccInputdgAcc;
        private System.Windows.Forms.Label lblAccInputdgAcc;
        private System.Windows.Forms.Label lblDiary;
        private System.Windows.Forms.Button btnAccGenerate;
        private System.Windows.Forms.Label lblAccInputYear;
        private System.Windows.Forms.TextBox txAccYear;
        private System.Windows.Forms.TextBox txAccMonth;
        private System.Windows.Forms.Button btnAccInputCost;
        private System.Windows.Forms.Button btnAccConfirm;
        private System.Windows.Forms.DataGridView dgCostItemView;
        private System.Windows.Forms.TextBox txDiaAccID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel plAccInputPanel;
        private System.Windows.Forms.Label lblDiaryAmount;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblAccInputPos;
        private System.Windows.Forms.Label lblSuggestResult;
        private System.Windows.Forms.Label lblWhereInput;
        private System.Windows.Forms.Label lblaccsuggest;
        private System.Windows.Forms.Label lblDiaNoValue;
        private System.Windows.Forms.Label lblDiaNo;
        private System.Windows.Forms.Label lblDiaryDate;
        private System.Windows.Forms.DateTimePicker dtAccPicker;
        private System.Windows.Forms.CheckBox chSaveAccount;
        private System.Windows.Forms.Button btnEmpty;
        private System.Windows.Forms.Button btnProfit;
        private System.Windows.Forms.GroupBox gbProfit;
        private System.Windows.Forms.Button btnUnprofit;
    }
}