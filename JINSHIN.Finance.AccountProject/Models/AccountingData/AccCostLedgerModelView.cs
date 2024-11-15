using JINSHIN.FinanceAccounting.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceAccountProgram.Models.AccountingData
{
    public class AccCostLedgerModelView : JINSHINFINANCE036
    {
        public int DataSn { get; set; }
        public bool Is_MoneyPay { get; set; }
    }
}
