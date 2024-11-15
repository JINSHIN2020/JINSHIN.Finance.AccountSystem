using JINSHIN.BUSINESS.LIBARY.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceAccountProgram.Models
{
    public class AccCostVerify :JBase
    {
            public int SN { get; set; }
            public string Invoice_No { get; set; }
            public int Item { get; set; }
            public byte Cost_M { get; set; }
            public string Acc_ID { get; set; }
            public System.DateTime Cost_Date { get; set; }
            public string Acc_No { get; set; }
            public string Acc_Desc { get; set; }
            public byte DataType { get; set; }
            public string Sell_ID { get; set; }
            public string Buy_ID { get; set; }
            public decimal Amount { get; set; }
            public decimal TaxAmount { get; set; }
            public bool HasTax { get; set; }
            public int invVal { get; set; }
       //     public bool Cost_Check { get; set; }
         //   public System.DateTime Check_Date { get; set; }
        //    public bool Cost_Compare { get; set; }
       //     public int Cost_Class { get; set; }
         //   public byte Cost_Month { get; set; }
            public System.DateTime CreateTime { get; set; }
            public int Rec_Type { get; set; }
    }
}
