using JINSHIN.Alayway.Frameworks.VModels.UIControl.DGridView;
using JINSHIN.BUSINESS.LIBARY.UIControls.GridView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JINSHIN.BUSINESS.LIBARY.Models.UIControls;
namespace FinanceAccountProgram.VModel.Conrols.GridView
{
    public class Acc_DiaryFoods_DGItems : ItemsBase
    {
        public Acc_DiaryFoods_DGItems()
        {
            columnwidths = new List<int>() { 100, 200, 100, 100, 100,100};
            columns.Add(new NameValues() { name = "I02", value = "Text", text = "序號" });
            columns.Add(new NameValues() { name = "DATA03", value = "Text", text = "日期" });
            columns.Add(new NameValues() { name = "DATA02", value = "Text", text = "類別" });
            columns.Add(new NameValues() { name = "DATA01", value = "Text", text = "名稱" });
            columns.Add(new NameValues() { name = "D02", value = "Text", text = "數量" });
            columns.Add(new NameValues() { name = "D01", value = "Text", text = "金額" });
        }
    }
}
