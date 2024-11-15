using CardClick.Model.GridModel;
using FinanceAccountProgram.Models.UControl;
using FinanceAccountProgram.VModel;
using FinanceAccountProgram.VModel.Conrols.GridView;
using JINSHIN.BUSINESS.LIBARY.Models.UControl.GView;
using JINSHIN.BUSINESS.LIBARY.Models.UIControls;
using JINSHIN.BUSINESS.LIBARY.Resources;
using JINSHIN.BUSINESS.LIBARY.UIControls.FormMgt.EntityVModel;
using JINSHIN.BUSINESS.LIBARY.UIControls.GridView;
using JINSHIN.Finance.AccountSystem.Controls.Dlg;
using JINSHIN.FinanceAccount.Libary.Models.Forms;
using JINSHIN.FinanceAccount.Libary.VModels;
using JINSHIN.FinanceAccount.Libary.VModels.AccControl;
using JINSHIN.FinanceAccount.Libary.VModels.Assets;
using JINSHIN.FinanceAccount.Libary.VModels.DB;
using JINSHIN.FinanceAccount.Libary.VModels.GridView.Assets;
using JINSHIN.FinanceAccounting.DB;
using JINSHIN.FinanceAccounting.DB.VModel;
using ProjectResourceData;
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
    public partial class FrmAssetsSetting : Form
    {
        private int detailkey = 0;
        private int detailaccid = 4;
        private int detailaccdesc = 5;
        private int masterkeydata = 0;
        public entityNames mastertype { get; set; }
        public List<NameValues> mvalues { get; set; }
        public entityNames detailtype { get; set; }  
        public DBClassCtl dbclassctl { get; set; }
        public FinanceEntityControl control { get; set; }
        public List<DataModel> mdata { get; set; }
        public List<DataModel> detaildata { get; set; }
        public BaseGridCtl gridviewctl { get; set; }
        public DataGridViewCellEventHandler GridSelectData { get; set; }
        public AssetsDoubleDataControls datacontrol { get; set; }
        public List<NameValues> detailvalues2 { get; set; }
        public FrmAssetsSetting()
        {
            InitializeComponent();

            dbMasterData.Font = new System.Drawing.Font(DataControl.DataGridFont, 
                Convert.ToInt32(DataControl.DataGridFontSize));
            dgDetailData.Font = new System.Drawing.Font(DataControl.DataGridFont, 
                Convert.ToInt32(DataControl.DataGridFontSize));

            datacontrol = new AssetsDoubleDataControls();
            detailvalues2 = new List<NameValues>();
            dbclassctl = new DBClassCtl();
            mdata = new List<DataModel>();
            detaildata = new List<DataModel>();
            gridviewctl = new BaseGridCtl();
            control = new FinanceEntityControl(gridviewctl);
            SetInit(entityNames.Acc_Assets,  control);

        }

        public void SetInit(entityNames mtype,  FinanceEntityControl Fcontrol)
        {
            mvalues = new List<NameValues>();
            mastertype = mtype;
            detailtype = entityNames.Acc_AssetsDetail;
            control = Fcontrol;
        }

        public void SetMvaluesIns()
        {
            mvalues.Clear();
            NameValues val = new NameValues();
            val.name = "SN";
            val.dbvalue = lblAssetsSN.Text == "" ? null : lblAssetsSN.Text.Trim();
            mvalues.Add(val);

            NameValues val01 = new NameValues();
            val01.name = "DescTitle";
            val01.dbvalue = txtIDiaAccDesc.Text.Trim() == "" ? null : txtIDiaAccDesc.Text.Trim();
            mvalues.Add(val01);

        }
        private void ClearDetail()
        {
            txDiaAccDesc01.Text = "";
            txDiaAccID.Text = "";
            lblDescSN.Text = "";
        }

        private void SingleRowCardDataModify01(DataGridViewRow rws01)
        {
            try
            {
                lblAssetsSN.Text = rws01.Cells[masterkeydata].Value.ToString();
                object valdesc = rws01.Cells[2].Value ?? "";
                txtIDiaAccDesc.Text = valdesc.ToString();
                SetMvaluesIns();
            }
            catch (Exception)
            {


            }
        }

        private void SingleRowCardDataModify02(DataGridViewRow rws01)
        {
            if (rws01.Cells.Count > 1)
            {
                try
                {
                    lblDescSN.Text = rws01.Cells[detailkey].Value.ToString();
                    txDiaAccID.Text = rws01.Cells[detailaccid].Value.ToString();
                    txDiaAccDesc01.Text = rws01.Cells[detailaccdesc].Value.ToString();
                    SetDetails(rws01);
                }
                catch (Exception)
                {

                }
            }
        }

        public void SetDetails(DataGridViewRow rws01)
        {
            detailvalues2.Clear();

            NameValues val02 = new NameValues();
            val02.name = "Desc02";
            val02.dbvalue = rws01.Cells[detailaccdesc].Value.ToString() == "" ? null : rws01.Cells[detailaccdesc].Value.ToString();
            val02.datatype = "string";

            //txtDesciddata
            NameValues val01 = new NameValues();
            val01.name = "DescID";
            val01.dbvalue = rws01.Cells[detailkey].Value.ToString() == "" ? null : rws01.Cells[detailkey].Value.ToString();
            val01.datatype = "int";


            NameValues val03 = new NameValues();
            val03.name = "Desc01";
            val03.dbvalue = txtIDiaAccDesc.Text.Trim() == "" ? null : txtIDiaAccDesc.Text.Trim();
            val03.datatype = "string";

            NameValues val05 = new NameValues();
            val05.name = "No64";
            val05.dbvalue = dbMasterData.SelectedRows[0].Cells[masterkeydata].Value.ToString().Trim() == "" ? null : dbMasterData.SelectedRows[0].Cells[masterkeydata].Value.ToString().Trim();
            val05.datatype = "int";


            NameValues val06 = new NameValues();
            val06.name = "Acc_ID";
            val06.dbvalue = rws01.Cells[detailaccid].Value.ToString() == "" ? null : rws01.Cells[detailaccid].Value.ToString();
            val06.datatype = "string";

            detailvalues2.Add(val01);
            detailvalues2.Add(val02);
            detailvalues2.Add(val03);
            detailvalues2.Add(val05);
            detailvalues2.Add(val06);
        }

        private void dbMasterData_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if ((dbMasterData.SelectedRows.Count > 0))
            {
                var rws = dbMasterData.SelectedRows[0];
                SingleRowCardDataModify01(rws);
            }
        }

        private void DetailRowSelected()
        {
            if ((dgDetailData.SelectedRows.Count > 0))
            {
                var rws = dgDetailData.SelectedRows[0];
                SingleRowCardDataModify02(rws);
            }
        }

        private void btnMQuery_Click(object sender, EventArgs e)
        {
            QueryMasterData();
        }
        private void QueryMasterData()
        {
           // SetMvaluesSearch();
            dgDetailData.DataSource = null;
            SetMvaluesSearch();
            QueryMCondition();
        }

        public List<JINSHINFINANCE064> QueryAssetsDataModel(List<JINSHINFINANCE064> data, List<NameValues> keys)
        {
            List<JINSHINFINANCE064> rs = new List<JINSHINFINANCE064>();
            foreach (var item in data)
            {
                if (control.SearchKeysInClass<JINSHINFINANCE064>(item, keys))
                    rs.Add(item);
            }
            return rs;
        }

        private void QueryMCondition()
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    List<string> data01 = new List<string>() { "SN", "DESCTITLE" };
                    List<string> data02 = new List<string>() { "I01", "DATA01" };

                    List<JINSHINFINANCE064> data =
                        QueryAssetsDataModel(entity.JINSHINFINANCE064.ToList(), mvalues);
                    List<DataModel> models = new List<DataModel>();
                    int sn = 1;
                    foreach (var item in data)
                    {
                        DataModel dmodel = new DataModel();
                        control.EntityDataClass<JINSHINFINANCE064, DataModel>(item, dmodel, data01, data02);
                        dmodel.Sn = sn;
                        models.Add(dmodel);
                        sn++;
                    }
                    RefreshAcc_Master(models);
                    try
                    {
                        if (dbMasterData.Rows.Count > 0)
                        {
                            dbMasterData.Rows[0].Selected = true;
                            datacontrol.QueryDCondition(Convert.ToInt32(dbMasterData.Rows[0].Cells[0].Value),
                                detailvalues2, dgDetailData);
                        }
                    }
                    catch (Exception ex)
                    {
                        LogControl.LogAlarm(ex.ToString(), "FrmAssetsAccounting");
                    }
                }
            }
        }

        private void RefreshAcc_Master(List<DataModel> datalist)
        {
       //     gridviewctl.SetGridColumns<DG_AssetsDlgItems>(dbMasterData, new DG_AssetsDlgItems());
            //dbMasterData.da
            dbMasterData.DataSource = datalist;
        }

        public void SetMvaluesSearch()
        {
            mvalues.Clear();
            NameValues val = new NameValues();
            val.name = "SN";
            val.dbvalue = txtSN.Text == "" ? null : txtSN.Text.Trim();
            mvalues.Add(val);

            NameValues val01 = new NameValues();
            val01.name = "DescTitle";
            val01.dbvalue = txtDiaAccDesc.Text.Trim() == "" ? null : txtDiaAccDesc.Text.Trim();
            mvalues.Add(val01);
        }


        private void btnMAdd_Click(object sender, EventArgs e)
        {
            if (lblAssetsSN.Text != "")
            {
                if (!(MessageBox.Show(FormCaption.AssetsMasterCaption01, accounting.FormDataTitle, 
                    MessageBoxButtons.OKCancel) == DialogResult.OK))
                {
                    return;
                }
            }
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    lblAssetsSN.Text = control.GetMaxNo(entity, mastertype).ToString();
                }
            }
            SetMvaluesIns();
            InsertAssetsSetup();
            txtIDiaAccDesc.Text = "";
        }

        public void InsertAssetsSetup()
        {
            JINSHINFINANCE064 val = new JINSHINFINANCE064();
            FunctionControl func = new FunctionControl();
            func.SetClassObj<JINSHINFINANCE064>(val, mvalues);
            if (string.IsNullOrEmpty(val.DescTitle))
            {
                MessageBox.Show(FormCaption.BookDescCaption03);
                return;
            }
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    var data = entity.JINSHINFINANCE064.
                        Where(o => o.DescTitle == val.DescTitle).FirstOrDefault();
                    if (data != null)
                    {
                        MessageBox.Show(FormCaption.BookDescCaption01);
                        return;
                    }
                    else
                    {
                        int sn = Convert.ToInt32(val.SN);
                        val.SN = sn;
                        val.CDate = DateTime.Now;
                        entity.JINSHINFINANCE064.Add(val);
                        entity.SaveChanges();
                    }
                }
            }
            func.Dispose();
            SetMvaluesSearch();
            QueryMCondition();
        }

        private void btnMUpdate_Click(object sender, EventArgs e)
        {
            SetMvaluesIns();
            UpdateAssetsSetup();
        }

        public void UpdateAssetsSetup()
        {
            JINSHINFINANCE064 val = new JINSHINFINANCE064();
            FunctionControl func = new FunctionControl();
            func.SetClassObj<JINSHINFINANCE064>(val, mvalues);
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    var data = entity.JINSHINFINANCE064.Where(o => o.SN == val.SN).FirstOrDefault();
                    if (data != null)
                    {
                        data.SN = val.SN;
                        data.DescTitle = val.DescTitle;
                        data.UDate = DateTime.Now;
                        entity.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show(FormCaption.BookDescCaption02);
                        return;
                    }
                }
            }
            func.Dispose();
            SetMvaluesSearch();
            QueryMCondition();
        }

        private void btnMDelete_Click(object sender, EventArgs e)
        {
            btnMasterDelete_Click(new object(), null);
            QueryMasterData();
        }

        private void btnMasterDelete_Click(object sender, EventArgs e)
        {
            SetMvaluesIns();
            if (mvalues[0].dbvalue != null)
            {
                using (AccountEntityDB content = new AccountEntityDB())
                {
                    using (AccountEntities entity = content.GetEntity())
                    {
                        int sn = Convert.ToInt32(mvalues[0].dbvalue);
                        var data = entity.JINSHINFINANCE065.Where(o => o.No64 == sn).ToList();
                        if (data.Count() == 0)
                        {
                            var item = entity.JINSHINFINANCE064.Where(o => o.SN == sn).FirstOrDefault();
                            if (item != null)
                            {
                                entity.JINSHINFINANCE064.Remove(item);
                                entity.SaveChanges();
                            }
                            else
                            {
                                MessageBox.Show(FormCaption.BookConvertCpation01);
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show(FormCaption.BookAffairsCaption01);
                            return;
                        }
                    }
                }
            }
        }

        private void btnDetailAdd_Click(object sender, EventArgs e)
        {
            if (lblDescSN.Text != "")
            {
                if (!(MessageBox.Show(FormCaption.AffairsDetailCaption01, accounting.FormDataTitle, MessageBoxButtons.OKCancel) == DialogResult.OK))
                {
                    return;
                }
            }
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    lblDescSN.Text = control.GetMaxNo(entity, detailtype).ToString();
                    SetIDetails();
                    InsertAssetsDesc();
                    ClearDetail();
                }
            }
        }

        public void InsertAssetsDesc()
        {
            JINSHINFINANCE065 val = new JINSHINFINANCE065();
            using (FunctionControl func = new FunctionControl())
            {
                func.SetClassObj<JINSHINFINANCE065>(val, detailvalues2);
            }
            if (string.IsNullOrEmpty(val.Desc02) || string.IsNullOrEmpty(val.Acc_ID))
            {
                MessageBox.Show(FormCaption.BookDescCaption03);
                return;
            }
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    try
                    {
                        var data = entity.JINSHINFINANCE065.Where(o => o.Desc02 == val.Desc02 
                        && o.Desc01 == val.Desc01 && o.Acc_ID == val.Acc_ID).FirstOrDefault();
                        if (data != null)
                        {
                            MessageBox.Show(FormCaption.BookDescCaption01);
                            return;
                        }
                        else
                        {
                            int sn = val.DescID;
                            val.CDate = DateTime.Now;
                            entity.JINSHINFINANCE065.Add(val);
                            entity.SaveChanges();
                        }
                        datacontrol.QueryDCondition(Convert.ToInt32(mvalues[0].dbvalue), detailvalues2, dgDetailData);
                    }
                    catch (Exception ex)
                    {
                        string str = ex.ToString();
                    }
                }
            }
        }

        public void SetIDetails()
        {
            detailvalues2.Clear();
            NameValues val02 = new NameValues();
            val02.name = "Desc02";
            val02.dbvalue = txDiaAccDesc01.Text.ToString() == "" ? null : txDiaAccDesc01.Text.ToString();
            val02.datatype = "string";

            //txtDesciddata
            NameValues val01 = new NameValues();
            val01.name = "DescID";
            val01.dbvalue = lblDescSN.Text.ToString() == "" ? null : lblDescSN.Text.ToString();
            val01.datatype = "int";


            NameValues val03 = new NameValues();
            val03.name = "Desc01";
            val03.dbvalue = txtIDiaAccDesc.Text.Trim() == "" ? null : txtIDiaAccDesc.Text.Trim();
            val03.datatype = "string";

            NameValues val05 = new NameValues();
            val05.name = "No64";
            val05.dbvalue = dbMasterData.SelectedRows[0].Cells[masterkeydata].Value.ToString().Trim() == "" ? null : dbMasterData.SelectedRows[0].Cells[masterkeydata].Value.ToString().Trim();
            val05.datatype = "int";


            NameValues val06 = new NameValues();
            val06.name = "Acc_ID";
            val06.dbvalue = txDiaAccID.Text.ToString() == "" ? null : txDiaAccID.Text.ToString();
            val06.datatype = "string";
            detailvalues2.Add(val01);
            detailvalues2.Add(val02);
            detailvalues2.Add(val03);
            detailvalues2.Add(val05);
            detailvalues2.Add(val06);
        }

        private void btnDetailUpdate_Click(object sender, EventArgs e)
        {
            SetIDetails();
            UpdateAssetsDesc();
        }

        public void UpdateAssetsDesc()
        {
            JINSHINFINANCE065 val = new JINSHINFINANCE065();
            List<NameValues> keys = new List<NameValues>();
            FunctionControl func = new FunctionControl();
            string keyno = detailvalues2.Where(o => o.name == "DescID").FirstOrDefault().name;
            func.SetClassObj<JINSHINFINANCE065>(val, detailvalues2);
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    var data = entity.JINSHINFINANCE065.Where(o => o.DescID == val.DescID).FirstOrDefault();
                    if (data != null)
                    {
                        foreach (var item in detailvalues2)
                        {
                            if (item.name != keyno)
                                keys.Add(item);
                        }
                        control.SetKeys<JINSHINFINANCE065>(data, detailvalues2);
                        data.UDate = DateTime.Now;
                        entity.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show(FormCaption.BookDescCaption02);
                        return;

                    }
                }
            }
            func.Dispose();
            datacontrol.QueryDCondition(Convert.ToInt32(mvalues[0].dbvalue), detailvalues2, dgDetailData);
        }

        private void btnDdelete_Click(object sender, EventArgs e)
        {
            Delete();
            ClearDetail();
            datacontrol.QueryDCondition(Convert.ToInt32(dbMasterData.SelectedRows[0].Cells[0].Value), detailvalues2, dgDetailData);
        }

        public void Delete()
        {
            if (detailvalues2[0].dbvalue != null)
            {
                try
                {
                    using (AccountEntityDB content = new AccountEntityDB())
                    {
                        using (AccountEntities entity = content.GetEntity())
                        {
                            int sn = Convert.ToInt32(detailvalues2[0].dbvalue);
                            entity.JINSHINFINANCE065.Remove(entity.JINSHINFINANCE065.Where(o => o.DescID == sn
                            ).FirstOrDefault());
                            entity.SaveChanges();
                        }
                    }
                }
                catch (Exception ex)
                {
                    LogControl.LogAlarm(ex.ToString(), ProjectNameRsource.AffairsAccountingMgt);
                }
            }

        }

        public void DeleteAll()
        {
            SetMvaluesIns();
            if (mvalues[0].dbvalue != null)
            {
                using (AccountEntityDB content = new AccountEntityDB())
                {
                    using (AccountEntities entity = content.GetEntity())
                    {
                        int sn = Convert.ToInt32(mvalues[0].dbvalue);
                        var data = entity.JINSHINFINANCE065.Where(o => o.No64 == sn).ToList();
                        if (data.Count() > 0)
                        {
                           // var item = entity.JINSHINFINANCE065.Where(o => o.No64 == sn).ToList();
                            if (data != null)
                            {
                                entity.JINSHINFINANCE065.RemoveRange(data);
                                entity.SaveChanges();
                            }
                            else
                            {
                                MessageBox.Show(FormCaption.BookConvertCpation01);
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show(FormCaption.BookConvertCpation01);
                            return;
                        }
                    }
                }
            }
        }

        private void btnDDeleteAll_Click(object sender, EventArgs e)
        {
            DeleteAll();
            ClearDetail();
            datacontrol.QueryDCondition(Convert.ToInt32(dbMasterData.SelectedRows[0].Cells[0].Value), detailvalues2, dgDetailData);
        }

        private void dbMasterData_SelectionChanged(object sender, EventArgs e)
        {
            if ((dbMasterData.SelectedRows.Count > 0))
            {
                var rws = dbMasterData.SelectedRows[0];
                SingleRowCardDataModify01(rws);
                if (datacontrol.QueryDCondition(Convert.ToInt32(mvalues[0].dbvalue), detailvalues2, dgDetailData))
                {
                    ClearDetail();
                }
            }
        }

        private void dgDetailData_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DetailRowSelected();
        }

        private void dgDetailData_SelectionChanged(object sender, EventArgs e)
        {
            if ((dgDetailData.SelectedRows.Count > 0))
            {
                var rws = dgDetailData.SelectedRows[0];
                SingleRowCardDataModify02(rws);
            }
        }

        private void dgDetailData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DetailRowSelected();
        }
        
        private void btnExport_Click(object sender, EventArgs e)
        {
            FormData.values = new List<string>();
            AssetsDlg assetdlg = new AssetsDlg();
            assetdlg.ShowDialog();
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    var contents = entity.JINSHINFINANCE064.ToList();
                    int maxsn = 0;
                    if (contents.Count > 0)
                        maxsn = contents.Max(v => v.SN);
                    foreach (var item in FormData.values)
                    {
                        JINSHINFINANCE064 val = new JINSHINFINANCE064();
                        val.SN = maxsn+1;
                        val.DescTitle = item;
                        val.CDate = DateTime.Now;
                        entity.JINSHINFINANCE064.Add(val);
                        entity.SaveChanges();
                        maxsn++;
                    }
                }
            }
            QueryMasterData();
        }

        private void FrmAssetsSetting_Shown(object sender, EventArgs e)
        {
            gridviewctl.SetGridColumns<Acc_Affairs_DGItems>(dbMasterData, new Acc_Affairs_DGItems());
            gridviewctl.SetGridColumns<Acc_AssetsDesc_DGItem>(dgDetailData, new Acc_AssetsDesc_DGItem());
            QueryMasterData();
            SysRescControlVModel.SetFixedWindow(this);
        }
    }
}
