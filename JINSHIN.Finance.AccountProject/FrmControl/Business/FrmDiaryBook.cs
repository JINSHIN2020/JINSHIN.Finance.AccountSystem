using FinanceAccountProgram.Models.Config;
using FinanceAccountProgram.Models.UControl;
using JINSHIN.Finance.AccountSystem.Resources;
using JINSHIN.FinanceAccounting.DB;
using FinanceAccountProgram.ViewFrm;
using FinanceAccountProgram.VModel;
using FinanceAccountProgram.VModel.Accounts;
using FinanceAccountProgram.VModel.Conrols.GridView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinanceAccountProgram.VModel.Conrols.ManageForm;
using JINSHIN.BUSINESS.LIBARY.Resources;
using JINSHIN.FinanceAccount.Libary.Config;
using JINSHIN.FinanceAccount.Libary.VModels;
using JINSHIN.FinanceAccounting.DB.VModel;
using JINSHIN.FinanceAccount.Libary.VModels.AccControl;

namespace FinanceAccountProgram.FrmControl
{
    public partial class FrmDiaryBook : Form
    {
        public AccAccountsGridView accountsgridview { get; set; }
      
        public FrmDiaryBook()
        {
            InitializeComponent();
            dgAccAccountsData.Font = new System.Drawing.Font(DataControl.DataGridFont, Convert.ToInt32(DataControl.DataGridFontSize));
            dgCostItemView.Font = new System.Drawing.Font(DataControl.DataGridFont, Convert.ToInt32(DataControl.DataGridFontSize));
            using (FormControlVModel ctlmodel = new FormControlVModel())
            {
                ctlmodel.ControlResolution(this);
            }
            //this.AutoScaleMode = AutoScaleMode;
            //this.AutoSize = true;
            //this.ScaleControl(new SizeF(0.2f, 0.2f), BoundsSpecified.All);
            accountsgridview = new AccAccountsGridView();
            
        }

        private void btnAccInputNew_Click(object sender, EventArgs e)
        {
            lblDiaNoValue.Text = "New";
            lblAccInputPos.Text = AccInputPosModel.NewRecord;
        }

        private void btnAccInputRecord_Click(object sender, EventArgs e)
        {
            try
            {
                if ((lblAccInputPos.Text == AccInputPosModel.NewRecord) || (lblAccInputPos.Text == AccInputPosModel.RecordStatus))
                {
                    if (lblDiaNoValue.Text == "New")
                    {
                        JINSHINFINANCE035 entries = new JINSHINFINANCE035();
                        entries.SN = dgAccAccountsData.Rows.Count + 1;
                        entries.Acc_ID = txDiaAccID.Text;
                        entries.DataType = byte.Parse(txAccDatatype.Text);
                        entries.Amount = decimal.Parse(txDiaAmount.Text);
                        if (txDiaAccNo.Text != "")
                        {
                            entries.Acc_No = txDiaAccNo.Text;
                            entries.Cost_Date = dtAccPicker.Value;
                            entries.Acc_Desc = txDiaAccDesc.Text;
                        }
                        else
                        {
                            MessageBox.Show("請先選擇日期", "對話框");
                        }
                        List<JINSHINFINANCE035> result = new List<JINSHINFINANCE035>();
                        List<JINSHINFINANCE035> contents = dgAccAccountsData.DataSource as List<JINSHINFINANCE035>;
                        if (contents != null)
                            result.AddRange(contents);
                        result.Add(entries);
                        dgAccAccountsData.DataSource = null;
                        
                        accountsgridview.SetAccConfirmGridColumns(dgAccAccountsData);
                        dgAccAccountsData.DataSource = result;
                        
                    }
                    else
                    {
                        //   int.TryParse(lblDiaNoValue.Text, out sn);
                        DataGridViewRow dgv = dgAccAccountsData.Rows[int.Parse(lblDiaNoValue.Text)];
                        dgv.Cells[1].Value = txDiaAccNo.Text;
                        dgv.Cells[2].Value = dtAccPicker.Value.ToString("yyyy/MM/dd");
                        dgv.Cells[3].Value = txDiaAccID.Text;
                        dgv.Cells[4].Value = txDiaAccDesc.Text;
                        dgv.Cells[5].Value = txAccDatatype.Text;
                        dgv.Cells[6].Value = txDiaAmount.Text;
                    }
                    ComputeDataTypeAmount();
                }
            }
            catch (Exception ex)
            {                                                
                MessageBox.Show("請檢查輸入資料", "對話框");
                string str = ex.ToString();
            }
        }

