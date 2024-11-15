using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinanceAccountProgram.VModel.UsrControl;
using FinanceAccountProgram.VModel.Conrols.Model;
using FinanceAccountProgram.VModel.Conrols;
using FinanceAccountProgram.Models.UControl;
using FinanceAccountProgram.Models.UpdateForm;
using FinanceAccountProgram.VModel;
using FinanceAccountProgram.Models;
using FinanceAccountProgram.VModel.Conrols.VModel;
using FinanceAccountProgram.Models.AddQueryDataForm;
using FinanceAccountProgram.VModel.Money;
using FinanceAccountProgram.VModel.Conrols.QueryModel;
using FinanceAccountProgram.VModel.Business;
using FinanceAccountProgram.Models.Config;
using JINSHIN.FinanceAccounting.DB;
using JINSHIN.BUSINESS.LIBARY.UIControls.GridView;
using JINSHIN.BUSINESS.LIBARY.Resources;
using JINSHIN.BUSINESS.LIBARY.Models.UIControls;
using JINSHIN.FinanceAccount.Libary.Models.Base;

namespace FinanceAccountProgram.Controls
{
    public partial class UpdateFrm : UserControl
    {
        public List<GridViewOperation> operations { get; set; }
        public UpdateFormEnum01 uftype01 { get; set; }
        public int uftypeval { get; set; }
        public List<int> diffcnt { get; set; }
        public GridViewBase gvbase { get; set; }
        public MoneyVModel moneymodel { get; set; }       
        public DataParams params01  { get; set; }
        public UpdateFormVModel model { get; set; }
        public GridViewQueryVModel querymodel { get; set; }
        private PathModel pathmodel { get; set; }
        public string accid { get; set; }
        public UpdateFrm()
        {
            InitializeComponent();
            dgControl.Font = new System.Drawing.Font(DataControl.DataGridFont, Convert.ToInt32(DataControl.DataGridFontSize));
            diffcnt = new List<int>() {0,4 };
          
        }
        public void SetInit(UpdateFormEnum01 data01 = UpdateFormEnum01.None, int ufclass=0)
        {
            pathmodel = new PathModel();
            querymodel = new GridViewQueryVModel();
            model = new UpdateFormVModel(dgControl, AddQueryEnum.None, UpdateFormEnum01.SalaryData);
            params01 = new DataParams();
            gvbase = new GridViewBase();
            moneymodel = new MoneyVModel();
            if (data01 != UpdateFormEnum01.None)
                uftype01 = data01;
            uftypeval = ufclass;
            operations = new List<GridViewOperation>();                     
            btnQuery_Click(new object(), null);
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            model.InitColumnConfig();
            model.GridViewUpdateData(dgControl, uftypeval, operations, params01);
        }

        private void SetGridColumns()
        {
            dgControl.AutoGenerateColumns = false;
            dgControl.Columns.Clear();
            SalaryGirdFrm vagrid = new SalaryGirdFrm();
            List<NameValues> columns = vagrid.columns;
            gvbase.AutoGenerateColumns(dgControl, columns);
        }

     

        private void dgControl_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
                operations.Add(new GridViewOperation()
                { colidx = e.ColumnIndex, rowidx = e.RowIndex });
        }

        private void dgControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnUpdate_Click(new object(), null);
            }
        }

        private void UpdateFrm_Load(object sender, EventArgs e)
        {

        }
       
        private void btnQuery_Click(object sender, EventArgs e)
        {
            params01.ClearData();
            int idx = 0;
            if (uftype01 != UpdateFormEnum01.None)
                idx = Convert.ToInt32(uftype01) - 1;
            else
                idx = uftypeval;
            querymodel.SetConfigToParameter(querymodel.updateFrms_conditiondesc[idx], params01);
            accid = querymodel.updateFrms_conditiondesc[idx].AccID_Cost;
            if (moneymodel.accmodel.ctl03.acc_CostItmes != null)
                moneymodel.accmodel.ctl03.acc_CostItmes.Clear();
            if (moneymodel.accmodel.ctl03.acc_VerifyItmes != null)
                moneymodel.accmodel.ctl03.acc_VerifyItmes.Clear();
            moneymodel.accmodel.ctl03.SetInit();
            SetGridColumns();
            moneymodel.accmodel.ctl03.GetStorageData(AddQueryEnum.JINSHINFINANCE047, params01);            
            moneymodel.accmodel.DataShow<JINSHINFINANCE035>(dgControl, params01, uftypeval);
        }

        private void dgControl_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView dg = sender as DataGridView;
            IComparer<JINSHINFINANCE035> clist = default(IComparer<JINSHINFINANCE035>);
            foreach (var item in model.sort_columns)
            {
                if (e.ColumnIndex == item.value01)
                {
                    switch (item.value02)
                    {
                        case "Valid_Month": {
                                clist = new VerifyMonthCompareList() as IComparer<JINSHINFINANCE035>;
                            } break;
                        case "Acc_No": {
                                clist = new Acc_NoCompareList() as IComparer<JINSHINFINANCE035>;
                            } break;
                        default:
                            break;
                    }
                }               
            }
            if (clist != null)
            {
                moneymodel.accmodel.ctl03.acc_CostItmes.Sort(clist);
                dg.DataSource = moneymodel.accmodel.ctl03.acc_CostItmes;
                //dg.DataSource
                dg.Refresh();
            }
        }

        private void btnVerifyCheck_Click(object sender, EventArgs e)
        {
            using (MoneyVerifyClass model = new MoneyVerifyClass())
            {
                model.CheckVerify(moneymodel.accmodel.ctl03.acc_CostItmes);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            using (MoneyVerifyClass model = new MoneyVerifyClass())
            {
                model.CancelVerify(moneymodel.accmodel.ctl03.acc_CostItmes);
            }           
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            using (MoneyVerifyClass model = new MoneyVerifyClass())
            {
                model.InvoiceImport(moneymodel.accmodel.ctl03.acc_CostItmes);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            using (GridViewBase grid = new GridViewBase())
            {
                grid.ExportDataGridView(pathmodel.exportPath, "Acc_Confirm", dgControl);
            }
        }

        private void UpdateFrm_Load_1(object sender, EventArgs e)
        {

        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            using (BusinessCtl busctl = new BusinessCtl())
            {
                busctl.VerifyInvoiceAndAmount(moneymodel.accmodel.ctl03.acc_CostItmes, dgControl, lstmsg, accid);
            }
          
        }

        private void dgControl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
