namespace FinanceAccountProgram.Controls
{
    partial class usrAccForm
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
            this.dgQueryData = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.txQueryType = new System.Windows.Forms.ComboBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.txQueryAcc = new System.Windows.Forms.TextBox();
            this.lblQueryAcc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgQueryData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgQueryData
            // 
            this.dgQueryData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgQueryData.Location = new System.Drawing.Point(19, 79);
            this.dgQueryData.Name = "dgQueryData";
            this.dgQueryData.RowTemplate.Height = 24;
            this.dgQueryData.Size = new System.Drawing.Size(1277, 600);
            this.dgQueryData.TabIndex = 27;
            this.dgQueryData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgQueryData_CellContentClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(270, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 19);
            this.label8.TabIndex = 26;
            this.label8.Text = "種類";
            // 
            // txQueryType
            // 
            this.txQueryType.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txQueryType.FormattingEnabled = true;
            this.txQueryType.Items.AddRange(new object[] {
            "全部",
            "薪資",
            "辦公租金",
            "業務支出",
            "勞健保",
            "Office365",
            "營業地租金",
            "yes123人力銀行",
            "廣告費網站",
            "電話費",
            "有線電話"});
            this.txQueryType.Location = new System.Drawing.Point(326, 21);
            this.txQueryType.Name = "txQueryType";
            this.txQueryType.Size = new System.Drawing.Size(121, 27);
            this.txQueryType.TabIndex = 25;
            // 
            // btnQuery
            // 
            this.btnQuery.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnQuery.Location = new System.Drawing.Point(475, 1);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(85, 64);
            this.btnQuery.TabIndex = 24;
            this.btnQuery.Text = "查詢";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // txQueryAcc
            // 
            this.txQueryAcc.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txQueryAcc.Location = new System.Drawing.Point(110, 21);
            this.txQueryAcc.Name = "txQueryAcc";
            this.txQueryAcc.Size = new System.Drawing.Size(142, 30);
            this.txQueryAcc.TabIndex = 23;
            // 
            // lblQueryAcc
            // 
            this.lblQueryAcc.AutoSize = true;
            this.lblQueryAcc.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblQueryAcc.Location = new System.Drawing.Point(15, 24);
            this.lblQueryAcc.Name = "lblQueryAcc";
            this.lblQueryAcc.Size = new System.Drawing.Size(85, 19);
            this.lblQueryAcc.TabIndex = 22;
            this.lblQueryAcc.Text = "會計科目";
            // 
            // usrAccForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgQueryData);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txQueryType);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.txQueryAcc);
            this.Controls.Add(this.lblQueryAcc);
            this.Name = "usrAccForm";
            this.Size = new System.Drawing.Size(1310, 680);
            this.Load += new System.EventHandler(this.usrAccForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgQueryData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgQueryData;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox txQueryType;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TextBox txQueryAcc;
        private System.Windows.Forms.Label lblQueryAcc;
    }
}
