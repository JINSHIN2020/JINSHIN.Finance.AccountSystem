using FinanceAccountProgram.Models;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JINSHIN.BUSINESS.LIBARY.Base;
namespace JINSHIN.Finance.AccountSystem.VModel.FileExport
{
    public class ExcelFileManager :JBase
    {
        /// <summary>
        /// data need to be arrange right
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="vals"></param>
        /// <param name="headercnt"></param>
        /// <param name="colcnt"></param>
        public void ExcelReport(string filename, List<string> vals,int headercnt,int colcnt)
        {
            XSSFWorkbook workbook = default(XSSFWorkbook);
            try
            {
                workbook = new XSSFWorkbook();
                XSSFSheet sheet = workbook.CreateSheet("sheet1") as XSSFSheet;
          
                          
                WriteExcelHeader(vals, headercnt, colcnt, sheet);
                int rowidx = 0;
                for (int i = 0; i < headercnt; i++)
                {
                    vals.RemoveAt(0);
                }
                rowidx = headercnt ;
                foreach (var item in vals)
                {
                    string[] data = item.Split(',');
                    IRow rw = sheet.CreateRow(rowidx);
                    for (int i = 0; i < data.Count(); i++)
                    {
                        ICell cell = rw.CreateCell(i);
                        cell.SetCellValue(data[i]);
                    }
                    rowidx = rowidx + 1;
                }
                FileStream fs = new FileStream(filename, FileMode.OpenOrCreate);
                workbook.Write(fs);
                fs.Close();
            }
            catch (Exception ex)
            {
                string str = ex.ToString();
            }
            finally
            {                
                workbook.Close();
            }
          //    File.WriteAllText(filename, datacontent, Encoding.UTF8);
        }

        private  void WriteExcelHeader(List<string> vals, int headercnt, int colcnt, ISheet sheet)
        {
            int cols = 0;
            int rwcols = 0;
            for (int i = 0; i < headercnt; i++)
          //  for (int i = 0; i < 10; i++)
            {
                string[] data = vals[i].Split(',');
                cols = 0;
                rwcols = colcnt / data.Count() == 1 ? 0  : colcnt / data.Count();
                IRow rw = sheet.CreateRow(i);
                for (int j = 0; j < data.Count(); j++)
                {                  
                    ICell cell = rw.CreateCell(j + j * rwcols, CellType.String);
                   // ICell cell = rw.CreateCell(j, CellType.String);
                    cell.SetCellValue(data[j]);
                    cols = cols + 1;
                }
                for (int z = 0; z < data.Count(); z++)
                {
                    if (((z + 1) * rwcols) - ((z * rwcols)) > 1)
                        sheet.AddMergedRegion(new NPOI.SS.Util.CellRangeAddress(i, i, z * rwcols, (z + 1) * rwcols));
                }
            }
        }
    }
}
