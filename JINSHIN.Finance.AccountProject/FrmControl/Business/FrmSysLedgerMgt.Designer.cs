namespace FinanceAccountProgram.FrmControl
{
    partial class FrmSysLedgerMgt
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
            this.chDataAgain = new System.Windows.Forms.CheckBox();
            this.btnOpenAccount = new System.Windows.Forms.Button();
            this.gbAccountsData = new System.Windows.Forms.GroupBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataFinancialLedger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgFinancialSettlGridView)).BeginInit();
            this.gbAccountsData.SuspendLayout();
            this.SuspendLayout();
            // 
            // chDataFull
            // 
            this.chDataFull.AutoSize = true;
            this.chDataFull.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chDataFull.Location = new System.Drawing.Point(653, 45);
            this.chDataFull.Name = "chDataFull";
            this.chDataFull.Size = new System.Drawing.Size(104, 23);
            this.chDataFull.TabIndex = 15;
            this.chDataFull.Text = "預先結算";
            this.chDataFull.UseVisualStyleBackColor = true;
            this.chDataFull.Visible = false;
            // 
            // lblsettleMsg
            // 
            this.lblsettleMsg.AutoSize = true;
            this.lblsettleMsg.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblsettleMsg.Location = new System.Drawing.Point(1166, 64);
            this.lblsettleMsg.Name = "lblsettleMsg";
            this.lblsettleMsg.Size = new System.Drawing.Size(47, 19);
            this.lblsettleMsg.TabIndex = 14;
            this.lblsettleMsg.Text = "訊息";
            // 
            // LstFinanacialMsg
            // 
            this.LstFinanacialMsg.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LstFinanacialMsg.FormattingEnabled = true;
            this.LstFinanacialMsg.ItemHeight = 19;
            this.LstFinanacialMsg.Location = new System.Drawing.Point(939, 93);
            this.LstFinanacialMsg.Name = "LstFinanacialMsg";
            this.LstFinanacialMsg.Size = new System.Drawing.Size(279, 650);
            this.LstFinanacialMsg.TabIndex = 13;
            // 
            // dataFinancialLedger
            // 
            this.dataFinancialLedger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFinancialLedger.Location = new System.Drawing.Point(13, 93);
            this.dataFinancialLedger.Name = "dataFinancialLedger";
            this.dataFinancialLedger.RowTemplate.Height = 24;
            this.dataFinancialLedger.Size = new System.Drawing.Size(919, 691);
            this.dataFinancialLedger.TabIndex = 11;
            this.dataFinancialLedger.Tag = "0,6";
            // 
            // dgFinancialSettlGridView
            // 
            this.dgFinancialSettlGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFinancialSettlGridView.Location = new System.Drawing.Point(1239, 73);
            this.dgFinancialSettlGridView.Name = "dgFinancialSettlGridView";
            this.dgFinancialSettlGridView.RowTemplate.Height = 24;
            this.dgFinancialSettlGridView.Size = new System.Drawing.Size(558, 690);
            this.dgFinancialSettlGridView.TabIndex = 12;
            this.dgFinancialSettlGridView.Tag = "0,6";
            this.dgFinancialSettlGridView.Visible = false;
            // 
            // btnCheckAccounts
            // 
            this.btnCheckAccounts.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCheckAccounts.Location = new System.Drawing.Point(1523, 13);
            this.btnCheckAccounts.Name = "btnCheckAccounts";
            this.btnCheckAccounts.Size = new System.Drawing.Size(139, 54);
            this.btnCheckAccounts.TabIndex = 5;
            this.btnCheckAccounts.Text = "檢查資料";
            this.btnCheckAccounts.UseVisualStyleBackColor = true;
            this.btnCheckAccounts.Visible = false;
            this.btnCheckAccounts.Click += new System.EventHandler(this.btnCheckAccounts_Click);
            // 
            // btnArrangeNew
            // 
            this.btnArrangeNew.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnArrangeNew.Location = new System.Drawing.Point(1378, 13);
            this.btnArrangeNew.Name = "btnArrangeNew";
            this.btnArrangeNew.Size = new System.Drawing.Size(139, 54);
            this.btnArrangeNew.TabIndex = 6;
            this.btnArrangeNew.Text = "重新排列";
            this.btnArrangeNew.UseVisualStyleBackColor = true;
            this.btnArrangeNew.Visible = false;
            this.btnArrangeNew.Click += new System.EventHandler(this.btnArrangeNew_Click);
            // 
            // btnCheckAccNo
            // 
            this.btnCheckAccNo.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCheckAccNo.Location = new System.Drawing.Point(1239, 12);
            this.btnCheckAccNo.Name = "btnCheckAccNo";
            this.btnCheckAccNo.Size = new System.Drawing.Size(133, 55);
            this.btnCheckAccNo.TabIndex = 7;
            this.btnCheckAccNo.Text = "檢查排序";
            this.btnCheckAccNo.UseVisualStyleBackColor = true;
            this.btnCheckAccNo.Visible = false;
            this.btnCheckAccNo.Click += new System.EventHandler(this.btnCheckAccNo_Click);
            // 
            // btnReportExportData
            // 
            this.btnReportExportData.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReportExportData.Location = new System.Drawing.Point(505, 18);
            this.btnReportExportData.Name = "btnReportExportData";
            this.btnReportExportData.Size = new System.Drawing.Size(141, 55);
            this.btnReportExportData.TabIndex = 8;
            this.btnReportExportData.Text = "匯出";
            this.btnReportExportData.UseVisualStyleBackColor = true;
            this.btnReportExportData.Click += new System.EventHandler(this.btnReportExportData_Click);
            // 
            // btnSetttleQuery
            // 
            this.btnSetttleQuery.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSetttleQuery.Location = new System.Drawing.Point(354, 17);
            this.btnSetttleQuery.Name = "btnSetttleQuery";
            this.btnSetttleQuery.Size = new System.Drawing.Size(141, 55);
            this.btnSetttleQuery.TabIndex = 9;
            this.btnSetttleQuery.Text = "查詢";
            this.btnSetttleQuery.UseVisualStyleBackColor = true;
            this.btnSetttleQuery.Click += new System.EventHandler(this.btnSetttleQuery_Click);
            // 
            // btnSettle
            // 
            this.btnSettle.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSettle.Location = new System.Drawing.Point(203, 17);
            this.btnSettle.Name = "btnSettle";
            this.btnSettle.Size = new System.Drawing.Size(141, 55);
            this.btnSettle.TabIndex = 10;
            this.btnSettle.Text = "結算";
            this.btnSettle.UseVisualStyleBackColor = true;
            this.btnSettle.Click += new System.EventHandler(this.btnSettle_Click);
            // 
            // chDataAgain
            // 
            this.chDataAgain.AutoSize = true;
            this.chDataAgain.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chDataAgain.Location = new System.Drawing.Point(10, 39);
            this.chDataAgain.Name = "chDataAgain";
            this.chDataAgain.Size = new System.Drawing.Size(104, 23);
            this.chDataAgain.TabIndex = 16;
            this.chDataAgain.Text = "覆蓋開帳";
            this.chDataAgain.UseVisualStyleBackColor = true;
            // 
            // btnOpenAccount
            // 
            this.btnOpenAccount.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOpenAccount.Location = new System.Drawing.Point(128, 14);
            this.btnOpenAccount.Name = "btnOpenAccount";
            this.btnOpenAccount.Size = new System.Drawing.Size(144, 55);
            this.btnOpenAccount.TabIndex = 17;
            this.btnOpenAccount.Text = "開帳";
            this.btnOpenAccount.UseVisualStyleBackColor = true;
            this.btnOpenAccount.Click += new System.EventHandler(this.btnOpenAccount_Click);
            // 
            // gbAccountsData
            // 
            this.gbAccountsData.Controls.Add(this.btnOpenAccount);
            this.gbAccountsData.Controls.Add(this.chDataAgain);
            this.gbAccountsData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbAccountsData.Location = new System.Drawing.Point(758, 5);
            this.gbAccountsData.Name = "gbAccountsData";
            this.gbAccountsData.Size = new System.Drawing.Size(288, 75);
            this.gbAccountsData.TabIndex = 18;
            this.gbAccountsData.TabStop = false;
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtYear.Location = new System.Drawing.Point(67, 31);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(120, 30);
            this.txtYear.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(9, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "年度";
            // 
            // FrmSysLedgerMgt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1224, 786);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbAccountsData);
            this.Controls.Add(this.chDataFull);
            this.Controls.Add(this.lblsettleMsg);
            this.Controls.Add(this.LstFinanacialMsg);
            this.Controls.Add(this.dataFinancialLedger);
            this.Controls.Add(this.dgFinancialSettlGridView);
            this.Controls.Add(this.btnCheckAccounts);
            this.Controls.Add(this.btnArrangeNew);
            this.Controls.Add(this.btnCheckAccNo);
            this.Controls.Add(this.btnReportExportData);
            this.Controls.Add(this.btnSetttleQuery);
            this.Controls.Add(this.btnSettle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmSysLedgerMgt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系統總帳管理";
            this.Shown += new System.EventHandler(this.FrmSysLedgerMgt_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataFinancialLedger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgFinancialSettlGridView)).EndInit();
            this.gbAccountsData.ResumeLayout(false);
            this.gbAccountsData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chDataFull;
        private System.Windows.Forms.Label lblsettleMsg;
        private System.Windows.Forms.ListBox LstFinanacialMsg;
        private System.Windows.Forms.DataGridView dataFinancialLedger;
        private System.Windows.Forms.DataGridView dgFinancialSettlGridView;
        private System.Windows.Forms.Button btnCheckAccounts;
        private System.Windows.Forms.Button btnArrangeNew;
        private System.Windows.Forms.Button btnCheckAccNo;
        private System.Windows.Forms.Button btnReportExportData;
        private System.Windows.Forms.Button btnSetttleQuery;
        private System.Windows.Forms.Button btnSettle;
        private System.Windows.Forms.CheckBox chDataAgain;
        private System.Windows.Forms.Button btnOpenAccount;
        private System.Windows.Forms.GroupBox gbAccountsData;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label1;
    }
}