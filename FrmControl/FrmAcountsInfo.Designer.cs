namespace FinanceAccountProgram.FrmControl
{
    partial class FrmAccountsInfo
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
            this.dataFinancialLedger = new System.Windows.Forms.DataGridView();
            this.btnView = new System.Windows.Forms.Button();
            this.LstFinanacialMsg = new System.Windows.Forms.ListBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.chDelete = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataFinancialLedger)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataFinancialLedger
            // 
            this.dataFinancialLedger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFinancialLedger.Location = new System.Drawing.Point(12, 74);
            this.dataFinancialLedger.Name = "dataFinancialLedger";
            this.dataFinancialLedger.RowTemplate.Height = 24;
            this.dataFinancialLedger.Size = new System.Drawing.Size(771, 631);
            this.dataFinancialLedger.TabIndex = 0;
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnView.Location = new System.Drawing.Point(146, 3);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(151, 56);
            this.btnView.TabIndex = 1;
            this.btnView.Text = "檢視";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // LstFinanacialMsg
            // 
            this.LstFinanacialMsg.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LstFinanacialMsg.FormattingEnabled = true;
            this.LstFinanacialMsg.ItemHeight = 21;
            this.LstFinanacialMsg.Location = new System.Drawing.Point(812, 74);
            this.LstFinanacialMsg.Name = "LstFinanacialMsg";
            this.LstFinanacialMsg.Size = new System.Drawing.Size(411, 634);
            this.LstFinanacialMsg.TabIndex = 2;
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtYear.Location = new System.Drawing.Point(550, 27);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(157, 30);
            this.txtYear.TabIndex = 3;
            this.txtYear.Text = "2022";
            this.txtYear.TextChanged += new System.EventHandler(this.txtYear_TextChanged);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblYear.Location = new System.Drawing.Point(497, 32);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(47, 19);
            this.lblYear.TabIndex = 4;
            this.lblYear.Text = "年度";
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnExport.Location = new System.Drawing.Point(303, 3);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(151, 56);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "匯出";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnImport
            // 
            this.btnImport.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnImport.Location = new System.Drawing.Point(3, 3);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(137, 56);
            this.btnImport.TabIndex = 5;
            this.btnImport.Text = "產生";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // chDelete
            // 
            this.chDelete.AutoSize = true;
            this.chDelete.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chDelete.Location = new System.Drawing.Point(717, 31);
            this.chDelete.Name = "chDelete";
            this.chDelete.Size = new System.Drawing.Size(104, 23);
            this.chDelete.TabIndex = 6;
            this.chDelete.Text = "覆蓋資料";
            this.chDelete.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnImport);
            this.flowLayoutPanel1.Controls.Add(this.btnView);
            this.flowLayoutPanel1.Controls.Add(this.btnExport);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(464, 62);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // FrmAccountsInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1235, 745);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.chDelete);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.LstFinanacialMsg);
            this.Controls.Add(this.dataFinancialLedger);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAccountsInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "帳戶餘額";
            this.Shown += new System.EventHandler(this.FrmAccountsInfo_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataFinancialLedger)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataFinancialLedger;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.ListBox LstFinanacialMsg;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.CheckBox chDelete;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}