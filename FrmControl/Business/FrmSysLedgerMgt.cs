using JINSHIN.Finance.AccountSystem;
using FinanceAccountProgram.Models.Config;
using FinanceAccountProgram.Models.VerifyModel;
using JINSHIN.Finance.AccountSystem.Resources;
using FinanceAccountProgram.VModel;
using FinanceAccountProgram.VModel.Accounts;
using FinanceAccountProgram.VModel.Business;
using FinanceAccountProgram.VModel.Conrols;
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
using JINSHIN.FinanceAccounting.DB;
using FinanceAccountProgram.VModel.Conrols.ManageForm;
using JINSHIN.BUSINESS.LIBARY.Resources;
using JINSHIN.BUSINESS.LIBARY.UIControls.GridView;
using JINSHIN.FinanceAccount.Libary.Config;
using JINSHIN.FinanceAccount.Libary.VModels.Finanacial;
using JINSHIN.FinanceAccount.Libary.Models;
using JINSHIN.FinanceAccount.Libary.VModels;
using JINSHIN.FinanceAccounting.DB.VModel;
using JINSHIN.FinanceAccount.Libary.VModels.Flow;
using FinanceAccountProgram.Models.AccountingData;
using JINSHIN.FinanceAccount.Libary.Models.Financial;
using JINSHIN.FinanceAccount.Libary.VModels.AccControl;
using JINSHIN.BUSINESS.LIBARY.Base;

namespace FinanceAccountProgram.FrmControl
{
    public partial class FrmSysLedgerMgt : Form
    {
        public AccountRemainData acountremain { get; set; }
        List<YearBeginViewModel> ybviewmodel = new List<YearBeginViewModel>();
        public string path { get; set; }
        public PathModel pathmodel { get; set; }
        public List<VerifyCostFinancialModel> ReportArrangeCostItem { get; set; }
        public FrmSysLedgerMgt()
        {
            InitializeComponent();
            dataFinancialLedger.Font = new System.Drawing.Font(DataControl.DataGridFont, Convert.ToInt32(DataControl.DataGridFontSize));
            using (FormControlVModel ctlmodel = new FormControlVModel())
            {
                ctlmodel.ControlResolution(this);
            }
            pathmodel = new PathModel();
            path = Environment.CurrentDirectory;
            DirectoryInfo di = new DirectoryInfo(path);
#if(DEBUG)
            path = di.Parent.Parent.FullName;
#else
            path = di.Parent.FullName;
#endif
            acountremain = new AccountRemainData();
            ReportArrangeCostItem = new List<VerifyCostFinancialModel>();
        }

        private void btnSettle_Click(object sender, EventArgs e)
        {
            try
            {
                int nw_year = Convert.ToInt32(txtYear.Text);
                CreateCostLedger(nw_year);
                using (VerifyVModel model = new VerifyVModel())
                {
                    model.VerifyData(false, DataClass.usrno);
                }
            }
            catch (Exception)
            {
              //  string str = ex.ToString();
            }
        }

