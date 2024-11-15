
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
    public partial class FrmRecTicketMgt : Form
    {
        public List<JINSHINFINANCE062> forms { get; set; }
        public int cnt { get; set; }
        public int curridx { get; set; }
        public string papernum { get; set; }
        public InvModel invmodel { get; set; }
        public RecTicketPaperVModel vmodel { get; set; }
        public int supplyno { get; set; }

        public FrmRecTicketMgt()
        {
            InitializeComponent();
            forms = new List<JINSHINFINANCE062>();
            cnt = 20;
            supplyno = DataClass.SupplyNo.Value;
            invmodel = new InvModel();
            vmodel = new RecTicketPaperVModel(dgData, cnt);
        }

        private void btnMAdd_Click(object sender, EventArgs e)
        {
            using (FrmRecTicketPaper addform = new FrmRecTicketPaper())
            {
                addform.ShowDialog();
                forms = vmodel.SearchData(true, forms, txtNo.Text, txtUser.Text, txtCompany.Text,
                                          supplyno, lblNoData01, lblmoney, dgData);
            }
        }

        private void btnMUpdate_Click(object sender, EventArgs e)
        {
            if (dgData.CurrentRow != null)
            {
                papernum = vmodel.GetPaperNo(dgData);
                using (FrmRecTicketUpdatePaper updateform = new FrmRecTicketUpdatePaper())
                {
                    updateform.papernum = papernum;
                    updateform.ShowDialog();
                    forms = vmodel.SearchData(true, forms, txtNo.Text, txtUser.Text, txtCompany.Text, supplyno,
                                            lblNoData01, lblmoney, dgData);
                }
            }
            else
            {
                MessageBox.Show("請選擇資料!");
            }
        }

        private void btnMDelete_Click(object sender, EventArgs e)
        {
            if (vmodel.DeleteData(dgData, supplyno))
                forms = vmodel.SearchData(true, forms, txtNo.Text, txtUser.Text, txtCompany.Text, supplyno, lblNoData01, lblmoney, dgData);
        }

        private void btnCreateAcc_Click(object sender, EventArgs e)
        {
            vmodel.CreateRecAccTicketData(dgData);
            forms = vmodel.SearchData(true, forms, txtNo.Text, txtUser.Text, txtCompany.Text,
                                        supplyno, lblNoData01, lblmoney, dgData);
        }

        private void btnDeleteAcc_Click(object sender, EventArgs e)
        {
            using (PaymentControl payment = new PaymentControl())
            {
                payment.UpdateAccId(dgData);
            }
            forms = vmodel.SearchData(true, forms, txtNo.Text, txtUser.Text, txtCompany.Text, supplyno, lblNoData01, lblmoney, dgData);
        }

        private void btnMQuery_Click(object sender, EventArgs e)
        {
            forms = vmodel.SearchData(true, forms, txtNo.Text, txtUser.Text, txtCompany.Text, supplyno, lblNoData01, lblmoney, dgData);
        }

        private void txtNo_KeyUp(object sender, KeyEventArgs e)
        {
            forms = vmodel.SearchData(false, forms, txtNo.Text, txtUser.Text, txtCompany.Text, supplyno, lblNoData01, lblmoney, dgData);
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
        }

        private void FrmRecTicketMgt_Shown(object sender, EventArgs e)
        {
            forms = vmodel.SearchData(true, forms, txtNo.Text, txtUser.Text, txtCompany.Text, supplyno, lblNoData01, lblmoney, dgData);
            SysRescControlVModel.SetFixedWindow(this);
        }
    }
}
