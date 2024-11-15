using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceAccountProgram.Models.UpdateForm
{
    public class UpdateFormClass
    {
        public static int Interest = 4;
        public static int dividend = 5;
        public static int payable = 6;
        public static int payableSalary = 7;         
        public static int NoIncluepayable = 8;
        public static int NoIncluepayableSalary = 9;
        public static int Assets = 10;
        public static int Depreciation_Cost = 11;
        public static int Cost_Income = 12;
        public static int gift = 13;
        public static int pre_payrate = 14;
        public static int others_cost = 15;
        public static int travel_income = 16;
        public static int rate = 17;
        public static int prepay_product = 18;
        public static int payfirstLaborInsurance = 19;
        public static int Cost_WorkOffice = 20;
    }
    public enum UpdateFormEnum01
    {
        None =0,
        SalaryData = 1,
        Office365 = 2,
        CompanyPhones =3,
        Finance = 4
    }
    public enum UpdateFormEnum02
    {
        None = 0,
        Interest = 1,
        dividend = 2,
        payable = 3,
        payableSalary = 4
    }
}
