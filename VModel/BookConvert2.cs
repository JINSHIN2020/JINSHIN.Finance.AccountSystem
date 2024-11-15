using FinanceAccountProgram.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JINSHIN.BUSINESS.LIBARY.Base;
namespace FinanceAccountProgram.VModel
{
    public class BookConvert2 : JBase
    {
        public string TaxNo { get; set; }
        public string BookNo { get; set; }
        public DateTime datadate { get; set; }
        public string Leftvalues { get; set; }
        public string Rightvalues { get; set; }
        public int amountType { get; set; }
        public double amount { get; set; }
        public string acc_id { get; set; }
        public string acc_desc { get; set; }
        public int SN { get; set; }
    }
}
