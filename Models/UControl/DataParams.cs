using JINSHIN.BUSINESS.LIBARY.Base;
using JINSHIN.Finance.AccountSystem.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FinanceAccountProgram.Models.UControl
{
    /// <summary>
    /// 
    /// </summary>
    public class DataParams : JBase
    {
        public dataCondition data001 { get; set; }
        public dataCondition data002 { get; set; }
        public dataCondition data003 { get; set; }
        public dataCondition data004 { get; set; }
        public dataCondition data005 { get; set; }
        public dataCondition data006 { get; set; }
        public dataCondition data011 { get; set; }
        public dataCondition data012 { get; set; }
        public dataCondition data013 { get; set; }
        public List<YearIntegrationModel> yiModels { get; set; }
        public List<string> accids { get; set; }
        public List<string> acc_desc { get; set; }
        public List<int> vmonths { get; set; }
        public int year { get; set; }
        public DataParams()
        {
            yiModels = new List<YearIntegrationModel>();
            accids = new List<string>();
            acc_desc = new List<string>();
            vmonths = new List<int>();
            data001 = new dataCondition();
            data002 = new dataCondition();
            data003 = new dataCondition();
            data004 = new dataCondition();
            data005 = new dataCondition();
            data006 = new dataCondition();
            data011 = new dataCondition();
            data012 = new dataCondition();
            data013 = new dataCondition();
        }
        public void ClearData()
        {
            data004.data = "";
            data004.enable = false;
            data005.data = "";
            data005.enable = false;
            data011.data = "";
            data011.enable = false;
            data003.data = "";
            data003.enable = false;
        }
    }
}
