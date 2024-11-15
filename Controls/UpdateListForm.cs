using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FinanceAccountProgram.Models.Config;
using System.IO;
using FinanceAccountProgram.VModel.UsrControl;
using FinanceAccountProgram.VModel.AddQueryForm;
using FinanceAccountProgram.Models.UControl;
using FinanceAccountProgram.VModel;
using FinanceAccountProgram.VModel.Conrols.VModel;
using FinanceAccountProgram.VModel.Conrols.Model;
using FinanceAccountProgram.VModel.UpdateListForm;
using FinanceAccountProgram.Models.UpdateForm;
using FinanceAccountProgram.Models.Config.UpdataeForm;
using JINSHIN.FinanceAccounting.DB;
using JINSHIN.BUSINESS.LIBARY.UIControls.GridView;
using JINSHIN.BUSINESS.LIBARY.Resources;
using JINSHIN.BUSINESS.LIBARY.Models.UIControls;
using JINSHIN.BUSINESS.LIBARY.Models;
using JINSHIN.FinanceAccount.Libary.Models.Base;
using JINSHIN.FinanceAccount.Libary.Models.UControls.DGridView;
using JINSHIN.FinanceAccount.Libary.Config;
using JINSHIN.FinanceAccount.Libary.VModels;
using JINSHIN.FinanceAccounting.DB.VModel;
using JINSHIN.FinanceAccount.Libary.VModels.Config;
using JINSHIN.FinanceAccount.Libary.VModels.AccControl;

namespace FinanceAccountProgram.Controls
{

    public partial class UpdateListForm : UserControl
    {        
        public AddQueryEnum datatype { get; set; }
        public AddQueryEnum gvdatatype { get; set; }
        public Acc_CostDataQuery ctl01 { get; set; }
        public DataGridView dgdataview { get; set; }
        public List<ListBox> listboxs = new List<ListBox>();
        public List<int> listboxSelect { get; set; }
        public Acc_VModel Accctl { get; set; }
        public List<int> comboli { get; set; }
        public List<int> check { get; set; }
        public GridViewComboFinanceBase gvbase { get; set; }
        public List<GridViewOperation> operations { get; set; }
        public string dataUpdateCenter { get; set; }
        public const string fname = "updateData.csv";
        private PathModel pathmodel { get; set; }
        public int Cnt { get; set; }
        public bool alarammsg { get; set; }
        public UpdateListForm()
        {
            InitializeComponent();
            gvdatatype = AddQueryEnum.Acc_CostData;
            dgControl.Font = new System.Drawing.Font(DataControl.DataGridFont, Convert.ToInt32(DataControl.DataGridFontSize));
            for (int i = 0; i < 3; i++)
            {
                listboxs.Add(new ListBox());
            }
            listboxSelect = new List<int>() { 0,0,0};
            VerifyAccGridViewVModel vagrid = new VerifyAccGridViewVModel();
            List<NameValues> columns = vagrid.columns;
            comboli = new List<int>();
            check = new List<int>();
            pathmodel = new PathModel();
         
        }
        public void SetInit(UpdateFormVModel updatemodel)
        {
            Accctl = new Acc_VModel();
            Accctl.ctl01 = ctl01;
            Accctl.datatype = datatype;
            listboxSelect = new List<int>() { 0, 0, 0 };
            int data = listboxSelect.Count();
            switch (datatype)
            {
                case AddQueryEnum.None:
                    break;
                case AddQueryEnum.Acc_CostData:
                    {
                        comboli.Add(5);
                        comboli.Add(7);
                        comboli.Add(15);
                        check.Add(12);
                    }
                    break;
                case AddQueryEnum.Invoice_Contract:
                    break;
                default:
                    break;
            }
            gvbase = new GridViewComboFinanceBase(gvdatatype);
            operations = new List<GridViewOperation>();
            AccBookParams inputdata = SetConditionData();
            updatemodel.Init(ctl01.dbclass, Accctl, inputdata, FormConfig.CostItemInitCnt);
        }

        
     
