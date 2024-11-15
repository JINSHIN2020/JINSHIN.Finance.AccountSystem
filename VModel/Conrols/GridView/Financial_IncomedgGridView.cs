using FinanceAccountProgram.Models;
using FinanceAccountProgram.Models.DataGridViewModel.Financial;
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
    public class Financial_IncomedgGridView : JBase
    {
        private Financial_IncomeGridViewItems gridviewcolus { get; set; }
        public Financial_IncomedgGridView()
        {

        }
        public void SetAccConfirmGridColumns(DataGridView dgControl)
        {
            try
            {
                GridViewBase gvbase = new GridViewBase();
                dgControl.AutoGenerateColumns = false;
                dgControl.Columns.Clear();
                gridviewcolus = new Financial_IncomeGridViewItems();
                gvbase.AutoGenerateColumns(dgControl, gridviewcolus.columns);
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
