using FinanceAccountProgram.Models;
using FinanceAccountProgram.Models.AddQueryDataForm;
using FinanceAccountProgram.Models.Config;
using FinanceAccountProgram.Models.UControl;
using JINSHIN.FinanceAccounting.DB;
using FinanceAccountProgram.VModel.AddQueryDataForm;
using FinanceAccountProgram.VModel.AddQueryForm;
using FinanceAccountProgram.VModel.Conrols;
using FinanceAccountProgram.VModel.Conrols.Model;
using JINSHIN.Alayway.Frameworks.VModels.UIControl.DGridView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JINSHIN.BUSINESS.LIBARY.UIControls.GridView;
using JINSHIN.FinanceAccount.Libary.Models.Base;
using JINSHIN.BUSINESS.LIBARY.Models.UIControls;
using JINSHIN.FinanceAccount.Libary.VModels;

namespace FinanceAccountProgram.VModel
{
    public class MoneyVModel : AccBaseCtl
    {
        public DBClassCtl dbclass { get; set; }
        public Acc_VModel accmodel { get; set; }
        public DataParams dataparam { get; set; }
        public AccBookParams accparams { get; set; }
        public AddQueryEnum datatype { get; set; }
        public GridViewFinanceBase gvbase { get; set; }
        public MoneyVModel()
        {
            dbclass = new DBClassCtl();
            //dataqueryBase = new AddQueryDataBase();
            //costdatamodel = new Acc_CostDataVModel();
            accmodel = new Acc_VModel();
            accmodel.ctl03 = new JINSHINFINANCE047Ctl();
            accmodel.ctl01 = new Acc_CostDataQuery();
            datatype = AddQueryEnum.Acc_CostData;
            gvbase = new GridViewFinanceBase(datatype);
        }
        public void Init(){
            //dataqueryBase.
         

        }

        //public AccBookParams SetBookConditionData(DataGridView dgControl)
        //{
        //    AccBookParams inputdata = new AccBookParams();
        //    inputdata.data001.enable = false;
        //    inputdata.data002.enable = false;
        //    inputdata.data003.enable = false;
        //    SetGridColumns(dgControl, AddQueryEnum.JINSHINFINANCE047);
        //    return inputdata;
        //}

        public DataParams SetConditionData(DataGridView dgControl,AddQueryEnum datatype, DataParams inputdata)
        {
            accmodel.datatype = datatype;
            inputdata.data001.enable = inputdata.data001.value !=0;
            inputdata.data002.enable = inputdata.data002.value > 0;
            inputdata.data003.enable = inputdata.data003.data != "";
            inputdata.data004.enable = inputdata.data004.data != "";
            inputdata.data005.enable = inputdata.data005.data != "";
            inputdata.data006.enable = inputdata.data006.value != -1;
            inputdata.data011.enable = inputdata.data011.data != "";
            SetGridColumns(dgControl, datatype);
            return inputdata;
        }

        public void SetGridColumns(DataGridView dgControl, AddQueryEnum datatype)
        {
            List<NameValues> columns = default(List<NameValues>);
            gvbase.datatype = datatype;
            dgControl.AutoGenerateColumns = false;
            dgControl.Columns.Clear();
            switch (datatype)
            {
                case AddQueryEnum.None:
                    break;
                case AddQueryEnum.Acc_CostData:
                    {
                        CostItemMoneyGridView vagrid = new CostItemMoneyGridView();
                        columns = vagrid.columns;
                        gvbase.AutoGenerateColumns(dgControl, columns);
                    }
                    break;
                case AddQueryEnum.Invoice_Contract:
                    break;
                case AddQueryEnum.Acc_VerifyCostData:
                    break;
                case AddQueryEnum.JINSHINFINANCE047:
                    {
                        VerifyItemGVModelConfig vagrid = new VerifyItemGVModelConfig();
                        columns = vagrid.columns;
                        gvbase.AutoGenerateColumns(dgControl, columns);
                    }
                    break;
            }
            
        }
    }
}
