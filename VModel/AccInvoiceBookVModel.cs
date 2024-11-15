using FinanceAccountProgram.Models;
using JINSHIN.BUSINESS.LIBARY.Base;
using JINSHIN.FinanceAccount.Libary.VModels;
using JINSHIN.FinanceAccounting.DB;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceAccountProgram.VModel
{
    public class AccInvoiceBookVModel :JBase
    {
        public List<string> Invfullfiles { get; set; }
        public AccInvoiceBookVModel()
        {
            Invfullfiles = new List<string>();
        }
        /// <summary>
        /// Invoice DB Book
        /// 0:SN,1:ACCID,2:Date,3:ACCNO,4:Desc,5:Get,6:Lend,7:InvoiceNO,8:Rec,9:Sell_ID
        /// </summary>
        public async Task<string> SaveToInvoiceDBBook()
        {
            string msg = "";
            AccBaseCtl accctl = new AccBaseCtl();
            List<string> datatemp = new List<string>();
            List<string> lendorget = new List<string>();
            List<JINSHINFINANCE039> accbooks = new List<JINSHINFINANCE039>();
           // int SN = 1;
            int count = 0;
            int bookcnt = Invfullfiles.Count;
            string rectype = "";
            try
            {
                foreach (var item in Invfullfiles)
                {
                    string[] data = File.ReadAllLines(item, Encoding.GetEncoding(950));
                    datatemp = data.ToList();
                    for (int i = 0; i < 1; i++)
                        datatemp.RemoveAt(0);
                    int y = 0, m = 0, d = 0;
                   // count += datatemp.Count();
                    count = 0;
                    foreach (var i in datatemp)
                    {
                        count++;
                        string[] ims = i.Split(',');
                        lendorget.Clear();
                        lendorget = accctl.CheckLendOrGet(ims[5], ims[6]);
                        JINSHINFINANCE039 book = new JINSHINFINANCE039();
                    //    book.SN = SN;
                        book.DataType = int.Parse(lendorget[0]);
                        book.Amount = Convert.ToDecimal(lendorget[1]);
                        book.Acc_No = ims[3];
                        book.Acc_ID = ims[1];
                        y = int.Parse(ims[2].Substring(0, 3));
                        m = int.Parse(ims[2].Substring(3, 2));
                        d = int.Parse(ims[2].Substring(5, 2));
                        book.Acc_M = Convert.ToByte(m);
                        book.Acc_Date = new DateTime(y + 1911, m, d);
                        book.Acc_Desc = ims[4];
                        book.Invoice_No = ims[7];
                        book.Sell_ID = ims[9];
                        rectype = ims[8] == "" ? "2" : ims[8];
                        book.Rec_Type = int.Parse(rectype);
                        book.CreateTime = DateTime.Now;
                      //  SN++;
                        accbooks.Add(book);
                    }
                    msg = ("Invoices資料檔案取得共" + bookcnt.ToString() + "筆,轉換資料共" + accbooks.Count.ToString() + "筆");
                }
                
                var contents = accbooks.OrderBy(o => o.Acc_No).GroupBy(o => o.Acc_No).ToList();
                using (DBClassCtl dbctl = new DBClassCtl())
                {
                    dbctl.SaveDataToDB<JINSHINFINANCE039>(contents, DBClassType.InvoiceBook);
                }            
            }
            catch (Exception ex)
            {
                string str = ex.ToString();
            }
            finally
            {
                accctl.Dispose();
                datatemp.Clear();
                lendorget.Clear();
                accbooks.Clear();
            }
            return msg;
        }


    }
}
