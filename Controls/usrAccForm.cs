using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JINSHIN.FinanceAccounting.DB;
using FinanceAccountProgram.Models;
using FinanceAccountProgram.VModel;
using JINSHIN.BUSINESS.LIBARY.Resources;
using JINSHIN.FinanceAccounting.DB.VModel;

namespace FinanceAccountProgram.Controls
{
    public partial class usrAccForm : UserControl
    {
        public int formtype { get; set; }
        public string AccID { get; set; }
        public string AccClass { get; set; }
        public usrAccForm()
        {
            InitializeComponent();
            dgQueryData.Font = new System.Drawing.Font(DataControl.DataGridFont, Convert.ToInt32(DataControl.DataGridFontSize));
        }

        private void usrAccForm_Load(object sender, EventArgs e)
        {

        }

        public List<AccBookVModel> GetBookData()
        {
            List<AccBookVModel> values = new List<AccBookVModel>();
            int classtype = 0;
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entities = content.GetEntity())
                {
                    if ((AccID != "") && (AccClass != ""))
                    {
                        var data = entities.JINSHINFINANCE032.Where(o => o.Acc_ID == AccID && o.Acc_Type == classtype).ToList();
                    }
                    else if (AccClass != "")
                    {
                        var data = entities.JINSHINFINANCE032.Where(o => o.Acc_Type == classtype).ToList();
                    }
                    else if (AccID != "")
                    {

                    }
                }
            }
            return values;
        }
        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (formtype == 1)
            {
                AccID = txQueryAcc.Text;
                AccClass = txQueryType.Text;
                using (AccountEntityDB content = new AccountEntityDB())
                {
                    using (AccountEntities entity = content.GetEntity())
                    {

                    }
                }
            }
        }

        private void dgQueryData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
