using FinanceAccountProgram.Models;
using JINSHIN.FinanceAccounting.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using JINSHIN.FinanceAccount.Libary.Models.Base;
using JINSHIN.BUSINESS.LIBARY.Base;

namespace FinanceAccountProgram.VModel.Conrols.Model
{
    public class GridViewControl :JBase
    {
        public List<JINSHINFINANCE034> datasource01 { get; set; }
        public List<JINSHINFINANCE037> datasource02 { get; set; }
        public List<JINSHINFINANCE057> datasource03 { get; set; }
        public GridViewControl(AddQueryEnum type)
        {
            using (AccountEntities book_entity = new AccountEntities())
            {
                switch (type)
                {
                    case AddQueryEnum.None:
                        break;
                    case AddQueryEnum.Acc_CostData:
                        {
                            datasource01 = book_entity.JINSHINFINANCE034.ToList();
                            datasource02 = book_entity.JINSHINFINANCE037.ToList();
                            datasource03 = book_entity.JINSHINFINANCE057.ToList();
                        }
                        break;
                    case AddQueryEnum.Acc_VerifyCostData:
                        {
                            datasource01 = book_entity.JINSHINFINANCE034.ToList();
                            datasource02 = book_entity.JINSHINFINANCE037.ToList();
                            datasource03 = book_entity.JINSHINFINANCE057.ToList();
                        }
                        break;
                    case AddQueryEnum.Invoice_Contract:
                        {

                        }
                        break;
                    default:
                        break;
                }
            }

        }
    }
}
