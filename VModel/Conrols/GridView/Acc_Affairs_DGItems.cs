
using JINSHIN.BUSINESS.LIBARY.Models.UIControls;
using JINSHIN.BUSINESS.LIBARY.UIControls.GridView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardClick.Model.GridModel
{
    /// <summary>
    /// 資產設定
    /// 事務設定
    /// </summary>
    public class Acc_Affairs_DGItems : ItemsBase
    {
        public Acc_Affairs_DGItems()
        {
            columnwidths = new List<int>() {70,70,400 };
            columns.Add(new NameValues() { name = "I01", value = "Text", text = "編號" });
            columns.Add(new NameValues() { name = "SN", value = "Text", text = "序號" });      
            columns.Add(new NameValues() { name = "Data01", value = "Text", text = "事務" });

        }
    }
}
