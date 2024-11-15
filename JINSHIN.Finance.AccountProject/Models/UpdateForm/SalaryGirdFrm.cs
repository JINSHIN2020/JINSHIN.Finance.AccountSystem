using FinanceAccountProgram.VModel.Conrols.Model;
using JINSHIN.BUSINESS.LIBARY.Base;
using JINSHIN.BUSINESS.LIBARY.Models.UIControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceAccountProgram.Models.UpdateForm
{
    public class SalaryGirdFrm :JBase
    {
        public List<NameValues> columns { get; set; }
        public SalaryGirdFrm()
        {
            columns = new List<NameValues>();
            columns.Add(new NameValues() { name = "SN", value = "Text", text = "序號" });
            columns.Add(new NameValues() { name = "Item", value = "Text", text = "項目" });
            columns.Add(new NameValues() { name = "Acc_ID", value = "Text", text = "會計科目" });
            columns.Add(new NameValues() { name = "Cost_M", value = "Text", text = "月份" });
            columns.Add(new NameValues() { name = "Cost_Date", value = "Text", text = "當期日" });
            columns.Add(new NameValues() { name = "Acc_No", value = "Text", text = "傳票" });
            columns.Add(new NameValues() { name = "Acc_Desc", value = "Text", text = "說明" });
            columns.Add(new NameValues() { name = "DataType", value = "Text", text = "借/貸" });
            columns.Add(new NameValues() { name = "Amount", value = "Text", text = "金額" });
            columns.Add(new NameValues() { name = "Verify_Month", value = "Text", text = "所屬月份" });
            columns.Add(new NameValues() { name = "Is_Fill", value = "Text", text = "核定" });
            columns.Add(new NameValues() { name = "Invoice_No", value = "Text", text = "發票" });

        }   
    }
}