        private void CreateCostLedger(int computeyear)
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                AccountEntities entity = content.GetEntity();              
                LstFinanacialMsg.Items.Clear();
                bool checkresult = false;
                bool verifyresult = false;
                try
                {
                    using (FinancialRptVModel financial = new FinancialRptVModel())
                    {
                        var items = entity.JINSHINFINANCE035.Where(o => 
                        o.Cost_Date.Value.Year == computeyear).ToList();
                        List<JINSHINFINANCE035> data01 = financial.CheckOK(items);
                        checkresult = financial.RefreshGrid(data01, dataFinancialLedger);
                        //是否需要驗證
                        verifyresult = accounting.TrailVerify == "1" ? true : false;
                        if (checkresult && !chDataFull.Checked && (!verifyresult))
                        {
                            LstFinanacialMsg.Items.Add("核對尚未完成");
                            return;
                        }
                        data01 = financial.CheckVerialLendAndGet(data01);
                        checkresult = financial.RefreshGrid(data01, dataFinancialLedger);
                        if (checkresult)
                        {
                            var vals = data01.GroupBy(v => v.Acc_No).ToList();
                            LstFinanacialMsg.Items.Add("借貸不平衡,不平衡的帳目!");
                            foreach (var item in vals)
                            {
                                var a01 = item.Where(v=>v.DataType==1).Sum(v => v.Amount);
                                var a02 = item.Where(v=>v.DataType==2).Sum(v => v.Amount);
                                if (a01 != a02)
                                {
                                    foreach (var v in item)
                                    {
                                        LstFinanacialMsg.Items.Add(v.Acc_No+","+v.Acc_ID.ToString() + "," + v.Amount);
                                    }
                                }
                            }
                            return;
                        }

                        List<VerifyCostDataModel> values = financial.GetYearsIncomeFinancialVal(data01);
                        foreach (var item in values.GroupBy(o => o.costitem.Acc_ID))
                        {
                            if (item.GroupBy(o => o.Add).Count() > 2)
                            {
                               //LstFinanacialMsg.Items.Add(item.First().costitem.Acc_ID + ":" + item.First().costitem.DataType + "," + item.First().costitem.Amount + ",IsAdd:有兩種");
                            }
                            else
                            {
                                if (item.First().Add.datatypectl == -1)
                                {
                                    //LstFinanacialMsg.Items.Add("*******" + item.First().costitem.Acc_ID + ":" + item.First().costitem.DataType + "," + item.First().costitem.Amount + ",IsAdd:" + item.First().Add.datatypectl);
                                }
                                else
                                {
                                    //LstFinanacialMsg.Items.Add(item.First().costitem.Acc_ID + ":" + item.First().costitem.DataType + "," + item.First().costitem.Amount + ",IsAdd:" + item.First().Add.datatypectl);
                                }
                            }
                        }

                        //目前顯示資料尚在統計中..
                        using (JINSHINFINANCE036VModel legervmodel = new JINSHINFINANCE036VModel())
                        {
                            ybviewmodel.Clear();
                            ybviewmodel = acountremain.SetDBMoneyData(computeyear);
                            List<string> msg = legervmodel.SaveDBData(entity, entity.JINSHINFINANCE036
                                .Where(o => o.Acc_Date.Value.Year == computeyear).ToList()
                                , ybviewmodel, true, computeyear);

                            //List<string> msg01 = new List<string>();
                            //foreach (var item in msg)
                            //{
                            //  //  LstFinanacialMsg.Items.Add(item);
                            //}
                        }
                        List<string> rs = acountremain.ShowFinancialLedgerGridView(dataFinancialLedger,computeyear,chDataAgain.Checked);
                        foreach (var item in rs)
                        {
                            LstFinanacialMsg.Items.Add(item);
                        }
                    }
                }
                catch (Exception ex)
                {
                    string str = ex.ToString();
                }
                finally
                {
                    entity.Dispose();
                }
            }
        }


        

        private void btnSetttleQuery_Click(object sender, EventArgs e)
        {
            try
            {
                int year = Convert.ToInt32(txtYear.Text);
                acountremain.ShowFinancialLedgerGridView(dataFinancialLedger, year, chDataAgain.Checked);
            }
            catch (Exception)
            { }
        }

        private void btnReportExportData_Click(object sender, EventArgs e)
        {
            using (GridViewBase grid = new GridViewBase())
            {
                grid.ExportDataGridView(pathmodel.exportPath, "ReportTotalCostAccounts", dataFinancialLedger);
            }
        }

        private void btnCheckAccNo_Click(object sender, EventArgs e)
        {
            AccountEntities entity = new AccountEntities();
            using (FinancialRptVModel financialmodel = new FinancialRptVModel())
            {
                var contents = AccCostItemConfig.GetVerifyClassData(entity.JINSHINFINANCE035.Where(o => o.Cost_Date.Value.Year == AccountingReso.yearnow).ToList());
                ReportArrangeCostItem = financialmodel.CheckAccNoSn(contents);
                foreach (var item in ReportArrangeCostItem)
                {
                    foreach (var v in item.values)
                    {
                        LstFinanacialMsg.Items.Add(v.Acc_No);
                    }
                }
            }
            entity.Dispose();
        }

        private void btnArrangeNew_Click(object sender, EventArgs e)
        {
            List<int> vals = new List<int>();
            try
            {
                using (AccountEntityDB content = new AccountEntityDB())
                {
                    using (AccountEntities entity = content.GetEntity())
                    {
                        List<JINSHINFINANCE035> list = entity.JINSHINFINANCE035.Where(o => o.Cost_Date.Value.Year == AccountingReso.yearnow).ToList();
                        foreach (var item in ReportArrangeCostItem)
                        {
                            foreach (var v in item.values)
                            {
                                vals.Add(int.Parse(v.Acc_No.Substring(10, v.Acc_No.Length - 10)));
                                if (vals.Count == 2)
                                {
                                    if ((vals[1] - vals[0]) != 1)
                                    {
                                        List<JINSHINFINANCE035> items = list.Where(o => o.Acc_No == v.Acc_No).ToList();
                                        foreach (var i in items)
                                        {
                                            i.Acc_No = i.Acc_No.Substring(10, i.Acc_No.Length - 10) + vals[0].ToString().PadRight(3, '0');
                                        }
                                    }
                                    vals.Clear();
                                }
                            }
                        }
                        entity.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                string str = ex.ToString();
            }
        }

        private void btnCheckAccounts_Click(object sender, EventArgs e)
        {
            AccountEntities entity = new AccountEntities();
            using (FinancialRptVModel financialmodel = new FinancialRptVModel())
            {
                var contents = AccCostItemConfig.GetVerifyClassData(entity.JINSHINFINANCE035.Where(o => o.Cost_Date.Value.Year == AccountingReso.yearnow).ToList());
                ReportArrangeCostItem = financialmodel.CheckAccNoSn(contents);
                foreach (var item in ReportArrangeCostItem)
                {
                    foreach (var v in item.values)
                    {
                        LstFinanacialMsg.Items.Add(v.Acc_No);
                    }
                }
            }
            entity.Dispose();
        }

        private void FrmSysLedgerMgt_Shown(object sender, EventArgs e)
        {
            txtYear.Focus();
            txtYear.Text = AccountingReso.yearnow.ToString();
            SysRescControlVModel.SetFixedWindow(this);
            // txtSYear.Text = DateTime.Now.Year.ToString();
        }

        private void btnOpenAccount_Click(object sender, EventArgs e)
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    try
                    {
                        int nwyear = Convert.ToInt32(txtYear.Text);
                        var jin48 = entity.JINSHINFINANCE048.Where(
                                       v => v.Acc_Date.Value.Year == (nwyear +1)).ToList();
                        foreach (var item in jin48)
                        {
                            item.IsClose = true;
                        }
                        entity.SaveChanges();
                    }
                    catch (Exception)
                    {
                    }
                }
            }
        }
    }
}
