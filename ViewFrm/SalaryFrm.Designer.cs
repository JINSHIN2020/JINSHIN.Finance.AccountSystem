namespace FinanceAccountProgram.ViewFrm
{
    partial class SalaryFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalaryFrm));
            this.updateFrm1 = new FinanceAccountProgram.Controls.UpdateFrm();
            this.SuspendLayout();
            // 
            // updateFrm1
            // 
            this.updateFrm1.accid = null;
            this.updateFrm1.diffcnt = ((System.Collections.Generic.List<int>)(resources.GetObject("updateFrm1.diffcnt")));
            this.updateFrm1.gvbase = null;
            this.updateFrm1.Location = new System.Drawing.Point(12, 3);
            this.updateFrm1.model = null;
            this.updateFrm1.moneymodel = null;
            this.updateFrm1.Name = "updateFrm1";
            this.updateFrm1.operations = null;
            this.updateFrm1.params01 = null;
            this.updateFrm1.querymodel = null;
            this.updateFrm1.Size = new System.Drawing.Size(1330, 775);
            this.updateFrm1.TabIndex = 0;
            this.updateFrm1.uftype01 = FinanceAccountProgram.Models.UpdateForm.UpdateFormEnum01.None;
            this.updateFrm1.uftypeval = 0;
            this.updateFrm1.Load += new System.EventHandler(this.updateFrm1_Load);
            // 
            // SalaryFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 778);
            this.Controls.Add(this.updateFrm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "SalaryFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalaryFrm";
            this.Shown += new System.EventHandler(this.SalaryFrm_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        public Controls.UpdateFrm updateFrm1;
    }
}