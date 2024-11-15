using FinanceAccountProgram.Models;
using FinanceAccountProgram.Models.UControl;
using FinanceAccountProgram.Models.UpdateForm;
using JINSHIN.FinanceAccounting.DB;
using FinanceAccountProgram.VModel.AddQueryDataForm;
using FinanceAccountProgram.VModel.Conrols;
using FinanceAccountProgram.VModel.Conrols.Model;
using FinanceAccountProgram.VModel.FormMaintain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JINSHIN.BUSINESS.LIBARY.Base;
using JINSHIN.FinanceAccount.Libary.Models.Base;
using JINSHIN.BUSINESS.LIBARY.UIControls.GridView;
using JINSHIN.FinanceAccounting.DB.VModel;
using FinanceAccountProgram.VModel.Business;

namespace FinanceAccountProgram.VModel.AddQueryForm
{
    public class Acc_VModel :JBase
    {
        public AddQueryEnum datatype { get; set; }
        public Acc_CostDataQuery ctl01 { get; set; }
        public Acc_InvoiceCostCTL ctl02 { get; set; }
        public JINSHINFINANCE047Ctl ctl03 { get; set; }
        public Acc_AssetsCtl ctl05 { get; set; }
        public Acc_Financial_IncomeCtl ctl06 { get; set; }
        public GridViewBase gvb { get; set; }
        //financial type
        public int ImportType { get; set; }
        public Acc_VModel()
        {
            gvb = new GridViewBase();
        }
        /// <summary>
        /// 不使用在帳務比對
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dgData"></param>
        /// <param name="MSelectVal"></param>
        /// <param name="ContentSelectVal"></param>
        /// <param name="data"></param>
        public void DataShow<T>(DataGridView dgData, int MSelectVal = 0, int ContentSelectVal = 0, List<T> data = null)
        {
            List<string> columnTitle = default(List<string>);
            if (datatype == AddQueryEnum.Acc_CostData)
            {
                columnTitle = new List<string>(){"序號","發票","項目","會計月","會計科目", "會計日期", "增減", "傳票", "摘要"
                ,"借/貸","銷售人統編","購買人統編","金額","狀態","加稅","檢查","檢查日期","核對","類別","明細類別","實際月","發票日期","種類","平行","建立日期"};
                if (data == null)
                {
                    ctl01.GetData(QueryFrmString.JINSHINFINANCE035, MSelectVal);
                    dgData.DataSource = ctl01.acc_orgcostitem;
                }
            }
            else if (datatype == AddQueryEnum.Invoice_Contract)
            {
                if (data == null)
                {
                    columnTitle = new List<string>(){"序號","會計科目","項目","日期","傳票",  "類別01", "類別02", "摘要"
                    ,"會計月","借/貸","金額","狀態","發票日期","發票月","發票"};
                    ctl02.GetData(QueryFrmString.Invoice_contract, MSelectVal, ContentSelectVal);
                    //偶爾會出錯，加一個null
                    dgData.DataSource = null;
                    dgData.DataSource = ctl02.invoice_contract;
                }
               
                else
                    columnTitle = new List<string>(){"序號","會計科目","項目","日期","傳票",  "類別01", "類別02", "摘要"
                    ,"會計月","借/貸","金額","狀態","發票日期","發票月","發票","平行","驗證","發票資料"};
                    List<Invoice_ContractAddModel> items = default(List<Invoice_ContractAddModel>);
                    List<JINSHINFINANCE058> dataitem = data as List<JINSHINFINANCE058>;
                    items = ctl02.GridViewAddContractModel(dataitem);
                    dgData.DataSource = items;
                }
            
            if ((data != null) && (datatype != AddQueryEnum.Invoice_Contract))
            {
               
                dgData.DataSource = data;
            }
            gvb.SetDataColumns(dgData, columnTitle);
            dgData.Refresh();
        }

        public int DataShowFormList<T>(DataGridView dgData, AccBookParams param, int LimitCnt, List<T> data = null)
        {
            if (data == null)
            {
                if (datatype == AddQueryEnum.Acc_VerifyCostData)
                {
                    ctl01.JINSHINFINANCE035 = ctl01.GetData(QueryFrmString.JINSHINFINANCE035, param);
                    dgData.DataSource = null;
                    List<VerifyAccGridView> datalist = ctl01.JINSHINFINANCE035.Take(LimitCnt).ToList();
                    dgData.DataSource = datalist;
                    return datalist.Count;
                }
            }
            return 0;
        }

