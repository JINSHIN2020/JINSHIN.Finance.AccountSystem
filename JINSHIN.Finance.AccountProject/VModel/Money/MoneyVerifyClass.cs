using FinanceAccountProgram.Models;
using JINSHIN.FinanceAccounting.DB;
using FinanceAccountProgram.VModel.Conrols.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using JINSHIN.BUSINESS.LIBARY.Base;
using JINSHIN.FinanceAccount.Libary.VModels;
using JINSHIN.FinanceAccounting.DB.VModel;

namespace FinanceAccountProgram.VModel.Money
{
    public class MoneyVerifyClass :JBase
    {
        public void CheckVerify(List<JINSHINFINANCE035> values)
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    try
                    {
                        foreach (var i in values)
                        {
                            JINSHINFINANCE035 cost = entity.JINSHINFINANCE035
                                .Where(o => o.Acc_ID == i.Acc_ID && o.Acc_No == i.Acc_No
                                 && o.Item == i.Item).FirstOrDefault();
                            cost.Is_Fill = true;
                            cost.Cost_Check = true;
                            cost.Check_Date = DateTime.Now;
                        }
                        entity.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        string str = ex.ToString();
                    }

                }
            }
        }

        public void InvoiceImport(List<JINSHINFINANCE035> values)
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    try
                    {
                        foreach (var i in values)
                        {
                            JINSHINFINANCE035 cost = entity.JINSHINFINANCE035.Where(o => o.Acc_ID == i.Acc_ID && o.Acc_No == i.Acc_No && o.Item == i.Item).FirstOrDefault();
                            JINSHINFINANCE047 vitems = entity.JINSHINFINANCE047.Where(o => o.Verify_Month == cost.Verify_Month && o.Acc_ID == cost.Acc_ID && o.Amount == cost.Amount).FirstOrDefault();
                            if (vitems != null)
                                cost.Invoice_No = vitems.Invoice_No;
                        }
                        entity.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        string str = ex.ToString();
                    }
                }
            }
        }


        public void CheckVerify(List<VerifyAccGridView> values)
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    try
                    {
                        foreach (var i in values)
                        {
                            JINSHINFINANCE035 cost = entity.JINSHINFINANCE035.Where(o => o.Acc_ID == i.Acc_ID && o.Acc_No == i.Acc_No
                           && o.Item == i.Item).FirstOrDefault();
                            cost.Cost_Check = true;
                            cost.Check_Date = DateTime.Now;
                        }
                        entity.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        string str = ex.ToString();
                    }
                }
            }
        }
        public void CancelVerify(List<VerifyAccGridView> values)
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    try
                    {
                        foreach (var i in values)
                        {
                            JINSHINFINANCE035 cost = entity.JINSHINFINANCE035.Where(o => o.Acc_ID == i.Acc_ID && o.Acc_No == i.Acc_No
                           && o.Item == i.Item).FirstOrDefault();
                            cost.Cost_Check = false;
                            cost.Check_Date = null;
                        }
                        entity.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        string str = ex.ToString();
                    }
                }
            }
        }

        public void CancelVerify(List<JINSHINFINANCE035> values)
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    try
                    {
                        foreach (var i in values)
                        {
                            JINSHINFINANCE035 cost = entity.JINSHINFINANCE035.Where(o => o.Acc_ID == i.Acc_ID && o.Acc_No == i.Acc_No
                           && o.Item == i.Item).FirstOrDefault();
                            cost.Is_Fill = false;
                            cost.Cost_Check = false;
                        }
                        entity.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        string str = ex.ToString();
                    }
                }
            }
        }
    }
}
