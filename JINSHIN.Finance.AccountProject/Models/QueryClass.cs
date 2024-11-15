using JINSHIN.BUSINESS.LIBARY.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceAccountProgram.Models
{
    public class QueryClass : JBase
    {
        public string classtype { get; set; }
        public string accid { get; set; }        
    }
}
