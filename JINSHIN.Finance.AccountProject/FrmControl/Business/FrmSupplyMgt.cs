
using FinanceAccountProgram.Models.Config;
using JINSHIN.BUSINESS.LIBARY.Base;
using JINSHIN.Finance.AccountSystem.FrmControl.Business.CompanyMgt;
using JINSHIN.FinanceAccount.Libary.VModels.AccControl;
using JINSHIN.FinanceAccount.Libary.VModels.Info;
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

namespace JINSHIN.Finance.AccountSystem.FrmControl.Business
{
    public partial class FrmSupplyMgt : Form
    {
        public List<JINSHINFINANCE012> forms { get; set; }
        public int cnt { get; set; }
        public int curridx { get; set; }
        public string papernum { get; set; }
        public InvModel invmodel { get; set; }
        public CompanyInfoVModel vmodel { get; set; }
        public int no { get; set; }
        public int supplyno { get; set; }

        public FrmSupplyMgt()
        {
            InitializeComponent();
            forms = new List<JINSHINFINANCE012>();
            cnt = 20;
            supplyno = DataClass.SupplyNo.Value;
            invmodel = new InvModel();
            vmodel = new CompanyInfoVModel(dgData, cnt);
        }

        private void btnMAdd_Click(object sender, EventArgs e)
        {
            using (FrmCompany addform = new FrmCompany())
            {
                addform.ShowDialog();
                forms = vmodel.SearchData(true, forms,  txtUser.Text, txtCompany.Text, txtAddress.Text,
                                           lblNoData01, lblmoney, dgData);
            }
        }

        private void btnMUpdate_Click(object sender, EventArgs e)
        {
            if (dgData.CurrentRow != null)
            {
                no = Convert.ToInt32(dgData.CurrentRow.Cells["no"].Value);                
                using (FrmCompanyUpdate updateform = new FrmCompanyUpdate())
                {
                    updateform.supplyno = no;
                    updateform.ShowDialog();
                    forms = vmodel.SearchData(true, forms, txtUser.Text, txtCompany.Text, txtAddress.Text,
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
            no = Convert.ToInt32(dgData.CurrentRow.Cells["no"].Value);
            if (vmodel.DeleteData(dgData, no))
            {             
                forms = vmodel.SearchData(true, forms,  txtUser.Text, txtCompany.Text, txtAddress.Text,
                                            lblNoData01, lblmoney, dgData);
            }
        }

        private void btnMQuery_Click(object sender, EventArgs e)
        {
            forms = vmodel.SearchData(true, forms, txtUser.Text, txtCompany.Text, txtAddress.Text,
                                           lblNoData01, lblmoney, dgData);
        }

        private void txtNo_KeyUp(object sender, KeyEventArgs e)
        {
            forms = vmodel.SearchData(false, forms, txtUser.Text, txtCompany.Text, txtAddress.Text,
                                                    lblNoData01, lblmoney, dgData);
        }

        private void dgData_Click(object sender, EventArgs e)
        {
            curridx = -1;
            if (dgData.CurrentRow != null)
            {
                curridx = dgData.CurrentRow.Index;
                vmodel.curridx = curridx;
            }
        }

        private void FrmSupplyMgt_Shown(object sender, EventArgs e)
        {
            forms = vmodel.SearchData(true, forms, txtUser.Text, txtCompany.Text, txtAddress.Text,
                                          lblNoData01, lblmoney, dgData);
            SysRescControlVModel.SetFixedWindow(this);
        }

        private void FrmSupplyMgt_Load(object sender, EventArgs e)
        {

        }
    }
}
