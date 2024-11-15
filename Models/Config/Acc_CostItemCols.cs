using JINSHIN.BUSINESS.LIBARY.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceAccountProgram.Models.Config
{
    public class JINSHINFINANCE035Cols :JBase
    {
        public List<VarClass> key_columns = new List<VarClass>();
        public List<VarClass> verify_columns = new List<VarClass>();
        public List<VarClass> verifyMoney_columns = new List<VarClass>();
        //  public List<VarClass> money_columns = new List<VarClass>();
        public JINSHINFINANCE035Cols()
        {
            verifyMoney_columns.Add(new VarClass()
            {
                value01 = 0,
                value02 = "Verify_Month"
            });
            verifyMoney_columns.Add(new VarClass()
            {
                value01 = 2,
                value02 = "Acc_ID"
            });
            verifyMoney_columns.Add(new VarClass()
            {
                value01 = 3,
                value02 = "Invoice_NO"
            });

            verify_columns.Add(new VarClass()
            {
                value01 = 0,
                value02 = "Verify_Month"
            });
            verify_columns.Add(new VarClass()
            {
                value01 = 2,
                value02 = "Acc_ID"
            });
            verify_columns.Add(new VarClass()
            {
                value01 = 3,
                value02 = "Invoice_NO"
            });
            verify_columns.Add(new VarClass()
            {
                value01 = 1,
                value02 = "Amount"
            });
            key_columns.Add(new VarClass()
            {
                value01 = 0,
                value02 = "SN"
            });
            key_columns.Add(new VarClass()
            {
                value01 = 2,
                value02 = "Acc_ID"
            });

            key_columns.Add(new VarClass()
            {
                value01 = 3,
                value02 = "Item"
            });
        }
    }
}
