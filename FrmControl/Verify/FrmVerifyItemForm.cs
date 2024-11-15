using FinanceAccountProgram.Controls;
using FinanceAccountProgram.Models;
using FinanceAccountProgram.Models.Config;
using FinanceAccountProgram.Models.UControl;
using FinanceAccountProgram.VModel;
using FinanceAccountProgram.VModel.AddQueryDataForm;
using FinanceAccountProgram.VModel.AddQueryForm;
using FinanceAccountProgram.VModel.FormMaintain;
using JINSHIN.BUSINESS.LIBARY.Resources;
using JINSHIN.BUSINESS.LIBARY.UIControls.GridView;
using JINSHIN.Finance.AccountSystem;
using JINSHIN.FinanceAccount.Libary.Models.Base;
using JINSHIN.FinanceAccount.Libary.VModels.AccControl;
using JINSHIN.FinanceAccounting.DB;
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

namespace JINSHIN.Finance.AccountSystem.FrmControl.Verify
{
    public partial class FrmVerifyItemForm : Form
    {
        public int ImportType { get; set; }
        public List<ListBox> listboxs = new List<ListBox>();
        public List<JINSHINFINANCE047> verifyitems = new List<JINSHINFINANCE047>();
        public DBClassCtl dbclassctl { get; set; }
        private string datapath06 = @"\Data6\";
        public string data6Path = @"\Data6\";
        public string path { get; set; }
        public PathModel pathmodel { get; set; }
        public Acc_VModel Accctl;
        public GridViewBase gvb;
        //ctl area
        public Acc_Financial_IncomeCtl financial_income { get; set; }
        public Acc_Financial_BalanceCtl financial_balance { get; set; }
        public JINSHINFINANCE047Ctl verifyitem_ctl { get; set; }
        public Acc_AssetsCtl assets_ctl { get; set; }
        public AddQueryEnum datatype { get; set; }

        public FrmVerifyItemForm()
        {
            InitializeComponent();
            SysRescControlVModel.Let1366ToMaxWindowSize(this);

            pathmodel = new PathModel();
            dgData.Font = new System.Drawing.Font(DataControl.DataGridFont, Convert.ToInt32(DataControl.DataGridFontSize));
            Accctl = new Acc_VModel();
            Accctl.datatype = datatype;
            for (int i = 0; i < 2; i++)
            {
                listboxs.Add(new ListBox());
            }
            gvb = new GridViewBase();                 
            path = Environment.CurrentDirectory;
            DirectoryInfo di = new DirectoryInfo(path);
#if (DEBUG)
            data6Path = di.Parent.Parent.FullName + data6Path;
            datapath06 = di.Parent.Parent.FullName + data6Path;
#else
            datapath06 = accounting.ClickPath + data6Path;
            data6Path = accounting.ClickPath + data6Path;
#endif
            datatype = AddQueryEnum.JINSHINFINANCE047;
            Accctl.datatype = AddQueryEnum.JINSHINFINANCE047;
            verifyitem_ctl = new JINSHINFINANCE047Ctl();
            verifyitem_ctl.dbclass = dbclassctl;
        }



        private void FrmVerifyItemForm_Shown(object sender, EventArgs e)
        {
            int year = DateTime.Now.Year;
            txtYear.Text = year.ToString();
            if (ImportType == ImportQueryClass.verifyitem)
            {
                verifyitem_ctl = new JINSHINFINANCE047Ctl();
                verifyitem_ctl.datatype = AddQueryEnum.JINSHINFINANCE047;
                verifyitem_ctl.SetInit();
                Accctl.ctl03 = verifyitem_ctl;
                Accctl.ctl03.acc_VerifyItmes = new List<JINSHINFINANCE047>();
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
               
                List<JINSHINFINANCE047> data = new List<JINSHINFINANCE047>();
                msg = verifyitem_ctl.SaveData(dgData, data, datapath06, true
                    ,false, Convert.ToInt32(txtYear.Text));
                VerifyItemsALL();                           
                lblCnt.Text = msg[0];
            }
            catch (Exception ex)
            {
                string str = ex.ToString();
            }
        }

        private void VerifyItemsALL()
        {
            int year = 0;
            if (txtYear.Text == "")
            {
                return;
            }
            year = Convert.ToInt32(txtYear.Text);
            verifyitem_ctl.datatype = AddQueryEnum.JINSHINFINANCE047;
            verifyitem_ctl.SetInit();
            Accctl.datatype = AddQueryEnum.verifyImport;
            DataParams inputdata = verifyitem_ctl.SetConditionData(dgData);
            inputdata.year = year;
        //    Accctl.ctl03 = new JINSHINFINANCE047Ctl();
            Accctl.DataShow<JINSHINFINANCE047>(dgData, inputdata);
            inputdata.Dispose();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            VerifyItemsALL();
            lblCnt.Text = dgData.Rows.Count.ToString();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string path = "";
            using (GridViewBase grid = new GridViewBase())
            {
                path = "AccVerifyItems_List";
                grid.ExportDataGridView(pathmodel.exportPath, path, dgData);
            }
        }

        private void dgData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                if (e.Value != null)
                {
                    e.Value = Convert.ToDouble(e.Value).ToString("###,###,###,###");
                }
            }
        }
    }
}
