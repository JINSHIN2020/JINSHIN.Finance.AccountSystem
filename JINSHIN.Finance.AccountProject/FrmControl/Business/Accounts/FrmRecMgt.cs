using FinanceAccountProgram.Models.Config;
using JINSHIN.BUSINESS.LIBARY.Base;
using JINSHIN.BUSINESS.LIBARY.Models.DGGridView;
using JINSHIN.BUSINESS.LIBARY.UIControls.GridView;
using JINSHIN.FinanceAccount.Libary.VModels.AccControl;
using JINSHIN.FinanceAccount.Libary.VModels.Payment;
using JINSHIN.FinanceAccounting.DB;
using JINSHIN.FinanceAccounting.DB.VModel;
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
    public partial class FrmRecMgt : Form
    {
        public List<JINSHINFINANCE061> forms { get; set; }
        public int cnt { get; set; }
        public int curridx { get; set; }
        public string papernum { get; set; }
        public InvModel invmodel { get; set; }
        public PaymentRecVModel vmodel { get; set; }
        public int supplyno { get; set; }
        public FrmRecMgt()
        {
            InitializeComponent();
            forms = new List<JINSHINFINANCE061>();
            cnt = 20;
            supplyno = DataClass.SupplyNo.Value;
            invmodel = new InvModel();
            vmodel = new PaymentRecVModel(dgData,cnt);
        }

        private void lbltitle02_Click(object sender, EventArgs e)
        {

        }

        private void btnMUpdate_Click(object sender, EventArgs e)
        {
            if (dgData.CurrentRow != null)
            {
                papernum = vmodel.GetPaperNo(dgData);
                using (FrmRecUpdatePaper updateform = new FrmRecUpdatePaper())
                {
                    updateform.papernum = papernum;
                    updateform.ShowDialog();
                    forms = vmodel.SearchData(true, forms, txtNo.Text, txtUser.Text, txtCompany.Text, supplyno, lblNoData01, lblmoney, dgData);
                }
            }
            else
            {
                MessageBox.Show("請選擇資料!");
            }
        }

        private void btnMDelete_Click(object sender, EventArgs e)
        {
            if (vmodel.DeleteData(dgData,supplyno))
                forms = vmodel.SearchData(true, forms, txtNo.Text, txtUser.Text, txtCompany.Text, supplyno, lblNoData01, lblmoney, dgData);
        }

        private void btnCreateAcc_Click(object sender, EventArgs e)
        {
            vmodel.CreateAccData(dgData);
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
           forms = vmodel.SearchData( false,forms, txtNo.Text, txtUser.Text, txtCompany.Text, supplyno,lblNoData01,lblmoney, dgData);
        }


        private void btnMAdd_Click(object sender, EventArgs e)
        {
            using (FrmRecPaper addform = new FrmRecPaper())
            {
                addform.ShowDialog();
                forms = vmodel.SearchData(true, forms, txtNo.Text, txtUser.Text, txtCompany.Text,
                                          supplyno, lblNoData01, lblmoney, dgData);
            }
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmRecMgt_Shown(object sender, EventArgs e)
        {
            forms = vmodel.SearchData(true, forms, txtNo.Text, txtUser.Text, txtCompany.Text, supplyno, lblNoData01, lblmoney, dgData);
            if (DataClass.power == 0)
            {
                btnMDelete.Visible= true;
            }
            else
            {
                btnMDelete.Visible= false;
            }
            SysRescControlVModel.SetFixedWindow(this);
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
    }
}
