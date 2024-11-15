using FinanceAccountProgram.Models;
using JINSHIN.Finance.AccountSystem.Resources;
using JINSHIN.FinanceAccount.Libary.Config;
using JINSHIN.FinanceAccount.Libary.VModels;
using JINSHIN.FinanceAccounting.DB;
using JINSHIN.FinanceAccounting.DB.VModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceAccountProgram.VModel
{
    public class AccLedgerAccount : AccBaseCtl
    {
        public virtual List<string> SaveData(List<JINSHINFINANCE040> values, bool IsDelete,int year)
        {
            List<string> rs = new List<string>();
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    try
                    {
                        var data = entity.JINSHINFINANCE040.Where(o => o.Acc_Date.Value.Year == year).ToList();
                        if (IsDelete)
                        {
                            if (data.Count() > 0)
                            {
                                entity.JINSHINFINANCE040.RemoveRange(data);
                                entity.SaveChanges();
                            }
                        }
                        var query = entity.JINSHINFINANCE032.Where(o => o.Acc_Date.Value.Year == year).ToList();
                        rs = GetDisplayString(query);
                        var accdata = query.OrderBy(o => o.Acc_ID).GroupBy(o => o.Acc_ID).ToList();
                        int sn = 1;
                        decimal amount_get = 0;
                        decimal amount_lend = 0;
                        foreach (var v in accdata)
                        {
                            amount_get = v.Where(o => o.DataType == 1).Sum(o => o.Amount).Value;
                            amount_lend = v.Where(o => o.DataType == 2).Sum(o => o.Amount).Value;
                            values.Add(new JINSHINFINANCE040()
                            {
                                SN = sn,
                                Acc_ID = v.First().Acc_ID,
                                Acc_Date = v.First().Acc_Date.Value,
                                Acc_Desc = v.First().Acc_Desc,
                                CreateTime = DateTime.Now,
                                Acc_Year = AccountingReso.yearnow
                            });
                            SetAmountData(values[sn - 1], amount_get, amount_lend);
                            sn = sn + 1;
                        }
                        // values.AddRange(accdata);                
                        entity.JINSHINFINANCE040.AddRange(values);
                        entity.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        string str = ex.ToString();

                    }
                }
            }
            return rs;
        }

        

        public List<JINSHINFINANCE040> GetData(int year)
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    List<JINSHINFINANCE040> data = entity.JINSHINFINANCE040.Where(o => o.Acc_Year == year).ToList();
                    return data;
                }
            }
        }
    }
}
