using JINSHIN.BUSINESS.LIBARY.Base;
using JINSHIN.FinanceAccounting.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceAccountProgram.Models.Accounts
{
    public class AccNameLink :JBase
    {
        public DateTime CostDate { get; set; }
        public JINSHINFINANCE040 accname { get; set; }
        public int datatype { get; set; }
    }
}
