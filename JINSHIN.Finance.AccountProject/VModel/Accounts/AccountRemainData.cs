
using FinanceAccountProgram.Models;
using FinanceAccountProgram.Models.AccountingData;
using FinanceAccountProgram.Models.Config;
using JINSHIN.Finance.AccountSystem.Resources;
using JINSHIN.FinanceAccounting.DB;
using FinanceAccountProgram.VModel.Conrols.GridView;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JINSHIN.BUSINESS.LIBARY.Models.UIControls;
using JINSHIN.BUSINESS.LIBARY.Base;
using JINSHIN.FinanceAccount.Libary.Config;
using JINSHIN.FinanceAccount.Libary.VModels.Finanacial;
using JINSHIN.FinanceAccount.Libary.Models;
using JINSHIN.FinanceAccounting.DB.VModel;
using NPOI.POIFS.FileSystem;
using FinanceAccountProgram.VModel.Business;
using ZXing.OneD;
using Org.BouncyCastle.Asn1.Esf;

namespace FinanceAccountProgram.VModel.Accounts
{
    public class AccountRemainData : JBase
    {
        public PathModel pathmodel { get; set; }
        public AccountRemainData()
        {
           // DirectoryInfo di = new DirectoryInfo(path);
            pathmodel = new PathModel();
        }

        public void SaveJin48(AccountEntities entity, List<AccCostLedgerModelView> view,
          bool IsDelete, int today_year, JINSHINFINANCE035 jin35)
        {
            try
            {
                if (IsDelete)
                {
                    var items = entity.JINSHINFINANCE048.Where(v => v.Acc_Year == today_year).ToList();
                    if (items.Count() > 0)
                    {
                        entity.JINSHINFINANCE048.RemoveRange(items);
                        entity.SaveChanges();
                    }
                }
                List<JINSHINFINANCE048> values = new List<JINSHINFINANCE048>();
                var accdata = view.OrderBy(o => o.Acc_ID).ToList();
                foreach (var v in accdata)
                {
                    string accid = v.Acc_ID;
                    if (accid.Substring(0, 1) == "1"  || accid.Substring(0, 1) == "2" || accid.Substring(0, 1) == "3")
                    {
                        values.Add(new JINSHINFINANCE048()
                        {
                            Acc_Year = today_year,
                            Acc_ID = v.Acc_ID,
                            Acc_Date = new DateTime(today_year, 1, 1),
                            Acc_Desc = v.Acc_Desc,
                            DataType = v.DataType,
                            Amount= v.Amount,
                            CreateTime = DateTime.Now
                        });
                    }
                }

                var val35 = default(JINSHINFINANCE048); 
                if (jin35!= null)
                    val35 = values.Where(v => v.Acc_ID == jin35.Acc_ID).FirstOrDefault();
                if (val35 != null)
                {
                    val35.Amount = jin35.Amount + val35.Amount;
                }
                else
                {
                    values.Add(new JINSHINFINANCE048()
                    {
                        Acc_Year = today_year,
                        Acc_ID = jin35.Acc_ID,
                        Acc_Date = new DateTime(today_year, 1, 1),
                        Acc_Desc = jin35.Acc_Desc,
                        DataType = jin35.DataType,
                        Amount= jin35.Amount ,
                        CreateTime = DateTime.Now
                    });

                }
                entity.JINSHINFINANCE048.AddRange(values);
                entity.SaveChanges();
            }catch (Exception ex) { 
            
            }
        }

