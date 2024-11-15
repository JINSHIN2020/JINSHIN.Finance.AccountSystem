using JINSHIN.BUSINESS.LIBARY.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceAccountProgram.Models.Business
{
    public class RestaurantModel :JBase
    {
        public List<string> data01 { get; set; }
        public List<string> data02 { get; set; }
        public List<string> columns { get; set; }
        public RestaurantModel()
        {
            columns = new List<string>() {"", "SN", "PROCLASS", "PNAME", "NUM", "PPRICE", "DISCOUNT" };

            data01 = new List<string>() { "SN", "PNAME", "PPRICE", "PROCLASS", "NUM", "DISCOUNT" };
            data02 = new List<string>() { "I01", "DATA01", "D01", "DATA02", "D02", "D03" };

            //columns.Add(new NameValues() { name = "I02", value = "Text", text = "序號" });
            //columns.Add(new NameValues() { name = "I01", value = "Text", text = "編號" });
            //columns.Add(new NameValues() { name = "DATA02", value = "Text", text = "類別" });
            //columns.Add(new NameValues() { name = "DATA01", value = "Text", text = "名稱" });
            //columns.Add(new NameValues() { name = "D02", value = "Text", text = "數量" });
            //columns.Add(new NameValues() { name = "D01", value = "Text", text = "金額" });
            //columns.Add(new NameValues() { name = "D03", value = "Text", text = "折扣" });
        }
    }
}
