using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceAccountProgram.Models
{
    public class Invoice_ContractModel
    {
        //{"序號","會計科目","項目","日期","傳票",  "類別01", "類別02", "摘要"
        // ,"會計月",
        //"借/貸","金額","狀態","有無","發票日期","發票月","發票"}
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
        
    }
}
