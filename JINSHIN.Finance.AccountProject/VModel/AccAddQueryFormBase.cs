using FinanceAccountProgram.Inc;
using FinanceAccountProgram.Models;
using FinanceAccountProgram.Models.Config.UpdataeForm;
using FinanceAccountProgram.Models.UControl;
using JINSHIN.Finance.AccountSystem.Resources;
using JINSHIN.FinanceAccounting.DB;
using FinanceAccountProgram.VModel.AddQueryForm;

using FinanceAccountProgram.VModel.Conrols.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JINSHIN.FinanceAccount.Libary.Config;
using JINSHIN.FinanceAccount.Libary.VModels;
using JINSHIN.FinanceAccounting.DB.VModel;
using FinanceAccountProgram.VModel.Business;

namespace FinanceAccountProgram.VModel
{
    public class AccAddQueryFormBase: AccBaseCtl
    {
        public List<JINSHINFINANCE040> accledger { get; set; }
        public List<VerifyAccGridView> JINSHINFINANCE035 { get; set; }
        public List<JINSHINFINANCE035> acc_orgcostitem { get; set; }
        public List<Invoice_ContractModel> invoice_contract { get; set; }
        public DBClassCtl dbclass { get; set; }
        public AccAddQueryFormBase()
        {
            acc_orgcostitem = new List<JINSHINFINANCE035>();
            invoice_contract = new List<Invoice_ContractModel>();
        }

