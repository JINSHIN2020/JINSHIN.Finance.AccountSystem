
using JINSHIN.FinanceAccount.Libary.Config;
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
using WinInvoice.Models;
using WinInvoice.VModel;

namespace JINSHIN.Finance.AccountSystem.FrmControl.Invoice.DBManagement
{
    public partial class FrmDataForm : Form
    {
        public string picspath { get; set; }
        public string basepath { get; set; }
        public List<ClassModel> models01 { get; set; }
        public List<VJin035> models02 { get; set; }
        public List<VJin035> models03 { get; set; }
        public List<string> data03 { get; set; }
        public string datatitle { get; set; }
        public int datayear { get; set; }
        public FrmDataForm()
        {
            InitializeComponent();
            models01 = new List<ClassModel>();
            models02 = new List<VJin035>();
            models03 = new List<VJin035>();

            data03 = new List<string>();
            picspath = Environment.CurrentDirectory;
            DirectoryInfo di = new DirectoryInfo(picspath);
            datatitle =  "\\Invoice\\DBManagement\\imgs\\invoice03\\";
            //srctitle = "\\src\\";
            //dsttitle = "\\pics\\";
            //pdftitle = "\\pdfs\\";

#if (DEBUG)
            //picspath = di.Parent.Parent.FullName + dsttitle;
            basepath = di.Parent.Parent.Parent.FullName + datatitle;
#else
            //path = di.Parent.FullName + dsttitle;
            //basepath = di.Parent.FullName + datatitle;
            basepath = accounting.ClickPath +datatitle;
#endif

        }

