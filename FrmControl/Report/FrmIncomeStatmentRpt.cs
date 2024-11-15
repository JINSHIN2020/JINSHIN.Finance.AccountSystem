using FinanceAccountProgram.Models.Config;
using FinanceAccountProgram.Models.UControl;
using JINSHIN.Finance.AccountSystem.Resources;
using JINSHIN.FinanceAccounting.DB;
using FinanceAccountProgram.VModel.Conrols;
using FinanceAccountProgram.VModel.Conrols.GridView;
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
using FinanceAccountProgram.VModel.Conrols.ManageForm;
using JINSHIN.BUSINESS.LIBARY.Resources;
using JINSHIN.BUSINESS.LIBARY.UIControls.GridView;
using JINSHIN.FinanceAccount.Libary.Models.Financial;
using JINSHIN.FinanceAccount.Libary.VModels.Finanacial;
using JINSHIN.FinanceAccount.Libary.Config;
using JINSHIN.Finance.AccountSystem;
using JINSHIN.FinanceAccount.Libary.VModels;
using JINSHIN.FinanceAccounting.DB.VModel;
using JINSHIN.FinanceAccount.Libary.VModels.Flow;
using JINSHIN.FinanceAccount.Libary.VModels.AccControl;
using JINSHIN.BUSINESS.LIBARY.Base;

namespace FinanceAccountProgram.FrmControl
{
    public partial class FrmIncomeStatmentRpt : Form
    {
        public List<string> FinancialReportCompareMsg { get; set; }
        public PathModel pathmodel { get; set; }
        public FrmIncomeStatmentRpt()
        {
            InitializeComponent();
            dgIncomeFinancial.Font = new System.Drawing.Font(DataControl.DataGridFont, Convert.ToInt32(DataControl.DataGridFontSize));
            using (FormControlVModel ctlmodel = new FormControlVModel())
            {
                ctlmodel.ControlResolution(this);
            }
            pathmodel = new PathModel();
            FinancialReportCompareMsg = new List<string>();
            SysRescControlVModel.Let1366ToMaxWindowSize(this);           
        }

