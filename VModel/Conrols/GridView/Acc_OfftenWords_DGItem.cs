using JINSHIN.Alayway.Frameworks.VModels.UIControl.DGridView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JINSHIN.BUSINESS.LIBARY.Models.UIControls;
using JINSHIN.BUSINESS.LIBARY.UIControls.GridView;
namespace FinanceAccountProgram.VModel.Conrols.GridView
{
    public class Acc_OfftenWords_DGItem : ItemsBase
    {
        public Acc_OfftenWords_DGItem()
        {
            columnwidths = new List<int>() { 100, 100, 100 };
            columns.Add(new NameValues() { name = "I01", value = "Text", text = "編號" });
            columns.Add(new NameValues() { name = "SN", value = "Text", text = "序號" });
            columns.Add(new NameValues() { name = "Data01", value = "Text", text = "常用名稱" });
        }
    }
}