        private void UpdateForm_Load(object sender, EventArgs e)
        {
            dgdataview = this.dgControl;
            listboxs[0] = listMaster;
            listboxs[1] = listContents;
            listboxs[2] = ListAccType;
            txAccYear.Text = AccountingReso.yearnow.ToString();
            lstUpdateMonths.SelectedIndex = DateTime.Now.Month - 1;
           // lstUpdateMonths.SelectedIndex = 3;
            FormConfig.CostItemInitCnt = 0;  
            Cnt = Convert.ToInt32(txtDataCnt.Text);
            if (dgControl.Rows.Count > 0)
            {
              dgControl.Rows[0].Cells[0].Selected = true;
              dgControl.BeginEdit(false);
            }

        }


        private void dgControl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {          
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgControl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dg = sender as DataGridView;
            int idx = e.ColumnIndex;
            if (dgControl.Rows.Count > 0)
            {
                dgControl.BeginEdit(false);
            }
            //if (e.ColumnIndex != -1)
            //    dgControl.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
            for (int i = 0; i < comboli.Count; i++)
            {
                if (comboli[i] == idx)
                {
                    dg.BeginEdit(false);
                    if (dg.EditingControl is DataGridViewComboBoxEditingControl dgviewedit)
                    {
                        dgviewedit.DroppedDown = true;
                    }
                    return;
                }
            }
            for (int i = 0; i < check.Count; i++)
            {
                if ( idx == check[i])
                {
                    dg.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = bool.Parse(dg.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue.ToString()) == false ? true : false;
                    dg.EndEdit();
                    return;
                }
            }         
        }

