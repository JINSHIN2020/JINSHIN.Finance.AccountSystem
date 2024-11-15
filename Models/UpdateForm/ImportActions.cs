using JINSHIN.BUSINESS.LIBARY.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceAccountProgram.Models.UpdateForm
{
    /// <summary>
    /// r為對沖
    /// u為更新
    /// e為沖
    /// </summary>
    public class ImportActions :JBase
    {
        public static string actionAdd = "+";
        public static string actionAddUpdate = "u";
        public static string actionDel = "-";
        public static string actionDirectRserve = "r";
        public static string actionRserve = "e";
        public static string actionWait = "f";
        public static string actionPaste = "p";
        public static string actionIndicateAdd = "i";
    }
}
