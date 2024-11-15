using FinanceAccountProgram;
using JINSHIN.BUSINESS.LIBARY.Sercurity;
using JINSHIN.Finance.AccountSystem.FrmControl.Business.Money;
using JINSHIN.Finance.AccountSystem.FrmControl.Invoice;
using JINSHIN.WORK.Resource;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JINSHIN.Finance.AccountSystem
{
    public partial class InvControlData : Form
    {
        public InvControlData()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            SNForm system = new SNForm();
           // this.Hide();
            system.ShowDialog();
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            using (Frm_InvScan mgt = new Frm_InvScan())
            {
               
                mgt.ShowDialog();
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            using (FrmMoneyPay moneypay = new FrmMoneyPay())
            {
                moneypay.ShowDialog();
            }
        }
    }
}
