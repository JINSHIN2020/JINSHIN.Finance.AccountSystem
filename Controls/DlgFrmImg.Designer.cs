namespace JINSHIN.Finance.AccountSystem.Controls
{
    partial class DlgFrmImg
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
            this.picimg = new System.Windows.Forms.PictureBox();
            this.plbottom = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picimg)).BeginInit();
            this.plbottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // picimg
            // 
            this.picimg.Dock = System.Windows.Forms.DockStyle.Top;
            this.picimg.Location = new System.Drawing.Point(0, 0);
            this.picimg.Name = "picimg";
            this.picimg.Size = new System.Drawing.Size(800, 390);
            this.picimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picimg.TabIndex = 0;
            this.picimg.TabStop = false;
            this.picimg.Click += new System.EventHandler(this.picimg_Click);
            // 
            // plbottom
            // 
            this.plbottom.Controls.Add(this.btnClose);
            this.plbottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plbottom.Location = new System.Drawing.Point(0, 390);
            this.plbottom.Name = "plbottom";
            this.plbottom.Size = new System.Drawing.Size(800, 60);
            this.plbottom.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClose.Location = new System.Drawing.Point(0, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(800, 60);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "關閉";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // DlgFrmImg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.plbottom);
            this.Controls.Add(this.picimg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "DlgFrmImg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "圖片";
            this.Load += new System.EventHandler(this.DlgFrmImg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picimg)).EndInit();
            this.plbottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picimg;
        private System.Windows.Forms.Panel plbottom;
        private System.Windows.Forms.Button btnClose;
    }
}