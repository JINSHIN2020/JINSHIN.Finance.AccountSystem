namespace CardClick.User
{
    partial class PersonalInfoFrm02
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
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblAgeVal = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.picPhoto = new System.Windows.Forms.PictureBox();
            this.lblName02Val = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblName02 = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.lblIDNameVal = new System.Windows.Forms.Label();
            this.gbGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // gbGender
            // 
            this.gbGender.Controls.Add(this.rdFemal);
            this.gbGender.Controls.Add(this.rdMan);
            this.gbGender.Location = new System.Drawing.Point(235, -4);
            this.gbGender.Name = "gbGender";
            this.gbGender.Size = new System.Drawing.Size(99, 74);
            this.gbGender.TabIndex = 50;
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
            this.rdMan.Text = "男";
            this.rdMan.UseVisualStyleBackColor = true;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDescription.Location = new System.Drawing.Point(3, 133);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(505, 235);
            this.txtDescription.TabIndex = 40;
            // 
            // lblAgeVal
            // 
            this.lblAgeVal.AutoSize = true;
            this.lblAgeVal.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAgeVal.Location = new System.Drawing.Point(236, 90);
            this.lblAgeVal.Name = "lblAgeVal";
            this.lblAgeVal.Size = new System.Drawing.Size(54, 22);
            this.lblAgeVal.TabIndex = 47;
            this.lblAgeVal.Text = "年紀";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAge.Location = new System.Drawing.Point(176, 90);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(54, 22);
            this.lblAge.TabIndex = 48;
            this.lblAge.Text = "年紀";
            // 
            // picPhoto
            // 
            this.picPhoto.Location = new System.Drawing.Point(514, 9);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(257, 285);
            this.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPhoto.TabIndex = 41;
            this.picPhoto.TabStop = false;
            // 
            // lblName02Val
            // 
            this.lblName02Val.AutoSize = true;
            this.lblName02Val.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblName02Val.Location = new System.Drawing.Point(72, 61);
            this.lblName02Val.Name = "lblName02Val";
            this.lblName02Val.Size = new System.Drawing.Size(54, 22);
            this.lblName02Val.TabIndex = 36;
            this.lblName02Val.Text = "匿稱";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblGender.Location = new System.Drawing.Point(176, 10);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(54, 22);
            this.lblGender.TabIndex = 46;
            this.lblGender.Text = "性別";
            // 
            // lblName02
            // 
            this.lblName02.AutoSize = true;
            this.lblName02.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblName02.Location = new System.Drawing.Point(12, 61);
            this.lblName02.Name = "lblName02";
            this.lblName02.Size = new System.Drawing.Size(54, 22);
            this.lblName02.TabIndex = 37;
            this.lblName02.Text = "匿稱";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblusername.Location = new System.Drawing.Point(12, 9);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(54, 22);
            this.lblusername.TabIndex = 39;
            this.lblusername.Text = "人名";
            // 
            // lblIDNameVal
            // 
            this.lblIDNameVal.AutoSize = true;
            this.lblIDNameVal.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblIDNameVal.Location = new System.Drawing.Point(72, 9);
            this.lblIDNameVal.Name = "lblIDNameVal";
            this.lblIDNameVal.Size = new System.Drawing.Size(54, 22);
            this.lblIDNameVal.TabIndex = 34;
            this.lblIDNameVal.Text = "人名";
            // 
            // PersonalInfoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 379);
            this.Controls.Add(this.gbGender);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblAgeVal);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.picPhoto);
            this.Controls.Add(this.lblName02Val);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblName02);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.lblIDNameVal);
            this.Name = "PersonalInfoFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "人員基本資料";
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbGender;
        private System.Windows.Forms.RadioButton rdFemal;
        private System.Windows.Forms.RadioButton rdMan;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblAgeVal;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.PictureBox picPhoto;
        private System.Windows.Forms.Label lblName02Val;
        private System.Windows.Forms.Label lblGender;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblName02;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblIDNameVal;
    }
}