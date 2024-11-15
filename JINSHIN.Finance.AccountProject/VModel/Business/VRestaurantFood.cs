
using FinanceAccountProgram.Models.UControl;
using JINSHIN.FinanceAccounting.DB;
using FinanceAccountProgram.VModel.UsrControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JINSHIN.BUSINESS.LIBARY.Models;
using JINSHIN.BUSINESS.LIBARY.UIControls.GridView;
using JINSHIN.BUSINESS.LIBARY.Models.UIControls;
using JINSHIN.BUSINESS.LIBARY.UIControls.FormMgt.EntityVModel;
using JINSHIN.BUSINESS.LIBARY.Models.UControl.GView;
using JINSHIN.FinanceAccount.Libary.VModels;
using JINSHIN.FinanceAccounting.DB.VModel;

namespace FinanceAccountProgram.VModel.Business
{
    public class VRestaurantFood : VBase
    {
        public BaseGridCtl gridviewctl { get; set; }
        public entityNames mastertype { get; set; }
        public List<NameValues> mvalues { get; set; }
        public DBClassCtl dbclassctl { get; set; }
        public EntityControl control { get; set; }
        public List<DataModel> mdata { get; set; }
        public VRestaurantFood()
        {
            gridviewctl = new BaseGridCtl();
            mastertype = new entityNames();
            mvalues = new List<NameValues>();
            dbclassctl = new DBClassCtl();
            control = new EntityControl(gridviewctl);
        }
        

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
                    JINSHINFINANCE045 product = new JINSHINFINANCE045();
                    using (EntityControl fc = new EntityControl(new BaseGridCtl()))
                    {
                        fc.SetKeys<JINSHINFINANCE045>(product, values);
                    }
                    entity.JINSHINFINANCE045.Add(product);
                    entity.SaveChanges();
                }
            }
        }
        public void RemoveData(JINSHINFINANCE045 val)
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    entity.JINSHINFINANCE045.Remove(val);
                    entity.SaveChanges();
                }
            }
        }

        public List<JINSHINFINANCE045> GetProductALL(string key) 
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    var values = entity.JINSHINFINANCE045.Where(o => o.ProClass == key).ToList();
                    return values;
                }
            }
        }
    }
}
