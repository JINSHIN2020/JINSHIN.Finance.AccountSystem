using FinanceAccountProgram.Models;
using JINSHIN.FinanceAccounting.DB;
using FinanceAccountProgram.VModel.UsrControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JINSHIN.BUSINESS.LIBARY.Models.UIControls;
using JINSHIN.BUSINESS.LIBARY.UIControls.FormMgt.EntityVModel;
using JINSHIN.BUSINESS.LIBARY.UIControls.GridView;
using JINSHIN.BUSINESS.LIBARY.Base;
using JINSHIN.FinanceAccount.Libary.VModels;
using JINSHIN.FinanceAccounting.DB.VModel;

namespace FinanceAccountProgram.VModel.Business
{
    public class VAcc_Words :JBase
    {
        public List<T> GetALL<T>() where T : class
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    return entity.Set<T>().ToList();
                }
            }
        }

        public void InsertData(List<NameValues> values)
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    JINSHINFINANCE042 word = new JINSHINFINANCE042();
                    using (EntityControl fc = new EntityControl(new BaseGridCtl()))
                    {
                        fc.SetKeys<JINSHINFINANCE042>(word, values);
                    }
                    entity.JINSHINFINANCE042.Add(word);
                    entity.SaveChanges();
                }
            }
        }
        public void RemoveData(JINSHINFINANCE042 val)
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    entity.JINSHINFINANCE042.Remove(val);
                    entity.SaveChanges();
                }
            }
        }

        public List<JINSHINFINANCE042> GetProductALL(string key)
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    var values = entity.JINSHINFINANCE042.Where(o => o.SName.IndexOf(key) != -1).ToList();
                    return values;
                }
            }
        }
    }
}
