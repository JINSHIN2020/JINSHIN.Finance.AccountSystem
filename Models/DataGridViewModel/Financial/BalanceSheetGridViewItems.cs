using FinanceAccountProgram.VModel.Conrols.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JINSHIN.BUSINESS.LIBARY.Models.UIControls;
using JINSHIN.BUSINESS.LIBARY.Base;

namespace FinanceAccountProgram.Models.DataGridViewModel.Financial
{
    public class BalanceSheetGridViewItems : JBase
    {
        public List<NameValues> columns { get; set; }
        public BalanceSheetGridViewItems()
        {
            columns = new List<NameValues>();
            columns.Add(new NameValues() { name = "ClassDesc", value = "Text", text = "分類" });
            columns.Add(new NameValues() { name = "DescData", value = "Text", text = "項目" });
            columns.Add(new NameValues() { name = "AmountStr", value = "Text", text = "金額" });
        }
    }
}
