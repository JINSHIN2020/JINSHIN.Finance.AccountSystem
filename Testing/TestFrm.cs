using JINSHIN.FinanceAccount.Libary.Models.BarCode;
using JINSHIN.Package.Libary.InvScan;
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

namespace JINSHIN.Finance.AccountSystem.Testing
{
    public partial class TestFrm: Form
    {
        public CodeMgtClass codeclass { get; set; }
        public Bitmap newbmp { get; set; }
        public Bitmap orgbmp { get; set; }
        private RotateFlipType ptype { get; set; }
        public RectClass rectclass { get; set; }
        public TestFrm()
        {
            InitializeComponent();
            codeclass = new CodeMgtClass(MediaPlayer);
        }

        private void NewFrame(object sender, ref Bitmap bmp)
        {
            if (bmp != null)
            {
                try
                {
                    bmp.RotateFlip(ptype);
                    orgbmp = bmp;
                    DrawRect(bmp);

                }
                catch (Exception ex)
                { }
            }
        }


        private RectClass BuildTheRects(RectClass rectclass, Bitmap drawbmp)
        {
            int wsize = 5;
            int hsize = 5;
            int MoveY = 2;
            int rectw = Convert.ToInt32(drawbmp.Width / 8 * wsize);
            int recth = Convert.ToInt32(drawbmp.Height / 8 * hsize);
            int centermoveY = Convert.ToInt32(drawbmp.Height /8 * MoveY);
            recth = recth + centermoveY;
            int rectpos01 = 0;
            int rectpos02 = 0;
            rectpos01 = Convert.ToInt32(drawbmp.Height * 1.0 * 0.37) - centermoveY;
            rectpos02 = Convert.ToInt32(drawbmp.Width * 1.0 * 0.37);
            double radioh = rectpos01 *1.0 / drawbmp.Height * 1.0;
            double radiow = rectpos02 * 1.0 / drawbmp.Width * 1.0;
            int center = drawbmp.Width / 2;
            int rh = rectpos01 + recth > drawbmp.Height ? drawbmp.Height - rectpos01 : recth;
            int rw = center + rectw > drawbmp.Width ? drawbmp.Width - center : rectw;
            rectclass.left_rect =new Rectangle(center - rectw, rectpos01, rectw, rh);
            rectclass.right_rect =new Rectangle(center, rectpos01, rw, rh);
            return rectclass;
        }


        private void DrawRect(Bitmap drawbmp)
        {
            Graphics g = Graphics.FromImage(drawbmp);
            Pen p = new Pen(Color.Red), blue = new Pen(Color.Blue);
            rectclass = BuildTheRects(rectclass, drawbmp);
            p.Width = 3;
            g.DrawRectangle(p, rectclass.left_rect);
            g.DrawRectangle(p, rectclass.right_rect);
            Point ps01 = new Point(0, drawbmp.Height /2);
            Point pe01 = new Point(drawbmp.Width, drawbmp.Height /2);
            Point ps02 = new Point(drawbmp.Width /2, 0);
            Point pe02 = new Point(drawbmp.Width/2, drawbmp.Height);
            g.DrawLine(blue, ps01, pe01);
            g.DrawLine(blue, ps02, pe02);
            g.Dispose();
            p.Dispose();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int w = picBarCode.Width;
            int h = picBarCode.Height;
            int imgw = picBarCode.Width / 4;
            int imgh = picBarCode.Height / 4;
            newbmp = codeclass.CreateBarCode(txtContent.Text, w, h);
            orgbmp = newbmp.Clone() as Bitmap;
            picBarCode.Image = Image.FromHbitmap(newbmp.GetHbitmap());
            if (chImg.Checked)
            {
                Bitmap img = new Bitmap(picimg.Image, imgw / 2, imgh / 2);
                Image content = Image.FromHbitmap(img.GetHbitmap());
                Image srcimg = Image.FromHbitmap(newbmp.GetHbitmap());
                Graphics g = Graphics.FromImage(srcimg);
                g.DrawImage(content, w / 2 - (imgw / 4), h / 2 - (imgh / 4));
                picBarCode.Image = srcimg;
            }
            else
            {
                picBarCode.Image = Image.FromHbitmap(newbmp.GetHbitmap());
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            opendlg.Filter = " jpeg File(*.jpeg)|*.jpeg|JPG File (*.jpg)|*.jpg|Png File (*.png)|*.png|bmp File (*.bmp)|*.bmp| Gif File (*.gif) |*.gif";
            opendlg.FileName = "";
            if (opendlg.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(opendlg.FileName, FileMode.Open);
                Bitmap bmptmp = new Bitmap(fs);
                picimg.Image = Image.FromHbitmap(bmptmp.GetHbitmap());
            }
        }
    }
}
