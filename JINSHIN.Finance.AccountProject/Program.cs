using FinanceAccountProgram.FrmControl;
using FinanceAccountProgram.FrmControl.Business;
using JINSHIN.Finance.AccountSystem;
using JINSHIN.Finance.AccountSystem.FrmControl.Business.Accounts;
using JINSHIN.Finance.AccountSystem.FrmControl.Business.Money;
using JINSHIN.Finance.AccountSystem.FrmControl.Business.SN;
using JINSHIN.Finance.AccountSystem.FrmControl.Invoice;
using JINSHIN.RegProcess.Liary.Content.Frm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceAccountProgram
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmPayMgt());
            
            //Application.Run(new FrmMenu());
            Application.Run(new frmLogin());
           // Application.Run(new FrmRecMgt());
            //Application.Run(new FrmRegister());
          //  Application.Run(new FrmInvScan());
            //Application.Run(new FrmInvoiceMgt());
        }
    }
}
