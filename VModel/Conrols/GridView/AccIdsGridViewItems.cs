using FinanceAccountProgram.Models.DataGridViewModel;
using JINSHIN.BUSINESS.LIBARY.Base;
using JINSHIN.BUSINESS.LIBARY.UIControls.GridView;
using JINSHIN.Finance.AccountSystem.Models.DataGridViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JINSHIN.Finance.AccountSystem.VModel.Conrols.GridView
{
    public class AccIdsGridViewItems : JBase
    {
        private AccIdsGVItems gridviewcolus { get; set; }
        public AccIdsGridViewItems()
        {

        }
        public void SetAccConfirmGridColumns(DataGridView dgControl)
        {
            try
            {
                GridViewBase gvbase = new GridViewBase();
                dgControl.AutoGenerateColumns = false;
                dgControl.Columns.Clear();
                gridviewcolus = new AccIdsGVItems();
                gvbase.AutoGenerateColumns(dgControl, gridviewcolus.columns,gridviewcolus.columnwidths);
                //dgControl.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                //for (int i = 0; i < dgControl.Columns.Count; i++)
                //{
                //    dgControl.Columns[i].Width = gridviewcolus.columnwidths[i];
                //}
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
