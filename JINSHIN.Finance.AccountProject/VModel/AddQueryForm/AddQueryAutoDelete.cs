using FinanceAccountProgram.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JINSHIN.BUSINESS.LIBARY.Base;
namespace FinanceAccountProgram.VModel.AddQueryForm
{
    /// <summary>
    /// IsFinancial_IncomeCreateDelete:FormMaintain
    /// </summary>
    public class AddQueryAutoDelete :JBase
    {
        public static bool IsAssetsAccountArgDelete = true;
        public static bool IsCostDataQueryDelete = true;
        public static bool IsInvoiceContractDelete = true;
        public static bool IsVerifyItemDelete = true;
        public static bool IsAssetsCreateDelete = true;
        public static bool IsFinancial_IncomeCreateDelete = true;
        public static bool IsFinancial_BalanceCreateDelete = true;
    }
}
