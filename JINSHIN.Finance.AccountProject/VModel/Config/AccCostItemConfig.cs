using FinanceAccountProgram.Models.Config.UpdataeForm;
using JINSHIN.FinanceAccounting.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceAccountProgram.VModel.Config
{
    public class AccCostItemConfig
    {
        public static List<Acc_CostItem> GetClassData(List<Acc_CostItem> data)
        {
            return data.Where(val=> val.Rec_Type != 9 && val.Rec_Type != FormConfig.WaitRecType && val.Is_Reserved != true).ToList();
        }
    }
}
