using FinanceAccountProgram.VModel.Conrols.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JINSHIN.BUSINESS.LIBARY.Models.UIControls;
using JINSHIN.BUSINESS.LIBARY.Base;
namespace FinanceAccountProgram.Models.DataGridViewModel
{
    public class AccCostLedgerGridViewItems :JBase
    {
        public List<NameValues> columns { get; set; }
        public AccCostLedgerGridViewItems()
        {
            columns = new List<NameValues>();
            columns.Add(new NameValues() { name = "sn", value = "Text", text = "序號" });
            columns.Add(new NameValues() {name="Acc_Date",value="Text",text="年度" });
            columns.Add(new NameValues() { name = "acc_id", value = "Text", text = "科目" });
            columns.Add(new NameValues() { name = "acc_desc", value = "Text", text = "描述" });
            columns.Add(new NameValues() { name = "datatype", value = "Text", text = "借/貸" });
            columns.Add(new NameValues() { name = "amount", value = "Text", text = "金額" });
        }
    }
}
