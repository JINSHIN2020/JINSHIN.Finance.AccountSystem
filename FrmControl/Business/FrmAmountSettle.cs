using JINSHIN.Finance.AccountSystem.Resources;
using JINSHIN.FinanceAccounting.DB;
using FinanceAccountProgram.VModel;
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
using JINSHIN.FinanceAccount.Libary.Config;
using FinanceAccountProgram.VModel.AddQueryForm;
using JINSHIN.FinanceAccount.Libary.Models.Base;
using JINSHIN.FinanceAccount.Libary.VModels.AccControl;

namespace FinanceAccountProgram.FrmControl
{
    public partial class FrmAmountSettle : Form
    {
        public Acc_CostDataQuery ctl01 { get;set;}
        public AddQueryEnum datatype { get; set; }
        public FrmAmountSettle()
        {
            InitializeComponent();
         
            using (FormControlVModel ctlmodel = new FormControlVModel())
            {
                ctlmodel.ControlResolution(this);
                SysRescControlVModel.Let1366ToSuitWidth(this);
            }
        }

        private void ShowLegerData()
        {
            using (AccLedgerAccount acc_account = new AccLedgerAccount())
            {
                List<JINSHINFINANCE040> values = acc_account.GetData(AccountingReso.yearnow);
                List<string> rs = acc_account.GetDisplayString(values);
                dgLedger.DataSource = values;
                using (AccCostLedgerGridView gridview = new AccCostLedgerGridView())
                {
                    gridview.SetAccConfirmGridColumns(dgLedger);
                }
                dgLedger.Refresh();
                SetTextDisplay(rs);
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            lblTtlCount.Visible = false;
            using (AccLedgerAccount ctl = new AccLedgerAccount())
            {
                List<JINSHINFINANCE040> data = new List<JINSHINFINANCE040>();
                int nw = AccountingReso.yearnow;
				List<string> rs = ctl.SaveData(data, true, nw);
                SetTextDisplay(rs);
            }
            ShowLegerData();
        }
        private void SetTextDisplay(List<string> rs)
        {
            if (rs.Count > 0)
            {
                lblLedgerGetVal.Text = rs[0];
                lblLedgerLend.Text = rs[1];
                lblLedgerResult.Text = rs[2];
            }
        }

        private void FrmAmountSettle_Load(object sender, EventArgs e)
        {
            lblTtlCount.Visible = false;
            dgLedger.Font = new System.Drawing.Font(DataControl.DataGridFont, Convert.ToInt32(DataControl.DataGridFontSize));
        }

        private void btnALegerQuery_Click(object sender, EventArgs e)
        {
            lblTtlCount.Visible = false;
            ShowLegerData();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            datatype = AddQueryEnum.Acc_CostData;
            ctl01 = new Acc_CostDataQuery();
            ctl01.dbclass = new DBClassCtl();
            List<JINSHINFINANCE035> data = new List<JINSHINFINANCE035>();
            List<string> msg = ctl01.SaveData(data, AddQueryAutoDelete.IsCostDataQueryDelete);
            lblTtlCount.Visible = true;
            lblTtlCount.Text = msg[0];  
        }

        private void FrmAmountSettle_Shown(object sender, EventArgs e)
        {
            lblNwYearValue.Text = AccountingReso.yearnow.ToString();
            SysRescControlVModel.SetFixedWindow(this);
        }

        private void lblYear_Click(object sender, EventArgs e)
        {

        }

        private void dgLedger_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                if (e.Value != null)
                {
                    e.Value = Convert.ToDateTime(e.Value).Year;
                }
            }
        }
    }
}
