using FinanceAccountProgram.Models.FormMaintain;
using FinanceAccountProgram.VModel.Conrols.GridView;
using JINSHIN.BUSINESS.LIBARY.Models.UIControls;
using JINSHIN.BUSINESS.LIBARY.UIControls.GridView;
using JINSHIN.Finance.AccountSystem.Controls.Dlg;
using JINSHIN.Finance.AccountSystem.VModel.Business.Assets;
using JINSHIN.FinanceAccount.Libary.VModels.AccControl;
using JINSHIN.FinanceAccount.Libary.VModels.GridView;
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

namespace JINSHIN.Finance.AccountSystem.FrmControl.Assets
{
    public partial class FrmAssetsView : Form
    {
        public int thisyear { get; set; }
        public BaseGridViewCtl gridviewctl { get; set; }
        public GridViewBase gvbase { get; set; }
        public List<JINSHINFINANCE035> JIN35 { get; set; }
        public List<JINSHINFINANCE052> JIN52 { get; set; }
        public int curridx { get; set; }
        public FrmAssetsView()
        {
            InitializeComponent();
            gridviewctl = new BaseGridViewCtl();
            gvbase = new GridViewBase();
            JIN35 = new List<JINSHINFINANCE035>();
            JIN52 = new List<JINSHINFINANCE052>();
            this.AdjustFormScrollbars(true);
            SysRescControlVModel.Let1366ToMaxWindowSize(this);
        }

        private void plSearch_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AssetsItemsALL()
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    var data = entity.JINSHINFINANCE051
                        .Where(v => (v.IsFinance == 1 || v.IsFinance == 2) && v.IsAll != true ).ToList();
                    List<Jin051Model> values = GetModels(data);
                    dgVerifyAssetsInfo.DataSource = null;
                    dgVerifyAssetsInfo.DataSource = values;

