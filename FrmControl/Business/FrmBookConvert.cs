#define DEBUG
using JINSHIN.Finance.AccountSystem;
using FinanceAccountProgram.Models;
using FinanceAccountProgram.Models.Config;
using JINSHIN.Finance.AccountSystem.Resources;
using JINSHIN.FinanceAccounting.DB;
using FinanceAccountProgram.VModel;
using FinanceAccountProgram.VModel.Accounts;

using FinanceAccountProgram.VModel.Conrols.GridView;
using FinanceAccountProgram.VModel.TPViewer;
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
using JINSHIN.FinanceAccount.Libary.Config;
using JINSHIN.FinanceAccount.Libary.Models;
using JINSHIN.FinanceAccount.Libary.VModels;
using JINSHIN.FinanceAccounting.DB.VModel;
using JINSHIN.FinanceAccount.Libary.VModels.AccControl;

namespace FinanceAccountProgram.FrmControl
{
    public partial class FrmBookConvert : Form
    {
        List<BookConvert2> bookconvert = new List<BookConvert2>();   
        List<string> ConvertMap = new List<string>();
        private List<string> compareDesc = new List<string>() { "Double", "noData" };
        public string keysfile = "106AccountMapTable.csv";
        private string CovertFormatStr = "會計代碼:{0},會計項目:{1},轉換代碼:{2},轉換名稱{3}";
        string exportdocTitle = "營利事業統一編號,會計編碼,日期,傳票編號,摘要,種類,借,貸";
        public AccountRemainData acountremain { get; set; }
        List<YearBeginViewModel> ybviewmodel = new List<YearBeginViewModel>();
        public AccInvoiceBookVModel AInvoiceBookModel { get; set; }
        List<BookConvert2> bookconvertGoal = new List<BookConvert2>();
        List<BookCompute> bookcomputes = new List<BookCompute>();
        List<string> fullfilesAno = new List<string>();
        List<JINSHINFINANCE032> dbbooks = new List<JINSHINFINANCE032>();
        string accdocTitle = "序號,會計編碼,日期,傳票編號,摘要,種類,借,貸,借/貸,餘額";
        private string SourceCompareRpt = "testReport.txt";
        public string reportfilename = "testAllReport.txt";
        public string DATANOTFOUND = "dataNotFound!";
        public DBClassCtl dbclassctl { get; set; }
        public PathModel pathmodel { get; set; }

        public string filepath = "";
        public string data2Path = "";
        public string data3Path = "";
        private string datapath01 = @"\Data\";
        private string datapath02 = @"\Data2\";
        private string datapath03 = @"\Data3\";
        public FrmBookConvert()
        {
            InitializeComponent();
            dgTabView.Font = new System.Drawing.Font(DataControl.DataGridFont, Convert.ToInt32(DataControl.DataGridFontSize));

            pathmodel = new PathModel();
            acountremain = new AccountRemainData();
            AInvoiceBookModel = new AccInvoiceBookVModel();
            dbclassctl = new DBClassCtl();            
            this.AutoScaleMode = AutoScaleMode.None;
            this.AutoSize = false;
            this.MaximizeBox = true;
            using (FormControlVModel ctlmodel = new FormControlVModel())
            {
                ctlmodel.ControlResolution(this);
            }
            SysRescControlVModel.Let1366ToSuitWidth(this);
        }


        public Dictionary<string, string> GetData(string value)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            string[] keys = File.ReadAllLines(pathmodel.path + @"\MetaData\" + keysfile);
            var data = keys.Where(o => o.IndexOf(value) > -1).ToList();
            if (data.Count > 0)
            {
                if (data.Count > 1)
                {
                    result.Add(compareDesc[0], compareDesc[0]);
                }
                else
                {
                    string[] vals = data.First().Split(',');
                    result.Add(vals[0], vals[1]);
                }
            }
            else
            {
                result.Add(compareDesc[1], compareDesc[1]);
            }
            return result;
        }


