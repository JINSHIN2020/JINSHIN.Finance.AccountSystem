using FinanceAccountProgram.Models;
using JINSHIN.BUSINESS.LIBARY.Base;
using JINSHIN.FinanceAccounting.DB;
using JINSHIN.FinanceAccounting.DB.VModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceAccountProgram.VModel
{
    public enum DBClassType
    {
        AccountBook = 1,
        InvoiceBook =2,
        Acc_Class = 3,
        Inv_Class = 5,
        Acc_DetailClass = 6
    }
    public class DBClassCtl :JBase
    {
        public void InsertClassData(string classname, int dataint, DBClassType dtype, int mdataint = 0)
        {
            try
            {
                using (AccountEntityDB content = new AccountEntityDB())
                {
                    using (AccountEntities entities = content.GetEntity())
                    {
                        switch (dtype)
                        {
                            case DBClassType.AccountBook:
                                break;
                            case DBClassType.InvoiceBook:
                                break;
                            case DBClassType.Acc_Class:
                                {
                                    JINSHINFINANCE034 accclass = new JINSHINFINANCE034();
                                    accclass.No = dataint;
                                    accclass.Name = classname;
                                    accclass.CreateTime = DateTime.Now;
                                    entities.JINSHINFINANCE034.Add(accclass);
                                }
                                break;

                            ///
                            case DBClassType.Inv_Class:
                                {
                                    JINSHINFINANCE057 accclass = new JINSHINFINANCE057();
                                    accclass.No = dataint;
                                    accclass.Name = classname;
                                    accclass.CreateTime = DateTime.Now;
                                    entities.JINSHINFINANCE057.Add(accclass);
                                }
                                break;
                            case DBClassType.Acc_DetailClass:
                                {
                                    JINSHINFINANCE037 accclass = new JINSHINFINANCE037();
                                    accclass.No = dataint;
                                    accclass.MaNo = mdataint;
                                    accclass.Name = classname;
                                    accclass.CreateTime = DateTime.Now;
                                    entities.JINSHINFINANCE037.Add(accclass);
                                }
                                break;
                            default:
                                break;
                        }
                        entities.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                string str = ex.ToString();
            }
           
        }

        public List<JINSHINFINANCE034> QueryAcc_Class()
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entities = content.GetEntity())
                {
                    return entities.JINSHINFINANCE034.ToList();
                }
            }
        }

        /// <summary>
        /// 憑證資訊
        /// </summary>
        /// <returns></returns>
        public List<JINSHINFINANCE057> QueryInv_Class()
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entities = content.GetEntity())
                {
                    return entities.JINSHINFINANCE057.ToList();
                }
            }
        }
        public List<JINSHINFINANCE037> QueryAcc_Detail()
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entities = content.GetEntity())
                {
                    return entities.JINSHINFINANCE037.ToList();
                }
            }
        }
        public List<JINSHINFINANCE037> QueryAcc_DetailClass(int masterno)
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entities = content.GetEntity())
                {
                    return entities.JINSHINFINANCE037.Where(o => o.MaNo == masterno).ToList();
                }
            }
        }
        public int GetClassNameMaxInt(DBClassType val,object data=null)
        {
            int rs = 0;
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entities = content.GetEntity())
                {
                    switch (val)
                    {
                        case DBClassType.AccountBook:
                            break;
                        case DBClassType.InvoiceBook:
                            break;
                            //發票類別
                        case DBClassType.Acc_Class:
                            {
                                if (entities.JINSHINFINANCE034.Count() > 0)
                                    rs = entities.JINSHINFINANCE034.Max(o => o.No) + 1;
                            }
                            break;
                            //憑證類別
                        case DBClassType.Inv_Class:
                            {
                                if (entities.JINSHINFINANCE057.Count() > 0)
                                    rs = entities.JINSHINFINANCE057.Where(i => i.No != 99999).Max(o => o.No) + 1;
                            }
                            break;
                        case DBClassType.Acc_DetailClass:
                            {
                                int masterno = 0;
                                int.TryParse(data.ToString(), out masterno);
                                var contents = entities.JINSHINFINANCE037.Where(o => o.MaNo == masterno).ToList();
                                if (contents.Count() > 0)
                                    rs = contents.Max(o => o.No) + 1;
                            }
                            break;
                        default:
                            break;
                    }
                    if (rs == 0)
                        return 1;
                }
            }
            return rs;
        }
        /// <summary>
        /// 更新發票及相關資訊
        /// </summary>
        /// <param name="IsDelete"></param>
        public void ClearInvoice_Books(int yearnow)
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities Acc_Books = content.GetEntity())
                {
                    try
                    {
                        var item = Acc_Books.JINSHINFINANCE039.Where(o => o.Acc_Date.Value.Year == yearnow).ToList();
                        Acc_Books.JINSHINFINANCE039.RemoveRange(item);
                        var data = Acc_Books.JINSHINFINANCE032.Where(o => o.Acc_Date.Value.Year == yearnow).ToList();
                        Acc_Books.JINSHINFINANCE032.RemoveRange(data);
                        Acc_Books.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        string str = ex.ToString();
                    }
                }
            }
        }

        /// <summary>
        /// 沒有加ItemID setup mode
        /// </summary>
        public List<AccBookModelView> CompareSaveToDB(string datapath,int bookType)
        {
            string title = "會計科目,傳票號碼,摘要";
            StringBuilder sb = new StringBuilder();
            sb.Append(title+Environment.NewLine);
            string[] datath = new string[2] {"Y","K" };
            List<AccBookModel> accbook01 = new List<AccBookModel>();
            List<AccBookModel> accbook02 = new List<AccBookModel>();
            List<AccBookModel> accbook03 = new List<AccBookModel>();
            List<AccBookModelView> accbookModel = new List<AccBookModelView>();
            try
            {
                using (AccountEntityDB content = new AccountEntityDB())
                {
                    using (AccountEntities Acc_Books = content.GetEntity())
                    {
                        accbook01 = Acc_Books.JINSHINFINANCE032.Select(o => new AccBookModel()
                        {
                            acc_date = o.Acc_Date.Value,
                            acc_desc = o.Acc_Desc,
                            acc_id = o.Acc_ID,
                            acc_m = o.Acc_M.Value,
                            acc_no = o.Acc_No,
                            item = o.Item,
                            amount = o.Amount.Value,
                            datatype = o.DataType.Value
                        }).ToList();
                        accbook02 = Acc_Books.JINSHINFINANCE039.Select(o => new AccBookModel()
                        {
                            acc_date = o.Acc_Date.Value,
                            acc_desc = o.Acc_Desc,
                            acc_id = o.Acc_ID,
                            acc_m = o.Acc_M.Value,
                            acc_no = o.Acc_No,
                            item = o.Item,
                            amount = o.Amount.Value,
                            datatype = o.DataType.Value
                        }).ToList();
                        bool IsNotGet = false;
                        for (int i = 0; i < accbook01.Count; i++)
                        {
                            IsNotGet = false;
                            for (int j = 0; j < accbook02.Count; j++)
                            {
                                if ((accbook01[i].acc_id == accbook02[j].acc_id) &&
                                    (accbook01[i].acc_desc == accbook02[j].acc_desc) &&
                                    (accbook01[i].acc_no == accbook02[j].acc_no))
                                {
                                    if (bookType == 1)
                                    {
                                        if (!((accbook01[i].acc_id == accbook02[j].acc_id) && (accbook01[i].acc_desc == accbook02[j].acc_desc)
                                            && (accbook01[i].acc_m == accbook02[j].acc_m) && (accbook01[i].acc_date == accbook02[j].acc_date)
                                            && (accbook01[i].acc_no == accbook02[j].acc_no) && (accbook01[i].amount == accbook02[j].amount)
                                            && (accbook01[i].datatype == accbook02[j].datatype)))
                                        {
                                            accbook03.Add(accbook01[i]);
                                        }
                                    }
                                    else if (bookType == 2)
                                    {
                                        if (!((accbook01[i].acc_id == accbook02[j].acc_id) && (accbook01[i].acc_desc == accbook02[j].acc_desc)
                                           && (accbook01[i].acc_m == accbook02[j].acc_m) && (accbook01[i].acc_date == accbook02[j].acc_date)
                                           && (accbook01[i].acc_no == accbook02[j].acc_no) && (accbook01[i].amount == accbook02[j].amount)
                                           && (accbook01[i].datatype == accbook02[j].datatype)))
                                        {
                                            accbook03.Add(accbook01[i]);
                                        }
                                    }
                                    IsNotGet = true;
                                }

                            }
                            if (IsNotGet == false)
                            {
                                accbook01[i].IsOnlyOne = true;
                                accbook03.Add(accbook01[i]);
                            }

                        }
                        //    accbook03 =accbook01.Except(accbook02).ToList();
                        accbook01.Clear();
                        accbook02.Clear();
                        int idx = 0;
                        for (int i = 0; i < accbook03.Count; i++)
                        {
                            string acc_no = accbook03[i].acc_no;
                            string acc_id = accbook03[i].acc_id;
                            string acc_desc = accbook03[i].acc_desc;
                            sb.Append(string.Format("{0},{1},{2}", acc_no, acc_id, acc_desc) + Environment.NewLine);
                            var item = Acc_Books.JINSHINFINANCE032.
                                Where(o => o.Acc_No == acc_no
                                && o.Acc_ID == acc_id && o.Acc_Desc == acc_desc).Select(o => new AccBookModelView()
                                {
                                    acc_date = o.Acc_Date.Value,
                                    acc_desc = o.Acc_Desc,
                                    acc_id = o.Acc_ID,
                                    acc_m = o.Acc_M.Value,
                                    acc_no = o.Acc_No,
                                    amount = o.Amount.Value,
                                    datatype = o.DataType.Value
                                }).FirstOrDefault();
                            idx = SetBookModelData(datath[0], accbookModel, idx, item);
                            var item2 = Acc_Books.JINSHINFINANCE039.
                                Where(o => o.Acc_No == acc_no
                                && o.Acc_ID == acc_id && o.Acc_Desc == acc_desc).Select(o => new AccBookModelView()
                                {
                                    acc_date = o.Acc_Date.Value,
                                    acc_desc = o.Acc_Desc,
                                    acc_id = o.Acc_ID,
                                    acc_m = o.Acc_M.Value,
                                    acc_no = o.Acc_No,
                                    amount = o.Amount.Value,
                                    datatype = o.DataType.Value
                                }).FirstOrDefault();
                            idx = SetBookModelData(datath[1], accbookModel, idx, item2);
                        }
                    }
                }
            //    File.WriteAllText(datapath + "accCompare" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt", sb.ToString());
            }
            catch (Exception ex)
            {
                string str = ex.ToString();
            }
            return accbookModel;
        }

        private static int SetBookModelData(string datath, List<AccBookModelView> accbookModel, int idx, AccBookModelView item)
        {
            if (item != null)
            {
                accbookModel.Add(item);
                accbookModel[idx].datath = datath;
            }
            else
            {
                accbookModel.Add(new AccBookModelView());
                accbookModel[idx].datath = datath;
            }
            idx++;
            return idx;
        }
        public List<JINSHINFINANCE034> GetAcc_Class()
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities Acc_Books = content.GetEntity())
                {
                    List<JINSHINFINANCE034> data = Acc_Books.JINSHINFINANCE034.ToList();
                    return data;
                }
            }
        }
        /// <summary>
        /// 1:
        /// 2:
        /// </summary>
        public int GetAccIncDec(string val,int dtype)
        {
            int datatype = Convert.ToInt32(val.Substring(0, 1));
            switch (datatype)
            {
                case 1: {
                        datatype = dtype;
                    } break;
                case 2: {
                        datatype = dtype==1?2:1;
                    } break;
                case 3: {
                        datatype = dtype == 1 ? 2 : 1;
                    } break;
                case 4: {
                        datatype = dtype == 1 ? 2 : 1;
                    } break;
                case 5: {
                        datatype = dtype;
                    } break;
                case 6: {
                        datatype = dtype;
                    } break;
                case 7: {
                        datatype = dtype == 1 ? 2 : 1;
                    } break;
                default:
                    break;
            }
            return datatype;
        }
        public List<JINSHINFINANCE037> GetAcc_ContentClass()
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities Acc_Books = content.GetEntity())
                {
                    return Acc_Books.JINSHINFINANCE037.ToList();
                }
            }
        }
        public void SaveDataToDB<T>(List<IGrouping<string,T>> data, DBClassType dtype) 
        {
            int itemsn = 1;
            string invoice = "";
            string Acc_No = "";
            try
            {
                using (AccountEntityDB content = new AccountEntityDB())
                {
                    using (AccountEntities Acc_Books = content.GetEntity())
                    {
                        foreach (var item in data)
                        {
                            itemsn = 1;
                            foreach (var v in item)
                            {
                                switch (dtype)
                                {
                                    case DBClassType.AccountBook:
                                        {
                                            JINSHINFINANCE032 acbook = v as JINSHINFINANCE032;
                                            acbook.Item = itemsn;
                                            itemsn++;
                                            Acc_Books.JINSHINFINANCE032.Add(acbook);
                                        }
                                        break;
                                    case DBClassType.InvoiceBook:
                                        {
                                            JINSHINFINANCE039 invbook = v as JINSHINFINANCE039;
                                            invoice = invbook.Invoice_No;
                                            Acc_No = invbook.Acc_No;
                                            invbook.Item = itemsn;
                                            itemsn++;
                                            Acc_Books.JINSHINFINANCE039.Add(invbook);
                                            //Acc_Books.SaveChanges();
                                        }
                                        break;
                                    default:
                                        break;
                                }

                            }
                        }
                        Acc_Books.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                string str = ex.ToString();
          //      throw;
            }
           




        }


    }
}
