
using JINSHIN.BUSINESS.LIBARY.UIControls.FormMgt.EntityVModel;

namespace FinanceAccountProgram.FrmControl.Business
{
    partial class FrmOftenWords
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
            this.masterUI1 = new FinanceAccountProgram.Controls.MasterUI();
            this.SuspendLayout();
            // 
            // masterUI1
            // 
            this.masterUI1.control = null;
            this.masterUI1.dbclassctl = null;
            this.masterUI1.Location = new System.Drawing.Point(12, 12);
            this.masterUI1.mastertype1 = JINSHIN.BUSINESS.LIBARY.UIControls.FormMgt.EntityVModel.entityNames.Acc_BookDesc;
            this.masterUI1.mvalues = null;
            this.masterUI1.Name = "masterUI1";
            this.masterUI1.Size = new System.Drawing.Size(1245, 595);
            this.masterUI1.TabIndex = 0;
            this.masterUI1.Load += new System.EventHandler(this.masterUI1_Load);
            // 
            // FrmOftenWords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 599);
            this.Controls.Add(this.masterUI1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOftenWords";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "常用會計名稱";
            this.Shown += new System.EventHandler(this.FrmOftenWords_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.MasterUI masterUI1;
    }
}