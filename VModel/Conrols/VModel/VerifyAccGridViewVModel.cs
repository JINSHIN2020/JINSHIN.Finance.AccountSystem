using FinanceAccountProgram.Models;
using FinanceAccountProgram.VModel.Conrols.Model;
using JINSHIN.BUSINESS.LIBARY.Models.UControl;
using JINSHIN.BUSINESS.LIBARY.Models.UIControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceAccountProgram.VModel.Conrols.VModel
{
    public class VerifyAccGridViewVModel : GridViewConfigBase
    {
        public List<NameValues> columns { get; set; }
        public VerifyAccGridViewVModel()
        {            
            columns = new List<NameValues>();
            columns.Add(new NameValues() { name = "SN", value = "Text",text = "序號" });
            columns.Add(new NameValues() { name="IsSysAutoFill",value="Text",text="系統設定"});
            columns.Add(new NameValues() { name = "Acc_Desc", value = "Text", text = "說明" });
            columns.Add(new NameValues() { name = "Acc_ID", value = "Text", text = "會計科目" });
            columns.Add(new NameValues() { name = "Item", value = "Text", text = "項目" });
            columns.Add(new NameValues() { name = "Acc_No", value = "Text", text = "傳票" });
            columns.Add(new NameValues() { name = "Amount", value = "Text", text = "金額" });
      //      columns.Add(new NameValues() { name = "Cost_Class", value = "Combo", text = "類別", combotype = BaseClassEnum.Acc_Class });
            columns.Add(new NameValues() { name = "Cost_Date", value = "Text", text = "當期日" });
        //    columns.Add(new NameValues() { name = "Cost_Detail", value = "Combo", text = "細項", combotype = BaseClassEnum.Acc_Detail });
            columns.Add(new NameValues() { name = "Cost_M", value = "Text", text = "月份" });
        //    columns.Add(new NameValues() { name = "Verify_Month", value = "Text", text = "所屬月份" });
        //    columns.Add(new NameValues() { name = "Cost_Type", value = "Text", text = "增減" });
            columns.Add(new NameValues() { name = "DataType", value = "Text", text = "借/貸" });
            columns.Add(new NameValues() { name = "Invoice_No", value = "Text", text = "發票" });
            columns.Add(new NameValues() { name = "Inv_Date", value = "Text", text = "發票日期" });
            //columns.Add(new NameValues() { name="sell_id", value="Text", text="賣方統編" });
            //columns.Add(new NameValues() { name="buy_id", value="Text", text="買方統編" });
            columns.Add(new NameValues() { name = "Rec_Type", value = "Combo", text = "種類", combotype = BaseClassEnum.Inv_Class});
            columns.Add(new NameValues() { name = "Status", value = "Text", text = "狀態" });
            columns.Add(new NameValues() { name = "Sell_ID", value = "Text", text = "銷售ID" });
            columns.Add(new NameValues() { name = "Buy_ID", value = "Text", text = "購買ID" });
            columns.Add(new NameValues() { name = "Invoice_NO", value = "Text", text = "發票" });

            config_columns = new List<VarClass>();
            config_columns.Add(new VarClass()
            {
                value01 = 2,
                value02 = "Cost_class"
            });
            config_columns.Add(new VarClass()
            {
                value01 = 3,
                value02 = "Cost_detail"
            });
            config_columns.Add(new VarClass()
            {
                value01 = 5,
                value02 = "Rec_type"
            });
            config_columns.Add(new VarClass()
            {
                value01 = 13,
                value02 = "HasTax"
            });
            //   key_columns = new List<VarClass>();
        }
    }
}
