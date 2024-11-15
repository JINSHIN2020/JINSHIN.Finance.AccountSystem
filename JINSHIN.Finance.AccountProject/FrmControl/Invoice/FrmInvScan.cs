#define DEBUG
using FinanceAccountProgram.Models.Config;
using FinanceAccountProgram.VModel.Business;
using JINSHIN.BUSINESS.LIBARY.Sercurity;
using JINSHIN.BUSINESS.LIBARY.VModel.InvModel;
using JINSHIN.Finance.AccountSystem.Controls;
using JINSHIN.FinanceAccount.Libary.Config;
using JINSHIN.FinanceAccount.Libary.Models.BarCode;
using JINSHIN.FinanceAccount.Libary.VModels.AccControl;
using JINSHIN.FinanceAccounting.DB;
using JINSHIN.FinanceAccounting.DB.VModel;
using JINSHIN.Package.Libary.InvScan;
using JINSHIN.Package.Libary.InvScan.Model;
using JINSHIN.Package.Libary.InvScan.PlayerRound;
using JINSHIN.Package.Libary.InvScan.VModel;
using JINSHIN.Packages.Libary.InvScan;
using JINSHIN.RegProcess.Liary.Content.Register.Sercurity;
using JINSHIN.WORK.Resource;
using JINSHINVision;
using JINSHINVision.Model;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AForge.Controls.VideoSourcePlayer;
using Point = OpenCvSharp.Point;

namespace JINSHIN.Finance.AccountSystem.FrmControl.Invoice
{
    public partial class Frm_InvScan : Form
    {
        public JINSHIN_VideoPlayer player { get; set; }
        public CodeMgtClass codeclass { get; set; }
        private string imgbasepath { get; set; }
        private string imgPath { get; set; }
        public int datatype { get; set; }
        private RotateFlipType ptype { get; set; }
        public CardInfo info { get; set; }
        private bool IsCreateImg { get; set; }
        public string logintype { get; set; }
        private InvVModel vmodel { get; set; }
        private int timemax { get; set; }
        public DateTime drawtime { get; set; }
        public Bitmap orgbmp { get; set; }
        public Bitmap drawbmp { get; set; }
        public Bitmap bmp01 { get; set; }
        public Bitmap bmp02 { get; set; }
        public Bitmap bmp03 { get; set; }
        public RectClass rectclass { get; set; }
        public CardInfo cardinfo01 { get; set; }
        public CardInfo cardinfo03 { get; set; }
        public CardInfo cardinfo02 { get; set; }
        public InvModel invmodel { get; set; }
        public int top { get; set; }
        public int bottom { get; set; }
        public string selectfilename { get; set; }
        public Bitmap barcodebmp { get; set; }
        public int ttlcnt { get; set; }
        public List<string> msg { get; set; }
        public bool display { get; set; }
        public string dir { get; set; }
        public string idno { get; set; }
        public LicenseVModel licensemodel { get; set; }
        public bool RunRight { get; set; }

        public Frm_InvScan()
        {
            InitializeComponent();

            ptype = RotateFlipType.Rotate180FlipXY;
            licensemodel = new LicenseVModel();
            cardinfo01 = new CardInfo();
            msg = new List<string>();
            rectclass = new RectClass();
            vmodel = new InvVModel();
            logintype = "1";
            timemax = 3;
            IsCreateImg = Convert.ToBoolean(Resource.CreateImage);
            info = new CardInfo();
            codeclass = new CodeMgtClass(MediaPlayer);
            #region code setting
            codeclass.delaysec = 0;
            codeclass.photocnt = 1;
            #endregion
         //   ptype = RotateFlipType.Rotate180FlipY;
            try
            {
                player = new JINSHIN_VideoPlayer(videoplayers);
                videoplayers.NewFrame += new NewFrameHandler(NewFrame);
                imgPath = "imgs";
#if (DEBUG)
                DirectoryInfo di = new DirectoryInfo(Application.StartupPath);
                imgbasepath = di.Parent.Parent.FullName + "\\" + imgPath + "\\";
                invmodel = new InvModel();
                dir = imgbasepath;
#else        
                dir = accounting.ClickPath + "\\CameraPics\\";
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }               
#endif
            }
            catch (Exception ex)
            {

            }

