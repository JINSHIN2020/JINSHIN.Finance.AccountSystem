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
    public partial class FrmPayMgt : Form
    {
        private BaseGridViewCtl gridviewctl { get; set; }
        public List<JINSHINFINANCE060> forms { get; set; }
        public int cnt { get; set; }
        public int curridx { get; set; }
        public string papernum { get; set; }
        public InvModel invmodel { get; set; }
        public int supplyno { get; set; }
        public FrmPayMgt()
        {
            InitializeComponent();
            forms = new List<JINSHINFINANCE060>();
            cnt = 20;
            gridviewctl = new BaseGridViewCtl();
            supplyno = DataClass.SupplyNo.Value;
            invmodel = new InvModel();
        }

        private void btnMAdd_Click(object sender, EventArgs e)
        {
            using (FrmPayPaper addform = new FrmPayPaper())
            {
                addform.ShowDialog();
                RefreshData();
            }
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
                      && (i.RecCompany.IndexOf(company) !=-1 || company == "")
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
            if (forms.Count > 0)
                dgData.CurrentCell = dgData.Rows[curridx].Cells[0];
        }

        private void btnMUpdate_Click(object sender, EventArgs e)
        {
            if (dgData.CurrentRow != null)
            {
                if (dgData.CurrentRow.Cells["papernum"].Value != null)
                    papernum = dgData.CurrentRow.Cells["papernum"].Value.ToString();

             
                using (Frm_UPayPaper updateform = new Frm_UPayPaper())
                {
                    updateform.papernum = papernum;
                    updateform.ShowDialog();
                    RefreshData();
                }
            }
            else
            {
                MessageBox.Show("請選擇資料!");
            }
        }

        private void OrderBy()
        {
            for (int i = 0; i < dgData.Rows.Count; i++)
            {
                dgData.Rows[i].Cells[0].Value = (i+1);
            }
        }


        private void btnMDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確認要刪除?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (AccountEntityDB dbentity = new AccountEntityDB())
                {
                    using (AccountEntities entity = dbentity.GetEntity())
                    {
                        string nwno = "";
                        object no = dgData.CurrentRow.Cells["papernum"].Value;
                        if (no != null)
                            nwno = no.ToString();
                        var form = entity.JINSHINFINANCE060.Where(i => i.PaperNum == nwno && i.SupplyNo == supplyno).FirstOrDefault();
                        if (form != null)
                        {
                            entity.JINSHINFINANCE060.Remove(form);
                            entity.SaveChanges();
                            RefreshData();
                        }
                        else
                        {
                            MessageBox.Show("請選擇資料!");
                        }
                    }
                }
            }
        }

        private void btnMQuery_Click(object sender, EventArgs e)
        {
            SearchData(true);
        }

        private void FrmPayMgt_Shown(object sender, EventArgs e)
        {
            using (AccountEntityDB dbentity = new AccountEntityDB())
            {
                using (AccountEntities entity = dbentity.GetEntity())
                {
                    gridviewctl.SetGridColumns<PayForm_DGItems>(dgData, new PayForm_DGItems());
                    forms = entity.JINSHINFINANCE060.Where(i => i.SupplyNo == supplyno)
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

                    if (DataClass.power == 0)
                    {
                        btnMDelete.Visible= true;
                    }
                    else
                    {
                        btnMDelete.Visible= false;
                    }
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
                        && (i.RecCompany.IndexOf(company) !=-1 || company == "")
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
                && (i.RecCompany.IndexOf(company) !=-1 || company == "")
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

        private void btnCreateAcc_Click(object sender, EventArgs e)
        {
            double amount = 0;
            if (dgData.CurrentRow != null)
            {
                if (dgData.CurrentRow.Cells["papernum"].Value != null)
                    papernum = dgData.CurrentRow.Cells["papernum"].Value.ToString();
                if (dgData.CurrentRow.Cells["amount"].Value != null)
                    amount = Convert.ToDouble(dgData.CurrentRow.Cells["amount"].Value);
            }
            using (PaymentControl payment = new PaymentControl())
            {
                payment.CreateAccPayAccount(DateTime.Now,papernum,amount);
            }
            RefreshData();
        }

        private void btnDeleteAcc_Click(object sender, EventArgs e)
        {
            using (PaymentControl payment = new PaymentControl())
            {
                string no = "";
                decimal amountval = 0;
                object accno = dgData.CurrentRow.Cells["accno"].Value;
                object amount = dgData.CurrentRow.Cells["amount"].Value;
                if (accno != null)
                    no = dgData.CurrentRow.Cells["accno"].Value.ToString();
                if (amount != null)
                {
                    amountval = Convert.ToDecimal(dgData.CurrentRow.Cells["amount"].Value);
                }
                if (no!="")
                {
                    payment.UpdateAccAcount(no, amountval);
                    
                }
                else
                    MessageBox.Show("請先建立帳務！");
                RefreshData();
            }
        }

        private void txtNo_KeyUp(object sender, KeyEventArgs e)
        {
            SearchData(false);
        }

        private void plSearch_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmPayMgt_Load(object sender, EventArgs e)
        {

        }
    }
}