        private void FrmDataForm_Load(object sender, EventArgs e)
        {

        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            List<string> newdata = new List<string>();
            List<string> data01 = new List<string>();
            List<string> data02 = new List<string>();
            List<string> data03 = new List<string>();
            //no invoice
            List<string> data05 = new List<string>();
            List<string> data06 = new List<string>();
            List<string> data07 = new List<string>();

            int datayear = Convert.ToInt32(txtYear.Text);
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    var jin035lst = entity.JINSHINFINANCE035.Where(v => v.Cost_Date.Value.Year
                                    == datayear).ToList();
                    var inv035lst = jin035lst.GroupBy(v => v.Invoice_No).ToList();
                    string invno = "";
                    foreach (var item in inv035lst)
                    {
                        var data = item.FirstOrDefault();
                        invno = data.Invoice_No;
                        ClassModel model = new ClassModel();
                        model.sn = data.SN;
                        model.month = data.Cost_Date.Value.Year;
                        model.dataname = data.Acc_Desc;
                        model.invno = invno;
                        model.accno = data.Acc_No;
                        models01.Add(model);
                    }

                    DirectoryInfo di = new DirectoryInfo(basepath);
                    string strdata = "";
                    listBox1.Items.Clear();
                    foreach (var item in di.GetFiles())
                    {
                        FileInfo fi = new FileInfo(item.FullName);
                        strdata = fi.Name.Replace(fi.Extension, "");
                        string[] values = strdata.Split(new string[] { "--" }, StringSplitOptions.None);
                        string invdata = "";
                        if (values.Count() > 1)
                        {
                            VJin035 jin35 = new VJin035();
                            jin35.date = values[0];
                            jin35.invoice = values[1];
                            jin35.fname = fi.Name;
                            jin35.datapath = item.FullName;
                            invdata = jin35.invoice.Replace("-", "");
                            invdata = invdata.Replace("-", "");
                            jin35.org_invoice = invdata;
                            //路徑
                            models02.Add(jin35);
                        }
                    }
                    string inv = "";
                    //db  models01 models03
                    foreach (var item in models01)
                    {
                        VJin035 jin35 = new VJin035();
                        jin35.sn = item.sn;
                        jin35.invoice = item.invno;
                        models03.Add(jin35);
                    }
                    string invoice01 = "";
                    string invoice02 = "";
                    var val02 = models02.Where(v => v.invoice.IndexOf("36057987") != -1)
                                .ToList();
                    foreach (var v in models01)
                    {
                        foreach (var item in models03)
                        {
                            if (v.invno != null && item.invoice != null)
                            {
                                invoice01 = v.invno.Replace("-", "");
                                invoice01 = invoice01.Replace("-", "");

                                invoice02 = item.invoice.Replace("-", "");
                                invoice02 = invoice02.Replace("-", "");

                                if (invoice01.IndexOf("22809928") != -1)
                                {
                                    string str = "";
                                }
                                var val = models02.Where(I => I.org_invoice == invoice01).FirstOrDefault();
                                if (val != null)
                                {
                                    FileInfo fi = new FileInfo(val.datapath);
                                    v.fname = fi.Name;
                                    if (invoice01 == invoice02)
                                    {
                                        v.chkdata = true;
                                        item.chkdata = true;
                                        item.datapath = val.datapath;
                                        break;
                                    }
                                }
                            }
                        }
                        if (!v.chkdata)
                        {
                            if (v.invno != null)
                            {
                                invoice01 = v.invno.Replace("-", "");
                                invoice01 = invoice01.Replace("-", "");
                                var val = models02.Where(i => i.org_invoice
                                            == invoice01).FirstOrDefault();
                                if (val != null)
                                {

                                    FileInfo fi = new FileInfo(val.datapath);
                                    v.fname = fi.Name;
                                    data01.Add(v.accno + "," + v.fname);
                                    listBox1.Items.Add(v.accno + "," +v.fname);
                                }
                                else
                                {
                                    data07.Add(v.invno);
                                    data01.Add(v.invno + "," +v.accno + "沒有檔案!");
                                    data05.Add(v.invno);
                                    listBox1.Items.Add(v.invno + "," + v.accno + "沒有檔案!");
                                }
                            }
                            else
                            {
                                data01.Add(v.accno + "沒有發票及檔案!");
                            }
                        }
                    }
                    data02 = SetDataText(data02);
                    //沒有發票的比對                    
                    bool datacontent = false;
                    foreach (var item in data05)
                    {
                        datacontent = false;
                        foreach (var v in models02)
                        {
                            if (v.org_invoice == item)
                            {
                                newdata.Add(item +"+");
                                datacontent = true;
                                break;
                            }
                        }
                        if (!datacontent)
                        {
                            newdata.Add(item);
                        }
                    }
                    foreach (var item in models03)
                    {
                        data03.Add(item.invoice);
                        if (item.chkdata)
                        {
                            if (item.datapath !=  null)
                            {
                                byte[] data = File.ReadAllBytes(item.datapath);
                                var jin35 = entity.JINSHINFINANCE035.Where(v => v.SN == item.sn)
                                                    .FirstOrDefault();
                                if (jin35 != null)
                                {
                                    var jindata = entity.JINSHINFINANCE035.Where(v => v.Acc_No == jin35.Acc_No).ToList();
                                    foreach (var vdata in jindata)
                                    {
                                        vdata.Img = data;
                                        vdata.ImgPath = item.datapath;
                                        entity.SaveChanges();
                                    }
                                }
                            }
                        }
                    }
                    ///資料庫資料整合
                    var jin35lst = entity.JINSHINFINANCE035.Where(v =>
                        v.Cost_Date.Value.Year ==datayear).GroupBy(v => v.Cost_Date).ToList();
                    foreach (var item in jin35lst)
                    {
                        var v = item.GroupBy(I => I.Invoice_No).ToList();
                        foreach (var x in v)
                        {
                            if (x.Count() > 1)
                            {
                                sb.Append(x.FirstOrDefault().Acc_No.ToString() +","+ x.FirstOrDefault().Cost_Date.Value.ToString("yyyyMMdd")
                                    +","+x.FirstOrDefault().Invoice_No+Environment.NewLine);
                            }
                        }
                    }

                    ///發票整合入jin35
                    foreach (var item in models02)
                    {
                        try
                        {
                            int year = Convert.ToInt32(item.date.Substring(0, 4));
                            int month = Convert.ToInt32(item.date.Substring(4, 2));
                            int day = Convert.ToInt32(item.date.Substring(6, 2));
                            DateTime dt = new DateTime(year, month, day);
                            var jin35 = entity.JINSHINFINANCE035.Where(v => v.Cost_Date.Value == dt)
                                        .ToList();
                            if (jin35.Count > 0)
                            {
                                var acc_no = jin35[0].Acc_No;
                                if (acc_no == "WF20220609001")
                                {
                                    string str = "";
                                }
                            }
                            jin35 = AccCostItemConfig.GetVerifyClassData(jin35);
                            string inv01 = item.invoice.Replace("-", "");
                            string inv02 = inv01.Replace("-", "");
                            string inv03 = "";
                            inv03 = item.invoice.Replace("-", "");
                            inv03 = inv03.Replace("-", "");
                            foreach (var v in jin35)
                            {
                                if (v.Invoice_No == null || v.Invoice_No == "")
                                {
                                    v.Invoice_No = inv03;
                                    entity.SaveChanges();
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            string str = ex.ToString();
                        }
                    }

                    foreach (var item in entity.JINSHINFINANCE035.Where(v =>
                    v.Invoice_No == null && v.Cost_Date.Value.Year ==datayear).ToList())
                    {
                        var data = entity.JINSHINFINANCE035.Where(v => v.Cost_Date.Value.Year == datayear
                        && v.Acc_No == item.Acc_No).ToList();
                        var val = data.Where(v => v.Invoice_No != null).FirstOrDefault();
                        if (val != null)
                        {
                            foreach (var m in data)
                            {
                                m.Invoice_No = val.Invoice_No;
                                m.Inv_Date = val.Inv_Date;
                                m.Sell_ID = val.Sell_ID;
                                m.Buy_ID = val.Buy_ID;
                            }
                            entity.SaveChanges();
                        }
                    }

                    //將發票的日期數大於一的， 寫入文字檔            
                    var datagroup = models02.GroupBy(v => v.date).ToList();
                    foreach (var item in datagroup)
                    {
                        foreach (var datainv in (item.GroupBy(v => v.org_invoice)))
                        {
                            string invoice = datainv.FirstOrDefault().org_invoice;
                            var jin35 = entity.JINSHINFINANCE035.Where(v =>
                            v.Invoice_No == invoice && v.Cost_Date.Value.Year == datayear).ToList();

                            if (jin35.Count > 1)
                            {
                                foreach (var m in jin35)
                                {
                                    if (datainv.FirstOrDefault() != null)
                                        sb.Append(m.Acc_No + "," +datainv.FirstOrDefault().date +","+datainv.FirstOrDefault().invoice + ","
                                            +Environment.NewLine);
                                }
                            }
                        }
                    }
                }
            }
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            newdata = newdata.Distinct().ToList();
            data02 = data02.Distinct().ToList();
            data03 = data03.Distinct().ToList();
            string d01 = "";
            string d02 = "";
            string d03 = "";
            string d05 = "";
            foreach (var item in newdata)
            {
                d01 += item + Environment.NewLine;
            }
            foreach (var item in models02)
            {
                d02 += item.invoice + Environment.NewLine;
            }
            foreach (var item in data03)
            {
                d03 += item + Environment.NewLine;
            }

            foreach (var item in data06)
            {
                d05 += item + Environment.NewLine;
            }
            foreach (var item in data07)
            {
                d05 += item + Environment.NewLine;
            }

            File.WriteAllText(basepath + "data01.txt", d01);
            File.WriteAllText(basepath + "data02.txt", d02);
            File.WriteAllText(basepath + "data03.txt", d03);
            File.WriteAllText(basepath + "data05.txt", sb.ToString());
            File.WriteAllText(basepath + "data06.txt", d05);

            foreach (var item in data01)
            {
                listBox1.Items.Add(item);
            }
            foreach (var item in data02)
            {
                listBox2.Items.Add(item);
            }

            dg01.DataSource = null;
            dg01.DataSource = models01;
            dg02.DataSource = null;
            dg02.DataSource = models03;
        }


