//#define DEBUG
using FinanceAccountProgram.Models;
using FinanceAccountProgram.Models.AccountingData;
using FinanceAccountProgram.Models.AddQueryDataForm;
using FinanceAccountProgram.Models.Assets;
using FinanceAccountProgram.Models.Config;
using FinanceAccountProgram.Models.Config.UpdataeForm;
using FinanceAccountProgram.Models.DataGridViewModel.Financial;
using FinanceAccountProgram.Models.FormMaintain;
using FinanceAccountProgram.Models.UControl;
using FinanceAccountProgram.Models.UpdateForm;
using FinanceAccountProgram.Models.VerifyModel;
using JINSHIN.Finance.AccountSystem.Resources;
using FinanceAccountProgram.ViewFrm;
using FinanceAccountProgram.VModel;
using FinanceAccountProgram.VModel.Accounts;
using FinanceAccountProgram.VModel.AddQueryDataForm;
using FinanceAccountProgram.VModel.AddQueryForm;
using FinanceAccountProgram.VModel.Business;
using FinanceAccountProgram.VModel.Conrols;
using FinanceAccountProgram.VModel.Conrols.GridView;
using FinanceAccountProgram.VModel.Conrols.Model;
using FinanceAccountProgram.VModel.Conrols.QueryModel;
using FinanceAccountProgram.VModel.Conrols.VModel;
using FinanceAccountProgram.VModel.FormMaintain;
using FinanceAccountProgram.VModel.Money;
using FinanceAccountProgram.VModel.PlayerRound;
using FinanceAccountProgram.VModel.TPViewer;
using FinanceAccountProgram.VModel.UsrControl;
using JINSHIN.BUSINESS.LIBARY.Models.UIControls;
using JINSHIN.BUSINESS.LIBARY.UIControls.GridView;
using JINSHIN.FinanceAccount.Libary.Config;
using JINSHIN.FinanceAccount.Libary.Models;
using JINSHIN.FinanceAccount.Libary.Models.Base;
using JINSHIN.FinanceAccount.Libary.Models.Financial;
using JINSHIN.FinanceAccount.Libary.VModels.Finanacial;
using JINSHIN.FinanceAccounting.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.ComboBox;
using Application = System.Windows.Forms.Application;
using JINSHIN.Finance.AccountSystem;
using JINSHIN.FinanceAccount.Libary.VModels;
using JINSHIN.FinanceAccounting.DB.VModel;
using JINSHIN.Finance.AccountSystem.VModel.FileExport;
using JINSHIN.FinanceAccount.Libary.VModels.Config;
using JINSHIN.FinanceAccount.Libary.Models.Assets;

namespace FinanceAccountProgram
{    
    public partial class frmFinancial : Form
    {
        public string path = "";
        public string id = accounting.accGovNo;
        public string year = accounting.accYear;
        public string keysfile = "106AccountMapTable.csv";
       
        public string reportfilename = "testAllReport.txt";
        private string SourceCompareRpt = "testReport.txt";
        public string DATANOTFOUND = "dataNotFound!";
        public string intelligenceComparesrc = "10769746686gsl2.csv";
        public string intelligenceComparedst = "107697466862.csv";
        string title = "營利事業統一編號,年度,類別,會計項目代碼,會計項目,會計編碼,日期,傳票編號,摘要,借貸註記,借方/貸方金額" + Environment.NewLine;
      //  string compareTitle = "營利事業統一編號,年度,會計編碼,日期,傳票編號,摘要,借,貸";
        string exportdocTitle = "營利事業統一編號,會計編碼,日期,傳票編號,摘要,種類,借,貸";
        string accdocTitle = "序號,會計編碼,日期,傳票編號,摘要,種類,借,貸,借/貸,餘額";
        private string datapath01 = @"\Data\";
        private string datapath02 = @"\Data2\";
        private string datapath03 = @"\Data3\";
        private string datapath05 = @"\Data5\";
        private string datapath07 = @"\Data7\";
        private string datapathUpdate = @"\UpdateCenter\";
        private string comparepath01 = @"";
        private string datapath06 = @"\Data6\";
        private string AIInfo = @"\AIInfo\";
        private string MetaDataPath = @"\MetaData\";       
        private string aiextension = ".csv";
        private string maptitle = "ConvertMap";
        private string assetsDatePath = @"\AssetsConfig.txt";
        private string compareextension = ".txt";
        private string taxFileStr = "gsl";
        private List<string> compareDesc = new List<string>() { "Double","noData" };
        private string CovertFormatStr = "會計代碼:{0},會計項目:{1},轉換代碼:{2},轉換名稱{3}";
        public string metadatafile = "";
        public string filepath = "";
        public string aiinfopath = "";   
        public string data2Path = "";
        public string data3Path = "";
        public string data5Path = "";
        //VerifyItems data
        public string data6Path = "";
        public string data7Path = "";
        public string exportAssetsCost = @"AssetsControl\";
        public string dataUpdateCenter = "";
        List<string> fullfiles = new List<string>();
        List<string> ConvertMap = new List<string>();
        List<string> fullfilesAno = new List<string>();       
        List<BookConvert2> bookconvert = new List<BookConvert2>();
        List<BookConvert2> bookconvertGoal = new List<BookConvert2>();
        List<YearBeginViewModel> ybviewmodel = new List<YearBeginViewModel>();
        List<BookCompute> bookcomputes = new List<BookCompute>();
        List<JINSHINFINANCE032> dbbooks = new List<JINSHINFINANCE032>();
        public DBClassCtl dbclassctl { get; set; }
        public AccInvoiceBookVModel AInvoiceBookModel { get; set; }
        public ClassTypeConfig<object> tab06 { get; set; }
        public ClassTypeConfig<JINSHINFINANCE034> tab07 { get; set; }
        public MoneyVModel moneymodel { get; set; }
        public MoneyVModel QueryAccmodel { get; set; }
        GridViewQueryVModel Acc_Confirm_querymodel = new GridViewQueryVModel();
        public List<string> FinancialReportCompareMsg { get; set; }

        public List<FinancialBase> financials { get; set; }
        //
        public List<VerifyCostFinancialModel> ReportArrangeCostItem { get; set; }
        public List<decimal> DiaryMoneys { get; set; }
        public PlayVModel playvmodel { get; set; }
        public AccountRemainData acountremain { get; set; }
        public string moneyfile = "money.txt";
        public string moneypath { get; set; }
        private string FinancePath = @"\Finance\";
        private PathModel pathmodel { get; set; }
        public frmFinancial()
        {
            InitializeComponent();
            pathmodel = new PathModel();
            DiaryMoneys = new List<decimal>();
            FinancialReportCompareMsg = new List<string>();
            moneymodel = new MoneyVModel();
            QueryAccmodel = new MoneyVModel();
            financials = new List<FinancialBase>();
            string path = Environment.CurrentDirectory;
            DirectoryInfo di = new DirectoryInfo(path);
#if(DEBUG)
            path = di.Parent.Parent.FullName;
            moneypath = di.Parent.Parent.FullName + FinancePath;
#else
            path = di.FullName;
            moneypath = di.FullName + FinancePath;
#endif
            playvmodel = new PlayVModel(path);
            acountremain = new AccountRemainData();


        }

        private void Financefrm_Load(object sender, EventArgs e)
        {
            AInvoiceBookModel = new AccInvoiceBookVModel();
            InitFilesColnfig();
            dbclassctl = new DBClassCtl();
            ReportArrangeCostItem = new List<VerifyCostFinancialModel>();
            tab06 = new ClassTypeConfig<object>();
            tab06.types = DBClassType.Acc_Class;
            tab07 = new ClassTypeConfig<JINSHINFINANCE034>();
            tab07.types = DBClassType.Acc_DetailClass;
            int existfunctions = 13;
            //for (int i = existfunctions; i < 23; i++)
            //{
            //    lblYearNo.TabPages.RemoveAt(existfunctions);
            //}
            using (SysSettingCtl ctl = new SysSettingCtl())
            {
                AccountingReso.yearnow = Convert.ToInt32(ctl.LoadData("AccYear"));
                AccountingReso.accno_id = ctl.LoadData("AccNo");
            }
            this.Text = accounting.FormDataTitle + " " + this.Text;
        }

        private void InitFilesColnfig()
        {
        //    lblYearNo.TabPages[2].Hide();
            path = Environment.CurrentDirectory;
            DirectoryInfo di = new DirectoryInfo(path);
#if (DEBUG)
            filepath = di.Parent.Parent.FullName + datapath01;
            aiinfopath = di.Parent.Parent.FullName + AIInfo;
            comparepath01 = di.Parent.Parent.FullName + AIInfo;
            metadatafile = di.Parent.Parent.FullName + MetaDataPath;
            data2Path = di.Parent.Parent.FullName + datapath02;
            data3Path = di.Parent.Parent.FullName + datapath03;
            data5Path = di.Parent.Parent.FullName + datapath05;
            data6Path = di.Parent.Parent.FullName + datapath06;
            data7Path = di.Parent.Parent.FullName + datapath07;
            dataUpdateCenter = di.Parent.Parent.FullName + datapathUpdate;
            exportAssetsCost = pathmodel.exportPath + exportAssetsCost;
            assetsDatePath = di.Parent.Parent.FullName + assetsDatePath;
#else
            filepath = di.Parent.FullName +datapath01;
            aiinfopath = di.Parent.FullName + AIInfo;
            comparepath01 =di.Parent.FullName + AIInfo;
            metadatafile = di.Parent.FullName + MetaDataPath;
            data2Path = di.Parent.FullName + datapath02;
            data3Path = di.Parent.FullName + datapath03;
            data5Path = di.Parent.FullName + datapath05;
            data6Path = di.Parent.FullName + datapath06;
            data7Path = di.Parent.FullName + datapath07;
            dataUpdateCenter = di.Parent.FullName + datapathUpdate;
            exportAssetsCost = pathmodel.exportPath + exportAssetsCost;
            assetsDatePath = di.Parent.FullName + assetsDatePath;
#endif
            // File.WriteAllText(aiinfopath + "path.txt", aiinfopath);
            DirectoryInfo fls = new DirectoryInfo(filepath);
            fullfiles.Clear();
            Filelst.Items.Clear();
            Filelst2.Items.Clear();
            Filelst3.Items.Clear();
            foreach (var item in fls.GetFiles())
            {
                fullfiles.Add(item.FullName);
                Filelst.Items.Add(item.Name);
            }
            SetDataFromPath(data2Path, fullfilesAno, Filelst2);
            SetDataFromPath(data3Path, AInvoiceBookModel.Invfullfiles, Filelst3);
        }

