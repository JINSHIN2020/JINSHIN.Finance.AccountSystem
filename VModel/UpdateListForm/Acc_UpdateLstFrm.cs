
using FinanceAccountProgram.Models.AddQueryDataForm;
using JINSHIN.FinanceAccounting.DB;
using FinanceAccountProgram.VModel.Conrols.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JINSHIN.BUSINESS.LIBARY.Models.UIControls;
using JINSHIN.FinanceAccount.Libary.Models.AddQueryDataForm;
using JINSHIN.FinanceAccounting.DB.VModel;

namespace FinanceAccountProgram.VModel.UpdateListForm
{
    public class Acc_UpdateLstFrm : AccAddQueryFormBase
    {
        public Acc_UpdateLstFrm()
        {
        }
        /// <summary>
        /// indicates twice way to mirror data
        /// </summary>
        /// <param name="dbclass"></param>
        public void InvoiceToCost(DBClassCtl dbclass)
        {
            FunctionControl functl = new FunctionControl();
            List<NameValues> keyitems = new List<NameValues>();
            int icnt = 0;
            JINSHINFINANCE035 testdata = default(JINSHINFINANCE035);
            try
            {
                using (AccountEntityDB content = new AccountEntityDB())
                {
                    using (AccountEntities entities = content.GetEntity())
                    {
                        var invoicesContract = entities.JINSHINFINANCE058.ToList();
                        var costitem = entities.JINSHINFINANCE035.ToList();
                        var invoices = entities.JINSHINFINANCE039.ToList();
                        List<string> keyvalues = new List<string>();

                        foreach (var data in costitem.OrderBy(o => o.Acc_ID).ToList())
                        {
                            icnt++;
                            if (icnt == 746)
                            {
                                // string str = "";
                            }
                            ContentCostLink data01 = SetValueToLink(invoicesContract, invoices, data);
                            keyvalues.Clear();
                            if (data01.iinvoicebook != null)
                            {
                                keyvalues.Add(data01.iinvoicebook.Rec_Type.Value.ToString());
                                keyvalues.Add(data01.iinvoicebook.Invoice_No.ToString());
                            }
                            else
                            {
                                keyvalues.Add("0");
                                keyvalues.Add("");
                            }
                            //cost_class
                            if (data01.icontract != null)
                            {
                                keyvalues.Add(data01.icontract.Inv_Class.ToString());
                                if (data01.icontract.Inv_DetailClass.ToString() == "")
                                    keyvalues.Add("0");
                                else
                                    keyvalues.Add(data01.icontract.Inv_DetailClass.ToString());
                                keyvalues.Add(data01.icontract.CostType.ToString());
                                keyvalues.Add(data01.icontract.Inv_M.ToString());
                            }
                            else
                            {
                                keyvalues.Add("0");
                                keyvalues.Add("0");
                                keyvalues.Add("0");
                                keyvalues.Add("0");
                            }
                            SetNameValueData(keynames, keytypes, keyitems, keyvalues.ToArray());
                            functl.SetClassObj<JINSHINFINANCE035>(data, keyitems);
                            testdata = data;
                            //data.CostType = dbclass.GetAccIncDec(data.Acc_ID, data.DataType.Value);
                        }
                        entities.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                string str = ex.ToString();
            }
            finally
            {
                functl.Dispose();
                //  data01.Dispose();
                keyitems.Clear();
            }

        }

    }
}
