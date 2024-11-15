using FinanceAccountProgram.VModel.AddQueryDataForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JINSHIN.Finance.AccountSystem.VModel.AddQueryDataForm
{
    public class Acc_YearIntegrationCtl : AddQueryDataBase
    {
        public List<string> SaveData(List<JINSHINFINANCE047> VerifyItem, string datapath05, bool IsDelete)
        {
            if (IsDelete)
            {
                RefreshDel();
            }
            List<string> names = new List<string> { "Verify_Month", "Item", "Acc_Date", "EmpName", "Acc_id", "Descrip", "Amount", "Invoice_No", "Rec_Type", "Inv_Month" };
            List<string> types = new List<string> { "int", "int", "datetime", "string", "string", "string", "decimal", "string", "int", "Int" };
            List<NameValues> items = new List<NameValues>();
            AccBaseCtl acc_ctl = new AccBaseCtl();
            List<string> files = acc_ctl.GetDataFile(datapath05);
            FunctionControl functl = new FunctionControl();
            int cnt = 0;
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
                            cnt = data.Count;
                            for (int j = 0; j < data.Count; j++)
                            {
                                List<string> values = data[j].Split(',').ToList();
                                values.RemoveAt(0);
                                SetNameValueData(names, types, items, values.ToArray());
                                JINSHINFINANCE047 accitem = new JINSHINFINANCE047();
                                functl.SetClassObj<JINSHINFINANCE047>(accitem, items);
                                if (accitem.Acc_Date != null)
                                    accitem.Acc_Date = accitem.Acc_Date.Value.Year < 1000 ? accitem.Acc_Date.Value.AddYears(1911) : accitem.Acc_Date.Value;
                                entities.JINSHINFINANCE047.Add(accitem);
                                entities.SaveChanges();
                            }
                        }
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
            return new List<string> { cnt.ToString() };
        }

        public void RefreshDel()
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entities = content.GetEntity())
                {
                    var VerifyItems = entities.JINSHINFINANCE047.ToList();
                    entities.JINSHINFINANCE047.RemoveRange(VerifyItems);
                    entities.SaveChanges();
                }
            }
        }

    }
}