        private void SetDataFromPath(string path,List<string> filelist,ListBox listbox)
        {
            filelist.Clear();
            DirectoryInfo fls2 = new DirectoryInfo(path);
            foreach (var i in fls2.GetFiles())
            {
                filelist.Add(i.FullName);
                listbox.Items.Add(i.Name);
            }
        }

        public Dictionary<string, string> GetData(string value)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            string[] keys = File.ReadAllLines(metadatafile+ keysfile);
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


       

        public Dictionary<int, double> GetLastMoney(string value)
        {
            Dictionary<int, double> result = default(Dictionary<int, double>);
            var data = ybviewmodel.Where(o => o.key == value).ToList();
            if (data.Count > 0)
            {
                var vals = data.First();
                result = GetAmountGroup( vals);
                vals.checkvalue = true;
            }
            else
            {
                result = new Dictionary<int, double>();
                result.Add(1, 0);
            }
            return result;
        }

        private Dictionary<int,double> GetAmountGroup( YearBeginViewModel vals)
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

        private List<string> CheckLendOrGet(string get, string lend)
        {
            List<string> result = new List<string>();
            if (string.IsNullOrEmpty(lend.Trim()) == false && string.IsNullOrEmpty(get) )
            {
                result.Add("2");
                result.Add(lend.Trim());
                return result;
            }
            else if (string.IsNullOrEmpty(get.Trim()) == false && string.IsNullOrEmpty(lend) )
            {
                result.Add("1");
                result.Add(get.Trim());
            }
            return result;
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
                    string[] data = File.ReadAllLines(item, Encoding.GetEncoding(950));
                    datatemp = data.ToList();
                    for (int i = 0; i < 4; i++)
                        datatemp.RemoveAt(0);
                    int y=0, m=0, d = 0;
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
                lstMsg.Items.Add("資料取得共"+ count.ToString() + "筆,轉換資料共" + accbooks.Count.ToString() + "筆");
                var contents = accbooks.OrderBy(o => o.Acc_No).GroupBy(o=>o.Acc_No).ToList();

                using (AccountEntityDB content = new AccountEntityDB())
                {
                    using (AccountEntities Acc_Books = content.GetEntity())
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
                                Acc_Books.JINSHINFINANCE032.Add(data);
                                Acc_Books.SaveChanges();
                            }
                        }
                        Acc_Books.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                string str = ex.ToString();
            }
            return rs;
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
                    dbbooks.Clear();
                    ProduceAccountingDataFile();
                }
            }
            catch (Exception ex)
            {
                string str = ex.ToString();
            }
            return bookconvertGoal;

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
                ProduceAccountingDataFile( );
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
                        SetDataToDocument(false,true,sb, i, i.amountType.ToString(), count, 1);
                        count++;
                    }
                    File.WriteAllText(aiinfopath + year + id + no + aiextension, sb.ToString(), Encoding.UTF8);
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
                    ybviewmodel= acountremain.SetMoneyData();
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
                    File.WriteAllText(aiinfopath + year + id + "DetailToCheck" + aiextension, notecontent,Encoding.UTF8);
                    File.WriteAllText(aiinfopath + year + id + "Moneys" + aiextension, msg, Encoding.UTF8);
                    File.WriteAllText(aiinfopath + year + id + "NextAmount" + aiextension, NextContentMoney, Encoding.UTF8);
                    File.WriteAllText(aiinfopath + year + id + (no + 1) + aiextension, sb.ToString(), Encoding.UTF8);
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
                    File.WriteAllText(aiinfopath + year + id + (no - 1) + "__yearbooks" + aiextension, sb02.ToString());
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

                    File.WriteAllText(aiinfopath + year + id + (no - 1) + aiextension, sb.ToString(), Encoding.UTF8);
                }
            }
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
        private static void SetNoAccToDocument(StringBuilder sb, BookCompute accval,int acctype)
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
                    sb.Append("1," + accval.taxno + ",,,," + accval.booktype.ToString() + ","+ GetDocAmount(accval.periodget).ToString()+",,借," + ( accval.periodget).ToString() + Environment.NewLine);
                else
                    sb.Append("1," + accval.taxno + ",,,," + accval.booktype.ToString() + ",,"+ GetDocAmount(accval.periodlend ).ToString()+",貸," + (accval.periodlend).ToString() + Environment.NewLine);
            }
        }

        private static string SetNextMoneyContent(string NextContentMoney, BookCompute s)
        {
            if (s.booktype == 1)
            {
                NextContentMoney += s.taxno + "," + s.total.ToString() + Environment.NewLine;
            }
            else
                NextContentMoney += s.taxno + "," + s.total.ToString() + Environment.NewLine ;
            return NextContentMoney;
        }

        private void SetDataToTotalDocument(StringBuilder sb, BookConvert2 i, string amountType, int count, double val)
        {
            string datanum = count == 0 ? "" : count.ToString();
            if (amountType == "1")
                sb.Append(datanum + "," + i.Rightvalues + "," + amountType + "," + val.ToString() + ",,借," + val.ToString() + Environment.NewLine);
            else
                sb.Append(datanum + "," + i.Rightvalues + "," + amountType + ",," + val.ToString() + ",貸," + val.ToString() + Environment.NewLine);
        }



        private void SetDataToDocument(bool rbopt01,bool rbopt02,StringBuilder sb, BookConvert2 i,string amountType,int count,int doctype)
        {
            if (rbopt01)
            {
                sb.Append(count.ToString()+","+i.Rightvalues + "," + amountType + "," + i.amount + Environment.NewLine);
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
                    sb.Append(datanum+","+i.Rightvalues + "," + amountType + ","  + i.amount +",,借,"+i.amount + Environment.NewLine);
                 else if (amountType == "2")
                    sb.Append(datanum + "," + i.Rightvalues + "," + amountType + ",," + i.amount +",貸,"+i.amount + Environment.NewLine);
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            GetBookToCountryFormatData();
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
                foreach (var item in fullfiles)
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
                        //compute countryTax Dictionary data
                        countryTax.Clear();
                        countryTax = GetData(ims[3]);
                        ConvertMap.Add(string.Format(CovertFormatStr, ims[4], ims[3], countryTax.Keys.First(), countryTax.Values.First()));
                        //compute lendorget object to get information                    
                        lendorget.Clear();
                        lendorget = CheckLendOrGet(ims[6], ims[7]);
                        BookConvert2 bookcnt = new BookConvert2();
                        bookcnt.BookNo = ims[2];
                        DateTime.TryParse(ims[1], out dtime);
                        bookcnt.datadate = dtime;
                        bookcnt.TaxNo = ims[4];
                        bookcnt.amountType = int.Parse(lendorget[0]);
                        content = string.Format("{0},{1},", id, year);
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
                    File.WriteAllText(aiinfopath + year + id + maptitle + index + compareextension, content);
                    index++;
                }

                for (int no = 0; no < 3; no++)
                {
                    sb.Clear();
                    sb.Append(exportdocTitle+Environment.NewLine);
                    if (no == 0)
                    {
                        foreach (var i in bookconvert)
                        {
                            sb.Append(i.Leftvalues + no.ToString() + i.Rightvalues + "," + i.amountType + "," + i.amount + Environment.NewLine);
                        }
                        File.WriteAllText(aiinfopath + year + id + taxFileStr + no + aiextension, sb.ToString());
                    }
                    else if (no == 1)
                    {
                        var lst = bookconvert.OrderBy(o => o.TaxNo).ThenBy(o => o.datadate).ThenBy(o => o.BookNo);
                        foreach (var i in lst)
                        {
                            sb.Append(i.Leftvalues + no.ToString() + i.Rightvalues + "," + i.amountType + "," + i.amount.ToString() + Environment.NewLine);
                        }
                        File.WriteAllText(aiinfopath + year + id + taxFileStr + no + aiextension, sb.ToString());
                    }
                    else if (no == 2)
                    {
                        ybviewmodel.Clear();
                        var lst = bookconvert.GroupBy(o => o.TaxNo);
                        double lend = 0; double get = 0;
                        double computevalue = 0;
                        string[] moneydata = File.ReadAllLines(moneypath + moneyfile);
                        StringBuilder sa = new StringBuilder();
                        sa.Append(sb.ToString());
                        Dictionary<int, double> YearOpenAmount = new Dictionary<int, double>();
                        ybviewmodel= acountremain.SetMoneyData();
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
                            sb.Append(string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10}", id, year, "", "", "", item.key, "1070101", "None", "期初資訊", amountgp.First().Key, amountgp.First().Value) + Environment.NewLine);
                        }
                        File.WriteAllText(aiinfopath + year + id + taxFileStr + no + aiextension, sb.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                string exceptionstr = ex.ToString();
            }
            return bookconvert;
        }

        public void ExportInfoReport(StringBuilder rpt)
        {
            string dataTotalComputePath = aiinfopath + intelligenceComparesrc;
            string dataTotalComputePath2 = aiinfopath + intelligenceComparedst;
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
            File.WriteAllText(aiinfopath + reportfilename, rpt.ToString());
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

        private void btnChange_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            ExportInfoReport(sb);
        }

        private void btnGenrateData_Click(object sender, EventArgs e)
        {
            try
            {
                DirectoryInfo di = new DirectoryInfo(aiinfopath);
                foreach (var ei in di.GetFiles())
                {
                    File.Delete(ei.FullName);
                }
                System.Threading.Thread.Sleep(300);
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
                        File.WriteAllText(aiinfopath + SourceCompareRpt, testReport.ToString());
                        ExportInfoReport(testReport);
                    }
                    break;
                    default: {

                    } break;
                }                
            }
            catch (Exception ex)
            {
                string str = ex.ToString();
                //throw;
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            InitFilesColnfig();
        }

        private void btnClassAdd_Click(object sender, EventArgs e)
        {
            if (coClassType.SelectedIndex == 0)
            {
                txClassNO.Text = dbclassctl.GetClassNameMaxInt(DBClassType.Acc_Class).ToString();
                tab06.types = DBClassType.Acc_Class;
            }
            else if (coClassType.SelectedIndex == 1)
            {
                txClassNO.Text = dbclassctl.GetClassNameMaxInt(DBClassType.Inv_Class).ToString();
                tab06.types = DBClassType.Inv_Class;
            }
            //else if (coClassType.SelectedIndex == 2)
            //{
            //    tab06.types = DBClassType.Acc_DetailClass;
            //    txClassNO.Text = dbclassctl.GetClassNameMaxInt(DBClassType.Acc_DetailClass).ToString(); ;
            //}
            txClassNO.Focus();
            Query_Class();
        }

        private void dgClassData_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (MessageBox.Show("是否確認要刪除!", "對話框", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
              int datano = int.Parse(dgClassData.Rows[e.RowIndex].Cells[0].Value.ToString());
                using (AccountEntityDB content = new AccountEntityDB())
                {
                    using (AccountEntities entities = content.GetEntity())
                    {
                        switch (tab06.types)
                        {
                            case DBClassType.AccountBook:
                                break;
                            case DBClassType.InvoiceBook:
                                break;
                            case DBClassType.Acc_Class:
                                {
                                    var accclass01 = entities.JINSHINFINANCE034.Where(o => o.No == datano).FirstOrDefault();
                                    entities.JINSHINFINANCE034.Remove(accclass01);
                                }
                                break;
                            case DBClassType.Inv_Class:
                                {
                                    var accclass02 = entities.JINSHINFINANCE057.Where(o => o.No == datano).FirstOrDefault();
                                    entities.JINSHINFINANCE057.Remove(accclass02);
                                }
                                break;
                            case DBClassType.Acc_DetailClass:
                                break;
                            default:
                                break;
                        }
                        entities.SaveChanges();
                    }
                }
            }
        }

        private void btnClassUpdate_Click(object sender, EventArgs e)
        {
            Query_Class();
        }

        private void Query_Class()
        {
          if (tab06.types == DBClassType.Acc_Class)
          {
              List<JINSHINFINANCE034> rs = dbclassctl.QueryAcc_Class();
              dgClassData.DataSource = rs;
          }else if (tab06.types == DBClassType.Inv_Class)
          {
              List<JINSHINFINANCE057> rs = dbclassctl.QueryInv_Class();
              dgClassData.DataSource = rs;             
          }
          if (dgClassData.Rows.Count > 0)
          {
              using (GridViewFinanceBase gvbase = new GridViewFinanceBase(AddQueryEnum.None))
              {
                  gvbase.columns = new List<string>() { "序號", "名稱", "建立日期" };
                  gvbase.SetDataColumns(dgClassData);
              }
          }
          dgClassData.Refresh();
        }

        private void txClassName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dbclassctl.InsertClassData(txClassName.Text, Convert.ToInt32(txClassNO.Text), tab06.types);
                Query_Class();
            }
        }

        private void txClassNO_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txClassName.Focus();
            }
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
                List<AccBookModelView> values = dbclass.CompareSaveToDB(comparepath01,datacompareType);
                dgTabView.DataSource = values;
                DiffCompareGridView diffgridview = new DiffCompareGridView();
                diffgridview.SetAccConfirmGridColumns(dgTabView);
                diffgridview.Dispose();
                dgTabView.Refresh();
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            int year = int.Parse(txQueryAccYear.Text);
            int month = int.Parse(txQueryAccMonth.Text);
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    List<JINSHINFINANCE035> list = GetYearMonthCostItem(entity, year, month);
                    var query = entity.JINSHINFINANCE032.Where(o => o.Acc_Date.Value.Year == year).ToList();
                    using (AccLedgerAccount ctl = new AccLedgerAccount())
                    {
                        List<string> rs = ctl.GetDisplayString(query);
                        lblBookGet.Text = rs[0];
                        lblBookLend.Text = rs[1];
                    }
                    AccAccountsGridView accountsgridview = new AccAccountsGridView();
                    dgQueryData.DataSource = list;
                    accountsgridview.SetAccConfirmGridColumns(dgQueryData);
                }
            }
        }
        

        private List<JINSHINFINANCE035> GetYearMonthCostItem(AccountEntities entity,int year,int month)
        {
                          
                var list = entity.JINSHINFINANCE035.Where(o => o.Cost_Date.Value.Year == year
                && o.Cost_Date.Value.Month == month).OrderBy(o=>o.Acc_No).ThenBy(o=>o.DataType).ToList();
                return list;
            
         }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            using (AccLedgerAccount ctl = new AccLedgerAccount())
            {
                List<JINSHINFINANCE040> data = new List<JINSHINFINANCE040>();
                List<string> rs = ctl.SaveData(data, true,2020);
                SetTextDisplay(rs);
            }
            ShowLegerData();
        }

        private void SetTextDisplay(List<string> rs)
        {
            lblLedgerGetVal.Text = rs[0];
            lblLedgerLend.Text = rs[1];
            lblLedgerResult.Text = rs[2];
        }

        private void dgLedger_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                e.CellStyle.Format = "##0";
            }
        }

        private void btnALegerQuery_Click(object sender, EventArgs e)
        {
            ShowLegerData();
        }

        private void ShowLegerData()
        {
            using (AccLedgerAccount acc_account = new AccLedgerAccount())
            {
                List<JINSHINFINANCE040> values = acc_account.GetData(AccountingReso.yearnow);
                List<string> rs = acc_account.GetDisplayString(values);
                dgLedger.DataSource = values;
                using (AccCostLedgerGridView gridview = new AccCostLedgerGridView())
                {
                    gridview.SetAccConfirmGridColumns(dgLedger);
                }
                dgLedger.Refresh();
                SetTextDisplay(rs);
            }
        }

        private void addQueryDataForm1_Load(object sender, EventArgs e)
        {
          
        }

        private void dgLedger_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }

        private void dgLedger_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {

        }

        private void updateForm1_Load(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            TabControl tc = sender as TabControl;
            if (AccVoiceSetting.VoiceSetting)
              playvmodel.PlayMedialData(tc.SelectedIndex + 1, true);
            
            switch (tc.SelectedTab.Name)
            {
                case "TPVerifyAcc":
                    {
                        using (UpdateFormVModel updatemodel = new UpdateFormVModel(updateVerifyAcc.dgdataview, AddQueryEnum.Acc_VerifyCostData, UpdateFormEnum01.None))
                        {
#region Variable init 
                            updateVerifyAcc.datatype = AddQueryEnum.Acc_VerifyCostData;
                            updateVerifyAcc.ctl01 = new Acc_CostDataQuery();
                            updateVerifyAcc.ctl01.dbclass = dbclassctl;
                            updateVerifyAcc.dataUpdateCenter = dataUpdateCenter;
#endregion
                            updateVerifyAcc.SetInit(updatemodel);
                          
                            updateVerifyAcc.listboxs[0].DataSource = dbclassctl.GetAcc_Class();
                            SetListBox(updateVerifyAcc.listboxs[0], "Name", "No");
                            updateVerifyAcc.listboxs[1].DataSource = dbclassctl.GetAcc_ContentClass();
                            SetListBox(updateVerifyAcc.listboxs[1], "Name", "No");
                            updateVerifyAcc.listboxs[2].DataSource = dbclassctl.QueryInv_Class();
                            SetListBox(updateVerifyAcc.listboxs[2], "Name", "No");                            
                        }
                    }
                    break;
                case "tabReport":
                    {
                        txtSYear.Text = DateTime.Now.Year.ToString();
                    } break;
                case "tbAccConfirm":
                    {
                        Acc_Confirm_BindingList(lstVerifyAccds, chConfirmAll);
                    }
                    break;
                case "TabBalanceRpt":
                    {
                        
                    } break;
                case "TPCostDataView":
                    {
                        AddQueryCostData.datatype = AddQueryEnum.Acc_CostData;
                        AddQueryCostData.ctl01 = new Acc_CostDataQuery();
                        AddQueryCostData.ctl01.dbclass = dbclassctl;
                        AddQueryCostData.listboxs[0].DataSource = dbclassctl.GetAcc_Class();
                        SetListBox(AddQueryCostData.listboxs[0], "Name", "No");
                        AddQueryCostData.listboxs[1].DataSource = dbclassctl.GetAcc_ContentClass();
                        SetListBox(AddQueryCostData.listboxs[1], "Name", "No");
                        AddQueryCostData.SetInit();
                    }
                    break;
                case "TPClassType": {
                        coClassType.SelectedIndex = 1;
                        lstInvoice.Items.Clear();
                        var vals = dbclassctl.QueryAcc_Class().OrderBy(o => o.No).ToList();
                        foreach (var item in vals)
                        {
                            lstInvoice.Items.Add(item.Name);

                        }
                    } break;
                case "TPInvContract":
                    {
                        addQueryInvContract.datatype = AddQueryEnum.Invoice_Contract;
                        addQueryInvContract.datapath05 = data5Path;
                        addQueryInvContract.ctl02 = new Acc_InvoiceCostCTL();
                        addQueryInvContract.ctl02.dbclass = dbclassctl;
                        addQueryInvContract.listboxs[0].DataSource = dbclassctl.GetAcc_Class();
                        SetListBox(addQueryInvContract.listboxs[0], "Name", "No");
                        addQueryInvContract.listboxs[1].DataSource = dbclassctl.GetAcc_ContentClass();
                        SetListBox(addQueryInvContract.listboxs[1], "Name", "No");
                        addQueryInvContract.SetInit();
                    }
                    break;
                case "TPClassDetail":
                    {
                        tab07.types = DBClassType.Acc_DetailClass;
                        using (AccountEntityDB content = new AccountEntityDB())
                        {
                            using (AccountEntities entity = content.GetEntity())
                            {
                                tab07.mclass = entity.JINSHINFINANCE034.ToList();
                            }
                        }
                        masterCtl01.dbclassctl = dbclassctl;
                        masterCtl01.tab06 = tab07;
                        masterCtl01.lstClassNamedata.DataSource = tab07.mclass;
                        masterCtl01.lstClassNamedata.DisplayMember = "name";
                        masterCtl01.lstClassNamedata.ValueMember = "No";
                        masterCtl01.SetInit();
                    }
                    break;
                case "TbMoney":
                    {
                    } break;         
                case "TbAssets":
                    {
                        frmAssets.ImportType = ImportQueryClass.Assets;
                        frmAssets.datapath07 = data7Path;
                        frmAssets.SetInit();

                    } break;
                case "tbViewData":
                    {
                        RefreshAccidVerifyList();
                    }
                    break;
                case "tbVerifyAssetsInfo":
                {
                    string datestr = File.ReadAllText(assetsDatePath);
                    DateTime yeardate = DateTime.Parse(datestr);
                    datetimecontrol.Value = yeardate;
                } break;
                case "DiaryBook":
                    {
                        dtAccPicker.Value = DateTime.Today;
                        lblInputPos.DataSource = null;
                        using (DiaryAccounts account = new DiaryAccounts())
                        {
                            lblInputPos.DataSource = account.GetJINSHINFINANCE050Items();
                            lblInputPos.DisplayMember = "NoName";
                            lblInputPos.ValueMember = "No";
                            txAccYear.Text = DateTime.Now.Year.ToString();
                            txAccMonth.Text = DateTime.Now.Month.ToString();
                        }
                    } break;
                case "TPQuery":
                    {
                        txQueryAccYear.Text = DateTime.Now.Year.ToString();
                        txQueryAccMonth.Text = DateTime.Now.Month.ToString();
                    } break;
                default:
                    break;
            }
        }

        private void Acc_Confirm_BindingList(ListBox lstVerifyAccds,CheckBox chConfirmAll)
        {
            BusinessCtl buinessctl = new BusinessCtl();
            List<IGrouping<string, AccDataModel>> datag = buinessctl.GetAccVerifysInfo();
            string nameval = "";
            int ttlcnt = 0, failcnt = 0, passcnt = 0;
           // lstVerifyAccds.Items.Clear();
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
            lstVerifyAccds.DisplayMember = "datadesc";
            lstVerifyAccds.ValueMember = "acc_id";
            lstVerifyAccds.DataSource = vals;
            buinessctl.Dispose();
        }

        private void RefreshAccidVerifyList()
        {
            lstVerifing.Items.Clear();
            lstVerifyData.Items.Clear();
            lstNoVerifyData.Items.Clear();
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    List<JINSHINFINANCE041> names = entity.JINSHINFINANCE041.ToList();
                    var contents = AccCostItemConfig.GetClassData(entity.JINSHINFINANCE035.Where(o => o.Cost_Date.Value.Year == AccountingReso.yearnow).ToList());
                    var data = contents.GroupJoin(names,
                        (cost) => new { acc_id = cost.Acc_ID }, (accname) => new { acc_id = accname.Acc_ID },
                        (cost, accname) => new
                        {
                            acc_id = cost.Acc_ID,
                            check = cost.Cost_Check,
                            accname = accname.FirstOrDefault()
                        }).ToList();

                    var vals = data.GroupBy(o => o.acc_id).ToList();
                    string nameval = "";
                    int ttlcnt = 0, passcnt = 0;
                    foreach (var item in vals)
                    {
                        if (item.FirstOrDefault().accname != null)
                            nameval = item.First().accname.AccName;
                        else
                            nameval = "";
                        ttlcnt = item.Count();
                        passcnt = item.Where(o => o.check == true).Count();
                        if (item.Where(o => o.check == false || o.check == null).Count() > 0)
                        {
                            lstNoVerifyData.Items.Add(item.First().acc_id + ":" + nameval);
                            if (passcnt != 0)
                                lstVerifing.Items.Add(item.First().acc_id + ":" + nameval + " 已核對" + passcnt.ToString() + "(" + ttlcnt.ToString() + ")");
                        }
                        else
                        {
                            lstVerifyData.Items.Add(item.First().acc_id + ":" + nameval);
                        }
                    }
                }
            }
        }

        private void SetListBox(ListBox ctl, string name, string no)
        {

            ctl.DisplayMember = name;
            ctl.ValueMember = no;
        }
        private void UpdateFormInvoice_Load(object sender, EventArgs e)
        {
            
           
        }
        /// <summary>
        /// SN,Month,Acc_ID,acc_date,VMonth,Inv_Date,Inv_No,ClassType,LendGet,Amount,IsInvoice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCostAdd_Click(object sender, EventArgs e)
        {
            //using (Acc_InvoiceCostCTL invctl = new Acc_InvoiceCostCTL())
            //{
            //   List<Invoice_Contract> invcontract = invctl.SaveData(datapath05);
            //}
            //SaveData();

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {

        }

        private void usrAccForm2_Load(object sender, EventArgs e)
        {

        }

        private void addQueryInvContract_Load(object sender, EventArgs e)
        {

        }

        private void coClassType_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cobo = sender as ComboBox;
            switch (cobo.SelectedIndex)
            {
                case 0: tab06.types = DBClassType.Acc_Class;
                    break;
                case 1: tab06.types = DBClassType.Inv_Class;
                    break;
                default:
                    break;
            }
        }

        private void txQueryType_Resize(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ImportDataFormControl(ImportQueryClass.verifyitem);
        }

        private static void ImportDataFormControl(int importType)
        {
        //    Application.OpenForms[0].Hide();
            ImportDataFrm idatafrm = new ImportDataFrm();
            idatafrm.ImportType = importType;
            idatafrm.Show();
        }

        private void btnMoney_Click(object sender, EventArgs e)
        {
            DataParams params01 = new DataParams();
            params01.data006.value = -1;
            if (rbType01.Checked)
                params01.data001.value = 1;
            else if (rbType02.Checked)
                params01.data001.value = 2;
            params01.data002.value = lstMonths.SelectedIndex + 1;
            params01.data003.data = txtCostDescData.Text.Trim();
            params01.data004.data = txtValidMAccID.Text.Trim();
            params01.data005.data = txtMCostAccID.Text.Trim();
            params01.data006.value = cokMonMALL.Checked ? 1 : 2;
            params01.data011.data = txtValidDescData.Text.Trim();
            MoneyDataShowSet(params01);
        }

        private void MoneyDataShowSet(DataParams params01)
        {
            if (moneymodel.accmodel.ctl03.acc_CostItmes != null)
                moneymodel.accmodel.ctl03.acc_CostItmes.Clear();
            if (moneymodel.accmodel.ctl03.acc_VerifyItmes != null)
                moneymodel.accmodel.ctl03.acc_VerifyItmes.Clear();

            moneymodel.accmodel.ctl03.SetInit();
            moneymodel.SetConditionData(dataMoney02, AddQueryEnum.JINSHINFINANCE047, params01);
            moneymodel.accmodel.DataShow<JINSHINFINANCE047>(dataMoney02, params01);

            moneymodel.SetConditionData(dataMoney01, AddQueryEnum.Acc_CostData, params01);
            moneymodel.accmodel.DataShow<JINSHINFINANCE035>(dataMoney01, params01);
        }

        private void dataMoney01_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView dg = sender as DataGridView;
            IComparer<JINSHINFINANCE035> clist = new VerifyMonthCompareList() as IComparer<JINSHINFINANCE035>;
            moneymodel.accmodel.ctl03.acc_CostItmes.Sort(clist);
            dg.DataSource = moneymodel.accmodel.ctl03.acc_CostItmes;
            dg.Refresh();
        }

        private void btnMoneyVeriy_Click(object sender, EventArgs e)
        {
            List<VarClass> key_columns = new JINSHINFINANCE035Cols().verify_columns;
            List<VarClass> keyMoney_columns = new JINSHINFINANCE035Cols().verifyMoney_columns;
            List<string> cols = new List<string>();
            List<string> colsmoney = new List<string>();
            key_columns.ForEach(p => cols.Add(p.value02));
            keyMoney_columns.ForEach(p => colsmoney.Add(p.value02));
            List<string> accids = new List<string>() { "2171", "2191"};
            List<string> accounts = new List<string>() { "薪資", "薪資" };
            foreach (var item in accids)
            {
                DataParams params01 = new DataParams();
                if (txtMCostAccID.Text.Trim() == item && txtValidMAccID.Text.Trim() == item)
                {
                    
                }
            }
            //DataParams params01 = new DataParams();
            //params01.data006.value = -1;
            //if (rbType01.Checked)
            //    params01.data001.value = 1;
            //else if (rbType02.Checked)
            //    params01.data001.value = 2;
            //params01.data002.value = lstMonths.SelectedIndex + 1;
            //params01.data003.data = txtCostDescData.Text.Trim();
            //params01.data004.data = txtValidMAccID.Text.Trim();
            //params01.data005.data = txtMCostAccID.Text.Trim();
            //params01.data006.value =  1 ;
            //params01.data011.data = txtValidDescData.Text.Trim();
            //MoneyDataShowSet(params01);

            var data = moneymodel.accmodel.ctl03.acc_VerifyItmes;            
            lstMoneyMsg.Items.Clear();
            string content = "";
            int rec_check = GetValidItemRec();
            JINSHINFINANCE047Flow verifyitem = AnalyzeAccItems(moneymodel.accmodel.ctl03.acc_CostItmes, rec_check);
            int sn = 1;
            string msg = "";
            
            List<JINSHINFINANCE047View> acc_veriItem = new List<JINSHINFINANCE047View>();
            using (FunctionControl fc = new FunctionControl())
            {
                foreach (var i in moneymodel.accmodel.ctl03.acc_VerifyItmes)
                {
                    acc_veriItem.Add(new JINSHINFINANCE047View()
                    {
                        Acc_Date = i.Acc_Date,
                        Acc_ID = i.Acc_ID,
                        Rec_Type = i.Rec_Type,
                        Amount = i.Amount,
                        isMap = false,
                        Verify_Month = i.Verify_Month,
                        Invoice_No = i.Invoice_No
                    });
                }
                var vitem = acc_veriItem.Where(o => o.Acc_ID == txtMCostAccID.Text.Trim()).FirstOrDefault();
                string accid = vitem.Acc_ID;
                string countcompare = verifyitem.data01.Count != acc_veriItem.Count ? "帳目數量為" + verifyitem.data01.Count.ToString()  + Environment.NewLine + "帳務實際數量為" + acc_veriItem.Count.ToString() : "";
                List<string> datamsg = new List<string>();

                if (!string.IsNullOrEmpty(accid))
                {
                    foreach (var item in verifyitem.data01)
                    {
                        verifyitem.result = false;
                        foreach (var it in acc_veriItem)
                        {
                            if ((item.Cost_M == 3) && (it.Verify_Month == 3))
                            {
                              //  string str = "";
                            }
                            content = fc.CheckClassKeyByVal<JINSHINFINANCE035, JINSHINFINANCE047>(cols, item, it);
                            if (content != "")
                            {
                                verifyitem.result = true;
                                it.isMap = true;
                                msg = sn.ToString() + "." + content + Environment.NewLine;                                
                                msg = msg + "yes";
                                break;
                            }
                            else
                            {
                                content = fc.CheckClassKeyByVal<JINSHINFINANCE035, JINSHINFINANCE047>(colsmoney, item, it);
                                if (content != "")
                                {
                                    if (item.Amount != it.Amount)
                                    {
                                        verifyitem.result = true;
                                        it.isMap = true;
                                        msg = sn.ToString() + "." + content + Environment.NewLine;
                                        msg = msg + "金額不同";
                                        lstMoneyMsg.Items.Add("= = = = = = = = = = = = =");
                                        lstMoneyMsg.Items.Add(msg);
                                        lstMoneyMsg.Items.Add("= = = = = = = = = = = = =");
                                        verifyitem.errorcnt = verifyitem.errorcnt + 1;
                                        SetVerifyModelToView(verifyitem, item);
                                    }
                                }
                            }
                        }
                        if (!verifyitem.result)
                        {
                            verifyitem.errorcnt = verifyitem.errorcnt + 1;
                            SetVerifyModelToView(verifyitem, item);
                            msg = sn.ToString() + ".";
                        //    lstMoneyMsg.Items.Add("");
                            lstMoneyMsg.Items.Add("多的帳目:"+msg + "會科:" + item.Acc_ID + " 月份:" + item.Verify_Month + " 金額:" + item.Amount);
                        }
                        sn = sn + 1;
                    }

                    if (countcompare != "")
                    {
                        lstMoneyMsg.Items.Add(countcompare);
                    }

                    acc_veriItem.ForEach(o => {
                        if (!o.isMap)
                        {
                            datamsg.Add("應增加帳務的資料:" + o.Acc_Date.Value.ToString("yyyyMMdd") + ",月份:" + o.Verify_Month.ToString() + ",編號:" + o.Acc_ID.ToString() + ",金額:" + o.Amount.ToString() );
                            verifyitem.errorcnt = verifyitem.errorcnt + 1;
                        }
                    });

                    if (datamsg.Count > 0)
                    {
                        foreach (var item in datamsg)
                        {
                            lstMoneyMsg.Items.Add(item);
                        }                       
                    }
                    if (verifyitem.getCheckItem == true)
                    {
                        var checkdata = acc_veriItem.Where(o => o.isMap == false);
                        if (checkdata.Count() > 0)
                        {
                            lstMoneyMsg.Items.Add("= = = = = =帳目異常檢查= = = = = = =");
                            foreach (var i in checkdata)
                            {
                                lstMoneyMsg.Items.Add("確認此月帳目.會科:" + i.Acc_ID + " 月份:" + i.Verify_Month + " 金額:" + i.Amount);
                                verifyitem.errorcnt = verifyitem.errorcnt + 1;
                                SetVerifyModelToView(verifyitem, i);
                            }
                            lstMoneyMsg.Items.Add("= = = = = = = = = = = = = = = = = = = ");
                        }
                        if (verifyitem.data02.Count() > 0)
                        {
                            lstMoneyMsg.Items.Add("= = = = = =帳目過多檢查= = = = = = = = =");
                            foreach (var ve in verifyitem.data02)
                            {
                                lstMoneyMsg.Items.Add("確認此月帳目.會科:" + ve.Acc_ID + " 月份:" + ve.Verify_Month + " 金額:" + ve.Amount);
                                verifyitem.errorcnt = verifyitem.errorcnt + 1;
                            }
                            if (verifyitem.data03 != null)
                            {
                                foreach (var ve in verifyitem.data03)
                                {
                                    lstMoneyMsg.Items.Add("確認此月帳目.會科:" + ve.Acc_ID + " 月份:" + ve.Verify_Month + " 金額:" + ve.Amount);
                                    verifyitem.errorcnt = verifyitem.errorcnt + 1;
                                }
                            }
                            lstMoneyMsg.Items.Add("= = = = = = = = = = = = = = = = = = = ");
                        }
                    }

                    foreach (var item in acc_veriItem)
                    {
                        foreach (var i in verifyitem.data05)
                        {
                            if (i.Verify_Month == item.Verify_Month)
                            {
                                i.DstAmount = item.Amount.Value;
                                i.DstMonth = item.Verify_Month;
                            }
                        }
                    }

                    if (verifyitem.errorcnt != 0)
                    {
                        lstMoneyMsg.Items.Add("比對後，兩方帳目金額及數量異常共" + verifyitem.errorcnt + "項.");
                        verifyitem.data05 = verifyitem.data05.OrderBy(o => o.Verify_Month).ToList();
                        foreach (var item in verifyitem.data05)
                        {
                            if (item.Verify_Month != item.Cost_M)
                            {
                                var contents = moneymodel.accmodel.ctl03.acc_CostItmes.Where(o => (o.Acc_ID == item.Acc_ID && o.Amount == item.DstAmount 
                                && o.Cost_M == item.DstMonth)||((o.Acc_Desc.IndexOf(item.DstMonth.ToString() +"月") != -1) && o.Amount == item.DstAmount)).ToList();

                                lstMoneyMsg.Items.Add("正確帳目.會科:" + item.Acc_ID + " 月份:" + item.DstMonth + " 金額:" + item.DstAmount);
                                foreach (var t in contents)
                                {
                                    lstMoneyMsg.Items.Add("建議此月帳目.會科:" + t.Acc_ID + " 月份:" + t.Verify_Month + " 帳目月:" + t.Cost_M + " 金額:" + t.Amount);
                                }                             
                            }
                        }
                    }
                    else
                        lstMoneyMsg.Items.Add("核定通過.");
                }
            }

        }

        private static void SetVerifyModelToView(JINSHINFINANCE047Flow verifyitem, JINSHINFINANCE047 item)
        {
            verifyitem.data05.Add(new JINSHINFINANCE035View()
            {
                Acc_Desc = item.Descrip,
                Acc_ID = item.Acc_ID,
                Amount = item.Amount,
                Rec_Type = item.Rec_Type,
                Verify_Month = Convert.ToByte(item.Verify_Month)
            });
        }

        private static void SetVerifyModelToView(JINSHINFINANCE047Flow verifyitem, JINSHINFINANCE035 item)
        {
            verifyitem.data05.Add(new JINSHINFINANCE035View()
            {
                Acc_Desc = item.Acc_Desc,
                Acc_ID = item.Acc_ID,
                Acc_No = item.Acc_No,
                Cost_M = item.Cost_M,
                Amount = item.Amount,
                Cost_Date = item.Cost_Date,
                DataType = item.DataType,
                Invoice_No = item.Invoice_No,
                Rec_Type = item.Rec_Type,
                Verify_Month = item.Verify_Month,
                SN = item.SN
            });
        }

        private int GetValidItemRec()
        {
            var rec_data = moneymodel.accmodel.ctl03.acc_VerifyItmes.GroupBy(o => o.Rec_Type)
                            .Select(i => new { cnt = i.Sum(o => o.Rec_Type), rec_type = i.First().Rec_Type });
            int rec_check = 0;
            int nowcnt = 0;
            foreach (var t in rec_data)
            {
                if (t.cnt > nowcnt)
                {
                    rec_check = t.rec_type.Value;
                }
                nowcnt = t.cnt.Value;
            }

            return rec_check;
        }

        private JINSHINFINANCE047Flow AnalyzeAccItems(List<JINSHINFINANCE035> data,int Rec_Type)
        {
            JINSHINFINANCE047Flow rs = new JINSHINFINANCE047Flow();
            List<JINSHINFINANCE035> values = new List<JINSHINFINANCE035>();
            foreach (var i in data)
                values.Add(i);
            List<JINSHINFINANCE035> values01 = default(List<JINSHINFINANCE035>);
            List<JINSHINFINANCE035> values02 = default(List<JINSHINFINANCE035>);
            List<JINSHINFINANCE035> values03 = default(List<JINSHINFINANCE035>);
            if (Rec_Type == 11)
            {
                values01 = new List<JINSHINFINANCE035>();
                values02 = new List<JINSHINFINANCE035>();
                values03 = new List<JINSHINFINANCE035>();
            }
            else
            {
                values01 = new List<JINSHINFINANCE035>();
                values02 = new List<JINSHINFINANCE035>();
            }
            //var dataval = values.GroupBy(o => new { o.Verify_Month, o.Invoice_No }).ToList();1714
            var dataval = values.GroupBy(o => new { o.Verify_Month,o.Amount }).ToList();
            if (Rec_Type == 11)
            {
                rs.getCheckItem = dataval.Where(o => o.Count() != 2).Count() > 0;
            }
            else
            {
                rs.getCheckItem = dataval.Where(o => o.Count() != 1).Count() > 0;
            }
            int datacnt = 0;
            JINSHINFINANCE035 item = default(JINSHINFINANCE035);
            foreach (var val in dataval)
            {
                datacnt = val.Count();
                if (Rec_Type == 11)
                {
                    if (datacnt != 2)
                    {
                        if ((datacnt == 1))
                        {
                            if ((val.First().Acc_Desc.IndexOf("去年12月") == -1) && (val.First().Acc_Desc.IndexOf("12月") == -1))
                            {
                                values01.Add(val.First());
                              //  values02.Add(val.First());
                            }
                            else
                            {
                                values01.Add(val.First());
                            }
                        }                       
                        else values03.Add(val.First());
                    }
                    else
                        foreach (var v in val)
                            values01.Add(v);
                }
                else
                {
                    if (datacnt != 1)
                    {
                      item = val.FirstOrDefault();
                      if (item != null)
                        values02.Add(val.First());
                    }
                    else {
                        foreach (var v in val)
                            values01.Add(v);
                    }
                }                
            }
            values01 = values01.OrderBy(o => o.Verify_Month).ToList();
            rs.data01 = values01;
            rs.data02 = values02;
            rs.data03 = values03;
            rs.Rec_Type = Rec_Type;
            return rs;
        }

        private void txtValidDescData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtValidMAccID.Text = "";
            }
        }

        private void txtMCostAccID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtValidMAccID.Text = txtMCostAccID.Text;
            }
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            AccidFormShow(UpdateFormEnum01.SalaryData);
        }
    
        private void AccidFormShow(UpdateFormEnum01 formtype=UpdateFormEnum01.None, int updatefrmtype = -1)
        {
            SalaryFrm idatafrm = new SalaryFrm();
            idatafrm.SetInit(pathmodel.exportPath);
            if (formtype != UpdateFormEnum01.None)
                idatafrm.updateFrm1.SetInit(formtype);
            else
                idatafrm.updateFrm1.SetInit(UpdateFormEnum01.None, updatefrmtype);
            idatafrm.Show();
        }

        private void btnOffice365_Click(object sender, EventArgs e)
        {
            AccidFormShow(UpdateFormEnum01.Office365);
        }

        private void btnPhone_Click(object sender, EventArgs e)
        {
            AccidFormShow(UpdateFormEnum01.CompanyPhones);
        }

        private void frmAssets_Load(object sender, EventArgs e)
        {

        }

        
        private void btnAssetsVerify_Click(object sender, EventArgs e)
        {
          
        }

        

        private static List<AssetsAccClass> GetAssetsClassName()
        {
            List<AssetsAccClass> accname = new List<AssetsAccClass>();
            accname.Add(new AssetsAccClass()
            {
                 acc_id_Add = "1586",
                  acc_id_Red = "6125",
                assetsname = "其他資產",
            });       
            accname.Add(new AssetsAccClass()
            {
                acc_id_Add = "1533",
                acc_id_Red = "6126",
                assetsname = "費用",
            });         
            return accname;
        }

        private void btnFinance_Click(object sender, EventArgs e)
        {
            AccidFormShow(UpdateFormEnum01.Finance);            
        }

        private void btnpayableSalary_Click(object sender, EventArgs e)
        {
            AccidFormShow(UpdateFormEnum01.None, UpdateFormClass.payableSalary);
        }

        private void btnpayable_Click(object sender, EventArgs e)
        {
            AccidFormShow(UpdateFormEnum01.None, UpdateFormClass.payable);          
        }

        private void btndividend_Click(object sender, EventArgs e)
        {
            AccidFormShow(UpdateFormEnum01.None, UpdateFormClass.dividend);
        
        }

        private void btnInterest_Click(object sender, EventArgs e)
        {
            AccidFormShow(UpdateFormEnum01.None, UpdateFormClass.Interest);
        }

        private void btnCostItemUpdate_Click(object sender, EventArgs e)
        {
            if (AddQueryCostData.ctl01.acc_orgcostitem != null)
            {
                if (MessageBox.Show("是否確認要更新~", "對話框", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    AddQueryCostData.ctl01.UpdateData(AddQueryCostData.ctl01.acc_orgcostitem);
                }
                // ctl03.acc_CostItmes
            }

        }

        private void btnRebuildIndx_Click(object sender, EventArgs e)
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    ReBuildIndex(entity);
                    ReBuildCostItemIndex(entity);
                    ReBuildInvoiceIndex(entity);
                }
            }
        }

        private void ReBuildCostItemIndex(AccountEntities entity)
        {
            int sn = 1;
            var data = entity.JINSHINFINANCE035.GroupBy(o => new { o.Acc_No }).ToList();
            foreach (var item in data)
            {
                sn = 1;
                foreach (var d in item.OrderBy(o=>o.Acc_ID))
                {
                    d.Item = sn;
                    sn = sn + 1;
                }
            }
            entity.SaveChanges();
        }
        private void ReBuildInvoiceIndex(AccountEntities entity)
        {
            int sn = 1;
            var data = entity.JINSHINFINANCE039.GroupBy(o => new { o.Acc_No }).ToList();
            foreach (var item in data)
            {
                sn = 1;
                foreach (var d in item.OrderBy(o => o.Acc_ID))
                {
                    d.Item = sn;
                    sn = sn + 1;
                }
            }
            entity.SaveChanges();
        }

        private  void ReBuildIndex( AccountEntities entity)
        {
            int sn = 1;
            var data = entity.JINSHINFINANCE032.GroupBy(o => o.Acc_No).ToList();
            foreach (var item in data)
            {
                sn = 1;
                foreach (var d in item.OrderBy(o=>o.Acc_ID))
                {
                    d.Item = sn;
                    sn = sn + 1;
                }
            }
            entity.SaveChanges();
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            InvoiceVModel invmodel = new InvoiceVModel();
            invmodel.BalanceInvoiceBook();
        }

        private void updateVerifyAcc_Load(object sender, EventArgs e)
        {

        }

        public void SetExportPath(SalaryFrm salary)
        {
            //salary.
        }

        private void btn_payfirstLaborInsurance_Click(object sender, EventArgs e)
        {
            AccidFormShow(UpdateFormEnum01.None, UpdateFormClass.payfirstLaborInsurance);

        }

        private void btn_prepay_product_Click(object sender, EventArgs e)
        {
            AccidFormShow(UpdateFormEnum01.None, UpdateFormClass.prepay_product);            
        }

        private void btn_rate_Click(object sender, EventArgs e)
        {
            AccidFormShow(UpdateFormEnum01.None, UpdateFormClass.rate);
        }

        private void btn_travel_income_Click(object sender, EventArgs e)
        {
            AccidFormShow(UpdateFormEnum01.None, UpdateFormClass.travel_income);
        }

        private void btn_pre_payrate_Click(object sender, EventArgs e)
        {
            AccidFormShow(UpdateFormEnum01.None, UpdateFormClass.pre_payrate);

        }

        private void btn_gift_Click(object sender, EventArgs e)
        {
            AccidFormShow(UpdateFormEnum01.None, UpdateFormClass.gift);
        }

        private void btn_Cost_Income_Click(object sender, EventArgs e)
        {
            AccidFormShow(UpdateFormEnum01.None, UpdateFormClass.Cost_Income);
        }

        private void btn_Depreciation_Cost_Click(object sender, EventArgs e)
        {
            AccidFormShow(UpdateFormEnum01.None, UpdateFormClass.Depreciation_Cost);
        }

        private void btnAssets_Click(object sender, EventArgs e)
        {
            AccidFormShow(UpdateFormEnum01.None, UpdateFormClass.Assets);    
        }

        private void btnpayable2ISalary_Click(object sender, EventArgs e)
        {
            AccidFormShow(UpdateFormEnum01.None, UpdateFormClass.NoIncluepayable);
        }

        private void btnpayableSalary2Include_Click(object sender, EventArgs e)
        {
            AccidFormShow(UpdateFormEnum01.None, UpdateFormClass.NoIncluepayableSalary);
          
        }

        private void btnOthersCost_Click(object sender, EventArgs e)
        {
            AccidFormShow(UpdateFormEnum01.None, UpdateFormClass.others_cost);
          
        }

        private void btnVierfyAcc_Click(object sender, EventArgs e)
        {
            using (MoneyVerifyClass model = new MoneyVerifyClass())
            {
                model.CheckVerify(moneymodel.accmodel.ctl03.acc_CostItmes);
            }
        }

        private void btnCancelCheck_Click(object sender, EventArgs e)
        {
            using (MoneyVerifyClass model = new MoneyVerifyClass())
            {
                model.CancelVerify(moneymodel.accmodel.ctl03.acc_CostItmes);
            }
        }

        private void btnViewRefresh_Click(object sender, EventArgs e)
        {
            RefreshAccidVerifyList();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            using (MoneyVerifyClass model = new MoneyVerifyClass())
            {
                model.CheckVerify(Acc_Confirm_querymodel.ctl01.JINSHINFINANCE035);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            using (MoneyVerifyClass model = new MoneyVerifyClass())
            {
                model.CancelVerify(Acc_Confirm_querymodel.ctl01.JINSHINFINANCE035);
            }
        }
       
        private void btnConfirmQuery_Click(object sender, EventArgs e)
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
            Acc_Confirm_querymodel.AccConfirm_SetConfigVerifyAccds( params01);
            if (Acc_Confirm_querymodel.ctl01.JINSHINFINANCE035 != null)
                Acc_Confirm_querymodel.ctl01.JINSHINFINANCE035.Clear();
            if (QueryAccmodel.accmodel.ctl03.acc_VerifyItmes != null)
                QueryAccmodel.accmodel.ctl03.acc_VerifyItmes.Clear();
            QueryAccmodel.accmodel.ctl03.SetInit();
            Acc_Confirm_querymodel.SetAccConfirmGridColumns(dgControl);
            QueryAccmodel.accmodel.ctl03.GetStorageData(AddQueryEnum.JINSHINFINANCE047, params01);
            Acc_Confirm_querymodel.ctl01.JINSHINFINANCE035 = Acc_Confirm_querymodel.ctl01.GetData(QueryFrmString.JINSHINFINANCE035, params01,chConfirmAll.Checked);
            dgControl.DataSource = Acc_Confirm_querymodel.ctl01.JINSHINFINANCE035;
          //  moneymodel.accmodel.DataShow<JINSHINFINANCE035>(dgControl, params01, 1);
        }

        private void chConfirmAll_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox ctl = sender as CheckBox;
            Acc_Confirm_BindingList(lstVerifyAccds, chConfirmAll);
        }

        private void txtValidMAccID_Click(object sender, EventArgs e)
        {
            btnMoney_Click(new object(), null);
        }

        private void btnAccExport_Click(object sender, EventArgs e)
        {
            using (GridViewBase grid = new GridViewBase())
            {
                grid.ExportDataGridView(pathmodel.exportPath, "Acc_Confirm", dgControl);
            }
         //   
            //dgControl.DataSource
        }

        private void btnVerifyAssetsData_Click(object sender, EventArgs e)
        {
           
        }

        private void TabsCtls_Selected(object sender, TabControlEventArgs e)
        {

        }

        private void btnPreStockMoney_Click(object sender, EventArgs e)
        {

        }

        private void btnAssetsExport_Click(object sender, EventArgs e)
        {
            using (GridViewBase grid = new GridViewBase())
            {
                grid.ExportDataGridView(pathmodel.exportPath, "Acc_Confirm", dgVerifyAssetsInfo);
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

        private void btnWorkCost_Click(object sender, EventArgs e)
        {
            AccidFormShow(UpdateFormEnum01.None, UpdateFormClass.Cost_WorkOffice);
        }

        private void btnSettle_Click(object sender, EventArgs e)
        {
            CreateCostLedger(AccountingReso.yearnow);
        }

        private void CreateCostLedger(int computeyear)
        {
            AccountEntities entity = new AccountEntities();
            LstFinanacialMsg.Items.Clear();
            bool checkresult = false;
            try
            {
                using (FinancialRptVModel financial = new FinancialRptVModel())
                {
                    var items = entity.JINSHINFINANCE035.Where(o=>o.Cost_Date.Value.Year == computeyear).ToList();
                    List<JINSHINFINANCE035> data01 = financial.CheckVerialOK(items);
                    checkresult = financial.RefreshGrid(data01, dataFinancialLedger);
                    if (checkresult && !chDataFull.Checked)
                    {
                        LstFinanacialMsg.Items.Add("CheckVerialOK");
                        return;
                    }
                    data01 = financial.CheckVerialLendAndGet(items);                                                                                                                                                                                                                                                                                                                                                                                            
                    checkresult = financial.RefreshGrid(data01, dataFinancialLedger);
                    if (checkresult)
                    {
                        LstFinanacialMsg.Items.Add("CheckVerialLendAndGet");
                        return;
                    }
                    List<VerifyCostDataModel> values = financial.GetYearsIncomeFinancialVal(items);
                    foreach (var item in values.GroupBy(o => o.costitem.Acc_ID))
                    {
                        if (item.GroupBy(o => o.Add).Count() > 2)
                        {
                            LstFinanacialMsg.Items.Add(item.First().costitem.Acc_ID + ":" + item.First().costitem.DataType + "," + item.First().costitem.Amount + ",IsAdd:有兩種");
                        }
                        else
                        {
                            if (item.First().Add.datatypectl == -1)
                                LstFinanacialMsg.Items.Add("*******" + item.First().costitem.Acc_ID + ":" + item.First().costitem.DataType + "," + item.First().costitem.Amount + ",IsAdd:" + item.First().Add.datatypectl);
                            else
                                LstFinanacialMsg.Items.Add(item.First().costitem.Acc_ID + ":" + item.First().costitem.DataType + "," + item.First().costitem.Amount + ",IsAdd:" + item.First().Add.datatypectl);
                        }
                    }
                    LstFinanacialMsg.Items.Add("本期結算金額:" + financial.GetYearIncomeResult(values));
                    using (JINSHINFINANCE036VModel legervmodel = new JINSHINFINANCE036VModel())
                    {
                        ybviewmodel.Clear();
                        ybviewmodel = acountremain.SetMoneyData();
                        List<string> msg = legervmodel.SaveData(entity, entity.JINSHINFINANCE036.Where(o=>o.Acc_Date.Value.Year == AccountingReso.yearnow).ToList(), ybviewmodel, true);
                        foreach (var item in msg)
                        {
                            LstFinanacialMsg.Items.Add(item);
                        }
                    }
                    acountremain.ShowFinancialLedgerGridView(dataFinancialLedger,computeyear,false);
                }
            }
            catch (Exception ex)
            {
                string str = ex.ToString();
            }
            finally
            {
                entity.Dispose();
            }
        }

        /// <summary>
        /// idxs are control cells idxs, default values is 0,6,2
        ///                                                sn,amount,acc_no
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgSettleGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dgFinancialSettlGridView.SelectedRows.Count > 0)
            {
                var rw = dgFinancialSettlGridView.SelectedRows[0];
                using (AccountEntityDB content = new AccountEntityDB())
                {
                    using (AccountEntities entity = content.GetEntity())
                    {
                        string[] idxs = dgFinancialSettlGridView.Tag.ToString().Split(',');
                        List<int> intidxs = new List<int>();
                        if (idxs.Count() > 3)
                        {
                            intidxs.Add(int.Parse(idxs[0]));
                            intidxs.Add(int.Parse(idxs[1]));
                            intidxs.Add(int.Parse(idxs[2]));
                        }
                        var items = entity.JINSHINFINANCE035.Where(o => o.Acc_No == rw.Cells[intidxs[2]].Value.ToString()).ToList();
                        ModifyDataFrm modifyfrm = new ModifyDataFrm(intidxs[0], intidxs[1]);
                        modifyfrm.values = items;
                        modifyfrm.ShowDialog();
                        intidxs.Clear();
                    }
                }
            }
        }
        private void DataBindSettleGridview(List<JINSHINFINANCE035> values)
        {
            using (AccNoGridView accnogv = new AccNoGridView())
            {
                dgFinancialSettlGridView.DataSource = values;
                accnogv.SetAccConfirmGridColumns(dgFinancialSettlGridView);
            }
        }
     
        private void btnSetttleQuery_Click(object sender, EventArgs e)
        {
            int datayear = 0;
            acountremain.ShowFinancialLedgerGridView(dataFinancialLedger,datayear,false);
        }

        private void btnArrangeNew_Click(object sender, EventArgs e)
        {
        //    string acc_no = "";
            List<int> vals = new List<int>();
            try
            {
                using (AccountEntityDB content = new AccountEntityDB())
                {
                    using (AccountEntities entity = content.GetEntity())
                    {
                        List<JINSHINFINANCE035> list = entity.JINSHINFINANCE035.Where(o => o.Cost_Date.Value.Year == AccountingReso.yearnow).ToList();
                        foreach (var item in ReportArrangeCostItem)
                        {
                            foreach (var v in item.values)
                            {
                                vals.Add(int.Parse(v.Acc_No.Substring(10, v.Acc_No.Length - 10)));
                                if (vals.Count == 2)
                                {
                                    if ((vals[1] - vals[0]) != 1)
                                    {
                                        List<JINSHINFINANCE035> items = list.Where(o => o.Acc_No == v.Acc_No).ToList();
                                        foreach (var i in items)
                                        {
                                            i.Acc_No = i.Acc_No.Substring(10, i.Acc_No.Length - 10) + vals[0].ToString().PadRight(3, '0');
                                        }
                                    }
                                    vals.Clear();
                                }
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
        }

        private void btnCheckAccNo_Click(object sender, EventArgs e)
        {
            AccountEntities entity = new AccountEntities();
            using (FinancialRptVModel financialmodel = new FinancialRptVModel())
            {
                var contents = AccCostItemConfig.GetClassData(entity.JINSHINFINANCE035.Where(o => o.Cost_Date.Value.Year == AccountingReso.yearnow).ToList());
                ReportArrangeCostItem = financialmodel.CheckAccNoSn(contents);
                foreach (var item in ReportArrangeCostItem)
                {
                    foreach (var v in item.values)
                    {
                        LstFinanacialMsg.Items.Add(v.Acc_No);
                    }                    
                }
            }
            entity.Dispose();
        }

        private void StatisticListBox(List<JINSHINFINANCE035> values, ListBox list)
        {
            string msg = "";
            list.Items.Clear();            
            using (FinancialRptVModel financialmodel = new FinancialRptVModel())
            {
                list.Items.Add("數量為:" + financialmodel.GetAccNoCount(values).ToString() + "個");
                msg = financialmodel.CheckVerialLendAndGet(values).Count > 0 ? "不平衡" : "平衡";
                list.Items.Add("借貸平衡:" + msg);
            }
        }

        private void btnCheckAccounts_Click(object sender, EventArgs e)
        {
            AccountEntities entity = new AccountEntities();
            using (FinancialRptVModel financialmodel = new FinancialRptVModel())
            {
            }
        }

        private void btnFinancialIncome_Click(object sender, EventArgs e)
        {
            ImportDataFormControl(ImportQueryClass.Financial_Income);
        }

        private void btnIncomeFinancial_Click(object sender, EventArgs e)
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    List<JINSHINFINANCE056> incomes = entity.JINSHINFINANCE056.OrderBy(o => o.orderth).ToList();
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
                                //  string str = "";
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
                                    AmountOrg = item.Amount ?? 0
                                };
                                var val = costledger.Where(o => o.Acc_ID == item.Accid).FirstOrDefault();
                                if (val != null)
                                {
                                    i.amount = val.Amount.Value;
                                    if (i.amount != i.AmountOrg)
                                    {
                                        msg = i.AccID.ToString() + ",計算," + i.amount + ",原來的," + i.AmountOrg;
                                        lstMsgIncomeStatment.Items.Add(msg);
                                        FinancialReportCompareMsg.Add(msg);
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
                                    amount = item.Amount ?? 0
                                });
                            }
                        }

                        IncomeFinancialRpt financialrpt = new IncomeFinancialRpt(financials, costledger,incomes);
                        StringBuilder sb = new StringBuilder();
                        foreach (var item in financialrpt.accids)
                        {
                            sb.Append(item.AccID + "," + item.amount + Environment.NewLine);
                        }
                        File.WriteAllText(pathmodel.exportPath + "Income" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".csv", sb.ToString(), Encoding.UTF8);

                        int cnt = 0;
                        foreach (var item in incomes)
                        {
                            cnt = cnt + 1;
                            if (cnt == 60)
                            {
                                //    string str = "";
                            }
                            if (item.datatype == 3)
                            {
                                financials.Add(new FinancialBase()
                                {
                                    ClassDesc = item.ClassDesc,
                                    DescData = item.DescData,
                                    orderth = item.orderth.Value,
                                    amount = financialrpt.accounts[item.ComputeNo.Value].amount
                                });
                            }
                        }
                        var valdata = financials.Where(o => o.AccID == "7151").ToList();
                        var datalist = financials.OrderBy(o => o.orderth).ToList();
                        DisplayReportDiffDataOnListBox(financialrpt.getReportDiffCheckData(), lstMsgIncomeStatment);
                        dgIncomeFinancial.DataSource = financials.OrderBy(o => o.orderth).ToList(); ;
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

        private void btnBalanceSheet_Click(object sender, EventArgs e)
        {
            ImportDataFormControl(ImportQueryClass.Balance_Sheet);
        }

        private void btnFinanceBalance_Click(object sender, EventArgs e)
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    List<JINSHINFINANCE054> balances = entity.JINSHINFINANCE054.Where(o => o.DescData != "本期損益").OrderBy(o => o.orderth).ToList();
                    List<JINSHINFINANCE036> costledger = entity.JINSHINFINANCE036.Where(o => o.Acc_Date.Value.Year == AccountingReso.yearnow).ToList();
                    BalanceSheetGridView gvitems = new BalanceSheetGridView();
                    financials.Clear();
                    lstMsgFinanceBalance.Items.Clear();
                    FinancialReportCompareMsg.Clear();
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
                                    AmountOrg = item.Amount ?? 0
                                };
                                var val = costledger.Where(o => o.Acc_ID == item.Accid).FirstOrDefault();
                                if (val != null)
                                {
                                    if (val.Acc_ID == "3351")
                                    {
                                        val.Amount = FinancialConfig.lastmoney;
                                        // val.Amount = val.Amount * -1 - FinancialConfig.todaymoney;
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
                                        lstMsgFinanceBalance.Items.Add(msg);
                                        FinancialReportCompareMsg.Add(msg);
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
                                    moneytype = item.MoneyType.Value
                                });
                            }
                        }
                        financials.Add(new FinancialBase()
                        {
                            ClassDesc = "權益",
                            DescData = AccountingReso.yearnow.ToString() + "年度本期損益",
                            orderth = 38,
                            moneytype = 4,
                            AccID = "3353",
                            datatypectl = 1,
                            amount = FinancialConfig.todaymoney
                        });

                        var values = financials.Where(o => o.AccID == "3351").ToList();
                        BalanceFinancialRpt financialrpt = new BalanceFinancialRpt(financials, costledger,balances);
