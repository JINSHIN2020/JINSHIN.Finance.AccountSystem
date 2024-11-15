using FinanceAccountProgram.VModel.Conrols.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JINSHIN.BUSINESS.LIBARY.Models.UIControls;
namespace FinanceAccountProgram.Models.FormMaintain
{
    public class AssetsGridViewConfig : GridViewConfigBase
    {
        public List<NameValues> columns { get; set; }
        public AssetsGridViewConfig()
        {
            columns = new List<NameValues>();
            columns.Add(new NameValues() { name = "SN", value = "Text", text = "編號" });
            columns.Add(new NameValues() { name = "NO", value = "Text", text = "序號" });

            columns.Add(new NameValues() { name = "AssetsName", value = "Text", text = "財產名稱" });
            columns.Add(new NameValues() { name = "BuyDate", value = "Text", text = "日期" });
            columns.Add(new NameValues() { name = "IsFinance", value = "Text", text = "是否外帳" });
            columns.Add(new NameValues() { name = "Acc_ID", value = "Text", text = "會科" });
            columns.Add(new NameValues() { name = "Cnt", value = "Text", text = "數量" });
            columns.Add(new NameValues() { name = "Unit", value = "Text", text = "單位" });
            columns.Add(new NameValues() { name = "Price", value = "Text", text = "原價" });       
            columns.Add(new NameValues() { name = "MachineYear", value = "Text", text = "耐用年限" });
            columns.Add(new NameValues() { name = "Months", value = "Text", text = "使用年月" });
            columns.Add(new NameValues() { name = "MonthUsed", value = "Text", text = "已使用年月" });                                  
            columns.Add(new NameValues() { name = "remark", value = "Text", text = "備註" });

        }
    }
}
