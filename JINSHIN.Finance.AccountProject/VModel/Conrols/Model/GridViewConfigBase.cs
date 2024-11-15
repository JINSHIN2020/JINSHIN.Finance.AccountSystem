using FinanceAccountProgram.Models;
using JINSHIN.BUSINESS.LIBARY.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceAccountProgram.VModel.Conrols.Model
{
 //   [Serializable]
    public class GridViewConfigBase :JBase
    {
        public List<VarClass> config_columns { get; set; }
        public List<VarClass> key_columns { get; set; }
  
    }
}
