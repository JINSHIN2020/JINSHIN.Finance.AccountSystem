namespace FinanceAccountProgram.FrmControl
{
    partial class FrmIncomeStatmentRpt
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
            this.label13 = new System.Windows.Forms.Label();
            this.lstMsgIncomeStatment = new System.Windows.Forms.ListBox();
            this.btnIncomeReport = new System.Windows.Forms.Button();
            this.btnReportExport = new System.Windows.Forms.Button();
            this.dgIncomeFinancial = new System.Windows.Forms.DataGridView();
            this.btnIncomeFinancial = new System.Windows.Forms.Button();
            this.lblIncomeStatement = new System.Windows.Forms.Label();
            this.lblFinancialRptCnt = new System.Windows.Forms.Label();
            this.btnIncomeVerify = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgIncomeFinancial)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.Location = new System.Drawing.Point(979, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 27);
            this.label13.TabIndex = 12;
            this.label13.Text = "訊息";
            // 
            // lstMsgIncomeStatment
            // 
            this.lstMsgIncomeStatment.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lstMsgIncomeStatment.FormattingEnabled = true;
            this.lstMsgIncomeStatment.ItemHeight = 19;
            this.lstMsgIncomeStatment.Location = new System.Drawing.Point(983, 63);
            this.lstMsgIncomeStatment.Name = "lstMsgIncomeStatment";
            this.lstMsgIncomeStatment.Size = new System.Drawing.Size(372, 707);
            this.lstMsgIncomeStatment.TabIndex = 11;
            // 
            // btnIncomeReport
            // 
            this.btnIncomeReport.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnIncomeReport.Location = new System.Drawing.Point(454, 8);
            this.btnIncomeReport.Name = "btnIncomeReport";
            this.btnIncomeReport.Size = new System.Drawing.Size(144, 52);
            this.btnIncomeReport.TabIndex = 9;
            this.btnIncomeReport.Text = "報表";
            this.btnIncomeReport.UseVisualStyleBackColor = true;
            this.btnIncomeReport.Click += new System.EventHandler(this.btnIncomeReport_Click);
            // 
            // btnReportExport
            // 
            this.btnReportExport.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReportExport.Location = new System.Drawing.Point(776, 8);
            this.btnReportExport.Name = "btnReportExport";
            this.btnReportExport.Size = new System.Drawing.Size(144, 52);
            this.btnReportExport.TabIndex = 10;
            this.btnReportExport.Text = "匯出";
            this.btnReportExport.UseVisualStyleBackColor = true;
            this.btnReportExport.Visible = false;
            this.btnReportExport.Click += new System.EventHandler(this.btnReportExport_Click);
            // 
            // dgIncomeFinancial
            // 
            this.dgIncomeFinancial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgIncomeFinancial.Location = new System.Drawing.Point(12, 64);
            this.dgIncomeFinancial.Name = "dgIncomeFinancial";
            this.dgIncomeFinancial.RowTemplate.Height = 24;
            this.dgIncomeFinancial.Size = new System.Drawing.Size(967, 702);
            this.dgIncomeFinancial.TabIndex = 8;
            // 
            // btnIncomeFinancial
            // 
            this.btnIncomeFinancial.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnIncomeFinancial.Location = new System.Drawing.Point(298, 8);
            this.btnIncomeFinancial.Name = "btnIncomeFinancial";
            this.btnIncomeFinancial.Size = new System.Drawing.Size(144, 52);
            this.btnIncomeFinancial.TabIndex = 7;
            this.btnIncomeFinancial.Text = "查詢";
            this.btnIncomeFinancial.UseVisualStyleBackColor = true;
            this.btnIncomeFinancial.Click += new System.EventHandler(this.btnIncomeFinancial_Click);
            // 
            // lblIncomeStatement
            // 
            this.lblIncomeStatement.AutoSize = true;
            this.lblIncomeStatement.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblIncomeStatement.Location = new System.Drawing.Point(13, 27);
            this.lblIncomeStatement.Name = "lblIncomeStatement";
            this.lblIncomeStatement.Size = new System.Drawing.Size(76, 22);
            this.lblIncomeStatement.TabIndex = 6;
            this.lblIncomeStatement.Text = "損益表";
            // 
            // lblFinancialRptCnt
            // 
            this.lblFinancialRptCnt.AutoSize = true;
            this.lblFinancialRptCnt.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblFinancialRptCnt.Location = new System.Drawing.Point(112, 29);
            this.lblFinancialRptCnt.Name = "lblFinancialRptCnt";
            this.lblFinancialRptCnt.Size = new System.Drawing.Size(180, 27);
            this.lblFinancialRptCnt.TabIndex = 13;
            this.lblFinancialRptCnt.Text = "                        ";
            // 
            // btnIncomeVerify
            // 
            this.btnIncomeVerify.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnIncomeVerify.Location = new System.Drawing.Point(613, 8);
            this.btnIncomeVerify.Name = "btnIncomeVerify";
            this.btnIncomeVerify.Size = new System.Drawing.Size(144, 52);
            this.btnIncomeVerify.TabIndex = 9;
            this.btnIncomeVerify.Text = "審核";
            this.btnIncomeVerify.UseVisualStyleBackColor = true;
            this.btnIncomeVerify.Click += new System.EventHandler(this.btnIncomeVerify_Click);
            // 
            // FrmIncomeStatmentRpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1366, 781);
            this.Controls.Add(this.lblFinancialRptCnt);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lstMsgIncomeStatment);
            this.Controls.Add(this.btnIncomeVerify);
            this.Controls.Add(this.btnIncomeReport);
            this.Controls.Add(this.btnReportExport);
            this.Controls.Add(this.dgIncomeFinancial);
            this.Controls.Add(this.btnIncomeFinancial);
            this.Controls.Add(this.lblIncomeStatement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmIncomeStatmentRpt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "損益表";
            this.Shown += new System.EventHandler(this.FrmIncomeStatmentRpt_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgIncomeFinancial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox lstMsgIncomeStatment;
        private System.Windows.Forms.Button btnIncomeReport;
        private System.Windows.Forms.Button btnReportExport;
        private System.Windows.Forms.DataGridView dgIncomeFinancial;
        private System.Windows.Forms.Button btnIncomeFinancial;
        private System.Windows.Forms.Label lblIncomeStatement;
        private System.Windows.Forms.Label lblFinancialRptCnt;
        private System.Windows.Forms.Button btnIncomeVerify;
    }
}