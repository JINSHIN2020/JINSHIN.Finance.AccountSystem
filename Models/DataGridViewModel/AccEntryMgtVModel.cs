using JINSHIN.BUSINESS.LIBARY.Base;
using JINSHIN.BUSINESS.LIBARY.Models.UIControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceAccountProgram.Models.DataGridViewModel
{
    public class AccEntryMgtVModel : JBase
    {
        public List<NameValues> columns { get; set; }
        public AccEntryMgtVModel()
        {
            columns = new List<NameValues>();
            columns.Add(new NameValues() { name = "no", value = "Text", text = "ID" });
            columns.Add(new NameValues() { name = "MdataText", value = "Text", text = "主要說明" });
            columns.Add(new NameValues() { name = "DdataText", value = "Text", text = "明細說明" });
            columns.Add(new NameValues() { name = "accid", value = "Text", text = "會計科目" });
            columns.Add(new NameValues() { name = "classtype", value = "Text", text = "說明" });
            columns.Add(new NameValues() { name = "datatype", value = "Text", text = "借/貸" });
            columns.Add(new NameValues() { name = "Amount", value = "Text", text = "金額" });
            columns.Add(new NameValues() { name = "createtime", value = "Text", text = "建立日期" });
            columns.Add(new NameValues() { name = "sn", value = "Text", text = "排序",hidden = true });
        }
    }
}
