using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinanceAccountProgram.Models;
using FinanceAccountProgram.VModel.AddQueryForm;
using FinanceAccountProgram.VModel.Conrols;
using JINSHIN.FinanceAccounting.DB;
using FinanceAccountProgram.Models.UControl;
using FinanceAccountProgram.VModel.AddQueryDataForm;
using FinanceAccountProgram.VModel.FormMaintain;
using JINSHIN.BUSINESS.LIBARY.Resources;
using JINSHIN.BUSINESS.LIBARY.UIControls.GridView;
using JINSHIN.FinanceAccount.Libary.Models.Base;
using FinanceAccountProgram.Models.Config;
using JINSHIN.FinanceAccounting.DB.VModel;

namespace FinanceAccountProgram.Controls
{
    /// <summary>
    /// datapath06:IsCostDataQueryDelete
    /// datapath07:IsAssetsCreateDelete
    /// datapath09:IsIncomeRptCreateDelete
    /// </summary>
    public partial class FrmDataMaintain : UserControl
    {     
        public int ImportType { get; set; }
        public List<ListBox> listboxs = new List<ListBox>();
        public List<JINSHINFINANCE047> verifyitems = new List<JINSHINFINANCE047>();
        public List<JINSHINFINANCE056> Financial_Incomes = new List<JINSHINFINANCE056>();
        public string datapath06 { get; set; }
        public string datapath07 { get; set; }
        public string datapath09 { get; set; }
        public string datapath10 { get; set; }
        public PathModel pathmodel { get; set; }
        public Acc_VModel Accctl;
        public GridViewBase gvb;
        //ctl area
        public Acc_Financial_IncomeCtl financial_income { get; set; }
        public Acc_Financial_BalanceCtl financial_balance { get; set; }
        public JINSHINFINANCE047Ctl verifyitem_ctl { get; set; }
        public Acc_AssetsCtl assets_ctl { get; set; }
        public AddQueryEnum datatype { get; set; }
        //ctl area
        public FrmDataMaintain()
        {
            InitializeComponent();
            pathmodel = new PathModel();
            dgData.Font = new System.Drawing.Font(DataControl.DataGridFont, Convert.ToInt32(DataControl.DataGridFontSize));
            Accctl = new Acc_VModel();
            Accctl.datatype = datatype;
            
            for (int i = 0; i < 2; i++)
            {
                listboxs.Add(new ListBox());
            }
            gvb = new GridViewBase();
            datapath10 = "";
        }
        public void SetInit()
        {
            if (datatype == AddQueryEnum.JINSHINFINANCE047)
            {
                verifyitem_ctl = new JINSHINFINANCE047Ctl();
                //datatype = AddQueryEnum.JINSHINFINANCE047;
                verifyitem_ctl.datatype = AddQueryEnum.JINSHINFINANCE047;
                verifyitem_ctl.SetInit();
                Accctl.ctl03 = verifyitem_ctl;
            }
            else if (ImportType == ImportQueryClass.Financial_Income)
            {
                //analyze is financial Ctl
                financial_income = new Acc_Financial_IncomeCtl();
                financial_income.ImportType = ImportQueryClass.Financial_Income;
                financial_income.SetInit();
                Accctl.ctl06 = financial_income;
            }
            else if (ImportType == ImportQueryClass.Assets)
            {
                assets_ctl = new Acc_AssetsCtl();
                assets_ctl.datatype = datatype;
                assets_ctl.ImportType = ImportQueryClass.Assets;
                assets_ctl.SetInit();
                Accctl.ctl05 = assets_ctl;
            }
            else if (ImportType == ImportQueryClass.Balance_Sheet)
            {
                //AddQueryDataBase
                financial_balance.ImportType = ImportQueryClass.Balance_Sheet;
                //give gridview columns
                financial_balance.SetInitNew();
            }
            //設定底層資訊
            Accctl.datatype = datatype;
            Accctl.ImportType = ImportType;
          
        }


        private void btnGenerate_Click(object sender, EventArgs e)
        {
            List<string> msg = default(List<string>);
            try
            {
                if (datatype == AddQueryEnum.JINSHINFINANCE047)
                {
                    List<JINSHINFINANCE047> data = new List<JINSHINFINANCE047>();
                    //msg = verifyitem_ctl.SaveData(dgData, data, datapath06, chclear.Checked
                    //    , chadd.Checked, Convert.ToInt32(txtYear.Text), chclear.Checked);
                    VerifyItemsALL();
                }else               
                if (ImportType == ImportQueryClass.Financial_Income)
                {
                    msg = financial_income.SaveData(datapath09, AddQueryAutoDelete.IsFinancial_IncomeCreateDelete);
                    Financial_IncomeItemsALL();
                }
                else if (ImportType == ImportQueryClass.Balance_Sheet)
                {
                    msg = financial_balance.SaveData(datapath10, AddQueryAutoDelete.IsFinancial_BalanceCreateDelete);
                    Financial_BalanceItemsALL();
                }
                lblCnt.Text = msg[0];
            }
            catch (Exception ex)
            {
                string str = ex.ToString();
            }
        }
        private void VerifyItemsALL()
        {            
            verifyitem_ctl.datatype = AddQueryEnum.JINSHINFINANCE047;
            verifyitem_ctl.SetInit();
            
            Accctl.datatype =AddQueryEnum.verifyImport; 
            DataParams inputdata = verifyitem_ctl.SetConditionData(dgData);
            Accctl.ctl03 = new JINSHINFINANCE047Ctl();
            
            Accctl.DataShow<JINSHINFINANCE047>(dgData, inputdata);
            inputdata.Dispose();
        }
        private void AssetsItemsALL()
        {
            DataParams inputdata = assets_ctl.SetConditionData(dgData);
            Accctl.DataShow<JINSHINFINANCE051>(dgData, inputdata);
            inputdata.Dispose();
        }

        private void Financial_IncomeItemsALL()
        {
            DataParams inputdata = financial_income.SetConditionData(dgData);
            Accctl.DataShow<JINSHINFINANCE056>(dgData, inputdata);
            inputdata.Dispose();
        }

        private void Financial_BalanceItemsALL()
        {
            DataParams inputdata = financial_balance.SetConditionData(dgData);
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    financial_balance.GetStorageData(entity, inputdata);
                    dgData.DataSource = financial_balance.Financial_Balances.ToList();
                }
            }
            inputdata.Dispose();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (datatype == AddQueryEnum.JINSHINFINANCE047 )
            {
                VerifyItemsALL();
            }
            else if (ImportType == ImportQueryClass.Assets)
            {
                AssetsItemsALL();
            }
            else if (ImportType == ImportQueryClass.Financial_Income)
            {
                Financial_IncomeItemsALL();
            }
            else if (ImportType == ImportQueryClass.Balance_Sheet)
            {
                Financial_BalanceItemsALL();
            }
            if ((ImportType == ImportQueryClass.Balance_Sheet) || (ImportType == ImportQueryClass.Financial_Income) 
                || (ImportType == ImportQueryClass.Assets) || (datatype == AddQueryEnum.JINSHINFINANCE047))
            {
                lblCnt.Text = dgData.Rows.Count.ToString();
            }
         }

        private void FrmDataMaintain_Load(object sender, EventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string path = "";
            using (GridViewBase grid = new GridViewBase())
            {
                path = "AccFinancial_Balance";
                grid.ExportDataGridView(pathmodel.exportPath, path, dgData);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
