using FinanceAccountProgram.Models;
using JINSHIN.Finance.AccountSystem.Resources;
using JINSHIN.FinanceAccounting.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JINSHIN.BUSINESS.LIBARY.Base;
using JINSHIN.FinanceAccount.Libary.Config;
using JINSHIN.FinanceAccount.Libary.VModels;
using JINSHIN.FinanceAccounting.DB.VModel;

namespace FinanceAccountProgram.VModel.TPViewer
{
    public class InvoiceVModel :JBase
    {
        public int BalanceInvoiceBook()
        {
            int rs = 0;
            JINSHINFINANCE039 add = default(JINSHINFINANCE039);
            try
            {
                using (AccountEntityDB content = new AccountEntityDB())
                {
                    using (AccountEntities entity = content.GetEntity())
                    {
                        List<JINSHINFINANCE032> books = entity.JINSHINFINANCE032.Where(o => o.Acc_Date.Value.Year == AccountingReso.yearnow).ToList();
                        List<JINSHINFINANCE039> invoices = entity.JINSHINFINANCE039.Where(o => o.Acc_Date.Value.Year == AccountingReso.yearnow).ToList();
                        List<JINSHINFINANCE039> others = new List<JINSHINFINANCE039>();

                        bool checkresult = false;
                        //modify and delete
                        foreach (var inv in invoices.OrderBy(o => o.Acc_No))
                        {
                            checkresult = false;
                            foreach (var book in books.OrderBy(o => o.Acc_No))
                            {
                                if ((book.Acc_ID == inv.Acc_ID) &&
                                   (book.Item == inv.Item) && (book.Acc_No == inv.Acc_No))
                                {
                                    inv.Acc_Desc = book.Acc_Desc;
                                    inv.Amount = book.Amount;
                                    checkresult = true;
                                    break;
                                }
                            }
                            if (!checkresult)
                            {
                                others.Add(inv);
                            }
                        }
                        entity.SaveChanges();
                        //add
                        foreach (var book in books)
                        {
                            checkresult = false;
                            foreach (var inv in invoices)
                            {
                                if ((book.Acc_ID == inv.Acc_ID) &&
                                   (book.Item == inv.Item) && (book.Acc_No == inv.Acc_No))
                                {
                                    checkresult = true;
                                    break;
                                }
                            }
                            if (!checkresult)
                            {
                                add = new JINSHINFINANCE039()
                                {
                                    Acc_Date = book.Acc_Date,
                                    Acc_Desc = book.Acc_Desc,
                                    Acc_ID = book.Acc_ID,
                                    Acc_M = book.Acc_M,
                                    Acc_No = book.Acc_No,
                                    Amount = book.Amount,
                                    CreateTime = DateTime.Now,
                                    DataType = book.DataType,
                                    Item = book.Item
                                };
                                entity.JINSHINFINANCE039.Add(add);
                            }
                        }
                        foreach (var item in others)
                        {
                            entity.JINSHINFINANCE039.Remove(item);
                        }
                        entity.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                string str = ex.ToString();
            }
            return rs;
        }
    }
}
