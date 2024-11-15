namespace JINSHIN.Finance.AccountSystem.FrmControl.Invoice
{
    partial class FrmInvoiceMgt
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInvoiceMgt));
            this.opendlg = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.攝影機反轉ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.檢視攝影機ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblIDNO = new System.Windows.Forms.Label();
            this.lblSign = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lblDateStr = new System.Windows.Forms.Label();
            this.videoplayers = new AForge.Controls.VideoSourcePlayer();
            this.lab01 = new System.Windows.Forms.Label();
            this.lab02 = new System.Windows.Forms.Label();
            this.btnOhterCost = new System.Windows.Forms.Button();
            this.btnOffice = new System.Windows.Forms.Button();
            this.btnOilCost = new System.Windows.Forms.Button();
            this.btnMasterial = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lab03 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new AForge.Controls.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.txtParams = new System.Windows.Forms.TextBox();
            this.picData = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.txtarea = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbldata = new System.Windows.Forms.Label();
            this.lblCnt = new System.Windows.Forms.Label();
            this.MediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.lstMsg = new System.Windows.Forms.ListBox();
            this.btnUP = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtps = new System.Windows.Forms.TextBox();
            this.comModes = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 650;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // 攝影機反轉ToolStripMenuItem
            // 
            this.攝影機反轉ToolStripMenuItem.Name = "攝影機反轉ToolStripMenuItem";
            this.攝影機反轉ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.攝影機反轉ToolStripMenuItem.Text = "攝影機反轉";
            this.攝影機反轉ToolStripMenuItem.Click += new System.EventHandler(this.攝影機反轉ToolStripMenuItem_Click);
            // 
            // 檢視攝影機ToolStripMenuItem
            // 
            this.檢視攝影機ToolStripMenuItem.Name = "檢視攝影機ToolStripMenuItem";
            this.檢視攝影機ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.檢視攝影機ToolStripMenuItem.Text = "檢視攝影機";
            this.檢視攝影機ToolStripMenuItem.Click += new System.EventHandler(this.檢視攝影機ToolStripMenuItem_Click);
            // 
            // 設定ToolStripMenuItem
            // 
            this.設定ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.檢視攝影機ToolStripMenuItem,
            this.攝影機反轉ToolStripMenuItem});
            this.設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
            this.設定ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.設定ToolStripMenuItem.Text = "設定";
            // 
            // lblIDNO
            // 
            this.lblIDNO.AutoSize = true;
            this.lblIDNO.Font = new System.Drawing.Font("新細明體", 55F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblIDNO.Location = new System.Drawing.Point(-33, 112);
            this.lblIDNO.Name = "lblIDNO";
            this.lblIDNO.Size = new System.Drawing.Size(0, 74);
            this.lblIDNO.TabIndex = 37;
            // 
            // lblSign
            // 
            this.lblSign.AutoSize = true;
            this.lblSign.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSign.Location = new System.Drawing.Point(15, 40);
            this.lblSign.Name = "lblSign";
            this.lblSign.Size = new System.Drawing.Size(222, 27);
            this.lblSign.TabIndex = 30;
            this.lblSign.Text = "xxxxxxxxxxxxxxx";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.設定ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1633, 24);
            this.menuStrip1.TabIndex = 32;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // lblDateStr
            // 
            this.lblDateStr.AutoSize = true;
            this.lblDateStr.Font = new System.Drawing.Font("新細明體", 55F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDateStr.Location = new System.Drawing.Point(-33, 5);
            this.lblDateStr.Name = "lblDateStr";
            this.lblDateStr.Size = new System.Drawing.Size(0, 74);
            this.lblDateStr.TabIndex = 31;
            // 
            // videoplayers
            // 
            this.videoplayers.Location = new System.Drawing.Point(1018, 40);
            this.videoplayers.Name = "videoplayers";
            this.videoplayers.Size = new System.Drawing.Size(589, 332);
            this.videoplayers.TabIndex = 42;
            this.videoplayers.Text = "videoSourcePlayer1";
            this.videoplayers.VideoSource = null;
            // 
            // lab01
            // 
            this.lab01.AutoSize = true;
            this.lab01.Font = new System.Drawing.Font("新細明體", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab01.Location = new System.Drawing.Point(532, 626);
            this.lab01.Name = "lab01";
            this.lab01.Size = new System.Drawing.Size(334, 43);
            this.lab01.TabIndex = 54;
            this.lab01.Text = "xxxxxxxxxxxxxxx";
            // 
            // lab02
            // 
            this.lab02.AutoSize = true;
            this.lab02.Font = new System.Drawing.Font("新細明體", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab02.Location = new System.Drawing.Point(532, 669);
            this.lab02.Name = "lab02";
            this.lab02.Size = new System.Drawing.Size(334, 43);
            this.lab02.TabIndex = 55;
            this.lab02.Text = "xxxxxxxxxxxxxxx";
            this.lab02.Click += new System.EventHandler(this.lab02_Click);
            // 
            // btnOhterCost
            // 
            this.btnOhterCost.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOhterCost.Location = new System.Drawing.Point(848, 470);
            this.btnOhterCost.Name = "btnOhterCost";
            this.btnOhterCost.Size = new System.Drawing.Size(169, 65);
            this.btnOhterCost.TabIndex = 56;
            this.btnOhterCost.Text = "雜費";
            this.btnOhterCost.UseVisualStyleBackColor = true;
            this.btnOhterCost.Click += new System.EventHandler(this.btnOhterCost_Click);
            // 
            // btnOffice
            // 
            this.btnOffice.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOffice.Location = new System.Drawing.Point(1033, 470);
            this.btnOffice.Name = "btnOffice";
            this.btnOffice.Size = new System.Drawing.Size(146, 65);
            this.btnOffice.TabIndex = 61;
            this.btnOffice.Text = "Office365";
            this.btnOffice.UseVisualStyleBackColor = true;
            this.btnOffice.Click += new System.EventHandler(this.btnOffice_Click);
            // 
            // btnOilCost
            // 
            this.btnOilCost.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOilCost.Location = new System.Drawing.Point(848, 543);
            this.btnOilCost.Name = "btnOilCost";
            this.btnOilCost.Size = new System.Drawing.Size(169, 63);
            this.btnOilCost.TabIndex = 62;
            this.btnOilCost.Text = "油資";
            this.btnOilCost.UseVisualStyleBackColor = true;
            this.btnOilCost.Click += new System.EventHandler(this.btnOilCost_Click);
            // 
            // btnMasterial
            // 
            this.btnMasterial.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMasterial.Location = new System.Drawing.Point(1033, 543);
            this.btnMasterial.Name = "btnMasterial";
            this.btnMasterial.Size = new System.Drawing.Size(147, 63);
            this.btnMasterial.TabIndex = 63;
            this.btnMasterial.Text = "產品材料";
            this.btnMasterial.UseVisualStyleBackColor = true;
            this.btnMasterial.Click += new System.EventHandler(this.btnMasterial_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSave.Location = new System.Drawing.Point(661, 470);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(169, 65);
            this.btnSave.TabIndex = 64;
            this.btnSave.Text = "儲存檔案";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(540, 470);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 65;
            this.textBox1.Text = "200";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(540, 500);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 66;
            this.textBox2.Text = "11";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(540, 530);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 67;
            this.textBox3.Text = "11";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lab03
            // 
            this.lab03.AutoSize = true;
            this.lab03.Font = new System.Drawing.Font("新細明體", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab03.Location = new System.Drawing.Point(532, 712);
            this.lab03.Name = "lab03";
            this.lab03.Size = new System.Drawing.Size(334, 43);
            this.lab03.TabIndex = 68;
            this.lab03.Text = "xxxxxxxxxxxxxxx";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(12, 80);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(334, 436);
            this.listBox1.TabIndex = 69;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = null;
            this.pictureBox1.Location = new System.Drawing.Point(376, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(625, 221);
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(376, 276);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(625, 179);
            this.pictureBox2.TabIndex = 71;
            this.pictureBox2.TabStop = false;
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAnalyze.Location = new System.Drawing.Point(661, 543);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(169, 65);
            this.btnAnalyze.TabIndex = 72;
            this.btnAnalyze.Text = "分析";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // txtParams
            // 
            this.txtParams.Location = new System.Drawing.Point(376, 470);
            this.txtParams.Name = "txtParams";
            this.txtParams.Size = new System.Drawing.Size(100, 22);
            this.txtParams.TabIndex = 73;
            this.txtParams.Text = "10";
            // 
            // picData
            // 
            this.picData.Location = new System.Drawing.Point(1018, 389);
            this.picData.Name = "picData";
            this.picData.Size = new System.Drawing.Size(589, 66);
            this.picData.TabIndex = 74;
            this.picData.TabStop = false;
            this.picData.Click += new System.EventHandler(this.picData_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 350;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // txtarea
            // 
            this.txtarea.Location = new System.Drawing.Point(361, 585);
            this.txtarea.Name = "txtarea";
            this.txtarea.Size = new System.Drawing.Size(100, 22);
            this.txtarea.TabIndex = 75;
            this.txtarea.Text = "111";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 607);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 12);
            this.label1.TabIndex = 76;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 589);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 77;
            this.label2.Text = "區域";
            // 
            // lbldata
            // 
            this.lbldata.AutoSize = true;
            this.lbldata.Location = new System.Drawing.Point(320, 626);
            this.lbldata.Name = "lbldata";
            this.lbldata.Size = new System.Drawing.Size(29, 12);
            this.lbldata.TabIndex = 78;
            this.lbldata.Text = "數量";
            // 
            // lblCnt
            // 
            this.lblCnt.AutoSize = true;
            this.lblCnt.Location = new System.Drawing.Point(361, 625);
            this.lblCnt.Name = "lblCnt";
            this.lblCnt.Size = new System.Drawing.Size(33, 12);
            this.lblCnt.TabIndex = 79;
            this.lblCnt.Text = "label3";
            // 
            // MediaPlayer
            // 
            this.MediaPlayer.Enabled = true;
            this.MediaPlayer.Location = new System.Drawing.Point(20, 712);
            this.MediaPlayer.Name = "MediaPlayer";
            this.MediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MediaPlayer.OcxState")));
            this.MediaPlayer.Size = new System.Drawing.Size(133, 82);
            this.MediaPlayer.TabIndex = 60;
            this.MediaPlayer.Visible = false;
            // 
            // lstMsg
            // 
            this.lstMsg.FormattingEnabled = true;
            this.lstMsg.ItemHeight = 12;
            this.lstMsg.Location = new System.Drawing.Point(1198, 470);
            this.lstMsg.Name = "lstMsg";
            this.lstMsg.Size = new System.Drawing.Size(409, 328);
            this.lstMsg.TabIndex = 80;
            // 
            // btnUP
            // 
            this.btnUP.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUP.Location = new System.Drawing.Point(873, 626);
            this.btnUP.Name = "btnUP";
            this.btnUP.Size = new System.Drawing.Size(144, 70);
            this.btnUP.TabIndex = 81;
            this.btnUP.Text = "儲存";
            this.btnUP.UseVisualStyleBackColor = true;
            this.btnUP.Click += new System.EventHandler(this.btnUP_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 552);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 82;
            this.label3.Text = "點數";
            // 
            // txtps
            // 
            this.txtps.Location = new System.Drawing.Point(361, 547);
            this.txtps.Name = "txtps";
            this.txtps.Size = new System.Drawing.Size(100, 22);
            this.txtps.TabIndex = 83;
            this.txtps.Text = "300";
            // 
            // comModes
            // 
            this.comModes.FormattingEnabled = true;
            this.comModes.Items.AddRange(new object[] {
            "list",
            "tree",
            "comp",
            "extern"});
            this.comModes.Location = new System.Drawing.Point(12, 531);
            this.comModes.Name = "comModes";
            this.comModes.Size = new System.Drawing.Size(121, 20);
            this.comModes.TabIndex = 84;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(12, 570);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 20);
            this.comboBox2.TabIndex = 85;
            // 
            // FrmInvoiceMgt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1633, 818);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comModes);
            this.Controls.Add(this.txtps);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnUP);
            this.Controls.Add(this.lstMsg);
            this.Controls.Add(this.lblCnt);
            this.Controls.Add(this.lbldata);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtarea);
            this.Controls.Add(this.picData);
            this.Controls.Add(this.txtParams);
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lab03);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnMasterial);
            this.Controls.Add(this.btnOilCost);
            this.Controls.Add(this.btnOffice);
            this.Controls.Add(this.MediaPlayer);
            this.Controls.Add(this.btnOhterCost);
            this.Controls.Add(this.lab02);
            this.Controls.Add(this.lab01);
            this.Controls.Add(this.videoplayers);
            this.Controls.Add(this.lblIDNO);
            this.Controls.Add(this.lblSign);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblDateStr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmInvoiceMgt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "發票掃描";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmInvoiceMgt_FormClosed);
            this.Load += new System.EventHandler(this.FrmInvoiceMgt_Load);
            this.Shown += new System.EventHandler(this.FrmInvoiceMgt_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog opendlg;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem 攝影機反轉ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 檢視攝影機ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 設定ToolStripMenuItem;
        private System.Windows.Forms.Label lblIDNO;
        private System.Windows.Forms.Label lblSign;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lblDateStr;
        private AForge.Controls.VideoSourcePlayer videoplayers;
        private System.Windows.Forms.Label lab01;
        private System.Windows.Forms.Label lab02;
        private System.Windows.Forms.Button btnOhterCost;
        private AxWMPLib.AxWindowsMediaPlayer MediaPlayer;
        private System.Windows.Forms.Button btnOffice;
        private System.Windows.Forms.Button btnOilCost;
        private System.Windows.Forms.Button btnMasterial;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lab03;
        private System.Windows.Forms.ListBox listBox1;
        private AForge.Controls.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.TextBox txtParams;
        private System.Windows.Forms.PictureBox picData;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.TextBox txtarea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbldata;
        private System.Windows.Forms.Label lblCnt;
        private System.Windows.Forms.ListBox lstMsg;
        private System.Windows.Forms.Button btnUP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtps;
        private System.Windows.Forms.ComboBox comModes;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}