using JINSHIN.Finance.AccountSystem;
using FinanceAccountProgram.Models.Config;
using JINSHIN.Finance.AccountSystem.Resources;
using JINSHIN.FinanceAccounting.DB;
using FinanceAccountProgram.ViewFrm;
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
using FinanceAccountProgram.VModel.Business;
using JINSHIN.FinanceAccount.Libary.Models.Financial;
using JINSHIN.FinanceAccount.Libary.VModels.Finanacial;
using JINSHIN.FinanceAccount.Libary.Config;
using JINSHIN.FinanceAccounting.DB.VModel;
using JINSHIN.Finance.AccountSystem.VModel.FileExport;
using JINSHIN.FinanceAccount.Libary.VModels.Config;
using JINSHIN.FinanceAccount.Libary.VModels.AccControl;
using ProjectResourceData;

namespace FinanceAccountProgram.FrmControl
{
    public partial class FrmFinanceBalanceRpt : Form
    {
        public List<FinancialBase> financials { get; set; }
      //  public List<string> FinancialReportCompareMsg { get; set; }
        public PathModel pathmodel { get; set; }
        public FrmFinanceBalanceRpt()
        {
            InitializeComponent();
            dgBalanceFinancial.Font = new System.Drawing.Font(DataControl.DataGridFont, Convert.ToInt32(DataControl.DataGridFontSize));
            using (FormControlVModel ctlmodel = new FormControlVModel())
            {
                ctlmodel.ControlResolution(this);
            }
            financials = new List<FinancialBase>();
            pathmodel = new PathModel();
        }

