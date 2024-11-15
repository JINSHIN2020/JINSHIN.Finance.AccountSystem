using FinanceAccountProgram.Models.AccountingData;
using FinanceAccountProgram.Models.VerifyModel;
using JINSHIN.Finance.AccountSystem.Resources;
using FinanceAccountProgram.VModel;
using FinanceAccountProgram.VModel.Accounts;
using FinanceAccountProgram.VModel.Business;
using FinanceAccountProgram.VModel.Conrols.GridView;
using JINSHIN.FinanceAccount.Libary.Config;
using JINSHIN.FinanceAccount.Libary.Models;
using JINSHIN.FinanceAccount.Libary.VModels.Finanacial;
using JINSHIN.FinanceAccounting.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using JINSHIN.FinanceAccounting.DB.VModel;
using JINSHIN.BUSINESS.LIBARY.UIControls.GridView;
using FinanceAccountProgram.Models.Config;
using JINSHIN.FinanceAccount.Libary.Models.Financial;
using System.Web.UI.WebControls;
using JINSHIN.FinanceAccount.Libary.VModels.AccControl;

namespace FinanceAccountProgram.FrmControl
{
    public partial class FrmAccountsInfo : Form
    {
        AccountRemainData acountremain {get;set;}
        public PathModel pathmodel { get; set; }
        public FrmAccountsInfo()
        {
            InitializeComponent();
            acountremain = new AccountRemainData();
            pathmodel = new PathModel();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="year"></param>
        private void ShowDataGrid()
        {
            try
            {
                int year = Convert.ToInt32(txtYear.Text);
                using (AccountEntityDB content = new AccountEntityDB())
                {
                    using (AccountEntities entity = content.GetEntity())
                    {
                        var jin48 = entity.JINSHINFINANCE048.Where(v => v.Acc_Year == year
                        && v.IsClose == true).ToList();
                        dataFinancialLedger.DataSource = jin48;
                        using (AccCostLedgerGridView gridview = new AccCostLedgerGridView())
                        {
                            gridview.SetAccConfirmGridColumns(dataFinancialLedger);
                        }
                        var data01 = jin48.Where(v => v.DataType == 1).ToList();
                        var data02 = jin48.Where(v => v.DataType == 2).ToList();
                        LstFinanacialMsg.Items.Add("借方:" + data01.Sum(i => i.Amount).Value.ToString("###,###,###,###"));
                        LstFinanacialMsg.Items.Add("貸方:" + data02.Sum(i => i.Amount).Value.ToString("###,###,###,###"));
                    }
                }
            }
            catch (Exception)
            { 
            
            }
        }

        /// <summary>
        /// 重新計算餘額
        /// </summary>
        /// <param name="computeyear"></param>
        private void ShowGrid(int computeyear)
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    LstFinanacialMsg.Items.Clear();
                    bool checkresult = false;
                    try
                    {
                        using (FinancialRptVModel financial = new FinancialRptVModel())
                        {
                            var items = entity.JINSHINFINANCE035.Where(o => o.Cost_Date.Value.Year <= computeyear
                            && ( o.Is_Reserved == false  || o.Is_Reserved == null) && o.Cost_Check == true).ToList();
                            List<JINSHINFINANCE035> data01 = financial.CheckVerialOK(items);
                            checkresult = financial.RefreshGrid(data01, dataFinancialLedger);

                            data01 = financial.CheckVerialLendAndGet(items);
                            checkresult = financial.RefreshGrid(data01, dataFinancialLedger);
                            List<VerifyCostDataModel> values = financial.GetYearsIncomeFinancialVal(items);
                            List<JINSHINFINANCE035> result = new List<JINSHINFINANCE035>();
                            foreach (var item in values.GroupBy(o => o.costitem.Acc_ID))
                            {
                                var dataget = item.Where(v => v.costitem.DataType == 1).Sum(v => v.costitem.Amount);
                                var datalend = item.Where(v => v.costitem.DataType == 2).Sum(v => v.costitem.Amount);
                                JINSHINFINANCE035 data = item.First().costitem;                                
                                data.Amount = dataget - datalend;
                                if (dataget > datalend)
                                {
                                    data.DataType = 1;
                                }else
                                    data.DataType = 2;
                                if (dataget == datalend)
                                {
                                    using (FinancialAccidsModel model = new FinancialAccidsModel())
                                    {
                                        data.DataType = model.GetDataType(item.FirstOrDefault().costitem.Acc_ID);
                                    }
                                }
                                result.Add(data);
                                //if (item.GroupBy(o => o.Add).Count() > 2)
                                //{
                                //    LstFinanacialMsg.Items.Add(item.First().costitem.Acc_ID + ":" + 
                                //        item.First().costitem.DataType + "," + item.First().costitem.Amount + ",IsAdd:有兩種");
                                //}
                                //else
                                //{
                                //    if (item.First().Add.datatypectl == -1)
                                //        LstFinanacialMsg.Items.Add("*******" + item.First().costitem.Acc_ID + ":" 
                                //            + item.First().costitem.DataType + "," + item.First().costitem.Amount 
                                //            + ",IsAdd:" + item.First().Add.datatypectl);
                                //    else
                                //        LstFinanacialMsg.Items.Add(item.First().costitem.Acc_ID + ":" 
                                //            + item.First().costitem.DataType + "," + item.First().costitem.Amount
                                //            + ",IsAdd:" + item.First().Add.datatypectl);
                                //}
                            }
                            LstFinanacialMsg.Items.Add("本期結算金額:" + financial.GetYearIncomeResult(values));
                            using (JINSHINFINANCE036VModel legervmodel = new JINSHINFINANCE036VModel())
                            {
                                acountremain.SetMoneyData();
                                List<string> msg = new List<string>();// legervmodel.SaveData(entity, entity.JINSHINFINANCE036.Where(o => o.Acc_Date.Value.Year == AccountingReso.yearnow).ToList(), ybviewmodel, true);
                                foreach (var item in msg)
                                {
                                    LstFinanacialMsg.Items.Add(item);
                                }
                            }
                            acountremain.ShowFinancialLedgerGridView(dataFinancialLedger,computeyear,result);
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
        }

        private void btnView_Click(object sender, EventArgs e)
        {
        
            ShowDataGrid();
        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            using (GridViewBase grid = new GridViewBase())
            {
                grid.ExportDataGridView(pathmodel.exportPath, "Acc_Confirm", dataFinancialLedger);
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            using (AccountRemainData pre_remain = new AccountRemainData())
            {
                try
                {
                    int datayear = Convert.ToInt32(txtYear.Text);
                    pre_remain.ImportMoneyData(datayear, chDelete.Checked);
                    ShowDataGrid();
                }
                catch (Exception)
                { 
                
                }
            }
        }

        private void FrmAccountsInfo_Shown(object sender, EventArgs e)
        {
            SysRescControlVModel.SetFixedWindow(this);
        }
    }
}
