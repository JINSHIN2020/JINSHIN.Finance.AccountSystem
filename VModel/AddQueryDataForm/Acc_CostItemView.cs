using FinanceAccountProgram.Models;
using JINSHIN.FinanceAccounting.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceAccountProgram.VModel.AddQueryDataForm
{
    public class JINSHINFINANCE035View : JINSHINFINANCE035
    {
        public decimal DstAmount { get; set; }
        public decimal DstMonth { get; set; }
    }
}
