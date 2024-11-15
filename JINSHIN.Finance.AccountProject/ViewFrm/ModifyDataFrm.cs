using JINSHIN.Finance.AccountSystem.Resources;
using JINSHIN.FinanceAccounting.DB;
using FinanceAccountProgram.VModel.Conrols.GridView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JINSHIN.FinanceAccount.Libary.Config;
using JINSHIN.FinanceAccount.Libary.VModels;
using JINSHIN.FinanceAccounting.DB.VModel;
using JINSHIN.FinanceAccount.Libary.VModels.AccControl;

namespace FinanceAccountProgram.ViewFrm
{
    public partial class ModifyDataFrm : Form
    {
        public List<JINSHINFINANCE035> values { get; set; }
        public int amountcellidx { get; set; }
        public int sncellidx { get; set; }
        public ModifyDataFrm(int snidx,int amountidx)
        {
            InitializeComponent();
            sncellidx = snidx;
            amountcellidx = amountidx;
        }

        private void ModifyDataFrm_Load(object sender, EventArgs e)
        {
            datagridContent.DataSource = values;
            using (AccNoGridView gridview = new AccNoGridView())
            {
                gridview.SetAccConfirmGridColumns(datagridContent);
            }            
        }

        private void btnModifyData_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "確認修改資料!", "訊息", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                long sn = 0;
                try
                {
                    using (AccountEntityDB content = new AccountEntityDB())
                    {
                        using (AccountEntities entity = content.GetEntity())
                        {
                            var data = entity.JINSHINFINANCE035.Where(o => o.Cost_Date.Value.Year == AccountingReso.yearnow).ToList();
                            for (int i = 0; i < datagridContent.Rows.Count; i++)
                            {
                                sn = long.Parse(datagridContent.Rows[i].Cells[sncellidx].Value.ToString());
                                var val = data.Where(o => o.SN == sn).FirstOrDefault();
                                val.Amount = decimal.Parse(datagridContent.Rows[i].Cells[amountcellidx].Value.ToString());
                            }
                            entity.SaveChanges();
                        }
                    }
                }
                catch (Exception )
                {

                }                
            }
        }

        private void ModifyDataFrm_Shown(object sender, EventArgs e)
        {
            SysRescControlVModel.SetFixedWindow(this);
        }
    }
}
