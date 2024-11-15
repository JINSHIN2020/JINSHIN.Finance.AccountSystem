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
    public class VerifyConfirmGridViewModel :JBase
    {
        public List<NameValues> columns { get; set; }
        public VerifyConfirmGridViewModel()
        {
            columns = new List<NameValues>();
            columns.Add(new NameValues() { name = "sn", value = "Text", text = "號碼" });
            columns.Add(new NameValues() { name = "acc_no", value = "Text", text = "傳票" });
            columns.Add(new NameValues() { name = "cost_m", value = "Text", text = "月份" });
            columns.Add(new NameValues() { name = "item", value = "Text", text = "項目" });
            columns.Add(new NameValues() { name = "acc_id", value = "Text", text = "會計科目" });
            columns.Add(new NameValues() { name = "cost_date", value = "Text", text = "會計日期" });
            columns.Add(new NameValues() { name = "verify_month", value = "Text", text = "會計月份" });
            columns.Add(new NameValues() { name = "acc_desc", value = "Text", text = "描述" });
            columns.Add(new NameValues() { name = "datatype", value = "Text", text = "借/貸" });
            columns.Add(new NameValues() { name = "amount", value = "Text", text = "金額" });
            columns.Add(new NameValues() { name = "Cost_Check", value = "Text", text = "是否核定" });
            columns.Add(new NameValues() { name = "Check_Date", value = "Text", text = "核定日期" });
        }
    }
}
