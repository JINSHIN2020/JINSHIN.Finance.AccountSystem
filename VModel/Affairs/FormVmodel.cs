﻿
using FinanceAccountProgram.Models;
using FinanceAccountProgram.Models.Config;
using FinanceAccountProgram.Models.UControl;
using FinanceAccountProgram.Models.UpdateForm;
using JINSHIN.Finance.AccountSystem.Resources;
using JINSHIN.FinanceAccounting.DB;
using FinanceAccountProgram.VModel.AddQueryDataForm;
using FinanceAccountProgram.VModel.AddQueryForm;
using FinanceAccountProgram.VModel.Conrols;
using FinanceAccountProgram.VModel.Conrols.Model;
using FinanceAccountProgram.VModel.Conrols.VModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JINSHIN.BUSINESS.LIBARY.Models.UIControls;
using JINSHIN.BUSINESS.LIBARY.UIControls.GridView;
using JINSHIN.BUSINESS.LIBARY.Base;
using JINSHIN.FinanceAccount.Libary.Models.Base;
using JINSHIN.BUSINESS.LIBARY.Models;
using JINSHIN.FinanceAccount.Libary.Config;
using JINSHIN.FinanceAccounting.DB.VModel;

namespace FinanceAccountProgram.VModel.Affairs
{
    public class FormVmodel :JBase
    {
        //public affairvmodelctl vmodel { get; set; }
        public List<VarClass> key_columns { get; set; }
        public List<VarClass> sort_columns { get; set; }
        public List<VarClass> Data = new List<VarClass>();
        private DataGridView Dg_Control { get; set; }
        public VerifyAccGridViewVModel verifyAccVmodel { get; set; }
        public FormVmodel(DataGridView dgControl)
        {
            Dg_Control = dgControl;
            verifyAccVmodel = new VerifyAccGridViewVModel();
            key_columns = new JINSHINFINANCE035Cols().key_columns;
            InitColumnConfig();
            UpdateSalaryCols ctl = new UpdateSalaryCols();
            key_columns = ctl.key_columns;
            sort_columns = ctl.sort_columns;
            //vmodel = new affairvmodelctl();
        }

        public FormVmodel()
        {            
            verifyAccVmodel = new VerifyAccGridViewVModel();
            key_columns = new JINSHINFINANCE035Cols().key_columns;
            InitColumnConfig();
            UpdateSalaryCols ctl = new UpdateSalaryCols();
            key_columns = ctl.key_columns;
            sort_columns = ctl.sort_columns;
            //vmodel = affvmodel;
        }
        private object GetCellVal(DataGridView dg, int i, int j, string controltype)
        {
            return dg.Rows[i].Cells[j].Value;
        }
        private JINSHINFINANCE035 GetCostItemVal(List<JINSHINFINANCE035> data, int data01, int data02, string data03)
        {
            return data.Where(o => o.SN == data01 && o.Item == data02 && o.Acc_ID == data03).FirstOrDefault();
        }

        public JINSHINFINANCE035 GetItemFromValues(UpdateFormEnum01 datatype, List<JINSHINFINANCE035> data, DataGridView dgControl, int idx)
        {
            switch (datatype)
            {
                case UpdateFormEnum01.SalaryData:
                    return GetCostItemVal(data,
                        Convert.ToInt32(dgControl.Rows[idx].Cells[key_columns[0].value01].Value),
                        Convert.ToInt32(dgControl.Rows[idx].Cells[key_columns[1].value01].Value),
                        dgControl.Rows[idx].Cells[key_columns[2].value01].Value.ToString());
            }
            return default(JINSHINFINANCE035);
        }


        public JINSHINFINANCE035 GetItemFromValues(List<JINSHINFINANCE035> data, DataGridView dgControl, int idx)
        {
            return GetCostItemVal(data,
                Convert.ToInt32(dgControl.Rows[idx].Cells[key_columns[0].value01].Value),
                Convert.ToInt32(dgControl.Rows[idx].Cells[key_columns[2].value01].Value),
                dgControl.Rows[idx].Cells[key_columns[1].value01].Value.ToString());
        }

