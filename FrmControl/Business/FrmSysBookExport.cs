using JINSHIN.Finance.AccountSystem;
using JINSHIN.Finance.AccountSystem.Resources;
using JINSHIN.FinanceAccounting.DB;
using FinanceAccountProgram.VModel;
using FinanceAccountProgram.VModel.Accounts;
using FinanceAccountProgram.VModel.Business;

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
using JINSHIN.FinanceAccount.Libary.Config;
using JINSHIN.FinanceAccount.Libary.Models;
using JINSHIN.FinanceAccount.Libary.VModels;
using JINSHIN.FinanceAccounting.DB.VModel;
using FinanceAccountProgram.Models.Config;
using JINSHIN.FinanceAccount.Libary.VModels.AccControl;

namespace FinanceAccountProgram.FrmControl
{
    public partial class FrmSysBookExport : Form
    {

        List<BookCompute> bookcomputes = new List<BookCompute>();
        List<BookConvert2> bookconvertGoal = new List<BookConvert2>();
        List<JINSHINFINANCE032> dbbooks = new List<JINSHINFINANCE032>();
        string accdocTitle01 = "序號,會計編碼,日期,傳票編號,摘要,種類,借,貸,借/貸,餘額";
        string accdocTitle00 = "序號,會計編碼,日期,傳票編號,摘要,種類,借,貸";
        public string id = accounting.accGovNo;
        public string year = (AccountingReso.yearnow - 1911).ToString();
        private string aiextension = ".csv";
        //public string aiinfopath = "";
        public string path { get; set; }
        private string AIInfo = @"\AIInfo\";
        public PathModel pathmodel { get; set; }
        List<YearBeginViewModel> ybviewmodel = new List<YearBeginViewModel>();
        public AccountRemainData acountremain { get; set; }
        public int fheight { get; set; }
        public int fwidth { get; set; }
        public FrmSysBookExport()
        {
            InitializeComponent();
            pathmodel = new PathModel();
            using (FormControlVModel ctlmodel = new FormControlVModel())
            {
                ctlmodel.ControlResolution(this);
            }
            path = Environment.CurrentDirectory;
            DirectoryInfo di = new DirectoryInfo(path);
//#if (DEBUG)
//            aiinfopath = di.Parent.Parent.FullName + AIInfo;
//#else
//            aiinfopath = accounting.ClickPath + AIInfo;
//#endif
            acountremain = new AccountRemainData();
        }


        /// <summary>
        /// no 0 日記 database JINSHINFINANCE035
        /// no 1 總帳
        /// no 2 明細
        /// </summary>
        /// <returns></returns>
        public List<BookConvert2> GetCompareDataFromDB()
        {
            bookcomputes.Clear();
            try
            {
                bookconvertGoal.Clear();
                string datestr = "";
                DateTime datatime = default(DateTime);
                using (AccountEntityDB content = new AccountEntityDB())
                {
                    using (AccountEntities entity = content.GetEntity())
                    {
                        var list = AccCostItemConfig.GetClassData(entity.JINSHINFINANCE035.Where(o => o.Cost_Date.Value.Year == AccountingReso.yearnow).ToList());
                        for (int i = 0; i < list.Count; i++)
                        {
                            BookConvert2 bookcnt = new BookConvert2();
                            bookcnt.BookNo = list[i].Acc_No;
                            bookcnt.datadate = list[i].Cost_Date.Value;
                            bookcnt.TaxNo = list[i].Acc_ID;
                            bookcnt.amountType = Convert.ToInt32(list[i].DataType);
                            datatime = list[i].Cost_Date.Value;
                            datestr = (datatime.Year - 1911).ToString() + datatime.Month.ToString("00") + datatime.Day.ToString("00");
                            bookcnt.Rightvalues = string.Format("{0},{1},{2},{3}", list[i].Acc_ID, datestr, list[i].Acc_No, list[i].Acc_Desc);
                            bookcnt.amount = double.Parse(list[i].Amount.ToString());
                            bookconvertGoal.Add(bookcnt);
                        }
                    }
                }
                dbbooks.Clear();
                ProduceAccountingDataFile();
                MessageBox.Show("匯出完成!");
            }
            catch (Exception ex)
            {
                string str = ex.ToString();
            }
            return bookconvertGoal;

        }

