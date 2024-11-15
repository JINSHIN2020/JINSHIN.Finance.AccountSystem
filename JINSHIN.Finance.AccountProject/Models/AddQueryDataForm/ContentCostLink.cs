using JINSHIN.BUSINESS.LIBARY.Models.Base;
using JINSHIN.FinanceAccounting.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceAccountProgram.Models.AddQueryDataForm
{
    public class ContentCostLink :JBase
    {
        public Invoice_Contract icontract { get; set; }
        public Acc_InvoiceBook iinvoicebook { get; set; }
        public ContentCostLink()
        {
            icontract = new Invoice_Contract();
            iinvoicebook = new Acc_InvoiceBook();
        }
    }
}
