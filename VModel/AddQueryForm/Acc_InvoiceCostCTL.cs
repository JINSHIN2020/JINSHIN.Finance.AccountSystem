
using FinanceAccountProgram.Models;
using JINSHIN.FinanceAccounting.DB;
using FinanceAccountProgram.VModel.Conrols.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JINSHIN.BUSINESS.LIBARY.Models.UIControls;
using JINSHIN.FinanceAccount.Libary.VModels;
using JINSHIN.FinanceAccounting.DB.VModel;

namespace FinanceAccountProgram.VModel.AddQueryForm
{
    public class Acc_InvoiceCostCTL : AccAddQueryFormBase
    {
        public Invoice_ContrctCtl ctl { get; set; }
        public Acc_InvoiceCostCTL()
        {
            ctl = new Invoice_ContrctCtl();
        }
        /// <summary>
        /// datetime 為中華民國年
        /// </summary>
        /// <param name="invoices"></param>
        /// <param name="datapath05"></param>
        /// <param name="IsDelete"></param>
        /// <returns></returns>
        public List<string> SaveData(List<JINSHINFINANCE058> invoices, string datapath05,bool IsDelete)
        {
            List<string> rs = new List<string>();
            if (IsDelete)
            {
                ctl.RefreshDel();
            }
            List<string> names = new List<string> { "SN", "Acc_M", "Acc_ID", "acc_date", "Inv_M", "Inv_Date", "Acc_No", "Acc_Desc", "Inv_Class","Inv_DetailClass", "DataType", "Amount", "Is_Inv","CostType" };
            List<string> types = new List<string> {"long", "int", "string", "datetime", "int", "datetime", "string", "string", "int","int", "int", "decimal", "bool","int" };
            List<string> keynames = new List<string> { "Acc_Date",   "Invoice_No","Acc_Desc"};
            List<string> keytypes = new List<string> {  "datetime",  "string","string" };
            List<NameValues> items = new List<NameValues>();
            List<NameValues> keyitems = new List<NameValues>();
            AccBaseCtl acc_ctl = new AccBaseCtl();
            List<string> files = acc_ctl.GetDataFile(datapath05);
            FunctionControl functl = new FunctionControl();
            JINSHINFINANCE058 temp = new JINSHINFINANCE058();
            try
            {
                using (AccountEntityDB content = new AccountEntityDB())
                {
                    using (AccountEntities entities = content.GetEntity())
                    {
                        var costitem = entities.JINSHINFINANCE035.ToList();
                        for (int i = 0; i < files.Count; i++)
                        {
                            List<string> data = File.ReadAllLines(files[i], Encoding.GetEncoding(950)).ToList();
                            data.RemoveAt(0);
                            for (int j = 0; j < data.Count; j++)
                            {
                                string[] values = data[j].Split(',');
                                SetNameValueData(names, types, items, values);
                                JINSHINFINANCE058 inv = new JINSHINFINANCE058();
                                functl.SetClassObj<JINSHINFINANCE058>(inv, items);
                                inv.CreateTime = DateTime.Now;
                                if (inv.Acc_M == null)
                                {
                                    inv.Acc_M = Convert.ToInt32(inv.Acc_No.Substring(7, 2));
                                }
                                invoices.Add(inv);
                            }
                        }
                    
                    string preacc = "";
                    int item = 1;
                    List<string> keyvalues = new List<string>();
                    foreach (var data in invoices.OrderBy(o => o.Acc_ID).ToList())
                    {
                        var costdata = costitem.Where(o => o.Acc_No == data.Acc_No
                        && o.Acc_ID == data.Acc_ID
                        && o.DataType == data.DataType).FirstOrDefault();
                        keyvalues.Clear();
                        if (costdata != null)
                        {
                            keyvalues.Add(costdata.Cost_Date.Value.ToString("yyyy/MM/dd"));
                            //    keyvalues.Add(costdata.Cost_M.ToString());
                            keyvalues.Add(costdata.Invoice_No.ToString());
                            keyvalues.Add(costdata.Acc_Desc.ToString());
                            SetNameValueData(keynames, keytypes, keyitems, keyvalues.ToArray());
                            functl.SetClassObj<JINSHINFINANCE058>(data, keyitems);
                            data.Is_Fill = true;
                        }
                        else
                        {
                            data.Is_Fill = false;
                        }

                        data.CostType = dbclass.GetAccIncDec(data.Acc_ID, data.DataType.Value);
                        if (data.Acc_ID == preacc)
                        {
                            data.Item = item;
                            item = item + 1;
                        }
                        else
                        {
                            item = 1;
                            data.Item = 1;
                            item = item + 1;
                        }
                        preacc = data.Acc_ID;
                    }
                    rs.Add("count:" + invoices.Count.ToString());
                    foreach (var a in invoices.ToList()) // for testing
                    {
                        if (a.Inv_Date != null)
                            a.Inv_Date = a.Inv_Date.Value.AddYears(1911);
                        if (a.Acc_Date != null)
                            a.Acc_Date = a.Acc_Date.Value.AddYears(1911);
                        temp = a;
                        entities.JINSHINFINANCE058.Add(a);
                        entities.SaveChanges();
                    }
                    //   entities.Invoice_Contract.AddRange(invoices);
                    //  entities.SaveChanges();
                }
            }
            }
            catch (Exception ex)
            {
                string str = ex.ToString();
            }
            finally
            {
                acc_ctl.Dispose();
                functl.Dispose();
            }
            return rs;
        }

        
    }
}
