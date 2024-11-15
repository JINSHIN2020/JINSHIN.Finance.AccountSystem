using FinanceAccountProgram.Models.Config;
using FinanceAccountProgram.VModel.Business;
using FinanceAccountProgram.VModel.Conrols.GridView;
using JINSHIN.BUSINESS.LIBARY.UIControls.FormUI;
using JINSHIN.BUSINESS.LIBARY.UIControls.GridView;
using JINSHIN.FinanceAccount.Libary.Config;
using JINSHIN.FinanceAccount.Libary.Models.Financial;
using JINSHIN.FinanceAccount.Libary.VModels.AccControl;
using JINSHIN.FinanceAccounting.DB;
using JINSHIN.FinanceAccounting.DB.VModel;
using NPOI.OpenXmlFormats.Dml;
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
    public partial class FrmDetailData : Form
    {
        public List<JINSHINFINANCE035> jin35_list { get; set; }
        public PathModel pathmodel { get; set; }
        public FrmDetailData()
        {
            InitializeComponent();
            jin35_list = new List<JINSHINFINANCE035>();
            pathmodel = new PathModel();

        }

        private void plSearch_Paint(object sender, PaintEventArgs e)
        {

        }



        private void ComputeData(List<JINSHINFINANCE035> contents)
        {           
            List<JINSHINFINANCE035> datalist = GetAccountData(contents);
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
            lblLedgerGetVal.Text = val01.ToString("###,###,###,###");
            lblLedgerLend.Text = val02.ToString("###,###,###,###");
        }

        private void btnMQuery_Click(object sender, EventArgs e)
        {
            if (CheckData(txtYear.Text))
                return;
            Query35( txtNo.Text, txtName.Text,txtYear.Text);
        }

        private List<JINSHINFINANCE035> GetAccountData(List<JINSHINFINANCE035> datalist)
        {
            using (FinancialRptVModel financial = new FinancialRptVModel())
            {
                return datalist = financial.CheckOK(datalist);
            }
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

        private void Query35(string accid,string name,string year)
        {
            if (year == "")
            {
                return;
            }
            int datayear = Convert.ToInt32(year);

            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entities = content.GetEntity())
                {
                    jin35_list.Clear();
                    jin35_list = entities.JINSHINFINANCE035.Where(v => 
                    v.Cost_Date.Value.Year == datayear
                    && (v.Acc_Desc.IndexOf(name) != -1  || name == "") 
                    && ( v.Acc_ID.IndexOf(accid) != -1 || accid == "" )
                    ).ToList();
                    jin35_list = GetAccountData(jin35_list);
                    AccAccountsGridView accountsgridview = new AccAccountsGridView();
                    accountsgridview.SetAccConfirmGridColumns(dgData);
                }
                int cnt = jin35_list.Count;
                lblmoney.Text = cnt.ToString();
                if (cnt == 0)
                {
                    lblNoData01.Visible = true;
                }
                else {
                    lblNoData01.Visible = false;
                }
            }
            Orderby(jin35_list);
        }

        private void FrmDetailData_Shown(object sender, EventArgs e)
        {
            lblNoData01.Visible = false;
            txtYear.Text = AccountingReso.yearnow.ToString();
            Query35("", "", AccountingReso.yearnow.ToString());
            SysRescControlVModel.SetFixedWindow(this);
        }

        public void Orderby(List<JINSHINFINANCE035> jin35s)
        {
            jin35s = jin35s.OrderBy(i => i.Acc_ID).ThenBy(v => v.Cost_Date).ToList();
            for (int i = 0; i < jin35s.Count; i++)
            {
                jin35s[i].SN = i+1;
            }
            dgData.DataSource = null;
            dgData.DataSource = jin35s;
            ComputeData(jin35s);
        }

        private void txtNo_KeyUp(object sender, KeyEventArgs e)
        {
            Query35(txtNo.Text, txtName.Text, txtYear.Text);          
        }

        private void txtName_KeyUp(object sender, KeyEventArgs e)
        {
            Query35(txtNo.Text, txtName.Text, txtYear.Text);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            using (GridViewBase grid = new GridViewBase())
            {
                grid.ExportDataGridView(pathmodel.exportPath, txtYear.Text + "_DetailAccount_Data明細帳", dgData);
            }
        }

        private void txtYear_KeyUp(object sender, KeyEventArgs e)
        {
          //  Query35(txtNo.Text, txtName.Text, txtYear.Text);
        }

        private void txtYear_KeyUp_1(object sender, KeyEventArgs e)
        {
            using (FormUICTL ctl = new FormUICTL())
            {
                if (!ctl.GetAllNumText(txtYear.Text))
                {
                    MessageBox.Show("你輸入了"+ txtYear.Text+",年度必須輸入數字!");
                }
            }
        }
    }
}
