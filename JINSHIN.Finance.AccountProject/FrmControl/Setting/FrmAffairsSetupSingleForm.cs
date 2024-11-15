using FinanceAccountProgram.VModel.Conrols.ManageForm;
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

namespace FinanceAccountProgram.FrmControl
{
    public partial class FrmAffairsSetupSingleForm : Form
    {
        public FrmAffairsSetupSingleForm()
        {
            InitializeComponent();
            using (FormControlVModel ctlmodel = new FormControlVModel())
            {
                ctlmodel.ControlResolution(this);
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {

        }

        private void FrmAffairsSetupSingleForm_Shown(object sender, EventArgs e)
        {
            SysRescControlVModel.SetFixedWindow(this);
        }
    }
}
