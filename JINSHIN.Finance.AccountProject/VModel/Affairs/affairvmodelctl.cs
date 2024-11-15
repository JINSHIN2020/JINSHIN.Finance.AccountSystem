using FinanceAccountProgram.Models;
using FinanceAccountProgram.Models.UControl;
using JINSHIN.Finance.AccountSystem.Resources;
using JINSHIN.FinanceAccounting.DB;
using FinanceAccountProgram.VModel.AddQueryDataForm;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JINSHIN.BUSINESS.LIBARY.Base;
using JINSHIN.FinanceAccount.Libary.Config;
using JINSHIN.FinanceAccounting.DB.VModel;

namespace FinanceAccountProgram.VModel.Affairs
{
    public class affairvmodelctl :JBase
    {
        public List<JINSHINFINANCE047> acc_VerifyItmes { get; set; }
        public List<JINSHINFINANCE035> acc_CostItmes { get; set; }
        public List<string> specialAccds { get; set; }
        public List<string> Accid_desc { get; set; }


        public void GetVerifyItems(DataParams paramdata)
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    acc_VerifyItmes.Clear();
                    acc_VerifyItmes = entity.JINSHINFINANCE047.Where(o => (
                    ((o.Verify_Month == paramdata.data002.value) || !paramdata.data002.enable 
                    || (paramdata.data006.value == 1)) &&
                    ((o.Descrip.IndexOf(paramdata.data011.data) != -1) || !paramdata.data011.enable) &&
                     ((o.Acc_ID.IndexOf(paramdata.data004.data) != -1) || !paramdata.data004.enable)
                    && (o.Acc_Date.Value.Year == AccountingReso.yearnow)
                     )
                    ).ToList();
                    var temp = acc_VerifyItmes.GroupBy(o => new { o.Descrip }).ToList();
                    List<JINSHINFINANCE047> data01 = new List<JINSHINFINANCE047>();
                    foreach (var item in temp)
                    {
                        data01.Add(item.First());
                    }
                    List<JINSHINFINANCE033> data05 = entity.JINSHINFINANCE033.ToList();
                    var data02 = data01.Join(entity.JINSHINFINANCE033.ToList(), o => new { ac_id = o.Acc_ID, desc = o.Descrip.Trim() }, i => new { ac_id = i.Acc_ID, desc = i.Desc02.Trim() },
                        (o, i) => new { i.Desc01 }).ToList();
                    Accid_desc.Clear();
                    data02.ForEach(o => Accid_desc.Add(o.Desc01));
                    acc_VerifyItmes = acc_VerifyItmes.OrderBy(o => o.Descrip).ThenBy(i => i.Verify_Month).ThenBy(c => c.EmpName).ToList();
                }
            }
        }
        public affairvmodelctl()
        {
           //gvbase = new GridViewBase(datatype);
            acc_VerifyItmes = new List<JINSHINFINANCE047>();
            acc_CostItmes = new List<JINSHINFINANCE035>();
            Accid_desc = new List<string>();
            specialAccds = new List<string>();
        }

        public void DataShow<T>(DataGridView dgData, DataParams param,bool ischeck)
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities accbook = content.GetEntity())
                {
                    //ufe02是否依據acc_desc分析
                    //change ctl03
                    GetStorageData(accbook, param,ischeck);
                    dgData.DataSource = acc_CostItmes.ToList();
                }
            }
        }

        public void GetStorageData(AccountEntities entity, DataParams paramdata,bool ischeck)
        {
            acc_CostItmes.Clear();
            List<JINSHINFINANCE035> values = new List<JINSHINFINANCE035>();
            List<JINSHINFINANCE035> ctl = new List<JINSHINFINANCE035>();
            try
            {
                //加入時已有排序
                List<string> accids = paramdata.data013.data.Split(',').ToList();
                List<string> descs = paramdata.data003.data.Split(',').ToList();
                int idx = 0;
                foreach (var item in accids)
                {
                    //data005 會科名稱的集合
                    //data003 會科描述的集合
                    var contents = AccCostItemConfig.GetClassData(entity.JINSHINFINANCE035.Where(o => o.Cost_Date.Value.Year == AccountingReso.yearnow).ToList());
                    var costitem = contents.Where(o =>
                     ((o.Acc_ID == item) || !paramdata.data005.enable) &&
                     ((o.Acc_Desc.ToUpper().IndexOf(descs[idx].ToUpper()) != -1) || !paramdata.data003.enable)
                     && (o.Cost_Check != ischeck)
                     ).ToList();
                    ctl.AddRange(costitem);
                    idx++;
                }

                var data = ctl.GroupBy(o => o.Acc_No).ToList();
                var contetns = AccCostItemConfig.GetClassData(entity.JINSHINFINANCE035.Where(o => o.Cost_Date.Value.Year == AccountingReso.yearnow).ToList());
                foreach (var item in data)
                {
                    values.AddRange(contetns.Where(o => o.Acc_No == item.First().Acc_No
                    ));
                }
                var query = values.GroupBy(o => o.Acc_No).ToList();

                List<string> acc_no_lst = new List<string>();
                foreach (var item in query)
                {
                    acc_no_lst.Add(item.First().Acc_No);
                }

                List<JINSHINFINANCE035> vals = default(List<JINSHINFINANCE035>);
                bool checkresult = false;
                checkresult = specialAccds.Where(o => o == paramdata.data005.data).Count() > 0;
                if (values.Count > 0)
                {
                    if (paramdata.data011.enable)
                    {
                        string acc_no = "";
                        //1.是否依據accid_desc 的數量作分析，使用摘要處理
                        if (Accid_desc.Count > 0)
                        {
                            foreach (var item in Accid_desc)
                            {
                                foreach (var p in query)
                                {                                        
                                    if (p.Where(o => o.Acc_Desc.ToUpper().IndexOf(item.ToUpper()) != -1).Count() > 0)
                                    {
                                        acc_no = p.First().Acc_No;
                                        vals = contetns.Where(o => o.Acc_No == p.First().Acc_No).ToList();

                                        //確認是否有重覆新增的項目
                                        if (acc_no_lst.FindIndex(v => v == acc_no) != -1)
                                        {
                                            if (ischeck)
                                            {

                                                if ((vals.Where(o => o.Cost_Check == null
                                                    || o.Cost_Check == false).Count() > 0) || checkresult == false
                                                    )
                                                {
                                                    acc_no_lst.Remove(p.First().Acc_No);
                                                    acc_CostItmes.AddRange(vals);
                                                }

                                            }
                                            else
                                            {
                                                if ((vals.Where(o => o.Cost_Check == true).Count() > 0)
                                                    || checkresult == false)
                                                {
                                                    acc_no_lst.Remove(p.First().Acc_No);
                                                    acc_CostItmes.AddRange(vals);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                            
                        //編號
                        foreach (var p in acc_no_lst)
                        {
                            vals = contetns.Where(o => o.Acc_No == p).ToList();
                            if (ischeck)
                            {
                                if ((vals.Where(o => o.Cost_Check == null 
                                    || o.Cost_Check == false).Count() > 0) || checkresult == false)
                                {
                                    acc_no_lst.Remove(p);
                                    acc_CostItmes.AddRange(vals);
                                }
                            }
                            else
                            {
                                if ((vals.Where(o => o.Cost_Check == true).Count() > 0) 
                                    || checkresult == false)
                                {
                                    acc_no_lst.Remove(p);
                                    acc_CostItmes.AddRange(vals);
                                }
                            }
                        }
                    }
                    else
                    {
                        foreach (var p in query)
                        {
                            vals = contetns.Where(o => o.Acc_No == p.First().Acc_No).ToList();
                            if (ischeck)
                            {
                                if ((vals.Where(o => o.Cost_Check == null || o.Cost_Check == false).Count() > 0) || checkresult == false)
                                    acc_CostItmes.AddRange(vals);
                            }
                            else
                            {
                                if ((vals.Where(o => o.Cost_Check == true).Count() > 0) || checkresult == false)
                                    acc_CostItmes.AddRange(vals);
                            }
                        }
                    }
                    acc_CostItmes = acc_CostItmes.OrderBy(o => o.Acc_No).ThenBy(o => o.DataType).ToList();
                }
            }
            finally
            {
                ctl.Clear();
            }
        }
    }
}