        /// <summary>
        /// 檢查發票是否沒有媒合的
        /// </summary>
        public List<string> SetDataText(List<string> src)
        {
            string invoice01 = "";
            string invoice02 = "";
            foreach (var v in models02)
            {
                foreach (var item in models01)
                {
                    if (v.invoice != null && item.invno != null)
                    {
                        invoice01 = v.invoice.Replace("-", "");
                        invoice01 = invoice01.Replace("-", "");
                        invoice02 = item.invno.Replace("-", "");
                        invoice02 = invoice02.Replace("-", "");
                        if (invoice01 == invoice02)
                        {
                            v.chkdata = true;
                            v.datapath = v.datapath;
                            break;
                        }
                    }
                }
                if (!v.chkdata)
                {
                    if (v.invoice != null)
                    {
                        invoice01 = v.invoice.Replace("-", "");
                        invoice01 = invoice01.Replace("-", "");                        
                        listBox2.Items.Add("有發票!沒有資料~" + v.invoice);
                        src.Add("有發票!沒有資料~" + v.invoice);
                    }
                }
              }
            return src;
        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void dg02_Click(object sender, EventArgs e)
        {
            if (dg02.CurrentRow != null)
            {
                long sn = long.Parse(dg02.CurrentRow.Cells[0].Value.ToString());
                using (AccountEntityDB content = new AccountEntityDB())
                {
                    using (AccountEntities entity =  content.GetEntity())
                    {
                        var data = entity.JINSHINFINANCE035.Where(v => v.SN == sn).FirstOrDefault();
                        if (data.Img != null)
                        {
                            MemoryStream ms = new MemoryStream(data.Img);
                            picdata.Image = Image.FromStream(ms);
                            picdata.Refresh();
                        }
                        else
                        {
                            picdata.Image = null;
                            picdata.Refresh();
                        }
                    }
                }
            
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            List<string> setting = new List<string>()
            {
"WF20220109001","WF20220109002","WF20220120002","WF20220124001","WF20220203001",
"WF20220211001","WF20220217001","WF20220211001","WF20220218001","WF20220224001",
"WF20220225002","WF20220227001","WF20220326001","WF20220902001","WF20220908001",
"WF20220910001","WF20220223002","WF20220223003","WF20220216001","WF20220216002",
"WF20220913001", "WF20220301001" ,"WF20220429001" ,
"WF20220101001",
"WF20220401001",
"WF20220701002",
"WF20220701006",
"WF20220701008",
"WF20220901006",
"WF20221001003",
"WF20221101020",
"WF20221109001"};
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    foreach (var item in setting)
                    {
                        var jin35 = entity.JINSHINFINANCE035.Where(v => v.Acc_No == item).ToList();
                        if (jin35 != null)
                        {
                            entity.JINSHINFINANCE035.RemoveRange(jin35);
                        }
                    }
                    entity.SaveChanges();
                }
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}