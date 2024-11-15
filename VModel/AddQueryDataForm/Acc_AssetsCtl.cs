
using FinanceAccountProgram.Models;
using FinanceAccountProgram.Models.Config.UpdataeForm;
using FinanceAccountProgram.Models.UControl;
using JINSHIN.BUSINESS.LIBARY.Models.UIControls;
using JINSHIN.FinanceAccount.Libary.Models.Base;
using JINSHIN.FinanceAccount.Libary.VModels;
using JINSHIN.FinanceAccount.Libary.VModels.GridView.Assets;
using JINSHIN.FinanceAccounting.DB;
using JINSHIN.FinanceAccounting.DB.VModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FinanceAccountProgram.VModel.AddQueryDataForm
{
    public class Acc_AssetsCtl : AddQueryDataBase
    {
        public List<JINSHINFINANCE051> acc_AssetsItems { get; set; }
        public List<JINSHINFINANCE051> Jin51_AssetsItems { get; set; }
        public Acc_AssetsCtl() {
            acc_AssetsItems = new List<JINSHINFINANCE051>();
            Jin51_AssetsItems = new List<JINSHINFINANCE051>();
        }
        public void GetStorageData(AccountEntities entity, DataParams paramdata, int typename)
        {
            switch (typename)
            {
                case ImportQueryClass.Assets:
                    {
                        acc_AssetsItems.Clear();
                        acc_AssetsItems = entity.JINSHINFINANCE051.Take(100).ToList();
                    }
                    break;
                default:
                    break;
            }
        }


        public List<string> SaveData(DataGridView dg, List<JINSHINFINANCE051> VerifyItem, string datapath07,
                                     bool IsDelete, bool IsAdd,int thisyear,bool IsDeleteAll)
        {

            List<string> names = new List<string>
            {
              "ClassNo","Item", "Acc_Type","AssetsName","Acc_Name","Acc_Id","Cnt","Unit","BuyDate","IsFinance","Price",
              "BookValue","ResidualVal","RemainVal","MachineYear","MonthUsed","Months","NwYear","RevaluationVal"
              ,"DepreciationVal","ReduingAssets",
              "Remark" 
            };

            List<string> types = new List<string>
            { "int", "int", "int", "string", "string","string", "int", "string", "datetime", "int", "DECIMAL",
              "DECIMAL" , "DECIMAL","DECIMAL", "DECIMAL","int","int","DECIMAL","DECIMAL"
              ,"DECIMAL","DECIMAL",
              "string"
            };

            List<NameValues> items = new List<NameValues>();
            AccBaseCtl acc_ctl = new AccBaseCtl();
            List<string> files = acc_ctl.GetDataFile(datapath07);
            FunctionControl functl = new FunctionControl();
            int cnt = 0;
            int SN = 1;

            if (IsAdd)
            {
                SaveSelectedData(dg,names, types, items, files, functl);
                return new List<string> { cnt.ToString() };
            }

            if (IsDeleteAll)
            {
                RefreshDel();
            }
            if (IsDelete)
            {
                RefreshDel(thisyear);
            }  
            
            try
            {
                Jin51_AssetsItems.Clear();
                using (AccountEntityDB content = new AccountEntityDB())
                {
                    using (AccountEntities entities = content.GetEntity())
                    {
                        var assetsclassItems = entities.JINSHINFINANCE053.ToList();
                        for (int i = 0; i < files.Count; i++)
                        {
                            List<string> data = File.ReadAllLines(files[i], Encoding.GetEncoding(950)).ToList();
                            data.RemoveAt(0);
                            cnt = data.Count;
                            for (int j = 0; j < data.Count; j++)
                            {
                                List<string> values = data[j].Split(',').ToList();
                                int No = GetAssetsNo(assetsclassItems, values);
                                values.Insert(0, SN.ToString());
                                SN = SN + 1;
                                values.Insert(0, No.ToString());                             
                                SetNameValueData(names, types, items, values.ToArray());

                                JINSHINFINANCE051 assetsitem = new JINSHINFINANCE051();
                                assetsitem.DepreciateFormula = FormConfig.AssetFormula;
                                functl.SetClassObj<JINSHINFINANCE051>(assetsitem, items);
                                var jin051 = entities.JINSHINFINANCE051.Where(v => v.AssetsName == assetsitem.AssetsName                                
                                ).FirstOrDefault();                          
                                if (jin051 == null)
                                    entities.JINSHINFINANCE051.Add(assetsitem);
                                else
                                    Jin51_AssetsItems.Add(jin051);
                                entities.SaveChanges();
                            }
                        }
                        cnt = entities.JINSHINFINANCE051.ToList().Count;
                    }
                }
            }
            catch (Exception ex)
            {
                string str = ex.ToString();
                MessageBox.Show("請檢查是否有重覆的編號!");
            }
            finally
            {
                acc_ctl.Dispose();
                functl.Dispose();
            }
            return new List<string> { cnt.ToString() };
        }

        public void SaveSelectedData(DataGridView dg, 
          List<string> files, FunctionControl functl,string itemno,string classno)
        {
            List<ImportModel> rs = GetImportModelList();
            List<NameValues> items = new List<NameValues>();
            int SN = 0;        
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entities = content.GetEntity())
                {
                    List<string> data = new List<string>();

                    var assetsclassItems = entities.JINSHINFINANCE053.ToList();
                    if (dg.SelectedRows.Count > 0)
                    {
                        for (int j = 0; j < dg.SelectedRows.Count; j++)
                        {
                            List<string> values = new List<string>();
                            for (int x = 0; x < dg.SelectedRows[j].Cells.Count; x++)
                            {
                                if (dg.SelectedRows[j].Cells[x].Value != null)
                                    values.Add(dg.SelectedRows[j].Cells[x].Value.ToString());
                                else
                                    values.Add("");
                            }                          
     
                            items = SetNameValueData(rs, new DGAssets_CreateItems().columns, values.ToArray());

                            JINSHINFINANCE051 assetsitem = new JINSHINFINANCE051();
                            functl.SetClassObj<JINSHINFINANCE051>(assetsitem, items);
                            assetsitem.DepreciateFormula = FormConfig.AssetFormula;
                            assetsitem.ClassNo = Convert.ToInt32(classno);
                            assetsitem.Item = Convert.ToInt32(itemno);
                            entities.JINSHINFINANCE051.Add(assetsitem);
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

        private List<ImportModel> GetImportModelList()
        {
            List<ImportModel> setting = new List<ImportModel>();
            setting.Add(new ImportModel()
            {
                name="ClassNo",
                datatype = "int"
            });
            setting.Add(new ImportModel()
            {
                name="Item",
                datatype = "int"
            });
            setting.Add(new ImportModel()
            {
                name="Acc_Type",
                datatype = "int"
            });

            setting.Add(new ImportModel()
            {
                name="AssetsName",
                datatype = "string"
            });
            setting.Add(new ImportModel()
            {
                name="Acc_Name",
                datatype = "string"
            });
            setting.Add(new ImportModel()
            {
                name="Acc_Id",
                datatype = "string"
            });
            setting.Add(new ImportModel()
            {
                name="Cnt",
                datatype = "int"
            });
            setting.Add(new ImportModel()
            {
                name="Unit",
                datatype = "string"
            });


            setting.Add(new ImportModel()
            {
                name="Unit",
                datatype = "string"
            });
            setting.Add(new ImportModel()
            {
                name="BuyDate",
                datatype = "datetime"
            });
            setting.Add(new ImportModel()
            {
                name="IsFinance",
                datatype = "int"
            });
            setting.Add(new ImportModel()
            {
                name="Price",
                datatype = "DCEIMAL"
            });


            setting.Add(new ImportModel()
            {
                name="BOOKVALUE",
                datatype = "DECIMAL"
            });
            setting.Add(new ImportModel()
            {
                name="ResidualVal",
                datatype = "DECIMAL"
            });
            setting.Add(new ImportModel()
            {
                name="RemainVal",
                datatype = "DECIMAL"
            });
            setting.Add(new ImportModel()
            {
                name="MachineYear",
                datatype = "DECIMAL"
            });
            setting.Add(new ImportModel()
            {
                name="MonthUsed",
                datatype = "int"
            });
            setting.Add(new ImportModel()
            {
                name="Months",
                datatype = "int"
            });
            setting.Add(new ImportModel()
            {
                name="NwYear",
                datatype = "DECIMAL"
            });
            setting.Add(new ImportModel()
            {
                name="RevaluationVal",
                datatype = "DECIMAL"
            });
            setting.Add(new ImportModel()
            {
                name="DepreciationVal",
                datatype = "DECIMAL"
            });
            setting.Add(new ImportModel()
            {
                name="ReduingAssets",
                datatype = "DECIMAL"
            });
            setting.Add(new ImportModel()
            {
                name="Remark",
                datatype="string"
            });
            return setting;
        }

        public void SaveSelectedData(DataGridView dg, List<string> names, List<string> types, List<NameValues> items, 
            List<string> files, FunctionControl functl)
        {         
            int SN = 0;
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entities = content.GetEntity())
                {
                    var assetsclassItems = entities.JINSHINFINANCE053.ToList();
                    if (dg.SelectedRows.Count > 0)
                    {
                        for (int j = 0; j < dg.SelectedRows.Count; j++)
                        {
                            List<string> values = new List<string>();
                            for (int x = 0; x < dg.SelectedRows[j].Cells.Count; x++)
                            {
                                if (dg.SelectedRows[j].Cells[x].Value != null)
                                    values.Add(dg.SelectedRows[j].Cells[x].Value.ToString());
                                else
                                    values.Add("");
                            }                          
                            int No = GetAssetsNo(assetsclassItems, values);
                            values.Insert(0, SN.ToString());
                            SN = SN + 1;
                            values.Insert(0, No.ToString());
                            SetNameValueData(names, types, items, values.ToArray());
                            JINSHINFINANCE051 assetsitem = new JINSHINFINANCE051();
                            functl.SetClassObj<JINSHINFINANCE051>(assetsitem, items);
                            assetsitem.DepreciateFormula = FormConfig.AssetFormula;
                            entities.JINSHINFINANCE051.Add(assetsitem);
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

        private  int GetAssetsNo(List<JINSHINFINANCE053> assetsclassItems, List<string> data)
        {
            var NoData = assetsclassItems.Where(o => o.Name == data[0] && o.SubName == data[1] 
            && o.item == Convert.ToInt32(data[2])).FirstOrDefault();
            int ClassNo = 0;
            if (NoData != null)
                ClassNo = NoData.No;
            else
                ClassNo = 0;
            for (int j = 0; j < 3; j++)
            {
                data.RemoveAt(0);
            }
            return ClassNo;
        }

        public void RefreshDel()
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entities = content.GetEntity())
                {
                    var AssetsItems = entities.JINSHINFINANCE051.ToList();
                    entities.JINSHINFINANCE051.RemoveRange(AssetsItems);
                    entities.SaveChanges();
                }
            }
        }

        public void RefreshDel(int year)
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entities = content.GetEntity())
                {
                    var AssetsItems = entities.JINSHINFINANCE051.Where(v=>v.BuyDate.Value.Year == year).ToList();
                    entities.JINSHINFINANCE051.RemoveRange(AssetsItems);
                    entities.SaveChanges();
                }
            }
        }
    }
}

