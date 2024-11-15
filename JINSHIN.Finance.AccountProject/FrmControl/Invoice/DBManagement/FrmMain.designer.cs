namespace JINSHIN.Finance.AccountSystem.FrmControl.Invoice.DBManagement
{
    partial class FrmMain
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

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.picdata = new System.Windows.Forms.PictureBox();
            this.lstData = new System.Windows.Forms.ListBox();
            this.txtpath = new System.Windows.Forms.TextBox();
            this.btnData = new System.Windows.Forms.Button();
            this.lbltitle = new System.Windows.Forms.Label();
            this.lblMsgData = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.filedlg = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl01 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl02 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl03 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl05 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtfilename = new System.Windows.Forms.TextBox();
            this.btnPDFToJPG = new System.Windows.Forms.Button();
            this.lbl001 = new System.Windows.Forms.Label();
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.gb001 = new System.Windows.Forms.GroupBox();
            this.btnadjust = new System.Windows.Forms.Button();
            this.gb002 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picdata)).BeginInit();
            this.gb001.SuspendLayout();
            this.gb002.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picdata
            // 
            this.picdata.Image = ((System.Drawing.Image)(resources.GetObject("picdata.Image")));
            this.picdata.Location = new System.Drawing.Point(12, 8);
            this.picdata.Name = "picdata";
            this.picdata.Size = new System.Drawing.Size(1266, 600);
            this.picdata.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picdata.TabIndex = 0;
            this.picdata.TabStop = false;
            this.picdata.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picdata_MouseDown);
            this.picdata.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picdata_MouseMove);
            this.picdata.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picdata_MouseUp);
            // 
            // lstData
            // 
            this.lstData.FormattingEnabled = true;
            this.lstData.HorizontalScrollbar = true;
            this.lstData.ItemHeight = 12;
            this.lstData.Location = new System.Drawing.Point(1293, 8);
            this.lstData.Name = "lstData";
            this.lstData.Size = new System.Drawing.Size(468, 568);
            this.lstData.TabIndex = 1;
            this.lstData.SelectedIndexChanged += new System.EventHandler(this.lstData_SelectedIndexChanged);
            // 
            // txtpath
            // 
            this.txtpath.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtpath.Location = new System.Drawing.Point(19, 22);
            this.txtpath.Name = "txtpath";
            this.txtpath.Size = new System.Drawing.Size(237, 27);
            this.txtpath.TabIndex = 2;
            // 
            // btnData
            // 
            this.btnData.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnData.Location = new System.Drawing.Point(262, 15);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(78, 36);
            this.btnData.TabIndex = 3;
            this.btnData.Text = "選擇";
            this.btnData.UseVisualStyleBackColor = true;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbltitle.Location = new System.Drawing.Point(19, 62);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(43, 16);
            this.lbltitle.TabIndex = 4;
            this.lbltitle.Text = "訊息:";
            // 
            // lblMsgData
            // 
            this.lblMsgData.AutoSize = true;
            this.lblMsgData.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMsgData.Location = new System.Drawing.Point(75, 62);
            this.lblMsgData.Name = "lblMsgData";
            this.lblMsgData.Size = new System.Drawing.Size(27, 16);
            this.lblMsgData.TabIndex = 5;
            this.lblMsgData.Text = "     ";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(190, 57);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 49);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "儲存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(19, 56);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(155, 51);
            this.btnLoad.TabIndex = 7;
            this.btnLoad.Text = "載入來源";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // filedlg
            // 
            this.filedlg.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(17, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "圖片寬";
            // 
            // lbl01
            // 
            this.lbl01.AutoSize = true;
            this.lbl01.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl01.Location = new System.Drawing.Point(80, 99);
            this.lbl01.Name = "lbl01";
            this.lbl01.Size = new System.Drawing.Size(53, 19);
            this.lbl01.TabIndex = 9;
            this.lbl01.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(154, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "圖片高";
            // 
            // lbl02
            // 
            this.lbl02.AutoSize = true;
            this.lbl02.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl02.Location = new System.Drawing.Point(224, 99);
            this.lbl02.Name = "lbl02";
            this.lbl02.Size = new System.Drawing.Size(53, 19);
            this.lbl02.TabIndex = 11;
            this.lbl02.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(17, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "影像寬";
            // 
            // lbl03
            // 
            this.lbl03.AutoSize = true;
            this.lbl03.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl03.Location = new System.Drawing.Point(107, 146);
            this.lbl03.Name = "lbl03";
            this.lbl03.Size = new System.Drawing.Size(49, 19);
            this.lbl03.TabIndex = 9;
            this.lbl03.Text = "        ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(181, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "影像高";
            // 
            // lbl05
            // 
            this.lbl05.AutoSize = true;
            this.lbl05.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl05.Location = new System.Drawing.Point(253, 146);
            this.lbl05.Name = "lbl05";
            this.lbl05.Size = new System.Drawing.Size(44, 19);
            this.lbl05.TabIndex = 11;
            this.lbl05.Text = "       ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(17, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "檔案名稱 ";
            // 
            // txtfilename
            // 
            this.txtfilename.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtfilename.Location = new System.Drawing.Point(115, 17);
            this.txtfilename.Name = "txtfilename";
            this.txtfilename.Size = new System.Drawing.Size(205, 30);
            this.txtfilename.TabIndex = 13;
            // 
            // btnPDFToJPG
            // 
            this.btnPDFToJPG.Location = new System.Drawing.Point(352, 57);
            this.btnPDFToJPG.Margin = new System.Windows.Forms.Padding(2);
            this.btnPDFToJPG.Name = "btnPDFToJPG";
            this.btnPDFToJPG.Size = new System.Drawing.Size(135, 49);
            this.btnPDFToJPG.TabIndex = 14;
            this.btnPDFToJPG.Text = "PDFToJPG";
            this.btnPDFToJPG.UseVisualStyleBackColor = true;
            this.btnPDFToJPG.Click += new System.EventHandler(this.btnPDFToJPG_Click);
            // 
            // lbl001
            // 
            this.lbl001.AutoSize = true;
            this.lbl001.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl001.Location = new System.Drawing.Point(16, 26);
            this.lbl001.Name = "lbl001";
            this.lbl001.Size = new System.Drawing.Size(47, 19);
            this.lbl001.TabIndex = 15;
            this.lbl001.Text = "比例";
            // 
            // txtRadio
            // 
            this.txtRadio.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtRadio.Location = new System.Drawing.Point(88, 21);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(100, 30);
            this.txtRadio.TabIndex = 16;
            this.txtRadio.Text = "100";
            // 
            // gb001
            // 
            this.gb001.Controls.Add(this.btnadjust);
            this.gb001.Controls.Add(this.lbl001);
            this.gb001.Controls.Add(this.txtRadio);
            this.gb001.Location = new System.Drawing.Point(15, 731);
            this.gb001.Name = "gb001";
            this.gb001.Size = new System.Drawing.Size(361, 68);
            this.gb001.TabIndex = 19;
            this.gb001.TabStop = false;
            // 
            // btnadjust
            // 
            this.btnadjust.Location = new System.Drawing.Point(214, 15);
            this.btnadjust.Name = "btnadjust";
            this.btnadjust.Size = new System.Drawing.Size(114, 42);
            this.btnadjust.TabIndex = 19;
            this.btnadjust.Text = "調整";
            this.btnadjust.UseVisualStyleBackColor = true;
            this.btnadjust.Click += new System.EventHandler(this.btnadjust_Click);
            // 
            // gb002
            // 
            this.gb002.Controls.Add(this.btnData);
            this.gb002.Controls.Add(this.txtpath);
            this.gb002.Controls.Add(this.btnPDFToJPG);
            this.gb002.Controls.Add(this.btnSave);
            this.gb002.Controls.Add(this.btnLoad);
            this.gb002.Location = new System.Drawing.Point(757, 729);
            this.gb002.Name = "gb002";
            this.gb002.Size = new System.Drawing.Size(518, 117);
            this.gb002.TabIndex = 20;
            this.gb002.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbltitle);
            this.groupBox1.Controls.Add(this.lblMsgData);
            this.groupBox1.Controls.Add(this.txtfilename);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbl01);
            this.groupBox1.Controls.Add(this.lbl05);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbl02);
            this.groupBox1.Controls.Add(this.lbl03);
            this.groupBox1.Location = new System.Drawing.Point(1293, 584);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 196);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1775, 860);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb002);
            this.Controls.Add(this.gb001);
            this.Controls.Add(this.lstData);
            this.Controls.Add(this.picdata);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "主選單";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Shown += new System.EventHandler(this.FrmMain_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.picdata)).EndInit();
            this.gb001.ResumeLayout(false);
            this.gb001.PerformLayout();
            this.gb002.ResumeLayout(false);
            this.gb002.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picdata;
        private System.Windows.Forms.ListBox lstData;
        private System.Windows.Forms.TextBox txtpath;
        private System.Windows.Forms.Button btnData;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label lblMsgData;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.OpenFileDialog filedlg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl01;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl02;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl03;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl05;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtfilename;
        private System.Windows.Forms.Button btnPDFToJPG;
        private System.Windows.Forms.Label lbl001;
        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.GroupBox gb001;
        private System.Windows.Forms.GroupBox gb002;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnadjust;
    }
}

