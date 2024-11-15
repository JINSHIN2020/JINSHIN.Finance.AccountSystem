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
    public partial class FrmPayVerifyMgt : Form
    {
        private BaseGridViewCtl gridviewctl { get; set; }
        public List<JINSHINFINANCE060> forms { get; set; }
        public int cnt { get; set; }
        public int curridx { get; set; }
        public string papernum { get; set; }
        public InvModel invmodel { get; set; }
        public int supplyno { get; set; }
        public PaymentPaperVModel vmodel { get; set; }
        public FrmPayVerifyMgt()
        {
            InitializeComponent();
            forms = new List<JINSHINFINANCE060>();
            cnt = 20;
            gridviewctl = new BaseGridViewCtl();
            supplyno = DataClass.SupplyNo.Value;
            invmodel = new InvModel();
            vmodel = new PaymentPaperVModel();
            vmodel.cnt = cnt;
            
        }


        private void RefreshData()
        {
            lblNoData01.Visible = false;
            string no = txtNo.Text;
            string user = txtUser.Text;
            string company = txtCompany.Text;
            using (AccountEntityDB dbentity = new AccountEntityDB())
            {
                using (AccountEntities entity = dbentity.GetEntity())
                {
                    forms = entity.JINSHINFINANCE060.Where(i => (i.SupplyNo == supplyno) &&
                      (i.PaperNum.IndexOf(no) !=-1  || no == "") &&(i.RecPerson.IndexOf(user) !=-1 || user == "")
                      && (i.RecCompany.IndexOf(company) !=-1 || company == "") && i.VerifyDate == null
                      ).OrderByDescending(v=>v.PayDate).Take(cnt).ToList();
                }
            }
            dgData.DataSource = null;
            dgData.DataSource = forms;
            if (forms.Count > 0)
                OrderBy();
            else
                lblNoData01.Visible = true;
            if (forms.Count <(curridx +1))
                curridx = curridx -1;
            if (curridx < 0)
                curridx =0;
            dgData.CurrentCell = dgData.Rows[curridx].Cells[0];
        }

        private void OrderBy()
        {
            for (int i = 0; i < dgData.Rows.Count; i++)
            {
                dgData.Rows[i].Cells[0].Value = (i+1);
            }
        }


        private void btnMQuery_Click(object sender, EventArgs e)
        {
            forms =  vmodel.VerifySearchData(true, forms, txtNo.Text, txtUser.Text, txtCompany.Text, supplyno, lblNoData01, lblmoney, dgData);
        }

        private void FrmPayMgt_Shown(object sender, EventArgs e)
        {
            using (AccountEntityDB dbentity = new AccountEntityDB())
            {
                using (AccountEntities entity = dbentity.GetEntity())
                {
                    gridviewctl.SetGridColumns<PayFormVerify_DGItems>(dgData, new PayFormVerify_DGItems());
                    forms = entity.JINSHINFINANCE060.Where(i => i.SupplyNo == supplyno && i.VerifyDate == null)
                    .OrderByDescending(i => i.PayDate).Take(cnt).ToList();
                    dgData.DataSource = null;
                    dgData.DataSource = forms;
                    if (forms.Count >0)
                    {
                        lblmoney.Text = forms.Sum(v => v.Amount).Value.ToString("###,###,###,##0");
                    }
                    else
                        lblmoney.Text = "0";
                    OrderBy();
                   
                }
            }
            SysRescControlVModel.SetFixedWindow(this);
        }


        public void QueryData(string no ,string user,string company)
        {           
            using (AccountEntityDB dbentity = new AccountEntityDB())
            {
                using (AccountEntities entity = dbentity.GetEntity())
                {
                    forms =  entity.JINSHINFINANCE060.Where(i => (i.SupplyNo == supplyno) &&
                        (i.PaperNum.IndexOf(no) !=-1  || no == "") &&(i.RecPerson.IndexOf(user) !=-1 || user == "")
                        && (i.RecCompany.IndexOf(company) !=-1 || company == "") && i.VerifyDate == null
                        ).OrderByDescending(v=>v.PayDate).Take(cnt).ToList();
                }
            }        
        }

        private void SearchData(bool IsRefresh)
        {
            lblNoData01.Visible = false;
            string no = txtNo.Text;
            string user = txtUser.Text;
            string company = txtCompany.Text;
            List<JINSHINFINANCE060> data = default(List<JINSHINFINANCE060>);
            if (IsRefresh)
            {
               QueryData(no, user, company);
               data = forms;
            }
            else
            {
                data = forms.Where(i => (i.SupplyNo ==supplyno) &&
                (i.PaperNum.IndexOf(no) !=-1  || no == "") &&(i.RecPerson.IndexOf(user) !=-1 || user == "")
                && (i.RecCompany.IndexOf(company) !=-1 || company == "") && i.VerifyDate == null
                ).OrderByDescending(v=>v.PayDate).Take(cnt).ToList();
            }
            if (data.Count >0)
            {
                lblmoney.Text = data.Sum(v => v.Amount).Value.ToString("###,###,##0");
            }
            else
            {
                lblmoney.Text = "0";
            }
            dgData.DataSource = null;
            dgData.DataSource = data;
            if (data.Count > 0)
                OrderBy();
            else
                lblNoData01.Visible = true;
            if ((dgData.Rows.Count -1) >= curridx)
                dgData.CurrentCell = dgData.Rows[curridx].Cells[0];
        }

        private void dgData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 )
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
                        case 0:e.Value= "電匯";break;
                    }
                }
            }
            if (e.ColumnIndex == 9)
            {
                e.Value = "已付款";
            }


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


        private void txtNo_KeyUp(object sender, KeyEventArgs e)
        {
            SearchData(false);
        }
        private void Verify_Click(string papernum)
        {
            vmodel.VerifyData(DataClass.empName, txtDesc.Text, papernum);
            forms = vmodel.VerifySearchData(true, forms, txtNo.Text, txtUser.Text, txtCompany.Text, supplyno, lblNoData01, lblmoney, dgData);
        }

        private void plSearch_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                string papernum = dgData.Rows[e.RowIndex].Cells["papernum"].Value.ToString();
                Verify_Click(papernum);
            }
        }

        private void lblNoData01_Click(object sender, EventArgs e)
        {

        }
    }
}
