namespace JINSHIN.Finance.AccountSystem.FrmControl.Assets
{
    partial class FrmCostView
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
            this.lbldatayear = new System.Windows.Forms.Label();
            this.Msg = new System.Windows.Forms.ListBox();
            this.dgVerifyAssetsInfo = new System.Windows.Forms.DataGridView();
            this.btnAssetsExport = new System.Windows.Forms.Button();
            this.btnVerifyAssetsData = new System.Windows.Forms.Button();
            this.dgDetails = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCreateData = new System.Windows.Forms.Button();
            this.dgCompare = new System.Windows.Forms.DataGridView();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblDataName = new System.Windows.Forms.Label();
            this.txtDataName = new System.Windows.Forms.TextBox();
            this.dgdiffdata = new System.Windows.Forms.DataGridView();
            this.lbltitle01 = new System.Windows.Forms.Label();
            this.lbltitle02 = new System.Windows.Forms.Label();
            this.lbltitle03 = new System.Windows.Forms.Label();
            this.lbltitle05 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgVerifyAssetsInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetails)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCompare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdiffdata)).BeginInit();
            this.SuspendLayout();
            // 
            // lbldatayear
            // 
            this.lbldatayear.AutoSize = true;
            this.lbldatayear.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbldatayear.Location = new System.Drawing.Point(804, 28);
            this.lbldatayear.Name = "lbldatayear";
            this.lbldatayear.Size = new System.Drawing.Size(47, 19);
            this.lbldatayear.TabIndex = 12;
            this.lbldatayear.Text = "年份";
            // 
            // Msg
            // 
            this.Msg.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Msg.FormattingEnabled = true;
            this.Msg.HorizontalScrollbar = true;
            this.Msg.ItemHeight = 16;
            this.Msg.Location = new System.Drawing.Point(1009, 68);
            this.Msg.Name = "Msg";
            this.Msg.Size = new System.Drawing.Size(372, 100);
            this.Msg.TabIndex = 11;
            // 
            // dgVerifyAssetsInfo
            // 
            this.dgVerifyAssetsInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVerifyAssetsInfo.Location = new System.Drawing.Point(8, 92);
            this.dgVerifyAssetsInfo.Name = "dgVerifyAssetsInfo";
            this.dgVerifyAssetsInfo.RowHeadersVisible = false;
            this.dgVerifyAssetsInfo.RowTemplate.Height = 24;
            this.dgVerifyAssetsInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgVerifyAssetsInfo.Size = new System.Drawing.Size(989, 425);
            this.dgVerifyAssetsInfo.TabIndex = 9;
            this.dgVerifyAssetsInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVerifyAssetsInfo_CellClick);
            this.dgVerifyAssetsInfo.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgVerifyAssetsInfo_CellFormatting);
            // 
            // btnAssetsExport
            // 
            this.btnAssetsExport.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAssetsExport.Location = new System.Drawing.Point(513, 3);
            this.btnAssetsExport.Name = "btnAssetsExport";
            this.btnAssetsExport.Size = new System.Drawing.Size(249, 45);
            this.btnAssetsExport.TabIndex = 7;
            this.btnAssetsExport.Text = "匯出";
            this.btnAssetsExport.UseVisualStyleBackColor = true;
            this.btnAssetsExport.Click += new System.EventHandler(this.btnAssetsExport_Click);
            // 
            // btnVerifyAssetsData
            // 
            this.btnVerifyAssetsData.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnVerifyAssetsData.Location = new System.Drawing.Point(258, 3);
            this.btnVerifyAssetsData.Name = "btnVerifyAssetsData";
            this.btnVerifyAssetsData.Size = new System.Drawing.Size(249, 45);
            this.btnVerifyAssetsData.TabIndex = 8;
            this.btnVerifyAssetsData.Text = "帳目比對";
            this.btnVerifyAssetsData.UseVisualStyleBackColor = true;
            this.btnVerifyAssetsData.Click += new System.EventHandler(this.btnVerifyAssetsData_Click);
            // 
            // dgDetails
            // 
            this.dgDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetails.Location = new System.Drawing.Point(8, 549);
            this.dgDetails.Name = "dgDetails";
            this.dgDetails.RowHeadersVisible = false;
            this.dgDetails.RowTemplate.Height = 24;
            this.dgDetails.Size = new System.Drawing.Size(681, 345);
            this.dgDetails.TabIndex = 9;
            this.dgDetails.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgDetails_CellFormatting);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCreateData);
            this.flowLayoutPanel1.Controls.Add(this.btnVerifyAssetsData);
            this.flowLayoutPanel1.Controls.Add(this.btnAssetsExport);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(5, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(789, 55);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // btnCreateData
            // 
            this.btnCreateData.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCreateData.Location = new System.Drawing.Point(3, 3);
            this.btnCreateData.Name = "btnCreateData";
            this.btnCreateData.Size = new System.Drawing.Size(249, 45);
            this.btnCreateData.TabIndex = 7;
            this.btnCreateData.Text = "產生帳目";
            this.btnCreateData.UseVisualStyleBackColor = true;
            this.btnCreateData.Click += new System.EventHandler(this.btnCreateData_Click);
            // 
            // dgCompare
            // 
            this.dgCompare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCompare.Location = new System.Drawing.Point(700, 549);
            this.dgCompare.Name = "dgCompare";
            this.dgCompare.RowHeadersVisible = false;
            this.dgCompare.RowTemplate.Height = 24;
            this.dgCompare.Size = new System.Drawing.Size(681, 345);
            this.dgCompare.TabIndex = 16;
            this.dgCompare.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgCompare_CellFormatting);
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtYear.Location = new System.Drawing.Point(857, 21);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(143, 30);
            this.txtYear.TabIndex = 17;
            // 
            // lblDataName
            // 
            this.lblDataName.AutoSize = true;
            this.lblDataName.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDataName.Location = new System.Drawing.Point(1013, 28);
            this.lblDataName.Name = "lblDataName";
            this.lblDataName.Size = new System.Drawing.Size(47, 19);
            this.lblDataName.TabIndex = 12;
            this.lblDataName.Text = "名稱";
            // 
            // txtDataName
            // 
            this.txtDataName.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDataName.Location = new System.Drawing.Point(1066, 21);
            this.txtDataName.Name = "txtDataName";
            this.txtDataName.Size = new System.Drawing.Size(143, 30);
            this.txtDataName.TabIndex = 17;
            // 
            // dgdiffdata
            // 
            this.dgdiffdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdiffdata.Location = new System.Drawing.Point(1009, 209);
            this.dgdiffdata.Name = "dgdiffdata";
            this.dgdiffdata.RowHeadersVisible = false;
            this.dgdiffdata.RowTemplate.Height = 24;
            this.dgdiffdata.Size = new System.Drawing.Size(372, 298);
            this.dgdiffdata.TabIndex = 18;
            this.dgdiffdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdiffdata_CellContentClick);
            // 
            // lbltitle01
            // 
            this.lbltitle01.AutoSize = true;
            this.lbltitle01.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbltitle01.Location = new System.Drawing.Point(11, 67);
            this.lbltitle01.Name = "lbltitle01";
            this.lbltitle01.Size = new System.Drawing.Size(85, 19);
            this.lbltitle01.TabIndex = 19;
            this.lbltitle01.Text = "財產清單";
            // 
            // lbltitle02
            // 
            this.lbltitle02.AutoSize = true;
            this.lbltitle02.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbltitle02.Location = new System.Drawing.Point(1011, 183);
            this.lbltitle02.Name = "lbltitle02";
            this.lbltitle02.Size = new System.Drawing.Size(180, 19);
            this.lbltitle02.TabIndex = 19;
            this.lbltitle02.Text = "無需提列折舊的資產";
            // 
            // lbltitle03
            // 
            this.lbltitle03.AutoSize = true;
            this.lbltitle03.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbltitle03.Location = new System.Drawing.Point(9, 524);
            this.lbltitle03.Name = "lbltitle03";
            this.lbltitle03.Size = new System.Drawing.Size(161, 19);
            this.lbltitle03.TabIndex = 19;
            this.lbltitle03.Text = "計算提列折舊清單";
            // 
            // lbltitle05
            // 
            this.lbltitle05.AutoSize = true;
            this.lbltitle05.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbltitle05.Location = new System.Drawing.Point(699, 524);
            this.lbltitle05.Name = "lbltitle05";
            this.lbltitle05.Size = new System.Drawing.Size(161, 19);
            this.lbltitle05.TabIndex = 19;
            this.lbltitle05.Text = "尚需提列折舊清單";
            // 
            // FrmCostView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1395, 903);
            this.Controls.Add(this.lbltitle05);
            this.Controls.Add(this.lbltitle03);
            this.Controls.Add(this.lbltitle02);
            this.Controls.Add(this.lbltitle01);
            this.Controls.Add(this.dgdiffdata);
            this.Controls.Add(this.txtDataName);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.dgCompare);
            this.Controls.Add(this.lblDataName);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lbldatayear);
            this.Controls.Add(this.Msg);
            this.Controls.Add(this.dgDetails);
            this.Controls.Add(this.dgVerifyAssetsInfo);
            this.Name = "FrmCostView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "資產提列折舊資訊";
            this.Load += new System.EventHandler(this.FrmCostView_Load);
            this.Shown += new System.EventHandler(this.FrmCostView_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgVerifyAssetsInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetails)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCompare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdiffdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbldatayear;
        private System.Windows.Forms.ListBox Msg;
        private System.Windows.Forms.DataGridView dgVerifyAssetsInfo;
        private System.Windows.Forms.Button btnAssetsExport;
        private System.Windows.Forms.Button btnVerifyAssetsData;
        private System.Windows.Forms.DataGridView dgDetails;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCreateData;
        private System.Windows.Forms.DataGridView dgCompare;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblDataName;
        private System.Windows.Forms.TextBox txtDataName;
        private System.Windows.Forms.DataGridView dgdiffdata;
        private System.Windows.Forms.Label lbltitle01;
        private System.Windows.Forms.Label lbltitle02;
        private System.Windows.Forms.Label lbltitle03;
        private System.Windows.Forms.Label lbltitle05;
    }
}