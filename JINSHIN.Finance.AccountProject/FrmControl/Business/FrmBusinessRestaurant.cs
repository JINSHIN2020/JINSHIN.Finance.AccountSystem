using FinanceAccountProgram.Models.Business;
using FinanceAccountProgram.Models.Config;
using FinanceAccountProgram.Models.Config.UpdataeForm;
using FinanceAccountProgram.Models.UControl;
using JINSHIN.Finance.AccountSystem.Resources;
using FinanceAccountProgram.VModel.Business;
using FinanceAccountProgram.VModel.Conrols.GridView;
using FinanceAccountProgram.VModel.UsrControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinanceAccountProgram.VModel.Conrols.ManageForm;
using JINSHIN.BUSINESS.LIBARY.UIControls.GridView;
using JINSHIN.BUSINESS.LIBARY.VModel;
using JINSHIN.BUSINESS.LIBARY.Models.UControl.GView;
using JINSHIN.FinanceAccounting.DB;
using JINSHIN.FinanceAccount.Libary.Config;
using JINSHIN.Finance.AccountSystem;
using JINSHIN.FinanceAccount.Libary.VModels;
using JINSHIN.FinanceAccounting.DB.VModel;
using JINSHIN.FinanceAccount.Libary.VModels.Config;
using JINSHIN.FinanceAccount.Libary.VModels.AccControl;
using JINSHIN.BUSINESS.LIBARY.Base;

