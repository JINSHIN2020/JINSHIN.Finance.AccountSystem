using JINSHIN.BUSINESS.LIBARY.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceAccountProgram.Models.Accounts
{
    public class DiaryDefaultModel :JBase
    {
        public int Mdataid { get; set; }
        public int dataid { get; set; }
        public string accid { get; set; }
        public int item { get; set; }
        public int datatype { get; set; }
        public decimal amount { get; set; }
        public decimal taxamount { get; set; }
        public int Rec_Type { get; set; }
        public string descirption { get; set; }
    }
}
 