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

namespace JINSHIN.Finance.AccountSystem.RegisterForm
{
    public partial class PassOn : Form
    {
        public PassOn()
        {
            InitializeComponent();
        }

        private void PassMgt_KeyDown(object sender, KeyEventArgs e)
        {
            ShowSysData(e);
        }

        private void ShowSysData(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11)
            {
                if (txtPass.Text == "sharon")
                {
                    FrmSysData sysdata = new FrmSysData();
                    sysdata.ShowDialog();
                    sysdata.Dispose();
                }
            }
        }

        private void PassOn_Load(object sender, EventArgs e)
        {

        }

        private void txtPass_KeyUp(object sender, KeyEventArgs e)
        {
            ShowSysData(e);
        }

        private void PassOn_Shown(object sender, EventArgs e)
        {
            SysRescControlVModel.SetFixedWindow(this);
        }
    }
}
