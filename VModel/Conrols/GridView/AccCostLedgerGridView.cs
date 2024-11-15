using FinanceAccountProgram.Models;
using FinanceAccountProgram.Models.DataGridViewModel;
using FinanceAccountProgram.VModel.Conrols.Model;
using JINSHIN.BUSINESS.LIBARY.Base;
using JINSHIN.BUSINESS.LIBARY.UIControls.GridView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceAccountProgram.VModel.Conrols.GridView
{
    public class AccCostLedgerGridView :JBase
    {
        private AccCostLedgerGridViewItems gridviewcolus { get; set; }
        public AccCostLedgerGridView()
        {

        }
        public void SetAccConfirmGridColumns(DataGridView dgControl)
        {
            try
            {
                GridViewBase gvbase = new GridViewBase();
                dgControl.AutoGenerateColumns = false;
                dgControl.Columns.Clear();
                gridviewcolus = new AccCostLedgerGridViewItems();
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
