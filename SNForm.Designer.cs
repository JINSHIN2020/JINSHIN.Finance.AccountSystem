
namespace FinanceAccountProgram
{
    partial class SNForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SNForm));
            this.btnBuy = new System.Windows.Forms.Button();
            this.txtRegInfo = new System.Windows.Forms.TextBox();
            this.gxSupply = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblKey = new System.Windows.Forms.Label();
            this.lblIdNo = new System.Windows.Forms.Label();
            this.lblSupEmail = new System.Windows.Forms.Label();
            this.lblSuppPhone = new System.Windows.Forms.Label();
            this.lblSupply = new System.Windows.Forms.Label();
            this.txtSupAddressVal = new System.Windows.Forms.TextBox();
            this.txtIdNoVal = new System.Windows.Forms.TextBox();
            this.txtSupEmailVal = new System.Windows.Forms.TextBox();
            this.txtSupKeyVal = new System.Windows.Forms.TextBox();
            this.txtSuppPhoneVal = new System.Windows.Forms.TextBox();
            this.txtSupplyVal = new System.Windows.Forms.TextBox();
            this.gxUserInfo = new System.Windows.Forms.GroupBox();
            this.lblJobTitle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblReason = new System.Windows.Forms.Label();
            this.lblUserAddress = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserAddressVal = new System.Windows.Forms.TextBox();
            this.lblUserNameVal = new System.Windows.Forms.Label();
            this.txtIDNameVal = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblUserPhone = new System.Windows.Forms.Label();
            this.txtPassVal = new System.Windows.Forms.TextBox();
            this.txtJobTitleVal = new System.Windows.Forms.TextBox();
            this.txtUserNameVal = new System.Windows.Forms.TextBox();
            this.txtUserAdrVal = new System.Windows.Forms.TextBox();
            this.txtUsrEmailVal = new System.Windows.Forms.TextBox();
            this.txtUserPhoneVal = new System.Windows.Forms.TextBox();
            this.cxTheSame = new System.Windows.Forms.CheckBox();
            this.cxAgree = new System.Windows.Forms.CheckBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comRule = new System.Windows.Forms.ComboBox();
            this.gxSupply.SuspendLayout();
            this.gxUserInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuy
            // 
            this.btnBuy.Font = new System.Drawing.Font("新細明體", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBuy.Location = new System.Drawing.Point(104, 549);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(607, 46);
            this.btnBuy.TabIndex = 16;
            this.btnBuy.Text = "註冊";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // txtRegInfo
            // 
            this.txtRegInfo.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtRegInfo.Location = new System.Drawing.Point(13, 606);
            this.txtRegInfo.Multiline = true;
            this.txtRegInfo.Name = "txtRegInfo";
            this.txtRegInfo.Size = new System.Drawing.Size(805, 186);
            this.txtRegInfo.TabIndex = 6;
            this.txtRegInfo.Text = resources.GetString("txtRegInfo.Text");
            this.txtRegInfo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtRegInfo_KeyUp);
            // 
            // gxSupply
            // 
            this.gxSupply.Controls.Add(this.label1);
            this.gxSupply.Controls.Add(this.lblKey);
            this.gxSupply.Controls.Add(this.lblIdNo);
            this.gxSupply.Controls.Add(this.lblSupEmail);
            this.gxSupply.Controls.Add(this.lblSuppPhone);
            this.gxSupply.Controls.Add(this.lblSupply);
            this.gxSupply.Controls.Add(this.txtSupAddressVal);
            this.gxSupply.Controls.Add(this.txtIdNoVal);
            this.gxSupply.Controls.Add(this.txtSupEmailVal);
            this.gxSupply.Controls.Add(this.txtSupKeyVal);
            this.gxSupply.Controls.Add(this.txtSuppPhoneVal);
            this.gxSupply.Controls.Add(this.txtSupplyVal);
            this.gxSupply.Location = new System.Drawing.Point(20, 12);
            this.gxSupply.Name = "gxSupply";
            this.gxSupply.Size = new System.Drawing.Size(663, 248);
            this.gxSupply.TabIndex = 9;
            this.gxSupply.TabStop = false;
            this.gxSupply.Enter += new System.EventHandler(this.gxSupply_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(40, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "地址";
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblKey.Location = new System.Drawing.Point(410, 40);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(47, 19);
            this.lblKey.TabIndex = 13;
            this.lblKey.Text = "鍵值";
            // 
            // lblIdNo
            // 
            this.lblIdNo.AutoSize = true;
            this.lblIdNo.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblIdNo.Location = new System.Drawing.Point(2, 196);
            this.lblIdNo.Name = "lblIdNo";
            this.lblIdNo.Size = new System.Drawing.Size(85, 19);
            this.lblIdNo.TabIndex = 13;
            this.lblIdNo.Text = "統一編號";
            // 
            // lblSupEmail
            // 
            this.lblSupEmail.AutoSize = true;
            this.lblSupEmail.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSupEmail.Location = new System.Drawing.Point(29, 143);
            this.lblSupEmail.Name = "lblSupEmail";
            this.lblSupEmail.Size = new System.Drawing.Size(58, 19);
            this.lblSupEmail.TabIndex = 13;
            this.lblSupEmail.Text = "E-mail";
            // 
            // lblSuppPhone
            // 
            this.lblSuppPhone.AutoSize = true;
            this.lblSuppPhone.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSuppPhone.Location = new System.Drawing.Point(410, 143);
            this.lblSuppPhone.Name = "lblSuppPhone";
            this.lblSuppPhone.Size = new System.Drawing.Size(47, 19);
            this.lblSuppPhone.TabIndex = 13;
            this.lblSuppPhone.Text = "電話";
            // 
            // lblSupply
            // 
            this.lblSupply.AutoSize = true;
            this.lblSupply.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSupply.Location = new System.Drawing.Point(40, 40);
            this.lblSupply.Name = "lblSupply";
            this.lblSupply.Size = new System.Drawing.Size(47, 19);
            this.lblSupply.TabIndex = 14;
            this.lblSupply.Text = "廠商";
            this.lblSupply.Click += new System.EventHandler(this.lblSupply_Click);
            // 
            // txtSupAddressVal
            // 
            this.txtSupAddressVal.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSupAddressVal.Location = new System.Drawing.Point(111, 92);
            this.txtSupAddressVal.Name = "txtSupAddressVal";
            this.txtSupAddressVal.Size = new System.Drawing.Size(474, 30);
            this.txtSupAddressVal.TabIndex = 3;
            // 
            // txtIdNoVal
            // 
            this.txtIdNoVal.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtIdNoVal.Location = new System.Drawing.Point(111, 196);
            this.txtIdNoVal.Name = "txtIdNoVal";
            this.txtIdNoVal.Size = new System.Drawing.Size(230, 30);
            this.txtIdNoVal.TabIndex = 6;
            // 
            // txtSupEmailVal
            // 
            this.txtSupEmailVal.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSupEmailVal.Location = new System.Drawing.Point(111, 143);
            this.txtSupEmailVal.Name = "txtSupEmailVal";
            this.txtSupEmailVal.Size = new System.Drawing.Size(276, 30);
            this.txtSupEmailVal.TabIndex = 4;
            // 
            // txtSupKeyVal
            // 
            this.txtSupKeyVal.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSupKeyVal.Location = new System.Drawing.Point(489, 40);
            this.txtSupKeyVal.Name = "txtSupKeyVal";
            this.txtSupKeyVal.Size = new System.Drawing.Size(153, 30);
            this.txtSupKeyVal.TabIndex = 2;
            // 
            // txtSuppPhoneVal
            // 
            this.txtSuppPhoneVal.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSuppPhoneVal.Location = new System.Drawing.Point(489, 143);
            this.txtSuppPhoneVal.Name = "txtSuppPhoneVal";
            this.txtSuppPhoneVal.Size = new System.Drawing.Size(153, 30);
            this.txtSuppPhoneVal.TabIndex = 5;
            // 
            // txtSupplyVal
            // 
            this.txtSupplyVal.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSupplyVal.Location = new System.Drawing.Point(111, 40);
            this.txtSupplyVal.Name = "txtSupplyVal";
            this.txtSupplyVal.Size = new System.Drawing.Size(253, 30);
            this.txtSupplyVal.TabIndex = 1;
            // 
            // gxUserInfo
            // 
            this.gxUserInfo.Controls.Add(this.comRule);
            this.gxUserInfo.Controls.Add(this.lblJobTitle);
            this.gxUserInfo.Controls.Add(this.label3);
            this.gxUserInfo.Controls.Add(this.lblReason);
            this.gxUserInfo.Controls.Add(this.lblUserAddress);
            this.gxUserInfo.Controls.Add(this.lblUserName);
            this.gxUserInfo.Controls.Add(this.txtUserAddressVal);
            this.gxUserInfo.Controls.Add(this.label2);
            this.gxUserInfo.Controls.Add(this.lblUserNameVal);
            this.gxUserInfo.Controls.Add(this.txtIDNameVal);
            this.gxUserInfo.Controls.Add(this.lblEmail);
            this.gxUserInfo.Controls.Add(this.lblUserPhone);
            this.gxUserInfo.Controls.Add(this.txtPassVal);
            this.gxUserInfo.Controls.Add(this.txtJobTitleVal);
            this.gxUserInfo.Controls.Add(this.txtUserNameVal);
            this.gxUserInfo.Controls.Add(this.txtUserAdrVal);
            this.gxUserInfo.Controls.Add(this.txtUsrEmailVal);
            this.gxUserInfo.Controls.Add(this.txtUserPhoneVal);
            this.gxUserInfo.Location = new System.Drawing.Point(19, 267);
            this.gxUserInfo.Name = "gxUserInfo";
            this.gxUserInfo.Size = new System.Drawing.Size(803, 267);
            this.gxUserInfo.TabIndex = 10;
            this.gxUserInfo.TabStop = false;
            // 
            // lblJobTitle
            // 
            this.lblJobTitle.AutoSize = true;
            this.lblJobTitle.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblJobTitle.Location = new System.Drawing.Point(381, 74);
            this.lblJobTitle.Name = "lblJobTitle";
            this.lblJobTitle.Size = new System.Drawing.Size(47, 19);
            this.lblJobTitle.TabIndex = 17;
            this.lblJobTitle.Text = "職務";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(381, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "密碼";
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblReason.Location = new System.Drawing.Point(343, 121);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(85, 19);
            this.lblReason.TabIndex = 17;
            this.lblReason.Text = "註冊原因";
            // 
            // lblUserAddress
            // 
            this.lblUserAddress.AutoSize = true;
            this.lblUserAddress.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblUserAddress.Location = new System.Drawing.Point(381, 23);
            this.lblUserAddress.Name = "lblUserAddress";
            this.lblUserAddress.Size = new System.Drawing.Size(47, 19);
            this.lblUserAddress.TabIndex = 17;
            this.lblUserAddress.Text = "地址";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblUserName.Location = new System.Drawing.Point(23, 24);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(47, 19);
            this.lblUserName.TabIndex = 18;
            this.lblUserName.Text = "姓名";
            // 
            // txtUserAddressVal
            // 
            this.txtUserAddressVal.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtUserAddressVal.Location = new System.Drawing.Point(444, 23);
            this.txtUserAddressVal.Name = "txtUserAddressVal";
            this.txtUserAddressVal.Size = new System.Drawing.Size(336, 30);
            this.txtUserAddressVal.TabIndex = 8;
            // 
            // lblUserNameVal
            // 
            this.lblUserNameVal.AutoSize = true;
            this.lblUserNameVal.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblUserNameVal.Location = new System.Drawing.Point(23, 171);
            this.lblUserNameVal.Name = "lblUserNameVal";
            this.lblUserNameVal.Size = new System.Drawing.Size(47, 19);
            this.lblUserNameVal.TabIndex = 11;
            this.lblUserNameVal.Text = "帳號";
            // 
            // txtIDNameVal
            // 
            this.txtIDNameVal.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtIDNameVal.Location = new System.Drawing.Point(84, 23);
            this.txtIDNameVal.Name = "txtIDNameVal";
            this.txtIDNameVal.Size = new System.Drawing.Size(153, 30);
            this.txtIDNameVal.TabIndex = 7;
            this.txtIDNameVal.TextChanged += new System.EventHandler(this.txtIDNameVal_TextChanged);
            this.txtIDNameVal.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtUserName_KeyUp);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblEmail.Location = new System.Drawing.Point(12, 120);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(58, 19);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "E-mail";
            // 
            // lblUserPhone
            // 
            this.lblUserPhone.AutoSize = true;
            this.lblUserPhone.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblUserPhone.Location = new System.Drawing.Point(23, 73);
            this.lblUserPhone.Name = "lblUserPhone";
            this.lblUserPhone.Size = new System.Drawing.Size(47, 19);
            this.lblUserPhone.TabIndex = 11;
            this.lblUserPhone.Text = "電話";
            // 
            // txtPassVal
            // 
            this.txtPassVal.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPassVal.Location = new System.Drawing.Point(445, 171);
            this.txtPassVal.Name = "txtPassVal";
            this.txtPassVal.PasswordChar = '*';
            this.txtPassVal.Size = new System.Drawing.Size(244, 30);
            this.txtPassVal.TabIndex = 14;
            // 
            // txtJobTitleVal
            // 
            this.txtJobTitleVal.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtJobTitleVal.Location = new System.Drawing.Point(444, 73);
            this.txtJobTitleVal.Name = "txtJobTitleVal";
            this.txtJobTitleVal.Size = new System.Drawing.Size(244, 30);
            this.txtJobTitleVal.TabIndex = 10;
            // 
            // txtUserNameVal
            // 
            this.txtUserNameVal.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtUserNameVal.Location = new System.Drawing.Point(85, 171);
            this.txtUserNameVal.Name = "txtUserNameVal";
            this.txtUserNameVal.Size = new System.Drawing.Size(153, 30);
            this.txtUserNameVal.TabIndex = 13;
            this.txtUserNameVal.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtUserNameVal_KeyUp);
            // 
            // txtUserAdrVal
            // 
            this.txtUserAdrVal.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtUserAdrVal.Location = new System.Drawing.Point(444, 120);
            this.txtUserAdrVal.Name = "txtUserAdrVal";
            this.txtUserAdrVal.Size = new System.Drawing.Size(244, 30);
            this.txtUserAdrVal.TabIndex = 12;
            // 
            // txtUsrEmailVal
            // 
            this.txtUsrEmailVal.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtUsrEmailVal.Location = new System.Drawing.Point(84, 119);
            this.txtUsrEmailVal.Name = "txtUsrEmailVal";
            this.txtUsrEmailVal.Size = new System.Drawing.Size(237, 30);
            this.txtUsrEmailVal.TabIndex = 11;
            // 
            // txtUserPhoneVal
            // 
            this.txtUserPhoneVal.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtUserPhoneVal.Location = new System.Drawing.Point(84, 72);
            this.txtUserPhoneVal.Name = "txtUserPhoneVal";
            this.txtUserPhoneVal.Size = new System.Drawing.Size(153, 30);
            this.txtUserPhoneVal.TabIndex = 9;
            // 
            // cxTheSame
            // 
            this.cxTheSame.AutoSize = true;
            this.cxTheSame.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cxTheSame.Location = new System.Drawing.Point(698, 233);
            this.cxTheSame.Name = "cxTheSame";
            this.cxTheSame.Size = new System.Drawing.Size(104, 23);
            this.cxTheSame.TabIndex = 18;
            this.cxTheSame.Text = "與上相同";
            this.cxTheSame.UseVisualStyleBackColor = true;
            this.cxTheSame.CheckedChanged += new System.EventHandler(this.cxTheSame_CheckedChanged);
            // 
            // cxAgree
            // 
            this.cxAgree.AutoSize = true;
            this.cxAgree.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cxAgree.Location = new System.Drawing.Point(15, 805);
            this.cxAgree.Name = "cxAgree";
            this.cxAgree.Size = new System.Drawing.Size(104, 23);
            this.cxAgree.TabIndex = 17;
            this.cxAgree.Text = "勾選同意";
            this.cxAgree.UseVisualStyleBackColor = true;
            this.cxAgree.CheckedChanged += new System.EventHandler(this.cxAgree_CheckedChanged);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReturn.Location = new System.Drawing.Point(699, 12);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(123, 34);
            this.btnReturn.TabIndex = 19;
            this.btnReturn.Text = "返回登入";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(22, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "角色";
            // 
            // comRule
            // 
            this.comRule.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comRule.FormattingEnabled = true;
            this.comRule.Location = new System.Drawing.Point(84, 219);
            this.comRule.Name = "comRule";
            this.comRule.Size = new System.Drawing.Size(154, 27);
            this.comRule.TabIndex = 19;
            // 
            // SNForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(847, 835);
            this.Controls.Add(this.cxAgree);
            this.Controls.Add(this.cxTheSame);
            this.Controls.Add(this.gxSupply);
            this.Controls.Add(this.txtRegInfo);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.gxUserInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "SNForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "金心資訊科技有限公司-授權";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SNForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SNForm_FormClosed);
            this.Load += new System.EventHandler(this.SNForm_Load);
            this.Shown += new System.EventHandler(this.SNForm_Shown);
            this.gxSupply.ResumeLayout(false);
            this.gxSupply.PerformLayout();
            this.gxUserInfo.ResumeLayout(false);
            this.gxUserInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.TextBox txtRegInfo;
        private System.Windows.Forms.GroupBox gxSupply;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Label lblSuppPhone;
        private System.Windows.Forms.Label lblSupply;
        private System.Windows.Forms.TextBox txtSupAddressVal;
        private System.Windows.Forms.TextBox txtSupKeyVal;
        private System.Windows.Forms.TextBox txtSuppPhoneVal;
        private System.Windows.Forms.TextBox txtSupplyVal;
        private System.Windows.Forms.GroupBox gxUserInfo;
        private System.Windows.Forms.Label lblUserAddress;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserAddressVal;
        private System.Windows.Forms.TextBox txtIDNameVal;
        private System.Windows.Forms.Label lblUserPhone;
        private System.Windows.Forms.TextBox txtUserAdrVal;
        private System.Windows.Forms.TextBox txtUserPhoneVal;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtUsrEmailVal;
        private System.Windows.Forms.Label lblSupEmail;
        private System.Windows.Forms.TextBox txtSupEmailVal;
        private System.Windows.Forms.CheckBox cxTheSame;
        private System.Windows.Forms.CheckBox cxAgree;
        private System.Windows.Forms.Label lblJobTitle;
        private System.Windows.Forms.TextBox txtJobTitleVal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUserNameVal;
        private System.Windows.Forms.TextBox txtPassVal;
        private System.Windows.Forms.TextBox txtUserNameVal;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblIdNo;
        private System.Windows.Forms.TextBox txtIdNoVal;
        private System.Windows.Forms.ComboBox comRule;
        private System.Windows.Forms.Label label2;
    }
}