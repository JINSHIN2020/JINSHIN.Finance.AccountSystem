namespace FinanceAccountProgram.FrmControl
{
    partial class FrmEntryVerify
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
            this.label12 = new System.Windows.Forms.Label();
            this.lstAccConfirmMsg = new System.Windows.Forms.ListBox();
            this.chConfirmAll = new System.Windows.Forms.CheckBox();
            this.lstVerifyAccds = new System.Windows.Forms.ListBox();
            this.lblLstAccIDs = new System.Windows.Forms.Label();
            this.dgControl = new System.Windows.Forms.DataGridView();
            this.btnAnalyzeAccs = new System.Windows.Forms.Button();
            this.btnAccExport = new System.Windows.Forms.Button();
            this.btnConfirmQuery = new System.Windows.Forms.Button();
            this.btnVerify = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblTitle01 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgControl)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("新細明體", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(1565, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 20);
            this.label12.TabIndex = 59;
            this.label12.Text = "訊息";
            // 
            // lstAccConfirmMsg
            // 
            this.lstAccConfirmMsg.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lstAccConfirmMsg.FormattingEnabled = true;
            this.lstAccConfirmMsg.ItemHeight = 19;
            this.lstAccConfirmMsg.Location = new System.Drawing.Point(1565, 99);
            this.lstAccConfirmMsg.Name = "lstAccConfirmMsg";
            this.lstAccConfirmMsg.Size = new System.Drawing.Size(199, 650);
            this.lstAccConfirmMsg.TabIndex = 58;
            // 
            // chConfirmAll
            // 
            this.chConfirmAll.AutoSize = true;
            this.chConfirmAll.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chConfirmAll.Location = new System.Drawing.Point(143, 14);
            this.chConfirmAll.Name = "chConfirmAll";
            this.chConfirmAll.Size = new System.Drawing.Size(104, 23);
            this.chConfirmAll.TabIndex = 57;
            this.chConfirmAll.Text = "全部顯示";
            this.chConfirmAll.UseVisualStyleBackColor = true;
            this.chConfirmAll.CheckedChanged += new System.EventHandler(this.chConfirmAll_CheckedChanged);
            // 
            // lstVerifyAccds
            // 
            this.lstVerifyAccds.ColumnWidth = 50;
            this.lstVerifyAccds.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lstVerifyAccds.FormattingEnabled = true;
            this.lstVerifyAccds.ItemHeight = 24;
            this.lstVerifyAccds.Items.AddRange(new object[] {
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
            this.lstVerifyAccds.Location = new System.Drawing.Point(6, 42);
            this.lstVerifyAccds.Name = "lstVerifyAccds";
            this.lstVerifyAccds.Size = new System.Drawing.Size(238, 652);
            this.lstVerifyAccds.TabIndex = 56;
            this.lstVerifyAccds.SelectedIndexChanged += new System.EventHandler(this.lstVerifyAccds_SelectedIndexChanged);
            // 
            // lblLstAccIDs
            // 
            this.lblLstAccIDs.AutoSize = true;
            this.lblLstAccIDs.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblLstAccIDs.Location = new System.Drawing.Point(6, 14);
            this.lblLstAccIDs.Name = "lblLstAccIDs";
            this.lblLstAccIDs.Size = new System.Drawing.Size(89, 19);
            this.lblLstAccIDs.TabIndex = 55;
            this.lblLstAccIDs.Text = "審核資訊";
            // 
            // dgControl
            // 
            this.dgControl.AllowUserToOrderColumns = true;
            this.dgControl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgControl.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgControl.Location = new System.Drawing.Point(255, 100);
            this.dgControl.Name = "dgControl";
            this.dgControl.RowTemplate.Height = 24;
            this.dgControl.Size = new System.Drawing.Size(1298, 662);
            this.dgControl.TabIndex = 54;
            this.dgControl.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgControl_CellFormatting);
            // 
            // btnAnalyzeAccs
            // 
            this.btnAnalyzeAccs.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAnalyzeAccs.Location = new System.Drawing.Point(1231, 16);
            this.btnAnalyzeAccs.Name = "btnAnalyzeAccs";
            this.btnAnalyzeAccs.Size = new System.Drawing.Size(165, 67);
            this.btnAnalyzeAccs.TabIndex = 51;
            this.btnAnalyzeAccs.Text = "分析";
            this.btnAnalyzeAccs.UseVisualStyleBackColor = true;
            this.btnAnalyzeAccs.Visible = false;
            this.btnAnalyzeAccs.Click += new System.EventHandler(this.btnAnalyzeAccs_Click);
            // 
            // btnAccExport
            // 
            this.btnAccExport.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAccExport.Location = new System.Drawing.Point(1056, 16);
            this.btnAccExport.Name = "btnAccExport";
            this.btnAccExport.Size = new System.Drawing.Size(165, 67);
            this.btnAccExport.TabIndex = 52;
            this.btnAccExport.Text = "匯出";
            this.btnAccExport.UseVisualStyleBackColor = true;
            this.btnAccExport.Click += new System.EventHandler(this.btnAccExport_Click);
            // 
            // btnConfirmQuery
            // 
            this.btnConfirmQuery.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnConfirmQuery.Location = new System.Drawing.Point(881, 16);
            this.btnConfirmQuery.Name = "btnConfirmQuery";
            this.btnConfirmQuery.Size = new System.Drawing.Size(165, 67);
            this.btnConfirmQuery.TabIndex = 53;
            this.btnConfirmQuery.Text = "查詢";
            this.btnConfirmQuery.UseVisualStyleBackColor = true;
            this.btnConfirmQuery.Click += new System.EventHandler(this.btnConfirmQuery_Click);
            // 
            // btnVerify
            // 
            this.btnVerify.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnVerify.Location = new System.Drawing.Point(531, 17);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(165, 67);
            this.btnVerify.TabIndex = 49;
            this.btnVerify.Text = "確認";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancel.Location = new System.Drawing.Point(706, 17);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(165, 67);
            this.btnCancel.TabIndex = 50;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblTitle01
            // 
            this.lblTitle01.AutoSize = true;
            this.lblTitle01.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTitle01.Location = new System.Drawing.Point(262, 40);
            this.lblTitle01.Name = "lblTitle01";
            this.lblTitle01.Size = new System.Drawing.Size(171, 22);
            this.lblTitle01.TabIndex = 60;
            this.lblTitle01.Text = "                       ";
            // 
            // FrmEntryVerify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1773, 790);
            this.Controls.Add(this.lblTitle01);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lstAccConfirmMsg);
            this.Controls.Add(this.chConfirmAll);
            this.Controls.Add(this.lstVerifyAccds);
            this.Controls.Add(this.lblLstAccIDs);
            this.Controls.Add(this.dgControl);
            this.Controls.Add(this.btnAnalyzeAccs);
            this.Controls.Add(this.btnAccExport);
            this.Controls.Add(this.btnConfirmQuery);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEntryVerify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系統會計科目審查";
            this.Load += new System.EventHandler(this.FrmEntryVerify_Load);
            this.Shown += new System.EventHandler(this.FrmEntryVerify_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox lstAccConfirmMsg;
        private System.Windows.Forms.CheckBox chConfirmAll;
        private System.Windows.Forms.ListBox lstVerifyAccds;
        private System.Windows.Forms.Label lblLstAccIDs;
        private System.Windows.Forms.DataGridView dgControl;
        private System.Windows.Forms.Button btnAnalyzeAccs;
        private System.Windows.Forms.Button btnAccExport;
        private System.Windows.Forms.Button btnConfirmQuery;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTitle01;
    }
}