        private void dgControl_CellLeave(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnQuery_Click(object sender, EventArgs e)
        {
            if (datatype == AddQueryEnum.Acc_VerifyCostData)
            {
                 VerifyCostDataAll();
                if (dgControl.Rows.Count > 0)
                {
                    dgControl.Rows[0].Cells[0].Selected = true;
                    dgControl.BeginEdit(false);
                }
            }
        }

        private void VerifyCostDataAll()
        {
            //FormConfig.CostItemInitCnt
            AccBookParams inputdata = SetConditionData();       
            Accctl.DataShowFormList<JINSHINFINANCE035>(dgControl, inputdata, FormConfig.CostItemInitCnt);
            lblDataAllCnt.Text = dgControl.Rows.Count.ToString();
            dgControl.Refresh();
            inputdata.Dispose();
        }

        private void VerfyCostItemDataAll()
        {

        }
        private AccBookParams SetConditionData()
        {
            int val = 0;
            AccBookParams inputdata = new AccBookParams();
            inputdata.AccVal.value = Convert.ToInt32(ListAccType.SelectedValue);
            inputdata.AccVal.enable = listboxSelect[0] == 1;
            inputdata.MasterVal.value = Convert.ToInt32(listMaster.SelectedValue);
            inputdata.MasterVal.enable = listboxSelect[1] == 1;
            inputdata.ContentVal.value = Convert.ToInt32(listContents.SelectedValue);
            inputdata.ContentVal.enable = listboxSelect[2] == 1;
            inputdata.Acc_No.data = txUpdateAcc.Text.Trim();
            inputdata.Acc_No.enable = txUpdateAcc.Text.Trim() != "";
            inputdata.Acc_ID.data = txUpdateAccID.Text.Trim();
            inputdata.Acc_ID.enable = txUpdateAccID.Text.Trim() != "";
            inputdata.Desc.data = txUpdateDesc.Text.Trim();
            inputdata.Desc.enable = txUpdateDesc.Text.Trim() != "";
            inputdata.invoice.data = txtInvoice.Text.Trim() ;

            int.TryParse(txUpdateAmount.Text.Trim(), out val);
            inputdata.Amount.value = val;
            inputdata.Amount.enable = txUpdateAmount.Text.Trim() != "";

            inputdata.Year.enable = txAccYear.Text.Trim() != "";
            int yearval = 0;
            int.TryParse(txAccYear.Text.Trim(), out yearval);
            if (yearval != 0)
              inputdata.Year.value = yearval;
            if (coUpdateAll.Checked)
                inputdata.Months.enable = false;
            else
            {
                inputdata.Months.value = lstUpdateMonths.SelectedIndex + 1;
                inputdata.Months.enable = lstUpdateMonths.SelectedIndex != -1;
            }
            
            dgControl.AutoGenerateColumns = false;
            dgControl.Columns.Clear();
            VerifyAccGridViewVModel vagrid = new VerifyAccGridViewVModel();
            List<NameValues> columns = vagrid.columns;
            gvbase.AutoGenerateColumns(dgControl, columns);
            return inputdata;
        }

      
        private void ListAccType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ListAccType_SelectedValueChanged(object sender, EventArgs e)
        {
            ListBox lstbox = sender as ListBox;
            ReBuildSelectInt(lstbox);
        }

        private void ReBuildSelectInt(ListBox lstbox)
        {
            int idx = 0;
            if (lstbox.SelectedIndex != -1)
            {
                switch (lstbox.Name)
                {
                    case "ListAccType": idx = 0;break;
                    case "listMaster": idx = 1; break; 
                    case "listContents": idx = 2; break;
                    default:
                        break;
                }
                if (lstbox.SelectedIndex == 0)
                {
                    listboxSelect[idx] = 0;
                }
                else
                    listboxSelect[idx] = 1;
            }
        }

        private void btnIntegrae_Click(object sender, EventArgs e)
        {
            
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            
        }

        private void btnIntegrate_Click(object sender, EventArgs e)
        {
            //17,19,18
            //14:Combine Tax Amount check if need
            try
            {
                using (UpdateFormVModel model = new UpdateFormVModel(dgControl,AddQueryEnum.None, UpdateFormEnum01.None ))
                {
                  //  model.InitColumnConfig();
                    model.UpdateData();
                }
                using (Acc_UpdateLstFrm actbasectl = new Acc_UpdateLstFrm())
                {
                    DBClassCtl dbclass = new DBClassCtl();
                    actbasectl.InvoiceToCost(dbclass);
                }
            }
            catch (Exception ex)
            {
                string str = ex.ToString();
            }
        }

        /// <summary>
        /// 0:SN,1:Invoice_NO,2:Item,3:Cost_M,4:Acc_ID,5:Cost_Date,6:Acc_No
        /// 7:Acc_Desc,8:DataType,9:Sell_ID,10:Buy_ID,11:Amount,12:TaxAmount,13:HasTax
        /// 14:Cost_Check,15:Check_Date,16:Cost_Compare,17:Cost_Class,18:Cost_Month
        /// 19:CreateTime
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            alarammsg = false;
            List<string> cols = default(List<string>);
            try
            {
                using (AccountEntityDB content = new AccountEntityDB())
                {
                    using (AccountEntities entity = content.GetEntity())
                    {
                        cols = new List<string>();
                        for (int i = 0; i < dgControl.Columns.Count; i++)
                        {
                            cols.Add(dgControl.Columns[i].Name);
                        }
                        switch (datatype)
                        {
                            case AddQueryEnum.None:
                                break;
                            case AddQueryEnum.Acc_CostData:
                                break;
                            case AddQueryEnum.Invoice_Contract:
                                break;
                            case AddQueryEnum.Acc_VerifyCostData:
                                {
                                    FunctionControl fcontrol = new FunctionControl();
                                    List<NameValues> values = new List<NameValues>();
                                    var data = operations.GroupBy(o => o.rowidx);
                                    using (AccountEntityDB dbentity = new AccountEntityDB())
                                    {
                                        using (AccountEntities accbook = dbentity.GetEntity())
                                        {
                                            AccBookParams inputdata = SetConditionData();
                                            List<JINSHINFINANCE035> contents = 
                                                ctl01.GetStorageData(accbook, QueryFrmString.JINSHINFINANCE035, inputdata);
                                            UpdateFormVModel vmodel = new 
                                                UpdateFormVModel(dgControl, AddQueryEnum.Acc_VerifyCostData,
                                                UpdateFormEnum01.None);
                                            foreach (var item in data)
                                            {
                                                if (alarammsg)
                                                {
                                                    break;
                                                }
                                                var im = item.FirstOrDefault();
                                                if (im != null)
                                                {
                                                    JINSHINFINANCE035 val = vmodel.GetItemFromValues(datatype, contents, dgControl, im.rowidx);
                                                    //沖帳不必修改,已過帳不能修改,已核定不能修改
                                                    if (val != null)
                                                    {
                                                        if ((val.Is_Reserved != true && val.Status <= coststatus.monthtaxapply
                                                            && val.Cost_Check != true) || true)
                                                        {
                                                            VerifyAccGridView ctl = new VerifyAccGridView();
                                                            foreach (var i in item)
                                                            {
                                                                values.Add(new NameValues()
                                                                {
                                                                    valuetype = NameValType.dbvalue,
                                                                    name = dgControl.Columns[i.colidx].DataPropertyName,
                                                                    dbvalue = dgControl.Rows[i.rowidx].Cells[i.colidx].Value
                                                                });
                                                            }
                                                            fcontrol.SetClassTypeObj<VerifyAccGridView>(ctl, values);
                                                            vmodel.SetVerifyAccToCostItem(fcontrol, val, ctl, values);
                                                            val.Is_Update = true;
                                                            int itemid = Convert.ToInt32(dgControl.Rows[im.rowidx].Cells[vmodel.key_columns[2].value01].Value);
                                                            if (val.Item != itemid)
                                                                val.Item = itemid;
                                                        }
                                                        else
                                                        {
                                                            alarammsg = true;
                                                            MessageBox.Show("已過帳或已核定，不能修改!");
                                                        }
                                                    }
                                             //       accbook.SaveChanges();
                                                }
                                            }
                                            accbook.SaveChanges();
                                        }
                                    }
                                }
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string str = ex.ToString();
            }
            finally {
                operations.Clear();
            }
        }

        private void dgControl_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
              operations.Add(new GridViewOperation()
              { colidx = e.ColumnIndex,rowidx = e.RowIndex });
        }

        private void dgControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnUpdate_Click(new object(), null);
            }
        }

