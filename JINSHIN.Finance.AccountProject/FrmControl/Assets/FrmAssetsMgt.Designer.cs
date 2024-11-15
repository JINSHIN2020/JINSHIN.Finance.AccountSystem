namespace JINSHIN.Finance.AccountSystem.FrmControl.Assets
{
    partial class FrmAssetsMgt
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
            this.dgData = new System.Windows.Forms.DataGridView();
            this.lblCnt = new System.Windows.Forms.Label();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.picShape = new System.Windows.Forms.PictureBox();
            this.plContent = new System.Windows.Forms.Panel();
            this.chclear = new System.Windows.Forms.CheckBox();
            this.chClearAll = new System.Windows.Forms.CheckBox();
            this.chadd = new System.Windows.Forms.CheckBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.dgDetails = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.txtItems = new System.Windows.Forms.TextBox();
            this.txtClassNo = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblTitle01 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShape)).BeginInit();
            this.plContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetails)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgData
            // 
            this.dgData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgData.Location = new System.Drawing.Point(6, 96);
            this.dgData.Name = "dgData";
            this.dgData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgData.RowTemplate.Height = 24;
            this.dgData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgData.Size = new System.Drawing.Size(1698, 478);
            this.dgData.TabIndex = 16;
            this.dgData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgData_CellClick);
            // 
            // lblCnt
            // 
            this.lblCnt.AutoSize = true;
            this.lblCnt.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCnt.Location = new System.Drawing.Point(724, 41);
            this.lblCnt.Name = "lblCnt";
            this.lblCnt.Size = new System.Drawing.Size(49, 19);
            this.lblCnt.TabIndex = 15;
            this.lblCnt.Text = "個數";
            // 
            // btnQuery
            // 
            this.btnQuery.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnQuery.Location = new System.Drawing.Point(576, 19);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(125, 62);
            this.btnQuery.TabIndex = 14;
            this.btnQuery.Text = "查詢";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnExport.Location = new System.Drawing.Point(308, 19);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(125, 62);
            this.btnExport.TabIndex = 12;
            this.btnExport.Text = "匯出";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnGenerate.Location = new System.Drawing.Point(442, 19);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(125, 62);
            this.btnGenerate.TabIndex = 13;
            this.btnGenerate.Text = "產生";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // picShape
            // 
            this.picShape.Location = new System.Drawing.Point(707, 19);
            this.picShape.Name = "picShape";
            this.picShape.Size = new System.Drawing.Size(85, 62);
            this.picShape.TabIndex = 17;
            this.picShape.TabStop = false;
            // 
            // plContent
            // 
            this.plContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plContent.Controls.Add(this.chclear);
            this.plContent.Controls.Add(this.chClearAll);
            this.plContent.Controls.Add(this.chadd);
            this.plContent.Controls.Add(this.lblYear);
            this.plContent.Controls.Add(this.txtYear);
            this.plContent.Location = new System.Drawing.Point(804, 23);
            this.plContent.Name = "plContent";
            this.plContent.Size = new System.Drawing.Size(510, 54);
            this.plContent.TabIndex = 18;
            // 
            // chclear
            // 
            this.chclear.AutoSize = true;
            this.chclear.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chclear.Location = new System.Drawing.Point(193, 18);
            this.chclear.Name = "chclear";
            this.chclear.Size = new System.Drawing.Size(66, 23);
            this.chclear.TabIndex = 16;
            this.chclear.Text = "清除";
            this.chclear.UseVisualStyleBackColor = true;
            // 
            // chClearAll
            // 
            this.chClearAll.AutoSize = true;
            this.chClearAll.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chClearAll.Location = new System.Drawing.Point(265, 18);
            this.chClearAll.Name = "chClearAll";
            this.chClearAll.Size = new System.Drawing.Size(85, 23);
            this.chClearAll.TabIndex = 16;
            this.chClearAll.Text = "全清除";
            this.chClearAll.UseVisualStyleBackColor = true;
            // 
            // chadd
            // 
            this.chadd.AutoSize = true;
            this.chadd.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chadd.Location = new System.Drawing.Point(356, 18);
            this.chadd.Name = "chadd";
            this.chadd.Size = new System.Drawing.Size(104, 23);
            this.chadd.TabIndex = 16;
            this.chadd.Text = "增加帳目";
            this.chadd.UseVisualStyleBackColor = true;
            this.chadd.Visible = false;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblYear.Location = new System.Drawing.Point(11, 17);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(47, 19);
            this.lblYear.TabIndex = 12;
            this.lblYear.Text = "年度";
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtYear.Location = new System.Drawing.Point(65, 12);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(117, 30);
            this.txtYear.TabIndex = 13;
            // 
            // dgDetails
            // 
            this.dgDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgDetails.Location = new System.Drawing.Point(5, 653);
            this.dgDetails.Name = "dgDetails";
            this.dgDetails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgDetails.RowTemplate.Height = 24;
            this.dgDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDetails.Size = new System.Drawing.Size(1698, 246);
            this.dgDetails.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblClass);
            this.panel1.Controls.Add(this.txtItems);
            this.panel1.Controls.Add(this.txtClassNo);
            this.panel1.Location = new System.Drawing.Point(525, 586);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 54);
            this.panel1.TabIndex = 19;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd.Location = new System.Drawing.Point(388, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 41);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(194, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "項目";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblClass.Location = new System.Drawing.Point(11, 17);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(47, 19);
            this.lblClass.TabIndex = 12;
            this.lblClass.Text = "分類";
            // 
            // txtItems
            // 
            this.txtItems.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtItems.Location = new System.Drawing.Point(253, 10);
            this.txtItems.Name = "txtItems";
            this.txtItems.Size = new System.Drawing.Size(117, 30);
            this.txtItems.TabIndex = 13;
            // 
            // txtClassNo
            // 
            this.txtClassNo.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtClassNo.Location = new System.Drawing.Point(70, 10);
            this.txtClassNo.Name = "txtClassNo";
            this.txtClassNo.Size = new System.Drawing.Size(117, 30);
            this.txtClassNo.TabIndex = 13;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelete.Location = new System.Drawing.Point(167, 19);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(125, 62);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "刪除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblTitle01
            // 
            this.lblTitle01.AutoSize = true;
            this.lblTitle01.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTitle01.Location = new System.Drawing.Point(379, 603);
            this.lblTitle01.Name = "lblTitle01";
            this.lblTitle01.Size = new System.Drawing.Size(129, 19);
            this.lblTitle01.TabIndex = 20;
            this.lblTitle01.Text = "匯入資料管理";
            // 
            // FrmAssetsMgt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1710, 915);
            this.Controls.Add(this.lblTitle01);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.plContent);
            this.Controls.Add(this.dgDetails);
            this.Controls.Add(this.dgData);
            this.Controls.Add(this.lblCnt);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.picShape);
            this.Name = "FrmAssetsMgt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "資材管理";
            this.Load += new System.EventHandler(this.FrmAssetsMgt_Load);
            this.Shown += new System.EventHandler(this.chAll_Shown);
            this.SizeChanged += new System.EventHandler(this.FrmAssetsMgt_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShape)).EndInit();
            this.plContent.ResumeLayout(false);
            this.plContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetails)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgData;
        private System.Windows.Forms.Label lblCnt;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.PictureBox picShape;
        private System.Windows.Forms.Panel plContent;
        private System.Windows.Forms.CheckBox chclear;
        private System.Windows.Forms.CheckBox chadd;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.CheckBox chClearAll;
        private System.Windows.Forms.DataGridView dgDetails;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.TextBox txtClassNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItems;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblTitle01;
    }
}