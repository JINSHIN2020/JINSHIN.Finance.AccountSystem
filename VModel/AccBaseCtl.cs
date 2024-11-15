
using FinanceAccountProgram.Models;
using FinanceAccountProgram.Models.AddQueryDataForm;

using JINSHIN.FinanceAccounting.DB;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using JINSHIN.BUSINESS.LIBARY.Models.UIControls;
using JINSHIN.BUSINESS.LIBARY.Models.Base;
using JINSHIN.FinanceAccount.Libary.Models.Financial;

namespace FinanceAccountProgram.VModel
{/// <summary>
/// spare the others business model
/// </summary>
    public class AccBaseCtl :JBase
    {
        public List<string> keynames = new List<string> { "Rec_Type","Invoice_No","Cost_Class", "Cost_Detail", "Cost_Type", "Verify_Month" };
        public List<string> keytypes = new List<string> { "int", "string", "int", "int", "int", "byte" };
        /// <summary>
        /// after computing if sing = -1,then reserved
        /// </summary>
        /// <param name="val"></param>
        /// <param name="datatype"></param>
        /// <returns></returns>
        public AccidAccount ConvertDataTypeAmount(decimal val,byte datatype)
        {
            AccidAccount result = new AccidAccount();
            if (Math.Sign(val) > 0)
            {
                result.amount = val;
                result.datatypectl = datatype;
            }
            else
            {
                result.amount = Math.Abs(val);                
                result.datatypectl = datatype == byte.Parse("1") ? byte.Parse("2") : byte.Parse("1");
            }
            return result;
        }
       
        public ContentCostLink SetValueToLink(List<Invoice_Contract> invoicesContract, List<Acc_InvoiceBook> invoices, Acc_CostItem data)
        {
            ContentCostLink data01 = new ContentCostLink();
            var items01 = invoicesContract.Where(o => o.Acc_No == data.Acc_No
            && o.Acc_ID == data.Acc_ID
            && o.DataType == data.DataType).ToList();
            var items02 = invoices.Where(o => o.Acc_No == data.Acc_No
             && o.Acc_ID == data.Acc_ID
             && o.DataType == data.DataType).ToList();
            if (items01.Count() <= 1)
                data01.icontract = items01.FirstOrDefault();
            else
            {
                data01.icontract = invoicesContract.Where(o => o.Acc_No == data.Acc_No &&
                o.Acc_ID == data.Acc_ID && o.Acc_Desc == data.Acc_Desc).FirstOrDefault();
            }
            if (items02.Count() <= 1)
                data01.iinvoicebook = items02.FirstOrDefault();
            else
            {
                data01.iinvoicebook = invoices.Where(o => o.Acc_No == data.Acc_No &&
                o.Acc_ID == data.Acc_ID && o.Acc_Desc == data.Acc_Desc).FirstOrDefault();
            }
            return data01;
        }

        public List<string> GetDataFile(string basepath)
        {
            List<string> rs = new List<string>();
            DirectoryInfo di = new DirectoryInfo(basepath);
            foreach (var i in di.GetFiles())
            {
                rs.Add(i.FullName);
            }
            return rs;
        }
        public List<string> CheckLendOrGet(string get, string lend)
        {
            List<string> result = new List<string>();
            if (string.IsNullOrEmpty(lend.Trim()) == false && string.IsNullOrEmpty(get))
            {
                result.Add("2");
                result.Add(lend.Trim());
                return result;
            }
            else if (string.IsNullOrEmpty(get.Trim()) == false && string.IsNullOrEmpty(lend))
            {
                result.Add("1");
                result.Add(get.Trim());
            }
            return result;
        }
        public void SetAmountData(Acc_Ledger val, decimal data01, decimal data02)
        {
            decimal computevalue = data01 - data02;
            if (computevalue >= 0)
            {
                val.DataType = 1;
                val.Amount = computevalue;
            }
            else
            {
                val.DataType = 2;
                val.Amount = computevalue * -1;
            }
        }
        public void SetAmountData(Acc_CostLedger val, decimal data01, decimal data02)
        {
            decimal computevalue = data01 - data02;
            if (computevalue >= 0)
            {
                val.DataType = 1;
                val.Amount = computevalue;
            }
            else
            {
                val.DataType = 2;
                val.Amount = computevalue * -1;
            }
        }

        public List<string> GetDisplayString<T>(List<T> query)
        {
            List<string> rs = new List<string>();
            if (query.Count() > 0)
            {
                decimal get = 0, lend = 0;
                if (query[0] is Acc_Book)
                {
                    List<Acc_Book> values = query as List<Acc_Book>;
                    get = values.Where(o => o.DataType == 1).Sum(o => o.Amount).Value;                    
                    lend = values.Where(o => o.DataType == 2).Sum(o => o.Amount).Value;                    
                }
                else if (query[0] is Acc_Ledger)
                {
                    List<Acc_Ledger> values = query as List<Acc_Ledger>;
                    get = values.Where(o => o.DataType == 1).Sum(o => o.Amount).Value;
                    lend = values.Where(o => o.DataType == 2).Sum(o => o.Amount).Value;
                }
                else if (query[0] is Acc_CostItem)
                {
                    List<Acc_CostItem> values = query as List<Acc_CostItem>;
                    get = values.Where(o => o.DataType == 1).Sum(o => o.Amount).Value;
                    lend = values.Where(o => o.DataType == 2).Sum(o => o.Amount).Value;
                }
                rs.Add("本年度產生借方："+get.ToString("##0"));
                rs.Add("本年度產生貸方："+lend.ToString("##0"));
                rs.Add(get == lend ? "本年度借貸平衡" : "本年度借貸不平衡");
            }
            return rs;
        }

        public void SetNameValueData(List<string> names, List<string> types, List<NameValues> items, string[] values)
        {
            items.Clear();
            try
            {
                for (int k = 0; k < values.Count(); k++)
                {
                    NameValues nameval = new NameValues();
                    nameval.name = names[k];
                    if (types[k].ToUpper() == "INT")
                    {
                        nameval.value = values[k] == "" ? "0" : values[k];
                        nameval.dbvalue = values[k] == "" ? "0" : values[k];
                    }
                    else
                    {
                        nameval.value = values[k] == "" ? null : values[k];
                        nameval.dbvalue = values[k] == "" ? null : values[k];
                    }
                    nameval.datatype = types[k];
                    nameval.ConvertTo(nameval.value);
                    items.Add(nameval);
                }
            }
            catch (Exception ex)
            {
                string str = ex.ToString();
            }
        }
    }
}
