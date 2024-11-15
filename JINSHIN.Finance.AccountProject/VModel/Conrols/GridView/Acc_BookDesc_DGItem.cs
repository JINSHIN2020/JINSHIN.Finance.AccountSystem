using JINSHIN.BUSINESS.LIBARY.Models.UIControls;
using JINSHIN.BUSINESS.LIBARY.UIControls.GridView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JINSHIN.Finance.AccountSystem.VModel.Conrols.GridView
{
    public class Acc_BookDesc_DGItem :ItemsBase
    {
        public Acc_BookDesc_DGItem()
        {
            columnwidths = new List<int>() { 100, 100, 200, 100, 200, 200 };
            columns.Add(new NameValues() { name = "I01", value = "Text", text = "編號" });
            columns.Add(new NameValues() { name = "SN", value = "Text", text = "序號" });
            columns.Add(new NameValues() { name = "I02", value = "Text", text = "事務編號" });
            columns.Add(new NameValues() { name = "Data01", value = "Text", text = "事務" });
            columns.Add(new NameValues() { name = "Data02", value = "Text", text = "會計科目" });
            columns.Add(new NameValues() { name = "Data03", value = "Text", text = "會計摘要" });
        }
    }
}
