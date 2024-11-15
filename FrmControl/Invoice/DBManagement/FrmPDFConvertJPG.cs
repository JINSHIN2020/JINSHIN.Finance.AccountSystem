using SkiaSharp;
using Spire.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JINSHIN.Finance.AccountSystem.FrmControl.Invoice.DBManagement
{
    public partial class FrmPDFConvertJPG : Form
    {
        public string picspath { get; set; }
        public string srcpath { get; set; }
        public string basepath { get; set; }
        public string srctitle { get; set; }
        public string dsttitle { get; set; }
        public string pdftitle { get; set; }
        public List<string> filelist { get; set; }
        public List<string> pdflist { get; set; }
        public FrmPDFConvertJPG()
        {
            InitializeComponent();
            picspath = Environment.CurrentDirectory;
            DirectoryInfo di = new DirectoryInfo(picspath);
            srctitle = "\\Invoice\\DBManagement\\src\\";
            dsttitle = "\\Invoice\\DBManagement\\pics\\";
            pdftitle = "\\Invoice\\DBManagement\\pdfs\\";

#if(DEBUG)
            picspath = di.Parent.Parent.FullName + dsttitle;
            srcpath = di.Parent.Parent.FullName + pdftitle;
            basepath = di.Parent.Parent.FullName;
#else
            //path = di.Parent.FullName + dsttitle;
            srcpath = accounting.ClickPath + pdftitle;
            basepath = accounting.ClickPath;
#endif
            filelist = new List<string>();
            pdflist = new List<string>();
        }

        private List<string> SetDataFromPath(string path, ListBox listbox,List<string> datalist)
        {
            datalist.Clear();
            listbox.Items.Clear();
            DirectoryInfo fls2 = new DirectoryInfo(path);
            foreach (var i in fls2.GetFiles())
            {
                listbox.Items.Add(i.FullName);
                datalist.Add(i.FullName);
            }
            return datalist;
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            string chpath = "";
            if (filedlg.ShowDialog() == DialogResult.OK)
            {
                FileInfo fi = new FileInfo(filedlg.FileName);
                chpath = fi.Directory.FullName;

                srcpath = chpath + pdftitle;
                picspath = chpath + dsttitle;

                pdflist = SetDataFromPath(srcpath, lstData,pdflist);
                filelist = SetDataFromPath(picspath, lstContent,filelist);

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string path = "";
            string pass = "69746686";
            string pass02 = "N123797384";
            foreach (var datafile in pdflist)
            {
                path = datafile;
          //      FileStream fs = new FileStream(path, FileMode.Open);
                PdfDocument apdf = new PdfDocument();
                try
                {
                    apdf.LoadFromFile(path);
                } catch (Exception ex)
                {
                    try
                    {
                        apdf.LoadFromFile(path, "69746686");
                    }
                    catch (Exception ex02)
                    {
                        try
                        {
                            apdf.LoadFromFile(path, pass02);
                        }
                        catch (Exception ex03)
                        {
                            string str = "";
                        }
                    }

                }
                
                int pagecnt = apdf.Pages.Count;
                for (int i = 0; i < pagecnt ; i++)
                {
                    Image img = apdf.SaveAsImage(0, 300, 300);
                    FileInfo fi = new FileInfo(path);
                    DirectoryInfo di = new DirectoryInfo(picspath);
                    int cnt = di.GetFiles().Count() +1;
                    string datapath = picspath +fi.Name.Replace(fi.Extension, "") + cnt.ToString("00") + ".jpeg";
                    img.Save(datapath);
                    //apdf.Close();
                }
                apdf.Close();
                //List<SKBitmap> values = default;
                //try
                //{
                //    //PDFtoImage.Conversion.ToImages()
                //    values = PDFtoImage.Conversion.ToImages(fs, dpi: 500, withFormFill: true, withAspectRatio: true).ToList();
                //}
                //catch (Exception ex)
                //{
                //    values = PDFtoImage.Conversion.ToImages(fs, password: "69746686").ToList();
                //}
                //int cnt = values.Count +1;
                //FileInfo fia = new FileInfo(path);
                //foreach (var item in values)
                //{
                //    FileStream fst = new FileStream(picspath +fi.Name.Replace(fi.Extension, "") + cnt.ToString("00") + ".jpeg", FileMode.OpenOrCreate);
                //    item.Encode(fst, SKEncodedImageFormat.Jpeg, 100);
                //    cnt++;
                //}
            }

        }

        private void FrmPDFConvertJPG_Shown(object sender, EventArgs e)
        {
            SetDataFromPath(srcpath, lstData,pdflist);
            SetDataFromPath(picspath, lstContent,filelist);
        }
    }
}
