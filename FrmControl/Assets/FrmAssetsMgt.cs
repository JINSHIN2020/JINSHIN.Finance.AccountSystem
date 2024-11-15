using FinanceAccountProgram.Models.Config;
using FinanceAccountProgram.Models.FormMaintain;
using FinanceAccountProgram.Models.UControl;
using FinanceAccountProgram.VModel;
using FinanceAccountProgram.VModel.AddQueryDataForm;
using FinanceAccountProgram.VModel.AddQueryForm;
using FinanceAccountProgram.VModel.FormMaintain;
using JINSHIN.BUSINESS.LIBARY.Models.UIControls;
using JINSHIN.BUSINESS.LIBARY.UIControls.GridView;
using JINSHIN.Finance.AccountSystem.FrmControl.Assets.Dlg;
using JINSHIN.FinanceAccount.Libary.Models.Assets;
using JINSHIN.FinanceAccount.Libary.Models.Base;
using JINSHIN.FinanceAccount.Libary.VModels;
using JINSHIN.FinanceAccount.Libary.VModels.AccControl;
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
    public partial class FrmAssetsMgt : Form
    {
        public Acc_AssetsCtl assets_ctl { get; set; }
        public Acc_VModel Accctl;
        public int ImportType { get; set; }
        private string datapath07 = @"\Data7\";
        public PathModel pathmodel { get; set; }
        public BaseGridViewCtl gridviewctl { get; set; }
        public int curridx { get; set; }
        public FrmAssetsMgt()
        {
            InitializeComponent();
            string path = Environment.CurrentDirectory;
            DirectoryInfo di = new DirectoryInfo(path);
            gridviewctl = new BaseGridViewCtl();
#if (DEBUG)
            datapath07 = di.Parent.Parent.FullName + datapath07;
#else
            datapath07 = accounting.ClickPath + datapath07;         
#endif
            pathmodel = new PathModel();
            Accctl = new Acc_VModel();
            Accctl.ctl05 = new Acc_AssetsCtl();
            assets_ctl = new Acc_AssetsCtl();
            assets_ctl.SetInitNew();
            ImportType = ImportQueryClass.Assets;

            SysRescControlVModel.Let1366ToMaxWindowSize(this);
        }

        private static List<AssetsAccClass> GetAssetsClassName()
        {
            List<AssetsAccClass> accname = new List<AssetsAccClass>();
            accname.Add(new AssetsAccClass()
            {
                acc_id_Add = "1586",
                acc_id_Red = "6125",
                assetsname = "其他資產",
            });
            accname.Add(new AssetsAccClass()
            {
                acc_id_Add = "1533",
                acc_id_Red = "6126",
                assetsname = "費用",
            });
            return accname;
        }

        public void AssetsItemsALL()
        {
            assets_ctl.ImportType = ImportType;
            DataParams inputdata = new DataParams();
            Accctl.ImportType = ImportType;
            Accctl.DataShow<JINSHINFINANCE051>(dgData, inputdata);
            inputdata.Dispose();
            OrderBy(dgData);
            if (dgData.Rows.Count > 0)
                if (curridx <= dgData.Rows.Count -1)
                {
                    dgData.CurrentCell = dgData.Rows[curridx].Cells[0];
                }
            lblCnt.Text = dgData.Rows.Count.ToString();
        }

        private void OrderBy(DataGridView dg)
        {
            for (int i = 0; i < dg.Rows.Count; i++)
            {
                dg.Rows[i].Cells[0].Value = (i+1).ToString();
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            AssetsItemsALL();
            if (ImportType == ImportQueryClass.Assets)
            {
                lblCnt.Text = dgData.Rows.Count.ToString();
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            List<string> msg = default(List<string>);
            try
            {
                int year = 0;
                int.TryParse(txtYear.Text, out year);
                if (year == 0 && chclear.Checked)
                {
                    MessageBox.Show("請輸入要重整的年度.");
                    return;
                }
                List<JINSHINFINANCE051> data = new List<JINSHINFINANCE051>();
                msg = assets_ctl.SaveData(dgData,data, datapath07 , chclear.Checked,
                        chadd.Checked, year,chClearAll.Checked);
                AssetsItemsALL();
                dgDetails.DataSource = null;
                dgDetails.DataSource = assets_ctl.Jin51_AssetsItems;
                OrderBy(dgDetails);
                lblCnt.Text = msg[0];
            }
            catch (Exception ex)
            {

            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string path = "";
            using (GridViewBase grid = new GridViewBase())
            {
                path = "AccAssets_";
                grid.ExportDataGridView(pathmodel.exportPath, path, dgData);
            }
        }

        private void chAll_Shown(object sender, EventArgs e)
        {
            gridviewctl.SetGridColumns<DGAssets_CreateItems>(dgData, new DGAssets_CreateItems());
            gridviewctl.SetGridColumns<DGAssets_CreateItems>(dgDetails, new DGAssets_CreateItems());
            AssetsItemsALL();
            SysRescControlVModel.SetFixedWindow(this);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {         
            AccBaseCtl acc_ctl = new AccBaseCtl();
            List<string> files = acc_ctl.GetDataFile(datapath07);
            FunctionControl functl = new FunctionControl();
            string itemno = txtItems.Text;
            string classno = txtClassNo.Text;
            try
            {
                assets_ctl.SaveSelectedData(dgDetails, files, functl,itemno,classno);
            }
            catch (Exception ex)
            {
                string str = ex.ToString();
                MessageBox.Show("有重覆的編號!");
            }
            AssetsItemsALL();
              
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entities = content.GetEntity())
                {
                    int cclassno = 0;
                    int itemno = 0;
                    var data = entities.JINSHINFINANCE052.Where(v => v.ClassNo == cclassno && v.Item == itemno).ToList();
                    if (data.Count == 0)
                    {
                        if (dgData.CurrentRow.Cells["ClassNo"].Value != null)
                            cclassno = Convert.ToInt32(dgData.CurrentRow.Cells["ClassNo"].Value);
                        if (dgData.CurrentRow.Cells["item"].Value != null)
                            itemno = Convert.ToInt32(dgData.CurrentRow.Cells["item"].Value);
                        var val = entities.JINSHINFINANCE051.Where(v => v.ClassNo == cclassno && v.Item == itemno).FirstOrDefault();
                        if (val != null)
                        {
                            entities.JINSHINFINANCE051.Remove(val);
                            entities.SaveChanges();
                        }
                        AssetsItemsALL();
                    }
                    else
                    {
                        MessageBox.Show("資產已有折舊提列!");
                    }                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void dgData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmAssetsModify modifyfrm = new FrmAssetsModify();
            modifyfrm.classitem = Convert.ToInt32(dgData.CurrentRow.Cells["Item"].Value.ToString());
            modifyfrm.classno = Convert.ToInt32(dgData.CurrentRow.Cells["ClassNo"].Value.ToString());
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                  curridx = dgData.CurrentRow.Index;
                  var  smodel = entity.JINSHINFINANCE051.Where(i => i.ClassNo == modifyfrm.classno 
                  && i.Item ==modifyfrm.classitem).FirstOrDefault();
                  modifyfrm.smodel = smodel;
                  modifyfrm.mgt = this;
                  if (smodel != null)
                    modifyfrm.ShowDialog();
                }
            }
          
        }

        private void FrmAssetsMgt_Load(object sender, EventArgs e)
        {

        }

        private void FrmAssetsMgt_SizeChanged(object sender, EventArgs e)
        {

        }
    }
}