        public List<JINSHINFINANCE035> GetStorageData(AccountEntities entity, string typename, AccBookParams paramdata)
        {
            List<JINSHINFINANCE035> rs = entity.JINSHINFINANCE035.Where(o => (
            ((o.Rec_Type == paramdata.AccVal.value) || !paramdata.AccVal.enable) &&
            ((o.Cost_Class == paramdata.MasterVal.value) || !paramdata.MasterVal.enable) &&
            ((o.Cost_Detail == paramdata.ContentVal.value) || !paramdata.ContentVal.enable))).ToList();         
            return rs;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="datalist"></param>
        /// <returns></returns>
        private List<JINSHINFINANCE035> GetAccountData(List<JINSHINFINANCE035> datalist)
        {
            using (FinancialRptVModel financial = new FinancialRptVModel())
            {
                return datalist = financial.CheckOK(datalist);
            }
        }

        /// <summary>
        /// use in Acc_Confirm Tab
        /// 已經過濾沖帳項目
        /// </summary>
        /// <param name="typename"></param>
        /// <param name="paramdata"></param>
        /// <returns></returns>
        public List<VerifyAccGridView> GetData(string typename, DataParams paramdata,bool IsChecked)
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    List<VerifyAccGridView> rs = new List<VerifyAccGridView>();
                    var contents = AccCostItemConfig.GetClassData(
                        entity.JINSHINFINANCE035.Where(o => 
                        o.Cost_Date.Value.Year == AccountingReso.yearnow).ToList());

                    var list = contents.Where(o => (o.Cost_Check == false 
                    || o.Cost_Check == null || IsChecked)
                    ).ToList();

                    list = GetAccountData(list);

                    var listg = list.Where(o => (
                    (o.Acc_ID == paramdata.data005.data || !paramdata.data005.enable) &&
                    (o.Acc_Desc.IndexOf(paramdata.data003.data) != -1 || !paramdata.data003.enable)
                    )).GroupBy(o => new { o.Acc_ID, o.Acc_No }).ToList();
                    try
                    {
                        acc_orgcostitem.Clear();
                        foreach (var item in listg)
                        {
                            JINSHINFINANCE035 cost = item.First();
                            var costitems = entity.JINSHINFINANCE035.Where(o => o.Acc_No == cost.Acc_No).ToList();
                            var verifyAccGriditem = costitems.Select(i => new VerifyAccGridView()
                            {
                                SN = i.SN,

                                Acc_Desc = i.Acc_Desc,
                                Acc_ID = i.Acc_ID,
                                Item = i.Item,
                                Acc_No = i.Acc_No,
                                Amount = i.Amount.Value,
                                Cost_Class = i.Cost_Class ?? 0,
                                Cost_Date = i.Cost_Date.Value,
                                Cost_Detail = i.Cost_Detail ?? 0,
                                Cost_M = i.Cost_M ?? 0,
                                Verify_Month = i.Verify_Month,
                                Cost_Type = i.Cost_Type ?? 0,
                                DataType = i.DataType.Value,
                                HasTax = i.HasTax ?? false,
                                Invoice_No = i.Invoice_No,
                                Inv_Date = i.Inv_Date,
                                Rec_Type = i.Rec_Type ?? 0,
                                Status = i.Status ?? 0,
                                Cost_Check = i.Cost_Check,
                                Check_Date = i.Check_Date
                            }).OrderBy(o => o.DataType).ToList();
                            acc_orgcostitem.AddRange(costitems);
                            rs.AddRange(verifyAccGriditem);
                        }
                    }
                    catch (Exception)
                    {

                    }
                    return rs;
                }
            }
        }

        public List<VerifyAccGridView> GetData(string typename, AccBookParams paramdata)
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    List<VerifyAccGridView> rs = new List<VerifyAccGridView>();
                    var list = entity.JINSHINFINANCE035.Select(i => new VerifyAccGridView()
                    {
                        SN = i.SN,
                        Acc_Desc = i.Acc_Desc,
                        Acc_ID = i.Acc_ID,
                        Item = i.Item,
                        Acc_No = i.Acc_No,
                        Amount = i.Amount ??0,
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
                        Rec_Type = i.Rec_Type ?? 0,
                        Status = i.Status ?? 0,
                        Buy_ID = i.Buy_ID,
                        Sell_ID = i.Sell_ID,
                        Is_Reserved = i.Is_Reserved,
                        IsSysAutoFill = i.IsSysAutoFill ?? false
                    }).ToList();

                    list = list.Where(o => (
                    ((o.Rec_Type == paramdata.AccVal.value) || !paramdata.AccVal.enable) &&
                    ((o.Cost_Class == paramdata.MasterVal.value) || !paramdata.MasterVal.enable) &&
                    ((o.Cost_Detail == paramdata.ContentVal.value) || !paramdata.ContentVal.enable) &&
                    (o.Acc_No == paramdata.Acc_No.data || !paramdata.Acc_No.enable) &&
                    (o.Acc_ID == paramdata.Acc_ID.data || !paramdata.Acc_ID.enable) &&
                    (o.Acc_Desc.IndexOf(paramdata.Desc.data) != -1 || !paramdata.Desc.enable) &&
                    (o.Cost_M == paramdata.Months.value || !paramdata.Months.enable) &&
                    (o.Amount == paramdata.Amount.value || !paramdata.Amount.enable) &&
                    (o.Cost_Date.Value.Year == paramdata.Year.value || !paramdata.Year.enable)
                    )).ToList();

                    List<VerifyAccGridView> grids = new List<VerifyAccGridView>();
                    foreach (var item in list)
                    {
                        if (item.Invoice_No != null)
                        {
                            if (item.Invoice_No.IndexOf(paramdata.invoice.data) != -1)                                
                            {
                                grids.Add(item);
                            }
                        }else if ((paramdata.invoice.data == null) || (paramdata.invoice.data == ""))                        
                        {
                            grids.Add(item);
                        }
                    }
                    grids =grids.OrderBy(o => o.Cost_Date).ThenBy(o => o.Acc_No).ThenBy(o => o.Item).ThenBy(o => o.DataType)
                    .Take(FormConfig.CostItemInitCnt).ToList();
                    
                    return grids;
                }
            }
        }

        public void GetData(string typename,int val01=0,int val02=0) 
        {
            try
            {
                using (AccountEntityDB content = new AccountEntityDB())
                {
                    using (AccountEntities entity = content.GetEntity())
                    {
                        switch (typename)
                        {
                            case QueryFrmString.JINSHINFINANCE040:
                                {
                                    accledger = entity.JINSHINFINANCE040.ToList();
                                }
                                break;
                            case QueryFrmString.JINSHINFINANCE035:
                                {
                                    if (val01 != 0)
                                        acc_orgcostitem = entity.JINSHINFINANCE035.Where(o => (o.Cost_Class == val01) && (o.Cost_Date.Value.Year == AccountingReso.yearnow)).ToList();
                                    else
                                        acc_orgcostitem = entity.JINSHINFINANCE035.Where(o => o.Cost_Date.Value.Year == AccountingReso.yearnow).ToList();
                                }
                                break;
                            case QueryFrmString.Invoice_contract:
                                {
                                    if ((val01 != 0) && (val02 != 0))
                                    {
                                        //invoice_contract
                                        List<JINSHINFINANCE058> values = entity.JINSHINFINANCE058.Where(o => o.Inv_Class == val01 && o.Inv_DetailClass == val02).ToList();
                                        invoice_contract = GridViewInvoice_Contract(values);
                                    }
                                    else if (val01 != 0)
                                    {
                                        List<JINSHINFINANCE058> values = entity.JINSHINFINANCE058.Where(o => o.Inv_Class == val01).ToList();
                                        invoice_contract = GridViewInvoice_Contract(values);
                                    }
                                    else
                                    {
                                        List<JINSHINFINANCE058> values = entity.JINSHINFINANCE058.ToList();
                                        invoice_contract = GridViewInvoice_Contract(values);
                                    }
                                }
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string str = ex.ToString();
            }
            
        }

        public List<Invoice_ContractModel> GridViewInvoice_Contract(List<JINSHINFINANCE058> values)
        {
            invoice_contract.Clear();
            var class01 = dbclass.QueryAcc_Class();
            var class02 = dbclass.QueryAcc_Detail();
            string classtype01 = "", classtype02 = "", costtype = "";
            JINSHINFINANCE034 aclass = default(JINSHINFINANCE034);
            if (values.Count > 0)
            {
                foreach (var o in values)
                {
                    aclass = class01.Where(v => v.No == o.Inv_Class).FirstOrDefault();
                    classtype01 = aclass.Name;
                    classtype02 = class02.Where(v => v.No == o.Inv_DetailClass && v.MaNo == aclass.No).FirstOrDefault() == null ? "" : class02.Where(v => v.No == o.Inv_DetailClass).FirstOrDefault().Name;
                    costtype = dbclass.GetAccIncDec(o.Acc_ID, o.DataType.Value) == 1 ? "增加" : "減少";
                    Invoice_ContractModel imodel = new Invoice_ContractModel()
                    {
                        SN = o.SN,
                        Acc_ID = o.Acc_ID,
                        Item = o.Item,
                        Acc_Date = o.Acc_Date.Value,
                        Acc_No = o.Acc_No,
                        Invoice_No = o.Invoice_No,
                        Inv_Class = classtype01,                 
                        Acc_Desc = o.Acc_Desc,
                        Acc_M = o.Acc_M.Value,
                        DataType = o.DataType.Value,
                        Amount = o.Amount.Value,
                        CostName = costtype,
                        Inv_M = o.Inv_M.Value,
                    };
                    if (o.Inv_Date != null)
                    {
                        imodel.Inv_Date = o.Inv_Date.Value;
                    }
                    if (classtype02 != null)
                    {
                        imodel.Inv_DetailClass = classtype02;
                    }
                    invoice_contract.Add(imodel);
                }
            }
            return invoice_contract;
        }

        public List<Invoice_ContractAddModel> GridViewAddContractModel(List<JINSHINFINANCE058> values)
        {
            List<Invoice_ContractAddModel> rs = new List<Invoice_ContractAddModel>();
            var class01 = dbclass.QueryAcc_Class();
            var class02 = dbclass.QueryAcc_Detail();
            string classtype01 = "", classtype02 = "", costtype = "";
            JINSHINFINANCE034 aclass = default(JINSHINFINANCE034);
            if (values.Count > 0)
            {
                foreach (var o in values)
                {
                    aclass = class01.Where(v => v.No == o.Inv_Class).FirstOrDefault();
                    classtype01 = aclass.Name;
                    classtype02 = class02.Where(v => v.No == o.Inv_DetailClass && v.MaNo == aclass.No).FirstOrDefault() == null ? "" : class02.Where(v => v.No == o.Inv_DetailClass).FirstOrDefault().Name;
                    costtype = dbclass.GetAccIncDec(o.Acc_ID, o.DataType.Value) == 1 ? "增加" : "減少";
                    Invoice_ContractAddModel imodel = new Invoice_ContractAddModel()
                    {
                        SN = o.SN,
                        Acc_ID = o.Acc_ID,
                        Item = o.Item,
                        Acc_Date = o.Acc_Date.Value,
                        Acc_No = o.Acc_No,
                        Invoice_No = o.Invoice_No,
                        Inv_Class = classtype01,
                        Acc_Desc = o.Acc_Desc,
                        Acc_M = o.Acc_M.Value,
                        DataType = o.DataType.Value,
                        Amount = o.Amount.Value,
                        CostName = costtype,
                        Inv_M = o.Inv_M.Value,
                        Is_Fill = o.Is_Fill ?? false,
                        Is_Verify = o.Is_Verify ?? false,
                        Is_Inv =o.Is_Inv ?? false
                    };
                    if (o.Inv_Date != null)
                    {
                        imodel.Inv_Date = o.Inv_Date.Value;
                    }
                    if (classtype02 != null)
                    {
                        imodel.Inv_DetailClass = classtype02;
                    }
                    rs.Add(imodel);
                }
            }
            return rs;
        }
    }
}
