using FinanceAccountProgram.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JINSHIN.BUSINESS.LIBARY.Base;
namespace FinanceAccountProgram.VModel
{
    public class BookCompute : JBase
    {
        public string taxno { get; set; }
        public double lend { get; set; }
        public double periodlend { get; set; }
        public double get { get; set; }
        public double periodget { get; set; }
        public double total { get; set; }
        public int booktype { get; set; }
        public bool durationNodata { get; set; }
    }
}
