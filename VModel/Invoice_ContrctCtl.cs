using JINSHIN.BUSINESS.LIBARY.Base;
using JINSHIN.FinanceAccounting.DB;
using JINSHIN.FinanceAccounting.DB.VModel;
using System.Linq;

namespace FinanceAccountProgram.VModel
{
    public class Invoice_ContrctCtl :JBase
    {
        public void RefreshDel()
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entities = content.GetEntity())
                {
                    var invoicedata = entities.JINSHINFINANCE058.ToList();
                    entities.JINSHINFINANCE058.RemoveRange(invoicedata);
                    entities.SaveChanges();
                }
            }
        }
    }
}
