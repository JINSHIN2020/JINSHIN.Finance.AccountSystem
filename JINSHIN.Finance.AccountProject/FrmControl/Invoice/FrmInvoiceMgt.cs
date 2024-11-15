 using FinanceAccountProgram.Models.Config;
using JINSHIN.BUSINESS.LIBARY.VModel.InvModel;
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
    public partial class FrmInvoiceMgt : Form
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

        public FrmInvoiceMgt()
        {
            InitializeComponent();
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
            ptype = RotateFlipType.Rotate180FlipY;
            try
            {
                player = new JINSHIN_VideoPlayer(videoplayers);
                videoplayers.NewFrame += new NewFrameHandler(NewFrame);
                imgPath = "imgs";
#if (DEBUG)
                DirectoryInfo di = new DirectoryInfo(Application.StartupPath);
                imgbasepath = di.Parent.Parent.FullName + "\\" + imgPath + "\\";
#else
            if (IsCreateImg)
            {
                imgbasepath = Resource.ImgBasePath + "\\" + imgPath + "\\";
                if (!Directory.Exists(Resource.ImgBasePath))
                {
                    Directory.CreateDirectory(Resource.ImgBasePath);
                }
                if (!Directory.Exists(Resource.ImgBasePath + "\\" + imgPath + "\\"))
                {
                    Directory.CreateDirectory(Resource.ImgBasePath + "\\" + imgPath + "\\");
                }
            }
#endif            
            }
            catch (Exception ex)
            {
            
            }

        }


        private void DetectData()
        {
            ClearInfo();
            if (orgbmp != null)
            {
              //  orgbmp.Dispose();
             //   orgbmp = new Bitmap();
                DrawRectBarCode(orgbmp);
                cardinfo01 = codeclass.DetectDirectBarCode(codeclass, player, bmp01,ZXing.BarcodeFormat.QR_CODE);
                //rectclass.L_drawText = codeclass.datatext;
                //rectclass.L_IsGet = codeclass.IsGet;
                try
                {
                    cardinfo03 = codeclass.DetectDirectBarCode(codeclass, player, bmp03,ZXing.BarcodeFormat.CODE_39);
                    //rectclass.center_drawText = codeclass.datatext;
                    //rectclass.center_IsGet = codeclass.IsGet;

                    cardinfo02 = codeclass.DetectDirectBarCode(codeclass, player, bmp02,ZXing.BarcodeFormat.QR_CODE);
                    //rectclass.R_drawText = codeclass.datatext;
                    //rectclass.R_IsGet = codeclass.IsGet;
                    //bmp01.Dispose();
                    //bmp02.Dispose();
                    lab01.Text = cardinfo01.name;
                    lab03.Text = cardinfo03.name;
                    lab02.Text = cardinfo02.name;
                    //bmp01.Save(@"e:\1.bmp");
                    //bmp02.Save(@"e:\2.bmp");
                    //bmp03.Save(@"e:\3.bmp");
                }
                catch (Exception ex)
                {
                }
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer1.Interval = 650;
            if (videoplayers.IsRunning)
            {
                try
                {
                    DetectData();
                    DateTime dt = DateTime.Now;
                    if (rectclass.L_drawText != "")
                    {
                        if (rectclass.L_IsGet)
                        {
                            using (MedialControl media = new MedialControl(MediaPlayer))
                            {
                                media.PlayGet();
                                cardinfo01.logintype = logintype;
                                if (cardinfo01.name != null)
                                {
                                   if (vmodel.CheckInv(cardinfo01.name))
                                    { 
                                        invmodel = vmodel.ConvertInvFormat(cardinfo01.name);
                                        DisplayInfo(invmodel);
                                    }
                                    else
                                        lblSign.Text = info.name;
                                }
                                while (media.Playing() && DateTime.Now.Subtract(dt).Seconds > timemax) ;
                            }
                        }
                        else
                        {
                            if (cardinfo01 != null)
                              cardinfo01.name = "";
                        }
                    }
                    else
                    {
                        lblIDNO.Text = "";
                        lblDateStr.Text = "";
                        lblSign.Text = "";
                        info.datestr = "";
                    }
                }
                catch (Exception ex)
                {
                    string str = ex.ToString();
                }
            }
            timer1.Enabled = true;
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
      

        private void NewFrame(object sender, ref Bitmap bmp)
        {
            if (bmp != null)
            {
                //RotateFlipType ftype = RotateFlipType.Rotate180FlipX;
                //Stopwatch sw = new Stopwatch();
                //sw.Start();
                try
                {
                    //switch (datatype)
                    //{
                    //    case 1: ftype = RotateFlipType.Rotate90FlipX; break;
                    //    case 2: ftype = RotateFlipType.Rotate90FlipXY; break;
                    //    case 3: ftype = RotateFlipType.Rotate90FlipY; break;
                    //    case 4: ftype = RotateFlipType.Rotate90FlipNone; break;
                    //    case 5: ftype = RotateFlipType.Rotate180FlipNone; break;
                    //    case 6: ftype = RotateFlipType.Rotate180FlipX; break;
                    //    case 7: ftype = RotateFlipType.Rotate180FlipXY; break;
                    //    case 8: ftype = RotateFlipType.Rotate180FlipY; break;
                    //    default:
                    //        break;
                    //}
                    bmp.RotateFlip(ptype);
      
                    lock(bmp){
                        orgbmp = bmp;
                        DrawRect(orgbmp);
                   //     DrawTheKeyPoint();
                    }

                }
                catch (Exception ex)
                {
                    string str = ex.ToString();
                }
            }
            //if (player.IsSave)
            //{
            //    player.SaveDataImg(bmp, codefile.dir, codefile.filename,
            //        codefile.segfilepath, codefile.IsDetect);
            //    codefile.Dataint = codefile.Dataint + 1;
            //    player.IsSave = false;
            //}
        }
       
        private void FrmInvoiceMgt_Shown(object sender, EventArgs e)
        {
            player.ShowVideoForm(this, videoplayers);
            SysRescControlVModel.SetFixedWindow(this);
        }

        private void videoplayers_Click(object sender, EventArgs e)
        {

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
                    bmp03.Save(@"E:\pics\3-"+DateTime.Now.ToString("yyyyMMddHHmmss")+".bmp");
            }
            catch (Exception ex)
            { 
            
            }

            p.Dispose();
            g.Dispose();
            g2.Dispose();
            g3.Dispose();

        }

        private void DrawRect(Bitmap drawbmp)
        {
            Graphics g = Graphics.FromImage(drawbmp);
            Pen p = new Pen(Color.Red), blue = new Pen(Color.Blue);
            Pen colorcenter = new Pen(Color.Brown);

            rectclass = BuildTheRects(rectclass,drawbmp);
            p.Width = 3;
           // g.DrawRectangle(p, rectclass.left_rect);
            //g.DrawRectangle(p, rectclass.right_rect);
           // g.DrawRectangle(p, rectclass.center_rect);

            g.DrawRectangle(p, rectclass.left_rect);
         //   g.DrawRectangle(blue, rectclass.right_rect);
         //   g.DrawRectangle(colorcenter, rectclass.center_top);
            
            //rectclass.left_rect 
            //rectclass.right_rect
            System.Drawing.Point ps01 = new System.Drawing.Point(0, drawbmp.Height /2);
            System.Drawing.Point pe01 = new System.Drawing.Point(drawbmp.Width, drawbmp.Height /2);
            System.Drawing.Point ps02 = new System.Drawing.Point(drawbmp.Width /2, 0);
            System.Drawing.Point pe02 = new System.Drawing.Point(drawbmp.Width/2, drawbmp.Height);
            g.DrawLine(blue, ps01, pe01);
            g.DrawLine(blue, ps02, pe02);
            g.Dispose();
            p.Dispose();
        }

        /// <summary>
        /// 雙QRCode不好辨識及定位
        /// </summary>
        /// <param name="rectclass"></param>
        /// <param name="drawbmp"></param>
        /// <returns></returns>
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
            int centerdiff = Convert.ToInt32(textBox1.Text);
            int center_w = fdrawbmp.Width /2;
            int center_h = Convert.ToInt32(textBox1.Text);
            int rh = rectpos01 + recth > fdrawbmp.Height ? fdrawbmp.Height - rectpos01 : recth;
            int rw = center + rectw > fdrawbmp.Width ? fdrawbmp.Width - center : rectw;
            int rect_more = 20;

            int center_hdiff = Convert.ToInt32(textBox1.Text);
            int center_hdata = Convert.ToInt32(center / 6);
            int center_hp = center - center_hdiff - rh < 0 ? 0 : center - center_hdiff - rh;

            rectclass.left_rect =new Rectangle(0 , rectpos01, rectw + rect_more , rh);
            rectclass.right_rect =new Rectangle(center_w - rect_more , rectpos01, rectw+rect_more , rh);

            rectclass.center_rect = new Rectangle(0, center - centerdiff/2, fdrawbmp.Width, center_h);
            rh = rh > center ? center  + Convert.ToInt32(center /6) : rh;


            rectclass.center_top = new Rectangle(0, center_hp, 
                fdrawbmp.Width, rh);
            return rectclass;
        }
       
        private void btnOhterCost_Click(object sender, EventArgs e)
        {
            BuildTheCostData("雜費",6,6);
        }

        private void BuildTheCostData(string name,int mlink,int dlink)
        {
            try
            {
                using (AccountEntityDB content = new AccountEntityDB())
                {
                    using (AccountEntities entity = content.GetEntity())
                    {
                        var data = entity.JINSHINFINANCE050.Where(o => o.Ddatalink == dlink 
                                   && o.Mdatalink == mlink).OrderBy(i => i.Sn).ToList();
                        string title = entity.JINSHINFINANCE034.Where(o => o.No == mlink).FirstOrDefault().Name;
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
            }
            catch (Exception ex)
            {

            }
        }

        private void btnOffice_Click(object sender, EventArgs e)
        {
            BuildTheCostData("Office365", 2, 2);
        }
        private void btnOilCost_Click(object sender, EventArgs e)
        {
            BuildTheCostData("油資", 6, 7);
        }

        private void btnMasterial_Click(object sender, EventArgs e)
        {
            BuildTheCostData("產品材料", 6, 8);
        }

        private void FrmInvoiceMgt_Load(object sender, EventArgs e)
        {
            string path = @"E:\pics\";
            DirectoryInfo di = new DirectoryInfo(path);
            foreach (var item in di.GetFiles())
            {
                listBox1.Items.Add(item.FullName);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //bmp01.Save(@"E:\pics\" + DateTime.Now.ToString("yyyyMMddHHmmss") + "01.bmp");
            //bmp02.Save(@"E:\pics\" + DateTime.Now.ToString("yyyyMMddHHmmss") + "02.bmp");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void lab02_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string file = listBox1.Items[listBox1.SelectedIndex].ToString();
            pictureBox1.ImageLocation = file;
            selectfilename = file;
            orgbmp = new Bitmap(file);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            top = e.Y;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            bottom = e.Y;
            if (selectfilename != "")
            {
                Bitmap bmp = new Bitmap(selectfilename);
                Rectangle rect = new Rectangle(0, top, bmp.Width, bottom - top);
                if (barcodebmp != null)
                    barcodebmp.Dispose();
                barcodebmp = new Bitmap(bmp.Width, bmp.Height);
                Graphics g = Graphics.FromImage(barcodebmp);
                Rectangle src = new Rectangle(0, 0, bmp.Width, bottom - top);
                g.DrawImage(bmp, src, rect, GraphicsUnit.Pixel);
                pictureBox2.Image = barcodebmp;
                pictureBox2.Refresh();
                g.Dispose();

                cardinfo03 = codeclass.DetectDirectBarCode(codeclass, player, barcodebmp,ZXing.BarcodeFormat.CODE_39);
                rectclass.center_drawText = codeclass.datatext;
                rectclass.center_IsGet = codeclass.IsGet;
                lab01.Text = cardinfo03.name;
            }
            //if (cardinfo03.name != null )
            //    if (vmodel.CheckInv(cardinfo03.name))
            //    {
            //        invmodel = vmodel.ConvertInvFormat(cardinfo03.name);
            //   //     DisplayInfo(invmodel);
            //    }
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
        //    timer2.Enabled = true;
            DrawTheKeyPoint();
            DrawRect(orgbmp);
        }

        private void DrawTheKeyPoint()
        {
            //111
            //300
            RetrievalModes mode = RetrievalModes.External;
            switch (comModes.SelectedIndex)
            {
                case 0: {
                        mode=RetrievalModes.List;
                    }break;
                case 1: {
                        mode = RetrievalModes.Tree;
                    }break;
                case 2: {
                        mode = RetrievalModes.CComp;
                    }break;
                case 3: {
                        mode = RetrievalModes.External;
                    }break;
                default:
                    break;
            }

            ContourApproximationModes appmode = ContourApproximationModes.ApproxSimple;
            //ContourApproximationModes.ApproxNone
             



            int param01 = 100;
            int param02 = 100;
            Bitmap bmp = orgbmp;
            Mat src = bmp.ToMat();
            using (VisionControl vision = new VisionControl())
            {
                Point[][] ps = vision.GetComputePoints(src, mode, appmode, param01, param02);
                int datacnt = 0;
                int.TryParse(txtParams.Text, out datacnt);
                List<AnaModel> models = vision.GetCorrectPoly(ps, datacnt);
                Graphics g = default(Graphics);
                lock (bmp)
                {
                  g = Graphics.FromImage(bmp);
                }
                Rectangle area = new Rectangle(0, 0, orgbmp.Width, orgbmp.Height);
                Pen p = new Pen(Color.Blue);
                int psize = 10;
                int cnt = Convert.ToInt32(txtarea.Text);
                int psdata = Convert.ToInt32(txtps.Text);
                msg.Clear();
                try
                {
                    int dcnt = 0;
                    int detailcnt = 0;
                    display = false;                    
                    foreach (var item in models)
                    {
                        detailcnt = item.values.Count();
                        if (item.area > cnt && detailcnt > psdata)
                        {
                         //   detailcnt = item.values.Count();
                            int y01 = item.values.Max(o => o.Y);
                            int y02 = item.values.Min(o => o.Y);
                            int x01 = item.values.Max(o => o.X);
                            int x02 = item.values.Min(o => o.X);
                            msg.Add(detailcnt.ToString() + ",H:" + (y01 - y02).ToString() + ",W:"
                                +(x01 - x02).ToString());
                            //item.area
                            for (int j = 0; j < item.values.Count(); j++)
                            {
                                area.X = item.values[j].X;
                                area.Y = item.values[j].Y;
                                area.Width = psize;
                                area.Height = psize;
                                g.DrawEllipse(p, area);
                                //g.DrawImage(orgbmp, area, area, GraphicsUnit.Pixel);
                            }
                            dcnt++;
                        }
                    }
                    ttlcnt =  dcnt;
                    display = true;
                }
                catch (Exception ex)
                {
                    string str = ex.ToString();
                }
                g.Dispose();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {            
            //DrawTheKeyPoint();
            try
            {
                lblCnt.Text = ttlcnt.ToString();
                if (display)
                {
                    lstMsg.Items.Clear();
                    foreach (var item in msg)
                    {
                        lstMsg.Items.Add(item);
                    }
                }
                if (orgbmp != null)
                {
                    Bitmap temp = orgbmp.Clone() as Bitmap;
                    pictureBox1.Image = null;
                    pictureBox1.Image = temp;
                }
            }
            catch (Exception ex)
            { 
            
            }
          //  btnAnalyze_Click(null, null);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {

        }

        private void picData_Click(object sender, EventArgs e)
        {

        }

        private void FrmInvoiceMgt_FormClosed(object sender, FormClosedEventArgs e)
        {
            codeclass.DevClose(player, videoplayers);
        }

        private void btnUP_Click(object sender, EventArgs e)
        {
            string filedata = Environment.CurrentDirectory;
            DirectoryInfo di = new DirectoryInfo(filedata);
            string fullpath = di.Parent.Parent.FullName;
            string content = "";
            foreach (var item in msg)
            {
                content += item + Environment.NewLine;
            }
            File.WriteAllText(fullpath + "\\" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt", content);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
