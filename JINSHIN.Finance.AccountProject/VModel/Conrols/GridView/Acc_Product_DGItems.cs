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
    public class Acc_Product_DGItems : ItemsBase
    {
        public Acc_Product_DGItems()
        {
            columnwidths = new List<int>() { 100, 100, 100, 100, 100, 100, 100 };            
            columns.Add(new NameValues() { name = "I02", value = "Text", text = "序號" });
            columns.Add(new NameValues() { name = "I01", value = "Text", text = "編號" });
            columns.Add(new NameValues() { name = "DATA02", value = "Text", text = "類別" });
            columns.Add(new NameValues() { name = "DATA01", value = "Text", text = "名稱" });
            columns.Add(new NameValues() { name = "D02", value = "Text", text = "數量" });
            columns.Add(new NameValues() { name = "D01", value = "Text", text = "金額" });
            columns.Add(new NameValues() { name = "D03", value = "Text", text = "折扣" });



            //data01 = new List<string>() { "SN", "PNAME", "PPRICE", "PROCLASS", "NUM", "DISCOUNT" };
            //data02 = new List<string>() { "I01", "DATA01", "D01", "DATA02", "D02", "D03" };
        }
    }
}
