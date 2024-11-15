using FinanceAccountProgram.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JINSHIN.BUSINESS.LIBARY.Base;
namespace FinanceAccountProgram.VModel.DiaryInfo
{
    public class DiaryBookVModel :JBase
    {
        public int no { get; set; }
        public string MdataText { get; set; }
        public string DdataText { get; set; }
        public string accid { get; set; }
        public int datatype { get; set; }
        public int classtype { get; set; }
        public DateTime createtime { get; set; }
        public int sn { get; set; }
    }
}
