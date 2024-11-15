using JINSHIN.BUSINESS.LIBARY.Base;
using JINSHIN.FinanceAccount.Libary.VModels.Config;
using JINSHIN.FinanceAccounting.DB;
using JINSHIN.FinanceAccounting.DB.VModel;
using ProjectResourceData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JINSHIN.Finance.AccountSystem.Config
{
    public class SysSettingControl : SysSettingCtl
    {
        public void SaveData(string val, string name)
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                AccountEntities entity = content.GetEntity();
                try
                {
                    using (SysSettingControl ctl = new SysSettingControl())
                    {
                        var data = entity.JINSHINFINANCE017.
                            Where(o => o.SysName == name).FirstOrDefault();
                        if (data != null)
                        {
                            data.SysVal = val;
                            data.UDate = DateTime.Now;
                            data.UsrNo = DataClass.empID;
                            // SetValue(vals, txts, idx, data);
                        }
                        else
                        {
                            JINSHINFINANCE017 syssetup = new JINSHINFINANCE017();
                            syssetup.SysName = name;
                            syssetup.SysVal = val;
                            syssetup.UsrNo = DataClass.empID;
                            syssetup.CreateTime = DateTime.Now;
                            entity.JINSHINFINANCE017.Add(syssetup);
                        }
                        entity.SaveChanges();
                    }
                }
                finally
                {
                    entity.Dispose();
                }
            }


        }

    }
}
