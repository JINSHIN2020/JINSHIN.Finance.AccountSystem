using JINSHIN.FinanceAccounting.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JINSHIN.Finance.AccountSystem.VModel.Business.Assets
{
    public class Jin051Model : JINSHINFINANCE051
    {
        public decimal AccRemainVal { get; set; }
        public int datamonths { get; set; }
        public int Ttlmonths { get; set; }
        public double monthcost { get; set; }
    }
}
