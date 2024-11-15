namespace JINSHIN.Finance.AccountSystem.FrmControl.Invoice.DBManagement
{
    partial class FrmPDFConvertJPG
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnData = new System.Windows.Forms.Button();
            this.txtpath = new System.Windows.Forms.TextBox();
            this.lstData = new System.Windows.Forms.ListBox();
            this.lstContent = new System.Windows.Forms.ListBox();
            this.filedlg = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(600, 42);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 47);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "轉換";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnData
            // 
            this.btnData.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnData.Location = new System.Drawing.Point(672, 10);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(78, 26);
            this.btnData.TabIndex = 10;
            this.btnData.Text = "選擇";
            this.btnData.UseVisualStyleBackColor = true;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // txtpath
            // 
            this.txtpath.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtpath.Location = new System.Drawing.Point(370, 10);
            this.txtpath.Name = "txtpath";
            this.txtpath.Size = new System.Drawing.Size(293, 27);
            this.txtpath.TabIndex = 9;
            // 
            // lstData
            // 
            this.lstData.FormattingEnabled = true;
            this.lstData.ItemHeight = 12;
            this.lstData.Location = new System.Drawing.Point(29, 12);
            this.lstData.Name = "lstData";
            this.lstData.Size = new System.Drawing.Size(321, 568);
            this.lstData.TabIndex = 8;
            // 
            // lstContent
            // 
            this.lstContent.FormattingEnabled = true;
            this.lstContent.ItemHeight = 12;
            this.lstContent.Location = new System.Drawing.Point(762, 10);
            this.lstContent.Name = "lstContent";
            this.lstContent.Size = new System.Drawing.Size(321, 568);
            this.lstContent.TabIndex = 13;
            // 
            // filedlg
            // 
            this.filedlg.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(370, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(379, 331);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPDFConvertJPG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 590);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lstContent);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnData);
            this.Controls.Add(this.txtpath);
            this.Controls.Add(this.lstData);
            this.Name = "FrmPDFConvertJPG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDF轉JPEG";
            this.Shown += new System.EventHandler(this.FrmPDFConvertJPG_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnData;
        private System.Windows.Forms.TextBox txtpath;
        private System.Windows.Forms.ListBox lstData;
        private System.Windows.Forms.ListBox lstContent;
        private System.Windows.Forms.OpenFileDialog filedlg;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}