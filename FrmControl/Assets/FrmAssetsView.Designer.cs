namespace JINSHIN.Finance.AccountSystem.FrmControl.Assets
{
    partial class FrmAssetsView
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
            this.dgDetails = new System.Windows.Forms.DataGridView();
            this.dgVerifyAssetsInfo = new System.Windows.Forms.DataGridView();
            this.dgCostItems = new System.Windows.Forms.DataGridView();
            this.pldata = new System.Windows.Forms.Panel();
            this.btnDetailData = new System.Windows.Forms.Button();
            this.btnCloseData = new System.Windows.Forms.Button();
            this.btnVerify = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chOKed = new System.Windows.Forms.CheckBox();
            this.lblTitle01 = new System.Windows.Forms.Label();
            this.lblTitle02 = new System.Windows.Forms.Label();
            this.lblTitle03 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVerifyAssetsInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCostItems)).BeginInit();
            this.pldata.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgDetails
            // 
            this.dgDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetails.Location = new System.Drawing.Point(713, 586);
            this.dgDetails.Name = "dgDetails";
            this.dgDetails.RowHeadersVisible = false;
            this.dgDetails.RowTemplate.Height = 24;
            this.dgDetails.Size = new System.Drawing.Size(732, 446);
            this.dgDetails.TabIndex = 10;
            this.dgDetails.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgDetails_CellFormatting);
            // 
            // dgVerifyAssetsInfo
            // 
            this.dgVerifyAssetsInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVerifyAssetsInfo.Location = new System.Drawing.Point(10, 41);
            this.dgVerifyAssetsInfo.Name = "dgVerifyAssetsInfo";
            this.dgVerifyAssetsInfo.RowTemplate.Height = 24;
            this.dgVerifyAssetsInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgVerifyAssetsInfo.Size = new System.Drawing.Size(1412, 432);
            this.dgVerifyAssetsInfo.TabIndex = 11;
            this.dgVerifyAssetsInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVerifyAssetsInfo_CellClick);
            this.dgVerifyAssetsInfo.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgVerifyAssetsInfo_CellFormatting);
            this.dgVerifyAssetsInfo.SelectionChanged += new System.EventHandler(this.dgVerifyAssetsInfo_SelectionChanged);
            // 
            // dgCostItems
            // 
            this.dgCostItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCostItems.Location = new System.Drawing.Point(10, 586);
            this.dgCostItems.Name = "dgCostItems";
            this.dgCostItems.RowHeadersVisible = false;
            this.dgCostItems.RowTemplate.Height = 24;
            this.dgCostItems.Size = new System.Drawing.Size(693, 446);
            this.dgCostItems.TabIndex = 10;
            this.dgCostItems.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgCostItems_CellFormatting);
            // 
            // pldata
            // 
            this.pldata.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pldata.Controls.Add(this.btnDetailData);
            this.pldata.Controls.Add(this.btnCloseData);
            this.pldata.Location = new System.Drawing.Point(10, 481);
            this.pldata.Name = "pldata";
            this.pldata.Size = new System.Drawing.Size(1435, 55);
            this.pldata.TabIndex = 12;
            // 
            // btnDetailData
            // 
            this.btnDetailData.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDetailData.Location = new System.Drawing.Point(795, 2);
            this.btnDetailData.Name = "btnDetailData";
            this.btnDetailData.Size = new System.Drawing.Size(632, 47);
            this.btnDetailData.TabIndex = 1;
            this.btnDetailData.Text = "顯示總額資料";
            this.btnDetailData.UseVisualStyleBackColor = true;
            this.btnDetailData.Click += new System.EventHandler(this.btnDetailData_Click);
            // 
            // btnCloseData
            // 
            this.btnCloseData.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCloseData.Location = new System.Drawing.Point(60, 2);
            this.btnCloseData.Name = "btnCloseData";
            this.btnCloseData.Size = new System.Drawing.Size(632, 47);
            this.btnCloseData.TabIndex = 1;
            this.btnCloseData.Text = "顯示總額資料";
            this.btnCloseData.UseVisualStyleBackColor = true;
            this.btnCloseData.Click += new System.EventHandler(this.btnCloseData_Click);
            // 
            // btnVerify
            // 
            this.btnVerify.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnVerify.Location = new System.Drawing.Point(1426, 4);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(61, 140);
            this.btnVerify.TabIndex = 13;
            this.btnVerify.Text = "提列完成";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancel.Location = new System.Drawing.Point(1426, 150);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(61, 140);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "再度提列";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chOKed
            // 
            this.chOKed.AutoSize = true;
            this.chOKed.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chOKed.Location = new System.Drawing.Point(1278, 13);
            this.chOKed.Name = "chOKed";
            this.chOKed.Size = new System.Drawing.Size(142, 23);
            this.chOKed.TabIndex = 14;
            this.chOKed.Text = "顯示提列完成";
            this.chOKed.UseVisualStyleBackColor = true;
            this.chOKed.CheckedChanged += new System.EventHandler(this.chOKed_CheckedChanged);
            // 
            // lblTitle01
            // 
            this.lblTitle01.AutoSize = true;
            this.lblTitle01.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTitle01.Location = new System.Drawing.Point(13, 13);
            this.lblTitle01.Name = "lblTitle01";
            this.lblTitle01.Size = new System.Drawing.Size(85, 19);
            this.lblTitle01.TabIndex = 15;
            this.lblTitle01.Text = "資產清單";
            // 
            // lblTitle02
            // 
            this.lblTitle02.AutoSize = true;
            this.lblTitle02.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTitle02.Location = new System.Drawing.Point(13, 553);
            this.lblTitle02.Name = "lblTitle02";
            this.lblTitle02.Size = new System.Drawing.Size(123, 19);
            this.lblTitle02.TabIndex = 16;
            this.lblTitle02.Text = "已提折舊清單";
            // 
            // lblTitle03
            // 
            this.lblTitle03.AutoSize = true;
            this.lblTitle03.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTitle03.Location = new System.Drawing.Point(715, 553);
            this.lblTitle03.Name = "lblTitle03";
            this.lblTitle03.Size = new System.Drawing.Size(123, 19);
            this.lblTitle03.TabIndex = 17;
            this.lblTitle03.Text = "可提折舊清單";
            // 
            // FrmAssetsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1499, 992);
            this.Controls.Add(this.lblTitle03);
            this.Controls.Add(this.lblTitle02);
            this.Controls.Add(this.lblTitle01);
            this.Controls.Add(this.chOKed);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.pldata);
            this.Controls.Add(this.dgCostItems);
            this.Controls.Add(this.dgDetails);
            this.Controls.Add(this.dgVerifyAssetsInfo);
            this.Name = "FrmAssetsView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "資產折舊檢視";
            this.Load += new System.EventHandler(this.FrmAssetsView_Load);
            this.Shown += new System.EventHandler(this.FrmAssetsView_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVerifyAssetsInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCostItems)).EndInit();
            this.pldata.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDetails;
        private System.Windows.Forms.DataGridView dgVerifyAssetsInfo;
        private System.Windows.Forms.DataGridView dgCostItems;
        private System.Windows.Forms.Panel pldata;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chOKed;
        private System.Windows.Forms.Button btnDetailData;
        private System.Windows.Forms.Button btnCloseData;
        private System.Windows.Forms.Label lblTitle01;
        private System.Windows.Forms.Label lblTitle02;
        private System.Windows.Forms.Label lblTitle03;
    }
}