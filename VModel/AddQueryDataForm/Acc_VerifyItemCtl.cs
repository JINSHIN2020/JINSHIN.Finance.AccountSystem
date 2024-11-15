

using JINSHIN.FinanceAccounting.DB;
using FinanceAccountProgram.VModel.Conrols.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JINSHIN.BUSINESS.LIBARY.Models.UIControls;
using JINSHIN.FinanceAccount.Libary.VModels;
using JINSHIN.FinanceAccounting.DB.VModel;
using JINSHIN.FinanceAccount.Libary.Config.UpdataeForm;
using System.Windows.Forms;

namespace FinanceAccountProgram.VModel.AddQueryDataForm
{
    public class JINSHINFINANCE047Ctl : AddQueryDataBase
    {      
        private void SaveSelectedData(DataGridView dg, List<string> names, List<string> types, List<NameValues> items,
         List<string> files, FunctionControl functl)
        {
            int SN = 0;
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entities = content.GetEntity())
                {
                    var costitem = entities.JINSHINFINANCE047.ToList();
                    if (dg.SelectedRows.Count > 0)
                    {                      
                        for (int j = 0; j < dg.SelectedRows.Count; j++)
                        {
                            List<string> values = new List<string>();
                            for (int x = 0; x < dg.SelectedRows[j].Cells.Count; x++)
                            {
                                values.Add(dg.SelectedRows[j].Cells[x].Value.ToString());
                            }
                            SetNameValueData(names, types, items, values.ToArray());
                            JINSHINFINANCE047 accitem = new JINSHINFINANCE047();
                            functl.SetClassObj<JINSHINFINANCE047>(accitem, items);
                            if (accitem.Acc_Date != null)
                                accitem.Acc_Date = accitem.Acc_Date.Value.Year < 1000 ? accitem.Acc_Date.Value.AddYears(1911) 
                                    : accitem.Acc_Date.Value;
                            entities.JINSHINFINANCE047.Add(accitem);
                            entities.SaveChanges();
                        }
                    }
                    else
                    {
                        MessageBox.Show("請先選取資料!");
                    }

                }
            }
        }

        public List<string> SaveData(DataGridView dg,List<JINSHINFINANCE047> VerifyItem, string datapath05, bool IsDelete,bool IsAdd,
            int thisyear)
        {
            List<string> names = new List<string> {  "Verify_Month","Item","Acc_Date", "EmpName","Acc_id", "Descrip",
                                                     "Amount" ,"Invoice_No","Rec_Type","Inv_Month","Verify_Year"};
            List<string> types = new List<string> {  "int","int", "datetime", "string","string", "string", "decimal",
                                                    "string","int","Int","int"};
            List<NameValues> items = new List<NameValues>();
            AccBaseCtl acc_ctl = new AccBaseCtl();
            List<string> files = acc_ctl.GetDataFile(datapath05);
            FunctionControl functl = new FunctionControl();
            int cnt = 0;

            if (IsAdd)
            {
                SaveSelectedData(dg, names, types, items, files, functl);
                return new List<string> { cnt.ToString() };
            }
            if (IsDelete)
            {
                RefreshDel(thisyear);
            }

            try
            {
                using (AccountEntityDB content = new AccountEntityDB())
                {
                    using (AccountEntities entities = content.GetEntity())
                    {
                        var costitem = entities.JINSHINFINANCE047.ToList();
                        for (int i = 0; i < files.Count; i++)
                        {
                            List<string> data = File.ReadAllLines(files[i], Encoding.GetEncoding(950)).ToList();
                            data.RemoveAt(0);
                          //  cnt = data.Count;
                            for (int j = 0; j < data.Count; j++)
                            {
                                List<string> values = data[j].Split(',').ToList();
                                values.RemoveAt(0);
                                SetNameValueData(names, types, items, values.ToArray());
                                JINSHINFINANCE047 accitem = new JINSHINFINANCE047();
                                functl.SetClassObj<JINSHINFINANCE047>(accitem, items);
                                if (accitem.Acc_Date != null)
                                    accitem.Acc_Date = accitem.Acc_Date.Value.Year < 1000 ? accitem.Acc_Date.Value.AddYears(1911) : accitem.Acc_Date.Value;

                                if (accitem.Verify_Year == thisyear)
                                {
                                    entities.JINSHINFINANCE047.Add(accitem);
                                    cnt = cnt +1;
                                }
                                entities.SaveChanges();
                            }
                        }
                        var dataes = entities.JINSHINFINANCE047.ToList();
                      //  cnt = dataes.Count;
                    }     
                }
            }
            catch (Exception ex)
            {
                string str = ex.ToString();
            }
            finally
            {
                acc_ctl.Dispose();
                functl.Dispose();                
            }
            return new List<string> {cnt.ToString() };
        }

        public void RefreshDel(int year)
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entities = content.GetEntity())
                {
                    var VerifyItems = entities.JINSHINFINANCE047.Where(v=>v.Verify_Year == year).ToList();
                    entities.JINSHINFINANCE047.RemoveRange(VerifyItems);
                    entities.SaveChanges();
                }
            }
        }
    }
}