        /// <summary>
        /// 0:
        /// 1:
        /// 2:
        /// </summary>
        private void ProduceAccountingDataFile()
        {
            string NextContentMoney = "";
            int count = 0;
            StringBuilder sb = new StringBuilder();
            for (int no = 0; no < 3; no++)
            {
                sb.Clear();
                
                if (no == 0)
                {
                    sb.Append(accdocTitle00 + Environment.NewLine);
                    count = 1;
                    bookconvertGoal = bookconvertGoal.OrderBy(o => o.datadate).ToList();
                    foreach (var i in bookconvertGoal)
                    {
                        SetDataToDocument(false, true, sb, i, i.amountType.ToString(), count, 1);
                        count++;
                    }
                    File.WriteAllText(pathmodel.aiinfopath + year + id + no + aiextension, sb.ToString(), Encoding.UTF8);
                }
                //selectmany modify
                else if (no == 1)
                {
                    sb.Append(accdocTitle01 + Environment.NewLine);
                    JINSHINFINANCE032 accbook = new JINSHINFINANCE032();
                    bookcomputes.Clear();
                    var lst = bookconvertGoal.OrderBy(o => o.TaxNo).GroupBy(o => o.TaxNo);
                    double lend = 0; double get = 0;
                    double computevalue = 0;
                    StringBuilder sa = new StringBuilder();
                    sa.Append(sb.ToString());
                    Dictionary<int, double> YearOpenAmount = new Dictionary<int, double>();
                    ybviewmodel.Clear();
                    ybviewmodel = acountremain.SetMoneyData();
                    foreach (var s in lst)
                    {
                        BookCompute account = new BookCompute();
                        YearOpenAmount.Clear();
                        YearOpenAmount = GetLastMoney(s.First().TaxNo);
                        lend = s.Where(o => o.amountType == 2).Sum(o => o.amount);
                        get = s.Where(o => o.amountType == 1).Sum(o => o.amount);
                        account.lend = lend;
                        account.get = get;
                        account.taxno = s.First().TaxNo;
                        if (YearOpenAmount.ContainsKey(1))
                        {
                            get = get + YearOpenAmount.First().Value;
                            account.periodget = get;
                            account.periodlend = lend;
                        }
                        else
                        {
                            lend = lend + Math.Abs(YearOpenAmount.First().Value);
                            account.periodlend = lend;
                            account.periodget = get;
                        }
                        computevalue = account.periodget - account.periodlend;
                        if (computevalue >= 0)
                        {
                            account.booktype = 1;
                            account.total = computevalue;
                            SetDataToTotalDocument(sb, s.First(), "1", 1, computevalue);
                        }
                        else
                        {
                            account.booktype = 2;
                            account.total = computevalue;
                            SetDataToTotalDocument(sb, s.First(), "2", 1, computevalue * -1);
                        }
                        bookcomputes.Add(account);
                    }

                    var BeginYearData = ybviewmodel.Where(o => o.checkvalue == false).ToList();
                    Dictionary<int, double> amountgp = default(Dictionary<int, double>);
                    double accval = 0;
                    foreach (var item in BeginYearData)
                    {
                        BookCompute acc = new BookCompute();
                        amountgp = GetAmountGroup(item);
                        acc.booktype = amountgp.First().Key;
                        acc.taxno = item.key;
                        acc.durationNodata = true;
                        accval = amountgp.First().Value;
                        if (amountgp.First().Key == 1)
                        {
                            acc.periodget = amountgp.First().Value;
                            acc.total = acc.periodget;
                            sb.Append(string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}", 1, item.key, "1070101", "None", "期初資訊", amountgp.First().Key, accval, "", "借", accval) + Environment.NewLine);
                        }
                        else if (amountgp.First().Key == 2)
                        {
                            acc.periodlend = accval * -1;
                            acc.total = accval;
                            sb.Append(string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}", 1, item.key, "1070101", "None", "期初資訊", amountgp.First().Key, "", (accval * -1).ToString(), "貸", accval * -1) + Environment.NewLine);
                        }
                        bookcomputes.Add(acc);
                    }
                    List<double> ybCheck = new List<double>();
                    ybviewmodel.Select(o => o.value).ToList().ForEach(o => { ybCheck.Add(int.Parse(o)); });
                    string msg = "檢查上期餘額平衡:" + ybCheck.Sum().ToString() + Environment.NewLine;
                    double bookcomputeget = bookcomputes.Select(o => o.get).Sum();
                    double bookcomputelend = bookcomputes.Select(o => o.lend).Sum();
                    msg += "平衡小計 借:" + bookcomputeget.ToString() + ",貸:" + bookcomputelend.ToString() + Environment.NewLine;
                    bookcomputeget = bookcomputes.Select(o => o.periodget).Sum();
                    bookcomputelend = bookcomputes.Select(o => o.periodlend).Sum();
                    msg += "平衡結餘 借:" + bookcomputeget.ToString() + ",貸:" + bookcomputelend.ToString() + Environment.NewLine;
                    bookcomputeget = bookcomputes.Where(o => o.booktype == 1).Select(o => o.total).Sum();
                    bookcomputelend = bookcomputes.Where(o => o.booktype == 2).Select(o => o.total).Sum();
                    msg += "平衡總計結餘 借:" + bookcomputeget.ToString() + ",貸:" + bookcomputelend.ToString() + Environment.NewLine;
                    string notecontent = "";
                    foreach (var item in bookcomputes)
                    {
                        NextContentMoney = SetNextMoneyContent(NextContentMoney, item);
                        notecontent += "get:" + item.periodget.ToString() + ",lend:" + item.periodlend.ToString() + "," + (item.periodget - item.periodlend).ToString() + "," + item.total.ToString() + Environment.NewLine;
                    }
                    //以上資料尚不顯示 
                    //File.WriteAllText(aiinfopath + year + id + "DetailToCheck" + aiextension, notecontent, Encoding.UTF8);
                    //File.WriteAllText(aiinfopath + year + id + "Moneys" + aiextension, msg, Encoding.UTF8);
                    //File.WriteAllText(aiinfopath + year + id + "NextAmount" + aiextension, NextContentMoney, Encoding.UTF8);
                    File.WriteAllText(pathmodel.aiinfopath + year + id + (no + 1) + aiextension, sb.ToString(), Encoding.UTF8);
                }
                else if (no == 2)
                {
                    sb.Append(accdocTitle01 + Environment.NewLine);
                    string pretaxno = "";
                    var lst = bookconvertGoal.OrderBy(o => o.TaxNo).ThenBy(o => o.datadate).ThenBy(o => o.BookNo);
                    //*產生年度日記
                    var lst02 = bookconvertGoal.OrderBy(o => o.datadate).ThenBy(o => o.BookNo);
                    StringBuilder sb02 = new StringBuilder();
                    count = 0;
                    foreach (var i in lst02)
                    {
                        SetDataToDocument(false, true, sb02, i, i.amountType.ToString(), 1, 1);
                        count++;
                    }
                    File.WriteAllText(pathmodel.aiinfopath + year + id + (no - 1) + "__yearbooks" + aiextension, sb02.ToString());
                    //*產生年度日記
                    var NoDataAcc = bookcomputes.Where(o => o.durationNodata == true).ToList();
                    count = 1;
                    foreach (var i in lst)
                    {
                        if (pretaxno != i.TaxNo && count != 1)
                        {
                            count = 1;
                            var accval = bookcomputes.Where(o => o.taxno == pretaxno).FirstOrDefault();
                            if (accval != null)
                            {
                                SetNoAccToDocument(sb, accval, 1);
                            }
                        }
                        SetDataToDocument(false, true, sb, i, i.amountType.ToString(), count, 1);
                        pretaxno = i.TaxNo;
                        count++;
                    }

                    count = 1;
                    var accval02 = bookcomputes.Where(o => o.taxno == pretaxno).FirstOrDefault();
                    if (accval02 != null)
                    {
                        SetNoAccToDocument(sb, accval02, 1);
                    }
                    foreach (var item in NoDataAcc)
                    {
                        SetNoAccToDocument(sb, item, 6);
                    }
                    //lst02
                    File.WriteAllText(pathmodel.aiinfopath + year + id + (no - 1) + aiextension, sb.ToString(), Encoding.UTF8);
                }
            }
        }


