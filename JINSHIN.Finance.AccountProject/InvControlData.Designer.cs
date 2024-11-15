namespace JINSHIN.Finance.AccountSystem
{
    partial class InvControlData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvControlData));
            this.btnInvoice = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.lblIdno = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnInvoice
            // 
            this.btnInvoice.Font = new System.Drawing.Font("新細明體", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnInvoice.Location = new System.Drawing.Point(172, 12);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(513, 67);
            this.btnInvoice.TabIndex = 90;
            this.btnInvoice.Text = "發票掃描器";
            this.btnInvoice.UseVisualStyleBackColor = true;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.Font = new System.Drawing.Font("新細明體", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBuy.Location = new System.Drawing.Point(172, 102);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(513, 67);
            this.btnBuy.TabIndex = 91;
            this.btnBuy.Text = "採購";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // lblIdno
            // 
            this.lblIdno.AutoSize = true;
            this.lblIdno.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblIdno.Location = new System.Drawing.Point(172, 196);
            this.lblIdno.Name = "lblIdno";
            this.lblIdno.Size = new System.Drawing.Size(98, 22);
            this.lblIdno.TabIndex = 92;
            this.lblIdno.Text = "統一編號";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(276, 190);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(293, 33);
            this.textBox1.TabIndex = 93;
            // 
            // InvControlData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblIdno);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.btnInvoice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "InvControlData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "發票裝置";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Label lblIdno;
        private System.Windows.Forms.TextBox textBox1;
    }
}