using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinanceAccountProgram.VModel;
using FinanceAccountProgram.Models.Config;
using FinanceAccountProgram.VModel.Conrols;
using FinanceAccountProgram.Models;
using JINSHIN.FinanceAccounting.DB;
using JINSHIN.FinanceAccount.Libary.Models.Base;
using JINSHIN.BUSINESS.LIBARY.Resources;
using JINSHIN.FinanceAccounting.DB.VModel;

namespace FinanceAccountProgram.Controls
{
    public partial class MasterUserControl : UserControl
    {
        public DBClassCtl dbclassctl { get; set; }
        public ClassTypeConfig<JINSHINFINANCE034> tab06 { get; set; }
        public ListBox lstClassNamedata { get; set; }

        public void SetInit()
        {

        }
        public MasterUserControl()
        {
            InitializeComponent();
            dgClassData.Font = new System.Drawing.Font(DataControl.DataGridFont, Convert.ToInt32(DataControl.DataGridFontSize));
        }        
        private void btnClassAdd_Click(object sender, EventArgs e)
        {
            tab06.types = DBClassType.Acc_DetailClass;
            txClassNO.Text = dbclassctl.GetClassNameMaxInt(DBClassType.Acc_DetailClass,lstClassName.SelectedValue).ToString(); ;
            txClassNO.Focus();           
        }

        private void Query_Class(int masterno)
        {
           if (tab06.types == DBClassType.Acc_DetailClass)
            {                
                List<JINSHINFINANCE037> rs = dbclassctl.QueryAcc_DetailClass(masterno);
                dgClassData.DataSource = rs;
                lstClassName.DataSource = tab06.mclass;
                lstClassName.DisplayMember = "Name";
                lstClassName.ValueMember = "No";                
                using (GridViewFinanceBase gvbase = new GridViewFinanceBase(AddQueryEnum.None))
                {
                    gvbase.columns = new List<string>() { "序號", "主序", "名稱", "建立日期" };
                    gvbase.SetDataColumns(dgClassData);
                }
            }
            dgClassData.Refresh();
        }

        private void txClassName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dbclassctl.InsertClassData(txClassName.Text, Convert.ToInt32(txClassNO.Text), tab06.types, int.Parse(lstClassName.SelectedValue.ToString()));
                Query_Class(Convert.ToInt32(lstClassName.SelectedValue));
            }
        }

        private void btnClassUpdate_Click(object sender, EventArgs e)
        {
            Query_Class(Convert.ToInt32(lstClassName.SelectedValue));
        }

        private void MasterUserControl_Load(object sender, EventArgs e)
        {
            lstClassNamedata = lstClassName;
            
        }

        private void txClassNO_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
              txClassName.Focus();
            }
        }

        private void dgClassData_MouseClick(object sender, MouseEventArgs e)
        {
            //if (MessageBox.Show("是否確認要刪除!", "對話框", MessageBoxButtons.OKCancel) == DialogResult.OK)
            //{
            //    int datano = Convert.ToInt32((sender as DataGridView).CurrentRow.Cells[0].Value);
            //    int datano02 = Convert.ToInt32((sender as DataGridView).CurrentRow.Cells[1].Value);
            //    using (AccountEntities entities = new AccountEntities())
            //    {
            //        var accclass = entities.JINSHINFINANCE037.Where(o => o.No == datano && o.MaNo == datano02 ).FirstOrDefault();
            //        entities.JINSHINFINANCE037.Remove(accclass);
            //        entities.SaveChanges();
            //    }
            //    Query_Class(Convert.ToInt32(lstClassName.SelectedValue));
            //}            
        }

        private void lstClassName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstClassName.SelectedIndex != 0)
               Query_Class(Convert.ToInt32(lstClassName.SelectedValue));
            else
               Query_Class(0);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否確認要刪除!", "對話框", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int datano = Convert.ToInt32(dgClassData.CurrentRow.Cells[0].Value);
                int datano02 = Convert.ToInt32(dgClassData.CurrentRow.Cells[1].Value);
                using (AccountEntityDB content = new AccountEntityDB())
                {
                    using (AccountEntities entities = content.GetEntity())
                    {
                        var accclass = entities.JINSHINFINANCE037.Where(o => o.No == datano && o.MaNo == datano02).FirstOrDefault();
                        entities.JINSHINFINANCE037.Remove(accclass);
                        entities.SaveChanges();
                    }
                }
                Query_Class(Convert.ToInt32(lstClassName.SelectedValue));
            }
        }

        private void dgClassData_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dbclassctl.InsertClassData(txClassName.Text, Convert.ToInt32(txClassNO.Text), tab06.types, int.Parse(lstClassName.SelectedValue.ToString()));
            Query_Class(Convert.ToInt32(lstClassName.SelectedValue));
        }
    }
}
