
using FinanceAccountProgram.Models.Config;
using JINSHIN.BUSINESS.LIBARY.Base;
using JINSHIN.FinanceAccount.Libary.VModels.AccControl;
using JINSHIN.FinanceAccount.Libary.VModels.Payment;
using JINSHIN.FinanceAccounting.DB;
using JINSHIN.Package.Libary.InvScan.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace JINSHIN.Finance.AccountSystem.FrmControl.Business.Accounts
{
    public partial class FrmRecTicketVerifyMgt : Form
    {
        public List<JINSHINFINANCE062> forms { get; set; }
        public int cnt { get; set; }
        public int curridx { get; set; }
        public string papernum { get; set; }
        public InvModel invmodel { get; set; }
        public RecTicketPaperVModel vmodel { get; set; }
        public int supplyno { get; set; }

        public FrmRecTicketVerifyMgt()
        {
            InitializeComponent();
            forms = new List<JINSHINFINANCE062>();
            cnt = 20;
            supplyno = DataClass.SupplyNo.Value;
            invmodel = new InvModel();
            vmodel = new RecTicketPaperVModel();
            vmodel.SetVerify_DGGridData(dgData, cnt);
        }
        private void Verify_Click(string papernum)
        {
            vmodel.VerifyData(DataClass.empName, txtDesc.Text, papernum);
            forms = vmodel.VerifySearchData(true, forms, txtNo.Text, txtUser.Text, txtCompany.Text, supplyno, lblNoData01, lblmoney, dgData);
        }
        private void btnMQuery_Click(object sender, EventArgs e)
        {
            forms = vmodel.VerifySearchData(true, forms, txtNo.Text, txtUser.Text, txtCompany.Text, supplyno, lblNoData01, lblmoney, dgData);
        }

        private void txtNo_KeyUp(object sender, KeyEventArgs e)
        {
            forms = vmodel.VerifySearchData(false, forms, txtNo.Text, txtUser.Text, txtCompany.Text, supplyno, lblNoData01, lblmoney, dgData);
        }

        private void txtCompany_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgData_Click(object sender, EventArgs e)
        {
            papernum = "";
            curridx = -1;
            if (dgData.CurrentRow != null)
            {
                curridx = dgData.CurrentRow.Index;
                if (dgData.CurrentRow.Cells["papernum"].Value != null)
                    papernum = dgData.CurrentRow.Cells["papernum"].Value.ToString();
                vmodel.curridx = curridx;
            }
        }

        private void dgData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                if (e.Value != null)
                {
                    e.Value = Convert.ToDateTime(e.Value).ToString("yyyy/MM/dd");
                }
            }
            if (e.ColumnIndex == 3)
            {
                if (e.Value != null)
                {
                    int type = Convert.ToInt32(e.Value);
                    switch (type)
                    {
                        case 0: e.Value= "電匯"; break;
                    }
                }
            }
            if (e.ColumnIndex == 11)
            {
                e.Value = "已收款";
            }
        }

        private void FrmRecTicketMgt_Shown(object sender, EventArgs e)
        {
            forms = vmodel.VerifySearchData(true, forms, txtNo.Text, txtUser.Text, txtCompany.Text, supplyno, lblNoData01, lblmoney, dgData);
            SysRescControlVModel.SetFixedWindow(this);
        }

        private void dgData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 11)
            {
                string papernum = dgData.Rows[e.RowIndex].Cells["papernum"].Value.ToString();
                Verify_Click(papernum);
            }
        }
    }
}
