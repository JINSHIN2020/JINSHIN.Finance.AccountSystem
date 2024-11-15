using JINSHIN.BUSINESS.LIBARY.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceAccountProgram.Models.UpdateForm
{
    public class UpdateSalaryCols :JBase
    {
        public List<VarClass> key_columns = new List<VarClass>();
        public List<VarClass> sort_columns = new List<VarClass>();
        public UpdateSalaryCols()
        {
            VarClass.valueIdx = 10;
            sort_columns.Add(new VarClass()
            {
                value01 = 10,
                value02 = "Valid_Month"
            });
            sort_columns.Add(new VarClass()
            {
                value01 = 5,
                value02 = "Acc_No"
            });
            key_columns.Add(new VarClass()
            {
                value01 = 0,
                value02 = "SN"
            });          
            key_columns.Add(new VarClass()
            {
                value01 = 1,
                value02 = "Item"
            });
            key_columns.Add(new VarClass()
            {
                value01 = 2,
                value02 = "Acc_ID"
            });
        }
    }
}
