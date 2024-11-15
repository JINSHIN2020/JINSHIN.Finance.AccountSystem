namespace FinanceAccountProgram.ViewFrm
{
    partial class AffairsFormDlg
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
            this.lstmsg = new System.Windows.Forms.ListBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.btnVerifyCheck = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgControl = new System.Windows.Forms.DataGridView();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.chCheck = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgControl)).BeginInit();
            this.SuspendLayout();
            // 
            // lstmsg
            // 
            this.lstmsg.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lstmsg.FormattingEnabled = true;
            this.lstmsg.ItemHeight = 16;
            this.lstmsg.Location = new System.Drawing.Point(1209, 89);
            this.lstmsg.Name = "lstmsg";
            this.lstmsg.Size = new System.Drawing.Size(246, 676);
            this.lstmsg.TabIndex = 45;
            // 
            // btnQuery
            // 
            this.btnQuery.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnQuery.Location = new System.Drawing.Point(1038, 13);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(165, 67);
            this.btnQuery.TabIndex = 44;
            this.btnQuery.Text = "查詢";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAnalyze.Location = new System.Drawing.Point(12, 12);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(165, 67);
            this.btnAnalyze.TabIndex = 38;
            this.btnAnalyze.Text = "分析";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnExport.Location = new System.Drawing.Point(183, 13);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(165, 67);
            this.btnExport.TabIndex = 39;
            this.btnExport.Text = "匯出";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnInvoice
            // 
            this.btnInvoice.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnInvoice.Location = new System.Drawing.Point(354, 13);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(165, 67);
            this.btnInvoice.TabIndex = 40;
            this.btnInvoice.Text = "發票";
            this.btnInvoice.UseVisualStyleBackColor = true;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // btnVerifyCheck
            // 
            this.btnVerifyCheck.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnVerifyCheck.Location = new System.Drawing.Point(525, 12);
            this.btnVerifyCheck.Name = "btnVerifyCheck";
            this.btnVerifyCheck.Size = new System.Drawing.Size(165, 67);
            this.btnVerifyCheck.TabIndex = 41;
            this.btnVerifyCheck.Text = "確認";
            this.btnVerifyCheck.UseVisualStyleBackColor = true;
            this.btnVerifyCheck.Click += new System.EventHandler(this.btnVerifyCheck_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancel.Location = new System.Drawing.Point(696, 13);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(165, 67);
            this.btnCancel.TabIndex = 42;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUpdate.Location = new System.Drawing.Point(867, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(165, 67);
            this.btnUpdate.TabIndex = 43;
            this.btnUpdate.Text = "更新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgControl
            // 
            this.dgControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgControl.Location = new System.Drawing.Point(12, 89);
            this.dgControl.Name = "dgControl";
            this.dgControl.RowTemplate.Height = 24;
            this.dgControl.Size = new System.Drawing.Size(1191, 682);
            this.dgControl.TabIndex = 37;
            this.dgControl.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgControl_CellFormatting);
            this.dgControl.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgControl_CellValueChanged);
            this.dgControl.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgControl_ColumnHeaderMouseClick);
            this.dgControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgControl_KeyDown);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblYear.Location = new System.Drawing.Point(1340, 54);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(54, 22);
            this.lblYear.TabIndex = 46;
            this.lblYear.Text = "年份";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblValue.Location = new System.Drawing.Point(1393, 54);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(54, 22);
            this.lblValue.TabIndex = 46;
            this.lblValue.Text = "年份";
            // 
            // chCheck
            // 
            this.chCheck.AutoSize = true;
            this.chCheck.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chCheck.Location = new System.Drawing.Point(1209, 53);
            this.chCheck.Name = "chCheck";
            this.chCheck.Size = new System.Drawing.Size(95, 26);
            this.chCheck.TabIndex = 47;
            this.chCheck.Text = "已勾稽";
            this.chCheck.UseVisualStyleBackColor = true;
            // 
            // AffairsFormDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 789);
            this.Controls.Add(this.chCheck);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lstmsg);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnInvoice);
            this.Controls.Add(this.btnVerifyCheck);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AffairsFormDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "事務資料";
            this.Load += new System.EventHandler(this.AffairsFormDlg_Load);
            this.Shown += new System.EventHandler(this.AffairsFormDlg_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstmsg;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.Button btnVerifyCheck;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgControl;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.CheckBox chCheck;
    }
}