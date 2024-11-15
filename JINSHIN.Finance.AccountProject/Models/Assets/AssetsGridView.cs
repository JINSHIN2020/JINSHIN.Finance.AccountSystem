using JINSHIN.BUSINESS.LIBARY.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceAccountProgram.Models.Assets
{
    public class AssetsGridView : JBase
    {
        public long sn { get; set; }    
        public string acc_id { get; set; }
        public int item { get; set; }
        public string acc_no { get; set; }
        public string desc { get; set; }
        public int lend { get; set; }
        public double Org_amount { get; set; }
        public decimal Dst_amount { get; set; }
        public System.DateTime date { get; set; }     
        public DateTime dstdate { get; set; }
        public string invoice { get; set; }
    }
}