            SysRescControlVModel.Let1366ToMaxWindowSize(this);

        }
        private void NewFrame(object sender, ref Bitmap bmp)
        {
            if (bmp != null)
            {

                try
                {

                    bmp.RotateFlip(ptype);

                    lock (bmp)
                    {
                        orgbmp = bmp;
                        drawbmp = (Bitmap)bmp.Clone();
                        DrawRect(orgbmp);
                        //     DrawTheKeyPoint();
                    }

                }
                catch (Exception ex)
                {
                    string str = ex.ToString();
                }
            }

        }
        private void ClearInfo()
        {
            info.name = "";
            info.logintype = "";
            info.companyname = "";// Variable.CompanyName;
            info.datestr = "";
            info.hasdetect = false;
            player.memorydata.Clear();
            lab01.Text = "";
            lab02.Text = "";
            lab03.Text = "";
        }

        private void DrawRectBarCode(Bitmap newbmp)
        {
            Pen p = new Pen(Color.Red);
            rectclass = BuildTheRects(rectclass, newbmp);
            p.Width =3;
            bmp01 = new Bitmap(rectclass.left_rect.Width, rectclass.left_rect.Height);
            bmp01.SetResolution(90, 90);
            bmp02 = new Bitmap(rectclass.right_rect.Width, rectclass.right_rect.Height);
            bmp02.SetResolution(90, 90);
            bmp03 = new Bitmap(rectclass.center_top.Width, rectclass.center_rect.Height);
            bmp03.SetResolution(90, 90);
            Graphics g = Graphics.FromImage(bmp01);
            Graphics g2 = Graphics.FromImage(bmp02);
            Graphics g3 = Graphics.FromImage(bmp03);
            try
            {
                Rectangle dstrect = new Rectangle(0, 0, rectclass.left_rect.Width, rectclass.left_rect.Height);
                Rectangle dstrect01 = new Rectangle(0, 0, rectclass.right_rect.Width, rectclass.right_rect.Height);
                Rectangle dstrect02 = new Rectangle(0, 0, rectclass.center_rect.Width, rectclass.center_rect.Height);
                g.DrawImage(newbmp, dstrect, rectclass.left_rect, GraphicsUnit.Pixel);
                g2.DrawImage(newbmp, dstrect01, rectclass.right_rect, GraphicsUnit.Pixel);
                g3.DrawImage(newbmp, dstrect02, rectclass.center_top, GraphicsUnit.Pixel);
                if (bmp03 != null)
                    bmp03.Save(dir +"3-"+DateTime.Now.ToString("yyyyMMddHHmmss")+".bmp");
            }
            catch (Exception ex)
            {

            }

            p.Dispose();
            g.Dispose();
            g2.Dispose();
            g3.Dispose();
        }

