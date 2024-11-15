using FinanceAccountProgram.Models;
using JINSHIN.BUSINESS.LIBARY.Base;
using JINSHIN.FinanceAccount.Libary.VModels;
using JINSHIN.FinanceAccounting.DB;
using JINSHIN.FinanceAccounting.DB.VModel;
using ProjectResourceData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceAccountProgram.VModel.Business
{
    public class SysSettingCtl : JBase
    {
        public void SetYearMoney(decimal value)
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    var data = entity.Acc_SysSetting.Where(o => o.SysName == CommonVar.SettleMoney).FirstOrDefault();
                    data.SysVal = value.ToString();
                    data.UDate = DateTime.Now;
                    entity.SaveChanges();
                }
            }
        }
        public string LoadYearMoney(string name)
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    var data = entity.Acc_SysSetting.Where(o => o.SysName == name).FirstOrDefault();
                    if (data.UDate != null)
                    {
                        if (DateTime.Now.Subtract(data.UDate.Value).Days >= 1)
                        {
                            return "0";
                        }
                        else
                        {
                            return data == null ? "" : data.SysVal;
                        }
                    }
                    return data == null ? "" : data.SysVal;
                }
            }
        }

        public string LoadData(string name)
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    var data = entity.Acc_SysSetting.Where(o => o.SysName == name).FirstOrDefault();
                    return data == null ? "" : data.SysVal;
                }
            }
        }
        public bool GetNumberText(string val)
        {
            foreach (var item in val.ToString().ToCharArray())
            {
                if (!(item >= 48 && item <= 57))
                {
                    
                    return false;
                }
            }
            if (string.IsNullOrEmpty(val))
            {
                val = null;
            }                
            return true;
        }
    }
}
