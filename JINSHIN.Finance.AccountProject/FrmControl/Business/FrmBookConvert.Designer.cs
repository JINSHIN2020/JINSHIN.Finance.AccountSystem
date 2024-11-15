namespace FinanceAccountProgram.FrmControl
{
    partial class FrmBookConvert
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
            this.tabBookExport = new System.Windows.Forms.TabControl();
            this.tabAccountExport = new System.Windows.Forms.TabPage();
            this.rboption01 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenrateData = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.Filelst = new System.Windows.Forms.ListBox();
            this.lstMsg = new System.Windows.Forms.ListBox();
            this.lblInvoiceLst = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rboptions02 = new System.Windows.Forms.RadioButton();
            this.Filelst3 = new System.Windows.Forms.ListBox();
            this.Filelst2 = new System.Windows.Forms.ListBox();
            this.gbOPtionFile = new System.Windows.Forms.GroupBox();
            this.radioDB = new System.Windows.Forms.RadioButton();
            this.radioFile = new System.Windows.Forms.RadioButton();
            this.chUpdateDBResource = new System.Windows.Forms.CheckBox();
            this.tabAccountCheck = new System.Windows.Forms.TabPage();
            this.gpViewer = new System.Windows.Forms.GroupBox();
            this.radioBookItem = new System.Windows.Forms.RadioButton();
            this.radioBook = new System.Windows.Forms.RadioButton();
            this.btnBalance = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.lblYearTitle = new System.Windows.Forms.Label();
            this.lblViewStatus = new System.Windows.Forms.Label();
            this.dgTabView = new System.Windows.Forms.DataGridView();
            this.tabBookExport.SuspendLayout();
            this.tabAccountExport.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbOPtionFile.SuspendLayout();
            this.tabAccountCheck.SuspendLayout();
            this.gpViewer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTabView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabBookExport
            // 
            this.tabBookExport.Controls.Add(this.tabAccountExport);
            this.tabBookExport.Controls.Add(this.tabAccountCheck);
            this.tabBookExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabBookExport.Location = new System.Drawing.Point(0, 0);
            this.tabBookExport.Name = "tabBookExport";
            this.tabBookExport.SelectedIndex = 0;
            this.tabBookExport.Size = new System.Drawing.Size(1632, 539);
            this.tabBookExport.TabIndex = 31;
            this.tabBookExport.SelectedIndexChanged += new System.EventHandler(this.tabBookExport_SelectedIndexChanged);
            // 
            // tabAccountExport
            // 
            this.tabAccountExport.Controls.Add(this.rboption01);
            this.tabAccountExport.Controls.Add(this.label2);
            this.tabAccountExport.Controls.Add(this.btnGenrateData);
            this.tabAccountExport.Controls.Add(this.btnRefresh);
            this.tabAccountExport.Controls.Add(this.Filelst);
            this.tabAccountExport.Controls.Add(this.lstMsg);
            this.tabAccountExport.Controls.Add(this.lblInvoiceLst);
            this.tabAccountExport.Controls.Add(this.label1);
            this.tabAccountExport.Controls.Add(this.groupBox1);
            this.tabAccountExport.Controls.Add(this.Filelst3);
            this.tabAccountExport.Controls.Add(this.Filelst2);
            this.tabAccountExport.Controls.Add(this.gbOPtionFile);
            this.tabAccountExport.Controls.Add(this.chUpdateDBResource);
            this.tabAccountExport.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabAccountExport.Location = new System.Drawing.Point(4, 22);
            this.tabAccountExport.Name = "tabAccountExport";
            this.tabAccountExport.Padding = new System.Windows.Forms.Padding(3);
            this.tabAccountExport.Size = new System.Drawing.Size(1624, 513);
            this.tabAccountExport.TabIndex = 0;
            this.tabAccountExport.Text = "帳目匯入";
            this.tabAccountExport.UseVisualStyleBackColor = true;
            this.tabAccountExport.Click += new System.EventHandler(this.tabAccountExport_Click);
            // 
            // rboption01
            // 
            this.rboption01.AutoSize = true;
            this.rboption01.Location = new System.Drawing.Point(-4, 515);
            this.rboption01.Name = "rboption01";
            this.rboption01.Size = new System.Drawing.Size(65, 23);
            this.rboption01.TabIndex = 31;
            this.rboption01.Text = "國稅";
            this.rboption01.UseVisualStyleBackColor = true;
            this.rboption01.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(24, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 38;
            this.label2.Text = "比對資料";
            // 
            // btnGenrateData
            // 
            this.btnGenrateData.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnGenrateData.Location = new System.Drawing.Point(345, 99);
            this.btnGenrateData.Name = "btnGenrateData";
            this.btnGenrateData.Size = new System.Drawing.Size(199, 63);
            this.btnGenrateData.TabIndex = 35;
            this.btnGenrateData.Text = "匯出公司帳冊資料";
            this.btnGenrateData.UseVisualStyleBackColor = true;
            this.btnGenrateData.Click += new System.EventHandler(this.btnGenrateData_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRefresh.Location = new System.Drawing.Point(345, 168);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(199, 62);
            this.btnRefresh.TabIndex = 36;
            this.btnRefresh.Text = "更新檔案列表";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Filelst
            // 
            this.Filelst.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Filelst.FormattingEnabled = true;
            this.Filelst.ItemHeight = 19;
            this.Filelst.Location = new System.Drawing.Point(18, 19);
            this.Filelst.Name = "Filelst";
            this.Filelst.Size = new System.Drawing.Size(302, 346);
            this.Filelst.TabIndex = 34;
            // 
            // lstMsg
            // 
            this.lstMsg.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lstMsg.FormattingEnabled = true;
            this.lstMsg.ItemHeight = 19;
            this.lstMsg.Location = new System.Drawing.Point(1212, 134);
            this.lstMsg.Name = "lstMsg";
            this.lstMsg.Size = new System.Drawing.Size(404, 346);
            this.lstMsg.TabIndex = 42;
            this.lstMsg.SelectedIndexChanged += new System.EventHandler(this.lstMsg_SelectedIndexChanged);
            // 
            // lblInvoiceLst
            // 
            this.lblInvoiceLst.AutoSize = true;
            this.lblInvoiceLst.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblInvoiceLst.Location = new System.Drawing.Point(890, 375);
            this.lblInvoiceLst.Name = "lblInvoiceLst";
            this.lblInvoiceLst.Size = new System.Drawing.Size(123, 19);
            this.lblInvoiceLst.TabIndex = 39;
            this.lblInvoiceLst.Text = "發票原始資料";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(564, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 40;
            this.label1.Text = "原始資料";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rboptions02);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(353, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 59);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "格式";
            // 
            // rboptions02
            // 
            this.rboptions02.AutoSize = true;
            this.rboptions02.Checked = true;
            this.rboptions02.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rboptions02.Location = new System.Drawing.Point(6, 26);
            this.rboptions02.Name = "rboptions02";
            this.rboptions02.Size = new System.Drawing.Size(84, 23);
            this.rboptions02.TabIndex = 5;
            this.rboptions02.TabStop = true;
            this.rboptions02.Text = "公司帳";
            this.rboptions02.UseVisualStyleBackColor = true;
            // 
            // Filelst3
            // 
            this.Filelst3.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Filelst3.FormattingEnabled = true;
            this.Filelst3.ItemHeight = 19;
            this.Filelst3.Location = new System.Drawing.Point(891, 19);
            this.Filelst3.Name = "Filelst3";
            this.Filelst3.Size = new System.Drawing.Size(302, 346);
            this.Filelst3.TabIndex = 32;
            // 
            // Filelst2
            // 
            this.Filelst2.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Filelst2.FormattingEnabled = true;
            this.Filelst2.ItemHeight = 19;
            this.Filelst2.Location = new System.Drawing.Point(567, 19);
            this.Filelst2.Name = "Filelst2";
            this.Filelst2.Size = new System.Drawing.Size(302, 346);
            this.Filelst2.TabIndex = 33;
            this.Filelst2.SelectedIndexChanged += new System.EventHandler(this.Filelst2_SelectedIndexChanged);
            // 
            // gbOPtionFile
            // 
            this.gbOPtionFile.Controls.Add(this.radioDB);
            this.gbOPtionFile.Controls.Add(this.radioFile);
            this.gbOPtionFile.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbOPtionFile.Location = new System.Drawing.Point(1213, 19);
            this.gbOPtionFile.Name = "gbOPtionFile";
            this.gbOPtionFile.Size = new System.Drawing.Size(141, 109);
            this.gbOPtionFile.TabIndex = 41;
            this.gbOPtionFile.TabStop = false;
            this.gbOPtionFile.Text = "匯出格式";
            this.gbOPtionFile.Enter += new System.EventHandler(this.gbOPtionFile_Enter);
            // 
            // radioDB
            // 
            this.radioDB.AutoSize = true;
            this.radioDB.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioDB.Location = new System.Drawing.Point(6, 69);
            this.radioDB.Name = "radioDB";
            this.radioDB.Size = new System.Drawing.Size(84, 23);
            this.radioDB.TabIndex = 5;
            this.radioDB.Text = "資料庫";
            this.radioDB.UseVisualStyleBackColor = true;
            // 
            // radioFile
            // 
            this.radioFile.AutoSize = true;
            this.radioFile.Checked = true;
            this.radioFile.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioFile.Location = new System.Drawing.Point(6, 32);
            this.radioFile.Name = "radioFile";
            this.radioFile.Size = new System.Drawing.Size(103, 23);
            this.radioFile.TabIndex = 4;
            this.radioFile.TabStop = true;
            this.radioFile.Text = "輸出檔案";
            this.radioFile.UseVisualStyleBackColor = true;
            // 
            // chUpdateDBResource
            // 
            this.chUpdateDBResource.AutoSize = true;
            this.chUpdateDBResource.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chUpdateDBResource.Location = new System.Drawing.Point(1360, 101);
            this.chUpdateDBResource.Name = "chUpdateDBResource";
            this.chUpdateDBResource.Size = new System.Drawing.Size(104, 23);
            this.chUpdateDBResource.TabIndex = 43;
            this.chUpdateDBResource.Text = "資料覆蓋";
            this.chUpdateDBResource.UseVisualStyleBackColor = true;
            this.chUpdateDBResource.CheckedChanged += new System.EventHandler(this.chUpdateDBResource_CheckedChanged);
            // 
            // tabAccountCheck
            // 
            this.tabAccountCheck.Controls.Add(this.gpViewer);
            this.tabAccountCheck.Controls.Add(this.btnBalance);
            this.tabAccountCheck.Controls.Add(this.btnView);
            this.tabAccountCheck.Controls.Add(this.lblYearTitle);
            this.tabAccountCheck.Controls.Add(this.lblViewStatus);
            this.tabAccountCheck.Controls.Add(this.dgTabView);
            this.tabAccountCheck.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabAccountCheck.Location = new System.Drawing.Point(4, 22);
            this.tabAccountCheck.Name = "tabAccountCheck";
            this.tabAccountCheck.Padding = new System.Windows.Forms.Padding(3);
            this.tabAccountCheck.Size = new System.Drawing.Size(1624, 513);
            this.tabAccountCheck.TabIndex = 1;
            this.tabAccountCheck.Text = "匯入帳目審查";
            this.tabAccountCheck.UseVisualStyleBackColor = true;
            // 
            // gpViewer
            // 
            this.gpViewer.Controls.Add(this.radioBookItem);
            this.gpViewer.Controls.Add(this.radioBook);
            this.gpViewer.Location = new System.Drawing.Point(185, 8);
            this.gpViewer.Name = "gpViewer";
            this.gpViewer.Size = new System.Drawing.Size(200, 150);
            this.gpViewer.TabIndex = 8;
            this.gpViewer.TabStop = false;
            // 
            // radioBookItem
            // 
            this.radioBookItem.AutoSize = true;
            this.radioBookItem.Location = new System.Drawing.Point(6, 50);
            this.radioBookItem.Name = "radioBookItem";
            this.radioBookItem.Size = new System.Drawing.Size(138, 23);
            this.radioBookItem.TabIndex = 3;
            this.radioBookItem.Text = "BookItemView";
            this.radioBookItem.UseVisualStyleBackColor = true;
            this.radioBookItem.Visible = false;
            // 
            // radioBook
            // 
            this.radioBook.AutoSize = true;
            this.radioBook.Checked = true;
            this.radioBook.Location = new System.Drawing.Point(6, 21);
            this.radioBook.Name = "radioBook";
            this.radioBook.Size = new System.Drawing.Size(103, 23);
            this.radioBook.TabIndex = 3;
            this.radioBook.TabStop = true;
            this.radioBook.Text = "檢視帳務";
            this.radioBook.UseVisualStyleBackColor = true;
            // 
            // btnBalance
            // 
            this.btnBalance.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBalance.Location = new System.Drawing.Point(26, 86);
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.Size = new System.Drawing.Size(141, 52);
            this.btnBalance.TabIndex = 6;
            this.btnBalance.Text = "平衡帳務";
            this.btnBalance.UseVisualStyleBackColor = true;
            this.btnBalance.Click += new System.EventHandler(this.btnBalance_Click);
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnView.Location = new System.Drawing.Point(26, 18);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(141, 52);
            this.btnView.TabIndex = 7;
            this.btnView.Text = "檢視差異帳務";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // lblYearTitle
            // 
            this.lblYearTitle.AutoSize = true;
            this.lblYearTitle.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblYearTitle.Location = new System.Drawing.Point(392, 103);
            this.lblYearTitle.Name = "lblYearTitle";
            this.lblYearTitle.Size = new System.Drawing.Size(89, 19);
            this.lblYearTitle.TabIndex = 9;
            this.lblYearTitle.Text = "年度資料";
            // 
            // lblViewStatus
            // 
            this.lblViewStatus.AutoSize = true;
            this.lblViewStatus.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblViewStatus.Location = new System.Drawing.Point(392, 135);
            this.lblViewStatus.Name = "lblViewStatus";
            this.lblViewStatus.Size = new System.Drawing.Size(55, 19);
            this.lblViewStatus.TabIndex = 9;
            this.lblViewStatus.Text = "描述:";
            // 
            // dgTabView
            // 
            this.dgTabView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgTabView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTabView.Location = new System.Drawing.Point(11, 164);
            this.dgTabView.Name = "dgTabView";
            this.dgTabView.RowTemplate.Height = 24;
            this.dgTabView.Size = new System.Drawing.Size(1242, 529);
            this.dgTabView.TabIndex = 5;
            // 
            // FrmBookConvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1632, 539);
            this.Controls.Add(this.tabBookExport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmBookConvert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "帳目匯入";
            this.Load += new System.EventHandler(this.FrmBookConvert_Load);
            this.Shown += new System.EventHandler(this.FrmBookConvert_Shown);
            this.tabBookExport.ResumeLayout(false);
            this.tabAccountExport.ResumeLayout(false);
            this.tabAccountExport.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbOPtionFile.ResumeLayout(false);
            this.gbOPtionFile.PerformLayout();
            this.tabAccountCheck.ResumeLayout(false);
            this.tabAccountCheck.PerformLayout();
            this.gpViewer.ResumeLayout(false);
            this.gpViewer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTabView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabBookExport;
        private System.Windows.Forms.TabPage tabAccountExport;
        private System.Windows.Forms.RadioButton rboption01;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenrateData;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ListBox Filelst;
        private System.Windows.Forms.ListBox lstMsg;
        private System.Windows.Forms.Label lblInvoiceLst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rboptions02;
        private System.Windows.Forms.ListBox Filelst3;
        private System.Windows.Forms.ListBox Filelst2;
        private System.Windows.Forms.GroupBox gbOPtionFile;
        private System.Windows.Forms.RadioButton radioDB;
        private System.Windows.Forms.RadioButton radioFile;
        private System.Windows.Forms.CheckBox chUpdateDBResource;
        private System.Windows.Forms.TabPage tabAccountCheck;
        private System.Windows.Forms.GroupBox gpViewer;
        private System.Windows.Forms.RadioButton radioBookItem;
        private System.Windows.Forms.RadioButton radioBook;
        private System.Windows.Forms.Button btnBalance;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.DataGridView dgTabView;
        private System.Windows.Forms.Label lblViewStatus;
        private System.Windows.Forms.Label lblYearTitle;
    }
}