        private List<string> CheckLendOrGet(string get, string lend)
        {
            List<string> result = new List<string>();
            if (string.IsNullOrEmpty(lend.Trim()) == false && string.IsNullOrEmpty(get))
            {
                result.Add("2");
                result.Add(lend.Trim());
                return result;
            }
            else if (string.IsNullOrEmpty(get.Trim()) == false && string.IsNullOrEmpty(lend))
            {
                result.Add("1");
                result.Add(get.Trim());
            }
            return result;
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

        public List<BookConvert2> GetBookToCountryFormatData()
        {
            string content = "";
            StringBuilder sb = new StringBuilder();
            bookconvert.Clear();
            List<string> lendorget = new List<string>();
            Dictionary<string, string> countryTax = new Dictionary<string, string>();
            DateTime dtime;
            List<string> datatemp;
            int index = 0;
            try
            {
                bookconvert.Clear();
                foreach (var item in fullfilesAno)
                {
                    string[] data = File.ReadAllLines(item);
                    datatemp = data.ToList();
                    for (int i = 0; i < 4; i++)
                    {
                        datatemp.RemoveAt(0);
                    }
                    data = datatemp.ToArray();
                    ConvertMap.Clear();
                    foreach (var i in data)
                    {
                        string[] ims = i.Split(',');
                        countryTax.Clear();
                        countryTax = GetData(ims[3]);
                        ConvertMap.Add(string.Format(CovertFormatStr, ims[4], ims[3], countryTax.Keys.First(), countryTax.Values.First()));
                        lendorget.Clear();
                        lendorget = CheckLendOrGet(ims[5], ims[6]);
                        BookConvert2 bookcnt = new BookConvert2();
                        bookcnt.BookNo = ims[3];
                        DateTime.TryParse(ims[2], out dtime);
                        bookcnt.datadate = dtime;
                        //bookcnt.TaxNo = ims[4];
                        bookcnt.amountType = int.Parse(lendorget[0]);
                        content = string.Format("{0},{1},", pathmodel.id, pathmodel.year);
                        bookcnt.Leftvalues = content;
                        bookcnt.Rightvalues = string.Format("{0},{1},{2},{3},{4},{5}", countryTax.Keys.First(), ims[3], ims[4], ims[1], ims[2], ims[5]);
                        bookcnt.amount = double.Parse(lendorget[1]);
                        bookconvert.Add(bookcnt);
                        index++;
                    }
                    content = "";
                    foreach (var i in ConvertMap)
                    {
                        content += i + Environment.NewLine;
                    }
                    //to save log and new file
                    File.WriteAllText(pathmodel.aiinfopath + pathmodel.year + pathmodel.id + pathmodel.maptitle + index + pathmodel.compareextension, content);
                    index++;
                }

                for (int no = 0; no < 3; no++)
                {
                    sb.Clear();
                    sb.Append(exportdocTitle + Environment.NewLine);
                    if (no == 0)
                    {
                        foreach (var i in bookconvert)
                        {
                            sb.Append(i.Leftvalues + no.ToString() + i.Rightvalues + "," + i.amountType + "," + i.amount + Environment.NewLine);
                        }
                        File.WriteAllText(pathmodel.aiinfopath + pathmodel.year + pathmodel.id + pathmodel.taxFileStr + no + pathmodel.aiextension, sb.ToString());
                    }
                    else if (no == 1)
                    {
                        var lst = bookconvert.OrderBy(o => o.TaxNo).ThenBy(o => o.datadate).ThenBy(o => o.BookNo);
                        foreach (var i in lst)
                        {
                            sb.Append(i.Leftvalues + no.ToString() + i.Rightvalues + "," + i.amountType + "," + i.amount.ToString() + Environment.NewLine);
                        }
                        File.WriteAllText(pathmodel.aiinfopath + pathmodel.year + pathmodel.id + pathmodel.taxFileStr + no + pathmodel.aiextension, sb.ToString());
                    }
                    else if (no == 2)
                    {
                        ybviewmodel.Clear();
                        var lst = bookconvert.GroupBy(o => o.TaxNo);
                        double lend = 0; double get = 0;
                        double computevalue = 0;
                        string[] moneydata = File.ReadAllLines(pathmodel.moneypath + pathmodel.moneyfile);
                        StringBuilder sa = new StringBuilder();
                        sa.Append(sb.ToString());
                        Dictionary<int, double> YearOpenAmount = new Dictionary<int, double>();
                        ybviewmodel = acountremain.SetMoneyData();
                        foreach (var s in lst)
                        {
                            YearOpenAmount.Clear();
                            YearOpenAmount = GetLastMoney(s.First().TaxNo);
                            lend = s.Where(o => o.amountType == 2).Sum(o => o.amount);
                            get = s.Where(o => o.amountType == 1).Sum(o => o.amount);
                            //check the reason and do
                            if (YearOpenAmount.ContainsKey(1))
                            {
                                get = get + YearOpenAmount.First().Value;
                            }
                            else
                                lend = lend + Math.Abs(YearOpenAmount.First().Value);
                            computevalue = get - lend;
                            if (computevalue >= 0)
                            {
                                sb.Append(s.First().Leftvalues + no.ToString() + s.First().Rightvalues + ",1," + computevalue.ToString() + Environment.NewLine);
                            }
                            else
                            {
                                sb.Append(s.First().Leftvalues + no.ToString() + s.First().Rightvalues + ",2," + Math.Abs(computevalue).ToString() + Environment.NewLine);
                            }
                        }
                        var BeginYearData = ybviewmodel.Where(o => o.checkvalue == false).ToList();
                        Dictionary<int, double> amountgp = default(Dictionary<int, double>);
                        foreach (var item in BeginYearData)
                        {
                            amountgp = GetAmountGroup(item);
                            //*待解譯轉換版本*//
                            sb.Append(string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10}", pathmodel.id, pathmodel.year, "", "", "", item.key, "1070101", "None", "期初資訊", amountgp.First().Key, amountgp.First().Value) + Environment.NewLine);
                        }
                        File.WriteAllText(pathmodel.aiinfopath + pathmodel.year + pathmodel.id + pathmodel.taxFileStr + no + pathmodel.aiextension, sb.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                string exceptionstr = ex.ToString();
            }
            return bookconvert;
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

        private void btnGenrateData_Click(object sender, EventArgs e)
        {
            try
            {
                DirectoryInfo di = new DirectoryInfo(pathmodel.aiinfopath);
                foreach (var ei in di.GetFiles())
                {
                    File.Delete(ei.FullName);
                }
                //System.Threading.Thread.Sleep(300);
                bookconvert = GetBookToCountryFormatData();
                AccExportType savedatatype = AccExportType.FILEOUTPUT;
                if (radioDB.Checked)
                    savedatatype = AccExportType.DBOUTPUT;
                else if (radioFile.Checked)
                    savedatatype = AccExportType.FILEOUTPUT;
                switch (savedatatype)
                {
                    case AccExportType.DBOUTPUT:
                        {
                            if (chUpdateDBResource.Checked)
                            {
                                dbclassctl.ClearInvoice_Books(AccountingReso.yearnow);
                            }
                            var data01 = SaveToDbBooks001();
                            var data02 = AInvoiceBookModel.SaveToInvoiceDBBook();
                            string msg01 = data01.Result;
                            string msg02 = data02.Result;
                            lstMsg.Items.Add(msg02);
                        }
                        break;
                    case AccExportType.FILEOUTPUT:
                        {
                            bookconvertGoal = GetCompareData();
                            StringBuilder testReport = new StringBuilder();
                            foreach (var item in bookconvert)
                            {
                                var data = bookconvertGoal.Where(o => o.BookNo == item.BookNo && o.TaxNo == item.TaxNo).FirstOrDefault();
                                WriteToFile(testReport, item, data);
                            }
                            File.WriteAllText(pathmodel.aiinfopath + SourceCompareRpt, testReport.ToString());
                            //aiinfo report
                            //ExportInfoReport(testReport);
                        }
                        break;
                    default:
                        {

                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                string str = ex.ToString();
                //throw;
            }

        }




        private void SetCostItemData(JINSHINFINANCE032 cost, BookConvert2 items)
        {
            //cost.Acc_Desc = items.
            //cost.Acc_ID = items.Acc_ID;
            //cost.Acc_No = items.Acc_No;
            //cost.Amount = items.Amount;
            //cost.Buy_ID = data.Buy_ID;
            //cost.Sell_ID = data.Sell_ID;
            //cost.Cost_Date = data.Acc_Date;
            //cost.Invoice_No = data.Invoice_No;
            //cost.Cost_M = data.Acc_M;
            //cost.CreateTime = DateTime.Now;
         //   cost.SN = SN;
        //    cost.Buy_ID = companyId;
         //   cost.Rec_Type = data.Rec_Type;
          //  cost.DataType = Convert.ToByte(items.amountType.Value);
            //cost.HasTax = data.Invoice_No != null;
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
                            var cnt = list.Where(o => o.Acc_ID == "6111" && o.DataType == 1).Count();
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
                    sb.Append(accdocTitle + Environment.NewLine);
                    if (no == 0)
                    {
                        count = 1;
                        bookconvertGoal = bookconvertGoal.OrderBy(o => o.datadate).ToList();
                        foreach (var i in bookconvertGoal)
                        {
                            SetDataToDocument(false, true, sb, i, i.amountType.ToString(), count, 1);
                            count++;
                        }
                        File.WriteAllText(pathmodel.aiinfopath + pathmodel.year + pathmodel.id + no + pathmodel.aiextension, sb.ToString(), Encoding.UTF8);
                    }
                    //selectmany modify
                    else if (no == 1)
                    {
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
                        File.WriteAllText(pathmodel.aiinfopath + pathmodel.year + pathmodel.id + "DetailToCheck" + pathmodel.aiextension, notecontent, Encoding.UTF8);
                        File.WriteAllText(pathmodel.aiinfopath + pathmodel.year + pathmodel.id + "Moneys" + pathmodel.aiextension, msg, Encoding.UTF8);
                        File.WriteAllText(pathmodel.aiinfopath + pathmodel.year + pathmodel.id + "NextAmount" + pathmodel.aiextension, NextContentMoney, Encoding.UTF8);
                        File.WriteAllText(pathmodel.aiinfopath + pathmodel.year + pathmodel.id + (no + 1) + pathmodel.aiextension, sb.ToString(), Encoding.UTF8);
                    }
                    else if (no == 2)
                    {
                        string pretaxno = "";
                        var lst = bookconvertGoal.OrderBy(o => o.TaxNo).ThenBy(o => o.datadate).ThenBy(o => o.BookNo);
                        //*產生年度日記
                        var lst02 = bookconvertGoal.OrderBy(o => o.datadate).ThenBy(o => o.BookNo);
                        StringBuilder sb02 = new StringBuilder();
                        count = 0;
                        foreach (var i in lst02)
                        {
                            SetDataToDocument(rboption01.Checked, rboptions02.Checked, sb02, i, i.amountType.ToString(), 1, 1);
                            count++;
                        }
                        File.WriteAllText(pathmodel.aiinfopath + pathmodel.year + pathmodel.id + (no - 1) + "__yearbooks" + pathmodel.aiextension, sb02.ToString());
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
                            SetDataToDocument(rboption01.Checked, rboptions02.Checked, sb, i, i.amountType.ToString(), count, 1);
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

                        File.WriteAllText(pathmodel.aiinfopath + pathmodel.year + pathmodel.id + (no - 1) + pathmodel.aiextension, sb.ToString(), Encoding.UTF8);
                    }
                }
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


            public void ExportInfoReport(StringBuilder rpt)
            {
                string dataTotalComputePath = pathmodel.aiinfopath + pathmodel.intelligenceComparesrc;
                string dataTotalComputePath2 = pathmodel.aiinfopath + pathmodel.intelligenceComparedst;
                string[] data01 = File.ReadAllLines(dataTotalComputePath);
                string[] data02 = File.ReadAllLines(dataTotalComputePath2);
                List<BookConvert2> bookconvertTaxTtl = new List<BookConvert2>();
                List<string> money = new List<string>();
                for (int i = 1; i < data02.Length; i++)
                {
                    money.Clear();
                    BookConvert2 bookdata = new BookConvert2();
                    string[] values = data02[i].Split(',');
                    bookdata.BookNo = values[3];
                    bookdata.TaxNo = values[1];
                    bookdata.amountType = int.Parse(values[5]);
                    SetAllReportSrcData(bookdata, values);
                    bookconvertTaxTtl.Add(bookdata);
                }

                int amtype = 0;
                double amvalue = 0;
                rpt.Clear();
                for (int i = 1; i < data01.Length; i++)
                {
                    string[] data01val = data01[i].Split(',');
                    amtype = int.Parse(data01val[9]);
                    amvalue = double.Parse(data01val[10]);
                    var chkval = bookconvertTaxTtl.Where(o => o.TaxNo == data01val[5] && o.amountType == amtype && o.amount == amvalue);
                    if (chkval.Count() == 0)
                    {
                        var chkdata = bookconvertTaxTtl.Where(o => o.TaxNo == data01val[5]).FirstOrDefault();
                        rpt.Append(string.Format("{0},{1},{2},{3}", data01val[5], data01val[7], data01val[9], data01val[10]) + Environment.NewLine);
                        if (chkdata == null)
                        {
                            rpt.Append(DATANOTFOUND + Environment.NewLine);
                            rpt.Append(" = = = == = = == = = = == = =" + Environment.NewLine);
                        }
                        else
                            rpt.Append(string.Format("{0},{1},{2},{3}", chkdata.BookNo, chkdata.TaxNo, chkdata.amountType.ToString(), chkdata.amount.ToString()) + Environment.NewLine);
                    }

                }
                File.WriteAllText(pathmodel.aiinfopath + reportfilename, rpt.ToString());
                //data01[5],data01[7],data01[9],data01[10]
                //data02[2],data02[4],data02[6],data02[7]
                //string title = "營利事業統一編號,年度,類別,會計項目代碼,會計項目,會計編碼,日期,傳票編號,摘要,借貸註記,借方/貸方金額" + Environment.NewLine;
                //string compareTitle = "營利事業統一編號,年度,會計編碼,日期,傳票編號,摘要,借,貸";
            }


            /// <summary>
            /// set the txt file named all reports source data
            /// </summary>
            /// <param name="bookdata"></param>
            /// <param name="values"></param>
            private void SetAllReportSrcData(BookConvert2 bookdata, string[] values)
            {
                if (rboptions02.Checked)
                {
                    if (bookdata.amountType == 2)
                        bookdata.amount = double.Parse(values[7]);
                    else
                        bookdata.amount = double.Parse(values[6]);
                }
                else
                    bookdata.amount = double.Parse(values[6]);
            }
            private static string GetDocAmount(double val)
            {
                return val == 0 ? "" : val.ToString();
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

            private void WriteToFile(StringBuilder testReport, BookConvert2 item, BookConvert2 data)
            {
                if (data == null)
                {
                    testReport.Append(string.Format("{0},{1},{2},{3}", item.BookNo, item.TaxNo, item.amountType, item.amount) + Environment.NewLine);
                }
                else if (data != null)
                {
                    if (data.amountType != item.amountType || data.amount != item.amount)
                    {
                        testReport.Append(string.Format("{0},{1},{2},{3}", item.BookNo, item.TaxNo, item.amountType, item.amount) + Environment.NewLine);
                        testReport.Append(string.Format("{0},{1},{2},{3}", data.BookNo, data.TaxNo, data.amountType, data.amount) + Environment.NewLine);
                    }
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

            /// <summary>
            /// no 0 日記 org AccBook Export
            /// no 1 總帳
            /// no 2 明細
            /// </summary>
            /// <returns></returns>
            public List<BookConvert2> GetCompareData()
            {
                bookcomputes.Clear();
                List<string> lendorget = new List<string>();
                DateTime dtime;
                List<string> datatemp;
                int count = 0;
                try
                {
                    bookconvertGoal.Clear();
                    foreach (var item in fullfilesAno)
                    {
                        string[] data = File.ReadAllLines(item, Encoding.GetEncoding(950));
                        datatemp = data.ToList();
                        for (int i = 0; i < 4; i++)
                        {
                            datatemp.RemoveAt(0);
                        }
                        data = datatemp.ToArray();
                        count = 0;
                        foreach (var i in data)
                        {
                            //  int ii = 57;
                            count++;
                            string[] ims = i.Split(',');
                            lendorget.Clear();
                            lendorget = CheckLendOrGet(ims[5], ims[6]);
                            BookConvert2 bookcnt = new BookConvert2();
                            bookcnt.BookNo = ims[3];
                            DateTime.TryParse(ims[2], out dtime);
                            bookcnt.datadate = dtime;
                            bookcnt.TaxNo = ims[1];
                            bookcnt.amountType = int.Parse(lendorget[0]);
                            bookcnt.Rightvalues = string.Format("{0},{1},{2},{3}", ims[1], ims[2], ims[3], ims[4]);
                            bookcnt.amount = double.Parse(lendorget[1]);
                            bookconvertGoal.Add(bookcnt);
                        }
                    }
                    dbbooks.Clear();
                    ProduceAccountingDataFile();
                }
                catch (Exception ex)
                {
                    string str = ex.ToString();
                }
                return bookconvertGoal;
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



            /// <summary>
            /// Cost Acc Book
            /// </summary>
            public async Task<string> SaveToDbBooks001()
            {
                string invno = "";
                string acc_id = "";
                string rs = "";
                List<string> datatemp;
                List<string> lendorget = new List<string>();
                List<JINSHINFINANCE032> accbooks = new List<JINSHINFINANCE032>();
                int SN = 1;
                int count = 0;
                int itemsn = 0;
                try
                {
                       
                     foreach (var item in fullfilesAno)
                    {
                    //File.ReadAllLines(item, Encoding.u
               //         string[] data = File.ReadAllLines(item, Encoding.GetEncoding(950));
                        string[] data = File.ReadAllLines(item, new UTF8Encoding());
                        datatemp = data.ToList();
                        for (int i = 0; i < 4; i++)
                            datatemp.RemoveAt(0);
                        int y = 0, m = 0, d = 0;
                        count += datatemp.Count();
                        foreach (var i in datatemp)
                        {
                            string[] ims = i.Split(',');
                            lendorget.Clear();
                            lendorget = CheckLendOrGet(ims[5], ims[6]);
                            JINSHINFINANCE032 book = new JINSHINFINANCE032();
                            //  book.SN = SN;
                            book.DataType = int.Parse(lendorget[0]);
                            book.Amount = Convert.ToDecimal(lendorget[1]);
                            book.Acc_No = ims[3];
                            book.Acc_ID = ims[1];
                            y = int.Parse(ims[2].Substring(0, 3));
                            m = int.Parse(ims[2].Substring(3, 2));
                            d = int.Parse(ims[2].Substring(5, 2));
                            book.Acc_M = Convert.ToByte(m);
                            book.Acc_Date = new DateTime(y + 1911, m, d);
                            book.Acc_Desc = ims[4];
                            book.CreateTime = DateTime.Now;
                            SN++;
                            accbooks.Add(book);
                        }
                    }
                    lstMsg.Items.Add("資料取得共" + fullfilesAno.Count.ToString() + "筆,轉換資料共" + accbooks.Count.ToString() + "筆");
                    if (chUpdateDBResource.Checked)
                    {
                        var months = accbooks.GroupBy(i => i.Acc_M);
                        using (AccountEntityDB content = new AccountEntityDB())
                        {
                            using (AccountEntities entity = content.GetEntity())
                            {
                                foreach (var item in months)
                                {
                                    int fmonth = Convert.ToInt32(item.FirstOrDefault().Acc_M);
                                    int fyear = item.FirstOrDefault().Acc_Date.Value.Year;
                                    var lst = entity.JINSHINFINANCE032.Where(v => v.Acc_Date.Value.Year == fyear && v.Acc_Date.Value.Month == fmonth).ToList();
                                    entity.JINSHINFINANCE032.RemoveRange(lst);
                                    //entity.JINSHINFINANCE032.AddRange(accbooks);
                                    entity.SaveChanges();
                                }
                            }
                        }
                       }

                        var contents = accbooks.OrderBy(o => o.Acc_No).GroupBy(o => o.Acc_No).ToList();
                //chUpdateDBResource
                        using (AccountEntityDB content = new AccountEntityDB())
                        {
                            using (AccountEntities entity = content.GetEntity())
                            {
                                foreach (var item in contents)
                                {
                                    itemsn = 1;
                                    foreach (var data in item)
                                    {
                                        invno = data.Acc_No;
                                        acc_id = data.Acc_ID;
                                        data.Item = itemsn;
                                        itemsn++;
                                        entity.JINSHINFINANCE032.Add(data);
                                    //    entity.SaveChanges();
                                    }
                                }
                                entity.SaveChanges();
                            }
                        }
                }
                catch (Exception ex)
                {
                  string str = ex.ToString();
                }
                return rs;
            }

        private void btnView_Click(object sender, EventArgs e)
        {
            using (DBClassCtl dbclass = new DBClassCtl())
            {
                int datacompareType = 0;
                if (radioBook.Checked)
                    datacompareType = 1;
                else if (radioBookItem.Checked)
                    datacompareType = 2;

                List<AccBookModelView> values = 
                    dbclass.CompareSaveToDB(pathmodel.comparepath01, datacompareType);
                if (values.Count == 0)
                {
                    lblViewStatus.Text = FormCaption.BookConvertCpation01;
                    dgTabView.DataSource = null;
                }
                else
                {
                    dgTabView.DataSource = values;
                    DiffCompareGridView diffgridview = new DiffCompareGridView();
                    diffgridview.SetAccConfirmGridColumns(dgTabView);
                    diffgridview.Dispose();
                    dgTabView.Refresh();
                }
            }
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            InvoiceVModel invmodel = new InvoiceVModel();
            invmodel.BalanceInvoiceBook();
            btnView_Click(new object(), null);
        }

        private void FrmBookConvert_Load(object sender, EventArgs e)
        {
         
        }

        private void Init()
        {
            DirectoryInfo fls = new DirectoryInfo(pathmodel.filepath);
            fullfilesAno.Clear();
            Filelst.Items.Clear();
            Filelst2.Items.Clear();
            Filelst3.Items.Clear();
            if (Directory.Exists(fls.FullName))
            {
                foreach (var item in fls.GetFiles())
                {
                    fullfilesAno.Add(item.FullName);
                    Filelst.Items.Add(item.Name);
                }
            }
            SetDataFromPath(pathmodel.data2Path, fullfilesAno, Filelst2);
            SetDataFromPath(pathmodel.data3Path, AInvoiceBookModel.Invfullfiles, Filelst3);
        }

        private void SetDataFromPath(string path, List<string> filelist, ListBox listbox)
        {
            filelist.Clear();
            DirectoryInfo fls2 = new DirectoryInfo(path);
            foreach (var i in fls2.GetFiles())
            {
                filelist.Add(i.FullName);
                listbox.Items.Add(i.Name);
            }
        }

        private void FrmBookConvert_Shown(object sender, EventArgs e)
        {
            Init();
          //  tabBookExport.TabPages.RemoveAt(1);
            SysRescControlVModel.SetFixedWindow(this);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            InitFilesColnfig();
        }

        private void InitFilesColnfig()
        {                           
            string path = Environment.CurrentDirectory;
            DirectoryInfo di = new DirectoryInfo(path);
#if (DEBUG)
            filepath = di.Parent.Parent.FullName + datapath01;
            data2Path = di.Parent.Parent.FullName + datapath02;
            data3Path = di.Parent.Parent.FullName + datapath03;
#else
            filepath = di.Parent.FullName + datapath01;
            data2Path = di.Parent.FullName + datapath02;
            data3Path = di.Parent.FullName + datapath03;
#endif
            DirectoryInfo fls = new DirectoryInfo(filepath);
            fullfilesAno.Clear();
            Filelst.Items.Clear();
            Filelst2.Items.Clear();
            Filelst3.Items.Clear();
            foreach (var item in fls.GetFiles())
            {
                fullfilesAno.Add(item.FullName);
                Filelst.Items.Add(item.Name);
            }
            SetDataFromPath(data2Path, fullfilesAno, Filelst2);
            SetDataFromPath(data3Path, AInvoiceBookModel.Invfullfiles, Filelst3);
        }

        private void tabBookExport_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((sender as TabControl).SelectedIndex)
            {
                case 1: {
                        lblYearTitle.Text =(AccountingReso.yearnow - 1911) + "年度資料";
                    }
                    break;
                default:
                    break;
            }
        }

        private void Filelst2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gbOPtionFile_Enter(object sender, EventArgs e)
        {

        }

        private void chUpdateDBResource_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lstMsg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabAccountExport_Click(object sender, EventArgs e)
        {

        }
    }
}
