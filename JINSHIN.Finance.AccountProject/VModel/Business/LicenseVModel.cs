using JINSHIN.BUSINESS.LIBARY.Base;
using JINSHIN.BUSINESS.LIBARY.Sercurity;
using JINSHIN.FinanceAccounting.DB;
using JINSHIN.FinanceAccounting.DB.VModel;
using JINSHIN.RegProcess.Liary.Content.Register.Sercurity;
using JINSHIN.WORK.Resource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceAccountProgram.VModel.Business
{
    public class LicenseVModel :JBase
    {
        public bool License(string idno)
        {
            try
            {
                if (idno == "" || idno == null)
                {
                    throw new Exception("請輸入統一編號");
                }
            }
            catch (Exception ex)
            { 
            }
            using (SercurityControl control = new SercurityControl())
            {
                DevInfo dev = control.GetPhyData();
                string pass = ProjectData.DataPass;
                try
                {
                    using (AccountEntityDB content = new AccountEntityDB())
                    {
                        using (AccountEntities entity = content.GetEntity())
                        {
                            var jinshin30 = entity.JINSHINFINANCE030.Where(i => i.IdNo == idno).FirstOrDefault();
                            if (jinshin30 != null)
                            {
                                string val01 = SSTCryptographer.GetCryLink(jinshin30.A01, pass);
                                string val02 = SSTCryptographer.GetCryLink(jinshin30.A02, pass);
                                if (val01 == dev.devdata && val02 == dev.hostname)
                                {

                                }
                                else
                                {
                                    throw new Exception("請先註冊!");
                                }
                            }
                            return true;
                        }
                    }
                }
                catch (Exception ex)
                { 
                    return false;
                }
            }
        }
    }
}
