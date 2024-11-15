namespace FinanceAccountProgram.FrmControl
{
    partial class FrmFinanceBalanceRpt
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
            this.btnBalanceReport = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.lstMsgFinanceBalance = new System.Windows.Forms.ListBox();
            this.dgBalanceFinancial = new System.Windows.Forms.DataGridView();
            this.btnFinanceBalance = new System.Windows.Forms.Button();
            this.lblFinanceBalance = new System.Windows.Forms.Label();
            this.lblBalanceSheetCnt = new System.Windows.Forms.Label();
            this.btnDiffData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgBalanceFinancial)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBalanceReport
            // 
            this.btnBalanceReport.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBalanceReport.Location = new System.Drawing.Point(586, 31);
            this.btnBalanceReport.Name = "btnBalanceReport";
            this.btnBalanceReport.Size = new System.Drawing.Size(162, 53);
            this.btnBalanceReport.TabIndex = 15;
            this.btnBalanceReport.Text = "報表";
            this.btnBalanceReport.UseVisualStyleBackColor = true;
            this.btnBalanceReport.Click += new System.EventHandler(this.btnBalanceReport_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.Location = new System.Drawing.Point(1053, 65);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 19);
            this.label14.TabIndex = 14;
            this.label14.Text = "訊息";
            // 
            // lstMsgFinanceBalance
            // 
            this.lstMsgFinanceBalance.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lstMsgFinanceBalance.FormattingEnabled = true;
            this.lstMsgFinanceBalance.ItemHeight = 19;
            this.lstMsgFinanceBalance.Location = new System.Drawing.Point(1053, 91);
            this.lstMsgFinanceBalance.Name = "lstMsgFinanceBalance";
            this.lstMsgFinanceBalance.Size = new System.Drawing.Size(372, 707);
            this.lstMsgFinanceBalance.TabIndex = 13;
            // 
            // dgBalanceFinancial
            // 
            this.dgBalanceFinancial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBalanceFinancial.Location = new System.Drawing.Point(12, 92);
            this.dgBalanceFinancial.Name = "dgBalanceFinancial";
            this.dgBalanceFinancial.RowTemplate.Height = 24;
            this.dgBalanceFinancial.Size = new System.Drawing.Size(1032, 702);
            this.dgBalanceFinancial.TabIndex = 12;
            // 
            // btnFinanceBalance
            // 
            this.btnFinanceBalance.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFinanceBalance.Location = new System.Drawing.Point(417, 30);
            this.btnFinanceBalance.Name = "btnFinanceBalance";
            this.btnFinanceBalance.Size = new System.Drawing.Size(162, 53);
            this.btnFinanceBalance.TabIndex = 11;
            this.btnFinanceBalance.Text = "查詢";
            this.btnFinanceBalance.UseVisualStyleBackColor = true;
            this.btnFinanceBalance.Click += new System.EventHandler(this.btnFinanceBalance_Click);
            // 
            // lblFinanceBalance
            // 
            this.lblFinanceBalance.AutoSize = true;
            this.lblFinanceBalance.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblFinanceBalance.Location = new System.Drawing.Point(7, 10);
            this.lblFinanceBalance.Name = "lblFinanceBalance";
            this.lblFinanceBalance.Size = new System.Drawing.Size(147, 27);
            this.lblFinanceBalance.TabIndex = 10;
            this.lblFinanceBalance.Text = "資產負債表";
            // 
            // lblBalanceSheetCnt
            // 
            this.lblBalanceSheetCnt.AutoSize = true;
            this.lblBalanceSheetCnt.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblBalanceSheetCnt.Location = new System.Drawing.Point(175, 53);
            this.lblBalanceSheetCnt.Name = "lblBalanceSheetCnt";
            this.lblBalanceSheetCnt.Size = new System.Drawing.Size(243, 27);
            this.lblBalanceSheetCnt.TabIndex = 16;
            this.lblBalanceSheetCnt.Text = "                                 ";
            // 
            // btnDiffData
            // 
            this.btnDiffData.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDiffData.Location = new System.Drawing.Point(755, 31);
            this.btnDiffData.Name = "btnDiffData";
            this.btnDiffData.Size = new System.Drawing.Size(162, 53);
            this.btnDiffData.TabIndex = 15;
            this.btnDiffData.Text = "差異";
            this.btnDiffData.UseVisualStyleBackColor = true;
            this.btnDiffData.Visible = false;
            this.btnDiffData.Click += new System.EventHandler(this.btnDiffData_Click);
            // 
            // FrmFinanceBalanceRpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1438, 833);
            this.Controls.Add(this.lblBalanceSheetCnt);
            this.Controls.Add(this.btnDiffData);
            this.Controls.Add(this.btnBalanceReport);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lstMsgFinanceBalance);
            this.Controls.Add(this.dgBalanceFinancial);
            this.Controls.Add(this.btnFinanceBalance);
            this.Controls.Add(this.lblFinanceBalance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmFinanceBalanceRpt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "資產負債表";
            this.Shown += new System.EventHandler(this.FrmFinanceBalanceRpt_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgBalanceFinancial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBalanceReport;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListBox lstMsgFinanceBalance;
        private System.Windows.Forms.DataGridView dgBalanceFinancial;
        private System.Windows.Forms.Button btnFinanceBalance;
        private System.Windows.Forms.Label lblFinanceBalance;
        private System.Windows.Forms.Label lblBalanceSheetCnt;
        private System.Windows.Forms.Button btnDiffData;
    }
}