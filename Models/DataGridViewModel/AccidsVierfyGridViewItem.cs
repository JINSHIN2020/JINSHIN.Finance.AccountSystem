using FinanceAccountProgram.VModel.Conrols.Model;
using JINSHIN.BUSINESS.LIBARY.Models.UIControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JINSHIN.BUSINESS.LIBARY.Base;
namespace FinanceAccountProgram.Models.DataGridViewModel
{
    public class AccidsVierfyGridViewItem : JBase
    {
        public List<NameValues> columns { get; set; }
        public AccidsVierfyGridViewItem()
        {
            columns = new List<NameValues>();
            columns.Add(new NameValues() { name = "sn", value = "Text", text = "群組號碼" });
            columns.Add(new NameValues() { name = "acc_no", value = "Text", text = "傳票" });
            columns.Add(new NameValues() { name = "acc_m", value = "Text", text = "月份" });
            columns.Add(new NameValues() { name = "item", value = "Text", text = "項目" });
            columns.Add(new NameValues() { name = "IsOnlyOne", value = "Text", text = "檢查" });
            columns.Add(new NameValues() { name = "sn", value = "Text", text = "序號" });
            columns.Add(new NameValues() { name = "acc_id", value = "Text", text = "會計科目" });
            columns.Add(new NameValues() { name = "acc_date", value = "Text", text = "會計日期" });
            columns.Add(new NameValues() { name = "acc_desc", value = "Text", text = "描述" });
            columns.Add(new NameValues() { name = "datatype", value = "Text", text = "借/貸" });
            columns.Add(new NameValues() { name = "amount", value = "Text", text = "金額" });
        }
    }
}
