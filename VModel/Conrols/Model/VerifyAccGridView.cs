using FinanceAccountProgram.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JINSHIN.BUSINESS.LIBARY.Base;
namespace FinanceAccountProgram.VModel.Conrols.Model
{
    //"序號","類別","細項","月份","種類","會計科目","徵稅","發票號碼",
    //"所屬月份","當期日","增減","傳票","說明","借/貸","金額","狀態","發票日期"
    //item:2,
    public class VerifyAccGridView :JBase
    {
        public int SN { get; set; }
        public bool IsSysAutoFill { get; set; }
        public int Item { get; set; }
        public int Cost_Class { get; set; }
        public int Cost_Detail { get; set; }
        public byte Cost_M { get; set; }        
        public int Rec_Type { get; set; }
        public string Acc_ID { get; set; }
        public bool HasTax { get; set; }        
        public string Invoice_No { get; set; }
        public string Sell_ID { get; set; }
        public string Buy_ID { get; set; }
        public byte? Verify_Month { get; set; }
        public DateTime? Cost_Date { get; set; }
        public int Cost_Type { get; set; }
        public string Acc_No { get; set; }
        public string Acc_Desc { get; set; }
        public byte DataType { get; set; }
        public decimal Amount { get; set; }
        public int Status { get; set; }
        public DateTime? Inv_Date { get; set; }
        public bool? Is_Reserved { get; set; }
        public bool? Cost_Check { get; set; }
        public DateTime? Check_Date { get; set; }
    }
}
