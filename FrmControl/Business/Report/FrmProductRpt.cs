using FinanceAccountProgram.Models.Business;
using FinanceAccountProgram.Models.Config;
using FinanceAccountProgram.Models.UControl;
using JINSHIN.Finance.AccountSystem.Resources;
using FinanceAccountProgram.VModel.Business;
using FinanceAccountProgram.VModel.Conrols;
using FinanceAccountProgram.VModel.Conrols.GridView;
using FinanceAccountProgram.VModel.UsrControl;
using JINSHIN.Alayway.Frameworks.VModels.UIControl.DGridView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JINSHIN.FinanceAccounting.DB;
using FinanceAccountProgram.VModel.Conrols.ManageForm;
using JINSHIN.BUSINESS.LIBARY.UIControls.GridView;
using JINSHIN.BUSINESS.LIBARY.Models.UIControls;
using JINSHIN.BUSINESS.LIBARY.Resources;
using JINSHIN.BUSINESS.LIBARY.Models.UControl.GView;
using JINSHIN.BUSINESS.LIBARY.UIControls.FormMgt.EntityVModel;
using JINSHIN.BUSINESS.LIBARY.VModel;
using JINSHIN.BUSINESS.LIBARY.Models.UControl.Frm;
using JINSHIN.FinanceAccount.Libary.Config;
using JINSHIN.FinanceAccounting.DB.VModel;
using JINSHIN.FinanceAccount.Libary.VModels.Config;
using JINSHIN.FinanceAccount.Libary.VModels.AccControl;

namespace FinanceAccountProgram.FrmControl.Business.Report
{
    public partial class FrmProductRpt : Form
    {
        public PathModel pathmodel { get; set; }
        public BaseGridCtl gridviewctl { get; set; }
        public List<NameValues> mvalues { get; set; }
        public FrmProductRpt()
        {
            InitializeComponent();
            gridviewctl = new BaseGridCtl();
            pathmodel = new PathModel();
            mvalues = new List<NameValues>();
            dgControl.Font = new System.Drawing.Font(DataControl.DataGridFont, Convert.ToInt32(DataControl.DataGridFontSize));

        }
        private void ViewDiaryProductReport()
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    var data = entity.JINSHINFINANCE044.Where(o => o.CDate.Value.Year == DateTime.Now.Year
                && o.CDate.Value.Month == DateTime.Now.Month
                && o.CDate.Value.Day == DateTime.Now.Day
                ).GroupBy(o => o.PName).Select(i => new JINSHINFINANCE044()
                {
                    No = i.First().No,
                    CDate = i.First().CDate,
                    ProClass = i.First().ProClass,
                    PName = i.First().PName,
                    Num = i.Sum(y => y.Num),
                    PPrice = i.Sum(y => y.PPrice)
                }).ToList();
                    List<string> data01 = new List<string>() { "NO", "CDATE", "PROCLASS", "PNAME", "NUM", "PPRICE" };
                    List<string> data02 = new List<string>() {
                "I01",  "DATA03", "DATA02","DATA01","D02", "D01"     };
                    EntityControl control = new EntityControl(gridviewctl);
                    List<DataModel> models = new List<DataModel>();
                    int sn = 1;
                    try
                    {
                        foreach (var item in data)
                        {
                            DataModel dmodel = new DataModel();
                            control.EntityDataClass<JINSHINFINANCE044, DataModel>(item, dmodel, data01, data02);
                            dmodel.Sn = sn;
                            models.Add(dmodel);
                            sn++;
                        }
                    }
                    catch (Exception)
                    {
                        // string str = "";
                    }
                    gridviewctl.SetGridColumns<Acc_DiaryFoods_DGItems>(dgControl, new Acc_DiaryFoods_DGItems());
                    dgControl.DataSource = models;
                }
            }

        }

        private void btnVerifyAccExport_Click(object sender, EventArgs e)
        {
            using (GridViewBase grid = new GridViewBase())
            {
                grid.ExportDataGridView(pathmodel.exportPath, "QueryProductReport", dgControl);
            }
        }

        public void SetMvaluesSearch()
        {
            mvalues.Clear();
            NameValues val01 = new NameValues();
            val01.name = "CYear";
            val01.dbvalue = txAccYear.Text == "" ? null : txAccYear.Text.Trim();
            mvalues.Add(val01);

            NameValues val02 = new NameValues();
            val02.name = "CDate";
            if (coUpdateAll.Checked)
                val02.dbvalue = null;
            else
              val02.dbvalue = lstUpdateMonths.Text.Trim() == "" ? null : lstUpdateMonths.Text.Trim();
            mvalues.Add(val02);
        }
        private void BtnQuery_Click(object sender, EventArgs e)
        {
            QueryData();
        }

        private void QueryData()
        {
            SetMvaluesSearch();
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    int mdata = 0;
                    int setupcnt = txtDataCnt.Text.Trim() == "" ? 0 : Convert.ToInt32(txtDataCnt.Text);
                    if (mvalues[0].dbvalue != null)
                        mdata = Convert.ToInt32(mvalues[1].dbvalue);
                    object dvalue = mvalues[1].dbvalue;
                    int ydata = 0;
                    ydata = Convert.ToInt32(mvalues[0].dbvalue);
                    // JINSHINFINANCE043 不必使用
                    var data = entity.JINSHINFINANCE044.Where(o => o.CDate.Value.Year == ydata
                      && (o.CDate.Value.Month == mdata || dvalue == null)
                      ).GroupBy(o => o.PName).Select(i => new OrderDetailModel()
                      {
                          No = i.FirstOrDefault().No,
                          CDate = i.FirstOrDefault().CDate,
                          ProClass = i.FirstOrDefault().ProClass,
                          PName = i.FirstOrDefault().PName,
                          Num = i.Sum(y => y.Num),
                          PPrice = i.Sum(y => y.PPrice)
                      }).ToList();

                    lblDataAllCnt.Text = data.Count.ToString();
                    data = data.Take(setupcnt).ToList();
                    BusiDataModelControl modelcontrol = new BusiDataModelControl();
                    List<DataModel> models = modelcontrol.ConvertOrderDetailToDataModel(data);
                    gridviewctl.SetGridColumns<Acc_DiaryFoods_DGItems>(dgControl, new Acc_DiaryFoods_DGItems());
                    dgControl.DataSource = models;
                    modelcontrol.Dispose();
                }
            }
        }

        private void coUpdateAll_CheckedChanged(object sender, EventArgs e)
        {
            QueryData();
        }

        private void txtDataCnt_TextChanged(object sender, EventArgs e)
        {
            using (SysSettingCtl setting = new SysSettingCtl())
            {
                if (!setting.GetNumberText(txtDataCnt.Text))
                {
                    MessageBox.Show("編碼位數一定要輸入數字!");
                }
                else
                    QueryData();
            }
        }

        private void FrmProductRpt_Load(object sender, EventArgs e)
        {
            txAccYear.Text = AccountingReso.yearnow.ToString();
            lstUpdateMonths.SelectedIndex = DateTime.Now.Month - 1;
            using (SystemControl syscontrol = new SystemControl())
            {
                CustomFrmDgn custDgn = syscontrol.GetResolution(this);
                double val = 0;
                if (custDgn.name == "1920")
                {
                    val = 1;
                }
                else {
                    val = 1.2;
                }
                syscontrol.LoadControlFrmLst(this, syscontrol.GetResolution(this).value, "lstUpdateMonths", val);// ControlModel.parpam03);
            }
        }

        private void FrmProductRpt_Shown(object sender, EventArgs e)
        {
            SysRescControlVModel.SetFixedWindow(this);
        }
    }
}
