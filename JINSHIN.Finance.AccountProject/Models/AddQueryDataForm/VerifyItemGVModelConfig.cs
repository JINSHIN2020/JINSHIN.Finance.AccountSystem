using FinanceAccountProgram.VModel.Conrols.Model;
using JINSHIN.BUSINESS.LIBARY.Models.UIControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceAccountProgram.Models.AddQueryDataForm
{
    public class VerifyItemGVModelConfig : GridViewConfigBase
    {
        public List<NameValues> columns { get; set; }
        public VerifyItemGVModelConfig()
        {
            columns = new List<NameValues>();
            columns.Add(new NameValues() { name = "NO", value = "Text", text = "序號" });
            //columns.Add(new NameValues() { name = "Item", value = "Text", text = "項目" });
            columns.Add(new NameValues() { name = "Acc_Date", value = "Text", text = "日期" });
            columns.Add(new NameValues() { name = "Verify_Year", value = "Text", text = "年份" });
            columns.Add(new NameValues() { name = "Verify_Month", value = "Text", text = "月份" });
            columns.Add(new NameValues() { name = "EmpName", value = "Text", text = "人員" });
            columns.Add(new NameValues() { name = "Acc_ID", value = "Text", text = "會計編碼" });
            columns.Add(new NameValues() { name = "Descrip", value = "Text", text = "項目" });
            columns.Add(new NameValues() { name = "Amount", value = "Text", text = "金額" });
            columns.Add(new NameValues() { name = "Invoice_No", value = "Text", text = "發票" });
            config_columns = new List<VarClass>();         
        }
    }
}
