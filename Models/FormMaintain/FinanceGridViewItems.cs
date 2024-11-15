using FinanceAccountProgram.VModel.Conrols.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JINSHIN.BUSINESS.LIBARY.Models.UIControls;
namespace FinanceAccountProgram.Models.FormMaintain
{
    public class FinanceGridViewItems : GridViewConfigBase
    {
        public List<NameValues> columns { get; set; }
        public FinanceGridViewItems()
        {
            columns = new List<NameValues>();
            columns.Add(new NameValues() { name = "SN", value = "Text", text = "序號" });
            columns.Add(new NameValues() { name = "AccId", value = "Text", text = "會計編碼" });
            columns.Add(new NameValues() { name = "Orderth", value = "Text", text = "排序" });
            columns.Add(new NameValues() { name = "ComputeNo", value = "Text", text = "計算編碼" });
            columns.Add(new NameValues() { name = "cmd", value = "Text", text = "種類" });
            columns.Add(new NameValues() { name = "Display", value = "Text", text = "顯示" });
            columns.Add(new NameValues() { name = "Datatype", value = "Text", text = "借/貸" });
            columns.Add(new NameValues() { name = "Amount", value = "Text", text = "金額" });
            columns.Add(new NameValues() { name = "DescData", value = "Text", text = "描述" });
            columns.Add(new NameValues() { name = "ClassDesc", value = "Text", text = "類別" });
            columns.Add(new NameValues() { name = "MoneyType", value = "Text", text = "報表型式" });
            columns.Add(new NameValues() { name = "CreateTime", value = "Text", text = "建立日期" });
            config_columns = new List<VarClass>();
        }
    }
}
