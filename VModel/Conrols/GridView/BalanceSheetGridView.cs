using FinanceAccountProgram.Models;
using FinanceAccountProgram.Models.DataGridViewModel.Financial;
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
    public class BalanceSheetGridView :JBase
    {
        private BalanceSheetGridViewItems gridviewcolus { get; set; }
        public BalanceSheetGridView()
        {

        }
        public void SetAccConfirmGridColumns(DataGridView dgControl)
        {
            try
            {
                GridViewBase gvbase = new GridViewBase();
                dgControl.AutoGenerateColumns = false;
                dgControl.Columns.Clear();
                gridviewcolus = new BalanceSheetGridViewItems();
                gvbase.AutoGenerateColumns(dgControl, gridviewcolus.columns);
                //   dgControl.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgControl.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgControl.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
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
