using JINSHIN.FinanceAccounting.DB;
using FinanceAccountProgram.VModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JINSHIN.BUSINESS.LIBARY.Base;

namespace FinanceAccountProgram.Models.Config
{
    public class ClassTypeConfig<T> :JBase
    {
        public DBClassType types { get; set; }
        public List<T> mclass { get; set; }
    }
}
