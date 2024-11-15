using JINSHIN.BUSINESS.LIBARY.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceAccountProgram.Models.Config
{
    public class coststatus :JBase
    {
        public const int accountcreated = 1;
        //帳務建立
        public const int diaryaccount = 2;
        //
        public const int monthtaxapply = 3;
        //年結
        public const int yeartaxapply = 5;
    }
}
