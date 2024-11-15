using JINSHIN.FinanceAccount.Libary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceAccountProgram.Models
{
    public class AccLedgerBook : AccBookBase
    {
        public double invoiceAmount { get; set; }
        public int reverse_entrycnt { get; set; }
    }
}
