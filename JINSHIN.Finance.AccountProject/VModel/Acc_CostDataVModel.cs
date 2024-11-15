using FinanceAccountProgram.Models;
using JINSHIN.FinanceAccounting.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JINSHIN.BUSINESS.LIBARY.Base;
using JINSHIN.FinanceAccounting.DB.VModel;
using JINSHIN.FinanceAccount.Libary.Config;

namespace FinanceAccountProgram.VModel
{
    public class Acc_CostDataVModel :JBase
    {
        public void DeleteAcc_CostData(string invoiceNo, string item)
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entities = content.GetEntity())
                {
                    var costdata = entities.JINSHINFINANCE035.Where(o => o.Invoice_No == invoiceNo && o.Item == int.Parse(item)).FirstOrDefault();
                    entities.JINSHINFINANCE035.Remove(costdata);
                    entities.SaveChanges();
                }
            }
        }
        public void RefreshDel()
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entities = content.GetEntity())
                {
                    var costdata = entities.JINSHINFINANCE035.Where(o=>o.Cost_Date.Value.Year == AccountingReso.yearnow).ToList();
                    entities.JINSHINFINANCE035.RemoveRange(costdata);
                    entities.SaveChanges();
                }
            }
        }
        public List<JINSHINFINANCE035> QueryAcc_CostData()
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entities = content.GetEntity())
                {
                    return entities.JINSHINFINANCE035.ToList();
                }
            }
        }
    }
}
