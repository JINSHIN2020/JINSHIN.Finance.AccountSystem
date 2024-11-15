using FinanceAccountProgram.Models.DataGridViewModel;
using JINSHIN.BUSINESS.LIBARY.Base;
using JINSHIN.BUSINESS.LIBARY.UIControls.GridView;
using JINSHIN.FinanceAccount.Libary.Models.Financial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JINSHIN.Finance.AccountSystem.VModel.Conrols.GridView
{
    public class AccLedgerGridView :JBase
    {
        private AccLedgerGridViewItems gridviewcolus { get; set; }
        public AccLedgerGridView()
        {

        }
        public void SetAccConfirmGridColumns(DataGridView dgControl)
        {
            try
            {
                GridViewBase gvbase = new GridViewBase();
                dgControl.AutoGenerateColumns = false;
                dgControl.Columns.Clear();
                gridviewcolus = new AccLedgerGridViewItems();
                gvbase.AutoGenerateColumns(dgControl, gridviewcolus.columns);
                gvbase.Dispose();
            }
            finally
            {
                gridviewcolus.columns.Clear();
                gridviewcolus.Dispose();
            }
        }
    }
}
