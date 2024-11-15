namespace FinanceAccountProgram.FrmControl
{
    partial class FrmAmountSettle
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
            this.btnALegerQuery = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblLedgerLend = new System.Windows.Forms.Label();
            this.lblLedgerResult = new System.Windows.Forms.Label();
            this.lblGet = new System.Windows.Forms.Label();
            this.lblLedgerGetVal = new System.Windows.Forms.Label();
            this.lblLend = new System.Windows.Forms.Label();
            this.dgLedger = new System.Windows.Forms.DataGridView();
            this.btnImport = new System.Windows.Forms.Button();
            this.lblNwYear = new System.Windows.Forms.Label();
            this.lblNwYearValue = new System.Windows.Forms.Label();
            this.lblTtlCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgLedger)).BeginInit();
            this.SuspendLayout();
            // 
            // btnALegerQuery
            // 
            this.btnALegerQuery.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnALegerQuery.Location = new System.Drawing.Point(1245, 17);
            this.btnALegerQuery.Name = "btnALegerQuery";
            this.btnALegerQuery.Size = new System.Drawing.Size(105, 52);
            this.btnALegerQuery.TabIndex = 9;
            this.btnALegerQuery.Text = "查詢";
            this.btnALegerQuery.UseVisualStyleBackColor = true;
            this.btnALegerQuery.Click += new System.EventHandler(this.btnALegerQuery_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnGenerate.Location = new System.Drawing.Point(1132, 17);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(105, 52);
            this.btnGenerate.TabIndex = 10;
            this.btnGenerate.Text = "產生";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblLedgerLend
            // 
            this.lblLedgerLend.AutoSize = true;
            this.lblLedgerLend.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblLedgerLend.Location = new System.Drawing.Point(299, 15);
            this.lblLedgerLend.Name = "lblLedgerLend";
            this.lblLedgerLend.Size = new System.Drawing.Size(111, 19);
            this.lblLedgerLend.TabIndex = 4;
            this.lblLedgerLend.Text = "                 ";
            // 
            // lblLedgerResult
            // 
            this.lblLedgerResult.AutoSize = true;
            this.lblLedgerResult.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblLedgerResult.Location = new System.Drawing.Point(530, 15);
            this.lblLedgerResult.Name = "lblLedgerResult";
            this.lblLedgerResult.Size = new System.Drawing.Size(69, 19);
            this.lblLedgerResult.TabIndex = 5;
            this.lblLedgerResult.Text = "結果：";
            // 
            // lblGet
            // 
            this.lblGet.AutoSize = true;
            this.lblGet.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblGet.Location = new System.Drawing.Point(22, 15);
            this.lblGet.Name = "lblGet";
            this.lblGet.Size = new System.Drawing.Size(49, 19);
            this.lblGet.TabIndex = 6;
            this.lblGet.Text = "借：";
            // 
            // lblLedgerGetVal
            // 
            this.lblLedgerGetVal.AutoSize = true;
            this.lblLedgerGetVal.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblLedgerGetVal.Location = new System.Drawing.Point(66, 15);
            this.lblLedgerGetVal.Name = "lblLedgerGetVal";
            this.lblLedgerGetVal.Size = new System.Drawing.Size(111, 19);
            this.lblLedgerGetVal.TabIndex = 7;
            this.lblLedgerGetVal.Text = "                 ";
            // 
            // lblLend
            // 
            this.lblLend.AutoSize = true;
            this.lblLend.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblLend.Location = new System.Drawing.Point(251, 15);
            this.lblLend.Name = "lblLend";
            this.lblLend.Size = new System.Drawing.Size(49, 19);
            this.lblLend.TabIndex = 8;
            this.lblLend.Text = "貸：";
            // 
            // dgLedger
            // 
            this.dgLedger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLedger.Location = new System.Drawing.Point(19, 80);
            this.dgLedger.Name = "dgLedger";
            this.dgLedger.RowTemplate.Height = 24;
            this.dgLedger.Size = new System.Drawing.Size(1311, 617);
            this.dgLedger.TabIndex = 3;
            this.dgLedger.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgLedger_CellFormatting);
            // 
            // btnImport
            // 
            this.btnImport.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnImport.Location = new System.Drawing.Point(1020, 17);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(105, 52);
            this.btnImport.TabIndex = 9;
            this.btnImport.Text = "轉入";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // lblNwYear
            // 
            this.lblNwYear.AutoSize = true;
            this.lblNwYear.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblNwYear.Location = new System.Drawing.Point(718, 48);
            this.lblNwYear.Name = "lblNwYear";
            this.lblNwYear.Size = new System.Drawing.Size(89, 19);
            this.lblNwYear.TabIndex = 13;
            this.lblNwYear.Text = "現今年度";
            // 
            // lblNwYearValue
            // 
            this.lblNwYearValue.AutoSize = true;
            this.lblNwYearValue.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblNwYearValue.Location = new System.Drawing.Point(810, 48);
            this.lblNwYearValue.Name = "lblNwYearValue";
            this.lblNwYearValue.Size = new System.Drawing.Size(69, 19);
            this.lblNwYearValue.TabIndex = 14;
            this.lblNwYearValue.Text = "          ";
            // 
            // lblTtlCount
            // 
            this.lblTtlCount.AutoSize = true;
            this.lblTtlCount.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTtlCount.Location = new System.Drawing.Point(897, 48);
            this.lblTtlCount.Name = "lblTtlCount";
            this.lblTtlCount.Size = new System.Drawing.Size(69, 19);
            this.lblTtlCount.TabIndex = 15;
            this.lblTtlCount.Text = "共幾筆";
            // 
            // FrmAmountSettle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 712);
            this.Controls.Add(this.lblTtlCount);
            this.Controls.Add(this.lblNwYearValue);
            this.Controls.Add(this.lblNwYear);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnALegerQuery);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lblLedgerLend);
            this.Controls.Add(this.lblLedgerResult);
            this.Controls.Add(this.lblGet);
            this.Controls.Add(this.lblLedgerGetVal);
            this.Controls.Add(this.lblLend);
            this.Controls.Add(this.dgLedger);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmAmountSettle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系統總帳結算";
            this.Load += new System.EventHandler(this.FrmAmountSettle_Load);
            this.Shown += new System.EventHandler(this.FrmAmountSettle_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgLedger)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnALegerQuery;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblLedgerLend;
        private System.Windows.Forms.Label lblLedgerResult;
        private System.Windows.Forms.Label lblGet;
        private System.Windows.Forms.Label lblLedgerGetVal;
        private System.Windows.Forms.Label lblLend;
        private System.Windows.Forms.DataGridView dgLedger;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Label lblNwYear;
        private System.Windows.Forms.Label lblNwYearValue;
        private System.Windows.Forms.Label lblTtlCount;
    }
}