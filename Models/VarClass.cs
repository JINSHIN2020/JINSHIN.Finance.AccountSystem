using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JINSHIN.BUSINESS.LIBARY.Base;
namespace FinanceAccountProgram.Models
{
    public class Pos : JBase
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    public class VarClass :JBase
    {
        public static int valueIdx = 0;
        public int value01 { get; set; }       
        public string value02 { get; set; }
        public decimal value03 { get; set; }
        public bool value05 { get; set; }
        public double value06 { get; set; }
        public Pos value07 { get; set; }
        public VarClass()
        {
            value07 = new Pos();
        }
    }
}