        private void btnFinanceBalance_Click(object sender, EventArgs e)
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    var incomedataReady = entity.JINSHINFINANCE049.Where(o => o.AccYear == (AccountingReso.yearnow - 1911)).FirstOrDefault();
                    if (incomedataReady != null)
                    {
                        if (!incomedataReady.IsVerify.Value)
                        {
                            MessageBox.Show(ProjectNameRsource.FinanceBalanceAlarm01, accounting.FormDataTitle, MessageBoxButtons.OKCancel);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show(ProjectNameRsource.FinanceBalanceAlarm01, accounting.FormDataTitle, MessageBoxButtons.OKCancel);
                        return;
                    }
                    //FinancialConfig.todaymoney =
                    JINSHINFINANCE054 balance = entity.JINSHINFINANCE054.Where(v => v.DescData == "本期損益").FirstOrDefault();
                    List<JINSHINFINANCE054> balances = entity.JINSHINFINANCE054.Where(v=>v.DescData != "本期損益").OrderBy(o => o.orderth).ToList();
                    if (balances.Count == 0)
                    {
                        MessageBox.Show("請設定資產負債表格式!");
                        return;
                    }
                    string totalyear_accid = "";
                    var thisyearIncome_accid = "";
                    var valdata = balances.Where(v => v.DescData.Trim() == "累計虧損").FirstOrDefault();
                   
                    if (valdata != null)
                    {
                      totalyear_accid = valdata.Accid;
                    }
                  
                    List<JINSHINFINANCE036> costledger = entity.JINSHINFINANCE036.Where(o => o.Acc_Date.Value.Year == AccountingReso.yearnow).ToList();
                    BalanceSheetGridView gvitems = new BalanceSheetGridView();
                    financials.Clear();
                    lstMsgFinanceBalance.Items.Clear();
                    string msg = "";
                    try
                    {
                        foreach (var item in balances)
                        {
                            if ((item.datatype == 1) || (item.datatype == 2))
                            {
                                var i = new FinancialBase()
                                {
                                    AccID = item.Accid,
                                    ClassDesc = item.ClassDesc,
                                    DescData = item.DescData,
                                    orderth = item.orderth.Value,
                                    datatypectl = item.datatype.Value,
                                    moneytype = item.MoneyType.Value,
                                    AmountOrg = item.Amount ?? 0,
                                    Display = item.Display == "V" ? true : false
                                };
                                var val = costledger.Where(o => o.Acc_ID == item.Accid).FirstOrDefault();
                                if (val != null)
                                {
                                    if (val.Acc_ID == totalyear_accid)
                                    {
                                        val.Amount = -val.Amount;
                                    }

                                    //原將調整加入金融資產
                                    //if (val.Acc_ID == "1121")
                                    //{
                                    //    var valdata = costledger.Where(o => o.Acc_ID == "1122").FirstOrDefault();
                                    //    if (valdata != null)
                                    //    {
                                    //        val.Amount = val.Amount + valdata.Amount;
                                    //    }
                                    //}
                                    i.amount = val.Amount.Value;
                                    i.AmountOrg = item.Amount.Value;
                                    if (i.amount != i.AmountOrg)
                                    {
                                        msg = i.AccID.ToString() + ",計算," + i.amount + ",原來的," + i.AmountOrg;
                                        // lstMsgFinanceBalance.Items.Add(msg);
                                        //FinancialReportCompareMsg.Add(msg);
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
                                    moneytype = item.MoneyType.Value,
                                    Display = item.Display == "V" ? true : false
                                });
                            }
                        }

                        #region 設定本期損益
                        if (balance != null)
                        {
                            thisyearIncome_accid = balance.Accid;
                        }
                        var yearsettilemoney = new FinancialBase()
                        {
                            ClassDesc = "權益",
                            DescData = (AccountingReso.yearnow - 1911).ToString() + "年度本期損益",
                            orderth = 38,
                            moneytype = 4,
                            AccID = thisyearIncome_accid,
                            Display =  true
                        };
                        #endregion
                        using (SysSettingCtl ctl = new SysSettingCtl())
                        {
                           // yearsettilemoney.com
                            yearsettilemoney.amount = decimal.Parse(ctl.LoadYearMoney(CommonVar.SettleMoney));
                            if (Math.Sign(yearsettilemoney.amount) >=0)
                            {
                                yearsettilemoney.datatypectl = 2;
                            }
                            else
                            {
                                yearsettilemoney.datatypectl = 1;
                            }
                        }
                        financials.Add(yearsettilemoney);

                        var values = financials.Where(o => o.AccID == "3351").FirstOrDefault();
                        BalanceFinancialRpt financialrpt = new BalanceFinancialRpt(financials, costledger, balances);
#if (DEBUG)
                        StringBuilder sb = new StringBuilder();
                        foreach (var item in financialrpt.accids)
                        {
                            sb.Append(item.AccID + "," + item.amount + Environment.NewLine);
                        }
#endif
                        foreach (var item in balances)
                        {
                            if (item.datatype == 3)
                            {
                                financials.Add(new FinancialBase()
                                {
                                    ClassDesc = item.ClassDesc,
                                    DescData = item.DescData,
                                    orderth = item.orderth.Value,
                                    amount = financialrpt.accounts[item.ComputeNo.Value].amount,
                                    moneytype = item.MoneyType.Value,
                                    Display = item.Display == "V" ? true : false
                                });
                            }
                        }
                        //lstMsgFinanceBalance diff
                        DisplayReportDiffDataOnListBox(financialrpt.getReportDiffCheckData(), lstMsgFinanceBalance);
                        var datalist = financials.Where(v=>v.Display == true).OrderBy(o => o.orderth).ToList();
                        dgBalanceFinancial.DataSource = datalist.OrderBy(o => o.orderth).ToList(); ;
                        lblBalanceSheetCnt.Text = "總數:" + datalist.Count;
                        gvitems.SetAccConfirmGridColumns(dgBalanceFinancial);
                        financialrpt.Dispose();
                    }
                    finally
                    {
                        gvitems.Dispose();
                        // financialrpt.Dispose();
                    }
                    //Financial_IncomeGridViewItems
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

        private void btnDiffData_Click(object sender, EventArgs e)
        {
            using (GridViewBase grid = new GridViewBase())
            {
                grid.ExportDataGridView(pathmodel.exportPath, "BalanceReportData", dgBalanceFinancial);
                WriteAmountDiffLog("BalanceReport");
            }
        }

        private void WriteAmountDiffLog(string title)
        {
            string content = "Accid,系統資料,系統金額,原來的資料,原來的金額" + Environment.NewLine;
            string filename = title + DateTime.Now.ToString("yyyyMMddHHmmss");
            //foreach (var item in FinancialReportCompareMsg)
            //{
            //    content = content + item + Environment.NewLine;
            //}
            File.WriteAllText(pathmodel.exportPath + filename + ".csv", content, Encoding.UTF8);
        }

        private List<string> GetReportContent(List<FinancialBase> data01, List<FinancialBase> data02)
        {
            List<string> content = new List<string>();
            for (int i = 0; i < data02.Count(); i++)
            {
                if ((i + 1) <= data01.Count)
                {
                    content.Add(data02[i].ClassDesc + "," + data02[i].DescData + "," + data02[i].amount + "," + data01[i].ClassDesc + "," + data01[i].DescData + "," + data01[i].amount);
                }
                else
                {
                    content.Add(data02[i].ClassDesc + "," + data02[i].DescData + "," + data02[i].amount);
                }
            }

            return content;
        }

        private void btnBalanceReport_Click(object sender, EventArgs e)
        {
            string head = "金心資訊科技有限公司";
            string reporttype = (AccountingReso.yearnow - 1911).ToString() + "資產負債表";
            List<string> reportdata = new List<string>();
            reportdata.Insert(0, reporttype);
            reportdata.Insert(0, head);
            reportdata.Add("分類,項目,金額,分類,項目,金額");
            if (SwhoBalanceReportMsg("資產負債", dgBalanceFinancial))
            {
                try
                {
                    var data01 = financials.Where(o => o.moneytype == 1 || o.moneytype == 2).Where(v=>v.Display == true).OrderBy(o => o.orderth).ToList();
                    var data02 = financials.Where(o => o.moneytype != 1 && o.moneytype != 2).Where(v=>v.Display == true).OrderBy(o => o.orderth).ToList();
                    var val = financials.Where(o => o.AccID == "3351").ToList();
                    List<string> content = new List<string>();
                    if (data02.Count() > data01.Count())
                    {
                        content = GetReportContent(data01, data02);
                    }
                    else
                    {
                        content = GetReportContent(data02, data01);
                    }
                    reportdata.AddRange(content);
                    using (ExcelFileManager excel = new ExcelFileManager())
                    {
                        excel.ExcelReport(pathmodel.ReportPath + "FinanceBalanceReport" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".xlsx", reportdata, 3, 6);
                    }
                }
                catch (Exception ex)
                {
                    string str = ex.ToString();
                }
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

        private void FrmFinanceBalanceRpt_Shown(object sender, EventArgs e)
        {
            SysRescControlVModel.SetFixedWindow(this);
        }
    }
}
