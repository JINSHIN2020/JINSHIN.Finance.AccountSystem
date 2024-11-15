using JINSHIN.FinanceAccounting.DB;
using FinanceAccountProgram.VModel.AddQueryDataForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JINSHIN.BUSINESS.LIBARY.Base;
namespace FinanceAccountProgram.Models.AddQueryDataForm
{
    /// <summary>
    /// errorcnt :錯誤數量
    /// getCheckItem:確認其他問題
    /// thesame:是否一致
    /// </summary>
    public class JINSHINFINANCE047Flow :JBase
    {
        public List<JINSHINFINANCE035> data01 { get; set; }
        public List<JINSHINFINANCE035> data02 { get; set; }
        public List<JINSHINFINANCE035> data03 { get; set; }
        public List<JINSHINFINANCE035View> data05 { get; set; }
        public int Rec_Type { get; set; }
        public bool result { get; set; }
        public bool thesame { get; set; }
        public bool getCheckItem { get; set; }
        public int errorcnt { get; set; }
        public JINSHINFINANCE047Flow()
        {
            data05 = new List<JINSHINFINANCE035View>();
            result = true;
            thesame = false;
            getCheckItem = false;
        }
    }
}