#if (debug)
                    StringBuilder sb = new StringBuilder();
                    foreach (var item in financialrpt.accids)
                    {
                        sb.Append(item.AccID + "," + item.amount + Environment.NewLine);
                    }
                    File.WriteAllText(pathmodel.exportPath + "Balance" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".csv", sb.ToString(),Encoding.UTF8);
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
                                    moneytype = item.MoneyType.Value
                                });
                            }
                        }
                        //lstMsgFinanceBalance diff
                        DisplayReportDiffDataOnListBox(financialrpt.getReportDiffCheckData(), lstMsgFinanceBalance);
                        var datalist = financials.OrderBy(o => o.orderth).ToList();
                        dgBalanceFinancial.DataSource = financials.OrderBy(o => o.orderth).ToList(); ;
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

        private void btnReportExportData_Click(object sender, EventArgs e)
        {
            using (GridViewBase grid = new GridViewBase())
            {
                grid.ExportDataGridView(pathmodel.exportPath, "ReportTotalCostAccounts", dataFinancialLedger);
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

        

        private void btnBalanceReportData_Click(object sender, EventArgs e)
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
            foreach (var item in FinancialReportCompareMsg)
            {
                content = content + item + Environment.NewLine;
            }
            File.WriteAllText(pathmodel.exportPath + filename + ".csv", content, Encoding.UTF8);
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
                File.WriteAllText(pathmodel.ReportPath + "IncomeStatementReport" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".csv", reporthead.ToString(),Encoding.UTF8);
            }
        }

        private bool SwhoBalanceReportMsg(string reporttype,DataGridView dgv)
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
        private void btnBalanceReport_Click(object sender, EventArgs e)
        {
            string head = "金心資訊科技有限公司" ;
            string reporttype = (AccountingReso.yearnow - 1911).ToString() + "資產負債表" ;
            List<string> reportdata = new List<string>();
            reportdata.Insert(0, reporttype);
            reportdata.Insert(0, head);
            reportdata.Add("分類,項目,金額,分類,項目,金額" );
            if (SwhoBalanceReportMsg("資產負債", dgBalanceFinancial))
            {
                try
                {
                    var data01 = financials.Where(o => o.moneytype == 1 || o.moneytype == 2).OrderBy(o=>o.orderth).ToList();
                    var data02 = financials.Where(o => o.moneytype != 1 && o.moneytype != 2).OrderBy(o=>o.orderth).ToList();

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
            // File.WriteAllText(ReportPath + "IncomeStatementReport" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".csv", reporthead.ToString());
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

        private void btnProduceYearBookData_Click(object sender, EventArgs e)
        {

        }

        private void btnExportYearBook_Click(object sender, EventArgs e)
        {
           
        }

        private void FinancialFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void btnAccInputSave_Click(object sender, EventArgs e)
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
                        if (lst.Count() == 0)
                        {
                            txDiaAccNo.Text = AccountingReso.accno_id + dtAccPicker.Value.ToString("yyyyMMdd") + "001";
                        }
                        else
                            txDiaAccNo.Text = AccountingReso.accno_id + dtAccPicker.Value.ToString("yyyyMMdd") + (no.Max() + 1).ToString("000");
                    }
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
                        QueryAccInputAcc_No();
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

        private void coSelectLink_SelectedIndexChanged(object sender, EventArgs e)
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

        private string ConvertCell(object val)
        {
            if (val != null)
                return val.ToString();
            else return "";
        }
        private void dgAccAccountsData_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TempGridModify(e.ColumnIndex,e.RowIndex);
        }

        private void TempGridModify(int colidx,int rowidx)
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

        private void btnAccInputNew_Click(object sender, EventArgs e)
        {
            lblDiaNoValue.Text = "New";
            lblAccInputPos.Text = AccInputPosModel.NewRecord;
        }

        private void dgAccAccountsData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DeleteRecordData();
            }
        }

        private void DeleteRecordData()
        {
            if (MessageBox.Show("請確認是否刪除此筆資料", "對話框", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                List<JINSHINFINANCE035> result = new List<JINSHINFINANCE035>();
                List<JINSHINFINANCE035> items = dgAccAccountsData.DataSource as List<JINSHINFINANCE035>;
                //  dgAccAccountsData
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
                dgAccAccountsData.DataSource = result;
            }
        }

        private void btnDeleteQueryAcc_Click(object sender, EventArgs e)
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    int year = int.Parse(txQueryAccYear.Text);
                    int month = int.Parse(txQueryAccMonth.Text);
                    List<JINSHINFINANCE035> vals = new List<JINSHINFINANCE035>();
                    if (chQueryAcc.Checked)
                    {
                        vals = entity.JINSHINFINANCE035.Where(o => o.Cost_Date.Value.Year == year
                         && o.Cost_Date.Value.Month == month && o.Status == coststatus.diaryaccount).ToList();
                    }
                    else
                        vals = entity.JINSHINFINANCE035.Where(o => o.Cost_Date.Value.Year == year
                    && o.Cost_Date.Value.Month == month && o.Status == coststatus.accountcreated).ToList();
                    entity.JINSHINFINANCE035.RemoveRange(vals);
                    entity.SaveChanges();
                }
            }
        }

        private void btnAccGenerate_Click(object sender, EventArgs e)
        {
            using (DiaryAccounts accounts = new DiaryAccounts())
            {
                accounts.SaveAccountsToDB(accounts.values.Where(o => o.IsDefaultAccount == true).ToList(),int.Parse(txAccMonth.Text));
            }
        }

        private void btnDiaryCreate_Click(object sender, EventArgs e)
        {
            int year = int.Parse(txQueryAccYear.Text);
            int month = int.Parse(txQueryAccMonth.Text);
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    List<JINSHINFINANCE035> list = GetYearMonthCostItem(entity, year, month);
                    foreach (var item in list)
                    {
                        item.Status = coststatus.diaryaccount;
                    }
                    entity.SaveChanges();
                }
            }
        }

        private void btnDiaryExport_Click(object sender, EventArgs e)
        {
            using (GridViewBase grid = new GridViewBase())
            {
                grid.ExportDataGridView(pathmodel.exportPath, "Diary_Data_", dgQueryData);
            }
        }

        private void txDiaAccDesc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txDiaAmount.Focus();
            }
        }

        private void txDiaAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAccInputSave_Click(new object(), new EventArgs());
            }
        }

        private void dgCostItemView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CostItemModify(e.ColumnIndex,e.RowIndex);

        }

        private void CostItemModify(int colindex,int rowindex)
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

        private void btnAccInputSave_Click_1(object sender, EventArgs e)
        {
            if (lblAccInputPos.Text == AccInputPosModel.DBStatus)
            {
                int sn = int.Parse(lblDiaNoValue.Text);
                using (AccountEntityDB content = new AccountEntityDB())
                {
                    using (AccountEntities entities = content.GetEntity())
                    {
                        var val = entities.JINSHINFINANCE035.Where(o => o.SN == sn).FirstOrDefault();
                        val.Acc_No = txDiaAccNo.Text;
                        val.Acc_Desc = txDiaAccDesc.Text;
                        val.Amount = Convert.ToDecimal(txDiaAmount.Text);
                        entities.SaveChanges();
                    }
                }
                QueryAccInputAcc_No();
            }
            btnAccQuery_Click(new object(),new EventArgs());
        }

        private void btnAccQuery_Click(object sender, EventArgs e)
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entities = content.GetEntity())
                {
                    QueryAccCostStatus(entities, dtAccPicker.Value.Year, dtAccPicker.Value.Month);
                    AccAccountsGridView accountsgridview = new AccAccountsGridView();
                    accountsgridview.SetAccConfirmGridColumns(dgCostItemView);
                }
            }
        }

        private void QueryAccCostStatus(AccountEntities entities,int year,int month)
        {
            //int year = int.Parse(txAccYear.Text);
            //int month = int.Parse(txAccMonth.Text);
            dgCostItemView.DataSource = entities.JINSHINFINANCE035.Where(o => o.Cost_Date.Value.Year == year
          && o.Cost_Date.Value.Month == month && o.Status == coststatus.accountcreated).OrderBy(o => o.Acc_No).ToList();
        }

        private void dgCostItemView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DeleteCostAccItem();
            }
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

        private void btnAccInputCost_Click(object sender, EventArgs e)
        {
            QueryAccInputAcc_No();
        }

        private void QueryAccInputAcc_No()
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entities = content.GetEntity())
                {
                    dgCostItemView.DataSource = entities.JINSHINFINANCE035.Where(o => o.Cost_Date.Value.Year == dtAccPicker.Value.Year
        && o.Cost_Date.Value.Month == dtAccPicker.Value.Month && o.Status == coststatus.accountcreated && o.Acc_No == txAccInputdgAcc.Text.Trim())
        .OrderBy(o => o.Acc_No).ToList();
                    AccAccountsGridView accountsgridview = new AccAccountsGridView();
                    accountsgridview.SetAccConfirmGridColumns(dgCostItemView);
                }
            }
        }

        private void btnConvert_Click_1(object sender, EventArgs e)
        {

        }

        private void btnChange_Click_1(object sender, EventArgs e)
        {

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
                    if (checkresult && chExportVerify.Checked == false)
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            DeleteRecordData();
        }

        private void dgAccAccountsData_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgCostItemView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            CostItemModify(e.ColumnIndex,e.RowIndex);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteRecordData();
            }
            catch (Exception ex)
            {
                LogControl.LogAlarm(ex.ToString(),"刪除資料動作");
            }
        }

        private void btnInteliAccDelete_Click(object sender, EventArgs e)
        {
            DeleteCostAccItem();
        }

        private void btnSetup_Click(object sender, EventArgs e)
        {
            using (SysSettingCtl setting = new SysSettingCtl())
            {
                if (!setting.GetNumberText(txtSYear.Text))
                    MessageBox.Show(MsgText.SysSettingNumMsg);
                string resource_name = "AccYear";
                using (AccountEntityDB content = new AccountEntityDB())
                {
                    using (AccountEntities account = content.GetEntity())
                    {
                        var data = account.JINSHINFINANCE017.Where(o => o.SysName == resource_name).FirstOrDefault();
                        if (data != null)
                        {
                            data.SysVal = txtSYear.Text;
                        }
                        else
                        {
                            JINSHINFINANCE017  sys = new JINSHINFINANCE017();
                            sys.SysName = resource_name;
                            sys.SysVal = txtSYear.Text;
                            sys.CreateTime = DateTime.Now;
                            account.JINSHINFINANCE017.Add(sys);
                        }
                        account.SaveChanges();
                    }
                }
            }
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {

        }
    }
    
}
