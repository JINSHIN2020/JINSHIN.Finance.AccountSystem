
using FinanceAccountProgram.Models.Config;
using JINSHIN.BUSINESS.LIBARY.Base;
using JINSHIN.BUSINESS.LIBARY.UIControls.GridView;
using JINSHIN.FinanceAccount.Libary.Models.Forms;
using JINSHIN.FinanceAccount.Libary.VModels.AccControl;
using JINSHIN.FinanceAccounting.DB;
using JINSHIN.FinanceAccounting.DB.VModel;
using JINSHIN.Work.TimeSystem.Model.GridModel;
using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JINSHIN.Work.TimeSystem.FormControl.LeaveManagement.Dlg
{
    public partial class UserDlg : Form
    {
        private BaseGridViewCtl gridviewctl { get; set; }
        public List<JINSHINFINANCE018> values { get; set; }
        public int cnt { get; set; }
        public FormData formdata { get; set; }
        public UserDlg()
        {
            InitializeComponent();
            cnt = 20;
            gridviewctl = new BaseGridViewCtl();
        }

        private void lbltitle01_Click(object sender, EventArgs e)
        {

        }

        private void UserDlg_Shown(object sender, EventArgs e)
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    gridviewctl.SetGridColumns<DlgUser_DGItems>(dgData, new DlgUser_DGItems());
                    values = entity.JINSHINFINANCE018.OrderBy(i => i.UsrNo).Take(cnt).ToList();
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

        private void dgData_Click(object sender, EventArgs e)
        {
            if (dgData.CurrentRow != null)
            {
                if (dgData.CurrentRow.Cells["UsrNO"].Value != null)
                    FormData.str01 = Convert.ToString(dgData.CurrentRow.Cells["UsrNO"].Value);
                if (dgData.CurrentRow.Cells["IdName"].Value != null)
                    FormData.str02 = Convert.ToString(dgData.CurrentRow.Cells["IdName"].Value);
                Close();
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

            var data = values.Where(i => (i.SupplyNo == DataClass.SupplyNo) &&
             (i.UsrNo.IndexOf(id) !=-1  || id == "") &&(i.IDName.IndexOf(name) !=-1 || name == "")).Take(cnt).ToList();

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
    }
}
