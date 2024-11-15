using JINSHIN.BUSINESS.LIBARY.Base;
using JINSHIN.BUSINESS.LIBARY.Models.UIControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JINSHIN.Finance.AccountSystem.Models.DataGridViewModel.CountryTaxReport
{
    public class DetailReportGridViewItems : JBase
    {
        public List<NameValues> columns { get; set; }
        public DetailReportGridViewItems()
        {
            columns = new List<NameValues>();
            columns.Add(new NameValues() { name = "sn", value = "Text", text = "序號" });
            columns.Add(new NameValues() { name = "cost_date", value = "Text", text = "日期" });
            columns.Add(new NameValues() { name = "acc_no", value = "Text", text = "傳票" });
            columns.Add(new NameValues() { name = "item", value = "Text", text = "項目" });
            columns.Add(new NameValues() { name = "acc_id", value = "Text", text = "科目" });
            columns.Add(new NameValues() { name = "acc_desc", value = "Text", text = "描述" });
            columns.Add(new NameValues() { name = "amount", value = "Text", text = "金額" });
            columns.Add(new NameValues() { name = "datatype", value = "Text", text = "借/貸" });
        }
    }
}
