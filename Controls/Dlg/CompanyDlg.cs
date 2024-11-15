
using FinanceAccountProgram.Models.Config;
using JINSHIN.BUSINESS.LIBARY.UIControls.GridView;
using JINSHIN.FinanceAccount.Libary.Models.Forms;
using JINSHIN.FinanceAccount.Libary.VModels.AccControl;
using JINSHIN.FinanceAccount.Libary.VModels.GridView;
using JINSHIN.FinanceAccounting.DB;
using JINSHIN.FinanceAccounting.DB.VModel;
using JINSHIN.Work.TimeSystem.Model.GridModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JINSHIN.Finance.AccountSystem.Controls.Dlg
{
    public partial class CompanyDlg : Form
    {
        private BaseGridViewCtl gridviewctl { get; set; }
        public List<JINSHINFINANCE012> values { get; set; }
        public int cnt { get; set; }
        public FormData formdata { get; set; }
        public int formtype { get; set; }
        public CompanyDlg()
        {
            InitializeComponent();
            cnt = 20;
            gridviewctl = new BaseGridViewCtl();
        }

        private void CompanyDlg_Shown(object sender, EventArgs e)
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    gridviewctl.SetGridColumns<DlgCompany_DGItems>(dgData, new DlgCompany_DGItems());
                    values = entity.JINSHINFINANCE012.OrderBy(i => i.IdNo).Take(cnt).ToList();
                    dgData.DataSource = null;
                    dgData.DataSource = values;
                    dgData.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    FormData.str01 = "";
                    FormData.str02 = "";
                    OrderBy();
                }
            }
            SysRescControlVModel.SetFixedWindow(this);
        }
        private void OrderBy()
        {
            for (int i = 0; i < dgData.Rows.Count; i++)
            {
                dgData.Rows[i].Cells[0].Value = (i+1);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtName.Text = "";
        }

        private void SearchData()
        {
            string id = txtID.Text;
            string name = txtName.Text;

            var data = values.Where(i => 
             (i.IdNo.IndexOf(id) != -1  || id == "") &&(i.Supply.IndexOf(name) !=-1 || name == "")).Take(cnt).ToList();

            dgData.DataSource = null;
            dgData.DataSource = data;
            OrderBy();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            SearchData();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            SearchData();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            SearchData();
        }

        private void dgData_Click(object sender, EventArgs e)
        {
            if (dgData.CurrentRow != null)
            {
                if (formtype == 1)
                {
                    if (dgData.CurrentRow.Cells["BankIdRec"].Value != null)
                        FormData.str01 = Convert.ToString(dgData.CurrentRow.Cells["BankIdRec"].Value);
                    if (dgData.CurrentRow.Cells["AccAccountRec"].Value != null)
                        FormData.str02 = Convert.ToString(dgData.CurrentRow.Cells["AccAccountRec"].Value);
                }
                else
                {
                    if (dgData.CurrentRow.Cells["BankIdPay"].Value != null)
                        FormData.str01 = Convert.ToString(dgData.CurrentRow.Cells["BankIdPay"].Value);
                    if (dgData.CurrentRow.Cells["AccAccountPay"].Value != null)
                        FormData.str02 = Convert.ToString(dgData.CurrentRow.Cells["AccAccountPay"].Value);
                }
                Close();
            }
        }
    }
}
