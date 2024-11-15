using JINSHIN.Finance.AccountSystem;
using FinanceAccountProgram.Models.AddQueryDataForm;
using FinanceAccountProgram.Models.Config;
using FinanceAccountProgram.Models.UControl;
using FinanceAccountProgram.Models.UpdateForm;
using JINSHIN.FinanceAccounting.DB;
using FinanceAccountProgram.VModel;
using FinanceAccountProgram.VModel.Affairs;
using FinanceAccountProgram.VModel.Business;
using FinanceAccountProgram.VModel.Conrols;
using FinanceAccountProgram.VModel.Conrols.Model;
using FinanceAccountProgram.VModel.Conrols.QueryModel;
using FinanceAccountProgram.VModel.Money;
using FinanceAccountProgram.VModel.UsrControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JINSHIN.BUSINESS.LIBARY.UIControls.GridView;
using JINSHIN.BUSINESS.LIBARY.Models.UIControls;
using JINSHIN.Finance.AccountSystem.Resources;
using JINSHIN.FinanceAccount.Libary.Config;
using System.Web.UI.WebControls;
using JINSHIN.FinanceAccount.Libary.VModels.AccControl;

namespace FinanceAccountProgram.ViewFrm
{
    public partial class AffairsFormDlg : Form
    {
        public List<GridViewOperation> operations { get; set; }
        public List<int> diffcnt { get; set; }
        public GridViewBase gvbase { get; set; }
        public MoneyVModel moneymodel { get; set; }
        public DataParams params01 { get; set; }
        public FormVmodel model { get; set; }
        public GridViewQueryAffairs querymodel { get; set; }
        private PathModel pathmodel { get; set; }
        public string accid { get; set; }
        public int datalink { get; set; }
        public affairvmodelctl affvmodel { get; set; }
        public bool NoData { get; set; }
        public AffairsFormDlg()
        {
            InitializeComponent();
            diffcnt = new List<int>() { 0, 4 };
            affvmodel = new affairvmodelctl();
        }

        private List<JINSHINFINANCE035> GetAccountData(List<JINSHINFINANCE035> datalist)
        {
            using (FinancialRptVModel financial = new FinancialRptVModel())
            {
                return datalist = financial.CheckOK(datalist);
            }
        }

        public bool SetInit()
        {
            pathmodel = new PathModel();
            querymodel = new GridViewQueryAffairs(datalink);
            model = new FormVmodel(dgControl);
            params01 = new DataParams();
            gvbase = new GridViewBase();
            moneymodel = new MoneyVModel();
            operations = new List<GridViewOperation>();
            btnQuery_Click(new object(), null);
            return NoData;
        }


        private void SetGridColumns()
        {
            dgControl.AutoGenerateColumns = false;
            dgControl.Columns.Clear();
            SalaryGirdFrm vagrid = new SalaryGirdFrm();
            List<NameValues> columns = vagrid.columns;
            gvbase.AutoGenerateColumns(dgControl, columns);
        }
        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (chCheck.Checked)
                GetVeriftData(false);
            else
                GetVeriftData(true);
        }

        private void GetVeriftData(bool checkdata)
        {
            params01.ClearData();
            if (querymodel.updateFrms_conditiondesc.AccID_Cost == null)
            {
                MessageBox.Show(accounting.AffairsMsg01);
                this.Close();
                NoData = true;
                return;
            }
            querymodel.SetConfigToParameter(querymodel.updateFrms_conditiondesc, params01);
            accid = querymodel.updateFrms_conditiondesc.AccID_Cost;
            if (affvmodel.acc_CostItmes != null)
                affvmodel.acc_CostItmes.Clear();
            if (affvmodel.acc_VerifyItmes != null)
                affvmodel.acc_VerifyItmes.Clear();
            SetGridColumns();

            affvmodel.GetVerifyItems(params01);
            affvmodel.DataShow<JINSHINFINANCE035>(dgControl, params01, checkdata);
            
            //List<JINSHINFINANCE035> view = GetAccountData(view);


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            model.InitColumnConfig();
            model.GridViewUpdateData(affvmodel,dgControl,  operations, params01);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            using (MoneyVerifyClass model = new MoneyVerifyClass())
            {
                GetVeriftData(false);
                model.CancelVerify(affvmodel.acc_CostItmes);
                btnQuery_Click(null, null);
            }
        }

        private void btnVerifyCheck_Click(object sender, EventArgs e)
        {
            using (MoneyVerifyClass model = new MoneyVerifyClass())
            {
                List<JINSHINFINANCE035> values = new List<JINSHINFINANCE035>();
                int sn = 0;
                for (int i = 0; i < dgControl.SelectedRows.Count; i++)
                {
                    sn = Convert.ToInt32(dgControl.SelectedRows[i].Cells[0].Value);
                    values.Add(affvmodel.acc_CostItmes.Where(o => o.SN == sn).FirstOrDefault());
                }
                model.CheckVerify(values);
                btnQuery_Click(null, null);
           //     model.CheckVerify(affvmodel.acc_CostItmes);
            }
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            using (MoneyVerifyClass model = new MoneyVerifyClass())
            {
                model.InvoiceImport(affvmodel.acc_CostItmes);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            using (GridViewBase grid = new GridViewBase())
            {
                grid.ExportDataGridView(pathmodel.exportPath, "Acc_Confirm", dgControl);
            }
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            using (BusinessCtl busctl = new BusinessCtl())
            {
                busctl.VerifyInvoiceAndAmount(affvmodel.acc_CostItmes, dgControl, lstmsg, accid);
            }
        }

        private void dgControl_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
                operations.Add(new GridViewOperation()
                { colidx = e.ColumnIndex, rowidx = e.RowIndex });
        }

        private void dgControl_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridView dg = sender as DataGridView;
                IComparer<JINSHINFINANCE035> clist = default(IComparer<JINSHINFINANCE035>);
                foreach (var item in model.sort_columns)
                {
                    if (e.ColumnIndex == item.value01)
                    {
                        switch (item.value02)
                        {
                            case "Valid_Month":
                                {
                                    clist = new VerifyMonthCompareList() as IComparer<JINSHINFINANCE035>;
                                }
                                break;
                            case "Acc_No":
                                {
                                    clist = new Acc_NoCompareList() as IComparer<JINSHINFINANCE035>;
                                }
                                break;
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
            catch (Exception ex)
            {
                string str = "";
            }
        }

        private void dgControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnUpdate_Click(new object(), null);
            }
        }

        private void AffairsFormDlg_Load(object sender, EventArgs e)
        {
            lblValue.Text = AccountingReso.yearnow.ToString();
        }

        private void AffairsFormDlg_Shown(object sender, EventArgs e)
        {
            SysRescControlVModel.SetFixedWindow(this);
        }

        private void dgControl_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 10)
            {
                if (e.Value != null)
                {
                    bool check = Convert.ToBoolean(e.Value);
                    if (check)
                        e.Value = "V";
                    else
                        e.Value = "";
                }
            }
        }
    }
}
