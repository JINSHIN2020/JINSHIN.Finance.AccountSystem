using FinanceAccountProgram.Models;
using JINSHIN.Finance.AccountSystem.Resources;
using JINSHIN.FinanceAccounting.DB;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JINSHIN.BUSINESS.LIBARY.Base;
using JINSHIN.FinanceAccount.Libary.Config;
using JINSHIN.FinanceAccounting.DB.VModel;

namespace FinanceAccountProgram.VModel.Business
{
    public class AccDataModel : JBase
    {
        public string acc_id { get; set; }
        public JINSHINFINANCE041 accname { get; set; }
        public string datadesc { get; set; }
        public bool? check { get; set; }
    }
    public class BusinessCtl :JBase
    {
        public void VerifyInvoiceAndAmount(List<JINSHINFINANCE035> values, DataGridView dgControl, ListBox lstmsg,string accid)
        {
            List<JINSHINFINANCE035> costitem = new List<JINSHINFINANCE035>();
            List<string> msgs = new List<string>();
            string msg01 = "借貸沒有平衡,數量為";
            int cnt = 0;
            int counter = 0;
            string msg02 = "傳票數量共有";
            string msg03 = "發票號碼重覆,號碼:{0},發票:{1},金額:{2}";
            List<JINSHINFINANCE035> nodata = new List<JINSHINFINANCE035>();
            foreach (var item in values.GroupBy(o => o.Acc_No))
            {
                decimal data01 = item.Where(o => o.DataType == 1).Sum(o => o.Amount).Value;
                decimal data02 = item.Where(o => o.DataType == 2).Sum(o => o.Amount).Value;
                nodata.Add(item.First());
                if (data01 != data02)
                {
                    costitem.AddRange(item);
                    cnt = cnt + 1;
                    msgs.Add(msg01 + cnt.ToString());
                }
                counter = counter + 1;
            }
            msgs.Add(msg02 + counter.ToString());
            counter = 0;
            foreach (var item in nodata.Where(o => o.Invoice_No != "" && o.Invoice_No != null).GroupBy(o => o.Invoice_No))
            {
                if (item.Count() > 1)
                {
                    foreach (var v in item)
                    {
                        msgs.Add(string.Format(msg03, v.Acc_No, v.Invoice_No, v.Amount));
                        counter = counter + 1;
                    }
                }
            }
            msgs.Add("發票號碼重覆數量為" + counter.ToString());
            decimal get = values.Where(o => o.DataType == 1 && o.Acc_ID  == accid).Sum(o => o.Amount).Value;
            decimal lend = values.Where(o => o.DataType == 2 && o.Acc_ID == accid).Sum(o => o.Amount).Value;
            decimal total = get - lend;
            if (total > 0)
            {
                msgs.Add("借方餘額:" + total.ToString());
            }
            else if (total < 0)
            {
                msgs.Add("貸方餘額:" + total.ToString());
            }
            else {
                msgs.Add("借貸平衡");
            }
            var accids = values.GroupBy(o => o.Acc_ID);
            foreach (var item in accids)
            {
                msgs.Add(item.First().Acc_ID + "總數量:" + item.Count());
            }
            lstmsg.Items.Clear();
            foreach (var i in msgs)
            {
                lstmsg.Items.Add(i);
            }
            dgControl.DataSource = costitem;
            dgControl.Refresh();
        }

        public async Task<bool> ShowMsg(string msg,Label lbl)
        {
            lbl.Visible = true;
            lbl.Text = msg;           
           // System.Threading.Thread.Sleep(Convert.ToInt32(accounting.MsgTime));
           // lbl.Visible = false;
            return true;
        }

        public List<IGrouping<string, AccDataModel>> GetAccVerifysInfo()
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    List<JINSHINFINANCE041> names = entity.JINSHINFINANCE041.ToList();
                    var contents = AccCostItemConfig.GetClassData(entity.JINSHINFINANCE035.Where(o => o.Cost_Date.Value.Year == AccountingReso.yearnow).ToList());
                    var data = contents.GroupJoin(names,
                        (cost) => new { acc_id = cost.Acc_ID }, (accname) => new { acc_id = accname.Acc_ID },
                        (cost, accname) => new AccDataModel()
                        {
                            acc_id = cost.Acc_ID,
                            check = cost.Cost_Check,
                            accname = accname.FirstOrDefault()
                        }).ToList();
                    var vals = data.GroupBy(o => o.acc_id).ToList();
                    return vals;
                }
            }
        }
    }
}
