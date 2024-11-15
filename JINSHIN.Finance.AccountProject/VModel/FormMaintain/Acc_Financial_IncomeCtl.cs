
using FinanceAccountProgram.Models;
using FinanceAccountProgram.Models.UControl;
using JINSHIN.FinanceAccounting.DB;
using FinanceAccountProgram.VModel.AddQueryDataForm;
using FinanceAccountProgram.VModel.Conrols.Model;
using JINSHIN.Alayway.Frameworks.VModels.UIControl.DGridView;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JINSHIN.BUSINESS.LIBARY.Models.UIControls;
using JINSHIN.FinanceAccount.Libary.Models.Base;
using JINSHIN.FinanceAccount.Libary.VModels;
using JINSHIN.FinanceAccounting.DB.VModel;

namespace FinanceAccountProgram.VModel.FormMaintain
{
    public class Acc_Financial_IncomeCtl : AddQueryDataBase
    {
        public List<JINSHINFINANCE056> Financial_Incomes { get; set; }
        public List<JINSHINFINANCE047> jin047 { get; set; }

        public Acc_Financial_IncomeCtl()
        {
            jin047 = new List<JINSHINFINANCE047>();
            Financial_Incomes = new List<JINSHINFINANCE056>();
        }



        /// <summary>
        /// FrmDataMaintain
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="typename"></param>
        /// <param name="paramdata"></param>
        public void GetStorageData(AccountEntities entity, DataParams paramdata, int typename)
        {
            switch (typename)
            {
                case ImportQueryClass.Financial_Income:
                    {
                        Financial_Incomes.Clear();
                        List<JINSHINFINANCE056> values = new List<JINSHINFINANCE056>();
                        Financial_Incomes = entity.JINSHINFINANCE056.Where(o => (
                      ((o.DescData.IndexOf(paramdata.data011.data) != -1) || !paramdata.data011.enable) &&
                       ((o.Accid.IndexOf(paramdata.data004.data) != -1) || !paramdata.data004.enable)
                      )).ToList();

                   }
                    break;
                case ImportQueryClass.verifyImports:
                    {
                        jin047.Clear();
                        List<JINSHINFINANCE047> values = new List<JINSHINFINANCE047>();
                        jin047 = entity.JINSHINFINANCE047.Where(o => (
                      ((o.Descrip.IndexOf(paramdata.data011.data) != -1) || !paramdata.data011.enable) &&
                       ((o.Acc_ID.IndexOf(paramdata.data004.data) != -1) || !paramdata.data004.enable)
                      )).ToList();

                    }
                    break;
                default:
                    break;
            }
        }

        public List<string> SaveData( string datapath, bool IsDelete)
        {
            if (IsDelete)
            {
                RefreshDel();
            }            
            List<string> names = new List<string> { "AccId", "Orderth",  "datatype", "ComputeNo", 
                "cmd","Display","DescData", "ClassDesc", "MoneyType","Amount" };
            List<string> types = new List<string> {  "string","int", "int", "int",
                "string","string", "string","string", "int","decimal"};
            List<NameValues> items = new List<NameValues>();
            AccBaseCtl acc_ctl = new AccBaseCtl();
            List<string> files = acc_ctl.GetDataFile(datapath);
            FunctionControl functl = new FunctionControl();
            int cnt = 0;
            try
            {
                using (AccountEntityDB content = new AccountEntityDB())
                {
                    using (AccountEntities entities = content.GetEntity())
                    {
                        var costitem = entities.JINSHINFINANCE056.ToList();
                        for (int i = 0; i < files.Count; i++)
                        {
                            List<string> data = File.ReadAllLines(files[i], Encoding.GetEncoding(950)).ToList();
                            data.RemoveAt(0);
                            cnt = data.Count;
                            for (int j = 0; j < data.Count; j++)
                            {
                                List<string> values = data[j].Split(',').ToList();
                                SetNameValueData(names, types, items, values.ToArray());
                                JINSHINFINANCE056 income = new JINSHINFINANCE056();
                                functl.SetClassObj<JINSHINFINANCE056>(income, items);
                                income.CreateTime = DateTime.Now;
                                entities.JINSHINFINANCE056.Add(income);
                                entities.SaveChanges();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string str = ex.ToString();
            }
            finally
            {
                acc_ctl.Dispose();
                functl.Dispose();
            }
            return new List<string> { cnt.ToString() };
        }

        public void RefreshDel()
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entities = content.GetEntity())
                {
                    var financial_income = entities.JINSHINFINANCE056.ToList();
                    entities.JINSHINFINANCE056.RemoveRange(financial_income);
                    entities.SaveChanges();
                }
            }
        }



    }
}
