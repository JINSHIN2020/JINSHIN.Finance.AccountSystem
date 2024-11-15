using JINSHIN.BUSINESS.LIBARY.Models.UControl;
using JINSHIN.FinanceAccount.Libary.Models.Assets;
using JINSHIN.FinanceAccount.Libary.VModels.AccControl;
using JINSHIN.FinanceAccount.Libary.VModels.GridView;
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
    public partial class AssetsCostInfoDlg : Form
    {
        public List<JINSHINFINANCE052> values52 { get; set; }
        public List<JINSHINFINANCE035> values35 { get; set; }
        public int datatype { get; set; }
        public int nwyear { get; set; }
        public int cnt { get; set; }
        public BaseGridViewCtl gridviewctl { get; set; }
        public AssetsCostInfoDlg()
        {
            InitializeComponent();
            cnt =20;
            gridviewctl = new BaseGridViewCtl();
        }

       

        private void SearchData35()
        {
            string id = txtID.Text;

            var data = values35.Where(i =>
             (i.Acc_ID.IndexOf(id) !=-1  || id == ""))
                .GroupBy(v=>v.Acc_ID)
                .Take(cnt).ToList();

            List<AssetsModel> val35 = new List<AssetsModel>();
            foreach (var item in data)
            {
                AssetsModel model = new AssetsModel();
                model.Acc_no = item.First().Acc_No;             
                model.Acc_ID = item.First().Acc_ID;
                model.Acc_Desc = item.First().Acc_Desc;
                model.Amount = item.Sum(v => v.Amount).Value;
                model.Cost_Date = item.First().Cost_Date.Value;
                //    model.ClassNo = item.First().ClassNo;
                val35.Add(model);
            }

            dgData.DataSource = null;
            dgData.DataSource = val35;
            OrderBy(dgData);
        }
     

        private void SearchData52()
        {
            string id = txtID.Text;

            var data = values52.Where(i =>
             (i.Acc_ID.IndexOf(id) !=-1  || id == "")).GroupBy(v => v.Acc_ID);

            List<AssetsTestCostModel> val52 = new List<AssetsTestCostModel>();
            foreach (var item in data)
            {
                AssetsTestCostModel model = new AssetsTestCostModel();
                model.AccountDate = item.First().AccountDate.Value;
                model.Item = item.First().Item;
                model.Acc_ID = item.First().Acc_ID;
                model.Acc_Desc = item.First().Acc_Desc;
                model.Amount = item.Sum(v => v.Amount).Value;
                model.Cost_Date = item.First().Cost_Date.Value;
                model.ClassNo = item.First().ClassNo;
                val52.Add(model);
            }
            dgData.DataSource = null;
            dgData.DataSource = val52;
            OrderBy(dgData);
        }

        private void OrderBy(DataGridView dg)
        {
            for (int i = 0; i < dg.Rows.Count; i++)
            {
                dg.Rows[i].Cells[0].Value = i +1;
            }
        }

        //private void TotalSum(DataGridView dg, Label lbl, string accid)
        //{
        //    double amount = 0;
        //    for (int i = 0; i < dg.Rows.Count; i++)
        //    {
        //        if (dg.Rows[i].Cells["Acc_id"].Value.ToString() == accid)
        //            amount += Convert.ToDouble(dg.Rows[i].Cells["amount"].Value);
        //    }
        //    lbl.Text = amount.ToString();
        //}

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            SearchData();
        }

        private void AssetsCostInfoDlg_Shown(object sender, EventArgs e)
        {
            if (datatype == 1)
              gridviewctl.SetGridColumns<DG_AssetsAmountDlg>(dgData, new DG_AssetsAmountDlg());
            else 
              gridviewctl.SetGridColumns<DG_AssetsAmount02Dlg>(dgData, new DG_AssetsAmount02Dlg());
            SearchData();
            SysRescControlVModel.SetFixedWindow(this);
        }

        private void SearchData()
        {
            switch (datatype)
            {
                case 1:
                    {
                        SearchData35();
                    }
                    break;
                case 2:
                    {
                        SearchData52();
                    }
                    break;
                default:
                    break;
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            SearchData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
        }
    }
}
