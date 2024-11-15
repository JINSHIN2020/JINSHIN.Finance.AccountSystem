using FinanceAccountProgram.Models.Config;
using JINSHIN.Finance.AccountSystem.Resources;
using JINSHIN.FinanceAccounting.DB;
using FinanceAccountProgram.VModel;
using FinanceAccountProgram.VModel.Conrols;
using FinanceAccountProgram.VModel.Conrols.GridView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinanceAccountProgram.VModel.Conrols.ManageForm;
using JINSHIN.BUSINESS.LIBARY.Resources;
using JINSHIN.BUSINESS.LIBARY.UIControls.GridView;
using JINSHIN.FinanceAccount.Libary.Config;
using JINSHIN.FinanceAccount.Libary.VModels;
using JINSHIN.FinanceAccounting.DB.VModel;
using JINSHIN.Finance.AccountSystem.Models.VerifyModel;
using JINSHIN.BUSINESS.LIBARY.Models.UIControls;
using JINSHIN.FinanceAccount.Libary.VModels.AccControl;

namespace FinanceAccountProgram.FrmControl
{
    public partial class FrmDiaryVerify : Form
    {
        public PathModel pathmodel { get; set; }
        public FrmDiaryVerify()
        {
            InitializeComponent();
            dgQueryData.Font = new System.Drawing.Font(DataControl.DataGridFont, Convert.ToInt32(DataControl.DataGridFontSize));
            using (FormControlVModel ctlmodel = new FormControlVModel())
            {
                ctlmodel.ControlResolution(this);
            }
            pathmodel = new PathModel();

            SysRescControlVModel.Let1366ToMaxWindowSize(this);
        }

        private List<JINSHINFINANCE035> GetYearMonthCostItem(AccountEntities entity, int year, int month)
        {
            var list = entity.JINSHINFINANCE035.Where(o => o.Cost_Date.Value.Year == year
            && o.Cost_Date.Value.Month == month).OrderBy(o => o.Acc_No).ThenBy(o => o.DataType).ToList();
            return list;
        }
        private void btnQuery_Click(object sender, EventArgs e)
        {
            int year = int.Parse(txQueryAccYear.Text);
            int month = int.Parse(txQueryAccMonth.Text);
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    List<JINSHINFINANCE035> list = GetYearMonthCostItem(entity, year, month);   
                    int sn = 1;
                    foreach (var item in list)
                    {
                        item.SN = sn;
                        sn++;
                    }
                    var query = entity.JINSHINFINANCE032.Where(o => o.Acc_Date.Value.Year == year).ToList();
                    if (list.Count > 0)
                    {
                        using (AccLedgerAccount ctl = new AccLedgerAccount())
                        {
                            List<string> rs = ctl.GetDisplayString(list);
                            lblBookGet.Text = rs[0];
                            lblBookLend.Text = rs[1];
                        }
                        AccAccountsGridView accountsgridview = new AccAccountsGridView();
                        dgQueryData.DataSource = list;
                        accountsgridview.SetAccConfirmGridColumns(dgQueryData);
                    }
                    else
                    {
                        MessageBox.Show("沒有資料");
                    }
                }
            }
        }

        private void btnDeleteQueryAcc_Click(object sender, EventArgs e)
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    int year = int.Parse(txQueryAccYear.Text);
                    int month = int.Parse(txQueryAccMonth.Text);
                    List<JINSHINFINANCE035> vals = new List<JINSHINFINANCE035>();
                    if (chQueryAcc.Checked)
                    {
                        vals = entity.JINSHINFINANCE035.Where(o => o.Cost_Date.Value.Year == year
                         && o.Cost_Date.Value.Month == month && o.Status == coststatus.diaryaccount).ToList();
                    }
                    else
                        vals = entity.JINSHINFINANCE035.Where(o => o.Cost_Date.Value.Year == year
                    && o.Cost_Date.Value.Month == month && o.Status == coststatus.accountcreated).ToList();
                    entity.JINSHINFINANCE035.RemoveRange(vals);
                    if (MessageBox.Show("是否刪除!","",MessageBoxButtons.OKCancel) == DialogResult.OK )
                    {
                        entity.SaveChanges();
                    }
                }
            }
        }

        private void btnDiaryCreate_Click(object sender, EventArgs e)
        {
            int year = int.Parse(txQueryAccYear.Text);
            int month = int.Parse(txQueryAccMonth.Text);
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    List<JINSHINFINANCE035> list = GetYearMonthCostItem(entity, year, month);
                    foreach (var item in list)
                    {
                        item.Status = coststatus.diaryaccount;
                    }
                    entity.SaveChanges();
                }
            }
        }

        private void btnDiaryExport_Click(object sender, EventArgs e)
        {
            using (GridViewBase grid = new GridViewBase())
            {
                grid.ExportDataGridView(pathmodel.exportPath, "Diary_Data_", dgQueryData);
            }
        }

        private void FrmDiaryVerify_Load(object sender, EventArgs e)
        {
            txQueryAccYear.Text = AccountingReso.yearnow.ToString();
            txQueryAccMonth.Text = DateTime.Now.Month.ToString();
        }

        private void FrmDiaryVerify_Shown(object sender, EventArgs e)
        {            
            SysRescControlVModel.SetFixedWindow(this);
        }
    }
}
