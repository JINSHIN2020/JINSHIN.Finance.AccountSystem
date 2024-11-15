
using JINSHIN.BUSINESS.LIBARY.Base;
using JINSHIN.FinanceAccounting.DB;
using JINSHIN.FinanceAccounting.DB.VModel;
using JINSHIN.Interface.Data.Services.File;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceAccountProgram.VModel.SN
{
    public class TableFrmNo :JBase
    {
        public string GetLeaveNo()
        {
            using (AccountEntityDB db = new AccountEntityDB())
            {
                using (AccountEntities entity = new AccountEntities())
                {
                    var code = entity.JINSHINFINANCE004.Where(i => i.SupplyNo 
                              == DataClass.SupplyNo).FirstOrDefault();
                    if (code != null)
                    {
                        return entity.GetTableNo(2, code.SugKey ??"", code.Num).FirstOrDefault();
                    }
                    else
                        return entity.GetTableNo(2, "", 3).FirstOrDefault();
                }
            }
        }

        
        public string GetCodeNo(AccountEntities entity, CTATableDataNo ap)
        {
            var code = entity.JINSHINFINANCE004.Where(o => o.SupplyNo == ap.SupplyNo && ap.TableInt == ap.TableInt).FirstOrDefault();
            if (code == null || ap.SupplyNo == null)
            {            
               return entity.GetTableNo(ap.TableInt,"", ap.Num).FirstOrDefault(); 
            }
            else {
               return entity.GetTableNo(ap.TableInt , code.SugKey ?? "", code.Num).FirstOrDefault();
            }
        }
        public string GetTableNo(CTATableDataNo ap)
        {
            string rs = "";
            try
            {
                using (AccountEntityDB dbentity = new AccountEntityDB())
                {
                    using (AccountEntities entity = dbentity.GetEntity())
                    {
                        rs = GetCodeNo(entity, ap);
                        if (rs != null)
                        {
                            return rs;
                        }
                        else
                        {
                         //   MessageModel.ShowMsg(Screen_Cht.FrmSNMsg, MessageType.MsgBox).Wait();
                            //MessageBox.Show(Screen_Cht.FrmSNMsg);
                            return rs;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
             //   LogControl.LogAlarm(ex.ToString());
                return rs;
            }
            finally
            {
              
            }

        }
    }
}
