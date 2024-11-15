using FinanceAccountProgram.Models;
using FinanceAccountProgram.Models.AddQueryDataForm;
using FinanceAccountProgram.Models.FormMaintain;
using FinanceAccountProgram.Models.UControl;
using FinanceAccountProgram.Models.UpdateForm;
using JINSHIN.Finance.AccountSystem.Resources;
using JINSHIN.FinanceAccounting.DB;

using FinanceAccountProgram.VModel.Conrols;
using FinanceAccountProgram.VModel.Conrols.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JINSHIN.BUSINESS.LIBARY.UIControls.GridView;
using JINSHIN.BUSINESS.LIBARY.Models.UIControls;
using JINSHIN.FinanceAccount.Libary.Models.Base;
using JINSHIN.FinanceAccount.Libary.Config;
using JINSHIN.FinanceAccount.Libary.VModels;
using JINSHIN.FinanceAccounting.DB.VModel;

namespace FinanceAccountProgram.VModel.AddQueryDataForm
{
    public class AddQueryDataBase : AccBaseCtl
    {
        public List<JINSHINFINANCE047> acc_VerifyItmes { get; set; }
        public List<JINSHINFINANCE035> acc_CostItmes { get; set; }        
        public List<string> Accid_desc { get; set; }
        public GridViewBase gvbase { get; set; }
        public AddQueryEnum datatype { get; set; }
        public int ImportType { get; set; }
        public DBClassCtl dbclass { get; set; }
        public List<string> specialAccds { get; set; }
        public AddQueryDataBase()
        {
            Accid_desc = new List<string>();
            specialAccds = new List<string>() {"2171","2191" };
        }
        public void SetInit()
        {
            gvbase = new GridViewFinanceBase(datatype);
            acc_VerifyItmes = new List<JINSHINFINANCE047>();
            acc_CostItmes = new List<JINSHINFINANCE035>();          
            Accid_desc = new List<string>();
        }
        public void SetInitNew()
        {
            gvbase = new GridViewFinanceBase(datatype);
        }
        public void GetStorageData(AddQueryEnum typename, DataParams paramdata)
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    switch (typename)
                    {
                        case AddQueryEnum.None:
                            break;
                        //6111 and 6120 data show
                        case AddQueryEnum.Acc_CostData:
                            {
                                acc_CostItmes.Clear();
                                List<JINSHINFINANCE035> values = new List<JINSHINFINANCE035>();
                                if (paramdata.data001.value == 1)
                                {
                                    var contents = AccCostItemConfig.GetClassData(entity.JINSHINFINANCE035.Where(o => o.Cost_Date.Value.Year == AccountingReso.yearnow).ToList());
                                    values = contents.Where(o =>
                                    (
                                    ((o.Acc_ID == "6111" || o.Acc_ID == "6120")) &&
                                    ((o.Cost_M == paramdata.data002.value) || !paramdata.data002.enable || (paramdata.data006.value == 1)) &&
                                    ((o.Acc_Desc.IndexOf(paramdata.data003.data) != -1) || !paramdata.data003.enable)
                                    ) && (o.Cost_Date.Value.Year == AccountingReso.yearnow)
                                    ).ToList();
                                }
                                else if (paramdata.data001.value == 2)
                                {
                                    var contents = AccCostItemConfig.GetClassData(entity.JINSHINFINANCE035.Where(o => o.Cost_Date.Value.Year == AccountingReso.yearnow).ToList());
                                    var data = contents.Where(o => (
                                    ((o.Acc_ID == "6111" || o.Acc_ID == "6120")) &&
                                    ((o.Cost_M == paramdata.data002.value) || !paramdata.data002.enable || (paramdata.data006.value == 1)) &&
                                    ((o.Acc_Desc.IndexOf(paramdata.data003.data) != -1) || !paramdata.data003.enable)
                                    && (o.Cost_Date.Value.Year == AccountingReso.yearnow)
                                    )
                                    ).GroupBy(o => o.Acc_No).ToList();
                                    var contetns = entity.JINSHINFINANCE035.Where(o => o.Cost_Date.Value.Year == AccountingReso.yearnow).ToList();
                                    foreach (var item in data)
                                    {
                                        values.AddRange(contetns.Where(o => o.Acc_No == item.First().Acc_No &&
                                        ((o.Acc_ID.IndexOf(paramdata.data005.data) != -1) || !paramdata.data005.enable)
                                        ));
                                    }
                                }
                                if (values.Count > 0)
                                {
                                    if (Accid_desc.Count > 0)
                                    {
                                        foreach (var item in Accid_desc)
                                        {
                                            acc_CostItmes.AddRange(values.Where(o => o.Acc_Desc.IndexOf(item) != -1));
                                        }
                                        acc_CostItmes = acc_CostItmes.OrderBy(o => o.Acc_No).ThenBy(o => o.DataType).ToList();
                                    }
                                }

                            }
                            break;
                        case AddQueryEnum.Invoice_Contract:
                            break;
                        case AddQueryEnum.Acc_VerifyCostData:
                            break;
                        case AddQueryEnum.JINSHINFINANCE047:
                            {
                                acc_VerifyItmes.Clear();
                                acc_VerifyItmes = entity.JINSHINFINANCE047.Where(o => (
                                ((o.Verify_Month == paramdata.data002.value) || !paramdata.data002.enable || (paramdata.data006.value == 1)) &&
                                ((o.Descrip.IndexOf(paramdata.data011.data) != -1) || !paramdata.data011.enable) &&
                                 ((o.Acc_ID.IndexOf(paramdata.data004.data) != -1) || !paramdata.data004.enable)
                                && (o.Acc_Date.Value.Year == AccountingReso.yearnow)
                                 )).ToList();

                                var temp = acc_VerifyItmes.GroupBy(o => new { o.Descrip }).ToList();
                                List<JINSHINFINANCE047> data01 = new List<JINSHINFINANCE047>();
                                foreach (var item in temp)
                                {
                                    data01.Add(item.First());
                                }
                                List<JINSHINFINANCE033> data05 = entity.JINSHINFINANCE033.ToList();
                                //var data02 = (from d1 in data01
                                //              join d2 in data05
                                //              on new { d1.Acc_ID, desc = d1.Descrip }
                                //              equals new { d2.Acc_ID, desc = d2.Desc02 }
                                //              select d2.Desc01).ToList(); //有bug in 利息收入
                                //List<string> data02 = new List<string>();
                                //foreach (var item in data05)
                                //{
                                //    foreach (var i in data01)
                                //    {
                                //        if ((i.Acc_ID == item.Acc_ID) &&(i.Descrip == item.Desc02))
                                //            data02.Add(item.Desc01);
                                //    }                             
                                //}
                                var data02 = data01.Join(entity.JINSHINFINANCE033.ToList(), o => new { ac_id = o.Acc_ID, desc = o.Descrip.Trim() }, i => new { ac_id = i.Acc_ID, desc = i.Desc02.Trim() },
                                    (o, i) => new { i.Desc01 }).ToList();
                                Accid_desc.Clear();
                                data02.ForEach(o => Accid_desc.Add(o.Desc01));
                                acc_VerifyItmes = acc_VerifyItmes.OrderBy(o => o.Descrip).ThenBy(i => i.Verify_Month).ThenBy(c => c.EmpName).ToList();
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="typename"></param>
        /// <param name="paramdata"></param>
        /// <returns></returns>
        public List<JINSHINFINANCE047> GetStorageData(AccountEntities entity, string typename, DataParams paramdata)
        {
            List<JINSHINFINANCE047> rs = entity.JINSHINFINANCE047
                                         .Where(o=>o.Acc_Date.Value.Year == AccountingReso.yearnow).ToList();
            return rs;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="typename"></param>
        /// <param name="paramdata"></param>
        public void GetStorageData(AccountEntities entity, int typename, DataParams paramdata)
        {
            acc_CostItmes.Clear();
            List<JINSHINFINANCE035> values = new List<JINSHINFINANCE035>();
            List<JINSHINFINANCE035> ctl = new List<JINSHINFINANCE035>();
            try
            {                
                List<string> accids = paramdata.data013.data.Split(',').ToList();
                foreach (var item in accids)
                {
                    var contents = AccCostItemConfig.GetClassData(entity.JINSHINFINANCE035.Where(o=>o.Cost_Date.Value.Year == AccountingReso.yearnow).ToList());
                    var costitem = contents.Where(o =>
                     ((o.Acc_ID == item) || !paramdata.data005.enable) &&
                     ((o.Acc_Desc.ToUpper().IndexOf(paramdata.data003.data.ToUpper()) != -1) || !paramdata.data003.enable)
                     && (o.Cost_Check != true)
                     ).ToList();
                    ctl.AddRange(costitem);
                }
                var data = ctl.GroupBy(o => o.Acc_No).ToList();

                var contetns = AccCostItemConfig.GetClassData(entity.JINSHINFINANCE035.Where(o => o.Cost_Date.Value.Year == AccountingReso.yearnow).ToList());
                foreach (var item in data)
                {
                    values.AddRange(contetns.Where(o => o.Acc_No == item.First().Acc_No 
                    ));
                }
                var query = values.GroupBy(o => o.Acc_No).ToList();
                List<JINSHINFINANCE035> vals = default(List<JINSHINFINANCE035>);
                bool checkresult = false;
                checkresult = specialAccds.Where(o => o == paramdata.data005.data).Count() > 0;
                if (values.Count > 0)
                {
                    if (paramdata.data011.enable)
                    {
                        if (typename == 0)
                        {
                            if (Accid_desc.Count > 0)
                            {
                                foreach (var item in Accid_desc)
                                {
                                    foreach (var p in query)
                                    {
                                    
                                        if (p.Where(o => o.Acc_Desc.ToUpper().IndexOf(item.ToUpper()) != -1).Count() > 0) 
                                        {
                                            vals = contetns.Where(o => o.Acc_No == p.First().Acc_No ).ToList();
                                            if ((vals.Where(o => o.Cost_Check == null || o.Cost_Check == false).Count() > 0) || checkresult == false)
                                                acc_CostItmes.AddRange(vals);
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            foreach (var p in query)
                            {
                                vals = contetns.Where(o => o.Acc_No == p.First().Acc_No ).ToList();
                                if ((vals.Where(o => o.Cost_Check == null || o.Cost_Check == false).Count() > 0) || checkresult == false)
                                    acc_CostItmes.AddRange(vals);
                            }
                        }
                    }
                    else
                    {
                        foreach (var p in query)
                        {
                            vals = contetns.Where(o => o.Acc_No == p.First().Acc_No ).ToList();
                            if ((vals.Where(o => o.Cost_Check == null || o.Cost_Check == false).Count() > 0) || checkresult == false)
                                acc_CostItmes.AddRange(vals);
                        }
                    }
                    //bool checkresult = false;
                    //checkresult = specialAccds.Where(o => o == paramdata.data005.data).Count() > 0;
                    //if (checkresult)
                    //    acc_CostItmes = acc_CostItmes.Where(o => o.Cost_Check == false || o.Cost_Check == null).ToList();
                    acc_CostItmes = acc_CostItmes.OrderBy(o => o.Acc_No).ThenBy(o => o.DataType).ToList();
                }
            }
            finally
            {
                ctl.Clear();
            }
        }
       

        public void GetStorageData(AccountEntities entity, AddQueryEnum typename, DataParams paramdata)
        {
            switch (typename)
            {
                case AddQueryEnum.None:
                    break;

                //data001
                case AddQueryEnum.Acc_CostData:
                    {
                        acc_CostItmes.Clear();
                        List<JINSHINFINANCE035> values = new List<JINSHINFINANCE035>();
                        var contents = AccCostItemConfig.GetClassData(entity.JINSHINFINANCE035.Where(o => o.Cost_Date.Value.Year == paramdata.year).ToList());
                        if (paramdata.data001.value == 1)
                        {
                            values = contents.Where(o =>
                            (
                            ((o.Acc_ID == "6111" || o.Acc_ID == "6120")) &&
                            ((o.Cost_M == paramdata.data002.value) || !paramdata.data002.enable || (paramdata.data006.value == 1)) &&
                            ((o.Acc_Desc.IndexOf(paramdata.data003.data) != -1) || !paramdata.data003.enable)
                            )).ToList();
                        }
                        else if (paramdata.data001.value == 2)
                        {

                            foreach (var item in paramdata.yiModels)
                            {
                                var val = contents.Where(o => (
                               ((o.Cost_M == item.month || o.Verify_Month == item.month)
                                || (item.month ==0)  || (paramdata.data006.value == 1)) &&
                               (o.Acc_Desc.IndexOf(item.desc) != -1) && (o.Acc_ID == item.accid)
                               && (o.Cost_Date.Value.Year == paramdata.year)
                               )).ToList();
                                foreach (var v in val)
                                {
                                    var data = values.Where(i => i.SN == v.SN).FirstOrDefault();
                                    if (data == null)
                                    {
                                        values.Add(v);
                                    }
                                }                         
                           }                      
                        }                       
                        if (values.Count > 0)
                        {
                            acc_CostItmes = values.OrderBy(o => o.Acc_No).ThenBy(o => o.DataType).ToList();
                            //if (Accid_desc.Count > 0)
                            //{
                            //    foreach (var item in Accid_desc)
                            //    {
                            //        acc_CostItmes.AddRange(values.Where(o => o.Acc_Desc.IndexOf(item) != -1));                                        
                            //    }
                            //    acc_CostItmes = acc_CostItmes.OrderBy(o => o.Acc_No).ThenBy(o => o.DataType).ToList();
                            //}                           
                        }
                    }
                    break;
                case AddQueryEnum.Acc_VerifyCostData:
                    break;
                case AddQueryEnum.JINSHINFINANCE047:
                    {
                        acc_VerifyItmes.Clear();
                        //acc_VerifyItmes = entity.JINSHINFINANCE047.Where(o => (
                        //((o.Verify_Month == paramdata.data002.value) || !paramdata.data002.enable || (paramdata.data006.value == 1)) &&
                        //((o.Descrip.IndexOf(paramdata.data011.data) != -1) || !paramdata.data011.enable)&&
                        // ((o.Acc_ID.IndexOf(paramdata.data004.data) != -1) || !paramdata.data004.enable)
                        // && (o.Acc_Date.Value.Year == paramdata.year)
                        //)
                        //).ToList();
                        foreach (var item in paramdata.yiModels)
                        {
                            try
                            {
                                var vals = entity.JINSHINFINANCE047.Where(o => (
                               ((o.Verify_Month == item.month) || paramdata.data006.value==1) &&
                               ((o.Descrip.IndexOf(item.desc) != -1) || (o.Acc_ID == item.accid))
                               && ((o.Acc_Date.Value.Year == item.year) || item.year == 0)
                               )).ToList();
                                foreach (var v in vals)
                                {
                                    var data = acc_VerifyItmes.Where(i => i.No == v.No).FirstOrDefault();
                                    if (data == null)
                                    {
                                        acc_VerifyItmes.Add(v);
                                    }
                                }
                            }
                            catch (Exception ex)
                            { 
                            
                            }
                        }

                        //var temp = acc_VerifyItmes.GroupBy(o => new {o.Descrip }).ToList();
                        //List<JINSHINFINANCE047> data01 = new List<JINSHINFINANCE047>();
                        //foreach (var item in temp)
                        //{
                        //    data01.Add(item.First());
                        //}
                        //List<JINSHINFINANCE033> data05 = entity.JINSHINFINANCE033.ToList();
                        //var data02 = (from d1 in data01
                        //             join d2 in data05
                        //             on new { acc_id = d1.Acc_ID.Trim(), desc= d1.Descrip.Trim() }
                        //             equals new {acc_id= d2.Acc_ID.Trim(), desc=d2.Desc02.Trim() }                                     
                        //             select d2.Desc01).ToList();                  
                        //Accid_desc.Clear();
                        //data02.ForEach(o => Accid_desc.Add(o));
                        acc_VerifyItmes = acc_VerifyItmes.OrderBy(o => o.Descrip).ThenBy(i => i.Verify_Month).ThenBy(c => c.EmpName).ToList();
                    }
                    break;
                case AddQueryEnum.verifyImport:
                    {
                        if (acc_VerifyItmes != null)
                            acc_VerifyItmes.Clear();
                        List<JINSHINFINANCE047> values = new List<JINSHINFINANCE047>();
                        acc_VerifyItmes = entity.JINSHINFINANCE047.Where(o => (
                      ((o.Descrip.IndexOf(paramdata.data011.data) != -1) || !paramdata.data011.enable) &&
                       ((o.Acc_ID.IndexOf(paramdata.data004.data) != -1) || !paramdata.data004.enable) && 
                       (o.Verify_Year == paramdata.year)
                      )).ToList();

                    }
                    break;
                default:
                    break;
            }
        }


        public DataParams SetConditionData(DataGridView dgControl)
        {
            DataParams inputdata = new DataParams();
            
            inputdata.data001.enable = false;
            inputdata.data002.enable = false;
            inputdata.data003.enable = false;
            dgControl.AutoGenerateColumns = false;
            dgControl.Columns.Clear();
            List<NameValues> columns = new List<NameValues>();
            switch (datatype)
            {
                case AddQueryEnum.None:
                    break;
                case AddQueryEnum.Acc_CostData:
                    break;             
                case AddQueryEnum.JINSHINFINANCE047:                        
                    {
                        VerifyItemGVModelConfig vagrid = new VerifyItemGVModelConfig();
                        columns = vagrid.columns;
                    }
                    break;
               
                default:break;
            }
            if (ImportType == ImportQueryClass.Assets)
            {
                AssetsGridViewConfig assets = new AssetsGridViewConfig();
                columns = assets.columns;
            }
            else if (ImportType == ImportQueryClass.Financial_Income)
            {
                FinanceGridViewItems financeincome = new FinanceGridViewItems();
                columns = financeincome.columns;
            }
            else if (ImportType == ImportQueryClass.Balance_Sheet)
            {
                FinanceGridViewItems BalanceItems = new FinanceGridViewItems();
                columns = BalanceItems.columns;
            }
            gvbase.AutoGenerateColumns(dgControl, columns);            
            return inputdata;
        }
    }
}
