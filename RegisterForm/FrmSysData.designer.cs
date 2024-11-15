
namespace JINSHIN.Finance.AccountSystem.RegisterForm
{
    partial class FrmSysData
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
            this.gbSysData = new System.Windows.Forms.GroupBox();
            this.btnServer = new System.Windows.Forms.Button();
            this.btnSaveAdrData = new System.Windows.Forms.Button();
            this.txtadr05 = new System.Windows.Forms.TextBox();
            this.txtadr03 = new System.Windows.Forms.TextBox();
            this.txtadr02 = new System.Windows.Forms.TextBox();
            this.txtadr01 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbSysData.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSysData
            // 
            this.gbSysData.Controls.Add(this.btnServer);
            this.gbSysData.Controls.Add(this.btnSaveAdrData);
            this.gbSysData.Controls.Add(this.txtadr05);
            this.gbSysData.Controls.Add(this.txtadr03);
            this.gbSysData.Controls.Add(this.txtadr02);
            this.gbSysData.Controls.Add(this.txtadr01);
            this.gbSysData.Controls.Add(this.label1);
            this.gbSysData.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbSysData.Location = new System.Drawing.Point(12, 12);
            this.gbSysData.Name = "gbSysData";
            this.gbSysData.Size = new System.Drawing.Size(685, 117);
            this.gbSysData.TabIndex = 98;
            this.gbSysData.TabStop = false;
            this.gbSysData.Text = "系統資料處理";
            // 
            // btnServer
            // 
            this.btnServer.Location = new System.Drawing.Point(551, 62);
            this.btnServer.Name = "btnServer";
            this.btnServer.Size = new System.Drawing.Size(128, 43);
            this.btnServer.TabIndex = 9;
            this.btnServer.Text = "預設值";
            this.btnServer.UseVisualStyleBackColor = true;
            this.btnServer.Click += new System.EventHandler(this.btnServer_Click);
            // 
            // btnSaveAdrData
            // 
            this.btnSaveAdrData.Location = new System.Drawing.Point(551, 16);
            this.btnSaveAdrData.Name = "btnSaveAdrData";
            this.btnSaveAdrData.Size = new System.Drawing.Size(128, 43);
            this.btnSaveAdrData.TabIndex = 9;
            this.btnSaveAdrData.Text = "設定";
            this.btnSaveAdrData.UseVisualStyleBackColor = true;
            this.btnSaveAdrData.Click += new System.EventHandler(this.btnSaveAdrData_Click);
            // 
            // txtadr05
            // 
            this.txtadr05.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtadr05.Location = new System.Drawing.Point(441, 33);
            this.txtadr05.Name = "txtadr05";
            this.txtadr05.Size = new System.Drawing.Size(104, 30);
            this.txtadr05.TabIndex = 7;
            // 
            // txtadr03
            // 
            this.txtadr03.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtadr03.Location = new System.Drawing.Point(331, 33);
            this.txtadr03.Name = "txtadr03";
            this.txtadr03.Size = new System.Drawing.Size(104, 30);
            this.txtadr03.TabIndex = 5;
            // 
            // txtadr02
            // 
            this.txtadr02.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtadr02.Location = new System.Drawing.Point(221, 33);
            this.txtadr02.Name = "txtadr02";
            this.txtadr02.Size = new System.Drawing.Size(104, 30);
            this.txtadr02.TabIndex = 3;
            // 
            // txtadr01
            // 
            this.txtadr01.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtadr01.Location = new System.Drawing.Point(111, 33);
            this.txtadr01.Name = "txtadr01";
            this.txtadr01.Size = new System.Drawing.Size(104, 30);
            this.txtadr01.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(20, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 99;
            this.label1.Text = "服務設定";
            // 
            // FrmSysData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 141);
            this.Controls.Add(this.gbSysData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmSysData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "系統資料";
            this.Load += new System.EventHandler(this.FrmSysData_Load);
            this.Shown += new System.EventHandler(this.FrmSysData_Shown);
            this.gbSysData.ResumeLayout(false);
            this.gbSysData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbSysData;
        private System.Windows.Forms.TextBox txtadr01;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveAdrData;
        private System.Windows.Forms.TextBox txtadr05;
        private System.Windows.Forms.TextBox txtadr03;
        private System.Windows.Forms.TextBox txtadr02;
        private System.Windows.Forms.Button btnServer;
    }
}