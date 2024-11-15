using JINSHIN.FinanceAccounting.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceAccountProgram.VModel.AddQueryForm
{
    public class Acc_CostCompareUpdate: IEqualityComparer<JINSHINFINANCE035>
    {

        public bool Equals(JINSHINFINANCE035 x, JINSHINFINANCE035 y)
        {
            if ((x != null) && (y != null))
            {
                if (x.Acc_No == y.Acc_No && x.Acc_ID == y.Acc_ID && x.Cost_Date == y.Cost_Date)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        public int GetHashCode(JINSHINFINANCE035 obj)
        {
            return obj.GetHashCode();
            //  throw new NotImplementedException();
        }
    }
}
