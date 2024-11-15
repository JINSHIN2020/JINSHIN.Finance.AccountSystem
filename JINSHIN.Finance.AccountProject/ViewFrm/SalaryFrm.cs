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

namespace FinanceAccountProgram.ViewFrm
{
    public partial class SalaryFrm : Form
    {
       // public string exportPath { get; set; }
        public SalaryFrm()
        {
            InitializeComponent();
        }
        public void SetInit(string path)
        {
        //    exportPath = path;
        //    updateFrm1.exportPath = path;
        }

        private void updateFrm1_Load(object sender, EventArgs e)
        {

        }

        private void SalaryFrm_Shown(object sender, EventArgs e)
        {
            SysRescControlVModel.SetFixedWindow(this);
        }
    }
}