        private void btnReserved_Click(object sender, EventArgs e)
        {
            try
            {
                using (AccountEntityDB content = new AccountEntityDB())
                {
                    using (AccountEntities accbook = content.GetEntity())
                    {
                        var data = accbook.JINSHINFINANCE035.ToList();
                        var lst = data.Where(o => o.Acc_Desc.IndexOf("沖帳-") != -1).GroupBy(o => o.Acc_No).ToList();
                        string acc_no = "";
                        foreach (var item in lst)
                        {
                            if (item.First().Acc_Desc.Length >= 16)
                            {
                                acc_no = item.First().Acc_Desc.Substring(3, 13);
                                List<JINSHINFINANCE035> costitem = data.Where(o => o.Acc_No == acc_no).ToList();
                                if (costitem.Count > 0)
                                {
                                    foreach (var detail in item)
                                    {
                                        detail.Is_Reserved = true;
                                        detail.Is_Process = 1;
                                    }
                                    foreach (var st in costitem)
                                    {
                                        st.Is_Reserved = true;
                                        st.Is_Process = 1;
                                        st.Rec_Type = 9;
                                    }
                                }
                                else
                                {
                                    foreach (var detail in item)
                                    {
                                        detail.Is_Reserved = true;
                                        detail.Is_Process = 1;
                                    }
                                }
                            }
                        }
                        accbook.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
              string str = ex.ToString();
            }
            
        }
        /// <summary>
        /// actionUpdate:"u" check 功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateExport_Click(object sender, EventArgs e)
        {
            string fullpath = dataUpdateCenter + fname; 
            string actionAdd = ImportActions.actionAdd;
            string actionDel = ImportActions.actionDel;
            string actionRserve = ImportActions.actionRserve;
            string actionDirectRserve = ImportActions.actionDirectRserve;
            string actionUpdate = ImportActions.actionAddUpdate;
            string actionWait = ImportActions.actionWait;
            string actionPaste = ImportActions.actionPaste;
            string actionIndicateAdd = ImportActions.actionIndicateAdd;
            string[] data = File.ReadAllLines(fullpath, Encoding.GetEncoding(950));
            DateTime dtime = default(DateTime);
            List<string> lendorget = new List<string>();
            AccBaseCtl accctl = new AccBaseCtl();
            List<string> datatemp = data.ToList();
            string datactl = "";
            int y = 0, m = 0, d = 0;
            try
            {
                datatemp.RemoveAt(0);
                data = datatemp.ToArray();
                int count = 0;
                int year = 0;
                int.TryParse(txAccYear.Text,out year);
                if (year == 0)
                    year = AccountingReso.yearnow;

                List<JINSHINFINANCE035> contents = new List<JINSHINFINANCE035>();
                using (AccountEntityDB content = new AccountEntityDB())
                {
                    using (AccountEntities entity = content.GetEntity())
                    {
                        List<JINSHINFINANCE035> datacenter = entity.JINSHINFINANCE035.Where(o => o.Cost_Date.Value.Year == year).ToList();
                        List<JINSHINFINANCE035> waitdata = entity.JINSHINFINANCE035.Where(o => (o.Rec_Type == FormConfig.WaitRecType) 
                        && (o.Cost_Date.Value.Year == year)).ToList();
                        foreach (var i in data)
                        {
                            count++;
                            string[] ims = i.Split(',');
                            lendorget.Clear();
                            lendorget = accctl.CheckLendOrGet(ims[6], ims[7]);

                            JINSHINFINANCE035 book = new JINSHINFINANCE035();                            
                            datactl = ims[8].Trim();
                            book.SN = Convert.ToInt32(ims[0]);
                            book.Acc_No = ims[2];
                            DateTime.TryParse(ims[1], out dtime);
                            y = Convert.ToInt32(ims[1].Substring(0, 3));
                            m = Convert.ToInt32(ims[1].Substring(3, 2));
                            d = Convert.ToInt32(ims[1].Substring(5, 2));
                            book.Cost_Date = new DateTime(y + 1911, m, d);
                            book.Acc_ID = ims[4];
                            book.Acc_Desc = ims[5];
                            book.DataType = byte.Parse(lendorget[0]);
                            book.Amount = Convert.ToDecimal(lendorget[1]);
                            book.Rec_Type = 3;
                            book.Item = Convert.ToInt32(ims[3]);
                            book.Cost_M = Convert.ToByte(m);
                            book.Status = 2;
                            if (datactl == actionAdd || datactl == actionIndicateAdd)
                            {
                                book.Is_Update = true;
                                contents.Add(book);
                            }
                            else if (datactl == actionDel)
                            {
                                JINSHINFINANCE035 delobj = ImportData(datacenter, book, datactl);
                                if (delobj != null)
                                    entity.JINSHINFINANCE035.Remove(delobj);
                            }
                            else if (datactl == actionDirectRserve)
                            {
                                JINSHINFINANCE035 reserve_data = ImportDataReverse(datacenter, book, datactl);
                                using (AccountingControl control = new AccountingControl())
                                {
                                    //新增沖帳帳目
                                    JINSHINFINANCE035 valdata = AddReverseBooks(reserve_data);
                                    valdata.Acc_No = book.Acc_No;
                                    valdata = SetImportStatus(valdata);
                                    valdata.Rec_Type = reserve_data.Rec_Type;
                                    valdata.Cost_Date = book.Cost_Date;
                                    valdata.Status = 2;
                                    valdata.Cost_M = book.Cost_M;
                                    contents.Add(valdata);
                                    //原來的帳目設定
                                    if (reserve_data != null)
                                    {
                                        reserve_data= SetImportStatus(reserve_data);
                                    }
                                }                              
                            }
                            else if (datactl == actionUpdate)
                            {
                                JINSHINFINANCE035 reserve = ImportData(datacenter, book, datactl);
                                reserve.Acc_ID = book.Acc_ID;
                                reserve.Amount = book.Amount;
                                reserve.Acc_Desc = book.Acc_Desc;
                                reserve.DataType = book.DataType;
                                book.Is_Update = true;
                            }
                            //新增沖帳帳目,新增正確帳目
                            else if (datactl == actionRserve)
                            {
                                JINSHINFINANCE035 reserve_data = ImportDataReverse(datacenter, book, datactl);
                                using (AccountingControl control = new AccountingControl())
                                {
                                    List<string> rs = control.GetAccNo2(book.Acc_No);
                                    //新增沖帳帳目
                                    JINSHINFINANCE035 valdata = AddReverseBooks(reserve_data);
                                    valdata.Acc_No = rs[1];
                                    valdata = SetImportStatus(valdata);
                                    valdata.Rec_Type = reserve_data.Rec_Type;
                                    valdata.Cost_Date = book.Cost_Date;
                                    valdata.Status = 2;
                                    valdata.Cost_M = book.Cost_M;
                                    contents.Add(valdata);

                                    //原來的帳目設定
                                    if (reserve_data != null)
                                    {
                                        reserve_data= SetImportStatus(reserve_data);
                                    }
                                    book.Is_Update = true;
                                  //  book.Rec_Type = reserve_data.Rec_Type;
                                    book.Status = 2;
                                    book.Acc_Desc = book.Acc_Desc.Substring(3, book.Acc_Desc.Length-3);
                                    contents.Add(book);
                                }
                            }
                            else if (datactl == actionWait)
                            {
                                JINSHINFINANCE035 reserve = ImportData(datacenter, book, datactl);
                                reserve.Rec_Type = FormConfig.WaitRecType;
                            }
                            else if (datactl == actionPaste)
                            {
                                JINSHINFINANCE035 delobj = ImportData(datacenter, book, datactl);
                                if (delobj == null)
                                {
                                    book.Is_Update = true;
                                    contents.Add(book);
                                }
                            }
                        }
                        var itemg = contents.GroupBy(o => o.Acc_No).ToList();
                        int dataidx = 1;
                        string acc_no = "";
                        List<JINSHINFINANCE035> data_no = new List<JINSHINFINANCE035>();
                        bool IsReplace = false;
                        List<JINSHINFINANCE035> waitcostitem = new List<JINSHINFINANCE035>();
                        //先取被取代的傳票,再給予新的初始傳票
                        JINSHINFINANCE035 wait_costitem = new JINSHINFINANCE035();
                        int itemsn = 1;
                        foreach (var p in itemg)
                        {
                            dataidx = 1;
                            IsReplace = false;
                            if (waitdata.Count() > 0)
                            {
                                acc_no = waitdata[0].Acc_No;
                                waitcostitem = waitdata.Where(o => o.Acc_No == acc_no).ToList();
                                wait_costitem.Acc_No = waitcostitem[0].Acc_No;
                                wait_costitem.Cost_Date = waitcostitem[0].Cost_Date;
                                foreach (var v in waitcostitem)
                                {
                                    waitdata.Remove(v);
                                }
                                entity.JINSHINFINANCE035.RemoveRange(waitcostitem);
                                IsReplace = true;
                            }
                            else if (data_no.Count() > 0)
                            {
                                wait_costitem.Acc_No = data_no[0].Acc_No;
                                wait_costitem.Cost_Date = data_no[0].Cost_Date;
                                data_no.RemoveAt(0);
                            }
                            itemsn = 1;
                            foreach (var item in p.OrderBy(o => o.Acc_No))
                            {
                                item.Item = itemsn;
                                dataidx = dataidx + 1;
                                JINSHINFINANCE035 addobj = ImportData(datacenter, item, actionAdd);
                                if (item.Amount == 23995)
                                {
                                    //   string str = "";
                                }
                                if (addobj == null)
                                {
                                    if (IsReplace && datactl != actionPaste && datactl != actionIndicateAdd)
                                    {
                                        if (acc_no.IndexOf("WF") != -1)
                                        {
                                            data_no.Add(new JINSHINFINANCE035()
                                            {
                                                Acc_No = item.Acc_No,
                                                Cost_Date = item.Cost_Date
                                            });
                                        }
                                        item.Acc_No = wait_costitem.Acc_No;
                                        //   item.Cost_Date = wait_costitem.Cost_Date;
                                        //  item.SN
                                    }
                                    entity.JINSHINFINANCE035.Add(item);
                                }
                                itemsn = itemsn + 1;
                            }
                        }
                        entity.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                string str = ex.ToString();
            }
        }

        private JINSHINFINANCE035 SetImportStatus(JINSHINFINANCE035 valdata)
        {
            valdata.Is_Update = true;
            valdata.Rec_Type = 9;
            valdata.Is_Reserved = true;
            valdata.Is_Process = 2;
            return valdata;
        }

        private JINSHINFINANCE035 AddReverseBooks( JINSHINFINANCE035 reserve_data)
        {
            JINSHINFINANCE035 book = new JINSHINFINANCE035();
            book.Acc_No = reserve_data.Acc_No;
            book.Cost_Date = reserve_data.Cost_Date;
            book.Acc_ID = reserve_data.Acc_ID;
            book.Acc_Desc =reserve_data.Acc_Desc;
            if (reserve_data.DataType == 1)
                book.DataType = 2;
            else
                book.DataType = 1;
            book.Amount = reserve_data.Amount;
            book.Cost_M =reserve_data.Cost_M;
            return book;
        }

        private JINSHINFINANCE035 ImportDataReverse(List<JINSHINFINANCE035> datacenter, JINSHINFINANCE035 book, string action)
        {
            if (book.Acc_Desc.Length >= 16)
            {
                //取得沖帳傳票
                string acc_no = book.Acc_Desc.Substring(3, 13);
                return datacenter.Where(o => o.Acc_No == acc_no && book.Item == o.Item).FirstOrDefault();
            }
            return null;
        }
        private  JINSHINFINANCE035 ImportData(List<JINSHINFINANCE035> datacenter, JINSHINFINANCE035 book,string action)
        {
            if (action == ImportActions.actionAdd || action == ImportActions.actionDel || action == ImportActions.actionWait)
            {
                return datacenter.
                    Where(o => o.Acc_ID == book.Acc_ID && o.Acc_No == book.Acc_No
                    && o.DataType == book.DataType ).FirstOrDefault();
            }
            else if ( action == ImportActions.actionPaste)
            {
                return datacenter.
                   Where(o => o.Acc_ID == book.Acc_ID && o.Acc_No == book.Acc_No
                   && o.DataType == book.DataType && o.Item == book.Item).FirstOrDefault();
            }           
            else if (action == ImportActions.actionAddUpdate)
            {
                return datacenter.
                    Where(o => o.SN == book.SN
                   ).FirstOrDefault();
            }
            return default(JINSHINFINANCE035);
        }

        private void btnVerifyAccExport_Click(object sender, EventArgs e)
        {
            using (GridViewBase grid = new GridViewBase())
            {
                grid.ExportDataGridView(pathmodel.exportPath, "Acc_Confirm", dgControl);
            }
        }

        private void txtDataCnt_KeyUp(object sender, KeyEventArgs e)
        {
            bool error = false;
            using (SysSettingCtl setting = new SysSettingCtl())
            {
                if (!setting.GetNumberText(txtDataCnt.Text))
                {
                    MessageBox.Show("編碼位數一定要輸入數字!");
                    error = true;
                }
            }
            if (error)
               return;
            FormConfig.CostItemInitCnt = Convert.ToInt32(txtDataCnt.Text);
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities accbook = content.GetEntity())
                {
                    var data = accbook.JINSHINFINANCE035.Where(o=>o.Cost_Date.Value.Year == AccountingReso.yearnow && (o.Cost_Date.Value.Month == 1 || o.Cost_Date.Value.Month == 2)).ToList();
                    var lst = data.GroupBy(o => o.Acc_No).ToList();
                    int cnt = 1;
                    foreach (var item in lst)
                    {
                        cnt = 1;
                        foreach (var v in item)
                        {
                            v.Item = cnt;
                            cnt++;
                        }
                    }
                    accbook.SaveChanges();
                }                
            }
        }

        private void dgControl_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgControl.Rows.Count > 0)
              dgControl.BeginEdit(false);
        //    dgControl.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
        }

