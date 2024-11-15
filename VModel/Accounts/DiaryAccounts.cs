using FinanceAccountProgram.Models;
using FinanceAccountProgram.Models.Accounts;
using FinanceAccountProgram.Models.Config;
using JINSHIN.Finance.AccountSystem.Resources;
using JINSHIN.BUSINESS.LIBARY.Events;
using JINSHIN.BUSINESS.LIBARY.Base;
using JINSHIN.FinanceAccount.Libary.Models.Financial;
using JINSHIN.FinanceAccounting.DB;
using ProjectResourceData;
using System;
using System.Collections.Generic;
using System.Linq;
using JINSHIN.FinanceAccount.Libary.VModels;
using JINSHIN.FinanceAccounting.DB.VModel;

namespace FinanceAccountProgram.VModel.Accounts
{
    /// <summary>
    /// zero base do not have data in the values list 
    /// </summary>
    public class DiaryAccounts :JBase
    {
        public List<DiaryModel> values { get; set; }
        public List<DiaryDefaultModel> defaulModel { get; set; }
        public int DialaryLink { get; set; }
        private List<JINSHINFINANCE041> accidnames { get; set; }
        
        public DiaryAccounts()
        {
            List<string> contents = new List<string>();
            defaulModel = new List<DiaryDefaultModel>();
            contents.Add(Diary.Default.OfficeCost);
            AddDefaultModel(30,2,"6112",1,Diary.Default.OfficeCost,3,0 , "office");
            AddDefaultModel(30,2, "1262",2, Diary.Default.OfficeCost, 3, 0, "office");    
            
            AddDefaultModel(30,3, "6112", 1, Diary.Default.Office365, 2, 0, "office365");
            DiaryDefaultModel model = AddDefaultModel(30, 3, "6123", 1, Convert.ToDecimal(Convert.ToDouble(Diary.Default.Office365) / (1 + 0.05) * 0.05).ToString(),2, 0, "office365");
            AddDefaultModel(30,3, "1113", 2, Diary.Default.Office365, 2,model.amount, "office365");

            AddDefaultModel(1,1, "6111", 1, Diary.Default.Salary, 3, 0, "薪資");
            AddDefaultModel(1,1, "1281", 1, Diary.Default.LaborHealthInsuranceCost, 3, 0, "勞健保");
            AddDefaultModel(1,1, "6120", 1, Diary.Default.CompanyInsurace, 3, 0, "保險費");
            AddDefaultModel(1,1, "1261", 1, "0", 3, 0, "業務支出");
            AddDefaultModel(1,1, "2171", 2, Diary.Default.CompanyInsurace, 3, 0, "薪資");
            contents.Clear();
            contents.Add(Diary.Default.Salary);
            contents.Add(Diary.Default.LaborHealthInsuranceCost);
            AddDefaultModel(1,1, "2191", 2,contents, 3, 0, "薪資");

            AddDefaultModel(1,7, "2171", 1, "0", 3, 0, "薪資支出");
            AddDefaultModel(1,7, "2191", 1, "0", 3, 0, "薪資支出");
            AddDefaultModel(1,7, "1113", 2, "0", 3, 0, "薪資支出");

            AddDefaultModel(1,8, "6111", 1, Diary.Default.LaborHealthInsuranceCost, 3, 0, "勞健保支出");
            AddDefaultModel(1,3, "1281", 2, Diary.Default.LaborHealthInsuranceCost, 3, 0, "勞健保支出");

            AddDefaultModel(1,3, "6111", 1, "0", 2, 0, "業務支出");
            DiaryDefaultModel model02 = AddDefaultModel(1,3, "6123", 1,"0", 2, 0, "業務支出");
            AddDefaultModel(1,3, "1113", 2, "0", 2, model02.amount, "業務支出");
            AddDefaultModel(1, 3, "1261", 2, "0", 2,0, "業務支出");
            //
            AddDefaultModel(1, 1, "6134", 1, Diary.Default.MediaCost, 3, 0, "預付投資、最新消息媒體費");
            AddDefaultModel(1, 1, "1262", 2, Diary.Default.MediaCost, 3, 0, "預付投資、最新消息媒體費");

            AddDefaultModel(6, 5, "6116", 1, "0", 3, 0, "郵電費");
            AddDefaultModel(6, 5, "6123", 1, "0", 3, 0, "郵電費");
            AddDefaultModel(6, 5, "1113", 2, "0", 3, 0, "郵電費");
            // amodel.
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    List<AccNameLink> namelinks = new List<AccNameLink>();
                    values = new List<DiaryModel>();
                    values.Add(new DiaryModel());
                    accidnames = entity.JINSHINFINANCE041.ToList();
                    List<AccidAccount> datactl = new List<AccidAccount>();
                    bool IsDefaultAccount = false;
                    //var accountsdata = entity.JINSHINFINANCE050.GroupBy(o => o.Mdatalink).ToList();
                    var accountsdata = entity.JINSHINFINANCE050.ToList();
                    try
                    {
                        foreach (var v in accountsdata)
                        {
                            var vmodel = defaulModel.Where(o => o.accid == v.AccId && o.Mdataid == v.Mdatalink && o.dataid == v.Ddatalink && o.datatype == v.datatype).FirstOrDefault();
                            if (vmodel != null)
                            {
                                try
                                {
                                    datactl.Add(new AccidAccount()
                                    {
                                        AccID = v.AccId,
                                        datatypectl = v.datatype.Value,
                                        amount = vmodel.amount,
                                        defaultdate = v.CostDate.Value,
                                        remark = vmodel.descirption,
                                        mdata = v.Mdatalink.Value,
                                        ddata = v.Ddatalink.Value
                                    });
                                    //only one tag,control all status to be right
                                    IsDefaultAccount = true;
                                }
                                catch (Exception ex)
                                {
                                    string str = ex.ToString();
                                }
                            }
                            //else
                            //{
                            //    string desc = vmodel != null ? vmodel.descirption : "";
                            //    datactl.Add(new AccidAccount()
                            //    {
                            //        AccID = v.AccId,
                            //        datatypectl = v.datatype.Value,
                            //        remark = desc
                            //    });
                            //    IsDefaultAccount = false;
                            //}
                        }
                        var data = datactl.GroupBy(o => new { o.mdata, o.ddata });
                        foreach (var item in data)
                        {
                            AddAccounts(datactl, item.First().mdata, item.First().ddata, IsDefaultAccount);
                        }                          
                    }
                   // }
                    catch (Exception ex)
                    {
                        string str = ex.ToString();
                    }
                }
            }
        }

        private DiaryDefaultModel AddDefaultModel(int Mdataid,int dataid, string accid, int datatype, string amounts, int rec_type, decimal taxamount,string desc)
        {
            DiaryDefaultModel amodel = new DiaryDefaultModel();
            amodel.Mdataid = Mdataid;
            amodel.dataid = dataid;
            amodel.datatype = datatype;
            amodel.accid = accid;          
            amodel.amount = Convert.ToDecimal(amounts);
            if (taxamount != 0)
            {
                amodel.amount = amodel.amount - taxamount;
            }
            amodel.Rec_Type = rec_type;
            amodel.descirption = desc;
            defaulModel.Add(amodel);
            return amodel;
        }

        private DiaryDefaultModel AddDefaultModel(int Mdataid,int dataid,string accid,int datatype,List<string> amounts,int rec_type,decimal taxamount,string desc)
        {
            DiaryDefaultModel amodel = new DiaryDefaultModel();
            amodel.Mdataid = Mdataid;
            amodel.dataid = dataid;
            amodel.datatype = datatype;
            amodel.accid = accid;
            foreach (var item in amounts)
            {
              amodel.amount = amodel.amount + Convert.ToDecimal(item);
            }
            if (taxamount != 0)
            {
                amodel.amount = amodel.amount - taxamount;
            }
            amodel.Rec_Type = rec_type;
            amodel.descirption = desc;
            defaulModel.Add(amodel);
            return amodel;
        }

        public List<JINSHINFINANCE035> ChangeToCost(List<JINSHINFINANCE050> entits)
        {
            List<JINSHINFINANCE035> items = new List<JINSHINFINANCE035>();
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    int sn = 1;
                    foreach (var v in entits)
                    {
                        items.Add(new JINSHINFINANCE035()
                        {
                            SN = sn,
                            Acc_ID = v.AccId,
                            DataType = Convert.ToByte(v.datatype)
                        });
                        sn = sn + 1;
                    }
                }
            }
            return items;

        }
        public List<JINSHINFINANCE035> GetData(JINSHINFINANCE037 data)
        {
            List<JINSHINFINANCE035> items = new List<JINSHINFINANCE035>();
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    var vals = entity.JINSHINFINANCE050.Where(o => o.Mdatalink == data.MaNo && o.Ddatalink == data.No).OrderBy(i => i.Sn).ToList();
                    int sn = 1;
                    foreach (var v in vals)
                    {
                        items.Add(new JINSHINFINANCE035()
                        {
                            SN = sn,
                            Acc_ID = v.AccId,
                            DataType = Convert.ToByte(v.datatype)
                        });
                        sn = sn + 1;
                    }
                }
            }
            return items;
        }

        public List<JINSHINFINANCE035> GetData(JINSHINFINANCE037 datalink,int datatype)
        {
            List<JINSHINFINANCE035> items = default(List<JINSHINFINANCE035>);
            List<JINSHINFINANCE050> data = default(List<JINSHINFINANCE050>);
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    if (datatype != 0)
                    {
                        data = entity.JINSHINFINANCE050.Where(o => o.Mdatalink == datalink.MaNo && o.Ddatalink == datalink.No && o.datatype == datatype).ToList();
                    }
                    else
                    {
                        data = entity.JINSHINFINANCE050.Where(o => o.Mdatalink == datalink.MaNo && o.Ddatalink == datalink.No).ToList();
                    }
                    items = ChangeToCost(data);
                }
            }
            return items;
        }

        private void AddAccounts(List<AccidAccount> namelinks,int datalink,int ddatalink,bool DefaultAccount)
        {
            foreach (var item in namelinks)
            {
                item.AccName = GetAccIdData(item.AccID).AccName;
            }            
            AddDiaryAccountsLink(namelinks, datalink, ddatalink, DefaultAccount);
           // namelinks.Clear();
        }

        private List<AccidAccount> ProduceAccounts(List<AccNameLink> contents)
        {
            List<AccidAccount> accounts = new List<AccidAccount>();
            foreach (var item in contents)
            {
                JINSHINFINANCE041 idname = GetAccIdData(item.accname.Acc_ID);
                accounts.Add(new AccidAccount() { costdate = item.CostDate, AccID = idname.Acc_ID, AccName = idname.AccName });
            }         
            contents.Clear();
            return accounts;
        }

        private JINSHINFINANCE041 GetAccIdData(string accid)
        {
            return accidnames.Where(o => o.Acc_ID == accid).FirstOrDefault();
        }
        private void AddDiaryAccountsLink(List<AccidAccount> items,int diarylinkno,int dno, bool DefaultAccount)
        {
            DiaryModel data = SetAccountsData(items, diarylinkno,dno, DefaultAccount);
            values.Add(data);
           // items.Clear();
        }

        private DiaryModel SetAccountsInfo(List<AccidAccount> data, int link)
        {
            DiaryModel val = values.Where(o => o.DialaryLink == link).FirstOrDefault();
            if (val != null)
            {
                List<AccidAccount> info = val.values.OrderBy(o => o.datatypectl).ToList();
                for (int i = 0; i < data.Count; i++)
                {
                    AccidAccount item = info.Where(o=>o.datatypectl == data[i].datatypectl && o.AccID == data[i].AccID).FirstOrDefault();
                    item.costdate = data[i].costdate;
                    item.amount = data[i].amount;
                    item.AccDesc = data[i].AccDesc;
                }
            }
            return val;
        }
     

        public List<JINSHINFINANCE037> GetJINSHINFINANCE050Items()
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    return entity.JINSHINFINANCE037.ToList();
                }
            }
        }
        /// <summary>
        /// itmes 的 zero base have data
        /// </summary>
        /// <param name="items"></param>
        /// <param name="month"></param>
        public void SaveAccountsToDB(List<DiaryModel> items,int month)
        {
            int sn = 1;
            string acc_no = "";
            DateTime dtime = default(DateTime);
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {                    var contents = items.GroupBy(o => o.Day).ToList();

                    List<JINSHINFINANCE035> data = new List<JINSHINFINANCE035>();
                    int itemsn = 1;
                    for (int i = 0; i < contents.Count; i++)
                    {
                        sn = 1;
                        foreach (var v in contents[i])
                        {
                            if (v.values.Count == 0)
                                break;
                            dtime = new DateTime(DateTime.Now.Year, month, v.values.First().defaultdate.Day);
                            if (dtime.Day == 30)
                            {
                                int dcnt = DateTime.DaysInMonth(dtime.Year, dtime.Month) - dtime.Day;
                                dtime = dtime.AddDays(dcnt);
                            }
                            acc_no = Diary.Default.DiaryAccNo + dtime.Year.ToString() + dtime.Month.ToString("00") + dtime.Day.ToString("00") + sn.ToString("000");
                            itemsn = 1;
                            foreach (var p in v.values)
                            {
                                JINSHINFINANCE035 cost = new JINSHINFINANCE035();
                                cost.Acc_No = acc_no;
                                cost.Item = itemsn;
                                cost.Cost_Date = dtime;
                                cost.Cost_M = Convert.ToByte(dtime.Month);
                                cost.Acc_ID = p.AccID;
                                cost.DataType = byte.Parse(p.datatypectl.ToString());
                                cost.Amount = p.amount;
                                cost.Acc_Desc = dtime.Month.ToString() + "月份" + p.AccDesc;
                                cost.Status = coststatus.accountcreated;
                                data.Add(cost);
                                itemsn = itemsn + 1;
                            }
                            sn = sn + 1;
                        }
                    }
                    try
                    {
                        entity.JINSHINFINANCE035.AddRange(data);
                        entity.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        LogControl.LogAlarm(ex.ToString());
                    }
                }
            }
        }
        public DiaryModel SetAccountsData(List<AccidAccount> data,int link,int dlink,bool isdefault)
        {
            DiaryModel val = new DiaryModel();
            int day = 0;
            var detial = data.Where(o => o.mdata == link && o.ddata == dlink).ToList();   
            for (int i = 0; i < detial.Count; i++)
            {
                AccidAccount item = new AccidAccount()
                {
                    AccName = detial[i].AccName,
                    amount = detial[i].amount,
                    defaultdate = detial[i].defaultdate,
                    AccID = detial[i].AccID,
                    AccDesc = detial[i].AccDesc,
                    datatypectl = detial[i].datatypectl,
                    remark = detial[i].remark
                };
                day = detial[i].defaultdate.Day;
                if (string.IsNullOrEmpty(item.AccDesc) && !string.IsNullOrEmpty(item.remark))
                {
                    item.AccDesc =  item.remark;
                }
                val.values.Add(item);
            }
            val.DialaryLink = link;
            val.Day = day;
            val.IsDefaultAccount = isdefault;
            return val;
        }
    }
}
