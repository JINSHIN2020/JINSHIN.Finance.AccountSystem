using JINSHIN.BUSINESS.LIBARY.Base;
using JINSHIN.RegProcess.Liary.Content.Register.Model.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceAccountProgram.Models.Config
{
    public class DataClass :JBase
    {
        public static string A05 { get; set; }
        public static string A02 { get; set; }
        public static string KeyId { get; set; }
        public static string username { get; set; }
        public static int? SupplyNo { get; set; }
        public static string SearchEmpID { get; set; }
        public static int PosNo { get; set; }
        public static string empID { get; set; }
        public static string empName { get; set; }
        public static string OUID { get; set; }
        public static string usrno { get; set; }
        public static int worktype { get; set; }
        public static int? power { get; set; }
        public static bool Lock { get; set; }
        public static bool FirstTimeSign { get; set; }
        public static bool TrialLicense { get; set; }
        public static DateTime Traildate { get; set; }
        public static DateTime LicenseDate { get; set; }
        public static DateTime remaindate { get; set; }
        public static List<ProcessModel> process_values { get; set; }
        public static int deptno_supno { get; set; }

        //   public static MessageType msgtype { get; set; }
    }
}
