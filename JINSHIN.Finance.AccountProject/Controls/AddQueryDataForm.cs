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
using JINSHIN.BUSINESS.LIBARY.UIControls.GridView;
using JINSHIN.BUSINESS.LIBARY.Resources;
using JINSHIN.FinanceAccount.Libary.Models.Base;

namespace FinanceAccountProgram.Controls
{
    /// <summary>
    /// Acc_CostDataQuery
    /// </summary>
    public partial class AddQueryDataForm : UserControl
    {
        public AddQueryEnum datatype { get; set; }
        public Acc_CostDataQuery ctl01 { get; set; }
        public Acc_InvoiceCostCTL ctl02 { get; set; }
        public List<ListBox> listboxs = new List<ListBox>();
        public string datapath05 { get; set; }
        public Acc_VModel Accctl;
        public GridViewBase gvb;
        public AddQueryDataForm()
        {
            InitializeComponent();
            dgData.Font = new System.Drawing.Font(DataControl.DataGridFont, Convert.ToInt32(DataControl.DataGridFontSize));

            Accctl = new Acc_VModel();
            for (int i = 0; i < 2; i++)
            {
                listboxs.Add(new ListBox());
            }
            gvb = new GridViewBase();
        }
        public void SetInit()
        {
            Accctl.ctl01 = ctl01;
            Accctl.ctl02 = ctl02;
            Accctl.datatype = datatype;
        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            List<string> msg = default(List<string>);
            if (MessageBox.Show("是否確認要刪除,資料可能要重建（設定資料亦是）!", "對話框", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    if (datatype == AddQueryEnum.Acc_CostData)
                    {
                        List<JINSHINFINANCE035> data = new List<JINSHINFINANCE035>();
                        msg = ctl01.SaveData(data, AddQueryAutoDelete.IsCostDataQueryDelete);
                        Accctl.DataShow(dgData,0,0, data);
                        //   gvb.SetDataColumns(dgData);
                    }
                    else if (datatype == AddQueryEnum.Invoice_Contract)
                    {
                        List<JINSHINFINANCE058> data = new List<JINSHINFINANCE058>();
                        msg = ctl02.SaveData(data, datapath05, AddQueryAutoDelete.IsInvoiceContractDelete);
                        Accctl.DataShow(dgData,0,0, data);
                        //   gvb.SetDataColumns(dgData);
                    }
                    lblCnt.Text = msg[0];
                }
                catch (Exception ex)
                {
                    string str = ex.ToString();
                }
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (datatype == AddQueryEnum.Acc_CostData)
            {
                Accctl.DataShow<JINSHINFINANCE035>(dgData, Convert.ToInt32(listMaster.SelectedValue));
            }
            else if (datatype == AddQueryEnum.Invoice_Contract)
            {
                Accctl.DataShow<JINSHINFINANCE058>(dgData, Convert.ToInt32(listMaster.SelectedValue), 
                    Convert.ToInt32(listContents.SelectedValue), null);
            }
            lblCnt.Text = "個數:" + dgData.RowCount;
        }
     

        private void AddQueryDataForm_Load(object sender, EventArgs e)
        {
            listboxs[0] = listMaster;
            listboxs[1] = listContents;
        }
    }
}
