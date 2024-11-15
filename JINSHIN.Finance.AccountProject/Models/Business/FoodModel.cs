using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JINSHIN.BUSINESS.LIBARY.Base;
namespace FinanceAccountProgram.Models.Business
{
    public class FoodModel :JBase
    {
        public string Fname { get; set; }
        public decimal Fprice { get; set; }
    }
}
