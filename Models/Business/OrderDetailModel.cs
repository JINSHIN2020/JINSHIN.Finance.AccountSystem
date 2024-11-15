using JINSHIN.BUSINESS.LIBARY.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceAccountProgram.Models.Business
{
    public class OrderDetailModel :JBase
    {
        public int No { get; set; }
        public Nullable<System.DateTime> CDate { get; set; }
        public string OrderNo { get; set; }
        public string ProClass { get; set; }
        public string PName { get; set; }
        public Nullable<int> Num { get; set; }
        public Nullable<decimal> PPrice { get; set; }
     
    
    }
}
