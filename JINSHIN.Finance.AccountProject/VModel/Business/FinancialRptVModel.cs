using FinanceAccountProgram.Models;
using FinanceAccountProgram.Models.Config.UpdataeForm;

using FinanceAccountProgram.Models.VerifyModel;
using JINSHIN.FinanceAccounting.DB;

using FinanceAccountProgram.VModel.Conrols.GridView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JINSHIN.BUSINESS.LIBARY.Base;
using JINSHIN.FinanceAccount.Libary.Config;
using JINSHIN.FinanceAccount.Libary.Models.Financial;
using FinanceAccountProgram.VModel.Conrols.Model;
using FinanceAccountProgram.Models.AccountingData;

namespace FinanceAccountProgram.VModel.Business
{
    public class FinancialRptVModel :JBase
    {
        public FinancialRptVModel()
        {

        }

        /// <summary>
        /// 年度帳目檢查,去除不需要的帳目
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public List<VerifyAccGridView> CheckYearDataOK(List<VerifyAccGridView> values)
        {
            return values.Where(o => o.Rec_Type != FormConfig.ReserveRecType 
            && o.Rec_Type != FormConfig.WaitRecType && o.Is_Reserved != true).ToList();
        }

        public List<string> CheckDataType(List<AccCostLedgerModelView> models)
        {
            List<string> rs = new List<string>();
            using (FinancialAccidsModel financialModel = new FinancialAccidsModel())
            {
                int correctdatatype = 0;
                foreach (var item in models)
                {
                    correctdatatype =financialModel.GetAccidLendOrGet(item.Acc_ID);
                    if (correctdatatype != item.DataType)
                       rs.Add("科目:" +item.Acc_ID +",請檢查!");
                }
               
                return rs;
            }
        }

      


        public List<JINSHINFINANCE035> CheckOK(List<JINSHINFINANCE035> values)
        {
            return values.Where(o => o.Rec_Type != FormConfig.ReserveRecType
            && o.Rec_Type != FormConfig.WaitRecType && o.Is_Reserved != true).ToList();
        }

        /// <summary>
        /// 餘額查看
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public List<JINSHINFINANCE035> CheckVerialOK(List<JINSHINFINANCE035> values)
        {
            return values.Where(o => o.Cost_Check != true && o.Rec_Type != FormConfig.ReserveRecType 
            && o.Rec_Type != FormConfig.WaitRecType && o.Is_Reserved != true).ToList();
        }

        public bool RefreshGrid(List<JINSHINFINANCE035> values, DataGridView dgControl)
        {
            if (values.Count() > 0)
            {
                dgControl.DataSource = null;
                dgControl.DataSource = values;
                using (AccNoGridView gridview = new AccNoGridView())
                {
                    gridview.SetAccConfirmGridColumns(dgControl);
                }
                return true;
            }
            return false;
        }

        public List<VerifyCostFinancialModel> CheckAccNoSn(List<JINSHINFINANCE035> values)
        {
            List<VerifyCostFinancialModel> result = new List<VerifyCostFinancialModel>();
            var items = values.OrderBy(o => o.Acc_No).GroupBy(o => o.Acc_No.Substring(0,10));
            string acc_no = "";
            List<int> sn = new List<int>();
            foreach (var v in items)
            {
              VerifyCostFinancialModel val = new VerifyCostFinancialModel();
              for (int i = 1; i < v.Count(); i++)
              {
                    sn.Clear();
                    acc_no = v.ElementAt(i).Acc_No;
                    sn.Add(int.Parse(acc_no.Substring(10, acc_no.Length)));
                    acc_no = v.ElementAt(i-1).Acc_No;
                    sn.Add(int.Parse(acc_no.Substring(10, acc_no.Length)));
                    if ((sn[1] - sn[0]) == 1)
                    {
                        val.values.Add(v.ElementAt(i - 1));
                        val.values.Add(v.ElementAt(i));
                    }
                }
                if (val.values.Count > 0)
                  result.Add(val);
            }
            return result;
        }

        public List<JINSHINFINANCE035> CheckItemsContents(List<JINSHINFINANCE035> values)
        {
            List<JINSHINFINANCE035> result = new List<JINSHINFINANCE035>();
            var contents = AccCostItemConfig.GetVerifyClassData(values);
            return contents.Where(o => o.Is_Update == true).ToList();
        }


        public int GetAccNoCount(List<JINSHINFINANCE035> values)
        {
            return values.GroupBy(o => o.Acc_No).Count();
        }


        public List<JINSHINFINANCE035> CheckVerialLendAndGet(List<JINSHINFINANCE035> values)
        {            
            List<JINSHINFINANCE035> result = new List<JINSHINFINANCE035>();
            var contents = AccCostItemConfig.GetVerifyClassData(values);
            //decimal get, lend;            
            if (CompareItems(contents))
            {
                var data = contents.OrderBy(o=>o.Acc_No).GroupBy(o => o.Acc_No).ToList();
                foreach (var it in data)
                {
                    if (CompareItems(it.ToList()))
                    {
                        result.AddRange(it.ToList());
                    }
                }
            }
            return result;
        }

        public double GetYearIncomeResult(List<VerifyCostDataModel> values)
        {
            double val01 = double.Parse(values.Where(o => o.Add.datatypectl == 2 || (o.Add.datatypectl == 1 && o.Add.reserved == true)).Sum(o => o.costitem.Amount).Value.ToString());
            double val02 = double.Parse(values.Where(o => o.Add.datatypectl == 1 || (o.Add.datatypectl == 2 && o.Add.reserved == true)).Sum(o => o.costitem.Amount).Value.ToString());
            return val01 - val02;
        }


        public List<VerifyCostDataModel> GetYearsIncomeFinancialVal(List<JINSHINFINANCE035> values)
        {
            var contents = AccCostItemConfig.GetVerifyClassData(values);
            FinancialAccidsModel incomeparam = new FinancialAccidsModel();
            List<VerifyCostDataModel> result = new List<VerifyCostDataModel>();
            foreach (var item in contents)
            {
                VerifyCostDataModel data = new VerifyCostDataModel();
                data.Add = incomeparam.GetDataAddCostItem(item);
                data.costitem = item;
                result.Add(data);
            }
            return result;
        }
        


        private bool CompareItems(List<JINSHINFINANCE035> contents)
        {
           decimal get = contents.Where(o => o.DataType == 1).Sum(o => o.Amount).Value;
           decimal lend = contents.Where(o => o.DataType == 2).Sum(o => o.Amount).Value;
           return get != lend;
        }
    }
}
