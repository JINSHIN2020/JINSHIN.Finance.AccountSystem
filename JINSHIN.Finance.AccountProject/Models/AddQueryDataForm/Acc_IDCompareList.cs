using JINSHIN.FinanceAccounting.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceAccountProgram.Models.AddQueryDataForm
{

    public class Acc_IDCompareList : IComparer<JINSHINFINANCE035>
    {
        public int Compare(JINSHINFINANCE035 x, JINSHINFINANCE035 y)
        {
            return x.Acc_ID.CompareTo(y.Acc_ID.ToString()) > 0 ? 1 : -1;
        }

    }
}
