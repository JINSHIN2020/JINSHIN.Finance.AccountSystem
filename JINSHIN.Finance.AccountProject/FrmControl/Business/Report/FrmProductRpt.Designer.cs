namespace FinanceAccountProgram.FrmControl.Business.Report
{
    partial class FrmProductRpt
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
            this.coUpdateAll = new System.Windows.Forms.CheckBox();
            this.lstUpdateMonths = new System.Windows.Forms.ListBox();
            this.txtDataCnt = new System.Windows.Forms.TextBox();
            this.lblAccYear = new System.Windows.Forms.Label();
            this.lblLstMonths = new System.Windows.Forms.Label();
            this.lblDataAllCnt = new System.Windows.Forms.Label();
            this.lblSetupDataCnt = new System.Windows.Forms.Label();
            this.lblAllCnt = new System.Windows.Forms.Label();
            this.txAccYear = new System.Windows.Forms.TextBox();
            this.dgControl = new System.Windows.Forms.DataGridView();
            this.BtnQuery = new System.Windows.Forms.Button();
            this.btnVerifyAccExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgControl)).BeginInit();
            this.SuspendLayout();
            // 
            // coUpdateAll
            // 
            this.coUpdateAll.AutoSize = true;
            this.coUpdateAll.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.coUpdateAll.Location = new System.Drawing.Point(188, 64);
            this.coUpdateAll.Name = "coUpdateAll";
            this.coUpdateAll.Size = new System.Drawing.Size(104, 23);
            this.coUpdateAll.TabIndex = 56;
            this.coUpdateAll.Text = "全部月份";
            this.coUpdateAll.UseVisualStyleBackColor = true;
            this.coUpdateAll.CheckedChanged += new System.EventHandler(this.coUpdateAll_CheckedChanged);
            // 
            // lstUpdateMonths
            // 
            this.lstUpdateMonths.ColumnWidth = 50;
            this.lstUpdateMonths.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lstUpdateMonths.FormattingEnabled = true;
            this.lstUpdateMonths.ItemHeight = 19;
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
            this.lstUpdateMonths.Location = new System.Drawing.Point(303, 13);
            this.lstUpdateMonths.MultiColumn = true;
            this.lstUpdateMonths.Name = "lstUpdateMonths";
            this.lstUpdateMonths.Size = new System.Drawing.Size(236, 61);
            this.lstUpdateMonths.TabIndex = 55;
            // 
            // txtDataCnt
            // 
            this.txtDataCnt.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDataCnt.Location = new System.Drawing.Point(478, 87);
            this.txtDataCnt.Name = "txtDataCnt";
            this.txtDataCnt.Size = new System.Drawing.Size(70, 30);
            this.txtDataCnt.TabIndex = 51;
            this.txtDataCnt.Text = "20";
            this.txtDataCnt.Visible = false;
            this.txtDataCnt.TextChanged += new System.EventHandler(this.txtDataCnt_TextChanged);
            // 
            // lblAccYear
            // 
            this.lblAccYear.AutoSize = true;
            this.lblAccYear.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAccYear.Location = new System.Drawing.Point(36, 13);
            this.lblAccYear.Name = "lblAccYear";
            this.lblAccYear.Size = new System.Drawing.Size(47, 19);
            this.lblAccYear.TabIndex = 44;
            this.lblAccYear.Text = "年份";
            // 
            // lblLstMonths
            // 
            this.lblLstMonths.AutoSize = true;
            this.lblLstMonths.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblLstMonths.Location = new System.Drawing.Point(245, 13);
            this.lblLstMonths.Name = "lblLstMonths";
            this.lblLstMonths.Size = new System.Drawing.Size(47, 19);
            this.lblLstMonths.TabIndex = 45;
            this.lblLstMonths.Text = "月份";
            // 
            // lblDataAllCnt
            // 
            this.lblDataAllCnt.AutoSize = true;
            this.lblDataAllCnt.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDataAllCnt.Location = new System.Drawing.Point(665, 15);
            this.lblDataAllCnt.Name = "lblDataAllCnt";
            this.lblDataAllCnt.Size = new System.Drawing.Size(18, 19);
            this.lblDataAllCnt.TabIndex = 46;
            this.lblDataAllCnt.Text = "0";
            // 
            // lblSetupDataCnt
            // 
            this.lblSetupDataCnt.AutoSize = true;
            this.lblSetupDataCnt.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSetupDataCnt.Location = new System.Drawing.Point(383, 87);
            this.lblSetupDataCnt.Name = "lblSetupDataCnt";
            this.lblSetupDataCnt.Size = new System.Drawing.Size(85, 19);
            this.lblSetupDataCnt.TabIndex = 47;
            this.lblSetupDataCnt.Text = "資料筆數";
            this.lblSetupDataCnt.Visible = false;
            // 
            // lblAllCnt
            // 
            this.lblAllCnt.AutoSize = true;
            this.lblAllCnt.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAllCnt.Location = new System.Drawing.Point(547, 15);
            this.lblAllCnt.Name = "lblAllCnt";
            this.lblAllCnt.Size = new System.Drawing.Size(104, 19);
            this.lblAllCnt.TabIndex = 48;
            this.lblAllCnt.Text = "資料總筆數";
            // 
            // txAccYear
            // 
            this.txAccYear.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txAccYear.Location = new System.Drawing.Point(88, 13);
            this.txAccYear.Name = "txAccYear";
            this.txAccYear.Size = new System.Drawing.Size(142, 30);
            this.txAccYear.TabIndex = 52;
            // 
            // dgControl
            // 
            this.dgControl.AllowUserToOrderColumns = true;
            this.dgControl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgControl.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgControl.Location = new System.Drawing.Point(12, 129);
            this.dgControl.Name = "dgControl";
            this.dgControl.RowTemplate.Height = 24;
            this.dgControl.Size = new System.Drawing.Size(986, 437);
            this.dgControl.TabIndex = 57;
            // 
            // BtnQuery
            // 
            this.BtnQuery.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnQuery.Location = new System.Drawing.Point(734, 9);
            this.BtnQuery.Name = "BtnQuery";
            this.BtnQuery.Size = new System.Drawing.Size(134, 54);
            this.BtnQuery.TabIndex = 58;
            this.BtnQuery.Text = "查詢";
            this.BtnQuery.UseVisualStyleBackColor = true;
            this.BtnQuery.Click += new System.EventHandler(this.BtnQuery_Click);
            // 
            // btnVerifyAccExport
            // 
            this.btnVerifyAccExport.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnVerifyAccExport.Location = new System.Drawing.Point(734, 69);
            this.btnVerifyAccExport.Name = "btnVerifyAccExport";
            this.btnVerifyAccExport.Size = new System.Drawing.Size(134, 54);
            this.btnVerifyAccExport.TabIndex = 59;
            this.btnVerifyAccExport.Text = "匯出";
            this.btnVerifyAccExport.UseVisualStyleBackColor = true;
            this.btnVerifyAccExport.Click += new System.EventHandler(this.btnVerifyAccExport_Click);
            // 
            // FrmProductRpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 578);
            this.Controls.Add(this.BtnQuery);
            this.Controls.Add(this.btnVerifyAccExport);
            this.Controls.Add(this.dgControl);
            this.Controls.Add(this.coUpdateAll);
            this.Controls.Add(this.lstUpdateMonths);
            this.Controls.Add(this.txtDataCnt);
            this.Controls.Add(this.lblAccYear);
            this.Controls.Add(this.lblLstMonths);
            this.Controls.Add(this.lblDataAllCnt);
            this.Controls.Add(this.lblSetupDataCnt);
            this.Controls.Add(this.lblAllCnt);
            this.Controls.Add(this.txAccYear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmProductRpt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "商品分析報表";
            this.Load += new System.EventHandler(this.FrmProductRpt_Load);
            this.Shown += new System.EventHandler(this.FrmProductRpt_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox coUpdateAll;
        private System.Windows.Forms.ListBox lstUpdateMonths;
        private System.Windows.Forms.TextBox txtDataCnt;
        private System.Windows.Forms.Label lblAccYear;
        private System.Windows.Forms.Label lblLstMonths;
        private System.Windows.Forms.Label lblDataAllCnt;
        private System.Windows.Forms.Label lblSetupDataCnt;
        private System.Windows.Forms.Label lblAllCnt;
        private System.Windows.Forms.TextBox txAccYear;
        private System.Windows.Forms.DataGridView dgControl;
        private System.Windows.Forms.Button BtnQuery;
        private System.Windows.Forms.Button btnVerifyAccExport;
    }
}