using JINSHIN.BUSINESS.LIBARY.UIControls;

namespace FinanceAccountProgram
{
    partial class frmLogin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
			this.txUserName = new System.Windows.Forms.TextBox();
			this.txPwd = new System.Windows.Forms.TextBox();
			this.lblLoginName = new System.Windows.Forms.Label();
			this.lblLoginPwd = new System.Windows.Forms.Label();
			this.btnLogin = new System.Windows.Forms.Button();
			this.timerLogin = new System.Windows.Forms.Timer(this.components);
			this.ckVoice = new System.Windows.Forms.CheckBox();
			this.btnReg = new System.Windows.Forms.Button();
			this.picloginmsg = new System.Windows.Forms.PictureBox();
			this.btnInvoice = new System.Windows.Forms.Button();
			this.btnBuy = new System.Windows.Forms.Button();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.button1 = new System.Windows.Forms.Button();
			this.lblidno = new System.Windows.Forms.Label();
			this.txtIdno = new System.Windows.Forms.TextBox();
			this.progressBar1 = new JINSHIN.BUSINESS.LIBARY.UIControls.ProcessbarControl();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.picloginmsg)).BeginInit();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txUserName
			// 
			this.txUserName.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txUserName.Location = new System.Drawing.Point(331, 19);
			this.txUserName.Name = "txUserName";
			this.txUserName.Size = new System.Drawing.Size(262, 39);
			this.txUserName.TabIndex = 0;
			this.txUserName.TextChanged += new System.EventHandler(this.txUserName_TextChanged);
			this.txUserName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txUserName_KeyUp);
			// 
			// txPwd
			// 
			this.txPwd.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txPwd.Location = new System.Drawing.Point(331, 75);
			this.txPwd.Name = "txPwd";
			this.txPwd.PasswordChar = '*';
			this.txPwd.Size = new System.Drawing.Size(262, 39);
			this.txPwd.TabIndex = 1;
			this.txPwd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txPwd_KeyUp);
			// 
			// lblLoginName
			// 
			this.lblLoginName.AutoSize = true;
			this.lblLoginName.BackColor = System.Drawing.Color.Transparent;
			this.lblLoginName.Font = new System.Drawing.Font("新細明體", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblLoginName.ForeColor = System.Drawing.Color.White;
			this.lblLoginName.Location = new System.Drawing.Point(102, 19);
			this.lblLoginName.Name = "lblLoginName";
			this.lblLoginName.Size = new System.Drawing.Size(222, 40);
			this.lblLoginName.TabIndex = 1;
			this.lblLoginName.Text = "使用者名稱";
			// 
			// lblLoginPwd
			// 
			this.lblLoginPwd.AutoSize = true;
			this.lblLoginPwd.BackColor = System.Drawing.Color.Transparent;
			this.lblLoginPwd.Font = new System.Drawing.Font("新細明體", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblLoginPwd.ForeColor = System.Drawing.Color.White;
			this.lblLoginPwd.Location = new System.Drawing.Point(102, 75);
			this.lblLoginPwd.Name = "lblLoginPwd";
			this.lblLoginPwd.Size = new System.Drawing.Size(222, 40);
			this.lblLoginPwd.TabIndex = 1;
			this.lblLoginPwd.Text = "使用者密碼";
			this.lblLoginPwd.Click += new System.EventHandler(this.lblLoginPwd_Click);
			// 
			// btnLogin
			// 
			this.btnLogin.Font = new System.Drawing.Font("新細明體", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnLogin.Location = new System.Drawing.Point(109, 191);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(493, 59);
			this.btnLogin.TabIndex = 2;
			this.btnLogin.Text = "登入";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// timerLogin
			// 
			this.timerLogin.Interval = 700;
			this.timerLogin.Tick += new System.EventHandler(this.timerLogin_Tick);
			// 
			// ckVoice
			// 
			this.ckVoice.AutoSize = true;
			this.ckVoice.BackColor = System.Drawing.Color.Transparent;
			this.ckVoice.Font = new System.Drawing.Font("新細明體", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.ckVoice.Location = new System.Drawing.Point(258, 390);
			this.ckVoice.Name = "ckVoice";
			this.ckVoice.Size = new System.Drawing.Size(196, 44);
			this.ckVoice.TabIndex = 3;
			this.ckVoice.Text = "產生語音";
			this.ckVoice.UseVisualStyleBackColor = false;
			// 
			// btnReg
			// 
			this.btnReg.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnReg.Location = new System.Drawing.Point(3, 133);
			this.btnReg.Name = "btnReg";
			this.btnReg.Size = new System.Drawing.Size(187, 59);
			this.btnReg.TabIndex = 2;
			this.btnReg.Text = "公司註冊";
			this.btnReg.UseVisualStyleBackColor = true;
			this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
			this.btnReg.ChangeUICues += new System.Windows.Forms.UICuesEventHandler(this.btnReg_ChangeUICues);
			// 
			// picloginmsg
			// 
			this.picloginmsg.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.picloginmsg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.picloginmsg.Location = new System.Drawing.Point(266, 259);
			this.picloginmsg.Name = "picloginmsg";
			this.picloginmsg.Size = new System.Drawing.Size(166, 48);
			this.picloginmsg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picloginmsg.TabIndex = 87;
			this.picloginmsg.TabStop = false;
			this.picloginmsg.Visible = false;
			// 
			// btnInvoice
			// 
			this.btnInvoice.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnInvoice.Location = new System.Drawing.Point(3, 68);
			this.btnInvoice.Name = "btnInvoice";
			this.btnInvoice.Size = new System.Drawing.Size(187, 59);
			this.btnInvoice.TabIndex = 88;
			this.btnInvoice.Text = "發票掃描器";
			this.btnInvoice.UseVisualStyleBackColor = true;
			this.btnInvoice.Click += new System.EventHandler(this.btnInvoiceScan_Click);
			// 
			// btnBuy
			// 
			this.btnBuy.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnBuy.Location = new System.Drawing.Point(3, 3);
			this.btnBuy.Name = "btnBuy";
			this.btnBuy.Size = new System.Drawing.Size(187, 59);
			this.btnBuy.TabIndex = 2;
			this.btnBuy.Text = "註冊&採購";
			this.btnBuy.UseVisualStyleBackColor = true;
			this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
			this.flowLayoutPanel1.Controls.Add(this.btnBuy);
			this.flowLayoutPanel1.Controls.Add(this.btnInvoice);
			this.flowLayoutPanel1.Controls.Add(this.btnReg);
			this.flowLayoutPanel1.Controls.Add(this.button1);
			this.flowLayoutPanel1.Controls.Add(this.button2);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(701, 0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(192, 375);
			this.flowLayoutPanel1.TabIndex = 89;
			this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.button1.Location = new System.Drawing.Point(3, 198);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(187, 59);
			this.button1.TabIndex = 89;
			this.button1.Text = "修改序號";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Visible = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// lblidno
			// 
			this.lblidno.AutoSize = true;
			this.lblidno.BackColor = System.Drawing.Color.Transparent;
			this.lblidno.Font = new System.Drawing.Font("新細明體", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblidno.ForeColor = System.Drawing.Color.White;
			this.lblidno.Location = new System.Drawing.Point(102, 132);
			this.lblidno.Name = "lblidno";
			this.lblidno.Size = new System.Drawing.Size(181, 40);
			this.lblidno.TabIndex = 90;
			this.lblidno.Text = "統一編號";
			// 
			// txtIdno
			// 
			this.txtIdno.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtIdno.Location = new System.Drawing.Point(331, 132);
			this.txtIdno.Name = "txtIdno";
			this.txtIdno.Size = new System.Drawing.Size(262, 39);
			this.txtIdno.TabIndex = 91;
			this.txtIdno.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtIdno_KeyUp);
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(176, 313);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(509, 30);
			this.progressBar1.TabIndex = 4;
			this.progressBar1.Visible = false;
			this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.button2.Location = new System.Drawing.Point(3, 263);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(187, 59);
			this.button2.TabIndex = 89;
			this.button2.Text = "登錄序號";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Visible = false;
			this.button2.Click += new System.EventHandler(this.button1_Click);
			// 
			// frmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(893, 375);
			this.Controls.Add(this.lblidno);
			this.Controls.Add(this.txtIdno);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.picloginmsg);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.ckVoice);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.lblLoginPwd);
			this.Controls.Add(this.lblLoginName);
			this.Controls.Add(this.txPwd);
			this.Controls.Add(this.txUserName);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "frmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "金心使用者登入";
			this.Load += new System.EventHandler(this.frmLogin_Load);
			this.Shown += new System.EventHandler(this.frmLogin_Shown);
			((System.ComponentModel.ISupportInitialize)(this.picloginmsg)).EndInit();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txUserName;
        private System.Windows.Forms.TextBox txPwd;
        private System.Windows.Forms.Label lblLoginName;
        private System.Windows.Forms.Label lblLoginPwd;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Timer timerLogin;
        private System.Windows.Forms.CheckBox ckVoice;
        private System.Windows.Forms.Button btnReg;
        public ProcessbarControl progressBar1;
        private System.Windows.Forms.PictureBox picloginmsg;
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblidno;
        private System.Windows.Forms.TextBox txtIdno;
        private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
	}
}