                    if ((dgVerifyAssetsInfo.Rows.Count -1) >= curridx)
                        dgVerifyAssetsInfo.CurrentCell = dgVerifyAssetsInfo.Rows[curridx].Cells[0];
                   
                }
            }
        }

        private void AssetsItemsALLOK()
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    var data = entity.JINSHINFINANCE051
                        .Where(v => (v.IsFinance == 1 || v.IsFinance == 2) && v.IsAll == true).ToList();
                    List<Jin051Model> values = GetModels(data);
                    dgVerifyAssetsInfo.DataSource = null;
                    dgVerifyAssetsInfo.DataSource = values;
                }
            }
        }
        private void CostViewItems(string name)
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    JIN52.Clear();
                    JIN52 = entity.JINSHINFINANCE052.Where(v => 
                     v.Acc_Desc == name).OrderBy(v=>v.Cost_Date.Value.Year).ToList();
                    gridviewctl.SetGridColumns<DG_AssetsCostItem>(dgDetails, new DG_AssetsCostItem());
                    dgDetails.DataSource = null;
                    dgDetails.DataSource = JIN52;
                    OrderBy(dgDetails);
           
                }
            }
        }

        private void CostItemsViewItems(string name)
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    var lst = entity.JINSHINFINANCE052.Where(v =>
                    v.Acc_Desc == name && v.DataType == 1).OrderBy(v => v.Cost_Date.Value.Year).ToList();
                    var ids = lst.GroupBy(v => v.Acc_ID);
                    List<string> idsval = new List<string>();
                    foreach (var id in ids)
                    {
                        idsval.Add(id.First().Acc_ID);
                    }
      
                    List<JINSHINFINANCE035> values = new List<JINSHINFINANCE035>();
                    JIN35.Clear();
                    foreach (var item in idsval)
                    {
                        var datalst = entity.JINSHINFINANCE035.Where(v =>
                                 v.Acc_Desc == name && v.Acc_ID == item).GroupBy(v => v.Acc_No);
                        foreach (var v in datalst)
                        {
                            var info = v.First();
                            values.Add(info);
                        }
                    }

                    foreach (var item in values)
                    {
                        var datalst = entity.JINSHINFINANCE035.Where(v =>
                               v.Acc_Desc == name && v.Acc_No == item.Acc_No).ToList();
                        JIN35.AddRange(datalst);
                    }
                    DG_CostItems items = new DG_CostItems();
                    items.columns[1].hidden = true;
                    gridviewctl.SetGridColumns<DG_CostItems>(dgCostItems, new DG_CostItems());
                    dgCostItems.DataSource = null;
                    dgCostItems.DataSource = JIN35;
                    OrderBy(dgCostItems);
               
                }
            }
        }

        private void OrderBy(DataGridView dg)
        {
            for (int i = 0; i < dg.Rows.Count; i++)
            {
                dg.Rows[i].Cells[0].Value = i +1;
            }
        }

        private void btnSearc01_Click(object sender, EventArgs e)
        {

        }

        private void btnSearc02_Click(object sender, EventArgs e)
        {

        }

        public  List<Jin051Model> GetModels(List<JINSHINFINANCE051> data)
        {
            List<Jin051Model> rs = new List<Jin051Model>();
            using (FunctionControl func = new FunctionControl())
            {
                foreach (var item in data)
                {
                    Jin051Model val = new Jin051Model();
                    func.ClassCopyTo<JINSHINFINANCE051, Jin051Model>(item, val);                  
                    using (AccountEntityDB content = new AccountEntityDB())
                    {
                        using (AccountEntities entity = content.GetEntity())
                        {
                            var sumval = entity.JINSHINFINANCE052
                                .Where(v => v.Acc_Desc == item.AssetsName).ToList();
                            decimal datasum = sumval.Sum(i => i.Amount.Value);
                            val.AccRemainVal = datasum/2;
                            val.datamonths = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal(val.MachineYear.Value * 12)));                            
                            rs.Add(val);
                        }
                    }
                }
            }
            return rs;
        }
        private void FrmAssetsView_Shown(object sender, EventArgs e)
        {
            AccAccountsGridView accountsgridview = new AccAccountsGridView();
            accountsgridview.SetAccConfirmGridColumns(dgCostItems);
            gridviewctl.SetGridColumns<DGAssets_DataItems>(dgVerifyAssetsInfo, new DGAssets_DataItems());
            AssetsItemsALL();
            SysRescControlVModel.SetFixedWindow(this);
           
        }

        private void InsertAssetsItemsALL()
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    var data = entity.JINSHINFINANCE051.
                        Where(v => (v.IsFinance == 1 || v.IsFinance == 2) && v.IsAll != true
                        && v.Acc_ID != "9999")
                        .OrderBy(v => v.ClassNo)
                        .ThenBy(v => v.Item).ToList();

                    string assetname = "";
                    string accids = "";
                    int n64 = 0;
                    for (int i = 0; i < data.Count; i++)
                    {
                        assetname = data[i].AssetsName;
                        accids = data[i].Acc_ID;
                        var assets = entity.JINSHINFINANCE065.Where(v => v.Desc02== assetname).ToList();
                        if (assets.Count == 0)
                        {
                            var jin64 = entity.JINSHINFINANCE064.OrderBy(v => v.CDate).ToList();
                            var data_accid = entity.JINSHINFINANCE051.Where(v => v.Acc_ID == accids).ToList();

                            foreach (var v in entity.JINSHINFINANCE064.OrderBy(v => v.SN).ToList())
                            {
                                foreach (var item in data_accid)
                                {
                                    if (item.AssetsName == v.DescTitle)
                                    {
                                        n64 = v.SN;
                                        break;
                                    }
                                }
                            }
                            var setting = entity.JINSHINFINANCE065.Where(v => v.No64 == n64).ToList();
                            ComputeGridCostMoney(entity, data[i], setting);
                        }
                        else
                        {
                            ComputeGridCostMoney(entity, data[i], assets);
                        }
                    }
                    entity.SaveChanges();
                    dgVerifyAssetsInfo.DataSource = null;
                    dgVerifyAssetsInfo.DataSource = data;
                    OrderBy(dgVerifyAssetsInfo);
                }
            }
        }

        private void ComputeGridCostMoney(AccountEntities entity, JINSHINFINANCE051 data,
            List<JINSHINFINANCE065> setting)
        {
            decimal total = 0;
            if (setting.Count > 0)
            {
                setting = setting.OrderBy(v => v.No64).ToList();
                int n64 = setting[0].No64.Value;
                setting = setting.Where(v => v.No64 == n64).ToList();
                total = 0;
                string accid = "";
                for (int j = 0; j < setting.Count; j++)
                {
                    accid = setting[j].Acc_ID;
                    var jin35 = entity.JINSHINFINANCE035.Where(v => v.Acc_ID == accid  &&
                    v.Acc_Desc == data.AssetsName && v.Cost_Date.Value.Year <= thisyear).ToList();
                    total += jin35.Sum(v => v.Amount.Value);
                }
                data.RemainVal = data.Price  - data.ResidualVal;
                data.DepreciatedVal = total;
                data.ReduingAssets = data.RemainVal - total;
                data.BookValue = data.Price - data.DepreciatedVal;
            }
        }

        private void FrmAssetsView_Load(object sender, EventArgs e)
        {

        }

        private void dgVerifyAssetsInfo_SelectionChanged(object sender, EventArgs e)
        {
            string assetsname = "";
            if (dgVerifyAssetsInfo.CurrentRow.Cells["AssetsName"].Value != null)
            {
                assetsname = dgVerifyAssetsInfo.CurrentRow.Cells["AssetsName"].Value.ToString();
                CostItemsViewItems(assetsname);
                CostViewItems(assetsname);
            }
        }

        private void dgDetails_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex ==4)
            {
                if (e.Value != null)
                {
                    e.Value = Convert.ToDateTime(e.Value).Year;
                }
            }
        }

        private void dgCostItems_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex ==4)
            {
                if (e.Value != null)
                {
                    e.Value = Convert.ToDateTime(e.Value).Year;
                }
            }
        }

        private void txtAccid02_KeyUp(object sender, KeyEventArgs e)
        {
            //TotalSum(dgDetails, lblVal022, txtAccid02.Text);
        }

        private void txtAccid01_KeyUp(object sender, KeyEventArgs e)
        {
            //TotalSum(dgDetails, lblVal02,txtAccid01.Text);
        }

        private void TotalSum(DataGridView dg,Label lbl,string accid)
        {
            double amount = 0;
            for (int i = 0; i < dg.Rows.Count; i++)
            {
                if (dg.Rows[i].Cells["Acc_id"].Value.ToString() == accid)
                   amount += Convert.ToDouble(dg.Rows[i].Cells["amount"].Value);
            }
            lbl.Text = amount.ToString();
        }

        private void txtAccid001_KeyUp(object sender, KeyEventArgs e)
        {
         //   TotalSum(dgCostItems, lblVal01, txtAccid001.Text);
        }

        private void txtAccid002_KeyUp(object sender, KeyEventArgs e)
        {
         //   TotalSum(dgCostItems, lblVal011, txtAccid002.Text);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            AssetsClose(true);
        }

        private void AssetsClose(bool IsClosed)
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    for (int i = 0; i < dgVerifyAssetsInfo.SelectedRows.Count; i++)
                    {
                        string name = dgVerifyAssetsInfo.SelectedRows[i].Cells["AssetsName"].Value.ToString();
                        var jinfin51 = entity.JINSHINFINANCE051.Where(
                            v => (v.IsFinance == 1 || v.IsFinance == 2) && (v.AssetsName == name)).FirstOrDefault();
                        if (jinfin51 != null)
                        {
                            if (jinfin51.DepreciatedVal == jinfin51.RemainVal)
                            {
                                jinfin51.IsAll = IsClosed;
                            }
                        }
                    }
                    entity.SaveChanges();
                    RefreshData();
                    //AssetsItemsALL();
                }
            }
        }

        private void btnCloseData_Click(object sender, EventArgs e)
        {
            using (AssetsCostInfoDlg syssetting = new AssetsCostInfoDlg())
            {
                syssetting.datatype = 1;
                syssetting.values35 = JIN35;
                syssetting.ShowDialog();
            }
        }

        private void btnDetailData_Click(object sender, EventArgs e)
        {
            using (AssetsCostInfoDlg syssetting = new AssetsCostInfoDlg())
            {
                syssetting.datatype = 2;
                syssetting.values52 = JIN52;
                syssetting.ShowDialog();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            AssetsClose(false);
        }

        private void chOKed_CheckedChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            if (chOKed.Checked)
            {
                AssetsItemsALLOK();
            }
            else
            {
                AssetsItemsALL();
            }
        }

        private void dgVerifyAssetsInfo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 14)
            {
                if (e.Value != null)
                {
                    if (Convert.ToBoolean(e.Value))
                        e.Value = "提列完成";
                    else
                        e.Value = "尚未完成";
                }
                else
                    e.Value = "尚未完成";
            }
        }

        private void dgVerifyAssetsInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            curridx = dgVerifyAssetsInfo.CurrentRow.Index;
        }

        private void vScroll_Scroll(object sender, ScrollEventArgs e)
        {
           
        }
    }
}