        private void ComputeDataTypeAmount()
        {
            int lend = 0, get = 0;
            for (int i = 0; i < dgAccAccountsData.Rows.Count; i++)
            {
                if (dgAccAccountsData.Rows[i].Cells[1].Value != null)
                {
                    if (dgAccAccountsData.Rows[i].Cells[1].Value.ToString() == txDiaAccNo.Text)
                    {
                        if (dgAccAccountsData.Rows[i].Cells[5].Value.ToString() == "1")
                        {
                            get = get + Convert.ToInt32(dgAccAccountsData.Rows[i].Cells[6].Value);
                        }
                        else if (dgAccAccountsData.Rows[i].Cells[5].Value.ToString() == "2")
                        {
                            lend = lend + Convert.ToInt32(dgAccAccountsData.Rows[i].Cells[6].Value);
                        }
                    }
                }
            }
            lblSuggestResult.Text = "借:" + get.ToString() + " 貸:" + lend.ToString();
        }


        private void QueryAccInputAcc_No()
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entities = content.GetEntity())
                {
                    dgCostItemView.DataSource = entities.JINSHINFINANCE035.Where(o => 
                    o.Cost_Date.Value.Year == dtAccPicker.Value.Year
        && o.Cost_Date.Value.Month == dtAccPicker.Value.Month && o.Status == coststatus.accountcreated 
        && (o.Acc_No.IndexOf(txAccInputdgAcc.Text.Trim()) != -1))
        .OrderBy(o => o.Acc_No).ToList();
                    AccAccountsGridView accountsgridview = new AccAccountsGridView();
                    accountsgridview.SetAccConfirmGridColumns(dgCostItemView);
                }
            }
        }

        private void btnAccInputSave2_Click(object sender, EventArgs e)
        {
            if (lblAccInputPos.Text == AccInputPosModel.DBStatus)
            {
                int sn = int.Parse(lblDiaNoValue.Text);
                try
                {
                    using (AccountEntityDB content = new AccountEntityDB())
                    {
                        using (AccountEntities entities = content.GetEntity())
                        {
                            var val = entities.JINSHINFINANCE035.Where(o => o.SN == sn).FirstOrDefault();
                            val.Acc_No = txDiaAccNo.Text;
                            val.Acc_Desc = txDiaAccDesc.Text;
                            val.DataType = byte.Parse(txAccDatatype.Text);
                            val.Amount = Convert.ToDecimal(txDiaAmount.Text);
                            entities.SaveChanges();
                        }
                    }
                }
                catch (Exception ex)
                {
                    LogControl.LogAlarm(ex.ToString(),"DiaryBook");
                }
                QueryAccInputAcc_No();
            }
            btnAccQuery_Click(new object(), new EventArgs());
        }

        private void QueryAccCostStatus(AccountEntities entities, int year, int month)
        {
            //int year = int.Parse(txAccYear.Text);
            //int month = int.Parse(txAccMonth.Text);
          dgCostItemView.DataSource = entities.JINSHINFINANCE035.Where(o => o.Cost_Date.Value.Year == year
          && o.Cost_Date.Value.Month == month && o.Status == coststatus.accountcreated).OrderBy(o => o.Acc_No).ToList();
        }


        private void btnAccQuery_Click(object sender, EventArgs e)
        {
            //using (AccountEntities entities = new AccountEntities())
            //{
            //    QueryAccCostStatus(entities, dtAccPicker.Value.Year, dtAccPicker.Value.Month);
            //    AccAccountsGridView accountsgridview = new AccAccountsGridView();
            //    accountsgridview.SetAccConfirmGridColumns(dgCostItemView);
            //}
        }

        private void btnAccQuery_Click_1(object sender, EventArgs e)
        {
            QueryAccCostItem();
        }

        private void QueryAccCostItem()
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entities = content.GetEntity())
                {
                    AccAccountsGridView accountsgridview = new AccAccountsGridView();
                    accountsgridview.SetAccConfirmGridColumns(dgCostItemView);
                    QueryAccCostStatus(entities, dtAccPicker.Value.Year, dtAccPicker.Value.Month);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DeleteRecordData();
        }

        private void DeleteRecordData()
        {
            if (MessageBox.Show("請確認是否刪除此筆資料", "對話框", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                List<JINSHINFINANCE035> result = new List<JINSHINFINANCE035>();
                List<JINSHINFINANCE035> items = dgAccAccountsData.DataSource as List<JINSHINFINANCE035>;
                //  dgAccAccountsData
                if (items != null)
                {
                    foreach (var v in dgAccAccountsData.SelectedRows)
                    {
                        DataGridViewRow dgv = v as DataGridViewRow;
                        items.RemoveAt(int.Parse(dgv.Cells[0].Value.ToString()) - 1);
                    }
                    int sn = 1;
                    foreach (var v in items)
                    {
                        v.SN = sn;
                        sn = sn + 1;
                        result.Add(v);
                    }
                }
                    dgAccAccountsData.DataSource = result;
                    dgAccAccountsData.Refresh();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteRecordData();
            }
            catch (Exception ex)
            {
                LogControl.LogAlarm(ex.ToString(), "刪除資料動作");
            }
        }

        private void btnAccInputCost_Click(object sender, EventArgs e)
        {
            QueryAccInputAcc_No();
        }

        private void btnInteliAccDelete_Click(object sender, EventArgs e)
        {
            DeleteCostAccItem();
        }

        private void DeleteCostAccItem()
        {
            if (MessageBox.Show("請確認是否刪除此筆資料", "對話框", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int sn = 0;
                List<JINSHINFINANCE035> data = new List<JINSHINFINANCE035>();
                try
                {
                    using (AccountEntityDB content = new AccountEntityDB())
                    {
                        using (AccountEntities entities = content.GetEntity())
                        {
                            foreach (var v in dgCostItemView.SelectedRows)
                            {
                                DataGridViewRow dgv = v as DataGridViewRow;
                                sn = int.Parse(dgv.Cells[0].Value.ToString());
                                var item = entities.JINSHINFINANCE035.Where(o => o.SN == sn).FirstOrDefault();
                                if (item != null)
                                    data.Add(item);
                            }
                            entities.JINSHINFINANCE035.RemoveRange(data);
                            entities.SaveChanges();
                            QueryAccCostStatus(entities, dtAccPicker.Value.Year, dtAccPicker.Value.Month);
                        }
                    }
                }
                catch (Exception ex)
                {
                    string str = ex.ToString();
                }
            }

        }

        private void btnAccConfirm_Click(object sender, EventArgs e)
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    try
                    {
                        List<JINSHINFINANCE035> costs = new List<JINSHINFINANCE035>();
                        foreach (var item in dgAccAccountsData.Rows)
                        {
                            JINSHINFINANCE035 vdata = new JINSHINFINANCE035();
                            DataGridViewRow dgr = item as DataGridViewRow;
                            vdata.Acc_No = dgr.Cells[1].Value.ToString();
                            vdata.Cost_Date = DateTime.Parse(dgr.Cells[2].Value.ToString());
                            vdata.Cost_M = Convert.ToByte(vdata.Cost_Date.Value.Month);
                            vdata.Acc_ID = dgr.Cells[3].Value.ToString();
                            vdata.Acc_Desc = dgr.Cells[4].Value.ToString();
                            vdata.DataType = byte.Parse(dgr.Cells[5].Value.ToString());
                            vdata.Amount = decimal.Parse(dgr.Cells[6].Value.ToString());
                            vdata.Status = coststatus.accountcreated;
                            costs.Add(vdata);
                            //  MessageBox.Show("請先選擇日期", "對話框");
                        }
                        int itemsn = 1;
                        foreach (var item in costs.GroupBy(o => o.Acc_No))
                        {
                            itemsn = 1;
                            foreach (var i in item.OrderBy(o => o.DataType))
                            {
                                i.Item = itemsn;
                                itemsn = itemsn + 1;
                            }
                        }
                        entity.JINSHINFINANCE035.AddRange(costs);
                        entity.SaveChanges();
                        int month = dtAccPicker.Value.Month;
                        QueryAccCostItem();
                        int idx = lblInputPos.SelectedIndex;
                        lblInputPos.SelectedIndex = idx;
                        //  dgAccAccountsData.DataSource = null;
                    }
                    catch (Exception ex)
                    {
                        string str = ex.ToString();
                    }
                }
            }
        }

        private void btnAccGenerate_Click(object sender, EventArgs e)
        {
            using (DiaryAccounts accounts = new DiaryAccounts())
            {
                accounts.SaveAccountsToDB(accounts.values.Where(o => o.IsDefaultAccount == true).ToList(), int.Parse(txAccMonth.Text));
            }
        }

        private void lblInputPos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(lblInputPos.SelectedValue is JINSHINFINANCE037))
            {
                using (DiaryAccounts account = new DiaryAccounts())
                {
                    List<JINSHINFINANCE035> data = account.GetData(lblInputPos.SelectedItem as JINSHINFINANCE037, 0);
                    AccAccountsGridView accountsgridview = new AccAccountsGridView();
                    dgAccAccountsData.DataSource = data;
                    accountsgridview.SetAccConfirmGridColumns(dgAccAccountsData);
                }
            }
        }

        private void txDiaAccDesc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txDiaAccDesc.Text.Replace(Environment.NewLine, "");
                txDiaAmount.Focus();
            }
        }

        private void txDiaAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAccInputSave2_Click(new object(), new EventArgs());
            }
        }

        private void dtAccPicker_ValueChanged(object sender, EventArgs e)
        {
            if (dtAccPicker.Value != null)
            {
                using (AccountEntityDB content = new AccountEntityDB())
                {
                    using (AccountEntities entity = content.GetEntity())
                    {
                        var lst = entity.JINSHINFINANCE035.Where(o => o.Cost_Date == dtAccPicker.Value).ToList();
                        List<int> no = new List<int>();
                        foreach (var item in lst)
                        {
                            no.Add(Convert.ToInt32(item.Acc_No.Substring(item.Acc_No.Length - 3, 3)));
                        }
                        string fixednocnt = "";
                        string str1 = "";
                        for (int i = 0; i < AccountingReso.accnoLen - 1; i++)
                        {
                            str1 += "0";
                            fixednocnt += "0";
                        }
                        fixednocnt += "0";
                        if (lst.Count() == 0)
                        {
                            txDiaAccNo.Text = AccountingReso.accno_id + dtAccPicker.Value.ToString("yyyyMMdd") + str1 + "1";
                        }
                        else
                            txDiaAccNo.Text = AccountingReso.accno_id + dtAccPicker.Value.ToString("yyyyMMdd") + (no.Max() + 1).ToString(fixednocnt);
                    }
                }
            }
        }

        private void btnDiarySelection_Click(object sender, EventArgs e)
        {
            DiaryAccAcountFrm diaryaccfrm = new DiaryAccAcountFrm();
            diaryaccfrm.dgv = dgAccAccountsData;
            if (dgAccAccountsData.Rows.Count == 0)
                diaryaccfrm.sn = 1;
            else
                diaryaccfrm.sn = int.Parse(dgAccAccountsData.Rows[dgAccAccountsData.Rows.Count - 1].Cells[0].Value.ToString()) + 1;
            diaryaccfrm.Show();
        }

        private void FrmDiaryBook_Load(object sender, EventArgs e)
        {
            dtAccPicker.Value = DateTime.Today;
            lblInputPos.DataSource = null;
            using (DiaryAccounts account = new DiaryAccounts())
            {
                lblInputPos.DataSource = account.GetJINSHINFINANCE050Items();
                lblInputPos.DisplayMember = "Name";
                lblInputPos.ValueMember = "No";
                txAccYear.Text = DateTime.Now.Year.ToString();
                txAccMonth.Text = DateTime.Now.Month.ToString();
            }
        }

        private void gAccAccountsData_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TempGridModify(e.ColumnIndex, e.RowIndex);
        }

        private void gAccAccountsData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DeleteRecordData();
            }
        }

        private void TempGridModify(int colidx, int rowidx)
        {
            try
            {
                DataGridViewRow dgrow = dgAccAccountsData.Rows[rowidx];
                if (dgrow != null)
                {
                    var status = dgAccAccountsData.Rows.GetRowState(rowidx);
                    lblDiaNoValue.Text = rowidx.ToString();
                    //     txDiaAccNo.Text = ConvertCell(dgrow.Cells[1].Value);
                    txDiaAccID.Text = ConvertCell(dgrow.Cells[3].Value);
                    //    txDiaAccDesc.Text = ConvertCell(dgrow.Cells[4].Value);
                    txAccDatatype.Text = ConvertCell(dgrow.Cells[5].Value);
                    txDiaAmount.Text = ConvertCell(dgrow.Cells[6].Value);
                    lblAccInputPos.Text = AccInputPosModel.RecordStatus;
                }
                ComputeDataTypeAmount();
                txDiaAmount.Focus();
            }
            catch (Exception ex)
            {
                string str = ex.ToString();
            }
        }

        private string ConvertCell(object val)
        {
            if (val != null)
                return val.ToString();
            else return "";
        }

        private void txDiaAccDesc_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void dgAccAccountsData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DeleteRecordData();
            }
        }

        private void dgAccAccountsData_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TempGridModify(e.ColumnIndex, e.RowIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //using (AccountEntityDB content = new AccountEntityDB())
            //{
            //    using (AccountEntities entity = content.GetEntity())
            //    {
                    //using (AccountEntities entity = new AccountEntities())
                    //{
                    //    //var data01 = entity.JINSHINFINANCE035.Where(o => o.SN == 3).FirstOrDefault();
                    //    //entity.JINSHINFINANCE035.Remove(data01);
                    //    //var data02 = entity.JINSHINFINANCE035.Where(o => o.SN == 4).FirstOrDefault();
                    //    //entity.JINSHINFINANCE035.Remove(data02);
                    //    //var data03 = entity.JINSHINFINANCE035.Where(o => o.SN == 5).FirstOrDefault();
                    //    //entity.JINSHINFINANCE035.Remove(data03);
                    //    //entity.SaveChanges();
                    //}
                }

        private void dgCostItemView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            CostItemModify(e.ColumnIndex, e.RowIndex);
        }

        private void dgCostItemView_MouseClick(object sender, MouseEventArgs e)
        {
         
        }

        private void CostItemModify(int colindex, int rowindex)
        {
            try
            {
                DataGridViewRow dgrow = dgCostItemView.Rows[rowindex];
                if (dgrow != null)
                {
                    lblDiaNoValue.Text = ConvertCell(dgrow.Cells[0].Value);
                    txDiaAccNo.Text = ConvertCell(dgrow.Cells[1].Value);
                    txDiaAccID.Text = ConvertCell(dgrow.Cells[3].Value);
                    txDiaAccDesc.Text = ConvertCell(dgrow.Cells[4].Value);
                    txAccDatatype.Text = ConvertCell(dgrow.Cells[5].Value);
                    txDiaAmount.Text = ConvertCell(dgrow.Cells[6].Value);
                    lblAccInputPos.Text = AccInputPosModel.DBStatus;
                }
            }
            catch (Exception ex)
            {
                string str = ex.ToString();
            }
        }

        private void dgCostItemView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CostItemModify(e.ColumnIndex, e.RowIndex);
        }

        private void dgCostItemView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DeleteCostAccItem();
            }
        }

        private void btnEmpty_Click(object sender, EventArgs e)
        {
            dgAccAccountsData.DataSource = new List<JINSHINFINANCE035>();
            dgAccAccountsData.Refresh();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            profit("請確認是否認列為盈餘項目", true);
        }

        private void profit(string msg,bool IsConfirm)
        {
            if (MessageBox.Show(msg, "對話框", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int sn = 0;
                List<JINSHINFINANCE035> data = new List<JINSHINFINANCE035>();
                try
                {
                    using (AccountEntityDB content = new AccountEntityDB())
                    {
                        using (AccountEntities entities = content.GetEntity())
                        {
                            foreach (var v in dgCostItemView.SelectedRows)
                            {
                                DataGridViewRow dgv = v as DataGridViewRow;
                                sn = int.Parse(dgv.Cells[0].Value.ToString());
                                var item = entities.JINSHINFINANCE035.Where(o => o.SN == sn).FirstOrDefault();
                                item.Is_MoneyPay = IsConfirm;
                            }
                            entities.SaveChanges();
                            QueryAccCostStatus(entities, dtAccPicker.Value.Year, dtAccPicker.Value.Month);
                        }
                    }
                }
                catch (Exception ex)
                {
                    string str = ex.ToString();
                }
            }
        }

        
        private void btnUnprofit_click(object sender, EventArgs e)
        {
            profit("請確認是否認列為盈餘項目", false);
        }

        private void FrmDiaryBook_Shown(object sender, EventArgs e)
        {
            SysRescControlVModel.SetFixedWindow(this);
            this.HorizontalScroll.Value = 0;
            this.VerticalScroll.Value = 0;
          
        }

        private void FrmDiaryBook_SizeChanged(object sender, EventArgs e)
        {

        }
    }
}
