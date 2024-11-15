using FinanceAccountProgram.Models.Config;
using JINSHIN.FinanceAccount.Libary.Config;
using JINSHIN.FinanceAccounting.DB;
using JINSHIN.FinanceAccounting.DB.VModel;
using JINSHIN.Package.Libary.InvScan;
using JINSHIN.Package.Libary.InvScan.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace JINSHIN.Finance.AccountSystem.FrmControl.Invoice
{
    public partial class FrmOftenAccData : Form
    {
        public InvModel invmodel { get; set; }
        public FrmOftenAccData()
        {
            InitializeComponent();
            invmodel = new InvModel();
        }

        private void FrmOftenAccData_Load(object sender, EventArgs e)
        {
            int dlink = 0;
            int mlink = 0;
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    var data = entity.JINSHINFINANCE050.Where(o => o.Ddatalink == dlink
                                   && o.Mdatalink == mlink).OrderBy(i => i.Sn).ToList();
                }
            }
            //txtMonth.Text = DateTime.Now.Month.ToString();
        }

        private void lblMonth_Click(object sender, EventArgs e)
        {

        }

        private void txtMonth_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// sn:1,2,3
        /// datatype:1,1,2
        /// </summary>
        /// <param name="mlink"></param>
        /// <param name="dlink"></param>
        /// <param name="entity"></param>
        /// <returns></returns>
        private List<JINSHINFINANCE035> GetInputData(int mlink, int dlink, AccountEntities entity)
        {
            List<JINSHINFINANCE035> result = new List<JINSHINFINANCE035>();
            try
            {
                var data = entity.JINSHINFINANCE050.Where(o => o.Ddatalink == dlink
                                  && o.Mdatalink == mlink).OrderBy(i => i.Sn).ToList();

                string acc_no = "WF" + invmodel.InvDate.Value.Year.ToString("0000")
                    + invmodel.InvDate.Value.Month.ToString("00")
                    +invmodel.InvDate.Value.Day.ToString("00");

                var val = entity.JINSHINFINANCE035.Where(i => i.Acc_No.IndexOf(acc_no) != -1).GroupBy(v=>v.Acc_No).ToList();
                int cnt = val.Count();
                string strlen = "";
                for (int i = 0; i < AccountingReso.accnoLen; i++)
                {
                    strlen += "0";
                }
                int itemid = 1;
                foreach (var item in data)
                {
                    JINSHINFINANCE035 cost = new JINSHINFINANCE035();
                    cost.Acc_No = acc_no + (cnt+1).ToString(strlen);
                    cost.Cost_Date = invmodel.InvDate;
                    cost.Cost_M = Convert.ToByte(invmodel.InvDate.Value.Month);
                    cost.Acc_ID = item.AccId;
                    cost.Acc_Desc = item.classtext;
                    cost.Inv_Date = invmodel.InvDate;
                    cost.Invoice_No = invmodel.InvNO;
                    cost.Sell_ID = invmodel.selId;
                    cost.Buy_ID = invmodel.buyId;
                    cost.Item = itemid;
                    cost.DataType = Convert.ToByte(item.datatype.Value);
                    cost.Amount = item.Amount;
                    cost.Status = coststatus.accountcreated;
                    result.Add(cost);
                    itemid++;
                }
                return result.OrderBy(v => v.SN).ToList();
            }
            catch (Exception ex)
            {
                return result;
            }
        }

        /// <summary>
        /// 銀行存款支出
        /// </summary>
        /// <param name="mlink"></param>
        /// <param name="dlink"></param>
        /// <param name="entity"></param>
        /// <param name="masterNo"></param>
        private void AutoInputData(int mlink, int dlink, AccountEntities entity)
        {
            try
            {
                var data = entity.JINSHINFINANCE050.Where(o => o.Ddatalink == dlink
                                  && o.Mdatalink == mlink).OrderBy(i => i.Sn).ToList();
        
                string acc_no = "WF" + invmodel.InvDate.Value.Year.ToString("0000") 
                    + invmodel.InvDate.Value.Month.ToString("00")
                    +invmodel.InvDate.Value.Day.ToString("00");

                var val = entity.JINSHINFINANCE035.Where(i => i.Acc_No.IndexOf(acc_no) != -1).GroupBy(v=>v.Acc_No).ToList();
                int cnt = val.Count();
                string strlen = "";
                for (int i = 0; i < AccountingReso.accnoLen; i++)
                {
                    strlen += "0";
                }
                int item01 = 1;
                foreach (var item in data)
                {
                    JINSHINFINANCE035 cost = new JINSHINFINANCE035();
                    cost.Acc_No = acc_no + (cnt+1).ToString(strlen);
                    cost.Cost_Date = invmodel.InvDate;
                    cost.Cost_M = Convert.ToByte(invmodel.InvDate.Value.Month);
                    cost.Acc_ID = item.AccId;
                    cost.Acc_Desc = item.classtext;
                    cost.Inv_Date = invmodel.InvDate;
                    cost.Invoice_No = invmodel.InvNO;
                    cost.Sell_ID = invmodel.selId;
                    cost.Buy_ID = invmodel.buyId;
                    cost.Item = item01;
                    cost.DataType = Convert.ToByte(item.datatype.Value);
                    cost.Amount = item.Amount;                  
                    cost.Status = coststatus.accountcreated;
                    entity.JINSHINFINANCE035.Add(cost);
                    item01++;
                }
                entity.SaveChanges();
            }
            catch (Exception ex)
            { 
            
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="mlink"></param>
        /// <param name="dlink"></param>
        /// <param name="day"></param>
        /// <param name="money"></param>
        private void BuildTheCostData(string name, int mlink, int dlink, int day,
            int money,int tax,string desc,string sellid,string buyid,string invno)
        {
            try
            {               
                using (AccountEntityDB content = new AccountEntityDB())
                {
                    using (AccountEntities entity = content.GetEntity())
                    {
                        List<JINSHINFINANCE035> rs = GetInputData(mlink, dlink, entity);
                        rs[0].Amount = money;
                        rs[0].Acc_Desc = desc +"-" + rs[0].Acc_Desc;                        
                        entity.JINSHINFINANCE035.Add(rs[0]);
                        rs[1].Amount = tax;
                        rs[1].Acc_Desc = desc +"-" + rs[1].Acc_Desc;
                        rs[2].Amount = money +tax;
                        rs[2].Acc_Desc = desc +"-" + rs[2].Acc_Desc;
                        for (int i = 0; i < rs.Count; i++)
                        {
                            rs[i].Sell_ID = sellid;
                            rs[i].Buy_ID = buyid;
                            rs[i].Item = i+1;
                            rs[i].Invoice_No = invno;
                        }
                        entity.JINSHINFINANCE035.Add(rs[1]);
                        entity.JINSHINFINANCE035.Add(rs[2]);
                        entity.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }


        private void BuildTheCostData(string name, int mlink, int dlink,int day)
        {
            try
            {
                invmodel.InvDate = new DateTime(invmodel.InvDate.Value.Year, invmodel.InvDate.Value.Month, day);
                using (AccountEntityDB content = new AccountEntityDB())
                {
                    using (AccountEntities entity = content.GetEntity())
                    {
                        AutoInputData(mlink, dlink, entity);
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            int year = dtPicker.Value.Year;
            int month = dtPicker.Value.Month;
            invmodel.InvDate = new DateTime(year, month, 1);
            BuildTheCostData("租金支出", 6, 1,1);
        }

        private void btnOffice_Click(object sender, EventArgs e)
        {
            int year = dtPicker.Value.Year;
            int month = dtPicker.Value.Month;
            invmodel.InvDate = new DateTime(year, month, 2);
            BuildTheCostData("Office365", 2, 2,2);
        }

        private void btnProduce_Click(object sender, EventArgs e)
        {
         //   DateTimeSet();
            int year = dtPicker.Value.Year;
            int month = dtPicker.Value.Month;          
            invmodel.InvDate = new DateTime(year,month,1);
            BuildTheCostData("租金支出", 6, 1,1);
            BuildTheCostData("Office365", 2, 2,2);
            BuildTheCostData("媒體分攤", 32, 1,1);
        }

        private void btnMeidaShare_Click(object sender, EventArgs e)
        {
            int year = dtPicker.Value.Year;
            int month = dtPicker.Value.Month;
            invmodel.InvDate = new DateTime(year, month, 1);
            BuildTheCostData("媒體分攤", 32, 1,1);
        }

        private void DateTimeSet()
        {           
           invmodel.InvDate = dtPicker.Value;
        }

        private void btnScanPic_Click(object sender, EventArgs e)
        {
            string path = @"E:\DrawImg\";
            List<string> data = new List<string>();
            DirectoryInfo di = new DirectoryInfo(path);
            ScanInvObject scan = new ScanInvObject();
            foreach (var item in di.GetFiles())
            {
                data.Add(item.FullName);
            }
            foreach (var item in data)
            {
                scan.analyze(item);
            }
            scan.Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gbQuery_Enter(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int year = dtPicker.Value.Year;
            int month = dtPicker.Value.Month;
            int day = dtPicker.Value.Day;
            invmodel.InvDate = new DateTime(year, month, day);
            int amount = Convert.ToInt32(txtAmount.Text);
            int tax = Convert.ToInt32(txtTax.Text);
            string desc = txtDesc.Text;
            BuildTheCostData("郵電費", 6, 5, day,amount,tax,desc,txtSellId.Text,
                txtBuyId.Text, txtInvVal.Text);
        }

        private void gbTexts_Enter(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            if (txtAmount.Text != "")
            {
                
                double ttlamt = 0;
                double.TryParse(txtAmount.Text, out ttlamt);
                int tax = Convert.ToInt32(ttlamt*0.05);
                txtTax.Text = tax.ToString();
            }
        }

        private void btnOther_Click(object sender, EventArgs e)
        {
            int year = dtPicker.Value.Year;
            int month = dtPicker.Value.Month;
            int day = dtPicker.Value.Day;
            invmodel.InvDate = new DateTime(year, month, day);
            int amount = Convert.ToInt32(txtAmount.Text);
            int tax = Convert.ToInt32(txtTax.Text);
            string desc = txtDesc.Text;
            BuildTheCostData("一般營運使用", 5, 1, day, amount, tax, desc, txtSellId.Text,
                txtBuyId.Text,txtInvVal.Text);
        }

		private void btnOils_Click(object sender, EventArgs e)
		{
			int year = dtPicker.Value.Year;
			int month = dtPicker.Value.Month;
			int day = dtPicker.Value.Day;
			invmodel.InvDate = new DateTime(year, month, day);
			int amount = Convert.ToInt32(txtAmount.Text);
			int tax = Convert.ToInt32(txtTax.Text);
			string desc = txtDesc.Text;
			BuildTheCostData("油資", 7, 1, day, amount, tax, desc, txtSellId.Text,
				txtBuyId.Text, txtInvVal.Text);
		}
	}
}
