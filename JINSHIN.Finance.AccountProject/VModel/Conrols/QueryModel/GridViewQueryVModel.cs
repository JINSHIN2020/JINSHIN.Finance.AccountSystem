using FinanceAccountProgram.Models;
using FinanceAccountProgram.Models.DataGridViewModel;
using FinanceAccountProgram.Models.UControl;
using FinanceAccountProgram.Models.UpdateForm;
using JINSHIN.FinanceAccounting.DB;
using FinanceAccountProgram.VModel.AddQueryForm;
using FinanceAccountProgram.VModel.Conrols.Model;
using FinanceAccountProgram.VModel.Conrols.VModel;
using JINSHIN.Alayway.Frameworks.VModels.UIControl.DGridView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JINSHIN.BUSINESS.LIBARY.Base;
using JINSHIN.BUSINESS.LIBARY.UIControls.GridView;
using JINSHIN.BUSINESS.LIBARY.Models.UIControls;
using JINSHIN.FinanceAccount.Libary.Models.Base;
using JINSHIN.FinanceAccounting.DB.VModel;

namespace FinanceAccountProgram.VModel.Conrols.QueryModel
{
    public class GridViewQueryVModel :JBase
    {
        public List<ConditionClass> updateFrms_conditiondesc { get; set; }
        public Acc_VModel Accctl { get; set; }
        public AddQueryEnum datatype { get; set; }
        public Acc_CostDataQuery ctl01 { get; set; }
        public DBClassCtl dbclassctl { get; set; }
        public GridViewQueryVModel()
        {
            Accctl = new Acc_VModel();
            ctl01 = new Acc_CostDataQuery();
            dbclassctl = new DBClassCtl();
            ctl01.dbclass = dbclassctl;
            Accctl.ctl01 = ctl01;
            Accctl.datatype = datatype;
            updateFrms_conditiondesc = new List<ConditionClass>();

            List<ConditionClass> snscondition = new List<ConditionClass>();
            List<string> sns = new List<string>
            {
                "1281","6112","6116","7243",
                "7111","7141","2171","2191",
                "2171","2191","1586","6125",
                "7236","6122","1262","6134",
                "6114","6123","1266","1281","6112"
            };
            for (int i = 0; i < sns.Count; i++)
            {
                snscondition.Add(new ConditionClass() {
                     AccID_Cost = sns[i]
                });
            }
            snscondition[20].Desc_Cost = "辦公租金";
            snscondition[1].Desc_Cost = "Office365";

            //add desc01 2020 0316 to suite multi columns
            try
            {
                using (AccountEntityDB content = new AccountEntityDB())
                {
                    using (AccountEntities entity = content.GetEntity())
                    {
                        var data = entity.JINSHINFINANCE033.ToList();
                        foreach (var item in snscondition)
                        {
                            var val = data.Where(o => o.Acc_ID == item.AccID_Cost && ((o.Desc01.IndexOf(item.Desc_Cost) != -1) || (o.Desc01 == ""))).FirstOrDefault();
                            if (val != null)
                            {
                                updateFrms_conditiondesc.Add(new ConditionClass()
                                {
                                    AccID_Cost = val.Acc_ID,
                                    AccID_Real = val.Acc_ID,
                                    Desc_Cost = val.Desc01,
                                    Desc_Real = val.Desc02,
                                    MonthALL = 1,
                                    Multi_accids = val.Acc_ID
                                });
                            }
                            else
                            {
                                updateFrms_conditiondesc.Add(new ConditionClass()
                                {
                                    AccID_Cost = item.AccID_Cost,
                                    AccID_Real = item.AccID_Cost,
                                    Desc_Cost = item.Desc_Cost,
                                    Desc_Real = "",
                                    MonthALL = 1,
                                    Multi_accids = val.Acc_ID
                                });
                            }
                        }
                    }
                    ConditionClass conditionclass01 = updateFrms_conditiondesc.Where(o => o.AccID_Cost == "6112").FirstOrDefault();
                    conditionclass01.Multi_accids = "6112,5111,5152";
                    ConditionClass conditionclass02 = updateFrms_conditiondesc.Where(o => o.AccID_Cost == "6116").FirstOrDefault();
                    conditionclass02.Multi_accids = "5156,6116";
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
