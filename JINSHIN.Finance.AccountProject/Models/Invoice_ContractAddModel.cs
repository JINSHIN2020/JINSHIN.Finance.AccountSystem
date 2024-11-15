using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JINSHIN.BUSINESS.LIBARY.Base;
namespace FinanceAccountProgram.Models
{
    public class Invoice_ContractAddModel :JBase
    {
        public long SN { get; set; }
        public string Acc_ID { get; set; }
        public int Item { get; set; }
        public DateTime Acc_Date { get; set; }
        public string Acc_No { get; set; }
        public string Inv_Class { get; set; }
        public string Inv_DetailClass { get; set; }
        public string Acc_Desc { get; set; }
        public int Acc_M { get; set; }
        public int DataType { get; set; }
        public decimal Amount { get; set; }
        public string CostName { get; set; }
        public DateTime Inv_Date { get; set; }
        public int Inv_M { get; set; }
        public string Invoice_No { get; set; }
        public bool Is_Fill { get; set; }
        public bool Is_Verify { get; set; }
        public bool Is_Inv { get; set; }
    }
}
