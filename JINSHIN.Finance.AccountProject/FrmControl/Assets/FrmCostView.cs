using FinanceAccountProgram.Models.Assets;
using FinanceAccountProgram.Models.Config;
using FinanceAccountProgram.Models.FormMaintain;
using FinanceAccountProgram.Models.UControl;
using FinanceAccountProgram.Models.VerifyModel;
using FinanceAccountProgram.VModel.AddQueryDataForm;
using FinanceAccountProgram.VModel.AddQueryForm;
using FinanceAccountProgram.VModel.Conrols.GridView;
using FinanceAccountProgram.VModel.FormMaintain;
using JINSHIN.BUSINESS.LIBARY.Models.UIControls;
using JINSHIN.BUSINESS.LIBARY.UIControls.GridView;
using JINSHIN.FinanceAccount.Libary.Config;
using JINSHIN.FinanceAccount.Libary.Config.UpdataeForm;
using JINSHIN.FinanceAccount.Libary.Models.Assets;
using JINSHIN.FinanceAccount.Libary.VModels.AccControl;
using JINSHIN.FinanceAccount.Libary.VModels.Assets;
using JINSHIN.FinanceAccount.Libary.VModels.GridView;
using JINSHIN.FinanceAccount.Libary.VModels.GridView.Assets;
using JINSHIN.FinanceAccounting.DB;
using JINSHIN.FinanceAccounting.DB.VModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JINSHIN.Finance.AccountSystem.FrmControl.Assets
{
    public partial class FrmCostView : Form
    {
        private PathModel pathmodel { get; set; }
        public string exportAssetsCost { get; set; }
        public Acc_AssetsCtl assets_ctl { get; set; }
        public Acc_VModel Accctl;
        public BaseGridViewCtl gridviewctl { get; set; }
        public int thisyear { get; set; }
        public GridViewBase gvbase { get; set; }
        public FrmCostView()
        {
            InitializeComponent();
            gridviewctl = new BaseGridViewCtl();
            pathmodel = new PathModel();
            exportAssetsCost = @"AssetsControl\";
            exportAssetsCost = pathmodel.exportPath + exportAssetsCost;
            gvbase = new GridViewBase();
            Accctl = new Acc_VModel();
            Accctl.ctl05 = new Acc_AssetsCtl();
            assets_ctl = new Acc_AssetsCtl();
            assets_ctl.SetInitNew();
            dgVerifyAssetsInfo.AutoGenerateColumns = false;
            this.AdjustFormScrollbars(true);
            SysRescControlVModel.Let1366ToMaxWindowSize(this);
        }

        private static List<AssetsAccClass> GetAssetsClassName()
        {
            List<AssetsAccClass> accname = new List<AssetsAccClass>();
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    var asset_title = entity.JINSHINFINANCE064.ToList();
                    var assetdata = entity.JINSHINFINANCE051.ToList();
                    foreach (var item in asset_title)
                    {
                        var datalst = entity.JINSHINFINANCE065.Where(v => v.No64 == item.SN).ToList();
                        var info = assetdata.Where(v => v.AssetsName == item.DescTitle).FirstOrDefault();
                        if (info != null)
                        {
                            foreach (var v in datalst)
                            {
                                accname.Add(new AssetsAccClass() {
                                    acc_id_Add = info.Acc_ID,
                                    acc_id_Red = v.Acc_ID,
                                    assetsname = info.AssetsName
                                });
                            }
                        }
                    }
                }
            }          
            return accname;
        }


        private void InsertAssetsItemsALL()
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    thisyear = Convert.ToInt32(txtYear.Text);
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


        private void AssetsItemsALL()
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    thisyear = Convert.ToInt32(txtYear.Text);
                    var data = entity.JINSHINFINANCE051.
                        Where(v => (v.IsFinance == 1 || v.IsFinance == 2) && v.IsAll != true
                        && v.Acc_ID != "9999")
                        .OrderBy(v => v.ClassNo)
                        .ThenBy(v => v.Item).ToList();
            
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

        private void btnCreateData_Click(object sender, EventArgs e)
        {
            AssetsAccClassVModel ctl = new AssetsAccClassVModel();
            if (AddQueryAutoDelete.IsAssetsAccountArgDelete)
            {
                ctl.RefreshDel();
            }
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    List<AssetsAccClass> accname = GetAssetsClassName();
                    var assets_data = new AssetsCostModel();
                    assets_data = ctl.GetAssetsAccClassVModel(entity, accname);
                    int SN = 1;
                    int idx = 0;
                    List<int> years = new List<int>();
                    List<AssetsData> moneys = default(List<AssetsData>);
                    List<string> values = new List<string>();
                    JINSHINFINANCE052 assets_cost = new JINSHINFINANCE052();
                    try
                    {
                        foreach (var item in assets_data.AddModels)
                        {
                            years.Clear();                            
                            moneys = item.ComputeDepreciationVal(item.val, years);
                            idx = 0;
                            int ttlmonth = 0;
                            int monthcost = 0;
                            if (moneys.Count > 0)
                            {
                                ttlmonth = Convert.ToInt32(moneys[moneys.Count -1].months);
                                monthcost = Convert.ToInt32(moneys[0].monthcost);
                            }
                            var jin51=entity.JINSHINFINANCE051.Where(v=>v.No==item.val.No
                            && (v.IsFinance == 1 || v.IsFinance == 2)
                            ).FirstOrDefault();  

                            jin51.MonthUsed =  ttlmonth;
                            jin51.DepreciationVal = monthcost;
                            jin51.Months = Convert.ToInt32(jin51.MachineYear *12);
                            values.Add(ttlmonth + "," + monthcost.ToString());
                            foreach (var y in moneys)
                            {
                                foreach (var i in item.acc_account)
                                {
                                    assets_cost = new JINSHINFINANCE052();
                                    assets_cost.Acc_Desc = item.val.AssetsName;
                                    assets_cost.Cost_Date = item.val.BuyDate;
                                    assets_cost.AccountDate = new DateTime(years[idx], 12, 31);
                                    assets_cost.Cost_M = item.val.BuyDate.Value.Month;
                                    assets_cost.ClassNo = item.val.ClassNo;
                                    assets_cost.CreateTime = DateTime.Now;
                                    assets_cost.Item = SN;
                                    assets_cost.Acc_ID = i.acc_id;
                                    assets_cost.DataType = i.datatype;
                                    assets_cost.Amount = y.data;
                                    if (y.data != 0)                                        
                                        entity.JINSHINFINANCE052.Add(assets_cost);
                                    entity.SaveChanges();
                                    SN++;
                                }
                                idx++;
                            }
                        }                       
                    }
                    catch (Exception ex)
                    {
                        string str = ex.ToString();
                    }
                    finally
                    {
                        ctl.Dispose();

                    }
                }
            }
            InsertAssetsItemsALL();
        }

        private void btnVerifyAssetsData_Click(object sender, EventArgs e)
        {
            Msg.Items.Clear();
            CostViewItems(txtDataName.Text);
            CostItemDataView(txtDataName.Text);

            int year = Convert.ToInt32(txtYear.Text);
            Msg.Items.Add(year.ToString() + "年" + "資產數量為" + dgVerifyAssetsInfo.Rows.Count.ToString());
            Msg.Items.Add(year.ToString() + "年" + "應攤提折舊數量為" + (dgDetails.Rows.Count /2).ToString());
            Msg.Items.Add(year.ToString() + "年" +  "尚應攤提折舊數量為" + (dgCompare.Rows.Count/2).ToString());

        }

        private void btnAssetsExport_Click(object sender, EventArgs e)
        {
            string path = "";
            using (GridViewBase grid = new GridViewBase())
            {
                path = "AccAssets_";
                grid.ExportDataGridView(pathmodel.exportPath, path, dgVerifyAssetsInfo);
                path = "AccAssets_Cost";
                grid.ExportDataGridView(pathmodel.exportPath, path, dgDetails);
            }
        }

        private void dgVerifyAssetsInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CostViewItems(txtDataName.Text);
        }


        private void CostItemDataView(string dataname)
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    thisyear = Convert.ToInt32(txtYear.Text);
                    List<JINSHINFINANCE052> rs = new List<JINSHINFINANCE052>();
                    var data = entity.JINSHINFINANCE052.Where(v => v.AccountDate.Value.Year == thisyear
                    && (v.Acc_Desc.IndexOf(dataname) != -1 || dataname == "" )
                    ).ToList();
                    var lst = entity.JINSHINFINANCE035.Where(v => v.Cost_Date.Value.Year == thisyear).ToList();
                    foreach (var item in data)
                    {
                        foreach (var v in lst)
                        {
                            if ((v.Acc_Desc == item.Acc_Desc && v.Amount == item.Amount) )
                            {                
                               
                               rs.Add(item);
                            }
                        }
                    }
                    //建立view                   
                    foreach (var item in rs)
                    {                       
                         data.Remove(item);                     
                    }                        
                    gridviewctl.SetGridColumns<DG_CostItems>(dgCompare, new DG_CostItems());
                    dgCompare.DataSource = null;
                    dgCompare.DataSource = data;
                    OrderBy(dgCompare);
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
        private void CostViewItems(string dataname)
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    thisyear = Convert.ToInt32(txtYear.Text);
                    var lst = entity.JINSHINFINANCE052.Where(v => v.AccountDate.Value.Year == thisyear
                    && (v.Acc_Desc.IndexOf(dataname) != -1 || dataname == "")
                    ).ToList();
                    var assets = entity.JINSHINFINANCE051.Where(v=>(v.IsAll == null || v.IsAll != true)
                    && (v.IsFinance == 1 || v.IsFinance == 2) && (v.Acc_ID != "9999")
                    ).ToList();

                    List<JINSHINFINANCE051> rs = new List<JINSHINFINANCE051>();
                    bool isget = false;
                    foreach (var item in assets)
                    {
                        isget = false;
                        foreach (var v in lst)
                        {
                            if (item.AssetsName == v.Acc_Desc)
                            {
                                isget = true;
                            }
                        }
                        if (!isget)
                        {
                            rs.Add(item);
                        }
                    }
                  
                    dgDetails.DataSource = null;
                    dgDetails.DataSource = lst;
                    dgdiffdata.DataSource = null;
                    dgdiffdata.DataSource = rs;
                    OrderBy(dgDetails);
                    OrderBy(dgdiffdata);
                }
            }
        }

        private void FrmCostView_Shown(object sender, EventArgs e)
        {
            txtYear.Text = DateTime.Now.Year.ToString();
            gridviewctl.SetGridColumns<DG_CostItems>(dgDetails, new DG_CostItems());
            gridviewctl.SetGridColumns<DG_AssetsViewItems>(dgVerifyAssetsInfo,
                new DG_AssetsViewItems());
            gridviewctl.SetGridColumns<DG_AssetsDiffViewDGItems>(dgdiffdata,
              new DG_AssetsDiffViewDGItems());
            AssetsItemsALL();
            SysRescControlVModel.SetFixedWindow(this);
           
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            
        }

        private void dgVerifyAssetsInfo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {             
        }

        private void dgdiffdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgDetails_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex ==3)
            {
                if (e.Value != null)
                {
                    e.Value= Convert.ToDateTime(e.Value).Year.ToString();
                }
            }
        }

        private void dgCompare_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex ==3)
            {
                if (e.Value != null)
                {
                    e.Value = Convert.ToDateTime(e.Value).Year.ToString();
                }
            }
        }

        private void FrmCostView_Load(object sender, EventArgs e)
        {

        }

        private void vscroll_Scroll(object sender, ScrollEventArgs e)
        {
         
        }
    }
}
