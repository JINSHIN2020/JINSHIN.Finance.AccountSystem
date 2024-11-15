namespace CardClick.User
{
    partial class FrmRegUser02
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
            this.rdFemal = new System.Windows.Forms.RadioButton();
            this.rdMan = new System.Windows.Forms.RadioButton();
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.openDig = new System.Windows.Forms.OpenFileDialog();
            this.btnADD = new System.Windows.Forms.Button();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtNickName = new System.Windows.Forms.TextBox();
            this.txtIDName = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblAccount = new System.Windows.Forms.Label();
            this.picphoto = new System.Windows.Forms.PictureBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblName02 = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.lblDeptName = new System.Windows.Forms.Label();
            this.lblJob = new System.Windows.Forms.Label();
            this.comDepts = new System.Windows.Forms.ComboBox();
            this.comJobs = new System.Windows.Forms.ComboBox();
            this.lblCompany = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtUsrEMail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picphoto)).BeginInit();
            this.SuspendLayout();
            // 
            // rdFemal
            // 
            this.rdFemal.AutoSize = true;
            this.rdFemal.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rdFemal.Location = new System.Drawing.Point(14, 40);
            this.rdFemal.Name = "rdFemal";
            this.rdFemal.Size = new System.Drawing.Size(46, 23);
            this.rdFemal.TabIndex = 5;
            this.rdFemal.Text = "女";
            this.rdFemal.UseVisualStyleBackColor = true;
            // 
            // rdMan
            // 
            this.rdMan.AutoSize = true;
            this.rdMan.Checked = true;
            this.rdMan.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rdMan.Location = new System.Drawing.Point(14, 13);
            this.rdMan.Name = "rdMan";
            this.rdMan.Size = new System.Drawing.Size(46, 23);
            this.rdMan.TabIndex = 4;
            this.rdMan.TabStop = true;
            this.rdMan.Text = "男";
            this.rdMan.UseVisualStyleBackColor = true;
            // 
            // gbGender
            // 
            this.gbGender.Controls.Add(this.rdFemal);
            this.gbGender.Controls.Add(this.rdMan);
            this.gbGender.Location = new System.Drawing.Point(242, 55);
            this.gbGender.Name = "gbGender";
            this.gbGender.Size = new System.Drawing.Size(99, 74);
            this.gbGender.TabIndex = 4;
            this.gbGender.TabStop = false;
            // 
            // btnUpload
            // 
            this.btnUpload.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUpload.Location = new System.Drawing.Point(620, 303);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(238, 47);
            this.btnUpload.TabIndex = 17;
            this.btnUpload.Text = "照片上傳";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // openDig
            // 
            this.openDig.FileName = "openFileDialog1";
            // 
            // btnADD
            // 
            this.btnADD.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnADD.Location = new System.Drawing.Point(620, 356);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(238, 49);
            this.btnADD.TabIndex = 18;
            this.btnADD.Text = "新增";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAge.Location = new System.Drawing.Point(433, 63);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 30);
            this.txtAge.TabIndex = 6;
            this.txtAge.Text = "20";
            this.txtAge.Visible = false;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPass.Location = new System.Drawing.Point(242, 156);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(100, 30);
            this.txtPass.TabIndex = 10;
            // 
            // txtusername
            // 
            this.txtusername.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtusername.Location = new System.Drawing.Point(76, 156);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(100, 30);
            this.txtusername.TabIndex = 9;
            // 
            // txtNickName
            // 
            this.txtNickName.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtNickName.Location = new System.Drawing.Point(76, 107);
            this.txtNickName.Name = "txtNickName";
            this.txtNickName.Size = new System.Drawing.Size(100, 30);
            this.txtNickName.TabIndex = 3;
            // 
            // txtIDName
            // 
            this.txtIDName.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtIDName.Location = new System.Drawing.Point(76, 63);
            this.txtIDName.Name = "txtIDName";
            this.txtIDName.Size = new System.Drawing.Size(100, 30);
            this.txtIDName.TabIndex = 2;
            this.txtIDName.TextChanged += new System.EventHandler(this.txtIDName_TextChanged);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPass.Location = new System.Drawing.Point(183, 156);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(54, 22);
            this.lblPass.TabIndex = 39;
            this.lblPass.Text = "密碼";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAge.Location = new System.Drawing.Point(371, 63);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(54, 22);
            this.lblAge.TabIndex = 41;
            this.lblAge.Text = "年紀";
            this.lblAge.Visible = false;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblGender.Location = new System.Drawing.Point(183, 63);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(54, 22);
            this.lblGender.TabIndex = 37;
            this.lblGender.Text = "性別";
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAccount.Location = new System.Drawing.Point(18, 156);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(54, 22);
            this.lblAccount.TabIndex = 34;
            this.lblAccount.Text = "帳號";
            // 
            // picphoto
            // 
            this.picphoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picphoto.ErrorImage = null;
            this.picphoto.ImageLocation = "";
            this.picphoto.Location = new System.Drawing.Point(620, 12);
            this.picphoto.Name = "picphoto";
            this.picphoto.Size = new System.Drawing.Size(238, 285);
            this.picphoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picphoto.TabIndex = 36;
            this.picphoto.TabStop = false;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDescription.Location = new System.Drawing.Point(22, 266);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(576, 311);
            this.txtDescription.TabIndex = 15;
            // 
            // lblName02
            // 
            this.lblName02.AutoSize = true;
            this.lblName02.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblName02.Location = new System.Drawing.Point(18, 107);
            this.lblName02.Name = "lblName02";
            this.lblName02.Size = new System.Drawing.Size(54, 22);
            this.lblName02.TabIndex = 32;
            this.lblName02.Text = "匿稱";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblusername.Location = new System.Drawing.Point(18, 63);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(54, 22);
            this.lblusername.TabIndex = 31;
            this.lblusername.Text = "人名";
            // 
            // lblDeptName
            // 
            this.lblDeptName.AutoSize = true;
            this.lblDeptName.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDeptName.Location = new System.Drawing.Point(371, 107);
            this.lblDeptName.Name = "lblDeptName";
            this.lblDeptName.Size = new System.Drawing.Size(54, 22);
            this.lblDeptName.TabIndex = 39;
            this.lblDeptName.Text = "部門";
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblJob.Location = new System.Drawing.Point(371, 156);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(54, 22);
            this.lblJob.TabIndex = 39;
            this.lblJob.Text = "職別";
            // 
            // comDepts
            // 
            this.comDepts.BackColor = System.Drawing.Color.White;
            this.comDepts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comDepts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comDepts.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comDepts.FormattingEnabled = true;
            this.comDepts.Location = new System.Drawing.Point(433, 105);
            this.comDepts.Name = "comDepts";
            this.comDepts.Size = new System.Drawing.Size(121, 27);
            this.comDepts.TabIndex = 7;
            this.comDepts.DropDown += new System.EventHandler(this.comDepts_DropDown);
            this.comDepts.SelectedIndexChanged += new System.EventHandler(this.comDepts_SelectedIndexChanged);
            // 
            // comJobs
            // 
            this.comJobs.BackColor = System.Drawing.SystemColors.Window;
            this.comJobs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comJobs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comJobs.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comJobs.FormattingEnabled = true;
            this.comJobs.Location = new System.Drawing.Point(433, 154);
            this.comJobs.Name = "comJobs";
            this.comJobs.Size = new System.Drawing.Size(121, 27);
            this.comJobs.TabIndex = 8;
            this.comJobs.SelectedIndexChanged += new System.EventHandler(this.comJobs_SelectedIndexChanged);
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCompany.Location = new System.Drawing.Point(18, 19);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(54, 22);
            this.lblCompany.TabIndex = 31;
            this.lblCompany.Text = "公司";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCompanyName.Location = new System.Drawing.Point(76, 17);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(320, 30);
            this.txtCompanyName.TabIndex = 1;
            this.txtCompanyName.Text = "興承機械工業股份有限公司";
            this.txtCompanyName.Leave += new System.EventHandler(this.txtCompanyName_Leave);
            // 
            // txtUsrEMail
            // 
            this.txtUsrEMail.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtUsrEMail.Location = new System.Drawing.Point(76, 201);
            this.txtUsrEMail.Name = "txtUsrEMail";
            this.txtUsrEMail.Size = new System.Drawing.Size(215, 30);
            this.txtUsrEMail.TabIndex = 11;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblEmail.Location = new System.Drawing.Point(10, 201);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(62, 22);
            this.lblEmail.TabIndex = 73;
            this.lblEmail.Text = "EMail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(304, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 22);
            this.label1.TabIndex = 39;
            this.label1.Text = "手機/電話";
            // 
            // txtUserPhone
            // 
            this.txtUserPhone.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtUserPhone.Location = new System.Drawing.Point(416, 201);
            this.txtUserPhone.Name = "txtUserPhone";
            this.txtUserPhone.Size = new System.Drawing.Size(182, 30);
            this.txtUserPhone.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(418, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 39;
            this.label2.Text = "*電話請加區碼";
            // 
            // FrmRegUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 594);
            this.Controls.Add(this.txtUsrEMail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.comJobs);
            this.Controls.Add(this.comDepts);
            this.Controls.Add(this.gbGender);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.txtUserPhone);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.lblJob);
            this.Controls.Add(this.txtNickName);
            this.Controls.Add(this.lblDeptName);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.txtIDName);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.picphoto);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.lblName02);
            this.Controls.Add(this.lblusername);
            this.Name = "FrmRegUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "人員註冊";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmRegUser_FormClosed);
            this.Load += new System.EventHandler(this.FrmRegUser_Load);
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picphoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdFemal;
        private System.Windows.Forms.RadioButton rdMan;
        private System.Windows.Forms.GroupBox gbGender;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.OpenFileDialog openDig;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtNickName;
        private System.Windows.Forms.TextBox txtIDName;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.PictureBox picphoto;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblName02;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblDeptName;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.ComboBox comDepts;
        private System.Windows.Forms.ComboBox comJobs;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TextBox txtUsrEMail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserPhone;
        private System.Windows.Forms.Label label2;
    }
}