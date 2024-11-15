using JINSHIN.FinanceAccounting.DB;
using FinanceAccountProgram.VModel.Conrols.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceAccountProgram.Models.AddQueryDataForm
{
    public class VerifyMonthCompareList : IComparer<JINSHINFINANCE035>
    {
        public int Compare(JINSHINFINANCE035 x, JINSHINFINANCE035 y)
        {
            int d01 = 0;
            int d02 = 0;
            int d03 = 0;
            if ((x.Verify_Month == null) && (y.Verify_Month == null))
                return 0;
            else if (x.Verify_Month == null)
                return -1;
            else if (y.Verify_Month == null)
                return 1;
            d01 = x.Verify_Month.Value.CompareTo(y.Verify_Month);
            if (d01 == 0)
            {
                d02 = x.Acc_No.CompareTo(y.Acc_No);
                if (d02 == 0)
                {
                    d03 = x.DataType < y.DataType ? -1 : x.DataType == y.DataType ? 0 : 1;
                    return d03;
                }
                else return d02;
            }
            else return d01;
          //  return 0;
          //  return x.Verify_Month.Value.CompareTo(y.Verify_Month);
        }
        
    }
}
