namespace FinanceAccountProgram.Controls
{
    partial class AddQueryDataForm
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.dgData = new System.Windows.Forms.DataGridView();
            this.lblCnt = new System.Windows.Forms.Label();
            this.lblClassType = new System.Windows.Forms.Label();
            this.listMaster = new System.Windows.Forms.ListBox();
            this.listContents = new System.Windows.Forms.ListBox();
            this.lblDetails = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuery
            // 
            this.btnQuery.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnQuery.Location = new System.Drawing.Point(1056, 7);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(125, 62);
            this.btnQuery.TabIndex = 5;
            this.btnQuery.Text = "查詢";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnGenerate.Location = new System.Drawing.Point(925, 7);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(125, 62);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "產生";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // dgData
            // 
            this.dgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgData.Location = new System.Drawing.Point(12, 75);
            this.dgData.Name = "dgData";
            this.dgData.RowTemplate.Height = 24;
            this.dgData.Size = new System.Drawing.Size(1227, 617);
            this.dgData.TabIndex = 3;
            // 
            // lblCnt
            // 
            this.lblCnt.AutoSize = true;
            this.lblCnt.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCnt.Location = new System.Drawing.Point(1187, 47);
            this.lblCnt.Name = "lblCnt";
            this.lblCnt.Size = new System.Drawing.Size(49, 19);
            this.lblCnt.TabIndex = 6;
            this.lblCnt.Text = "個數";
            // 
            // lblClassType
            // 
            this.lblClassType.AutoSize = true;
            this.lblClassType.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblClassType.Location = new System.Drawing.Point(1243, 29);
            this.lblClassType.Name = "lblClassType";
            this.lblClassType.Size = new System.Drawing.Size(94, 19);
            this.lblClassType.TabIndex = 8;
            this.lblClassType.Text = "ClassType";
            // 
            // listMaster
            // 
            this.listMaster.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listMaster.FormattingEnabled = true;
            this.listMaster.ItemHeight = 19;
            this.listMaster.Location = new System.Drawing.Point(1245, 52);
            this.listMaster.Name = "listMaster";
            this.listMaster.Size = new System.Drawing.Size(214, 650);
            this.listMaster.TabIndex = 7;
            // 
            // listContents
            // 
            this.listContents.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listContents.FormattingEnabled = true;
            this.listContents.ItemHeight = 19;
            this.listContents.Location = new System.Drawing.Point(1465, 52);
            this.listContents.Name = "listContents";
            this.listContents.Size = new System.Drawing.Size(214, 650);
            this.listContents.TabIndex = 7;
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDetails.Location = new System.Drawing.Point(1463, 29);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(91, 19);
            this.lblDetails.TabIndex = 8;
            this.lblDetails.Text = "DetailList";
            // 
            // AddQueryDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.lblClassType);
            this.Controls.Add(this.listContents);
            this.Controls.Add(this.listMaster);
            this.Controls.Add(this.lblCnt);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.dgData);
            this.Name = "AddQueryDataForm";
            this.Size = new System.Drawing.Size(1720, 739);
            this.Load += new System.EventHandler(this.AddQueryDataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.DataGridView dgData;
        private System.Windows.Forms.Label lblCnt;
        private System.Windows.Forms.Label lblClassType;
        private System.Windows.Forms.ListBox listMaster;
        private System.Windows.Forms.ListBox listContents;
        private System.Windows.Forms.Label lblDetails;
    }
}
