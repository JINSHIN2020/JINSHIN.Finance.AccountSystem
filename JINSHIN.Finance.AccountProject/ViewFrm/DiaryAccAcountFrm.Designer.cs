namespace FinanceAccountProgram.ViewFrm
{
    partial class DiaryAccAcountFrm
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
            this.txDataType = new System.Windows.Forms.TextBox();
            this.lblDiary = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.coDiaryClass = new System.Windows.Forms.ComboBox();
            this.btnAccQuery = new System.Windows.Forms.Button();
            this.dgAccContents = new System.Windows.Forms.DataGridView();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtAffairName = new System.Windows.Forms.TextBox();
            this.coDiaryData = new System.Windows.Forms.ComboBox();
            this.lblText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgAccContents)).BeginInit();
            this.SuspendLayout();
            // 
            // txDataType
            // 
            this.txDataType.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txDataType.Location = new System.Drawing.Point(595, 12);
            this.txDataType.Name = "txDataType";
            this.txDataType.Size = new System.Drawing.Size(124, 30);
            this.txDataType.TabIndex = 31;
            this.txDataType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txDataType_KeyDown);
            // 
            // lblDiary
            // 
            this.lblDiary.AutoSize = true;
            this.lblDiary.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDiary.Location = new System.Drawing.Point(538, 14);
            this.lblDiary.Name = "lblDiary";
            this.lblDiary.Size = new System.Drawing.Size(55, 19);
            this.lblDiary.TabIndex = 30;
            this.lblDiary.Text = "借/貸";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label18.Location = new System.Drawing.Point(9, 14);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 19);
            this.label18.TabIndex = 33;
            this.label18.Text = "種類";
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
            this.coDiaryClass.Location = new System.Drawing.Point(61, 12);
            this.coDiaryClass.Name = "coDiaryClass";
            this.coDiaryClass.Size = new System.Drawing.Size(200, 186);
            this.coDiaryClass.TabIndex = 32;
            this.coDiaryClass.SelectedIndexChanged += new System.EventHandler(this.coDiaryList_SelectedIndexChanged);
            this.coDiaryClass.SelectedValueChanged += new System.EventHandler(this.coDiaryClass_SelectedValueChanged);
            this.coDiaryClass.TextChanged += new System.EventHandler(this.coDiaryClass_TextChanged);
            // 
            // btnAccQuery
            // 
            this.btnAccQuery.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAccQuery.Location = new System.Drawing.Point(749, 12);
            this.btnAccQuery.Name = "btnAccQuery";
            this.btnAccQuery.Size = new System.Drawing.Size(129, 47);
            this.btnAccQuery.TabIndex = 34;
            this.btnAccQuery.Text = "查詢";
            this.btnAccQuery.UseVisualStyleBackColor = true;
            this.btnAccQuery.Click += new System.EventHandler(this.btnAccQuery_Click);
            // 
            // dgAccContents
            // 
            this.dgAccContents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAccContents.Location = new System.Drawing.Point(22, 204);
            this.dgAccContents.Name = "dgAccContents";
            this.dgAccContents.RowTemplate.Height = 24;
            this.dgAccContents.Size = new System.Drawing.Size(840, 432);
            this.dgAccContents.TabIndex = 35;
            this.dgAccContents.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAccContents_CellContentDoubleClick);
            // 
            // btnTransfer
            // 
            this.btnTransfer.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTransfer.Location = new System.Drawing.Point(749, 65);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(129, 52);
            this.btnTransfer.TabIndex = 34;
            this.btnTransfer.Text = "傳入";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblName.Location = new System.Drawing.Point(538, 51);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 19);
            this.lblName.TabIndex = 30;
            this.lblName.Text = "名稱";
            // 
            // txtAffairName
            // 
            this.txtAffairName.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAffairName.Location = new System.Drawing.Point(595, 49);
            this.txtAffairName.Name = "txtAffairName";
            this.txtAffairName.Size = new System.Drawing.Size(124, 30);
            this.txtAffairName.TabIndex = 31;
            this.txtAffairName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txDataType_KeyDown);
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
            this.coDiaryData.Location = new System.Drawing.Point(316, 12);
            this.coDiaryData.Name = "coDiaryData";
            this.coDiaryData.Size = new System.Drawing.Size(200, 186);
            this.coDiaryData.TabIndex = 32;
            this.coDiaryData.SelectedIndexChanged += new System.EventHandler(this.coDiaryData_SelectedIndexChanged);
            this.coDiaryData.SelectedValueChanged += new System.EventHandler(this.coDiaryData_SelectedValueChanged);
            this.coDiaryData.TextChanged += new System.EventHandler(this.coDiaryData_TextChanged);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblText.Location = new System.Drawing.Point(264, 14);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(49, 19);
            this.lblText.TabIndex = 33;
            this.lblText.Text = "名稱";
            // 
            // DiaryAccAcountFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 659);
            this.Controls.Add(this.dgAccContents);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.btnAccQuery);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.coDiaryData);
            this.Controls.Add(this.coDiaryClass);
            this.Controls.Add(this.txtAffairName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txDataType);
            this.Controls.Add(this.lblDiary);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "DiaryAccAcountFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "會計資料";
            this.Load += new System.EventHandler(this.DiaryAccAcountFrm_Load);
            this.Shown += new System.EventHandler(this.DiaryAccAcountFrm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgAccContents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txDataType;
        private System.Windows.Forms.Label lblDiary;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox coDiaryClass;
        private System.Windows.Forms.Button btnAccQuery;
        private System.Windows.Forms.DataGridView dgAccContents;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtAffairName;
        private System.Windows.Forms.ComboBox coDiaryData;
        private System.Windows.Forms.Label lblText;
    }
}