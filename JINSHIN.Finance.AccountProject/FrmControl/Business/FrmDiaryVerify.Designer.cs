namespace FinanceAccountProgram.FrmControl
{
    partial class FrmDiaryVerify
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
            this.lblBookLend = new System.Windows.Forms.Label();
            this.lblBookTitleGet = new System.Windows.Forms.Label();
            this.lblBookGet = new System.Windows.Forms.Label();
            this.lblBookTitleLend = new System.Windows.Forms.Label();
            this.chQueryAcc = new System.Windows.Forms.CheckBox();
            this.lblQueryAccYear = new System.Windows.Forms.Label();
            this.dgQueryData = new System.Windows.Forms.DataGridView();
            this.btnDiaryExport = new System.Windows.Forms.Button();
            this.btnDiaryCreate = new System.Windows.Forms.Button();
            this.btnDeleteQueryAcc = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.txQueryAccYear = new System.Windows.Forms.TextBox();
            this.txQueryAccMonth = new System.Windows.Forms.TextBox();
            this.lblQueryAccMonth = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgQueryData)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBookLend
            // 
            this.lblBookLend.AutoSize = true;
            this.lblBookLend.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblBookLend.Location = new System.Drawing.Point(1248, 95);
            this.lblBookLend.Name = "lblBookLend";
            this.lblBookLend.Size = new System.Drawing.Size(111, 19);
            this.lblBookLend.TabIndex = 44;
            this.lblBookLend.Text = "                 ";
            // 
            // lblBookTitleGet
            // 
            this.lblBookTitleGet.AutoSize = true;
            this.lblBookTitleGet.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblBookTitleGet.Location = new System.Drawing.Point(1204, 61);
            this.lblBookTitleGet.Name = "lblBookTitleGet";
            this.lblBookTitleGet.Size = new System.Drawing.Size(49, 19);
            this.lblBookTitleGet.TabIndex = 45;
            this.lblBookTitleGet.Text = "借：";
            // 
            // lblBookGet
            // 
            this.lblBookGet.AutoSize = true;
            this.lblBookGet.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblBookGet.Location = new System.Drawing.Point(1248, 61);
            this.lblBookGet.Name = "lblBookGet";
            this.lblBookGet.Size = new System.Drawing.Size(87, 19);
            this.lblBookGet.TabIndex = 46;
            this.lblBookGet.Text = "             ";
            // 
            // lblBookTitleLend
            // 
            this.lblBookTitleLend.AutoSize = true;
            this.lblBookTitleLend.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblBookTitleLend.Location = new System.Drawing.Point(1204, 95);
            this.lblBookTitleLend.Name = "lblBookTitleLend";
            this.lblBookTitleLend.Size = new System.Drawing.Size(49, 19);
            this.lblBookTitleLend.TabIndex = 47;
            this.lblBookTitleLend.Text = "貸：";
            // 
            // chQueryAcc
            // 
            this.chQueryAcc.AutoSize = true;
            this.chQueryAcc.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chQueryAcc.Location = new System.Drawing.Point(1031, 56);
            this.chQueryAcc.Name = "chQueryAcc";
            this.chQueryAcc.Size = new System.Drawing.Size(104, 23);
            this.chQueryAcc.TabIndex = 43;
            this.chQueryAcc.Text = "強制清除";
            this.chQueryAcc.UseVisualStyleBackColor = true;
            this.chQueryAcc.Visible = false;
            // 
            // lblQueryAccYear
            // 
            this.lblQueryAccYear.AutoSize = true;
            this.lblQueryAccYear.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblQueryAccYear.Location = new System.Drawing.Point(8, 28);
            this.lblQueryAccYear.Name = "lblQueryAccYear";
            this.lblQueryAccYear.Size = new System.Drawing.Size(49, 19);
            this.lblQueryAccYear.TabIndex = 42;
            this.lblQueryAccYear.Text = "年份";
            // 
            // dgQueryData
            // 
            this.dgQueryData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgQueryData.Location = new System.Drawing.Point(12, 84);
            this.dgQueryData.Name = "dgQueryData";
            this.dgQueryData.RowTemplate.Height = 24;
            this.dgQueryData.Size = new System.Drawing.Size(1186, 710);
            this.dgQueryData.TabIndex = 41;
            // 
            // btnDiaryExport
            // 
            this.btnDiaryExport.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDiaryExport.Location = new System.Drawing.Point(887, 11);
            this.btnDiaryExport.Name = "btnDiaryExport";
            this.btnDiaryExport.Size = new System.Drawing.Size(132, 59);
            this.btnDiaryExport.TabIndex = 37;
            this.btnDiaryExport.Text = "匯出";
            this.btnDiaryExport.UseVisualStyleBackColor = true;
            this.btnDiaryExport.Click += new System.EventHandler(this.btnDiaryExport_Click);
            // 
            // btnDiaryCreate
            // 
            this.btnDiaryCreate.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDiaryCreate.Location = new System.Drawing.Point(739, 11);
            this.btnDiaryCreate.Name = "btnDiaryCreate";
            this.btnDiaryCreate.Size = new System.Drawing.Size(132, 59);
            this.btnDiaryCreate.TabIndex = 38;
            this.btnDiaryCreate.Text = "帳務建立";
            this.btnDiaryCreate.UseVisualStyleBackColor = true;
            this.btnDiaryCreate.Click += new System.EventHandler(this.btnDiaryCreate_Click);
            // 
            // btnDeleteQueryAcc
            // 
            this.btnDeleteQueryAcc.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDeleteQueryAcc.Location = new System.Drawing.Point(585, 11);
            this.btnDeleteQueryAcc.Name = "btnDeleteQueryAcc";
            this.btnDeleteQueryAcc.Size = new System.Drawing.Size(138, 59);
            this.btnDeleteQueryAcc.TabIndex = 39;
            this.btnDeleteQueryAcc.Text = "刪除";
            this.btnDeleteQueryAcc.UseVisualStyleBackColor = true;
            this.btnDeleteQueryAcc.Click += new System.EventHandler(this.btnDeleteQueryAcc_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnQuery.Location = new System.Drawing.Point(422, 11);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(148, 59);
            this.btnQuery.TabIndex = 40;
            this.btnQuery.Text = "查詢";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // txQueryAccYear
            // 
            this.txQueryAccYear.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txQueryAccYear.Location = new System.Drawing.Point(63, 25);
            this.txQueryAccYear.Name = "txQueryAccYear";
            this.txQueryAccYear.Size = new System.Drawing.Size(142, 30);
            this.txQueryAccYear.TabIndex = 35;
            // 
            // txQueryAccMonth
            // 
            this.txQueryAccMonth.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txQueryAccMonth.Location = new System.Drawing.Point(266, 25);
            this.txQueryAccMonth.Name = "txQueryAccMonth";
            this.txQueryAccMonth.Size = new System.Drawing.Size(142, 30);
            this.txQueryAccMonth.TabIndex = 36;
            // 
            // lblQueryAccMonth
            // 
            this.lblQueryAccMonth.AutoSize = true;
            this.lblQueryAccMonth.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblQueryAccMonth.Location = new System.Drawing.Point(211, 28);
            this.lblQueryAccMonth.Name = "lblQueryAccMonth";
            this.lblQueryAccMonth.Size = new System.Drawing.Size(49, 19);
            this.lblQueryAccMonth.TabIndex = 34;
            this.lblQueryAccMonth.Text = "月份";
            // 
            // FrmDiaryVerify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1503, 815);
            this.Controls.Add(this.lblBookLend);
            this.Controls.Add(this.lblBookTitleGet);
            this.Controls.Add(this.lblBookGet);
            this.Controls.Add(this.lblBookTitleLend);
            this.Controls.Add(this.chQueryAcc);
            this.Controls.Add(this.lblQueryAccYear);
            this.Controls.Add(this.dgQueryData);
            this.Controls.Add(this.btnDiaryExport);
            this.Controls.Add(this.btnDiaryCreate);
            this.Controls.Add(this.btnDeleteQueryAcc);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.txQueryAccYear);
            this.Controls.Add(this.txQueryAccMonth);
            this.Controls.Add(this.lblQueryAccMonth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDiaryVerify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "帳冊審查";
            this.Load += new System.EventHandler(this.FrmDiaryVerify_Load);
            this.Shown += new System.EventHandler(this.FrmDiaryVerify_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgQueryData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBookLend;
        private System.Windows.Forms.Label lblBookTitleGet;
        private System.Windows.Forms.Label lblBookGet;
        private System.Windows.Forms.Label lblBookTitleLend;
        private System.Windows.Forms.CheckBox chQueryAcc;
        private System.Windows.Forms.Label lblQueryAccYear;
        private System.Windows.Forms.DataGridView dgQueryData;
        private System.Windows.Forms.Button btnDiaryExport;
        private System.Windows.Forms.Button btnDiaryCreate;
        private System.Windows.Forms.Button btnDeleteQueryAcc;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TextBox txQueryAccYear;
        private System.Windows.Forms.TextBox txQueryAccMonth;
        private System.Windows.Forms.Label lblQueryAccMonth;
    }
}