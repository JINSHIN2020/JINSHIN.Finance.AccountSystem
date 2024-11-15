using JINSHIN.FinanceAccounting.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JINSHIN.BUSINESS.LIBARY.Base;
namespace FinanceAccountProgram.Models.VerifyModel
{
    public class VerifyCostFinancialModel : JBase
    {
        public List<JINSHINFINANCE035> values { get; set; }
        public VerifyCostFinancialModel()
        {
            values = new List<JINSHINFINANCE035>();
        }
    }
}
