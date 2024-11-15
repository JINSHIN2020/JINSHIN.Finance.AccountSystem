using FinanceAccountProgram.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JINSHIN.BUSINESS.LIBARY.Models.Base;

namespace FinanceAccountProgram.VModel
{
    public class YearBeginViewModel : JBase
    {
        public string key { get; set; }
        public string value { get; set; }
        public bool checkvalue { get; set; }
    }
}
