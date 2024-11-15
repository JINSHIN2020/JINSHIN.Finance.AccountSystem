using FinanceAccountProgram.Models;
using FinanceAccountProgram.Models.DataGridViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JINSHIN.BUSINESS.LIBARY.Base;
using JINSHIN.BUSINESS.LIBARY.UIControls.GridView;
namespace FinanceAccountProgram.VModel.Conrols.GridView
{
    public class AccoutnEntriesGridView :JBase
    {
        private AccoutnEntriesGridViewItem gridviewcolus { get; set; }
        public AccoutnEntriesGridView()
        {

        }
        public void SetAccConfirmGridColumns(DataGridView dgControl)
        {
            try
            {
                GridViewBase gvbase = new GridViewBase();
                dgControl.AutoGenerateColumns = false;
                dgControl.Columns.Clear();
                gridviewcolus = new AccoutnEntriesGridViewItem();
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
