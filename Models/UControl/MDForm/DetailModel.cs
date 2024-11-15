
using JINSHIN.BUSINESS.LIBARY.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceAccountProgram.Models.UControl.MDForm
{
    public class DetailModel :VBase
    {
      public string datasn { get; set; }
      public string accid { get; set; }
      public string desc01 { get; set; }
      public string desc02 { get; set; }        
    }
}
