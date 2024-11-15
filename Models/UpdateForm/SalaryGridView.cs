using FinanceAccountProgram.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JINSHIN.BUSINESS.LIBARY.Base;
namespace FinanceAccountProgram.Models.UpdateForm
{
    public class SalaryGridView :JBase
    {
        public int SN { get; set; }    
        public int item { get; set; }
        public string Acc_ID { get; set; }
        public byte Cost_M { get; set; }        
        public DateTime? Cost_Date { get; set; }
        public string Acc_No { get; set; }
        public string Acc_Desc { get; set; }        
        public string Invoice_No { get; set; }
        public byte DataType { get; set; }
        public decimal Amount { get; set; }
        public byte Verify_Month { get; set; }
        public int Rec_Type { get; set; }        
    }
}
