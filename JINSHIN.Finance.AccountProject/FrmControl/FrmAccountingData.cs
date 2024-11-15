using FinanceAccountProgram.Models;
using FinanceAccountProgram.Models.Config;
using FinanceAccountProgram.VModel;
using FinanceAccountProgram.VModel.Accounts;
using JINSHIN.Finance.AccountSystem.VModel.Conrols.GridView;
using JINSHIN.FinanceAccount.Libary.Models;
using JINSHIN.FinanceAccount.Libary.VModels.AccControl;
using JINSHIN.FinanceAccounting.DB;
using JINSHIN.FinanceAccounting.DB.VModel;
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

namespace JINSHIN.Finance.AccountSystem.FrmControl
{
    public partial class FrmAccountingData : Form
    {
        public PathModel pathmodel { get; set; }
        public List<BookConvert2> bookconvert { get; set; }
        public List<string> ConvertMap { get; set; }
        public List<string> fullfiles { get; set; }
        public string metadatafile { get; set; }
        public List<string> compareDesc = new List<string>() { "Double", "noData" };
        public string exportdocTitle { get; set; }
        public List<YearBeginViewModel> ybviewmodel { get; set; }
        public AccountRemainData acountremain { get; set; }
        List<string> fullfilesAno = new List<string>();
        public string filepath { get; set; }
        public string datapath01 { get; set; }
        public string keysfile = "106AccountMapTable.csv";
        private string ConvertFormatStr = "會計代碼:{0},會計項目:{1},轉換代碼:{2},轉換名稱{3}";
        public List<BookConvert2> books { get; set; }
      //  public List<JINSHINFINANCE038> ids { get; set; }
        public FrmAccountingData()
        {
            InitializeComponent();

            bookconvert = new List<BookConvert2>();
            DirectoryInfo di = new DirectoryInfo(Environment.CurrentDirectory);
            datapath01 = @"\MetaData\";
#if (DEBUG)
            filepath = di.Parent.Parent.FullName + datapath01;
#else
            filepath = accounting.ClickPath + datapath01;
#endif
            pathmodel = new PathModel();
            acountremain = new AccountRemainData();
            metadatafile = "";
            exportdocTitle = "";
            ConvertMap = new List<string>();
            fullfiles = new List<string>();
          //  compareDesc = new List<string>();
            ybviewmodel = new List<YearBeginViewModel>();

        }

        private void Init()
        {
            DirectoryInfo fls = new DirectoryInfo(pathmodel.data2Path);
            fullfilesAno.Clear();
         
            if (Directory.Exists(fls.FullName))
            {
                foreach (var item in fls.GetFiles())
                {
                    fullfilesAno.Add(item.FullName);
                }
            }
            SetDataFromPath(pathmodel.data2Path, fullfilesAno);
        }

        private void SetDataFromPath(string path, List<string> filelist)
        {
            filelist.Clear();
            DirectoryInfo fls2 = new DirectoryInfo(path);
            foreach (var i in fls2.GetFiles())
            {
                filelist.Add(i.FullName);
            }
        }

        private void FrmAccountingData_Shown(object sender, EventArgs e)
        {
            using (AccIdsGridViewItems gvitem = new AccIdsGridViewItems())
            {
                gvitem.SetAccConfirmGridColumns(dgData);
                dgData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                dgData.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                //for (int i = 0; i < dgData.Columns.Count-1; i++)
                //{
                //    dgData.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //}                               
                dgData.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                //dgData.Refresh();
            }
            RefreshData();
            SysRescControlVModel.SetFixedWindow(this);

        }

