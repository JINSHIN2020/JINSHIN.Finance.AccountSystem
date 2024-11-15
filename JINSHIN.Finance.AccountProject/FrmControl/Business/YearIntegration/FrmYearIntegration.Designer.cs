namespace JINSHIN.Finance.AccountSystem.FrmControl.Business.YearIntegration
{
    partial class FrmYearIntegration
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
            this.cokMonMALL = new System.Windows.Forms.CheckBox();
            this.lblMonthTitle = new System.Windows.Forms.Label();
            this.lstMonths = new System.Windows.Forms.ListBox();
            this.btnVierfyAcc = new System.Windows.Forms.Button();
            this.btnCancelCheck = new System.Windows.Forms.Button();
            this.btnMoneyVeriy = new System.Windows.Forms.Button();
            this.btnMoney = new System.Windows.Forms.Button();
            this.dataMoney02 = new System.Windows.Forms.DataGridView();
            this.dataMoney01 = new System.Windows.Forms.DataGridView();
            this.btnExport = new System.Windows.Forms.Button();
            this.plLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.chVerify = new System.Windows.Forms.CheckBox();
            this.lbl01 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.gd02 = new System.Windows.Forms.GroupBox();
            this.dgview_class = new System.Windows.Forms.DataGridView();
            this.dgview_setting = new System.Windows.Forms.DataGridView();
            this.btnFrmExports = new System.Windows.Forms.Button();
            this.lblData = new System.Windows.Forms.Label();
            this.lbl02 = new System.Windows.Forms.Label();
            this.dataMoney02Un = new System.Windows.Forms.DataGridView();
            this.lblaccdata = new System.Windows.Forms.Label();
            this.lblDataDiary = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataMoney02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMoney01)).BeginInit();
            this.plLayout.SuspendLayout();
            this.gbData.SuspendLayout();
            this.gd02.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgview_class)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgview_setting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMoney02Un)).BeginInit();
            this.SuspendLayout();
            // 
            // cokMonMALL
            // 
            this.cokMonMALL.AutoSize = true;
            this.cokMonMALL.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cokMonMALL.Location = new System.Drawing.Point(16, 81);
            this.cokMonMALL.Name = "cokMonMALL";
            this.cokMonMALL.Size = new System.Drawing.Size(66, 23);
            this.cokMonMALL.TabIndex = 26;
            this.cokMonMALL.Text = "全部";
            this.cokMonMALL.UseVisualStyleBackColor = true;
            // 
            // lblMonthTitle
            // 
            this.lblMonthTitle.AutoSize = true;
            this.lblMonthTitle.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMonthTitle.Location = new System.Drawing.Point(16, 20);
            this.lblMonthTitle.Name = "lblMonthTitle";
            this.lblMonthTitle.Size = new System.Drawing.Size(47, 19);
            this.lblMonthTitle.TabIndex = 17;
            this.lblMonthTitle.Text = "月份";
            // 
            // lstMonths
            // 
            this.lstMonths.ColumnWidth = 70;
            this.lstMonths.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lstMonths.FormattingEnabled = true;
            this.lstMonths.ItemHeight = 19;
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
            this.lstMonths.Location = new System.Drawing.Point(90, 19);
            this.lstMonths.MultiColumn = true;
            this.lstMonths.Name = "lstMonths";
            this.lstMonths.Size = new System.Drawing.Size(219, 80);
            this.lstMonths.TabIndex = 16;
            // 
            // btnVierfyAcc
            // 
            this.btnVierfyAcc.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnVierfyAcc.Location = new System.Drawing.Point(136, 3);
            this.btnVierfyAcc.Name = "btnVierfyAcc";
            this.btnVierfyAcc.Size = new System.Drawing.Size(127, 39);
            this.btnVierfyAcc.TabIndex = 14;
            this.btnVierfyAcc.Text = "核定帳目";
            this.btnVierfyAcc.UseVisualStyleBackColor = true;
            this.btnVierfyAcc.Click += new System.EventHandler(this.btnVierfyAcc_Click);
            // 
            // btnCancelCheck
            // 
            this.btnCancelCheck.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancelCheck.Location = new System.Drawing.Point(269, 3);
            this.btnCancelCheck.Name = "btnCancelCheck";
            this.btnCancelCheck.Size = new System.Drawing.Size(127, 39);
            this.btnCancelCheck.TabIndex = 13;
            this.btnCancelCheck.Text = "取消核定";
            this.btnCancelCheck.UseVisualStyleBackColor = true;
            this.btnCancelCheck.Click += new System.EventHandler(this.btnCancelCheck_Click);
            // 
            // btnMoneyVeriy
            // 
            this.btnMoneyVeriy.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMoneyVeriy.Location = new System.Drawing.Point(3, 3);
            this.btnMoneyVeriy.Name = "btnMoneyVeriy";
            this.btnMoneyVeriy.Size = new System.Drawing.Size(127, 39);
            this.btnMoneyVeriy.TabIndex = 12;
            this.btnMoneyVeriy.Text = "智慧檢查";
            this.btnMoneyVeriy.UseVisualStyleBackColor = true;
            this.btnMoneyVeriy.Click += new System.EventHandler(this.btnMoneyVeriy_Click);
            // 
            // btnMoney
            // 
            this.btnMoney.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMoney.Location = new System.Drawing.Point(20, 107);
            this.btnMoney.Name = "btnMoney";
            this.btnMoney.Size = new System.Drawing.Size(291, 41);
            this.btnMoney.TabIndex = 11;
            this.btnMoney.Text = "顯示";
            this.btnMoney.UseVisualStyleBackColor = true;
            this.btnMoney.Click += new System.EventHandler(this.btnMoney_Click);
            // 
            // dataMoney02
            // 
            this.dataMoney02.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMoney02.Location = new System.Drawing.Point(648, 40);
            this.dataMoney02.Name = "dataMoney02";
            this.dataMoney02.RowHeadersVisible = false;
            this.dataMoney02.RowTemplate.Height = 24;
            this.dataMoney02.Size = new System.Drawing.Size(405, 454);
            this.dataMoney02.TabIndex = 9;
            // 
            // dataMoney01
            // 
            this.dataMoney01.AllowUserToOrderColumns = true;
            this.dataMoney01.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMoney01.Location = new System.Drawing.Point(505, 522);
            this.dataMoney01.Name = "dataMoney01";
            this.dataMoney01.RowTemplate.Height = 24;
            this.dataMoney01.Size = new System.Drawing.Size(1054, 377);
            this.dataMoney01.TabIndex = 8;
            this.dataMoney01.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataMoney01_CellFormatting);
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnExport.Location = new System.Drawing.Point(3, 48);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(127, 39);
            this.btnExport.TabIndex = 12;
            this.btnExport.Text = "匯出";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // plLayout
            // 
            this.plLayout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plLayout.Controls.Add(this.btnMoneyVeriy);
            this.plLayout.Controls.Add(this.btnVierfyAcc);
            this.plLayout.Controls.Add(this.btnCancelCheck);
            this.plLayout.Controls.Add(this.btnExport);
            this.plLayout.Controls.Add(this.chVerify);
            this.plLayout.Location = new System.Drawing.Point(12, 498);
            this.plLayout.Name = "plLayout";
            this.plLayout.Size = new System.Drawing.Size(468, 110);
            this.plLayout.TabIndex = 27;
            // 
            // chVerify
            // 
            this.chVerify.AutoSize = true;
            this.chVerify.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chVerify.Location = new System.Drawing.Point(136, 48);
            this.chVerify.Name = "chVerify";
            this.chVerify.Size = new System.Drawing.Size(85, 23);
            this.chVerify.TabIndex = 26;
            this.chVerify.Text = "已審核";
            this.chVerify.UseVisualStyleBackColor = true;
            this.chVerify.CheckedChanged += new System.EventHandler(this.chVerify_CheckedChanged);
            // 
            // lbl01
            // 
            this.lbl01.AutoSize = true;
            this.lbl01.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl01.Location = new System.Drawing.Point(10, 20);
            this.lbl01.Name = "lbl01";
            this.lbl01.Size = new System.Drawing.Size(85, 19);
            this.lbl01.TabIndex = 19;
            this.lbl01.Text = "匯入年度";
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtYear.Location = new System.Drawing.Point(10, 45);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(163, 30);
            this.txtYear.TabIndex = 24;
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.gd02);
            this.gbData.Controls.Add(this.dgview_class);
            this.gbData.Controls.Add(this.dgview_setting);
            this.gbData.Controls.Add(this.txtYear);
            this.gbData.Controls.Add(this.lbl01);
            this.gbData.Controls.Add(this.btnFrmExports);
            this.gbData.Controls.Add(this.lblData);
            this.gbData.Controls.Add(this.lbl02);
            this.gbData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbData.Location = new System.Drawing.Point(13, 3);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(629, 489);
            this.gbData.TabIndex = 28;
            this.gbData.TabStop = false;
            this.gbData.Enter += new System.EventHandler(this.gbData_Enter);
            // 
            // gd02
            // 
            this.gd02.Controls.Add(this.lblMonthTitle);
            this.gd02.Controls.Add(this.lstMonths);
            this.gd02.Controls.Add(this.cokMonMALL);
            this.gd02.Controls.Add(this.btnMoney);
            this.gd02.Location = new System.Drawing.Point(179, 13);
            this.gd02.Name = "gd02";
            this.gd02.Size = new System.Drawing.Size(341, 155);
            this.gd02.TabIndex = 29;
            this.gd02.TabStop = false;
            // 
            // dgview_class
            // 
            this.dgview_class.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgview_class.Location = new System.Drawing.Point(10, 200);
            this.dgview_class.Name = "dgview_class";
            this.dgview_class.RowHeadersVisible = false;
            this.dgview_class.RowTemplate.Height = 24;
            this.dgview_class.Size = new System.Drawing.Size(368, 271);
            this.dgview_class.TabIndex = 30;
            this.dgview_class.SelectionChanged += new System.EventHandler(this.dgview_class_SelectionChanged);
            // 
            // dgview_setting
            // 
            this.dgview_setting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgview_setting.Location = new System.Drawing.Point(384, 200);
            this.dgview_setting.Name = "dgview_setting";
            this.dgview_setting.RowHeadersVisible = false;
            this.dgview_setting.RowTemplate.Height = 24;
            this.dgview_setting.Size = new System.Drawing.Size(239, 271);
            this.dgview_setting.TabIndex = 30;
            // 
            // btnFrmExports
            // 
            this.btnFrmExports.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFrmExports.Location = new System.Drawing.Point(10, 82);
            this.btnFrmExports.Name = "btnFrmExports";
            this.btnFrmExports.Size = new System.Drawing.Size(163, 37);
            this.btnFrmExports.TabIndex = 11;
            this.btnFrmExports.Text = "匯入";
            this.btnFrmExports.UseVisualStyleBackColor = true;
            this.btnFrmExports.Click += new System.EventHandler(this.btnFrmExports_Click);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblData.Location = new System.Drawing.Point(382, 177);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(85, 19);
            this.lblData.TabIndex = 20;
            this.lblData.Text = "匯入設定";
            // 
            // lbl02
            // 
            this.lbl02.AutoSize = true;
            this.lbl02.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl02.Location = new System.Drawing.Point(6, 178);
            this.lbl02.Name = "lbl02";
            this.lbl02.Size = new System.Drawing.Size(104, 19);
            this.lbl02.TabIndex = 20;
            this.lbl02.Text = "匯入的事務";
            // 
            // dataMoney02Un
            // 
            this.dataMoney02Un.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMoney02Un.Location = new System.Drawing.Point(1059, 40);
            this.dataMoney02Un.Name = "dataMoney02Un";
            this.dataMoney02Un.RowHeadersVisible = false;
            this.dataMoney02Un.RowTemplate.Height = 24;
            this.dataMoney02Un.Size = new System.Drawing.Size(405, 454);
            this.dataMoney02Un.TabIndex = 9;
            // 
            // lblaccdata
            // 
            this.lblaccdata.AutoSize = true;
            this.lblaccdata.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblaccdata.Location = new System.Drawing.Point(506, 498);
            this.lblaccdata.Name = "lblaccdata";
            this.lblaccdata.Size = new System.Drawing.Size(85, 19);
            this.lblaccdata.TabIndex = 29;
            this.lblaccdata.Text = "會計資料";
            // 
            // lblDataDiary
            // 
            this.lblDataDiary.AutoSize = true;
            this.lblDataDiary.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDataDiary.Location = new System.Drawing.Point(648, 16);
            this.lblDataDiary.Name = "lblDataDiary";
            this.lblDataDiary.Size = new System.Drawing.Size(85, 19);
            this.lblDataDiary.TabIndex = 30;
            this.lblDataDiary.Text = "事務資料";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(1055, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 19);
            this.label2.TabIndex = 30;
            this.label2.Text = "應新增的會計資料";
            // 
            // FrmYearIntegration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1571, 909);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDataDiary);
            this.Controls.Add(this.lblaccdata);
            this.Controls.Add(this.gbData);
            this.Controls.Add(this.plLayout);
            this.Controls.Add(this.dataMoney02Un);
            this.Controls.Add(this.dataMoney02);
            this.Controls.Add(this.dataMoney01);
            this.Name = "FrmYearIntegration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "智慧帳目比對";
            this.Shown += new System.EventHandler(this.FrmYearIntegration_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataMoney02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMoney01)).EndInit();
            this.plLayout.ResumeLayout(false);
            this.plLayout.PerformLayout();
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            this.gd02.ResumeLayout(false);
            this.gd02.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgview_class)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgview_setting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMoney02Un)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cokMonMALL;
        private System.Windows.Forms.Label lblMonthTitle;
        private System.Windows.Forms.ListBox lstMonths;
        private System.Windows.Forms.Button btnVierfyAcc;
        private System.Windows.Forms.Button btnCancelCheck;
        private System.Windows.Forms.Button btnMoneyVeriy;
        private System.Windows.Forms.Button btnMoney;
        private System.Windows.Forms.DataGridView dataMoney02;
        private System.Windows.Forms.DataGridView dataMoney01;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.FlowLayoutPanel plLayout;
        private System.Windows.Forms.Label lbl01;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.Button btnFrmExports;
        private System.Windows.Forms.Label lbl02;
        private System.Windows.Forms.GroupBox gd02;
        private System.Windows.Forms.DataGridView dgview_setting;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.DataGridView dgview_class;
        private System.Windows.Forms.CheckBox chVerify;
        private System.Windows.Forms.DataGridView dataMoney02Un;
        private System.Windows.Forms.Label lblaccdata;
        private System.Windows.Forms.Label lblDataDiary;
        private System.Windows.Forms.Label label2;
    }
}