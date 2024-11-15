using JINSHIN.Business.DataBase;
using JINSHIN.FinanceAccounting.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JINSHIN.Finance.AccountSystem.VModel.Finicial
{
    public class FunctionViewModel : JINSHINFINANCE011
    {
        public long No { get; set; }
        public string PowerText { get; set; }
        public string ProNameText { get; set; }
        public string ClassNameText { get; set; }
        public string OpenText { get; set; }
    }
}
