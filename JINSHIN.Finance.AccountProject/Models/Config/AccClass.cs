using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceAccountProgram.Models.Config
{
    public class AccClass
    {
       public static string everypay = "攤提";//1
       public static string accounting = "帳務";//2
       public static string invoice = "憑證";//3
       public static string receive = "收據";//7
       public static string reverse_entry = "沖帳";//9
       public static List<VarClass> classtypes;
       public static void SetClassData()
       {
            classtypes =  new List<VarClass>();
            classtypes.Add(new VarClass()
             {
                 value01 = 1,
                 value02 = AccClass.everypay
             });

            classtypes.Add(new VarClass()
            {
                value01 = 2,
                value02 = AccClass.accounting
            });

            classtypes.Add(new VarClass()
            {
                value01 = 3,
                value02 = AccClass.invoice
            });

            classtypes.Add(new VarClass()
            {
                value01 = 7,
                value02 = AccClass.receive
            });

            classtypes.Add(new VarClass()
            {
                value01 = 8,
                value02 = AccClass.reverse_entry
            });
        }
    }
}
