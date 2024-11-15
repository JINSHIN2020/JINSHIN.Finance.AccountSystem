using FinanceAccountProgram.Models;
using FinanceAccountProgram.VModel;
using FinanceAccountProgram.VModel.AddQueryDataForm;
using FinanceAccountProgram.VModel.FormMaintain;
using JINSHIN.Finance.AccountSystem;
using JINSHIN.FinanceAccount.Libary.Models.Base;
using JINSHIN.FinanceAccount.Libary.VModels.AccControl;
using JINSHIN.RegProcess.Liary.Content.Frm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceAccountProgram
{
    public partial class ImportDataFrm : Form
    {
        public int ImportType { get; set; }
        public DBClassCtl dbclassctl { get; set; }
        private string datapath06 = @"\Data6\";
        public string data6Path = "";
        private string datapath09 = @"\Data9\";
        public string data9Path = "";
        private string datapath10 = @"\Data10\";
        public string data10Path = "";

        public string path = "";
        public ImportDataFrm()
        {
            InitializeComponent();
            SysRescControlVModel.Let1366ToMaxWindowSize(this);
        }
        public void init()
        {
          path = Environment.CurrentDirectory;
          DirectoryInfo di = new DirectoryInfo(path);
#if (DEBUG)
            data6Path = di.Parent.Parent.FullName + datapath06;
            data9Path = di.Parent.Parent.FullName + datapath09;
            data10Path = di.Parent.Parent.FullName + datapath10;
            frmDataMaintain.datapath06 = di.Parent.Parent.FullName + datapath06;
            frmDataMaintain.datapath09 = di.Parent.Parent.FullName + datapath09;
            frmDataMaintain.datapath10 = di.Parent.Parent.FullName + datapath10;
#else
            //data6Path = di.Parent.FullName + datapath06;
            //data9Path = di.Parent.FullName + datapath09;
            //data10Path = di.Parent.FullName + datapath10;
            frmDataMaintain.datapath06 = accounting.ClickPath + datapath06;
            frmDataMaintain.datapath09 = accounting.ClickPath + datapath09;
            frmDataMaintain.datapath10 = accounting.ClickPath + datapath10;
            data6Path = accounting.ClickPath + datapath06;
            data9Path = accounting.ClickPath + datapath09;
            data10Path = accounting.ClickPath + datapath10;
         #endif
            TPImportData.TabPages[0].Select();
            InitFrmDataMaintain();
        }
       
        private void InitFrmDataMaintain()
        {
            switch (ImportType)
            {
                //保留先不使用
                case ImportQueryClass.verifyitem: {
                        frmDataMaintain.datapath06 = data6Path;
                        frmDataMaintain.datatype = AddQueryEnum.JINSHINFINANCE047;
                        frmDataMaintain.Accctl.datatype = AddQueryEnum.JINSHINFINANCE047;
                        frmDataMaintain.verifyitem_ctl = new JINSHINFINANCE047Ctl();
                        frmDataMaintain.verifyitem_ctl.dbclass = dbclassctl;
                        
                    } break;
                case ImportQueryClass.verifyImports:
                    {
                        frmDataMaintain.datapath06 = data6Path;
                        frmDataMaintain.datatype = AddQueryEnum.JINSHINFINANCE047;
                        frmDataMaintain.verifyitem_ctl = new JINSHINFINANCE047Ctl();
                        frmDataMaintain.verifyitem_ctl.dbclass = dbclassctl;
                    }
                    break;
                case ImportQueryClass.Financial_Income: {
                        frmDataMaintain.datapath09 = data9Path;
                        frmDataMaintain.ImportType = ImportQueryClass.Financial_Income;
                        frmDataMaintain.financial_income = new Acc_Financial_IncomeCtl();
                        frmDataMaintain.financial_income.dbclass = dbclassctl;
                    } break;
                case ImportQueryClass.Balance_Sheet:
                    {
                        frmDataMaintain.datapath10 = data10Path;
                        frmDataMaintain.ImportType = ImportQueryClass.Balance_Sheet;
                        frmDataMaintain.financial_balance = new Acc_Financial_BalanceCtl();
                    }
                    break;               
                default:
                    break;
            }
            if ((ImportType == ImportQueryClass.verifyitem) || (
                ImportType == ImportQueryClass.Financial_Income) 
                || (ImportType == ImportQueryClass.Balance_Sheet))
            {
                frmDataMaintain.SetInit();
            }
           
        }

        private void ImportDataFrm_Load(object sender, EventArgs e)
        {
            init();
            dbclassctl = new DBClassCtl();
        }

        private void tpVerifyItem_Click(object sender, EventArgs e)
        {

        }

        private void frmDataMaintain_Load(object sender, EventArgs e)
        {

        }

        private void ImportDataFrm_Shown(object sender, EventArgs e)
        {
            SysRescControlVModel.SetFixedWindow(this);
        }
    }
}
