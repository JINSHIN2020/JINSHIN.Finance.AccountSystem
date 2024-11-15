using FinanceAccountProgram.Models.Config;
using FinanceAccountProgram.Models.UpdateForm;
using JINSHIN.Finance.AccountSystem.Resources;
using JINSHIN.FinanceAccounting.DB;
using FinanceAccountProgram.ViewFrm;

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
using JINSHIN.FinanceAccounting.DB.VModel;
using JINSHIN.FinanceAccount.Libary.VModels.AccControl;

namespace FinanceAccountProgram.FrmControl
{
    public partial class FrmAccountingEntryManager : Form
    {
        public PathModel pathmodel { get; set; }
        public FrmAccountingEntryManager()
        {
            InitializeComponent();
            pathmodel = new PathModel();
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {

        }

        private void btnFinance_Click(object sender, EventArgs e)
        {
            AccidFormShow(UpdateFormEnum01.Finance);
        }

        private void btnSalary_Click_1(object sender, EventArgs e)
        {
            AccidFormShow(UpdateFormEnum01.SalaryData);
        }
        private void AccidFormShow(UpdateFormEnum01 formtype = UpdateFormEnum01.None, int updatefrmtype = -1)
        {
            SalaryFrm idatafrm = new SalaryFrm();
            idatafrm.SetInit(pathmodel.exportPath);
            if (formtype != UpdateFormEnum01.None)
                idatafrm.updateFrm1.SetInit(formtype);
            else
                idatafrm.updateFrm1.SetInit(UpdateFormEnum01.None, updatefrmtype);
            idatafrm.Show();
        }

        private void btnOffice365_Click(object sender, EventArgs e)
        {
            AccidFormShow(UpdateFormEnum01.Office365);
        }

        private void btnPhone_Click(object sender, EventArgs e)
        {
            AccidFormShow(UpdateFormEnum01.CompanyPhones);
        }

        private void btnInterest_Click(object sender, EventArgs e)
        {
            AccidFormShow(UpdateFormEnum01.None, UpdateFormClass.Interest);
        }

        private void btndividend_Click(object sender, EventArgs e)
        {
            AccidFormShow(UpdateFormEnum01.None, UpdateFormClass.dividend);
        }

        private void btnpayable_Click(object sender, EventArgs e)
        {
            AccidFormShow(UpdateFormEnum01.None, UpdateFormClass.payable);
        }

        private void btnpayableSalary_Click(object sender, EventArgs e)
        {
            AccidFormShow(UpdateFormEnum01.None, UpdateFormClass.payableSalary);
        }

        private void btnAssets_Click(object sender, EventArgs e)
        {
            AccidFormShow(UpdateFormEnum01.None, UpdateFormClass.Assets);
        }

        private void btn_Depreciation_Cost_Click(object sender, EventArgs e)
        {
            AccidFormShow(UpdateFormEnum01.None, UpdateFormClass.Depreciation_Cost);
        }

        private void btn_pre_payrate_Click(object sender, EventArgs e)
        {
            AccidFormShow(UpdateFormEnum01.None, UpdateFormClass.pre_payrate);
        }

        private void btnOthersCost_Click(object sender, EventArgs e)
        {
            AccidFormShow(UpdateFormEnum01.None, UpdateFormClass.others_cost);
        }

        private void btn_Cost_Income_Click(object sender, EventArgs e)
        {
            AccidFormShow(UpdateFormEnum01.None, UpdateFormClass.Cost_Income);
        }

        private void btn_gift_Click(object sender, EventArgs e)
        {
            AccidFormShow(UpdateFormEnum01.None, UpdateFormClass.gift);
        }

        private void btn_prepay_product_Click(object sender, EventArgs e)
        {
            AccidFormShow(UpdateFormEnum01.None, UpdateFormClass.prepay_product);
        }

        private void btn_payfirstLaborInsurance_Click(object sender, EventArgs e)
        {
            AccidFormShow(UpdateFormEnum01.None, UpdateFormClass.payfirstLaborInsurance);
        }

        private void btn_travel_income_Click(object sender, EventArgs e)
        {
            AccidFormShow(UpdateFormEnum01.None, UpdateFormClass.travel_income);
        }

        private void btn_rate_Click(object sender, EventArgs e)
        {
            AccidFormShow(UpdateFormEnum01.None, UpdateFormClass.rate);
        }

        private void btnWorkCost_Click(object sender, EventArgs e)
        {
            AccidFormShow(UpdateFormEnum01.None, UpdateFormClass.Cost_WorkOffice);
        }

        private void btnViewRefresh_Click(object sender, EventArgs e)
        {
            RefreshAccidVerifyList();
        }



        private void RefreshAccidVerifyList()
        {
            lstVerifing.Items.Clear();
            lstVerifyData.Items.Clear();
            lstNoVerifyData.Items.Clear();
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    List<JINSHINFINANCE041> names = entity.JINSHINFINANCE041.ToList();
                    var contents = AccCostItemConfig.GetClassData(entity.JINSHINFINANCE035.Where(o => o.Cost_Date.Value.Year == AccountingReso.yearnow).ToList());
                    var data = contents.GroupJoin(names,
                        (cost) => new { acc_id = cost.Acc_ID }, (accname) => new { acc_id = accname.Acc_ID },
                        (cost, accname) => new
                        {
                            acc_id = cost.Acc_ID,
                            check = cost.Cost_Check,
                            accname = accname.FirstOrDefault()
                        }).ToList();

                    var vals = data.GroupBy(o => o.acc_id).ToList();
                    string nameval = "";
                    int ttlcnt = 0, passcnt = 0;
                    foreach (var item in vals)
                    {
                        if (item.FirstOrDefault().accname != null)
                            nameval = item.First().accname.AccName;
                        else
                            nameval = "";
                        ttlcnt = item.Count();
                        passcnt = item.Where(o => o.check == true).Count();
                        if (item.Where(o => o.check == false || o.check == null).Count() > 0)
                        {
                            lstNoVerifyData.Items.Add(item.First().acc_id + ":" + nameval);
                            if (passcnt != 0)
                                lstVerifing.Items.Add(item.First().acc_id + ":" + nameval + " 已核對" + passcnt.ToString() + "(" + ttlcnt.ToString() + ")");
                        }
                        else
                        {
                            lstVerifyData.Items.Add(item.First().acc_id + ":" + nameval);
                        }
                    }
                }
            }
        }

        private void FrmAccountingEntryManager_Load(object sender, EventArgs e)
        {
            RefreshAccidVerifyList();
        }

        private void FrmAccountingEntryManager_SizeChanged(object sender, EventArgs e)
        {

        }

        private void FrmAccountingEntryManager_Shown(object sender, EventArgs e)
        {
            SysRescControlVModel.SetFixedWindow(this);
        }
    }
}
