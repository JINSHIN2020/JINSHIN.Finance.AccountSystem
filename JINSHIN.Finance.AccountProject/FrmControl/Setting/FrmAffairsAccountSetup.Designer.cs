namespace FinanceAccountProgram.FrmControl
{
    partial class FrmAffairsAccountSetup
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
            this.lblText = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.coDiaryData = new System.Windows.Forms.ComboBox();
            this.coDiaryClass = new System.Windows.Forms.ComboBox();
            this.dgAccContents = new System.Windows.Forms.DataGridView();
            this.chDefault = new System.Windows.Forms.CheckBox();
            this.btnAccSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbInputs = new System.Windows.Forms.GroupBox();
            this.lstClass = new System.Windows.Forms.ListBox();
            this.txtClassText005 = new System.Windows.Forms.TextBox();
            this.lblTypes = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtAccId005 = new System.Windows.Forms.TextBox();
            this.txtsn005 = new System.Windows.Forms.TextBox();
            this.txtAmount005 = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblOrderTh = new System.Windows.Forms.Label();
            this.txtDataType005 = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblDataType = new System.Windows.Forms.Label();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAccContents)).BeginInit();
            this.gbInputs.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblText.Location = new System.Drawing.Point(267, 9);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(49, 19);
            this.lblText.TabIndex = 36;
            this.lblText.Text = "名稱";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label18.Location = new System.Drawing.Point(12, 9);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 19);
            this.label18.TabIndex = 37;
            this.label18.Text = "種類";
            // 
            // coDiaryData
            // 
            this.coDiaryData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.coDiaryData.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.coDiaryData.FormattingEnabled = true;
            this.coDiaryData.Items.AddRange(new object[] {
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
            this.coDiaryData.Location = new System.Drawing.Point(319, 7);
            this.coDiaryData.Name = "coDiaryData";
            this.coDiaryData.Size = new System.Drawing.Size(200, 186);
            this.coDiaryData.TabIndex = 34;
            this.coDiaryData.SelectedValueChanged += new System.EventHandler(this.coDiaryData_SelectedValueChanged);
            this.coDiaryData.TextChanged += new System.EventHandler(this.coDiaryData_TextChanged);
            // 
            // coDiaryClass
            // 
            this.coDiaryClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.coDiaryClass.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.coDiaryClass.FormattingEnabled = true;
            this.coDiaryClass.Items.AddRange(new object[] {
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
            this.coDiaryClass.Location = new System.Drawing.Point(64, 7);
            this.coDiaryClass.Name = "coDiaryClass";
            this.coDiaryClass.Size = new System.Drawing.Size(200, 186);
            this.coDiaryClass.TabIndex = 35;
            this.coDiaryClass.SelectedIndexChanged += new System.EventHandler(this.coDiaryClass_SelectedIndexChanged);
            this.coDiaryClass.SelectedValueChanged += new System.EventHandler(this.coDiaryClass_SelectedValueChanged);
            this.coDiaryClass.TextChanged += new System.EventHandler(this.coDiaryClass_TextChanged);
            // 
            // dgAccContents
            // 
            this.dgAccContents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAccContents.Location = new System.Drawing.Point(12, 222);
            this.dgAccContents.MultiSelect = false;
            this.dgAccContents.Name = "dgAccContents";
            this.dgAccContents.RowTemplate.Height = 24;
            this.dgAccContents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAccContents.Size = new System.Drawing.Size(1260, 581);
            this.dgAccContents.TabIndex = 38;
            this.dgAccContents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAccContents_CellContentClick);
            this.dgAccContents.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgAccContents_CellFormatting);
            this.dgAccContents.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAccContents_CellLeave);
            this.dgAccContents.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgAccContents_CellMouseClick);
            this.dgAccContents.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAccContents_RowEnter);
            // 
            // chDefault
            // 
            this.chDefault.AutoSize = true;
            this.chDefault.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chDefault.Location = new System.Drawing.Point(241, 100);
            this.chDefault.Name = "chDefault";
            this.chDefault.Size = new System.Drawing.Size(88, 23);
            this.chDefault.TabIndex = 43;
            this.chDefault.Text = "預設值";
            this.chDefault.UseVisualStyleBackColor = true;
            // 
            // btnAccSave
            // 
            this.btnAccSave.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAccSave.Location = new System.Drawing.Point(665, 156);
            this.btnAccSave.Name = "btnAccSave";
            this.btnAccSave.Size = new System.Drawing.Size(129, 49);
            this.btnAccSave.TabIndex = 44;
            this.btnAccSave.Text = "儲存";
            this.btnAccSave.UseVisualStyleBackColor = true;
            this.btnAccSave.Click += new System.EventHandler(this.btnAccSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelete.Location = new System.Drawing.Point(802, 156);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(129, 49);
            this.btnDelete.TabIndex = 44;
            this.btnDelete.Text = "刪除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gbInputs
            // 
            this.gbInputs.Controls.Add(this.lstClass);
            this.gbInputs.Controls.Add(this.txtClassText005);
            this.gbInputs.Controls.Add(this.lblTypes);
            this.gbInputs.Controls.Add(this.lblName);
            this.gbInputs.Controls.Add(this.txtAccId005);
            this.gbInputs.Controls.Add(this.chDefault);
            this.gbInputs.Controls.Add(this.txtsn005);
            this.gbInputs.Controls.Add(this.txtAmount005);
            this.gbInputs.Controls.Add(this.lblSubject);
            this.gbInputs.Controls.Add(this.lblOrderTh);
            this.gbInputs.Controls.Add(this.txtDataType005);
            this.gbInputs.Controls.Add(this.lblAmount);
            this.gbInputs.Controls.Add(this.lblDataType);
            this.gbInputs.Location = new System.Drawing.Point(525, 7);
            this.gbInputs.Name = "gbInputs";
            this.gbInputs.Size = new System.Drawing.Size(661, 143);
            this.gbInputs.TabIndex = 45;
            this.gbInputs.TabStop = false;
            // 
            // lstClass
            // 
            this.lstClass.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lstClass.FormattingEnabled = true;
            this.lstClass.ItemHeight = 19;
            this.lstClass.Items.AddRange(new object[] {
            "請選擇",
            "收款單",
            "付款單",
            "應收票據",
            "應付票據"});
            this.lstClass.Location = new System.Drawing.Point(479, 21);
            this.lstClass.Name = "lstClass";
            this.lstClass.Size = new System.Drawing.Size(100, 99);
            this.lstClass.TabIndex = 46;
            this.lstClass.SelectedIndexChanged += new System.EventHandler(this.lstClass_SelectedIndexChanged);
            // 
            // txtClassText005
            // 
            this.txtClassText005.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtClassText005.Location = new System.Drawing.Point(294, 21);
            this.txtClassText005.Name = "txtClassText005";
            this.txtClassText005.Size = new System.Drawing.Size(124, 30);
            this.txtClassText005.TabIndex = 48;
            // 
            // lblTypes
            // 
            this.lblTypes.AutoSize = true;
            this.lblTypes.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTypes.Location = new System.Drawing.Point(424, 21);
            this.lblTypes.Name = "lblTypes";
            this.lblTypes.Size = new System.Drawing.Size(49, 19);
            this.lblTypes.TabIndex = 43;
            this.lblTypes.Text = "種類";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblName.Location = new System.Drawing.Point(237, 21);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 19);
            this.lblName.TabIndex = 43;
            this.lblName.Text = "名稱";
            // 
            // txtAccId005
            // 
            this.txtAccId005.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAccId005.Location = new System.Drawing.Point(106, 21);
            this.txtAccId005.Name = "txtAccId005";
            this.txtAccId005.Size = new System.Drawing.Size(124, 30);
            this.txtAccId005.TabIndex = 49;
            // 
            // txtsn005
            // 
            this.txtsn005.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtsn005.Location = new System.Drawing.Point(106, 99);
            this.txtsn005.Name = "txtsn005";
            this.txtsn005.Size = new System.Drawing.Size(124, 30);
            this.txtsn005.TabIndex = 50;
            // 
            // txtAmount005
            // 
            this.txtAmount005.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAmount005.Location = new System.Drawing.Point(294, 59);
            this.txtAmount005.Name = "txtAmount005";
            this.txtAmount005.Size = new System.Drawing.Size(124, 30);
            this.txtAmount005.TabIndex = 51;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSubject.Location = new System.Drawing.Point(11, 21);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(89, 19);
            this.lblSubject.TabIndex = 44;
            this.lblSubject.Text = "會計科目";
            // 
            // lblOrderTh
            // 
            this.lblOrderTh.AutoSize = true;
            this.lblOrderTh.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblOrderTh.Location = new System.Drawing.Point(49, 100);
            this.lblOrderTh.Name = "lblOrderTh";
            this.lblOrderTh.Size = new System.Drawing.Size(49, 19);
            this.lblOrderTh.TabIndex = 45;
            this.lblOrderTh.Text = "排序";
            // 
            // txtDataType005
            // 
            this.txtDataType005.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDataType005.Location = new System.Drawing.Point(106, 59);
            this.txtDataType005.Name = "txtDataType005";
            this.txtDataType005.Size = new System.Drawing.Size(124, 30);
            this.txtDataType005.TabIndex = 52;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAmount.Location = new System.Drawing.Point(237, 59);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(49, 19);
            this.lblAmount.TabIndex = 46;
            this.lblAmount.Text = "金額";
            // 
            // lblDataType
            // 
            this.lblDataType.AutoSize = true;
            this.lblDataType.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDataType.Location = new System.Drawing.Point(42, 59);
            this.lblDataType.Name = "lblDataType";
            this.lblDataType.Size = new System.Drawing.Size(55, 19);
            this.lblDataType.TabIndex = 47;
            this.lblDataType.Text = "借/貸";
            // 
            // btnQuery
            // 
            this.btnQuery.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnQuery.Location = new System.Drawing.Point(942, 156);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(129, 49);
            this.btnQuery.TabIndex = 44;
            this.btnQuery.Text = "查詢";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd.Location = new System.Drawing.Point(526, 156);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(129, 49);
            this.btnAdd.TabIndex = 44;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FrmAffairsAccountSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1288, 815);
            this.Controls.Add(this.gbInputs);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnAccSave);
            this.Controls.Add(this.dgAccContents);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.coDiaryClass);
            this.Controls.Add(this.coDiaryData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmAffairsAccountSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "會計分錄管理";
            this.Load += new System.EventHandler(this.FrmAffairsAccountSetup_Load);
            this.Shown += new System.EventHandler(this.FrmAffairsAccountSetup_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgAccContents)).EndInit();
            this.gbInputs.ResumeLayout(false);
            this.gbInputs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox coDiaryData;
        private System.Windows.Forms.ComboBox coDiaryClass;
        private System.Windows.Forms.DataGridView dgAccContents;
        private System.Windows.Forms.CheckBox chDefault;
        private System.Windows.Forms.Button btnAccSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gbInputs;
        private System.Windows.Forms.TextBox txtClassText005;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtAccId005;
        private System.Windows.Forms.TextBox txtsn005;
        private System.Windows.Forms.TextBox txtAmount005;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblOrderTh;
        private System.Windows.Forms.TextBox txtDataType005;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblDataType;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstClass;
        private System.Windows.Forms.Label lblTypes;
    }
}