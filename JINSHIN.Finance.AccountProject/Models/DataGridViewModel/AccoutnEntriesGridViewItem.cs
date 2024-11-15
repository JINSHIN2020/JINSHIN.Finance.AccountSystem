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
    public class AccoutnEntriesGridViewItem :JBase
    {
        public List<NameValues> columns { get; set; }
        public AccoutnEntriesGridViewItem()
        {
            columns = new List<NameValues>();
            columns.Add(new NameValues() { name = "no", value = "Text", text = "ID" });
            columns.Add(new NameValues() { name = "MdataText", value = "Text", text = "主要說明" });
            columns.Add(new NameValues() { name = "DdataText", value = "Text", text = "明細說明" });
            columns.Add(new NameValues() { name = "accid", value = "Text", text = "會計科目" });
            columns.Add(new NameValues() { name = "datatype", value = "Text", text = "借/貸" });
            columns.Add(new NameValues() { name = "createtime", value = "Text", text = "建立日期" });
            columns.Add(new NameValues() { name = "sn", value = "Text", text = "排序",hidden=true });
        }
    }
}
