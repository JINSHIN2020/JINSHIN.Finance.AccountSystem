using JINSHIN.BUSINESS.LIBARY.Base;
using JINSHIN.BUSINESS.LIBARY.Models.UIControls;
using JINSHIN.BUSINESS.LIBARY.UIControls.GridView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JINSHIN.Finance.AccountSystem.Models.DataGridViewModel
{
    public class AccIdsGVItems :ItemsBase
    {
       // public List<NameValues> columns { get; set; }
        public AccIdsGVItems()
        {
            columnwidths = new List<int> { 80, 80, 320 };
            columns = new List<NameValues>();
            columns.Add(new NameValues() { name = "sn", value = "Text", text = "序號" });
            columns.Add(new NameValues() { name = "acc_id", value = "Text", text = "科目" });
            columns.Add(new NameValues() { name = "acc_desc", value = "Text", text = "描述" });
        }
    }
}
