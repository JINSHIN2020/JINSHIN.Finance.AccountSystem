using FinanceAccountProgram.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using FinanceAccountProgram.Models.UControl;
using JINSHIN.FinanceAccounting.DB;
using System.Windows.Forms;
using JINSHIN.Finance.AccountSystem.Resources;
using FinanceAccountProgram.VModel.AddQueryDataForm;
using System.Text;
using System.Threading.Tasks;
using FinanceAccountProgram.Models.UpdateForm;
using FinanceAccountProgram.VModel.AddQueryForm;
using FinanceAccountProgram.VModel.Conrols;
using FinanceAccountProgram.Models.DataGridViewModel;
using FinanceAccountProgram.VModel.Conrols.VModel;
using JINSHIN.BUSINESS.LIBARY.UIControls.GridView;
using JINSHIN.BUSINESS.LIBARY.Models.UIControls;
using JINSHIN.BUSINESS.LIBARY.Base;
using JINSHIN.FinanceAccount.Libary.Models.Base;
using JINSHIN.FinanceAccounting.DB.VModel;

namespace FinanceAccountProgram.VModel.Affairs
{
    public class GridViewQueryAffairs :JBase
    {
        public ConditionClass updateFrms_conditiondesc { get; set; }
        public Acc_VModel Accctl { get; set; }
        public AddQueryEnum datatype { get; set; }
        public Acc_CostDataQuery ctl01 { get; set; }
        public DBClassCtl dbclassctl { get; set; }
        public GridViewQueryAffairs(int datalink)
        {
            Accctl = new Acc_VModel();
            ctl01 = new Acc_CostDataQuery();
            dbclassctl = new DBClassCtl();
            ctl01.dbclass = dbclassctl;
            Accctl.ctl01 = ctl01;
            Accctl.datatype = datatype;

            updateFrms_conditiondesc = new ConditionClass();
            //add desc01 2020 0316 to suite multi columns
            try
            {
                using (AccountEntityDB content = new AccountEntityDB())
                {
                    using (AccountEntities entity = content.GetEntity())
                    {
                        var data = entity.JINSHINFINANCE033.Where(o => o.AffairsNo == datalink).GroupBy(o => o.AffairsNo).ToList();
                        string accids = "";
                        string descs = "";
                        foreach (var item in data)
                        {
                            accids = "";
                            foreach (var v in item)
                            {
                                accids += v.Acc_ID.ToString() + ",";
                                descs += v.Desc02.ToString() + ",";
                            }
                            accids = accids.Substring(0, accids.Length - 1);

                            updateFrms_conditiondesc = new ConditionClass()
                            {
                                AccID_Cost = item.First().Acc_ID,
                                AccID_Real = item.First().Acc_ID,
                                Desc_Cost = descs,
                                Desc_Real = item.First().Desc01,
                                MonthALL = 1,
                                Multi_accids = accids
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogControl.LogAlarm(ex.ToString(), "檢查會科設定");
            }
        }

        public void SetAccConfirmGridColumns(DataGridView dgControl)
        {
            GridViewBase gvbase = new GridViewBase();
            dgControl.AutoGenerateColumns = false;
            dgControl.Columns.Clear();
            VerifyConfirmGridViewModel vagrid = new VerifyConfirmGridViewModel();
            List<NameValues> columns = vagrid.columns;
            gvbase.AutoGenerateColumns(dgControl, columns);
            gvbase.Dispose();
            columns.Clear();
        }

        public void SetGridColumns(DataGridView dgControl)
        {
            GridViewBase gvbase = new GridViewBase();
            dgControl.AutoGenerateColumns = false;
            dgControl.Columns.Clear();
            VerifyAccGridViewVModel vagrid = new VerifyAccGridViewVModel();
            List<NameValues> columns = vagrid.columns;
            gvbase.AutoGenerateColumns(dgControl, columns);
            gvbase.Dispose();
            columns.Clear();
        }
        public void SetConfigToParameter(ConditionClass val, DataParams params01)
        {
            params01.data004.data = val.AccID_Real;
            params01.data004.enable = val.AccID_Real.Trim() != "";

            params01.data005.data = val.AccID_Cost;
            params01.data005.enable = val.AccID_Cost.Trim() != "";

            params01.data011.data = val.Desc_Real;
            params01.data011.enable = !string.IsNullOrEmpty(val.Desc_Real.Trim());

            params01.data003.data = val.Desc_Cost;
            params01.data003.enable = !string.IsNullOrEmpty(val.Desc_Cost.Trim());

            params01.data013.data = val.Multi_accids;
            params01.data013.enable = !string.IsNullOrEmpty(val.Multi_accids.Trim());

        }
        public void AccConfirm_SetConfigVerifyAccds(DataParams params01)
        {
            params01.data004.enable = params01.data004.data.Trim() != "";
            params01.data005.enable = params01.data005.data.Trim() != "";
            params01.data011.enable = !string.IsNullOrEmpty(params01.data011.data.Trim());
            params01.data003.enable = !string.IsNullOrEmpty(params01.data003.data.Trim());
        }
    }
}
