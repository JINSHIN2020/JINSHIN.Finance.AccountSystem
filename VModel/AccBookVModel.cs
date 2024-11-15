using FinanceAccountProgram.Models;
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
    public class AccBookVModel : AccBaseCtl
    {
        public List<string> SaveLedgerAccountData(List<JINSHINFINANCE040> values,bool IsDelete)
        {
            List<string> rs = new List<string>();
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    if (IsDelete)
                    {
                        if (entity.JINSHINFINANCE040.Count() > 0)
                        {
                            var item = entity.JINSHINFINANCE040.ToList();
                            entity.JINSHINFINANCE040.RemoveRange(item);
                            entity.SaveChanges();
                        }
                    }
                    var query = entity.JINSHINFINANCE032.ToList();
                    decimal get = 0, lend = 0;
                    get = query.Where(o => o.DataType == 1).Sum(o => o.Amount).Value;
                    rs.Add(get.ToString("##0"));
                    lend = query.Where(o => o.DataType == 2).Sum(o => o.Amount).Value;
                    rs.Add(lend.ToString("##0"));
                    rs.Add(get == lend ? "本年度借貸平衡" : "本年度借貸不平衡");
                    var accdata = entity.JINSHINFINANCE032.OrderBy(o => o.Acc_ID).GroupBy(o => o.Acc_ID).ToList();
                    int sn = 1;
                    //decimal totalamount = 0;
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
                            CreateTime = DateTime.Now
                        });
                        SetAmountData(values[sn - 1], amount_get, amount_lend);
                        sn = sn + 1;
                    }
                    // values.AddRange(accdata);                
                    entity.JINSHINFINANCE040.AddRange(values);
                    entity.SaveChanges();
                }
            }
            return rs;
        }
       
    }
}