        private void DetectData()
        {
            ClearInfo();
            if (orgbmp != null)
            {
                DrawRectBarCode(orgbmp);
                cardinfo01 = codeclass.DetectDirectBarCode(codeclass, player, bmp01, ZXing.BarcodeFormat.QR_CODE);
                cardinfo01.drawText = codeclass.datatext;
                cardinfo01.IsGet =codeclass.IsGet;
                try
                {
                    cardinfo03 = codeclass.DetectDirectBarCode(codeclass, player, bmp03, ZXing.BarcodeFormat.CODE_39);
                    cardinfo02 = codeclass.DetectDirectBarCode(codeclass, player, bmp02, ZXing.BarcodeFormat.QR_CODE);
                    cardinfo02.drawText = codeclass.datatext;
                    cardinfo02.IsGet = codeclass.IsGet;
                    lab01.Text = cardinfo01.name;
                    lab03.Text = cardinfo03.name;
                    lab02.Text = cardinfo02.name;
                }
                catch (Exception ex)
                {
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            bool RunContinute = false;
            RunRight = false;
            if (videoplayers.IsRunning)
            {
                try
                {
                    DetectData();
                    if (cardinfo01.drawText != "")
                    {
                        RunContinute=ChkImgPhotoData(cardinfo01);
                        RunRight = true;
                    }
                    if (cardinfo02 != null)
                    {
                        if ((cardinfo02.drawText != "") && (!RunContinute))
                        {
                            RunContinute =ChkImgPhotoData(cardinfo02);
                            RunRight = true;
                        }
                        //if (!RunContinute)
                        //{
                        //    System.Threading.Thread.Sleep(6000);
                        //    lblIDNO.Text = "";
                        //    lblDateStr.Text = "";
                        //    lblSign.Text = "";
                        //    info.datestr = "";
                        //}
                        //   RunRight = true;
                    }
                    if (RunRight)
                        timer1.Enabled = !RunContinute;
                    else
                        timer1.Enabled = true;

                }
                catch (Exception ex)
                {
                    string str = ex.ToString();
                    timer1.Enabled = true;
                }
                
            }
            else
            { 
               timer1.Enabled = true;
            }
        }

        private bool ChkImgPhotoData(CardInfo cardinfo)
        {
            bool RunContinute = false;
            DateTime dt = DateTime.Now;
            if (cardinfo.IsGet)
            {
                using (MedialControl media = new MedialControl(MediaPlayer))
                {
                    media.PlayGet();
                    cardinfo.logintype = logintype;
                    if (cardinfo.name != null)
                    {
                        if (vmodel.CheckInv(cardinfo.name))
                        {
                            invmodel = vmodel.ConvertInvFormat(cardinfo.name);
                            DisplayInfo(invmodel);
                            RunContinute = true;
                        }
                        else
                            lblSign.Text = info.name;
                    }
                    while (media.Playing() && DateTime.Now.Subtract(dt).Seconds > timemax) ;
                }
            }
            else
            {
                if (cardinfo != null)
                    cardinfo.name = "";
            }

            return RunContinute;
        }

        private RectClass BuildTheRects(RectClass rectclass, Bitmap fdrawbmp)
        {
            int wsize = 4;
            int hsize = 4;
            int MoveY = 2;

            int rectw = Convert.ToInt32(fdrawbmp.Width / 8 * wsize);
            int recth = Convert.ToInt32(fdrawbmp.Height / 8 * hsize);

            int centermoveY = Convert.ToInt32(fdrawbmp.Height / 8 * MoveY);
            recth = recth + centermoveY;
            int rectpos01 = 0;
            int rectpos02 = 0;
            rectpos01 = Convert.ToInt32(fdrawbmp.Height * 1.0 * 0.37) - centermoveY;
            rectpos02 = Convert.ToInt32(fdrawbmp.Width * 1.0 * 0.37);
            double radioh = rectpos01 *1.0 / fdrawbmp.Height * 1.0;
            double radiow = rectpos02 * 1.0 / fdrawbmp.Width * 1.0;
            int center = fdrawbmp.Height / 2;
            int centerdiff = 200;
            int center_w = fdrawbmp.Width /2;
            int center_h = 200;
            int rh = rectpos01 + recth > fdrawbmp.Height ? fdrawbmp.Height - rectpos01 : recth;
            int rw = center + rectw > fdrawbmp.Width ? fdrawbmp.Width - center : rectw;
            int rect_more = 20;

            int center_hdiff = 200;
            int center_hdata = Convert.ToInt32(center / 6);
            int center_hp = center - center_hdiff - rh < 0 ? 0 : center - center_hdiff - rh;

            rectclass.left_rect =new Rectangle(0, rectpos01, rectw + rect_more, rh);
            rectclass.right_rect =new Rectangle(center_w - rect_more, rectpos01, rectw+rect_more, rh);

            rectclass.center_rect = new Rectangle(0, center - centerdiff/2, fdrawbmp.Width, center_h);
            rh = rh > center ? center  + Convert.ToInt32(center /6) : rh;


            rectclass.center_top = new Rectangle(0, center_hp,
                fdrawbmp.Width, rh);
            return rectclass;
        }

        private void DrawRect(Bitmap drawbmp)
        {
            Graphics g = Graphics.FromImage(drawbmp);
            Pen p = new Pen(Color.Red), blue = new Pen(Color.Blue);
            Pen colorcenter = new Pen(Color.Brown);

            rectclass = BuildTheRects(rectclass, drawbmp);
            p.Width = 3;
            g.DrawRectangle(p, rectclass.left_rect);
            System.Drawing.Point ps01 = new System.Drawing.Point(0, drawbmp.Height /2);
            System.Drawing.Point pe01 = new System.Drawing.Point(drawbmp.Width, drawbmp.Height /2);
            System.Drawing.Point ps02 = new System.Drawing.Point(drawbmp.Width /2, 0);
            System.Drawing.Point pe02 = new System.Drawing.Point(drawbmp.Width/2, drawbmp.Height);
            g.DrawLine(blue, ps01, pe01);
            g.DrawLine(blue, ps02, pe02);
            g.Dispose();
            p.Dispose();

        }

        private void DisplayInfo(InvModel model)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("發票編號 :"+model.InvNO + Environment.NewLine);
            sb.Append("日期:" + model.InvDate + Environment.NewLine);
            sb.Append("小計:" + model.InvAmount + Environment.NewLine);
            sb.Append("總計:" + model.InvTtlAmount + Environment.NewLine);
            sb.Append("買方統一編號:" + model.buyId + Environment.NewLine);
            sb.Append("賣方統一編號:" + model.selId + Environment.NewLine);
            lblSign.Text = sb.ToString();
            sb.Clear();
            model.Dispose();
            if (!player.IsSave)
                player.IsSave = true;
            codeclass.IsGet = false;
            codeclass.datatext = "";
        }

        private void 檢視攝影機ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            codeclass.DevClose(player, videoplayers);
            player.ShowVideoForm(this, videoplayers);
        }

