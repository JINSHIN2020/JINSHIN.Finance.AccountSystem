using FinanceAccountProgram.Models.Config;
using FinanceAccountProgram.Models.UControl;
using FinanceAccountProgram.VModel;
using FinanceAccountProgram.VModel.AddQueryForm;
using FinanceAccountProgram.VModel.Business;
using FinanceAccountProgram.VModel.Conrols.ManageForm;
using FinanceAccountProgram.VModel.Conrols.QueryModel;
using FinanceAccountProgram.VModel.Money;
using JINSHIN.BUSINESS.LIBARY.Resources;
using JINSHIN.BUSINESS.LIBARY.UIControls.GridView;
using JINSHIN.FinanceAccount.Libary.Models.Base;
using JINSHIN.FinanceAccount.Libary.VModels.AccControl;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace FinanceAccountProgram.FrmControl
{
    public partial class FrmEntryVerify : Form
    {
        GridViewQueryVModel Acc_Confirm_querymodel = new GridViewQueryVModel();
        public PathModel pathmodel { get; set; }
        public MoneyVModel QueryAccmodel { get; set; }
        public List<AccDataModel> content { get; set; }
        public FrmEntryVerify()
        {
            InitializeComponent();
            content = new List<AccDataModel>();
            using (FormControlVModel ctlmodel = new FormControlVModel())
            {
                ctlmodel.ControlResolution(this);
            }
            QueryAccmodel = new MoneyVModel();
            pathmodel = new PathModel();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            using (MoneyVerifyClass model = new MoneyVerifyClass())
            {
                model.CheckVerify(Acc_Confirm_querymodel.ctl01.JINSHINFINANCE035);
                Acc_Confirm_BindingList(lstVerifyAccds, chConfirmAll);
                dgControl.DataSource = null;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            using (MoneyVerifyClass model = new MoneyVerifyClass())
            {
                model.CancelVerify(Acc_Confirm_querymodel.ctl01.JINSHINFINANCE035);
                Acc_Confirm_BindingList(lstVerifyAccds, chConfirmAll);
                dgControl.DataSource = null;
            }
        }

        private void btnConfirmQuery_Click(object sender, EventArgs e)
        {
            QueryData();
            lblTitle01.Text = lstVerifyAccds.Text;
        }

        private void QueryData()
        {
            DataParams params01 = new DataParams();
            params01.ClearData();
            string val = "";
            if (lstVerifyAccds.SelectedValue != null)
            {
                val = lstVerifyAccds.SelectedValue.ToString();
            }
            params01.data004.data = val;
            params01.data005.data = val;
            Acc_Confirm_querymodel.AccConfirm_SetConfigVerifyAccds(params01);
            if (Acc_Confirm_querymodel.ctl01.JINSHINFINANCE035 != null)
                Acc_Confirm_querymodel.ctl01.JINSHINFINANCE035.Clear();
            if (QueryAccmodel.accmodel.ctl03.acc_VerifyItmes != null)
                QueryAccmodel.accmodel.ctl03.acc_VerifyItmes.Clear();

            QueryAccmodel.accmodel.ctl03.SetInit();
            Acc_Confirm_querymodel.SetAccConfirmGridColumns(dgControl);

            QueryAccmodel.accmodel.ctl03.GetStorageData(AddQueryEnum.JINSHINFINANCE047, params01);

            Acc_Confirm_querymodel.ctl01.JINSHINFINANCE035 =
                Acc_Confirm_querymodel.ctl01.GetData(QueryFrmString.JINSHINFINANCE035, params01,
                chConfirmAll.Checked);

            dgControl.DataSource = null;
            dgControl.DataSource = Acc_Confirm_querymodel.ctl01.JINSHINFINANCE035;
        }

        private void btnAccExport_Click(object sender, EventArgs e)
        {
            using (GridViewBase grid = new GridViewBase())
            {
                grid.ExportDataGridView(pathmodel.exportPath, "Acc_Confirm", dgControl);
            }
        }

        private void btnAnalyzeAccs_Click(object sender, EventArgs e)
        {
            string val = "";
            if (lstVerifyAccds.SelectedValue != null)
            {
                val = lstVerifyAccds.SelectedValue.ToString();
            }
            using (BusinessCtl businessctl = new BusinessCtl())
            {
                businessctl.VerifyInvoiceAndAmount(Acc_Confirm_querymodel.ctl01.acc_orgcostitem, dgControl, lstAccConfirmMsg, val);
            }
        }

        private void chConfirmAll_CheckedChanged(object sender, EventArgs e)
        {
           // CheckBox ctl = sender as CheckBox;
            Acc_Confirm_BindingList(lstVerifyAccds, chConfirmAll);
            dgControl.DataSource = null;
        }
        private void Acc_Confirm_BindingList(ListBox lstVerifyAccds, CheckBox chConfirmAll)
        {
            BusinessCtl buinessctl = new BusinessCtl();
            List<IGrouping<string, AccDataModel>> datag = buinessctl.GetAccVerifysInfo();
            string nameval = "";
            int ttlcnt = 0, failcnt = 0, passcnt = 0;
            List<AccDataModel> vals = new List<AccDataModel>();
            foreach (var item in datag)
            {
                if (item.FirstOrDefault().accname != null)
                    nameval = item.First().accname.AccName;
                else
                    nameval = "";
                ttlcnt = item.Count();
                failcnt = item.Where(o => o.check == false || o.check == null).Count();
                passcnt = item.Where(o => o.check == true).Count();
                if (((passcnt - ttlcnt) != 0) || chConfirmAll.Checked)
                {
                    AccDataModel amodel = new AccDataModel();
                    amodel.acc_id = item.First().acc_id;
                    amodel.datadesc = item.First().acc_id + ":" + nameval + "(" + failcnt.ToString() + ")";
                    vals.Add(amodel);
                }
            }

            if (lstVerifyAccds.SelectedValue != null)
            {
                string data = lstVerifyAccds.SelectedValue.ToString();
                //delete
                var excepts = content.Except(vals);
                var add = vals.Except(content);

                List<AccDataModel> models = new List<AccDataModel>();
                models.AddRange(content);
                foreach (var item in excepts)
                {                    
                    models.Remove(item);
                }
                foreach (var item in add)
                {
                    models.Add(item);
                }

                int idx = models.FindIndex(o=>o.acc_id == data);
                content.Clear();
                content.AddRange(models);
                idx = idx == -1 ? 0 :idx;
                lstVerifyAccds.DisplayMember = "datadesc";
                lstVerifyAccds.ValueMember = "acc_id";
                lstVerifyAccds.DataSource = null;
                lstVerifyAccds.DataSource = content;
                if (content.Count > 0)
                {
                    lstVerifyAccds.SelectedIndex = idx;
                }
            }
            else
            {              
                lstVerifyAccds.DataSource = vals;              
            }
            lstVerifyAccds.Refresh();
            lstVerifyAccds.DisplayMember = "datadesc";
            lstVerifyAccds.ValueMember = "acc_id";
            buinessctl.Dispose();
        }


        private void Load_BindingList(ListBox lstVerifyAccds, CheckBox chConfirmAll)
        {
            BusinessCtl buinessctl = new BusinessCtl();
            List<IGrouping<string, AccDataModel>> datag = buinessctl.GetAccVerifysInfo();
            string nameval = "";
            int ttlcnt = 0, failcnt = 0, passcnt = 0;
            content.Clear();
            foreach (var item in datag)
            {
                if (item.FirstOrDefault().accname != null)
                    nameval = item.First().accname.AccName;
                else
                    nameval = "";
                ttlcnt = item.Count();
                failcnt = item.Where(o => o.check == false || o.check == null).Count();
                passcnt = item.Where(o => o.check == true).Count();
                if (((passcnt - ttlcnt) != 0) || chConfirmAll.Checked)
                {
                    AccDataModel amodel = new AccDataModel();
                    amodel.acc_id = item.First().acc_id;
                    amodel.datadesc = item.First().acc_id + ":" + nameval + "(" + failcnt.ToString() + ")";
                    content.Add(amodel);
                }
            }
          
            lstVerifyAccds.DataSource = content;
            lstVerifyAccds.DisplayMember = "datadesc";
            lstVerifyAccds.ValueMember = "acc_id";
            buinessctl.Dispose();
        }

        private void FrmEntryVerify_Load(object sender, EventArgs e)
        {
            Load_BindingList(lstVerifyAccds, chConfirmAll);            
        }

        private void FrmEntryVerify_Shown(object sender, EventArgs e)
        {
            dgControl.Font = new System.Drawing.Font(DataControl.DataGridFont, 
                Convert.ToInt32(DataControl.DataGridFontSize));
            SysRescControlVModel.SetFixedWindow(this);
        }

        private void lstVerifyAccds_SelectedIndexChanged(object sender, EventArgs e)
        {            
        }

        private void dgControl_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 10)
            {
                if (e.Value != null)
                {
                    bool check = Convert.ToBoolean(e.Value);
                    if (check)
                        e.Value = "V";
                    else
                        e.Value = "";
                }
            }
            if (e.ColumnIndex == 11)
            {
                if (e.Value != null)
                {
                    string datestr = Convert.ToDateTime(e.Value).ToString("yyyy/MM/dd");
                    e.Value = datestr;
                }
            }
        }
    }
}
