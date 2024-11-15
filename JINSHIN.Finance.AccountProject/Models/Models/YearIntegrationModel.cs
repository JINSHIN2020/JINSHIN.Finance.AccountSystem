using JINSHIN.BUSINESS.LIBARY.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JINSHIN.Finance.AccountSystem.Models.Models
{
    public class YearIntegrationModel :JBase
    {
        public string accid { get; set; }
        public string desc { get; set; }
        public string desc02 { get; set; }
        public int month { get; set; }
        public int year { get; set; }
        public string YesNo { get; set; }
    }
}
