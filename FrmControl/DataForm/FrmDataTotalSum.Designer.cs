namespace JINSHIN.Finance.AccountSystem.FrmControl.DataForm
{
    partial class FrmDataTotalSum
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
            this.plSearch = new System.Windows.Forms.Panel();
            this.lblmoney = new System.Windows.Forms.Label();
            this.lblttlamt = new System.Windows.Forms.Label();
            this.lbltitle02 = new System.Windows.Forms.Label();
            this.lblYearVal = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblaccAffairs = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.btnMQuery = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblNoData01 = new System.Windows.Forms.Label();
            this.dgData = new System.Windows.Forms.DataGridView();
            this.btnExport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.plSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).BeginInit();
            this.SuspendLayout();
            // 
            // plSearch
            // 
            this.plSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plSearch.Controls.Add(this.label1);
            this.plSearch.Controls.Add(this.txtYear);
            this.plSearch.Controls.Add(this.btnExport);
            this.plSearch.Controls.Add(this.lblmoney);
            this.plSearch.Controls.Add(this.lblttlamt);
            this.plSearch.Controls.Add(this.lbltitle02);
            this.plSearch.Controls.Add(this.lblYearVal);
            this.plSearch.Controls.Add(this.lblYear);
            this.plSearch.Controls.Add(this.lblaccAffairs);
            this.plSearch.Controls.Add(this.txtNo);
            this.plSearch.Controls.Add(this.btnMQuery);
            this.plSearch.Controls.Add(this.txtName);
            this.plSearch.Location = new System.Drawing.Point(35, 12);
            this.plSearch.Name = "plSearch";
            this.plSearch.Size = new System.Drawing.Size(1106, 92);
            this.plSearch.TabIndex = 66;
            // 
            // lblmoney
            // 
            this.lblmoney.AutoSize = true;
            this.lblmoney.Font = new System.Drawing.Font("新細明體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblmoney.ForeColor = System.Drawing.Color.Red;
            this.lblmoney.Location = new System.Drawing.Point(983, 62);
            this.lblmoney.Name = "lblmoney";
            this.lblmoney.Size = new System.Drawing.Size(75, 14);
            this.lblmoney.TabIndex = 58;
            this.lblmoney.Text = "                 ";
            // 
            // lblttlamt
            // 
            this.lblttlamt.AutoSize = true;
            this.lblttlamt.Font = new System.Drawing.Font("新細明體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblttlamt.Location = new System.Drawing.Point(923, 62);
            this.lblttlamt.Name = "lblttlamt";
            this.lblttlamt.Size = new System.Drawing.Size(39, 14);
            this.lblttlamt.TabIndex = 57;
            this.lblttlamt.Text = "數量:";
            // 
            // lbltitle02
            // 
            this.lbltitle02.AutoSize = true;
            this.lbltitle02.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbltitle02.Location = new System.Drawing.Point(455, 20);
            this.lbltitle02.Name = "lbltitle02";
            this.lbltitle02.Size = new System.Drawing.Size(85, 19);
            this.lbltitle02.TabIndex = 52;
            this.lbltitle02.Text = "會計名稱";
            // 
            // lblYearVal
            // 
            this.lblYearVal.AutoSize = true;
            this.lblYearVal.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblYearVal.ForeColor = System.Drawing.Color.Red;
            this.lblYearVal.Location = new System.Drawing.Point(75, 57);
            this.lblYearVal.Name = "lblYearVal";
            this.lblYearVal.Size = new System.Drawing.Size(114, 19);
            this.lblYearVal.TabIndex = 53;
            this.lblYearVal.Text = "                     ";
            this.lblYearVal.Visible = false;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblYear.Location = new System.Drawing.Point(19, 57);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(47, 19);
            this.lblYear.TabIndex = 53;
            this.lblYear.Text = "年度";
            this.lblYear.Visible = false;
            // 
            // lblaccAffairs
            // 
            this.lblaccAffairs.AutoSize = true;
            this.lblaccAffairs.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblaccAffairs.Location = new System.Drawing.Point(220, 20);
            this.lblaccAffairs.Name = "lblaccAffairs";
            this.lblaccAffairs.Size = new System.Drawing.Size(85, 19);
            this.lblaccAffairs.TabIndex = 53;
            this.lblaccAffairs.Text = "會計科目";
            // 
            // txtNo
            // 
            this.txtNo.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtNo.Location = new System.Drawing.Point(310, 17);
            this.txtNo.Multiline = true;
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(103, 26);
            this.txtNo.TabIndex = 11;
            this.txtNo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNo_KeyUp);
            // 
            // btnMQuery
            // 
            this.btnMQuery.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMQuery.Location = new System.Drawing.Point(741, 10);
            this.btnMQuery.Name = "btnMQuery";
            this.btnMQuery.Size = new System.Drawing.Size(148, 41);
            this.btnMQuery.TabIndex = 15;
            this.btnMQuery.Text = "查詢";
            this.btnMQuery.UseVisualStyleBackColor = true;
            this.btnMQuery.Click += new System.EventHandler(this.btnMQuery_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(546, 17);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(103, 26);
            this.txtName.TabIndex = 12;
            this.txtName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyUp);
            // 
            // lblNoData01
            // 
            this.lblNoData01.AutoSize = true;
            this.lblNoData01.BackColor = System.Drawing.Color.Transparent;
            this.lblNoData01.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblNoData01.ForeColor = System.Drawing.Color.Red;
            this.lblNoData01.Location = new System.Drawing.Point(581, 465);
            this.lblNoData01.Name = "lblNoData01";
            this.lblNoData01.Size = new System.Drawing.Size(93, 27);
            this.lblNoData01.TabIndex = 65;
            this.lblNoData01.Text = "無資料";
            this.lblNoData01.Visible = false;
            // 
            // dgData
            // 
            this.dgData.AllowUserToAddRows = false;
            this.dgData.AllowUserToDeleteRows = false;
            this.dgData.AllowUserToResizeColumns = false;
            this.dgData.AllowUserToResizeRows = false;
            this.dgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgData.Location = new System.Drawing.Point(13, 112);
            this.dgData.MultiSelect = false;
            this.dgData.Name = "dgData";
            this.dgData.ReadOnly = true;
            this.dgData.RowTemplate.Height = 24;
            this.dgData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgData.Size = new System.Drawing.Size(1169, 389);
            this.dgData.TabIndex = 64;
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnExport.Location = new System.Drawing.Point(896, 10);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(148, 41);
            this.btnExport.TabIndex = 59;
            this.btnExport.Text = "匯出";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(19, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 61;
            this.label1.Text = "年度";
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtYear.Location = new System.Drawing.Point(73, 17);
            this.txtYear.Multiline = true;
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(103, 26);
            this.txtYear.TabIndex = 60;
            this.txtYear.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtYear_KeyUp);
            // 
            // FrmDataTotalSum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 529);
            this.Controls.Add(this.plSearch);
            this.Controls.Add(this.lblNoData01);
            this.Controls.Add(this.dgData);
            this.Name = "FrmDataTotalSum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "總帳";
            this.Shown += new System.EventHandler(this.FrmDataTotalSum_Shown);
            this.plSearch.ResumeLayout(false);
            this.plSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel plSearch;
        private System.Windows.Forms.Label lblmoney;
        private System.Windows.Forms.Label lblttlamt;
        private System.Windows.Forms.Label lbltitle02;
        private System.Windows.Forms.Label lblYearVal;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblaccAffairs;
        private System.Windows.Forms.TextBox txtNo;
        public System.Windows.Forms.Button btnMQuery;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblNoData01;
        public System.Windows.Forms.DataGridView dgData;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYear;
    }
}