        private void RefreshData()
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    //using (AccIdsGridViewItems gvitem = new AccIdsGridViewItems())
                    //{
                        ConvertToAccidModel(entity.JINSHINFINANCE038.ToList());
                    //   gvitem.SetAccConfirmGridColumns(dgData);
                        dgData.DataSource = null;
                        dgData.DataSource = bookconvert;
                   // }
                }
            }
        }

        private void ConvertToAccidModel(List<JINSHINFINANCE038> values)
        {
            int idx = 1;
            bookconvert.Clear();
            foreach (var item in values.OrderBy(i => i.Acc_id))
            {
                BookConvert2 val = new BookConvert2();
                val.SN = idx;
                val.acc_id = item.Acc_id;
                val.acc_desc = item.Acc_Desc;
                bookconvert.Add(val);
                idx++;
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
        public Dictionary<string, string> GetData(string value)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            string[] keys = File.ReadAllLines(filepath + keysfile);
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
                        countryTax = GetData(ims[1]);
                        ConvertMap.Add(string.Format(ConvertFormatStr, ims[1], ims[4], countryTax.Keys.First(), countryTax.Values.First()));
                        lendorget.Clear();
                        lendorget = CheckLendOrGet(ims[5], ims[6]);
                        BookConvert2 bookcnt = new BookConvert2();
                        bookcnt.BookNo = ims[3];
                        DateTime.TryParse(ims[2], out dtime);
                        bookcnt.datadate = dtime;
                        bookcnt.TaxNo = ims[3];
                        bookcnt.acc_desc = ims[4];
                        bookcnt.acc_id = ims[1];
                        bookcnt.amountType = int.Parse(lendorget[0]);
                        content = string.Format("{0},{1},", pathmodel.id, pathmodel.year);
                        bookcnt.Leftvalues = content;
                        //資料格式修改 20220719
                        bookcnt.Rightvalues = string.Format("{0},{1},{2},{3},{4}", countryTax.Keys.First(), ims[3], ims[4], ims[1], ims[2]);
                        bookcnt.amount = double.Parse(lendorget[1]);
                        bookconvert.Add(bookcnt);
                        index++;
                    }

                    //營所稅的會科
                    content = "";
                    foreach (var i in ConvertMap)
                    {
                        content += i + Environment.NewLine;
                    }
                    //to save log and new file
                    //File.WriteAllText(pathmodel.aiinfopath + pathmodel.year + pathmodel.id + pathmodel.maptitle + index + pathmodel.compareextension, content);
                    index++;
                }

            }
            catch (Exception ex)
            {
                string exceptionstr = ex.ToString();
            }
            return bookconvert;
        }

        private void dgData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void btnQuery_Click(object sender, EventArgs e)
        {
            var data = bookconvert.Where(i => i.acc_id.IndexOf(txtValue.Text) != -1 || txtValue.Text == "").ToList();
            dgData.DataSource = null;
            dgData.DataSource = data;
        }

        private void plcontent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Init();
            books = GetBookToCountryFormatData();
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    using (AccIdsGridViewItems gvitem = new AccIdsGridViewItems())
                    {
                        var deldata = entity.JINSHINFINANCE038.ToList();
                        entity.JINSHINFINANCE038.RemoveRange(deldata);
                        entity.SaveChanges();
                        foreach (var item in books)
                        {
                            var check = entity.JINSHINFINANCE038.Where(i => i.Acc_id == item.acc_id).FirstOrDefault();
                            if (check == null)
                            {
                                JINSHINFINANCE038 accid = new JINSHINFINANCE038();
                                accid.Acc_id = item.acc_id;
                                accid.Acc_Desc = item.acc_desc;
                                accid.CDate = DateTime.Now;
                                accid.UpdatePerson = "andrew";
                                entity.JINSHINFINANCE038.Add(accid);
                                entity.SaveChanges();
                            }
                        }
                        ConvertToAccidModel(entity.JINSHINFINANCE038.ToList());                      
                        dgData.DataSource = bookconvert;
                    }
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idx = listBox1.SelectedIndex;
            switch (idx)
            {
                case 0: {
                        dgData.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    };break;
                case 1: {
                        dgData.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    };break;
                case 2: {
                        dgData.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    };break;
                case 3: {
                        dgData.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    };break;
                case 4: {
                        dgData.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    }
                    break;
                case 5: {
                        dgData.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    }
                    break;
                    

               
            }
        }
    }
}
