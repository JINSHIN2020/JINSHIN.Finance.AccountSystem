using FinanceAccountProgram;
using JINSHIN.FinanceAccount.Libary.VModels.AccControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JINSHIN.Finance.AccountSystem.FrmControl.Business.Dialog
{
    public partial class PassDlg : Form
    {
        public FrmMenu frm { get; set; }
        public PassDlg()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtpass.Text == "12@WqaV")
            {
                frm.super_user  = true;
                Close();
            }
            else
                frm.super_user = false;
        }

        private void PassDlg_Shown(object sender, EventArgs e)
        {
            SysRescControlVModel.SetFixedWindow(this);
        }
    }
}