        private Dictionary<int, double> GetAmountGroup(YearBeginViewModel vals)
        {
            Dictionary<int, double> result = new Dictionary<int, double>();
            if (Math.Sign(double.Parse(vals.value)) > 0)
            {
                result.Add(1, double.Parse(vals.value));
            }
            else
                result.Add(2, double.Parse(vals.value));
            return result;
        }
        private void btnExportAccounting_Click(object sender, EventArgs e)
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    FinancialRptVModel financial = new FinancialRptVModel();
                    List<JINSHINFINANCE035> data01 = financial.CheckVerialOK(entity.JINSHINFINANCE035.Where(o => o.Cost_Date.Value.Year == AccountingReso.yearnow).ToList());
                    bool checkresult = data01.Count() > 0;
                    bool checkverify = accounting.TrailVerify == "1" ? true : false;
                    if (checkresult && chExportVerify.Checked == false && (!checkverify))
                    {
                        lstAccounting.Items.Add("CheckVerial Not OK,verify accounting data finish first");
                        return;
                    }
                    else
                    {
                        GetCompareDataFromDB();
                    }
                }
            }
        }

        /// <summary>
        /// 1為明細
        /// 6為總帳
        /// </summary>
        /// <param name="sb"></param>
        /// <param name="accval"></param>
        /// <param name="acctype"></param>
        private static void SetNoAccToDocument(StringBuilder sb, BookCompute accval, int acctype)
        {
            if (acctype == 1)
            {
                sb.Append(",,,,," + accval.booktype + "," + GetDocAmount(accval.get) + "," + GetDocAmount(accval.lend) + Environment.NewLine);
                if (accval.booktype == 1)
                    sb.Append(",,,,," + accval.booktype + "," + GetDocAmount(accval.periodget) + "," + GetDocAmount(accval.lend) + ",借," + accval.total + Environment.NewLine);
                else
                    sb.Append(",,,,," + accval.booktype + "," + GetDocAmount(accval.get) + "," + GetDocAmount(accval.periodlend) + ",貸," + accval.total * -1 + Environment.NewLine);
            }
            else if (acctype == 6)
            {
                if (accval.booktype == 1)
                    sb.Append("1," + accval.taxno + ",,,," + accval.booktype.ToString() + "," + GetDocAmount(accval.periodget).ToString() + ",,借," + (accval.periodget).ToString() + Environment.NewLine);
                else
                    sb.Append("1," + accval.taxno + ",,,," + accval.booktype.ToString() + ",," + GetDocAmount(accval.periodlend).ToString() + ",貸," + (accval.periodlend).ToString() + Environment.NewLine);
            }
        }
        public Dictionary<int, double> GetLastMoney(string value)
        {
            Dictionary<int, double> result = default(Dictionary<int, double>);
            var data = ybviewmodel.Where(o => o.key == value).ToList();
            if (data.Count > 0)
            {
                var vals = data.First();
                result = GetAmountGroup(vals);
                vals.checkvalue = true;
            }
            else
            {
                result = new Dictionary<int, double>();
                result.Add(1, 0);
            }
            return result;
        }

        private void SetDataToDocument(bool rbopt01, bool rbopt02, StringBuilder sb, BookConvert2 i, string amountType, int count, int doctype)
        {
            if (rbopt01)
            {
                sb.Append(count.ToString() + "," + i.Rightvalues + "," + amountType + "," + i.amount + Environment.NewLine);
            }
            else if (rbopt02)
            {
                string datanum = count == 0 ? "" : count.ToString();
                if (doctype == 1)
                {
                    if (amountType == "1")
                        sb.Append(datanum + "," + i.Rightvalues + "," + amountType + "," + i.amount + "," + Environment.NewLine);
                    else if (amountType == "2")
                        sb.Append(datanum + "," + i.Rightvalues + "," + amountType + ",," + i.amount + Environment.NewLine);

                }
                else if (doctype == 6)
                    if (amountType == "1")
                        sb.Append(datanum + "," + i.Rightvalues + "," + amountType + "," + i.amount + ",,借," + i.amount + Environment.NewLine);
                    else if (amountType == "2")
                        sb.Append(datanum + "," + i.Rightvalues + "," + amountType + ",," + i.amount + ",貸," + i.amount + Environment.NewLine);
            }
        }

        private void SetDataToTotalDocument(StringBuilder sb, BookConvert2 i, string amountType, int count, double val)
        {
            string datanum = count == 0 ? "" : count.ToString();
            if (amountType == "1")
                sb.Append(datanum + "," + i.Rightvalues + "," + amountType + "," + val.ToString() + ",,借," + val.ToString() + Environment.NewLine);
            else
                sb.Append(datanum + "," + i.Rightvalues + "," + amountType + ",," + val.ToString() + ",貸," + val.ToString() + Environment.NewLine);
        }

        private static string SetNextMoneyContent(string NextContentMoney, BookCompute s)
        {
            if (s.booktype == 1)
            {
                NextContentMoney += s.taxno + "," + s.total.ToString() + Environment.NewLine;
            }
            else
                NextContentMoney += s.taxno + "," + s.total.ToString() + Environment.NewLine;
            return NextContentMoney;
        }

        private static string GetDocAmount(double val)
        {
            return val == 0 ? "" : val.ToString();
        }

        private void FrmSysBookExport_ResizeBegin(object sender, EventArgs e)
        {
          
        }

        private void FrmSysBookExport_Resize(object sender, EventArgs e)
        {
          
        }

        private void FrmSysBookExport_Shown(object sender, EventArgs e)
        {
            SysRescControlVModel.SetFixedWindow(this);
        }

        private void FrmSysBookExport_SizeChanged(object sender, EventArgs e)
        {
          
        }
    }
}
