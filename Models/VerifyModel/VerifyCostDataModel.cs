using JINSHIN.FinanceAccounting.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JINSHIN.BUSINESS.LIBARY.Base;
using JINSHIN.FinanceAccount.Libary.Models.Financial;
namespace FinanceAccountProgram.Models.VerifyModel
{
    /// <summary>
    /// Add 1:is add , 2: is reduce
    /// </summary>
    public class VerifyCostDataModel : JBase
    {
        public JINSHINFINANCE035 costitem { get; set; }
        public bool IsVerify { get; set; }
        public AccidAccount Add { get; set; }

    }

    public class VerifyAssetDataModel : JBase
    {
        public JINSHINFINANCE052 assetsitem { get; set; }
        public bool IsVerify { get; set; }

    }
}
