using JINSHIN.BUSINESS.LIBARY.UIControls.GridView;
using JINSHIN.FinanceAccount.Libary.Models.Base;

namespace FinanceAccountProgram.FrmControl
{
    partial class FrmInvManager
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
            FinanceAccountProgram.VModel.AddQueryForm.Acc_VModel acc_VModel1 = new FinanceAccountProgram.VModel.AddQueryForm.Acc_VModel();
            JINSHIN.FinanceAccount.Libary.Models.Base.GridViewFinanceBase gridViewFinanceBase1 = new JINSHIN.FinanceAccount.Libary.Models.Base.GridViewFinanceBase();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInvManager));
            this.updateVerifyAcc = new FinanceAccountProgram.Controls.UpdateListForm();
            this.SuspendLayout();
            // 
            // updateVerifyAcc
            // 
            acc_VModel1.ctl01 = null;
            acc_VModel1.ctl02 = null;
            acc_VModel1.ctl03 = null;
            acc_VModel1.ctl05 = null;
            acc_VModel1.ctl06 = null;
            acc_VModel1.datatype = JINSHIN.FinanceAccount.Libary.Models.Base.AddQueryEnum.None;
            gridViewFinanceBase1.columns = null;
            gridViewFinanceBase1.datatype = JINSHIN.FinanceAccount.Libary.Models.Base.AddQueryEnum.None;
            gridViewFinanceBase1.gvComboList = null;
            acc_VModel1.gvb = gridViewFinanceBase1;
            acc_VModel1.ImportType = 0;
            this.updateVerifyAcc.Accctl = acc_VModel1;
            this.updateVerifyAcc.check = ((System.Collections.Generic.List<int>)(resources.GetObject("updateVerifyAcc.check")));
            this.updateVerifyAcc.Cnt = 150;
            this.updateVerifyAcc.comboli = ((System.Collections.Generic.List<int>)(resources.GetObject("updateVerifyAcc.comboli")));
            this.updateVerifyAcc.ctl01 = null;
            this.updateVerifyAcc.datatype = JINSHIN.FinanceAccount.Libary.Models.Base.AddQueryEnum.None;
            this.updateVerifyAcc.dataUpdateCenter = null;
            this.updateVerifyAcc.gvbase = null;
            this.updateVerifyAcc.gvdatatype = JINSHIN.FinanceAccount.Libary.Models.Base.AddQueryEnum.Acc_CostData;
            this.updateVerifyAcc.listboxSelect = ((System.Collections.Generic.List<int>)(resources.GetObject("updateVerifyAcc.listboxSelect")));
            this.updateVerifyAcc.Location = new System.Drawing.Point(12, 12);
            this.updateVerifyAcc.Name = "updateVerifyAcc";
            this.updateVerifyAcc.operations = null;
            this.updateVerifyAcc.Size = new System.Drawing.Size(1785, 916);
            this.updateVerifyAcc.TabIndex = 0;
            this.updateVerifyAcc.Load += new System.EventHandler(this.updateListForm1_Load);
            // 
            // FrmInvManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1828, 921);
            this.Controls.Add(this.updateVerifyAcc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmInvManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系統帳目管理";
            this.Load += new System.EventHandler(this.FrmInvManager_Load);
            this.Shown += new System.EventHandler(this.FrmInvManager_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.UpdateListForm updateVerifyAcc;
    }
}