        private void 攝影機反轉ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ptype = RotateFlipType.Rotate180FlipXY;
        }

        private void btnOffice_Click(object sender, EventArgs e)
        {
            BuildTheCostData("Office365", 2, 2, chInput.Checked);
        }

        private void btnOhterCost_Click(object sender, EventArgs e)
        {
            BuildTheCostData("雜費", 6, 6, chInput.Checked);
        }
        private void BuildTheCostData(string name, int mlink, int dlink,bool NoAutoInput)
        {
            try
            {
                using (AccountEntityDB content = new AccountEntityDB())
                {
                    using (AccountEntities entity = content.GetEntity())
                    {
                        if (!NoAutoInput)
                          AutoInputData(mlink, dlink, entity);
                        {
                            if (invmodel == null)
                                invmodel = new InvModel();
                            invmodel.InvDate = datapicker.Value;
                            invmodel.InvDate = new DateTime(datapicker.Value.Year,datapicker.Value.Month,datapicker.Value.Day);
                            string acc_no = "WF" + invmodel.InvDate.Value.Year.ToString("0000") 
                                                            + invmodel.InvDate.Value.Month.ToString("00")
                                  +invmodel.InvDate.Value.Day.ToString("00");
                            string strlen = "";
                            for (int i = 0; i < AccountingReso.accnoLen; i++)
                            {
                                strlen += "0";
                            }
                            var val = entity.JINSHINFINANCE035.Where(i => i.Acc_No.IndexOf(acc_no) != -1).ToList();
                            int cnt = val.Count();
                            var data = entity.JINSHINFINANCE050.Where(o => o.Ddatalink == dlink
                                              && o.Mdatalink == mlink).OrderBy(i => i.Sn).ToList();
                            string master_accid = data.Where(o => o.AccId != "6123" && o.AccId != "1113").FirstOrDefault().AccId;
                            JINSHINFINANCE035 cost = SetManualInput(acc_no, strlen, cnt, master_accid,1,0);
                            entity.JINSHINFINANCE035.Add(cost);
                            if (rdTax.Checked)
                            {
                                JINSHINFINANCE035 tax = SetManualInput(acc_no, strlen, cnt, "6123", 1, 1);
                                entity.JINSHINFINANCE035.Add(tax);
                            }
                            JINSHINFINANCE035 ttl = SetManualInput(acc_no, strlen, cnt, "1113", 2, 2);
                            entity.JINSHINFINANCE035.Add(ttl);
                            entity.SaveChanges();
                        }
                    }
                }
                timer1.Enabled = true;
            }
            catch (Exception ex)
            {

            }
        }

        private JINSHINFINANCE035 SetManualInput(string acc_no, string strlen, int cnt, string master_accid,int datatype,int index)
        {
            JINSHINFINANCE035 cost = new JINSHINFINANCE035();
            cost.Acc_No = acc_no + (cnt+1).ToString(strlen);
            cost.Cost_Date = invmodel.InvDate;
            cost.Cost_M = Convert.ToByte(invmodel.InvDate.Value.Month);
            cost.Acc_ID = master_accid;
            cost.Acc_Desc = txtAccDesc.Text;
            cost.Inv_Date = invmodel.InvDate;
            cost.Invoice_No = txtInvNum.Text;
            cost.Sell_ID = txtSellID.Text;
            cost.Buy_ID = txtBuyID.Text;
            cost.DataType = Convert.ToByte(datatype);
            int ttlamount = Convert.ToInt32(txtAccAmount.Text);
            switch (index)
            {
                case 0: { cost.Amount = Convert.ToInt32(txtAccAmount.Text); } break;
                case 1: { cost.Amount = Convert.ToInt32(txtTaxValue.Text); } break;
                case 2: { cost.Amount = Convert.ToInt32(txtAccAmount.Text) +Convert.ToInt32(txtTaxValue.Text); } break;
                default:
                    break;
            }
            cost.Status = coststatus.accountcreated;
            return cost;
        }

        private void AutoInputData(int mlink, int dlink, AccountEntities entity)
        {
            var data = entity.JINSHINFINANCE050.Where(o => o.Ddatalink == dlink
                                               && o.Mdatalink == mlink).OrderBy(i => i.Sn).ToList();
            string title = entity.JINSHINFINANCE034.Where(o => o.No == mlink).FirstOrDefault().Name;

            if (invmodel != null)
            {
                string acc_no = "WF" + invmodel.InvDate.Value.Year.ToString("0000") + invmodel.InvDate.Value.Month.ToString("00")
                    +invmodel.InvDate.Value.Day.ToString("00");
                var val = entity.JINSHINFINANCE035.Where(i => i.Acc_No.IndexOf(acc_no) != -1).ToList();
                int cnt = val.Count();
                string strlen = "";
                for (int i = 0; i < AccountingReso.accnoLen; i++)
                {
                    strlen += "0";
                }
                decimal ttlamount = Convert.ToDecimal(invmodel.InvTtlAmount);
                decimal amount = Convert.ToDecimal(invmodel.InvAmount);
                string master_accid = data.Where(o => o.AccId != "6123" && o.AccId != "1113").FirstOrDefault().AccId;
                foreach (var item in data)
                {
                    JINSHINFINANCE035 cost = new JINSHINFINANCE035();
                    cost.Acc_No = acc_no + (cnt+1).ToString(strlen);
                    cost.Cost_Date = invmodel.InvDate;
                    cost.Cost_M = Convert.ToByte(invmodel.InvDate.Value.Month);
                    cost.Acc_ID = item.AccId;
                    cost.Acc_Desc = title;
                    cost.Inv_Date = invmodel.InvDate;
                    cost.Invoice_No = invmodel.InvNO;
                    cost.Sell_ID = invmodel.selId;
                    cost.Buy_ID = invmodel.buyId;
                    cost.DataType = Convert.ToByte(item.datatype.Value);
                    if (item.AccId == master_accid)
                    {
                        cost.Amount = amount;
                    }
                    else if (item.AccId == "6123")
                    {
                        cost.Amount = ttlamount - amount;
                    }
                    else if (item.AccId == "1113")
                    {
                        cost.Amount = ttlamount;
                    }
                    cost.Status = coststatus.accountcreated;
                    entity.JINSHINFINANCE035.Add(cost);
                }
                entity.SaveChanges();
            }
        }

        private void btnOilCost_Click(object sender, EventArgs e)
        {
            BuildTheCostData("油資", 7, 1,chInput.Checked);
        }

        private void btnMasterial_Click(object sender, EventArgs e)
        {
            BuildTheCostData("產品材料", 20, 1, chInput.Checked);
        }

        private void FrmInvScan_FormClosed(object sender, FormClosedEventArgs e)
        {
            codeclass.DevClose(player, videoplayers);
        }

        private void FrmInvScan_Load(object sender, EventArgs e)
        {
            datapicker.Value = DateTime.Now;
            licensemodel.License(idno);
            RefreshImageDir();
        }
       
      

        private void RefreshImageDir()
        {
            lstFiles.Items.Clear();
            if (dir != "" && dir !=null)
            {
                DirectoryInfo di = new DirectoryInfo(dir);
                foreach (var item in di.GetDirectories())
                {
                    DirectoryInfo info = new DirectoryInfo(item.FullName);
                    foreach (var i in info.GetDirectories())
                    {
                        DirectoryInfo i01 = new DirectoryInfo(i.FullName);
                        foreach (var ii01 in i01.GetFiles())
                        {
                            lstFiles.Items.Add(ii01.FullName);
                        }
                    }
                }
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUP_Click(object sender, EventArgs e)
        {
            RefreshImageDir();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void datapicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true; 
        }

        private void gbMoneyArea_Enter(object sender, EventArgs e)
        {

        }

        private void chInput_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (invmodel.InvDate != null)
            {
                int year = invmodel.InvDate.Value.Year;
                int month = invmodel.InvDate.Value.Month;
                if (!Directory.Exists(dir + year.ToString()))
                {
                    Directory.CreateDirectory(dir + year.ToString());
                }
                if (!Directory.Exists(dir + year.ToString() + "\\" + month.ToString() +"\\"))
                {
                    Directory.CreateDirectory(dir + year.ToString() + "\\" + month.ToString() +"\\");
                }
                if (drawbmp != null)
                    drawbmp.Save( dir + year.ToString() + "\\" + month.ToString() +"\\" +invmodel.InvNO+ ".bmp");
                else
                    MessageBox.Show("相機尚未啟動!");
            }
        }

        private void lstFiles_Click(object sender, EventArgs e)
        {
            string filepath = "";
            filepath = lstFiles.Text;
            if (filepath != "")
            {
                DlgFrmImg frmimg = new DlgFrmImg();
                frmimg.filepath = filepath;
                frmimg.ShowDialog();
            }
        }

        private void btnMeidaShare_Click(object sender, EventArgs e)
        {
            BuildTheCostData("媒體分攤", 32, 1, chInput.Checked);
        }

        private void btnPreRent_Click(object sender, EventArgs e)
        {
            BuildTheCostData("預付租金", 30, 1, chInput.Checked);
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            BuildTheCostData("應收帳款", 31, 2, chInput.Checked);
        }

        private void btnCostIn_Click(object sender, EventArgs e)
        {
            BuildTheCostData("銷貨成本", 20, 1, chInput.Checked);
        }

        private void btnPreIncome_Click(object sender, EventArgs e)
        {
            BuildTheCostData("預收收入", 31, 1, chInput.Checked);
        }

        private void btnOfenAffair_Click(object sender, EventArgs e)
        {          
            FrmOftenAccData oftendata = new FrmOftenAccData();
            oftendata.ShowDialog();
        }

        private void lab03_Click(object sender, EventArgs e)
        {

        }

        private void 設定ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Frm_InvScan_Shown(object sender, EventArgs e)
        {
            SysRescControlVModel.SetFixedWindow(this);
        }

        private void btnBookTool_Click(object sender, EventArgs e)
        {
            BuildTheCostData("油資", 6, 7, chInput.Checked);
        }
    }
}
