namespace JINSHIN.Finance.AccountSystem.RegisterForm
{
    partial class GetSNFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetSNFrm));
            this.lblSerialSN = new System.Windows.Forms.Label();
            this.btnGenSN = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.txtContractData = new System.Windows.Forms.TextBox();
            this.gxSupply = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblKey = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblJobTitle = new System.Windows.Forms.Label();
            this.lblSupEmail = new System.Windows.Forms.Label();
            this.lblSuppPhone = new System.Windows.Forms.Label();
            this.lblSupply = new System.Windows.Forms.Label();
            this.txtSupAddressVal = new System.Windows.Forms.TextBox();
            this.txtSupKeyVal = new System.Windows.Forms.TextBox();
            this.txtIdCardVal = new System.Windows.Forms.TextBox();
            this.txtUserAddressVal = new System.Windows.Forms.TextBox();
            this.txtJobTitleVal = new System.Windows.Forms.TextBox();
            this.txtSupEmailVal = new System.Windows.Forms.TextBox();
            this.txtIDNoVal = new System.Windows.Forms.TextBox();
            this.txtSupPhoneVal = new System.Windows.Forms.TextBox();
            this.txtSupplyVal = new System.Windows.Forms.TextBox();
            this.cxAgree = new System.Windows.Forms.CheckBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.gxSupply.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSerialSN
            // 
            this.lblSerialSN.AutoSize = true;
            this.lblSerialSN.Font = new System.Drawing.Font("新細明體", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSerialSN.Location = new System.Drawing.Point(119, 753);
            this.lblSerialSN.Name = "lblSerialSN";
            this.lblSerialSN.Size = new System.Drawing.Size(467, 38);
            this.lblSerialSN.TabIndex = 0;
            this.lblSerialSN.Text = "                                             ";
            // 
            // btnGenSN
            // 
            this.btnGenSN.Enabled = false;
            this.btnGenSN.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnGenSN.Location = new System.Drawing.Point(603, 754);
            this.btnGenSN.Name = "btnGenSN";
            this.btnGenSN.Size = new System.Drawing.Size(123, 33);
            this.btnGenSN.TabIndex = 20;
            this.btnGenSN.Text = "產生序號";
            this.btnGenSN.UseVisualStyleBackColor = true;
            this.btnGenSN.Click += new System.EventHandler(this.btnGenSN_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.Font = new System.Drawing.Font("新細明體", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBuy.Location = new System.Drawing.Point(45, 326);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(676, 39);
            this.btnBuy.TabIndex = 22;
            this.btnBuy.Text = "上傳資料";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // txtContractData
            // 
            this.txtContractData.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtContractData.Location = new System.Drawing.Point(54, 371);
            this.txtContractData.Multiline = true;
            this.txtContractData.Name = "txtContractData";
            this.txtContractData.Size = new System.Drawing.Size(662, 236);
            this.txtContractData.TabIndex = 3;
            this.txtContractData.Text = resources.GetString("txtContractData.Text");
            this.txtContractData.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtContractData_KeyUp);
            // 
            // gxSupply
            // 
            this.gxSupply.Controls.Add(this.label1);
            this.gxSupply.Controls.Add(this.label2);
            this.gxSupply.Controls.Add(this.lblKey);
            this.gxSupply.Controls.Add(this.label6);
            this.gxSupply.Controls.Add(this.label4);
            this.gxSupply.Controls.Add(this.label3);
            this.gxSupply.Controls.Add(this.label5);
            this.gxSupply.Controls.Add(this.lblJobTitle);
            this.gxSupply.Controls.Add(this.lblSupEmail);
            this.gxSupply.Controls.Add(this.lblSuppPhone);
            this.gxSupply.Controls.Add(this.lblSupply);
            this.gxSupply.Controls.Add(this.txtSupAddressVal);
            this.gxSupply.Controls.Add(this.txtSupKeyVal);
            this.gxSupply.Controls.Add(this.txtIdCardVal);
            this.gxSupply.Controls.Add(this.txtUserAddressVal);
            this.gxSupply.Controls.Add(this.txtJobTitleVal);
            this.gxSupply.Controls.Add(this.txtSupEmailVal);
            this.gxSupply.Controls.Add(this.txtIDNoVal);
            this.gxSupply.Controls.Add(this.txtSupPhoneVal);
            this.gxSupply.Controls.Add(this.txtSupplyVal);
            this.gxSupply.Location = new System.Drawing.Point(40, 0);
            this.gxSupply.Name = "gxSupply";
            this.gxSupply.Size = new System.Drawing.Size(676, 320);
            this.gxSupply.TabIndex = 10;
            this.gxSupply.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(48, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "地址";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(278, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "鍵值";
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblKey.Location = new System.Drawing.Point(10, 65);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(85, 19);
            this.lblKey.TabIndex = 13;
            this.lblKey.Text = "統一編號";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(29, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "申請人";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(361, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "申請人";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(361, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "身份證";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(37, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "地址";
            // 
            // lblJobTitle
            // 
            this.lblJobTitle.AutoSize = true;
            this.lblJobTitle.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblJobTitle.Location = new System.Drawing.Point(48, 208);
            this.lblJobTitle.Name = "lblJobTitle";
            this.lblJobTitle.Size = new System.Drawing.Size(47, 19);
            this.lblJobTitle.TabIndex = 13;
            this.lblJobTitle.Text = "職級";
            // 
            // lblSupEmail
            // 
            this.lblSupEmail.AutoSize = true;
            this.lblSupEmail.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSupEmail.Location = new System.Drawing.Point(46, 162);
            this.lblSupEmail.Name = "lblSupEmail";
            this.lblSupEmail.Size = new System.Drawing.Size(47, 19);
            this.lblSupEmail.TabIndex = 13;
            this.lblSupEmail.Text = "姓名";
            // 
            // lblSuppPhone
            // 
            this.lblSuppPhone.AutoSize = true;
            this.lblSuppPhone.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSuppPhone.Location = new System.Drawing.Point(352, 162);
            this.lblSuppPhone.Name = "lblSuppPhone";
            this.lblSuppPhone.Size = new System.Drawing.Size(85, 19);
            this.lblSuppPhone.TabIndex = 13;
            this.lblSuppPhone.Text = "公司電話";
            // 
            // lblSupply
            // 
            this.lblSupply.AutoSize = true;
            this.lblSupply.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSupply.Location = new System.Drawing.Point(48, 21);
            this.lblSupply.Name = "lblSupply";
            this.lblSupply.Size = new System.Drawing.Size(47, 19);
            this.lblSupply.TabIndex = 14;
            this.lblSupply.Text = "廠商";
            // 
            // txtSupAddressVal
            // 
            this.txtSupAddressVal.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSupAddressVal.Location = new System.Drawing.Point(110, 107);
            this.txtSupAddressVal.Name = "txtSupAddressVal";
            this.txtSupAddressVal.Size = new System.Drawing.Size(474, 30);
            this.txtSupAddressVal.TabIndex = 4;
            // 
            // txtSupKeyVal
            // 
            this.txtSupKeyVal.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSupKeyVal.Location = new System.Drawing.Point(334, 62);
            this.txtSupKeyVal.Name = "txtSupKeyVal";
            this.txtSupKeyVal.Size = new System.Drawing.Size(135, 30);
            this.txtSupKeyVal.TabIndex = 3;
            // 
            // txtIdCardVal
            // 
            this.txtIdCardVal.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtIdCardVal.Location = new System.Drawing.Point(441, 208);
            this.txtIdCardVal.Name = "txtIdCardVal";
            this.txtIdCardVal.Size = new System.Drawing.Size(224, 30);
            this.txtIdCardVal.TabIndex = 14;
            // 
            // txtUserAddressVal
            // 
            this.txtUserAddressVal.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtUserAddressVal.Location = new System.Drawing.Point(109, 260);
            this.txtUserAddressVal.Name = "txtUserAddressVal";
            this.txtUserAddressVal.Size = new System.Drawing.Size(475, 30);
            this.txtUserAddressVal.TabIndex = 15;
            // 
            // txtJobTitleVal
            // 
            this.txtJobTitleVal.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtJobTitleVal.Location = new System.Drawing.Point(109, 208);
            this.txtJobTitleVal.Name = "txtJobTitleVal";
            this.txtJobTitleVal.Size = new System.Drawing.Size(230, 30);
            this.txtJobTitleVal.TabIndex = 10;
            // 
            // txtSupEmailVal
            // 
            this.txtSupEmailVal.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSupEmailVal.Location = new System.Drawing.Point(110, 158);
            this.txtSupEmailVal.Name = "txtSupEmailVal";
            this.txtSupEmailVal.Size = new System.Drawing.Size(230, 30);
            this.txtSupEmailVal.TabIndex = 5;
            // 
            // txtIDNoVal
            // 
            this.txtIDNoVal.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtIDNoVal.Location = new System.Drawing.Point(109, 62);
            this.txtIDNoVal.Name = "txtIDNoVal";
            this.txtIDNoVal.Size = new System.Drawing.Size(153, 30);
            this.txtIDNoVal.TabIndex = 2;
            // 
            // txtSupPhoneVal
            // 
            this.txtSupPhoneVal.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSupPhoneVal.Location = new System.Drawing.Point(442, 158);
            this.txtSupPhoneVal.Name = "txtSupPhoneVal";
            this.txtSupPhoneVal.Size = new System.Drawing.Size(223, 30);
            this.txtSupPhoneVal.TabIndex = 8;
            // 
            // txtSupplyVal
            // 
            this.txtSupplyVal.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSupplyVal.Location = new System.Drawing.Point(110, 17);
            this.txtSupplyVal.Name = "txtSupplyVal";
            this.txtSupplyVal.Size = new System.Drawing.Size(253, 30);
            this.txtSupplyVal.TabIndex = 1;
            this.txtSupplyVal.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSupplyVal_KeyUp);
            // 
            // cxAgree
            // 
            this.cxAgree.AutoSize = true;
            this.cxAgree.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cxAgree.Location = new System.Drawing.Point(40, 618);
            this.cxAgree.Name = "cxAgree";
            this.cxAgree.Size = new System.Drawing.Size(142, 23);
            this.cxAgree.TabIndex = 16;
            this.cxAgree.Text = "同意此上條款";
            this.cxAgree.UseVisualStyleBackColor = true;
            // 
            // btnPay
            // 
            this.btnPay.Font = new System.Drawing.Font("新細明體", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPay.Location = new System.Drawing.Point(48, 646);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(676, 39);
            this.btnPay.TabIndex = 22;
            this.btnPay.Text = "付款";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // GetSNFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 701);
            this.Controls.Add(this.cxAgree);
            this.Controls.Add(this.gxSupply);
            this.Controls.Add(this.txtContractData);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.btnGenSN);
            this.Controls.Add(this.lblSerialSN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "GetSNFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "金心資訊科技有限公司-授權";
            this.Load += new System.EventHandler(this.GetSNFrm_Load);
            this.Shown += new System.EventHandler(this.GetSNFrm_Shown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GetSNFrm_KeyUp);
            this.gxSupply.ResumeLayout(false);
            this.gxSupply.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSerialSN;
        private System.Windows.Forms.Button btnGenSN;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.TextBox txtContractData;
        private System.Windows.Forms.GroupBox gxSupply;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Label lblSupEmail;
        private System.Windows.Forms.Label lblSuppPhone;
        private System.Windows.Forms.Label lblSupply;
        private System.Windows.Forms.TextBox txtSupAddressVal;
        private System.Windows.Forms.TextBox txtSupKeyVal;
        private System.Windows.Forms.TextBox txtSupEmailVal;
        private System.Windows.Forms.TextBox txtIDNoVal;
        private System.Windows.Forms.TextBox txtSupPhoneVal;
        private System.Windows.Forms.TextBox txtSupplyVal;
        private System.Windows.Forms.CheckBox cxAgree;
        private System.Windows.Forms.Label lblJobTitle;
        private System.Windows.Forms.TextBox txtJobTitleVal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdCardVal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUserAddressVal;
        private System.Windows.Forms.Button btnPay;
    }
}