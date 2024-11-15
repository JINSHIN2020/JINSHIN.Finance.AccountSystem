using JINSHIN.FinanceAccount.Libary.Models.Base;

namespace FinanceAccountProgram
{
    partial class ImportDataFrm
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
            FinanceAccountProgram.Models.Config.PathModel pathModel1 = new FinanceAccountProgram.Models.Config.PathModel();
            FinanceAccountProgram.VModel.AddQueryDataForm.JINSHINFINANCE047Ctl jinshinfinancE047Ctl1 = new FinanceAccountProgram.VModel.AddQueryDataForm.JINSHINFINANCE047Ctl();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportDataFrm));
            this.TPImportData = new System.Windows.Forms.TabControl();
            this.tpVerifyItem = new System.Windows.Forms.TabPage();
            this.frmDataMaintain = new FinanceAccountProgram.Controls.FrmDataMaintain();
            this.TPImportData.SuspendLayout();
            this.tpVerifyItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // TPImportData
            // 
            this.TPImportData.Controls.Add(this.tpVerifyItem);
            this.TPImportData.Location = new System.Drawing.Point(4, 2);
            this.TPImportData.Name = "TPImportData";
            this.TPImportData.SelectedIndex = 0;
            this.TPImportData.Size = new System.Drawing.Size(1773, 855);
            this.TPImportData.TabIndex = 0;
            // 
            // tpVerifyItem
            // 
            this.tpVerifyItem.Controls.Add(this.frmDataMaintain);
            this.tpVerifyItem.Location = new System.Drawing.Point(4, 22);
            this.tpVerifyItem.Name = "tpVerifyItem";
            this.tpVerifyItem.Padding = new System.Windows.Forms.Padding(3);
            this.tpVerifyItem.Size = new System.Drawing.Size(1765, 829);
            this.tpVerifyItem.TabIndex = 0;
            this.tpVerifyItem.Text = "帳務";
            this.tpVerifyItem.UseVisualStyleBackColor = true;
            this.tpVerifyItem.Click += new System.EventHandler(this.tpVerifyItem_Click);
            // 
            // frmDataMaintain
            // 
            this.frmDataMaintain.assets_ctl = null;
            this.frmDataMaintain.datapath06 = null;
            this.frmDataMaintain.datapath07 = null;
            this.frmDataMaintain.datapath09 = null;
            this.frmDataMaintain.datapath10 = null;
            this.frmDataMaintain.datatype = JINSHIN.FinanceAccount.Libary.Models.Base.AddQueryEnum.None;
            this.frmDataMaintain.financial_balance = null;
            this.frmDataMaintain.financial_income = null;
            this.frmDataMaintain.ImportType = 0;
            this.frmDataMaintain.Location = new System.Drawing.Point(6, 6);
            this.frmDataMaintain.Name = "frmDataMaintain";
            pathModel1.dataUpdateCenter = "C:\\Program Files\\Microsoft Visual Studio\\2022\\Community\\UpdateCenter\\";
            pathModel1.moneypath = "C:\\Program Files\\Microsoft Visual Studio\\2022\\Community\\Finance\\";
            this.frmDataMaintain.pathmodel = pathModel1;
            this.frmDataMaintain.Size = new System.Drawing.Size(1738, 704);
            this.frmDataMaintain.TabIndex = 0;
            jinshinfinancE047Ctl1.acc_CostItmes = null;
            jinshinfinancE047Ctl1.acc_VerifyItmes = null;
            jinshinfinancE047Ctl1.Accid_desc = ((System.Collections.Generic.List<string>)(resources.GetObject("jinshinfinancE047Ctl1.Accid_desc")));
            jinshinfinancE047Ctl1.datatype = JINSHIN.FinanceAccount.Libary.Models.Base.AddQueryEnum.None;
            jinshinfinancE047Ctl1.dbclass = null;
            jinshinfinancE047Ctl1.gvbase = null;
            jinshinfinancE047Ctl1.ImportType = 0;
            jinshinfinancE047Ctl1.specialAccds = ((System.Collections.Generic.List<string>)(resources.GetObject("jinshinfinancE047Ctl1.specialAccds")));
            this.frmDataMaintain.verifyitem_ctl = jinshinfinancE047Ctl1;
            this.frmDataMaintain.Load += new System.EventHandler(this.frmDataMaintain_Load);
            // 
            // ImportDataFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1789, 878);
            this.Controls.Add(this.TPImportData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ImportDataFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "帳務管理";
            this.Load += new System.EventHandler(this.ImportDataFrm_Load);
            this.Shown += new System.EventHandler(this.ImportDataFrm_Shown);
            this.TPImportData.ResumeLayout(false);
            this.tpVerifyItem.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TPImportData;
        private System.Windows.Forms.TabPage tpVerifyItem;
        private Controls.FrmDataMaintain frmDataMaintain;
    }
}