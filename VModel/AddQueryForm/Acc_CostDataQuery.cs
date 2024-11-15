
using FinanceAccountProgram.Models;
using JINSHIN.FinanceAccounting.DB;
using FinanceAccountProgram.VModel.Conrols;
using FinanceAccountProgram.VModel.Conrols.Model;
using FinanceAccountProgram.VModel.Conrols.VModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JINSHIN.BUSINESS.LIBARY.Models.UIControls;
using JINSHIN.BUSINESS.LIBARY.UIControls.GridView;
using JINSHIN.FinanceAccount.Libary.Models.Base;
using JINSHIN.FinanceAccounting.DB.VModel;
using JINSHIN.FinanceAccount.Libary.Config;

namespace FinanceAccountProgram.VModel.AddQueryForm
{
    public class Acc_CostCompareClass : IEqualityComparer<JINSHINFINANCE035>
    {
       
        public bool Equals(JINSHINFINANCE035 x, JINSHINFINANCE035 y)
        {
            if ((x != null) && (y != null))
            {
                if (x.Acc_No == y.Acc_No && x.Acc_ID == y.Acc_ID && x.Acc_Desc == y.Acc_Desc)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        public int GetHashCode(JINSHINFINANCE035 obj)
        {
            return obj.GetHashCode();
          //  throw new NotImplementedException();
        }
    }
    /// <summary>
    /// entity as T
    /// </summary>
    public class Acc_CostDataQuery : AccAddQueryFormBase
    {
        public VerifyAccGridViewVModel gridctl { get; set; }
        public DBClassCtl dbclassctl { get; set; }
        public string companyId { get; set; }
        public Acc_CostDataVModel ctl { get; set; }
        public Acc_CostDataQuery()
        {            
            ctl = new Acc_CostDataVModel();
            companyId = "69746686";
        }


        /// <summary>
        /// join 如何使用IEq
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="values"></param>
        /// <param name="IsDelete"></param>
        /// <returns></returns>
        public void UpdateData(List<JINSHINFINANCE035> values)
        {
            try
            {
                using (AccountEntityDB content = new AccountEntityDB())
                {
                    using (AccountEntities entity = content.GetEntity())
                    {
                        var items = entity.JINSHINFINANCE032.ToList();
                        var data = entity.JINSHINFINANCE039.ToList();
                        List<JINSHINFINANCE035> result = new List<JINSHINFINANCE035>();
                        result = InsertData(items, data, values);
                        int item = 1;
                        string val = "";
                        foreach (var data01 in values.OrderBy(o => o.Acc_No).ThenBy(o => o.Acc_ID).ToList())
                        {
                            SetInvData(ref item, ref val, data01);
                        }
                        item = 1;
                        val = "";
                        foreach (var data01 in result.OrderBy(o => o.Acc_No).ThenBy(i => i.Acc_ID).ToList())
                        {
                            SetInvData(ref item, ref val, data01);
                        }
                        entity.JINSHINFINANCE035.AddRange(result);
                        //var others = values.Except(result);
                        bool checkresult = false;
                        List<JINSHINFINANCE035> others = new List<JINSHINFINANCE035>();
                        foreach (var i in values)
                        {
                            checkresult = false;
                            foreach (var e in items)
                            {
                                if (i.Item == e.Item && i.Acc_ID.Trim() == e.Acc_ID.Trim() && i.Acc_No.Trim() == e.Acc_No.Trim())
                                {
                                    checkresult = true;
                                }
                            }
                            if (!checkresult)
                                others.Add(i);
                        }
                        entity.SaveChanges();
                        foreach (var i in others)
                        {
                            var delobj = entity.JINSHINFINANCE035.Where(n => n.Acc_No == i.Acc_No && n.Item == i.Item && n.Acc_ID == i.Acc_ID).FirstOrDefault();
                            if (delobj != null)
                                entity.JINSHINFINANCE035.Remove(delobj);
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

        private static void SetInvData(ref int item, ref string val, JINSHINFINANCE035 data01)
        {           
            if (data01.Acc_No == val)
            {
                data01.Item = item;
                item = item + 1;
            }
            else {
                item = 1;
                data01.Item = 1;
                item = item + 1;
            }
            val = data01.Acc_No;
        }
        /// <summary>
        /// 新增修改資料
        /// </summary>
        /// <param name="items"></param>
        /// <param name="data"></param>
        /// <param name="accCostdata"></param>
        /// <returns></returns>
        private List<JINSHINFINANCE035> InsertData(List<JINSHINFINANCE032> items, List<JINSHINFINANCE039> data, List<JINSHINFINANCE035> accCostdata=default(List<JINSHINFINANCE035>))
        {
            int SN = 1;
            List<JINSHINFINANCE035> result = new List<JINSHINFINANCE035>();           
            for (int i = 0; i < items.Count; i++)
            {
                for (int j = 0; j < data.Count; j++)
                {
                    if ((items[i].Acc_No == data[j].Acc_No) &&
                        (items[i].Acc_ID == data[j].Acc_ID) &&
                        (items[i].Acc_Desc == data[j].Acc_Desc))
                    {
                        var val = default(JINSHINFINANCE035);
                        if (accCostdata != null)
                          val = accCostdata.Where(o => o.Acc_No == items[i].Acc_No && o.Acc_ID == items[i].Acc_ID &&
                        o.Acc_Desc == items[i].Acc_Desc).FirstOrDefault();
                        if (val != null)
                        {
                            SetCostItemData(items[i], data[j], SN, val);
                            result.Add(val);
                        }
                        else
                        {
                            JINSHINFINANCE035 cost = new JINSHINFINANCE035();
                            SetCostItemData(items[i], data[j], SN, cost);
                            result.Add(cost);
                        }                        
                        //  accCostdata.Add(cost);
                    }
                    SN = SN + 1;
                }
            }
            
            return result;
        }

        private void SetCostItemData(JINSHINFINANCE032 items, JINSHINFINANCE039 data, int SN, JINSHINFINANCE035 cost)
        {
            cost.Acc_Desc = items.Acc_Desc;
            cost.Acc_ID = items.Acc_ID;
            cost.Acc_No = items.Acc_No;
            cost.Amount = items.Amount;
            cost.Buy_ID = data.Buy_ID;
            cost.Sell_ID = data.Sell_ID;
            cost.Cost_Date = data.Acc_Date;
            cost.Invoice_No = data.Invoice_No;
            cost.Cost_M = data.Acc_M;
            cost.CreateTime = DateTime.Now;
            cost.SN = SN;
            cost.Buy_ID = companyId;
            cost.Rec_Type = data.Rec_Type;
            cost.DataType = Convert.ToByte(items.DataType.Value);
            cost.HasTax = data.Invoice_No != null;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="values"></param>
        /// <param name="IsDelete"></param>
        /// <returns></returns>
        public List<string> SaveData(List<JINSHINFINANCE035> values, bool IsDelete)
        {
            List<string> rs = new List<string>();
            if (IsDelete)
            {
                ctl.RefreshDel();
            }
            try
            {
                using (AccountEntityDB content = new AccountEntityDB())
                {
                    using (AccountEntities entity = content.GetEntity())
                    {
                        var items = entity.JINSHINFINANCE032.Where(o=>o.Acc_Date.Value.Year == AccountingReso.yearnow).ToList();
                        var data = entity.JINSHINFINANCE039.Where(o=>o.Acc_Date.Value.Year == AccountingReso.yearnow).ToList();
                        //var contents = from items  in items
                        List<JINSHINFINANCE035> accCostdata = new List<JINSHINFINANCE035>();
                        accCostdata = InsertData(items, data);
                        int item = 0;
                        string val = "";
                        var lstcost = accCostdata.OrderBy(o=>o.Acc_No).ToList();
                        if (lstcost.Count > 0)
                        {
                            val = lstcost[0].Acc_No;
                        }
                        foreach (var data01 in lstcost)
                        {
                            if (data01.Acc_No == val)
                                item = item + 1;
                            else
                                item = 1; 
                            data01.Item = item;
                            val = data01.Acc_No;
                            values.Add(data01);
                        }
                        rs.Add("資料筆數:" + values.Count.ToString());
                        entity.JINSHINFINANCE035.AddRange(values);

                        //*檢查三欄位數量*//
                        int count = 1;
                        List<string> keys = new List<string>();
                        foreach (var i01 in values)
                        {
                            if (keys.Count >= 2)
                            {
                                if ((keys[0] == i01.SN.ToString()) &&
                                    (keys[1] == i01.Item.ToString()) &&
                                    (keys[2] == i01.Acc_ID.ToString()))
                                {
                                    count++;
                                }
                            }
                            keys.Clear();
                            keys.Add(i01.SN.ToString());
                            keys.Add(i01.Item.ToString());
                            keys.Add(i01.Acc_ID.ToString());
                        }
                        entity.SaveChanges();
                        // msdn再確認
                        //var contents = items.Join(data, con => con, ha => ha.Acc_No,
                        //    (con, ha) => new { Acc_no = con.Acc_No }, new Acc_CostCompareClass());                    
                    }
                }
            }
            catch (Exception ex)
            {
                string str = ex.ToString();
            }
            return rs;
        }




        public void datagrid(DataGridView Dg_Control)
        {
            FunctionControl functl = new FunctionControl();
            VerifyAccGridViewVModel verifygvModel = new VerifyAccGridViewVModel();
            List<NameValues> columns = verifygvModel.columns;            
            Dg_Control.Columns.Clear();

            List<DataGridViewComboBoxColumn> dgvCombobox = new List<DataGridViewComboBoxColumn>();
            dgvCombobox.Add(new DataGridViewComboBoxColumn());
            dgvCombobox.Add(new DataGridViewComboBoxColumn());
            //dgvCombobox.Add(new DataGridViewComboBoxColumn()); 也會有還不用寫

            DataGridViewCheckBoxColumn dgvcheck = new DataGridViewCheckBoxColumn();
            GridViewFinanceBase gvb = new GridViewFinanceBase(AddQueryEnum.Acc_CostData);
            //SetDGViewColumns(dgvCombobox, dgvcheck, dbclassctl.QueryAcc_Class(), dbclassctl.QueryInv_Class());
            Dg_Control.Columns.Add(dgvCombobox[0]);
            Dg_Control.Columns.Add(dgvCombobox[1]);
            //   Dg_Control.Columns.Add(dgvCombobox[2]);
            Dg_Control.Columns.Add(dgvcheck);


            List<AccCostVerify> values = new List<AccCostVerify>();
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    var data = entity.JINSHINFINANCE035.Select(i => new VerifyAccGridView()
                    {
                        SN = i.SN,
                        Acc_Desc = i.Acc_Desc,
                        Acc_ID = i.Acc_ID,
                        Acc_No = i.Acc_No,
                        Amount = i.Amount.Value,
                        Cost_Class = i.Cost_Class ?? 0,
                        Cost_Date = i.Cost_Date.Value,
                        Cost_Detail = i.Cost_Detail ?? 0,
                        Cost_M = i.Cost_M ?? 0,
                        Verify_Month = i.Verify_Month ?? 0,
                        Cost_Type = i.Cost_Type ?? 0,
                        DataType = i.DataType.Value,
                        HasTax = i.HasTax ?? false,
                        Invoice_No = i.Invoice_No,
                        Inv_Date = i.Inv_Date.Value,
                        Rec_Type = i.Rec_Type.Value,
                        Status = i.Status ?? 0
                    }).ToList();


                    for (int j = 0; j < Dg_Control.Rows.Count; j++)
                    {
                        //SetColumnsValueFromDB(Dg_Control.Rows[j], config_columns[1], comboBoxInvClass[j] as object);
                        //SetColumnsValueFromDB(Dg_Control.Rows[j], config_columns[0], comboBox[j] as object);
                        //SetColumnsValueFromDB(Dg_Control.Rows[j], config_columns[2], checkBox[j] as object);
                    }
                    Dg_Control.Refresh();
                    Dg_Control.BeginEdit(false);
                }
            }
        }
        private void SetColumnsValueFromDB(DataGridViewRow row, VarClass vclass, object val)
        {
            row.Cells[vclass.value01].Value = val;
        }
    }
}
