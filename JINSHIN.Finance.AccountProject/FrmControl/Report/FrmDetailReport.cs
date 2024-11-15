using FinanceAccountProgram.Models.Config;
using FinanceAccountProgram.VModel.Business;
using FinanceAccountProgram.VModel.Conrols.GridView;
using JINSHIN.BUSINESS.LIBARY.UIControls.GridView;
using JINSHIN.Finance.AccountSystem.VModel.Conrols.GridView;
using JINSHIN.FinanceAccount.Libary.Config;
using JINSHIN.FinanceAccount.Libary.Models.Financial;
using JINSHIN.FinanceAccount.Libary.VModels.AccControl;
using JINSHIN.FinanceAccount.Libary.VModels.CountryTax;
using JINSHIN.FinanceAccounting.DB;
using JINSHIN.FinanceAccounting.DB.VModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JINSHIN.Finance.AccountSystem.FrmControl.Report
{
    public partial class FrmDetailReport : Form
    {
        DetailReportVModel vmodel = new DetailReportVModel();
        public PathModel pathmodel { get; set; }
        public FrmDetailReport()
        {
            InitializeComponent();
            pathmodel = new PathModel();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private List<JINSHINFINANCE035> GetAccountData(List<JINSHINFINANCE035> datalist)
        {
            using (FinancialRptVModel financial = new FinancialRptVModel())
            {
                return datalist = financial.CheckOK(datalist);
            }
        }

        private void btnInquire_Click(object sender, EventArgs e)
        {
            DetailReportVModel vmodel = new DetailReportVModel();
            List<AccidAccount> rs = LoadData();
            List<JINSHINFINANCE035> view = new List<JINSHINFINANCE035>();            
            view = vmodel.control.GetCostItemList(AccountingReso.yearnow, rs);
            view = GetAccountData(view);
            using (AccNoGridView col = new AccNoGridView())
            {
                col.SetAccConfirmGridColumns(dgList);
                dgList.DataSource = null;
                dgList.DataSource = view;
            }
        }

       

        private List<AccidAccount> LoadData()
        {
            List<AccidAccount> rs = new List<AccidAccount>();
            using (AccLedgerGridView gridview = new AccLedgerGridView())
            {
                switch (lstType.SelectedIndex)
                {
                    case 0:
                        {
                            rs = vmodel.GetSaleCostList();
                        }
                        break;
                    case 1:
                        {
                            rs = vmodel.GetOperatingExpensesList();
                        }
                        break;
                    case 2:
                        {
                            List<JINSHINFINANCE035> values = vmodel.GetCostList("6130");
                            rs.Clear();
                            foreach (var item in values)
                            {
                                rs.Add(new AccidAccount() {
                                 AccID = item.Acc_ID,
                                 datatypectl = Convert.ToInt32(item.DataType),
                                 amount = item.Amount.Value
                                });
                            }
                        }
                        break;
                    case 3: {
                            int year = 2021;
                            string accid = "6134";
                            using (AccountEntityDB db = new AccountEntityDB())
                            {
                                using (AccountEntities entity = db.GetEntity())
                                {
                                    var accnos = entity.JINSHINFINANCE035.Where(i =>
                                                 i.Cost_Date.Value.Year == year &&
                                                 i.Acc_ID == accid)
                                                 .GroupBy(i => i.Acc_No).ToList();
                                    int sn = 1;
                                    foreach (var item in accnos)
                                    {
                                        rs.Add(new AccidAccount()
                                        {
                                            AccID = item.First().Acc_ID,
                                            datatypectl = Convert.ToInt32(item.First().DataType),
                                            amount = item.First().Amount.Value,
                                            AccDesc = item.First().Acc_Desc,
                                            costdate = item.First().Cost_Date.Value,
                                            Sn = sn
                                        });
                                        sn++;
                                    }
                                }
                            }
                        }
                        break;
                    default:
                        break;
                }
                dgData.DataSource = null;
                gridview.SetAccConfirmGridColumns(dgData);
                dgData.DataSource = rs;
                return rs;
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            using (GridViewBase grid = new GridViewBase())
            {
                grid.ExportDataGridView(pathmodel.ReportPath, 
                    "Total_Report01_" + lstType.Text, dgData);
                grid.ExportDataGridView(pathmodel.ReportPath,
                   "Detail_Report02_" + lstType.Text, dgList);
            }
        }

        private void FrmDetailReport_Shown(object sender, EventArgs e)
        {
            List<JINSHINFINANCE035> rs = new List<JINSHINFINANCE035>();
            using (AccNoGridView gridview = new AccNoGridView())
            {
                List<AccidAccount> data = vmodel.GetSaleCostList();   
                
                dgData.DataSource = null;
                gridview.SetAccConfirmGridColumns(dgData);
                dgData.DataSource = rs;
                if (vmodel.control.msg != null)
                    lstmsg.Items.Add(vmodel.control.msg);
            }
            SysRescControlVModel.SetFixedWindow(this);
        }

        private void FrmDetailReport_Load(object sender, EventArgs e)
        {

        }

        private void dgData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
