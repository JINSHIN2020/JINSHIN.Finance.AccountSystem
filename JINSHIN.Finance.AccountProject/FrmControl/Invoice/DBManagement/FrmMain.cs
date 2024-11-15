//#define realse
using System; 
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JINSHIN.Finance.AccountSystem.FrmControl.Invoice.DBManagement
{
    public partial class FrmMain : Form
    {
        public Point OneP { get; set; }
        public Point TwoP { get; set; }
        public string filepath { get; set; }
        public string path { get; set; }
        public string srcpath { get; set; }
        public bool drawstart { get; set; }
        public string srctext { get; set; }
        public string dsttext { get; set; }
        public string basepath { get; set; }
        public string srctitle { get; set; }
        public string dsttitle { get; set; }
        public double fhradio { get; set; }
        public double fwradio { get; set; }
        public FrmMain()
        {
            InitializeComponent();
            fhradio = 0;
            fwradio = 0;
            srctext = "目前為載入來源";
            dsttext = "目前為載入產生檔案";
            path = Environment.CurrentDirectory;
            DirectoryInfo di = new DirectoryInfo(path);
            srctitle = "\\Invoice\\DBManagement\\src\\";
            dsttitle = "\\Invoice\\DBManagement\\pics\\";
#if(DEBUG)
            path = di.Parent.Parent.FullName + dsttitle;
            srcpath = di.Parent.Parent.FullName + srctitle;
            basepath = di.Parent.Parent.FullName;
#else
            path =accounting.ClickPath + dsttitle;
            srcpath = accounting.ClickPath + srctitle;
            basepath = accounting.ClickPath;
#endif
            //basepath = di.Parent.Parent.FullName;
            drawstart = false;
        }

        private void SetDataFromPath(string path,  ListBox listbox)
        {
            listbox.Items.Clear();
            DirectoryInfo fls2 = new DirectoryInfo(path);
            foreach (var i in fls2.GetFiles())
            {
                listbox.Items.Add(i.FullName);
            }
        }


        public Point GetSize(int w,int h)
        {
            double radiow = w * 1.0 / picdata.Width * 1.0;
            double radioh = h * 1.0 / picdata.Height * 1.0;
            int bmpx01 = Convert.ToInt32(radiow * OneP.X);
            int bmpy01 = Convert.ToInt32(radioh * OneP.Y);
            int bmpx02 = Convert.ToInt32(radiow * TwoP.X);
            int bmpy02 = Convert.ToInt32(radioh * TwoP.Y);
            int pich = bmpy02 - bmpy01;
            int picw = bmpx02 - bmpx01;
            pich = TwoP.Y - OneP.Y;
            picw = TwoP.X - OneP.X;
            return new Point(picw, pich);
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lstData.Items.Count == 0)
                return;

            Bitmap bmp = new Bitmap(lstData.Text);
            bmp.SetResolution(600, 600);
            int bmpwidth = bmp.Width;
            int bmpheight = bmp.Height;
            int picwidth = picdata.Width;
            int picheight = picdata.Height;

            double radiow = bmp.Width *1.0 / picdata.Width * 1.0;
            double radioh = bmp.Height *1.0 / picdata.Height * 1.0;
            Image img = Image.FromHbitmap(bmp.GetHbitmap());

            int bmpx01 = Convert.ToInt32(radiow * OneP.X);
            int bmpy01 = Convert.ToInt32(radioh * OneP.Y);
            
            int bmpx02 = Convert.ToInt32(radiow * TwoP.X);
            int bmpy02 = Convert.ToInt32(radioh * TwoP.Y);
            try
            {
                Bitmap newbmp = new Bitmap(bmpx02 - bmpx01, bmpy02 - bmpy01);
                newbmp.SetResolution(600, 600);
                Graphics g = Graphics.FromImage(newbmp);
                int pich = bmpy02 - bmpy01;
                int picw = bmpx02 - bmpx01;
                Rectangle rec = new Rectangle(0, 0, picw, pich);                
                g.DrawImage(img, rec, bmpx01, bmpy01, picw, pich,GraphicsUnit.Pixel);
                string datapath = lstData.Text;
                FileInfo fi = new FileInfo(datapath);
                newbmp.Save(path + txtfilename.Text + ".jpeg");
                lblMsgData.Text = path + txtfilename.Text + "__儲存完成!";

            }catch(Exception ex)
            {
                string str = ex.ToString();

            }

        }

        private void picdata_MouseDown(object sender, MouseEventArgs e)
        {
            drawstart = true;
            OneP  = new Point(e.X, e.Y);
        }

        private void picdata_MouseUp(object sender, MouseEventArgs e)
        {
            drawstart =false;
            TwoP = new Point(e.X, e.Y);
        }

        private void picdata_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawstart)
            {
                Image img = picdata.Image;
                Graphics g = picdata.CreateGraphics();
                Pen p = new Pen(Color.Red);
                p.Width = 3;
                TwoP = new Point(e.X, e.Y);
                Point pdata = GetSize(img.Width, img.Height);
                picdata.Refresh();
                g.DrawRectangle(p, new Rectangle(OneP.X, OneP.Y, pdata.X, pdata.Y));
                p.Dispose();
                g.Dispose();
            }
            //picdata.
        }

        private void FrmMain_Shown(object sender, EventArgs e)
        {
            lstData.Items.Clear();
            SetDataFromPath(path, lstData);
            btnLoad.Text = dsttext;
            txtpath.Text = basepath;
            lbl01.Text = picdata.Width.ToString();
            lbl02.Text = picdata.Height.ToString();
        }

        private void lstData_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadBmpContent();
        }

        private void LoadBmpContent()
        {
            if (lstData.SelectedIndex != -1)
            {
                if (txtRadio.Text != "")
                {
                    double fradio = Convert.ToDouble(txtRadio.Text);
                    LoadPicBmps(fradio/100.0);
                }
                else
                {
                    MessageBox.Show("請填調整比例!","金心資訊科技有限公司",MessageBoxButtons.YesNo);
                }
            }
        }

        private void LoadPicBmps(double setup_radio)
        {
            int w = picdata.Size.Width;
            int h = picdata.Size.Height;
            Bitmap bmp = new Bitmap(lstData.Text);
            picdata.Image = bmp;
            lbl03.Text = bmp.Width.ToString();
            lbl05.Text = bmp.Height.ToString();
            //900
            double datah = 700.0;
            double radio = bmp.Width * 1.0 / bmp.Height * 1.0;
            if (bmp.Height < datah)
                datah = bmp.Height;
            fhradio =  datah / bmp.Height * 1.0;
            fwradio = bmp.Width * 1.0 * fhradio;
            int new_w = Convert.ToInt32(bmp.Width * fhradio * setup_radio);
            int new_h = Convert.ToInt32(datah * setup_radio);
            Bitmap newbmp = new Bitmap(new_w, new_h);
            newbmp.SetResolution(96f, 96f);
            Graphics g = Graphics.FromImage(newbmp);
            Rectangle src = new Rectangle(0, 0, bmp.Width, bmp.Height);
            Rectangle dst = new Rectangle(0, 0, new_w, new_h);
            g.DrawImage(bmp, dst, src, GraphicsUnit.Pixel);
            picdata.Image = null;
            picdata.Image = newbmp;
            string value = lstData.Text;
            FileInfo fi = new FileInfo(value);
            txtfilename.Text = fi.Name.Replace(fi.Extension, "");
            picdata.Refresh();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadDataList();
        }

        private void LoadDataList()
        {
            string text = btnLoad.Text;
            if (text == srctext)
            {
                SetDataFromPath(path, lstData);
                btnLoad.Text = dsttext;
            }
            else if (text == dsttext)
            {
                SetDataFromPath(srcpath, lstData);
                btnLoad.Text = srctext;
            }
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            string chpath = "";
            if (filedlg.ShowDialog() == DialogResult.OK)
            {
                FileInfo fi = new FileInfo(filedlg.FileName);
                chpath = fi.Directory.FullName;
                srcpath = chpath + srctitle;
                path = chpath + dsttitle;
                LoadDataList();
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnPDFToJPG_Click(object sender, EventArgs e)
        {

        }

        private void btnadjust_Click(object sender, EventArgs e)
        {
            LoadBmpContent();
        }
    }
}
