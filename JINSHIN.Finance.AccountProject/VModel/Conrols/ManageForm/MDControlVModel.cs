using FinanceAccountProgram.Models;
using JINSHIN.BUSINESS.LIBARY.Base;
using JINSHIN.FinanceAccount.Libary.VModels;
using JINSHIN.FinanceAccounting.DB;
using JINSHIN.FinanceAccounting.DB.VModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceAccountProgram.VModel.Conrols.ManageForm
{
    public class MDControlVModel :JBase
    {
        public DBClassCtl dbclassctl { get; set; }
        public List<JINSHINFINANCE034> mclass { get; set; }
        public List<JINSHINFINANCE037> dclass { get; set; }
        public MDControlVModel()
        {
            dbclassctl = new DBClassCtl();
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    mclass = entity.JINSHINFINANCE034.ToList();
                    dclass = entity.JINSHINFINANCE037.ToList();
                }
            }
        }
        public void GetMasterData(ComboBox lstClassName)
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    lstClassName.DataSource = null;
                    lstClassName.DataSource = mclass;
                    lstClassName.DisplayMember = "Name";
                    lstClassName.ValueMember = "No";
                }
            }
        }

        public void GetDetailData(ComboBox lstClassName)
        {
            lstClassName.DataSource = null;
            lstClassName.DataSource = dclass;
            lstClassName.DisplayMember = "Name";
            lstClassName.ValueMember = "No";
        }
        public void Query_Class(int masterno, ComboBox lstClassName)
        {
            lstClassName.DataSource = null;
            List<JINSHINFINANCE037> rs = dbclassctl.QueryAcc_DetailClass(masterno);
            lstClassName.DataSource = rs;
            lstClassName.DisplayMember = "Name";
            lstClassName.ValueMember = "No";          
        }
    }
}