        private void dgControl_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgControl.Rows.Count > 0)
              dgControl.BeginEdit(false);
           // dgControl.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
        }

        private void btnTestEdit_Click(object sender, EventArgs e)
        {
            if (dgControl.CurrentCell != null)
                dgControl.BeginEdit(false);
        }

        private void btnInvCheck_Click(object sender, EventArgs e)
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities accbook = content.GetEntity())
                {
                    var data = accbook.JINSHINFINANCE035.Where(o => o.Cost_Date.Value.Year 
                    == AccountingReso.yearnow ).ToList();
                    var lst = data.GroupBy(o => o.Acc_No).OrderBy(i=>i.First().Acc_No).ToList();
                    int cnt = 1;
                    int datacnt = AccountingReso.accnoLen;
                    int len = 0;
                    int num = 0;
                    lstList.Items.Clear();
                    string title = "";
                    string pretitle = "";
                    foreach (var item in lst)
                    {
                        len = item.First().Acc_No.Length;
                        title = item.First().Acc_No.Substring(0, len - datacnt);
                        if (pretitle != title)
                        {
                            cnt = 1;
                        }
                   //     len = item.First().Acc_No.Length;
                        num = Convert.ToInt32(item.First().Acc_No.Substring(len - datacnt,datacnt));
                        if (num != cnt)
                        {
                            lstList.Items.Add(item.First().Acc_No.ToString());
                        }
                        cnt++;
                        pretitle = item.First().Acc_No.Substring(0, len - datacnt);
                    }
                    accbook.SaveChanges();
                }
            }
        }

        private void btnMontnApply_Click(object sender, EventArgs e)
        {
            AccBookParams inputdata = SetConditionData();
            Accctl.DataShowFormList<JINSHINFINANCE035>(dgControl, inputdata, FormConfig.CostItemInitCnt);
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    foreach (var item in ctl01.JINSHINFINANCE035)
                    {
                        var val = entity.JINSHINFINANCE035.Where(v => item.SN == v.SN).FirstOrDefault();
                        if (val != null)
                        {
                            val.Status = coststatus.monthtaxapply;
                        }
                    }
                    entity.SaveChanges();
                }
            }
            dgControl.Refresh();
            inputdata.Dispose();
        }

        private void dgControl_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                if (e.Value != null)
                {
                    bool data = Convert.ToBoolean(e.Value);
                    if (!data)
                        e.Value = null;
                }
            }
        }
    }
}
