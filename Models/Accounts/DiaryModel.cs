
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JINSHIN.BUSINESS.LIBARY.Base;
using JINSHIN.FinanceAccount.Libary.Models.Financial;

namespace FinanceAccountProgram.Models.Accounts
{
    public class DiaryModel :JBase
    {
        public int Day { get; set; }
        public List<AccidAccount> values { get; set; }
        public int DialaryLink { get; set; }
        public bool IsDefaultAccount { get; set; }
        public DiaryModel()
        {
            values = new List<AccidAccount>();
        }
    }
    
}
