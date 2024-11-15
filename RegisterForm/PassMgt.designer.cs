
namespace JINSHIN.Finance.AccountSystem.RegisterForm
{
    partial class PassOn
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
            this.lblPass = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPass.Location = new System.Drawing.Point(12, 23);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(120, 22);
            this.lblPass.TabIndex = 0;
            this.lblPass.Text = "管理員密碼";
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPass.Location = new System.Drawing.Point(138, 20);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(255, 33);
            this.txtPass.TabIndex = 1;
            this.txtPass.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPass_KeyUp);
            // 
            // PassOn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 84);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblPass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "PassOn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "請輸入管理員密碼";
            this.Load += new System.EventHandler(this.PassOn_Load);
            this.Shown += new System.EventHandler(this.PassOn_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PassMgt_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtPass;
    }
}