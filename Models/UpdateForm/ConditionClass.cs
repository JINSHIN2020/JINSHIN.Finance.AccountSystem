using JINSHIN.BUSINESS.LIBARY.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceAccountProgram.Models.UpdateForm
{
    /// <summary>
    /// 多種會科
    /// </summary>
    [Serializable]
    public class ConditionClass :JBase
    {
        public string AccID_Cost { get; set; }
        public string AccID_Real { get; set; }
        public int MonthALL { get; set; }
        public string Desc_Cost { get; set; }
        public string Desc_Real { get; set; }
        public string Multi_accids { get; set; }
        public ConditionClass()
        {
            Desc_Cost = "";
            Multi_accids = "";
        }
        //params01.data004.data = "1281";
        //    params01.data005.data = "1281";
        //    params01.data006.value =1;
        //    params01.data011.data = "勞健保";
    }
}
