using JINSHIN.BUSINESS.LIBARY.Models;
using JINSHIN.Finance.AccountSystem;
using System;
using System.IO;

namespace FinanceAccountProgram.Models.Config
{
    public class PathModel :VBase
    {
        public string id = accounting.accGovNo;
        public string year = accounting.accYear;
        public string data2Path = "";
        public string data3Path = "";
        public string aiinfopath = "";
        public string path = "";
        public string taxFileStr = "gsl";
        public string aiextension = ".csv";
        public string compareextension = ".txt";
        public string maptitle = "ConvertMap";
        public string datapath02 = @"\Data2\";
        public string datapath03 = @"\Data3\";
        public string ameraPic = @"\Exports\";
        public string exportPath = @"\Exports\";
        public string datapath10 = @"\Data10\";
        public string filepath = "";
        public string comparepath01 = @"";
        public string intelligenceComparesrc = "10769746686gsl2.csv";
        public string intelligenceComparedst = "107697466862.csv";
        private string datapath01 = @"\Data\";
        private string AIInfo = @"\AIInfo\";
        public string moneyfile = "money.txt";
        private string FinancePath = @"\Finance\";
        private string datapathUpdate = @"\UpdateCenter\";       
        public string dataUpdateCenter { get; set; }
        public string moneypath { get; set; }
        public string ReportPath = @"\Report\";
        public PathModel()
        {
            path = Environment.CurrentDirectory;
            DirectoryInfo di = new DirectoryInfo(path);
#if(DEBUG)
            path = di.Parent.Parent.FullName;
#else
            path = accounting.ClickPath;
#endif

#if (DEBUG)
            data2Path = di.Parent.Parent.FullName + datapath02;
            data3Path = di.Parent.Parent.FullName + datapath03;
            datapath10 = di.Parent.Parent.FullName + datapath10;
            exportPath = di.Parent.Parent.FullName + exportPath;
            filepath = di.Parent.Parent.FullName + datapath01;
            aiinfopath = di.Parent.Parent.FullName + AIInfo;
            moneypath = di.Parent.Parent.FullName + FinancePath;
            dataUpdateCenter = di.Parent.Parent.FullName + datapathUpdate;
            ReportPath = di.Parent.Parent.FullName + ReportPath;
            
#else
            if (!Directory.Exists(accounting.ClickPath))
            {
                Directory.CreateDirectory(accounting.ClickPath);
            }
            data2Path = accounting.ClickPath + datapath02;
            data3Path = accounting.ClickPath + datapath03;
            exportPath = accounting.ClickPath + exportPath;
            filepath = accounting.ClickPath + datapath01;
            aiinfopath = accounting.ClickPath + AIInfo;
            moneypath = accounting.ClickPath + FinancePath;
            dataUpdateCenter = accounting.ClickPath + datapathUpdate;
            ReportPath = accounting.ClickPath + ReportPath;
            datapath10= accounting.ClickPath + datapath10;
#endif

        }
    }
}
