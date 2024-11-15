namespace FinanceAccountProgram.Controls
{
    partial class UpdateFrm
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgControl = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnVerifyCheck = new System.Windows.Forms.Button();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.lstmsg = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgControl)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuery
            // 
            this.btnQuery.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnQuery.Location = new System.Drawing.Point(1041, 12);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(165, 67);
            this.btnQuery.TabIndex = 35;
            this.btnQuery.Text = "查詢";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUpdate.Location = new System.Drawing.Point(870, 11);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(165, 67);
            this.btnUpdate.TabIndex = 34;
            this.btnUpdate.Text = "更新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgControl
            // 
            this.dgControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgControl.Location = new System.Drawing.Point(15, 88);
            this.dgControl.Name = "dgControl";
            this.dgControl.RowTemplate.Height = 24;
            this.dgControl.Size = new System.Drawing.Size(1279, 682);
            this.dgControl.TabIndex = 33;
            this.dgControl.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgControl_CellContentClick);
            this.dgControl.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgControl_CellValueChanged);
            this.dgControl.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgControl_ColumnHeaderMouseClick);
            this.dgControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgControl_KeyDown);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancel.Location = new System.Drawing.Point(699, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(165, 67);
            this.btnCancel.TabIndex = 34;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnVerifyCheck
            // 
            this.btnVerifyCheck.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnVerifyCheck.Location = new System.Drawing.Point(528, 11);
            this.btnVerifyCheck.Name = "btnVerifyCheck";
            this.btnVerifyCheck.Size = new System.Drawing.Size(165, 67);
            this.btnVerifyCheck.TabIndex = 34;
            this.btnVerifyCheck.Text = "確認";
            this.btnVerifyCheck.UseVisualStyleBackColor = true;
            this.btnVerifyCheck.Click += new System.EventHandler(this.btnVerifyCheck_Click);
            // 
            // btnInvoice
            // 
            this.btnInvoice.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnInvoice.Location = new System.Drawing.Point(357, 12);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(165, 67);
            this.btnInvoice.TabIndex = 34;
            this.btnInvoice.Text = "發票";
            this.btnInvoice.UseVisualStyleBackColor = true;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnExport.Location = new System.Drawing.Point(186, 12);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(165, 67);
            this.btnExport.TabIndex = 34;
            this.btnExport.Text = "匯出";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAnalyze.Location = new System.Drawing.Point(15, 11);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(165, 67);
            this.btnAnalyze.TabIndex = 34;
            this.btnAnalyze.Text = "分析";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // lstmsg
            // 
            this.lstmsg.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lstmsg.FormattingEnabled = true;
            this.lstmsg.ItemHeight = 16;
            this.lstmsg.Location = new System.Drawing.Point(1300, 88);
            this.lstmsg.Name = "lstmsg";
            this.lstmsg.Size = new System.Drawing.Size(191, 676);
            this.lstmsg.TabIndex = 36;
            // 
            // UpdateFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lstmsg);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnInvoice);
            this.Controls.Add(this.btnVerifyCheck);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgControl);
            this.Name = "UpdateFrm";
            this.Size = new System.Drawing.Size(1500, 783);
            this.Load += new System.EventHandler(this.UpdateFrm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgControl;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnVerifyCheck;
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.ListBox lstmsg;
    }
}