        public DataParams SetConditionData(DataGridView dg)
        {
            DataParams inputdata = new DataParams();
            dg.AutoGenerateColumns = false;
            dg.Columns.Clear();
            return inputdata;
        }

        public List<JINSHINFINANCE035> GetCostModifyItems(AccountEntities entity, DataParams params01, DataGridView dg)
        {
            affairvmodelctl affvmodel = new affairvmodelctl();
            affvmodel.GetVerifyItems(params01);
            affvmodel.GetStorageData(entity, params01,true);
            return affvmodel.acc_CostItmes;
        }

        public void GridViewUpdateData(affairvmodelctl affvmodel, DataGridView dg,  List<GridViewOperation> operations, DataParams inputdata)
        {
            try
            {
                using (AccountEntityDB content = new AccountEntityDB())
                {
                    using (AccountEntities entity = content.GetEntity())
                    {
                        FunctionControl fcontrol = new FunctionControl();
                        List<NameValues> values = new List<NameValues>();
                        var data = operations.GroupBy(o => o.rowidx);
                        List<JINSHINFINANCE035> contents = GetCostModifyItems(entity, inputdata, dg);
                        FormVmodel vmodel = new FormVmodel();
                        foreach (var item in data)
                        {
                            var im = item.FirstOrDefault();
                            if (im != null)
                            {
                                JINSHINFINANCE035 val = vmodel.GetItemFromValues(UpdateFormEnum01.SalaryData, contents, dg, im.rowidx);
                                SalaryGridView ctl = new SalaryGridView();
                                foreach (var i in item)
                                {
                                    values.Add(new NameValues()
                                    {
                                        valuetype = NameValType.dbvalue,
                                        name = dg.Columns[i.colidx].DataPropertyName,
                                        dbvalue = dg.Rows[i.rowidx].Cells[i.colidx].Value
                                    });
                                }
                                fcontrol.SetClassTypeObj<SalaryGridView>(ctl, values);
                                vmodel.SetVerifyCostItem(fcontrol, val, ctl, values);
                                val.Is_Update = true;
                                entity.SaveChanges();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string str = ex.ToString();
            }

            finally
            {
                operations.Clear();
            }
        }

        public void UpdateData()
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    Dg_Control.EndEdit();
                    List<JINSHINFINANCE035> values = entity.JINSHINFINANCE035.Where(o => o.Cost_Date.Value.Year == AccountingReso.yearnow).ToList();
                    for (int i = 0; i < Dg_Control.Rows.Count; i++)
                    {
                        for (int j = 0; j < verifyAccVmodel.config_columns.Count; j++)
                        {
                            JINSHINFINANCE035 val = GetCostItemVal(values,
                            Convert.ToInt32(Dg_Control.Rows[i].Cells[key_columns[0].value01].Value),
                            Convert.ToInt32(Dg_Control.Rows[i].Cells[key_columns[2].value01].Value),
                            Dg_Control.Rows[i].Cells[key_columns[1].value01].Value.ToString());
                            switch (verifyAccVmodel.config_columns[j].value02)
                            {
                                case "Cost_Class":
                                    {
                                        val.Rec_Type = Convert.ToInt32(GetCellVal(Dg_Control, i, verifyAccVmodel.config_columns[j].value01, verifyAccVmodel.config_columns[j].value02));
                                    }
                                    break;
                                case "Cost_Detail":
                                    {
                                        val.Cost_Class = Convert.ToInt32(GetCellVal(Dg_Control, i, verifyAccVmodel.config_columns[j].value01, verifyAccVmodel.config_columns[j].value02));
                                    }
                                    break;
                                case "Rec_Type":
                                    {
                                        val.Rec_Type = Convert.ToInt32(GetCellVal(Dg_Control, i, verifyAccVmodel.config_columns[j].value01, verifyAccVmodel.config_columns[j].value02));
                                    }
                                    break;
                                case "HasTax":
                                    {
                                        val.Cost_Compare = Convert.ToBoolean(GetCellVal(Dg_Control, i, verifyAccVmodel.config_columns[j].value01, verifyAccVmodel.config_columns[j].value02));
                                    }
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                    entity.SaveChanges();
                }
            }
        }

        public int Init(DBClassCtl dbclassctl, Acc_VModel Accctl, AccBookParams inputdata, int datacnt)
        {
            int ttlcnt = 0;
            try
            {
                InitColumnConfig();
                Dg_Control.AutoGenerateColumns = false;
                using (GridViewFinanceBase gvb = new GridViewFinanceBase(AddQueryEnum.Acc_CostData))
                {
                    VerifyAccGridViewVModel vagrid = new VerifyAccGridViewVModel();
                    List<NameValues> columns = vagrid.columns;
                    gvb.AutoGenerateColumns(Dg_Control, columns);
                    vagrid.Dispose();
                }
                // FormConfig.VerifyItemCnt
                ttlcnt = Accctl.DataShow<JINSHINFINANCE035>(Dg_Control, inputdata, datacnt);
                inputdata.Dispose();
                Dg_Control.Refresh();
                Dg_Control.BeginEdit(false);
            }
            catch (Exception ex)
            {
                LogControl.LogAlarm(ex.ToString(), "待處理的WindowForm調校問題");
            }
            return ttlcnt;
        }

        private void SetColumnsValueFromDB(DataGridViewRow row, VarClass vclass, object val)
        {
            if (row.Cells.Count >= vclass.value01)
                row.Cells[vclass.value01].Value = val;
        }

        private static void SetDGViewColumns(List<DataGridViewComboBoxColumn> dgvCombobox, DataGridViewCheckBoxColumn dgvcheck, List<JINSHINFINANCE034> acctypes, 
            List<JINSHINFINANCE057> invtypes)
        {
            dgvCombobox[0].DataSource = invtypes; ;
            dgvCombobox[0].DisplayMember = "Name";
            dgvCombobox[0].ValueMember = "No";
            dgvCombobox[1].DataSource = acctypes;
            dgvCombobox[1].DisplayMember = "Name";
            dgvCombobox[1].ValueMember = "No";
            // dgvCombobox.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;               
            dgvcheck.FlatStyle = FlatStyle.Standard;
        }

        public JINSHINFINANCE035 SetCostItem<T>(T val, FunctionControl fcontrol)
        {
            JINSHINFINANCE035 item = default(JINSHINFINANCE035);
            List<string> data = new List<string>();
            data.Add("sn");
            data.Add("item");
            data.Add("acc_id");
            //   fcontrol.SetClassObj<JINSHINFINANCE035, VerifyAccGridView>(data, val, ctl, namevals);
            return item;
        }

        public bool SetVerifyAccToCostItem(FunctionControl fcontrol, JINSHINFINANCE035 val, VerifyAccGridView ctl, List<NameValues> namevals)
        {
            bool result = false;
            List<string> data = new List<string>();
            data.Add("sn");
            data.Add("item");
            data.Add("acc_id");
            result = fcontrol.SetClassObj<JINSHINFINANCE035, VerifyAccGridView>(data, val, ctl, namevals);
            return result;
        }

        public bool SetVerifyCostItem(FunctionControl fcontrol, JINSHINFINANCE035 val, SalaryGridView ctl, List<NameValues> namevals)
        {
            bool result = false;
            List<string> data = new List<string>();
            data.Add("sn");
            data.Add("item");
            data.Add("acc_id");
            result = fcontrol.SetClassObj<JINSHINFINANCE035, SalaryGridView>(data, val, ctl, namevals);
            return result;
        }

        public void InitColumnConfig()
        {


        }
    }
}