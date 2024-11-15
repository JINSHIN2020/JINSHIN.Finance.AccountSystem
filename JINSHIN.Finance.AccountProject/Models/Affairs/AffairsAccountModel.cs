using JINSHIN.BUSINESS.LIBARY.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceAccountProgram.Models.Affairs
{
    public class AffairsAccountModel :JBase
    {
        public int no { get; set; }
        public int DataSn { get; set; }
        public string MdataText { get; set; }
        public string DdataText { get; set; }
        public string accid { get; set; }
        public int datatype { get; set; }
        public string classtext { get; set; }
        public decimal amount { get; set; }
        public bool IsDefault { get; set; }
        public int sn { get; set; }
        public DateTime createtime { get; set; }
        public int? classtype { get; set; }

    }
}
