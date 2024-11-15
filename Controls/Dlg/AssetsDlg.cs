using JINSHIN.BUSINESS.LIBARY.Models.UControl;
using JINSHIN.FinanceAccount.Libary.Models.Forms;
using JINSHIN.FinanceAccount.Libary.VModels.AccControl;
using JINSHIN.FinanceAccount.Libary.VModels.GridView.Assets;
using JINSHIN.FinanceAccounting.DB;
using JINSHIN.FinanceAccounting.DB.VModel;
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
    public partial class AssetsDlg : Form
    {
        public string assetsname { get; set; }
        public List<JINSHINFINANCE051> values { get; set; }
        private BaseGridViewCtl gridviewctl { get; set; }
        public int cnt { get; set; }
        public AssetsDlg()
        {
            InitializeComponent();
            gridviewctl = new BaseGridViewCtl();
            cnt = 20;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            SearchData();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            SearchData();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            QueryData();
        }

        public void QueryData()
        {
            string id = txtID.Text;
            string name = txtName.Text;
            string priceval = "";
            int price = -1;
            if (txtPrice.Text != "")
            {
                price = Convert.ToInt32(txtPrice.Text);
            }
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    values =  entity.JINSHINFINANCE051.Where(i =>
                     (i.Acc_ID.IndexOf(id) != -1  || id == "")
                     && (i.AssetsName.IndexOf(name) !=-1 || name == "")
                      && (i.Price == price|| priceval == "")
                     ).Take(cnt).ToList();
                    dgData.DataSource = null;
                    dgData.DataSource = values;
                    OrderBy();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtName.Text = "";
        }

        private void OrderBy()
        {
            for (int i = 0; i < dgData.Rows.Count; i++)
            {
                dgData.Rows[i].Cells[0].Value = (i+1);
            }
        }

        private void SearchData()
        {
            string id = txtID.Text;
            string name = txtName.Text;
            string priceval = "";
            if (txtPrice.Text != "")
            {
                priceval = txtPrice.Text;
            }
            List<JINSHINFINANCE051> rs = new List<JINSHINFINANCE051>();
            bool add = false;
            bool namers = false;
            bool pricers = false;
            int datacnt = 0;
            foreach (var i in values)
            {
                add = false;
                namers = false;
                pricers = false;
                if (i.Acc_ID != null)
                {
                    add = i.Acc_ID.IndexOf(id) !=-1 || id == "";
                }
                else
                    add = true;

                if (i.AssetsName != null)
                {
                    namers = i.AssetsName.IndexOf(name) !=-1 || name == "";
                } else
                    namers = true;

                if (i.Price != null)
                {
                    pricers = i.Price.ToString().IndexOf(priceval) !=-1 || priceval == "";
                }
                else
                    pricers = true;

                if ((datacnt <= cnt) && (pricers && namers && add))
                {
                    rs.Add(i);
                    datacnt++;
                }
            }
            dgData.DataSource = null;
            dgData.DataSource = rs;
            OrderBy();
        }

        private void dgData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (FormData.values == null)
                FormData.values = new List<string>();
            else
                FormData.values.Clear();
            for (int i = 0; i <  dgData.SelectedRows.Count; i++)
            {
                FormData.values.Add(dgData.SelectedRows[i].Cells["AssetsName"].Value.ToString());
            }
            Close();
        }

        private void AssetsDlg_Shown(object sender, EventArgs e)
        {
            gridviewctl.SetGridColumns<DG_AssetsDlgItems>(dgData,new DG_AssetsDlgItems());
            QueryData();
            SysRescControlVModel.SetFixedWindow(this);
        }
    }
}
