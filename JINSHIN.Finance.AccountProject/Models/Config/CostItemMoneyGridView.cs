using FinanceAccountProgram.VModel.Conrols.Model;
using JINSHIN.BUSINESS.LIBARY.Models.UIControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceAccountProgram.Models.Config
{
    public class CostItemMoneyGridView : GridViewConfigBase
    {
        public List<NameValues> columns { get; set; }
        public CostItemMoneyGridView()
        {
            columns = new List<NameValues>();
            columns.Add(new NameValues() { name = "SN", value = "Text", text = "序號" });
            columns.Add(new NameValues() { name = "Cost_M", value = "Text", text = "月份" });
            columns.Add(new NameValues() { name = "Verify_Month", value = "Text", text = "實際月份" });
            columns.Add(new NameValues() { name = "Acc_No", value = "Text", text = "傳票編號" });
            columns.Add(new NameValues() { name = "Acc_ID", value = "Text", text = "會計編號" });
            columns.Add(new NameValues() { name = "Cost_Date", value = "Text", text = "日期" });            
            columns.Add(new NameValues() { name = "Acc_Desc", value = "Text", text = "描述" });
            columns.Add(new NameValues() { name = "datatype", value = "Text", text = "借貸" });
            columns.Add(new NameValues() { name = "Amount", value = "Text", text = "金額" });
            columns.Add(new NameValues() { name = "Cost_Check", value = "Text", text = "審核" });
            columns.Add(new NameValues() { name = "Is_Fill", value = "Text", text = "是否核定" });
            columns.Add(new NameValues() { name = "Check_Date", value = "Text", text = "核定日期" });
            config_columns = new List<VarClass>();
        }
    }
}
