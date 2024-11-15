using JINSHIN.BUSINESS.LIBARY.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceAccountProgram.Models.UControl
{
    public class dataCondition : JBase
    {
    //    public string id { get; set; }
        public string data { get; set; }
        public int value { get; set; }
        public bool enable { get; set; }
        public bool Add { get; set; }
        public bool All { get; set; }
    }
    public class AccBookParams :JBase
    {
      public dataCondition AccVal { get; set; }
      public dataCondition MasterVal { get; set; }
      public dataCondition ContentVal { get; set; }
      public dataCondition Acc_No { get; set; }
      public dataCondition Acc_ID { get; set; }
      public dataCondition Months { get; set; }
      public dataCondition Year { get; set; }
      public dataCondition Desc { get; set; }
      public dataCondition Amount { get; set; }
      public dataCondition invoice { get; set; }
      public AccBookParams()
      {
        AccVal = new dataCondition();
        MasterVal = new dataCondition();
        ContentVal = new dataCondition();
        Acc_No = new dataCondition();
        Acc_ID = new dataCondition();
        Months = new dataCondition();
        Desc = new dataCondition();
        Amount = new dataCondition();
        Year = new dataCondition();
        invoice = new dataCondition();
        Desc.data = "";
      }
    }
}
