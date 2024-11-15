using FinanceAccountProgram.Models.Config;
using FinanceAccountProgram.VModel.Business;
using FinanceAccountProgram.VModel.Conrols.GridView;
using JINSHIN.BUSINESS.LIBARY.Models.UIControls;
using JINSHIN.BUSINESS.LIBARY.UIControls.GridView;
using JINSHIN.FinanceAccount.Libary.Config;
using JINSHIN.FinanceAccount.Libary.Models.Financial;
using JINSHIN.FinanceAccount.Libary.VModels.AccControl;
using JINSHIN.FinanceAccounting.DB;
using JINSHIN.FinanceAccounting.DB.VModel;
using NLog.LayoutRenderers;
using OpenCvSharp.XFeatures2D;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JINSHIN.Finance.AccountSystem.FrmControl.DataForm
{
    public partial class FrmDataTotalSum : Form
    {
        public List<JINSHINFINANCE035> jin35_list { get; set; }
        public PathModel pathmodel { get; set; }
        public FrmDataTotalSum()
        {
            InitializeComponent();
            jin35_list = new List<JINSHINFINANCE035>();
            pathmodel = new PathModel();
        }

        private void FrmDataTotalSum_Shown(object sender, EventArgs e)
        {
            txtYear.Text = AccountingReso.yearnow.ToString();
            Query35("", "",txtYear.Text);
            SysRescControlVModel.SetFixedWindow(this);
        }

        private byte? ConvertDateType(byte? val)
        {
            if (val == 1)
                return 2;
            else if (val == 2)
                return 1;
            return 0;
        }

        public bool CheckData(string year)
        {
            if (year == "")
            {
                MessageBox.Show("請輸入年度!");
                return true;
            }
            return false;
        }
        private void Query35(string name, string accid,string year)
        {
            if (year == "")
            {
                return;
            }
            int datayear = Convert.ToInt32(year);

            List<JINSHINFINANCE035> jin35 = default(List<JINSHINFINANCE035>);
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entities = content.GetEntity())
                {
                    jin35 = entities.JINSHINFINANCE035.Where(v => v.Cost_Date.Value.Year == datayear
                    && (v.Acc_Desc.IndexOf(name) != -1  || name == "") && (v.Acc_ID.IndexOf(accid) != -1 || accid == "")
                    ).OrderBy(i => i.Acc_ID).ToList();
                    
                    var groupdata = jin35.GroupBy(v => v.Acc_ID).OrderBy(v=>v.FirstOrDefault().Acc_ID).ToList();
                    FunctionControl func = new FunctionControl();
                   
                    jin35_list.Clear();
                    foreach (var item in groupdata)
                    {
                        JINSHINFINANCE035 j35 = new JINSHINFINANCE035();
                        func.ClassCopyTo<JINSHINFINANCE035, JINSHINFINANCE035>(item.FirstOrDefault(), j35);
                        decimal total = ComputeData( item.ToList(), j35.Acc_ID);
                        j35.Amount = total;
                        jin35_list.Add(j35);
                    }
                    Orderby(jin35_list);
                    AccAccountsGridView accountsgridview = new AccAccountsGridView();
                    dgData.DataSource = jin35_list;
                    accountsgridview.SetAccConfirmGridColumns(dgData);
                }
                int cnt = jin35.Count;
                lblmoney.Text = cnt.ToString();
                if (cnt == 0)
                {
                    lblNoData01.Visible = true;
                }
                else
                {
                    lblNoData01.Visible = false;
                }
            }
        }

        private List<JINSHINFINANCE035> GetAccountData(List<JINSHINFINANCE035> datalist)
        {
            using (FinancialRptVModel financial = new FinancialRptVModel())
            {
                return datalist = financial.CheckVerialOK(datalist);
            }
        }

        private decimal ComputeData(List<JINSHINFINANCE035> item, string Acc_ID)
        {
            byte? fdatatype = 0;
            using (FinancialAccidsModel model = new FinancialAccidsModel())
            {
                fdatatype = model.GetDataType(Acc_ID);
            }
            List<JINSHINFINANCE035> datalist = GetAccountData(item);
            List<JINSHINFINANCE035> data01 = datalist.Where(v => v.DataType == 1).ToList();
            List<JINSHINFINANCE035> data02 = datalist.Where(v => v.DataType == 2).ToList();
            decimal val01 = 0;
            if (data01.Count > 0)
            {
                val01 = data01.Sum(v => v.Amount).Value;
            }
            decimal val02 = 0;
            if (data02.Count > 0)
            {
                val02 = data02.Sum(v => v.Amount).Value;
            }
            byte? datatype = ConvertDateType(fdatatype);
            decimal total = 0;
            if (datatype == 1)
            {
                total = val01 - val02;
            }
            else
            {
                total = val02 - val01;
            }
            return total;           
        }

        private void btnMQuery_Click(object sender, EventArgs e)
        {
            if (CheckData(txtYear.Text))
                return;
            Query35(txtName.Text, txtNo.Text,txtYear.Text);
        }

        private void txtNo_KeyUp(object sender, KeyEventArgs e)
        {
            Query35(txtName.Text, txtNo.Text, txtYear.Text);
        }

        public void Orderby(List<JINSHINFINANCE035> jin35)
        {
            for (int i = 0; i < jin35.Count; i++)
            {
                jin35[i].SN = i+1;
            }
            dgData.DataSource = jin35;
        }


        private List<JINSHINFINANCE035> GetData(Func<List<JINSHINFINANCE035>> data)
        {
            return data();        
        }


        private void txtName_KeyUp(object sender, KeyEventArgs e)
        {
            Query35(txtName.Text, txtNo.Text, txtYear.Text);            
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            using (GridViewBase grid = new GridViewBase())
            {
                grid.ExportDataGridView(pathmodel.exportPath, txtYear.Text + "_TotalAccount_Data總帳", dgData);
            }
        }

        private void txtYear_KeyUp(object sender, KeyEventArgs e)
        {
            Query35(txtName.Text, txtNo.Text, txtYear.Text);
        }
    }
}