        private void btnIncomeFinancial_Click(object sender, EventArgs e)
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    List<JINSHINFINANCE056> incomes = entity.JINSHINFINANCE056.OrderBy(o => o.orderth).ToList();
                    bool checkdata = incomes.Count == 0;
                    if (checkdata)
                    {
                        MessageBox.Show("請設定損益表格式!");
                        return;
                    }
                    List<JINSHINFINANCE036> costledger = entity.JINSHINFINANCE036.Where(o => o.Acc_Date.Value.Year == AccountingReso.yearnow).ToList();
                    Financial_IncomedgGridView gvitems = new Financial_IncomedgGridView();
                    List<FinancialBase> financials = new List<FinancialBase>();
                    lstMsgIncomeStatment.Items.Clear();
                    FinancialReportCompareMsg.Clear();
                    string msg = "";
                    try
                    {
                        foreach (var item in incomes)
                        {
                            if (item.Accid == "7162")
                            {
                                //    string str = "";
                            }
                            if ((item.datatype == 1) || (item.datatype == 2))
                            {
                                var i = new FinancialBase()
                                {
                                    AccID = item.Accid,
                                    ClassDesc = item.ClassDesc,
                                    DescData = item.DescData,
                                    orderth = item.orderth.Value,
                                    datatypectl = item.datatype.Value,
                                    AmountOrg = item.Amount ?? 0,
                                    Display = item.Display == "V" ? true : false
                                };
                                var val = costledger.Where(o => o.Acc_ID == item.Accid).FirstOrDefault();
                                if (val != null)
                                {
                                    i.amount = val.Amount.Value;
                                    if (i.amount != i.AmountOrg)
                                    {
                                        msg = i.AccID.ToString() + ",現在金額計算," + i.amount + ",原來的金額," + i.AmountOrg;                       
                                    }
                                }
                                financials.Add(i);
                            }
                            else if (item.datatype != 3)
                            {
                                financials.Add(new FinancialBase()
                                {
                                    ClassDesc = item.ClassDesc,
                                    DescData = item.DescData,
                                    orderth = item.orderth.Value,
                                    datatypectl = item.datatype.Value,
                                    amount = item.Amount ?? 0,
                                    Display = item.Display == "V" ? true : false
                                }) ;
                            }
                        }

                        IncomeFinancialRpt financialrpt = new IncomeFinancialRpt(financials, costledger,incomes);                        
                        StringBuilder sb = new StringBuilder();
                        foreach (var item in financialrpt.accids)
                        {
                            sb.Append(item.AccID + "," + item.amount + Environment.NewLine);
                        }
                        // File.WriteAllText(pathmodel.exportPath + "Income" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".csv", sb.ToString(), Encoding.UTF8);

                        int cnt = 0;
                        foreach (var item in incomes)
                        {
                            cnt = cnt + 1;
                            if (cnt == 60)
                            {
                                // string str = "";
                            }
                            if (item.datatype == 3)
                            {
                                financials.Add(new FinancialBase()
                                {
                                    ClassDesc = item.ClassDesc,
                                    DescData = item.DescData,
                                    orderth = item.orderth.Value,
                                    amount = financialrpt.accounts[item.ComputeNo.Value].amount,
                                    amountstr = financialrpt.accounts[item.ComputeNo.Value].amountstr,
                                    Display = item.Display == "V" ? true : false
                                }) ;
                            }
                        }
                        //  var valdata = financials.Where(o => o.AccID == "7151").ToList();
                        var datalist = financials.Where(v=>v.Display == true).OrderBy(o => o.orderth).ToList();
                        //顯示不同損益表的差異
                        //DisplayReportDiffDataOnListBox(financialrpt.getReportDiffCheckData(), lstMsgIncomeStatment);
                        dgIncomeFinancial.DataSource = datalist.OrderBy(o => o.orderth).ToList(); ;
                        lblFinancialRptCnt.Text = "總數:" + datalist.Count;
                        gvitems.SetAccConfirmGridColumns(dgIncomeFinancial);
                        financialrpt.Dispose();
                    }
                    catch (Exception ex)
                    {
                        LogControl.nlog.Error(ex.ToString());
                    }
                    finally
                    {
                        gvitems.Dispose();
                    }
                }
            }
        }


        private void DisplayReportDiffDataOnListBox(List<AccidAccount> diffvalues, ListBox list)
        {
            //  list.Items.Clear();
            foreach (var item in diffvalues)
            {
                list.Items.Add("Accid:" + item.AccID + ",Amount:" + item.amount);
            }
        }

        private bool SwhoBalanceReportMsg(string reporttype, DataGridView dgv)
        {
            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show("請先確認" + reporttype + "表格內是否完整,按下查詢按鈕", "對話框");
                return false;
            }
            else
            {
                return true;
            }

        }
        private void btnIncomeReport_Click(object sender, EventArgs e)
        {
            string head = Diary.Default.ReportTitle + Environment.NewLine;
            string reporttype = "損益表" + Environment.NewLine;
            if (SwhoBalanceReportMsg("損益", dgIncomeFinancial))
            {
                StringBuilder reporthead = new StringBuilder();
                reporthead.Insert(0, reporttype);
                reporthead.Insert(0, head);
                reporthead.Append("分類,項目,金額" + Environment.NewLine);
                for (int i = 0; i < dgIncomeFinancial.Rows.Count; i++)
                {
                    reporthead.Append(dgIncomeFinancial.Rows[i].Cells[0].Value + "," + dgIncomeFinancial.Rows[i].Cells[1].Value + "," + dgIncomeFinancial.Rows[i].Cells[2].Value + Environment.NewLine);
                }
                File.WriteAllText(pathmodel.ReportPath + "IncomeStatementReport" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".csv", reporthead.ToString(), Encoding.UTF8);
            }
        }

        private void btnReportExport_Click(object sender, EventArgs e)
        {
            using (GridViewBase grid = new GridViewBase())
            {
                grid.ExportDataGridView(pathmodel.exportPath, "IncomeReportData", dgIncomeFinancial);
                WriteAmountDiffLog("IncomeReportData");
            }
        }

        private void WriteAmountDiffLog(string title)
        {
            string content = "Accid,系統資料,系統金額,原來的資料,原來的金額" + Environment.NewLine;
            string filename = title + DateTime.Now.ToString("yyyyMMddHHmmss");
            foreach (var item in FinancialReportCompareMsg)
            {
                content = content + item + Environment.NewLine;
            }
            File.WriteAllText(pathmodel.exportPath + filename + ".csv", content, Encoding.UTF8);
        }

        private void btnIncomeVerify_Click(object sender, EventArgs e)
        {
            if (dgIncomeFinancial.Rows.Count == 0)
            {
                MessageBox.Show(FormCaption.IncomeReport001, accounting.FormDataTitle, MessageBoxButtons.OKCancel);
                return;
            }
            using (VerifyVModel model = new VerifyVModel())
            {
                model.VerifyData(true, DataClass.usrno);
            }
            
        }

        private void FrmIncomeStatmentRpt_Shown(object sender, EventArgs e)
        {
            SysRescControlVModel.SetFixedWindow(this);
        }
    }
}
