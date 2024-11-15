namespace CardClick.User
{
    partial class UserUpdateFrm02
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
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.rdFemal = new System.Windows.Forms.RadioButton();
            this.rdMan = new System.Windows.Forms.RadioButton();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtAgeVal = new System.Windows.Forms.TextBox();
            this.txtPassVal = new System.Windows.Forms.TextBox();
            this.txtUserNameVal = new System.Windows.Forms.TextBox();
            this.txtNickNameVal = new System.Windows.Forms.TextBox();
            this.txtIDNameVal = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblAccount = new System.Windows.Forms.Label();
            this.picphoto = new System.Windows.Forms.PictureBox();
            this.txtDescriptionVal = new System.Windows.Forms.TextBox();
            this.lblName02 = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.openDig = new System.Windows.Forms.OpenFileDialog();
            this.comJobs = new System.Windows.Forms.ComboBox();
            this.comDepts = new System.Windows.Forms.ComboBox();
            this.lblJob = new System.Windows.Forms.Label();
            this.lblDeptName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtUsrEMailVal = new System.Windows.Forms.TextBox();
            this.gbGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picphoto)).BeginInit();
            this.SuspendLayout();
            // 
            // gbGender
            // 
            this.gbGender.Controls.Add(this.rdFemal);
            this.gbGender.Controls.Add(this.rdMan);
            this.gbGender.Location = new System.Drawing.Point(242, 3);
            this.gbGender.Name = "gbGender";
            this.gbGender.Size = new System.Drawing.Size(99, 74);
            this.gbGender.TabIndex = 77;
            this.gbGender.TabStop = false;
            // 
            // rdFemal
            // 
            this.rdFemal.AutoSize = true;
            this.rdFemal.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rdFemal.Location = new System.Drawing.Point(14, 40);
            this.rdFemal.Name = "rdFemal";
            this.rdFemal.Size = new System.Drawing.Size(46, 23);
            this.rdFemal.TabIndex = 1;
            this.rdFemal.TabStop = true;
            this.rdFemal.Text = "女";
            this.rdFemal.UseVisualStyleBackColor = true;
            // 
            // rdMan
            // 
            this.rdMan.AutoSize = true;
            this.rdMan.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rdMan.Location = new System.Drawing.Point(14, 13);
            this.rdMan.Name = "rdMan";
            this.rdMan.Size = new System.Drawing.Size(46, 23);
            this.rdMan.TabIndex = 0;
            this.rdMan.TabStop = true;
            this.rdMan.Text = "男";
            this.rdMan.UseVisualStyleBackColor = true;
            // 
            // btnUpload
            // 
            this.btnUpload.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUpload.Location = new System.Drawing.Point(667, 294);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(238, 47);
            this.btnUpload.TabIndex = 76;
            this.btnUpload.Text = "照片上傳";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUpdate.Location = new System.Drawing.Point(667, 347);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(238, 107);
            this.btnUpdate.TabIndex = 75;
            this.btnUpdate.Text = "更新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtAgeVal
            // 
            this.txtAgeVal.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAgeVal.Location = new System.Drawing.Point(242, 90);
            this.txtAgeVal.Name = "txtAgeVal";
            this.txtAgeVal.Size = new System.Drawing.Size(100, 30);
            this.txtAgeVal.TabIndex = 73;
            // 
            // txtPassVal
            // 
            this.txtPassVal.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPassVal.Location = new System.Drawing.Point(242, 145);
            this.txtPassVal.Name = "txtPassVal";
            this.txtPassVal.PasswordChar = '*';
            this.txtPassVal.Size = new System.Drawing.Size(100, 30);
            this.txtPassVal.TabIndex = 72;
            // 
            // txtUserNameVal
            // 
            this.txtUserNameVal.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtUserNameVal.Location = new System.Drawing.Point(70, 145);
            this.txtUserNameVal.Name = "txtUserNameVal";
            this.txtUserNameVal.Size = new System.Drawing.Size(100, 30);
            this.txtUserNameVal.TabIndex = 69;
            // 
            // txtNickNameVal
            // 
            this.txtNickNameVal.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtNickNameVal.Location = new System.Drawing.Point(70, 90);
            this.txtNickNameVal.Name = "txtNickNameVal";
            this.txtNickNameVal.Size = new System.Drawing.Size(100, 30);
            this.txtNickNameVal.TabIndex = 74;
            // 
            // txtIDNameVal
            // 
            this.txtIDNameVal.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtIDNameVal.Location = new System.Drawing.Point(70, 11);
            this.txtIDNameVal.Name = "txtIDNameVal";
            this.txtIDNameVal.Size = new System.Drawing.Size(100, 30);
            this.txtIDNameVal.TabIndex = 67;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPass.Location = new System.Drawing.Point(176, 145);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(54, 22);
            this.lblPass.TabIndex = 63;
            this.lblPass.Text = "密碼";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAge.Location = new System.Drawing.Point(176, 95);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(54, 22);
            this.lblAge.TabIndex = 65;
            this.lblAge.Text = "年紀";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblGender.Location = new System.Drawing.Point(176, 16);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(54, 22);
            this.lblGender.TabIndex = 61;
            this.lblGender.Text = "性別";
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAccount.Location = new System.Drawing.Point(12, 145);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(54, 22);
            this.lblAccount.TabIndex = 58;
            this.lblAccount.Text = "帳號";
            // 
            // picphoto
            // 
            this.picphoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picphoto.ErrorImage = null;
            this.picphoto.ImageLocation = "";
            this.picphoto.InitialImage = null;
            this.picphoto.Location = new System.Drawing.Point(666, 3);
            this.picphoto.Name = "picphoto";
            this.picphoto.Size = new System.Drawing.Size(238, 285);
            this.picphoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picphoto.TabIndex = 60;
            this.picphoto.TabStop = false;
            // 
            // txtDescriptionVal
            // 
            this.txtDescriptionVal.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDescriptionVal.Location = new System.Drawing.Point(12, 189);
            this.txtDescriptionVal.Multiline = true;
            this.txtDescriptionVal.Name = "txtDescriptionVal";
            this.txtDescriptionVal.Size = new System.Drawing.Size(632, 235);
            this.txtDescriptionVal.TabIndex = 59;
            // 
            // lblName02
            // 
            this.lblName02.AutoSize = true;
            this.lblName02.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblName02.Location = new System.Drawing.Point(12, 95);
            this.lblName02.Name = "lblName02";
            this.lblName02.Size = new System.Drawing.Size(54, 22);
            this.lblName02.TabIndex = 56;
            this.lblName02.Text = "匿稱";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblusername.Location = new System.Drawing.Point(12, 16);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(54, 22);
            this.lblusername.TabIndex = 55;
            this.lblusername.Text = "人名";
            // 
            // openDig
            // 
            this.openDig.FileName = "openFileDialog1";
            // 
            // comJobs
            // 
            this.comJobs.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comJobs.FormattingEnabled = true;
            this.comJobs.Location = new System.Drawing.Point(429, 61);
            this.comJobs.Name = "comJobs";
            this.comJobs.Size = new System.Drawing.Size(121, 27);
            this.comJobs.TabIndex = 80;
            // 
            // comDepts
            // 
            this.comDepts.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comDepts.FormattingEnabled = true;
            this.comDepts.Location = new System.Drawing.Point(429, 12);
            this.comDepts.Name = "comDepts";
            this.comDepts.Size = new System.Drawing.Size(121, 27);
            this.comDepts.TabIndex = 81;
            this.comDepts.SelectedValueChanged += new System.EventHandler(this.comDepts_SelectedValueChanged);
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblJob.Location = new System.Drawing.Point(363, 61);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(54, 22);
            this.lblJob.TabIndex = 78;
            this.lblJob.Text = "職別";
            // 
            // lblDeptName
            // 
            this.lblDeptName.AutoSize = true;
            this.lblDeptName.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDeptName.Location = new System.Drawing.Point(363, 12);
            this.lblDeptName.Name = "lblDeptName";
            this.lblDeptName.Size = new System.Drawing.Size(54, 22);
            this.lblDeptName.TabIndex = 79;
            this.lblDeptName.Text = "部門";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblEmail.Location = new System.Drawing.Point(363, 145);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(62, 22);
            this.lblEmail.TabIndex = 63;
            this.lblEmail.Text = "EMail";
            // 
            // txtUsrEMailVal
            // 
            this.txtUsrEMailVal.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtUsrEMailVal.Location = new System.Drawing.Point(429, 145);
            this.txtUsrEMailVal.Name = "txtUsrEMailVal";
            this.txtUsrEMailVal.Size = new System.Drawing.Size(215, 30);
            this.txtUsrEMailVal.TabIndex = 72;
            // 
            // UserUpdateFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 474);
            this.Controls.Add(this.comJobs);
            this.Controls.Add(this.comDepts);
            this.Controls.Add(this.lblJob);
            this.Controls.Add(this.lblDeptName);
            this.Controls.Add(this.gbGender);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtAgeVal);
            this.Controls.Add(this.txtUsrEMailVal);
            this.Controls.Add(this.txtPassVal);
            this.Controls.Add(this.txtUserNameVal);
            this.Controls.Add(this.txtNickNameVal);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtIDNameVal);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.picphoto);
            this.Controls.Add(this.txtDescriptionVal);
            this.Controls.Add(this.lblName02);
            this.Controls.Add(this.lblusername);
            this.Name = "UserUpdateFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "更新人員資料";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserUpdateFrm_FormClosed);
            this.Load += new System.EventHandler(this.UserUpdateFrm_Load);
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picphoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGender;
        private System.Windows.Forms.RadioButton rdFemal;
        private System.Windows.Forms.RadioButton rdMan;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtAgeVal;
        private System.Windows.Forms.TextBox txtPassVal;
        private System.Windows.Forms.TextBox txtUserNameVal;
        private System.Windows.Forms.TextBox txtNickNameVal;
        private System.Windows.Forms.TextBox txtIDNameVal;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.PictureBox picphoto;
        private System.Windows.Forms.TextBox txtDescriptionVal;
        private System.Windows.Forms.Label lblName02;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.OpenFileDialog openDig;
        private System.Windows.Forms.ComboBox comJobs;
        private System.Windows.Forms.ComboBox comDepts;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.Label lblDeptName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtUsrEMailVal;
    }
}