        public int DataShow<T>(DataGridView dgData, AccBookParams param, int LimitCnt, List<T> data = null)
        {
            if (data == null)
            {
                if (datatype == AddQueryEnum.Acc_VerifyCostData)
                {
                    ctl01.JINSHINFINANCE035 = ctl01.GetData(QueryFrmString.JINSHINFINANCE035, param);
                    dgData.DataSource = null;
                    List<VerifyAccGridView> datalist = ctl01.JINSHINFINANCE035.Take(LimitCnt).ToList();
                    dgData.DataSource = datalist;                                
                    return datalist.Count;
                }
            }
            return 0;
        }

        public void DataShow<T>(DataGridView dgData, DataParams param, int ufe02)
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities accbook = content.GetEntity())
                {
                    ctl03.GetStorageData(accbook, ufe02, param);
                    dgData.DataSource = ctl03.acc_CostItmes.ToList();
                }
            }
        }

        /// <summary>
        /// the lastenew frmdatamaintain
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dgData"></param>
        /// <param name="param"></param>
        /// <param name="data"></param>
        public void DataShow<T>(DataGridView dgData, DataParams param, List<T> data = null)
        {
            if (data == null)
            {
                //用於帳務比對
                if (datatype == AddQueryEnum.JINSHINFINANCE047)
                {
                    using (AccountEntityDB content = new AccountEntityDB())
                    {
                        using (AccountEntities accbook = content.GetEntity())
                        {
                            ctl03.GetStorageData(accbook, AddQueryEnum.JINSHINFINANCE047, param);
                            dgData.DataSource = ctl03.acc_VerifyItmes;
                        }
                    }
                }
                //用於成本比對-帳務分析
                else if (datatype == AddQueryEnum.Acc_CostData)
                {
                    using (AccountEntityDB content = new AccountEntityDB())
                    {
                        using (AccountEntities accbook = content.GetEntity())
                        {
                            ctl03.GetStorageData(accbook, AddQueryEnum.Acc_CostData, param);
                            dgData.DataSource = ctl03.acc_CostItmes;
                        }
                    }
                }
                else if (ImportType == ImportQueryClass.Assets)
                {
                    using (AccountEntityDB content = new AccountEntityDB())
                    {
                        using (AccountEntities accbook = content.GetEntity())
                        {

                            ctl05.GetStorageData(accbook, param, ImportQueryClass.Assets);
                            dgData.DataSource = null;
                            dgData.DataSource = ctl05.acc_AssetsItems;
                        }
                    }
                }
                else if (ImportType == ImportQueryClass.Financial_Income)
                {
                    using (AccountEntityDB content = new AccountEntityDB())
                    {
                        using (AccountEntities accbook = content.GetEntity())
                        {
                            ctl06.GetStorageData(accbook, param, ImportQueryClass.Financial_Income);
                            //偶爾會出錯，加一個null
                            dgData.DataSource = null;
                            dgData.DataSource = ctl06.Financial_Incomes;
                        }
                    }
                }
                else if (ImportType == ImportQueryClass.Financial_Income)
                {
                    using (AccountEntityDB content = new AccountEntityDB())
                    {
                        using (AccountEntities accbook = content.GetEntity())
                        {
                            ctl06.GetStorageData(accbook, param, ImportQueryClass.Financial_Income);
                            //偶爾會出錯，加一個null
                            dgData.DataSource = null;
                            dgData.DataSource = ctl06.Financial_Incomes;
                        }
                    }
                }
                else if (datatype == AddQueryEnum.verifyImport)
                {
                    using (AccountEntityDB content = new AccountEntityDB())
                    {
                        using (AccountEntities accbook = content.GetEntity())
                        {
                            ctl03.GetStorageData(accbook, AddQueryEnum.verifyImport, param);
                            //偶爾會出錯，加一個null
                            dgData.DataSource = null;
                            ctl03.acc_VerifyItmes = ctl03.acc_VerifyItmes.OrderBy(v => v.Acc_ID).ThenBy(v => v.Acc_Date).ToList();
                            int sn = 1;
                            foreach (var item in ctl03.acc_VerifyItmes)
                            {
                                item.No= sn;
                                sn++;
                            }
                            dgData.DataSource = ctl03.acc_VerifyItmes;
                        }
                    }
                }
          
            }
        }
    }
}
