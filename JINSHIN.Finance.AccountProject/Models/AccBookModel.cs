
using JINSHIN.FinanceAccount.Libary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceAccountProgram.Models
{
    public class AccBookModel : AccBookBase, IEquatable<AccBookModel>
    {
      public string acc_no { get; set; }
      public int acc_m { get; set; }
      public int item { get; set; }
      public bool IsOnlyOne { get; set; }
      public bool Equals(AccBookModel other)
      {
            return other.acc_id == this.acc_id && other.acc_no == this.acc_no && other.acc_desc == this.acc_desc;
      }
    }
}
