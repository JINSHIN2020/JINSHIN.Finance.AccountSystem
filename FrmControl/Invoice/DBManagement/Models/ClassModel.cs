using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinInvoice.Models
{
    public class ClassModel
    {
        public long sn { get; set; }
        public int month { get; set; }
        public string accno { get; set; }
        public string fname { get; set; }
        public string dataname { get; set; }
        public string invno { get; set; }
        public string image { get; set; }
        public string datapath { get; set; }
        public bool chkdata { get; set; }
    }
}