namespace FinanceAccountProgram.FrmControl.Business
{
    public partial class FrmBusinessRestaurant : Form
    {
        public List<Button> btns { get; set; }
        public PathModel pathmodel { get; set; }
        public int totalprice { get; set; }
        public List<JINSHINFINANCE044> foods { get; set; }
        public List<JINSHINFINANCE044> DBfoods { get; set; }
        public string orderno { get; set; }
        public decimal ordermoney { get; set; }
        public BaseGridCtl gridviewctl { get; set; }
        public FrmBusinessRestaurant()
        {
            InitializeComponent();
            gridviewctl = new BaseGridCtl();
            btns = new List<Button>();
            pathmodel = new PathModel();
            foods = new List<JINSHINFINANCE044>();
            DBfoods = new List<JINSHINFINANCE044>();
            this.KeyUp += ViewFastKey;
            txtPayment.KeyUp += ViewFastKey;
            txtPrice.KeyUp += ViewFastKey;
            using (FormControlVModel ctlmodel = new FormControlVModel())
            {
                ctlmodel.ControlResolution(this);
            }

        }
        private void Compute()
        {
            txtPrice.Text = totalprice.ToString();



        }
        private void btnclick(object sender, EventArgs e)
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    int sn = Convert.ToInt32((sender as Button).Tag);
                    var product = entity.JINSHINFINANCE045.Where(o => o.Sn == sn).FirstOrDefault();
                    totalprice += Convert.ToInt32(product.PPrice);
                    MoneyCompute();
                    lblMsgProduct.Text += product.ProClass + ":" + product.PName + ":" + product.PPrice.ToString() + Environment.NewLine;
                }
            }
        }

        private void FrmBusinessRestaurant_Load(object sender, EventArgs e)
        {

            if (AccountingReso.yearnow == 0)
            {
                AccountingReso.yearnow = DateTime.Now.Year;
            }
            CreateButtons();
            lblMsgProduct.Text = "";
        }

        private void CreateButtons()
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    var products = entity.JINSHINFINANCE045.Where(o => o.IsDelete == false || o.IsDelete == null).ToList();
                    btns.Clear();
                    foreach (var item in products)
                    {
                        Button btn = new Button()
                        {
                            Text = item.PName + Environment.NewLine + item.PPrice.ToString(),
                            Tag = item.Sn
                            ,
                            Font = new Font("新細明體", 18)
                        };
                        btn.Click += btnclick;
                        btns.Add(btn);
                    }
                    PanelContrlData plcontrol = new PanelContrlData(plControls, Convert.ToInt32(txtCol.Text), btns.Count);
                    //plcontrol.colw = Convert.ToInt32(txtWidth.Text);
                    //plcontrol.colh = Convert.ToInt32(txtHeight.Text);
                    plcontrol.SetButtonInfo(btns, btns.Count, Convert.ToInt32(txtWidth.Text), Convert.ToInt32(txtHeight.Text));
                    plcontrol.ctable.SetTablePoints(plcontrol.MaxContentHeight);
                    plcontrol.PanelAddControl(true, plControls, new List<string>());
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CreateButtons();
        }

        private void txtPayment_TextChanged(object sender, EventArgs e)
        {
            using (SysSettingCtl setting = new SysSettingCtl())
            {
                if (!setting.GetNumberText(txtPayment.Text))
                {
                    MessageBox.Show("編碼位數一定要輸入數字!");
                    ClearScreen();
                }else
                    MoneyCompute();
            }
           
        }

        private void MoneyCompute()
        {
            txtPrice.Text = totalprice.ToString();
            int payment = Convert.ToInt32(txtPayment.Text);
            lblRemainPrice.Text = (payment - totalprice).ToString();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            using (SysSettingCtl setting = new SysSettingCtl())
            {
                if (!setting.GetNumberText(txtPrice.Text))
                {
                    MessageBox.Show("編碼位數一定要輸入數字!");
                    ClearScreen();
                }
                else
                    MoneyCompute();
            }           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearScreen();
        }

        private void ClearScreen()
        {
            totalprice = 0;
            txtPayment.Text = "100";
            txtPrice.Text = "0";
            lblMsgProduct.Text = "";
            lblRemainPrice.Text = "";
            ordermoney = 0;
            orderno = "";
        }

        public void ViewFastKey(object obj, KeyEventArgs args)
        {
            if (args.KeyCode == Keys.F1)
            {
                btnSave_Click(new object(), null);
            }
            else if (args.KeyCode == Keys.F2)
            {
                btnClear_Click(new object(), null);
            }          
        }

        
        private void btnSave_Click(object sender, EventArgs e)
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    try
                    {
                        var rs = SaveToOrder(entity).Result;
                        string data = txtPayment.Text;
                        int dataprice = Convert.ToInt32(data);
                        int ttlprice = totalprice;
                        ClearScreen();
                        txtPayment.Text = (dataprice - ttlprice).ToString();
                    }
                    catch (Exception ex)
                    {
                        string str = ex.ToString();
                    }
                }
            }
        }

        public delegate void textcontrol();
        public void txtControlVisiable( )
        {
            lblMsgDisplay.Visible = true;
            lblMsgDisplay.Text = string.Format(accounting.RestMsg, orderno, ordermoney);
        }

        public void ShowMsgInvoke()
        {
            using (BusinessCtl ctl = new BusinessCtl())
            {
                var ctlmsg = ctl.ShowMsg(string.Format(accounting.RestMsg, orderno, ordermoney), lblMsgDisplay).ContinueWith(
                       o =>
                       {
                           //textcontrol txt = new textcontrol(txtControlVisiable);
                           //this.Invoke(txt, false);
                           if (timer1.Enabled)
                           {
                               timer1.Stop();
                               timer1.Start();
                           }
                           else
                               timer1.Enabled = true;
                       }
                       );
            }
        }
        public void ShowMsg()
        {
            textcontrol txt = new textcontrol(txtControlVisiable);
            this.Invoke(txt,false);

          
        }

        private async Task<bool> SaveToOrder(AccountEntities entity)
        {
            JINSHINFINANCE043 order = new JINSHINFINANCE043();
            string no = entity.GetTableNo(6, FormConfig.JINSHINFINANCE043Title, 5).FirstOrDefault().ToString();
            orderno = no;
            order.Order_No = no;
            order.TtlPrice = totalprice;
            order.OrderName = DateTime.Now.ToString("yyyyMMddHH") + "餐點";
            order.UsNo = DataClass.usrno;
            order.CDate = DateTime.Now;
            foods.Clear();

            string[] details = lblMsgProduct.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            foods.Clear();
            int sn = 1;
            try
            {
                foreach (var item in details)
                {
                    string[] vals = item.Split(':');
                    if (vals.Length == 3)
                    {
                        JINSHINFINANCE044 detail = new JINSHINFINANCE044();
                        detail.PName = vals[1];
                        detail.PPrice = Convert.ToDecimal(vals[2]);
                        detail.OrderNo = no;
                        detail.CDate = DateTime.Now;
                        detail.Discount = 1;
                        detail.ProClass = vals[0];
                        detail.Num = 1;
                        detail.CDate = DateTime.Now;
                        foods.Add(detail);
                    }
                }
                DBfoods.Clear();
                var lst = foods.OrderBy(o => o.PName).GroupBy(o => o.PName).ToList();
                SaveAccItemData(entity);
                entity.SaveChanges();
                txtControlVisiable();
                timer1.Enabled = true;
                foreach (var item in lst)
                {
                    var food = item.First();
                    food.Num = item.Count();
                    food.PPrice = item.Sum(o => o.PPrice);
                    food.No = sn;
                    DBfoods.Add(food);
                    sn++;
                }
                entity.JINSHINFINANCE043.Add(order);
                entity.SaveChanges();
                entity.JINSHINFINANCE044.AddRange(DBfoods);
                entity.SaveChanges();
            }
            catch (Exception ex)
            {
                string str = ex.ToString();
            }
            //  var datactl = ctlmsg.Result;
            return false;
        }

        private void SaveAccItemData(JINSHIN.FinanceAccounting.DB.AccountEntities entity)
        {            
            string costno = entity.GetTableNo(1, AccountingReso.accno_id, AccountingReso.accnoLen).FirstOrDefault().ToString();
            decimal amount = foods.Sum(o => o.PPrice).Value;
            ordermoney = amount;
            decimal moneyamount = 0;
            if (chTaxRate.Checked)
                moneyamount = amount / Convert.ToDecimal(1.05);
            else
                moneyamount = amount;
            decimal taxamount = amount - moneyamount;
            DateTime accdate = DateTime.Now;
            JINSHINFINANCE035 costitem03 = new JINSHINFINANCE035();
            costitem03.Acc_ID = accounting.RestACCIDGet;
            costitem03.Acc_Desc = accdate.ToString("yyyyMMdd") + costno.Substring(costno.Length - 3, 3) + accounting.RestACCDesc;
            costitem03.Amount = moneyamount;
            costitem03.Cost_Date = new DateTime(accdate.Year, accdate.Month, accdate.Day);
            costitem03.Status = 1;
            costitem03.Cost_M = Convert.ToByte(accdate.Month);
            costitem03.Acc_No = costno;
            costitem03.DataType = 1;
            costitem03.Item = 1;
            entity.JINSHINFINANCE035.Add(costitem03);

            if (chTaxRate.Checked)
            {
                JINSHINFINANCE035 costitem02 = new JINSHINFINANCE035();
                costitem02.Acc_ID = accounting.TaxACCID;
                costitem02.Acc_Desc = DateTime.Now.ToString("yyyyMMdd") + costno.Substring(costno.Length - 3, 3) + accounting.TaxDesc;
                costitem02.Amount = taxamount;
                costitem02.Cost_Date = new DateTime(accdate.Year, accdate.Month, accdate.Day);
                costitem02.Status = 1;
                costitem02.Cost_M = Convert.ToByte(accdate.Month);
                costitem02.Acc_No = costno;
                costitem02.DataType = 1;
                costitem02.Item = 2;
                entity.JINSHINFINANCE035.Add(costitem02);
            }

            JINSHINFINANCE035 costitem01 = new JINSHINFINANCE035();
            costitem01.Acc_ID = accounting.RestACCIDLend;
            costitem01.Acc_Desc = DateTime.Now.ToString("yyyyMMdd") + costno.Substring(costno.Length - 3, 3) + accounting.RestACCDesc;
            costitem01.Amount = amount;
            costitem01.Cost_Date = new DateTime(accdate.Year, accdate.Month, accdate.Day);
            costitem01.Status = 1;
            costitem01.Cost_M = Convert.ToByte(accdate.Month);
            costitem01.Acc_No = costno;
            costitem01.DataType = 2;
            costitem01.Item = 3;
            entity.JINSHINFINANCE035.Add(costitem01);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblMsgDisplay.Visible = false;
            timer1.Enabled = false;
        }

        private void ViewDiaryProductReport()
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    //    var data = entity.JINSHINFINANCE044.Where(o => o.CDate.Value.Year == DateTime.Now.Year
                    //&& o.CDate.Value.Month == DateTime.Now.Month
                    //&& o.CDate.Value.Day == DateTime.Now.Day
                    //).GroupBy(o => o.PName).Select(i => new OrderDetailModel()
                    //{
                    //    No = i.FirstOrDefault().No,
                    //    CDate = i.FirstOrDefault().CDate,
                    //    ProClass = i.FirstOrDefault().ProClass,
                    //    PName = i.FirstOrDefault().PName,
                    //    Num = i.Sum(y => y.Num),
                    //    PPrice = i.Sum(y => y.PPrice)
                    //}).ToList();

                     var data = entity.JINSHINFINANCE044.Where(o => o.CDate.Value.Year == DateTime.Now.Year
                   && o.CDate.Value.Month == DateTime.Now.Month
                   && o.CDate.Value.Day == DateTime.Now.Day
                   ).Select(i => new OrderDetailModel()
                   {
                       No = i.No,
                       CDate = i.CDate,
                       ProClass = i.ProClass,
                       PName = i.PName,
                       Num = i.Num,
                       PPrice = i.PPrice
                   }).ToList();

                    BusiDataModelControl modelcontrol = new BusiDataModelControl();
                    List<DataModel> models = modelcontrol.ConvertOrderDetailToDataModel(data);
                    gridviewctl.SetGridColumns<Acc_DiaryFoods_DGItems>(datatodayfoods, new Acc_DiaryFoods_DGItems());
                    datatodayfoods.DataSource = models;
                    modelcontrol.Dispose();
                }
            }
        }

      

        private void tabPanels_SelectedIndexChanged(object sender, EventArgs e)
        {
            ViewDiaryProductReport();
        }

        private void FrmBusinessRestaurant_Shown(object sender, EventArgs e)
        {
            SysRescControlVModel.SetFixedWindow(this);
        }
    }
}