        public List<string> ShowFinancialLedgerGridView(DataGridView datagrid, int datayear,bool dataagain
            )
        {
            List<string> rs = new List<string>();
            //開帳資料為下一年度
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    using (JINSHINFINANCE036VModel legervmodel = new JINSHINFINANCE036VModel())
                    {
                        List<JINSHINFINANCE036> data = legervmodel.GetData(datayear);
                        List<AccCostLedgerModelView> models = new List<AccCostLedgerModelView>();
                        int sn = 1;
                        FunctionControl fc = new FunctionControl();
                        foreach (var item in data)
                        {
                            AccCostLedgerModelView view = new AccCostLedgerModelView();
                            fc.ClassCopyTo<JINSHINFINANCE036, AccCostLedgerModelView>(item, view);
                            item.SN = sn;
                            sn++;
                            models.Add(view);
                        }

                        SaveAccEveryAmt(datayear,dataagain,  entity, models);

                        List<string> msgrs = new List<string>();
                        using (FinancialRptVModel financial = new FinancialRptVModel())
                        {
                           msgrs =  financial.CheckDataType(models);                          
                        }

                        datagrid.DataSource = models;

                        var data01 = models.Where(v => v.DataType == 1).ToList();
                        var data02 = models.Where(v => v.DataType == 2).ToList();
                        rs.AddRange(msgrs);
                        rs.Add("借方:" + data01.Sum(v => v.Amount).Value.ToString("###,###,###,##0"));
                        rs.Add("貸方:" + data02.Sum(v => v.Amount).Value.ToString("###,###,###,##0"));
                        try
                        {
                            using (AccCostLedgerGridView gridview = new AccCostLedgerGridView())
                            {
                                gridview.SetAccConfirmGridColumns(datagrid);
                            }
                        }
                        catch (Exception ex)
                        {
                            return new List<string>();
                        }
                        return rs;
                    }
                }
            }
        }

        /// <summary>
        /// isopen:已經不能更新前期餘額
        /// dataagain:再更新前期餘額
        /// </summary>
        /// <param name="datayear"></param>
        /// <param name="dataagain"></param>
        /// <param name="entity"></param>
        /// <param name="models"></param>
        private void SaveAccEveryAmt(int datayear, bool dataagain, 
            AccountEntities entity, List<AccCostLedgerModelView> models)
        {
            var jin48 = entity.JINSHINFINANCE048.Where(
                        v => v.Acc_Year == datayear+1).ToList();
            bool? isopen = false;
            if (jin48.Count > 0)
                isopen = jin48.FirstOrDefault().IsClose;
            bool opened = isopen == null ? false : isopen.Value;
            bool isrefresh = !opened || dataagain;
            if (isrefresh)
            {
                if (jin48.Count() > 0)
                {
                    entity.JINSHINFINANCE048.RemoveRange(jin48);
                    entity.SaveChanges();
                }
            }

            //儲存期初項目,如果帳目沒有3351
            var jin3351 = entity.JINSHINFINANCE035.Where(v => v.Is_MoneyPay == true && v.Acc_ID == "3351").FirstOrDefault();
            if (isrefresh && jin3351 != null)
            {
                //儲存期初項目
                SaveJin48(entity, models
                    , isrefresh, datayear+1, jin3351);
            }
        }

        public void ShowFinancialLedgerGridView(DataGridView datagrid,int datayear, List<JINSHINFINANCE035> values)
        {
            List<AccCostLedgerModelView> models = new List<AccCostLedgerModelView>();
            int sn = 1;
            FunctionControl fc = new FunctionControl();
            foreach (var item in values)
            {
                AccCostLedgerModelView view = new AccCostLedgerModelView();
                fc.ClassCopyTo<JINSHINFINANCE035, AccCostLedgerModelView>(item, view);
                item.SN = sn;
                sn++;
                models.Add(view);
            }
            datagrid.DataSource = models.OrderBy(v=>v.Acc_ID).ToList();
            using (AccCostLedgerGridView gridview = new AccCostLedgerGridView())
            {
                gridview.SetAccConfirmGridColumns(datagrid);
            }
        }

        public List<YearBeginViewModel> SetMoneyData(int datayear)
        {
            return SetYearMonthData(datayear);
        }
        /// <summary>
        /// 讀取文字檔
        /// </summary>
        /// <returns></returns>
        public List<YearBeginViewModel> SetMoneyData()
        {
            string[] moneydata = File.ReadAllLines(pathmodel.moneypath + pathmodel.moneyfile);
            return SetYearMonthData(moneydata);
        }

        /// <summary>
        /// 匯入文字檔
        /// </summary>
        /// <returns></returns>
        public bool ImportMoneyData(int datayear,bool IsDelete)
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    var lst =entity.JINSHINFINANCE048.Where(v => v.Acc_Year == datayear).ToList();
                    if (lst.Count > 0)
                    {
                        MessageBox.Show("當年度己有開帳資料!");
                        return false;
                    }
                    if (IsDelete)
                    {
                        entity.JINSHINFINANCE048.RemoveRange(lst);
                        entity.SaveChanges();
                    }
                }
            }
            string[] moneydata = File.ReadAllLines(pathmodel.moneypath + pathmodel.moneyfile);
            try
            {
                List<JINSHINFINANCE048> values = new List<JINSHINFINANCE048>();
                using (AccountEntityDB content = new AccountEntityDB())
                {
                    using (AccountEntities entity = content.GetEntity())
                    {
                        for (int i = 0; i < moneydata.Length; i++)
                        {
                            string[] vals = moneydata[i].Split(',');
                            JINSHINFINANCE048 cost = new JINSHINFINANCE048();
                            cost.Acc_ID = vals[0];
                            cost.Acc_Date = new DateTime(datayear, 1, 1);
                            cost.Acc_Year = datayear;
                            cost.Acc_Desc = datayear.ToString() + "年度期初餘額";
                            cost.CreateTime = DateTime.Now;
                            cost.IsClose = true;

                            double amt = Convert.ToDouble(vals[1]);
                            if (Math.Sign(amt) > 0)
                            {
                                cost.DataType = 1;
                            }
                            else
                                cost.DataType = 2;
                            cost.Amount =  Math.Abs(Convert.ToDecimal(vals[1]));
                            values.Add(cost);
                        }
                        entity.JINSHINFINANCE048.AddRange(values);
                        entity.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                
                return false;
            }
            return true;           
        }

        /// <summary>
        /// 讀取DB
        /// </summary>
        /// <returns></returns>
        public List<YearBeginViewModel> SetDBMoneyData(int openyear)
        {          
            return SetYearMonthData(openyear);
        }

        private List<YearBeginViewModel> SetYearMonthData(int year)
        {
            List<YearBeginViewModel> ybviewmodel = new List<YearBeginViewModel>();

            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    var jin48 = entity.JINSHINFINANCE048.Where(v => v.Acc_Year == year).OrderBy(v=>v.Acc_ID).ToList();
                  //  YearBeginViewModel val = new YearBeginViewModel();
                    foreach (var item in jin48)
                    {
                        YearBeginViewModel val = new YearBeginViewModel();
                        val.key = item.Acc_ID;
                        val.datatype = Convert.ToInt32(item.DataType);
                        val.value = item.Amount.Value.ToString();
                        val.checkvalue = false;
                        ybviewmodel.Add(val);
                    }
                }
            }

                   
            return ybviewmodel;
        }


        private List<YearBeginViewModel> SetYearMonthData(string[] keys)
        {
            List<YearBeginViewModel> ybviewmodel = new List<YearBeginViewModel>();
            for (int i = 0; i < keys.Length; i++)
            {
                YearBeginViewModel val = new YearBeginViewModel();
                string[] vals = keys[i].Split(',');
                val.key = vals[0];
                val.value = vals[1];
                val.checkvalue = false;
                ybviewmodel.Add(val);
            }
            return ybviewmodel;
        }
    }
}
