using FinanceAccountProgram.VModel.SN;
using JINSHIN.BUSINESS.LIBARY.Base;
using JINSHIN.BUSINESS.LIBARY.UIControls.FormUI;
using JINSHIN.BUSINESS.LIBARY.UIControls.GridView;
using JINSHIN.BUSINESS.LIBARY.VModel.PayForms;
using JINSHIN.Finance.AccountSystem.Controls.Dlg;
using JINSHIN.FinanceAccount.Libary.Models.Forms;
using JINSHIN.FinanceAccount.Libary.Models.Payment;
using JINSHIN.FinanceAccount.Libary.VModels.AccControl;
using JINSHIN.FinanceAccount.Libary.VModels.Payment;
using JINSHIN.FinanceAccounting.DB;
using JINSHIN.FinanceAccounting.DB.VModel;
using JINSHIN.Work.TimeSystem.FormControl.LeaveManagement.Dlg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JINSHIN.Finance.AccountSystem.FrmControl.Business.Accounts
{
    public partial class FrmPayTicketPaper : Form
    {
        public string usrno { get; set; }
        public string idname { get; set; }
        public string bankid { get; set; }
        public string bankno { get; set; }
        public PaymentPaperVModel pvmodel { get; set; }
        public FrmPayTicketPaper()
        {
            InitializeComponent();
            pvmodel = new PaymentPaperVModel();
        }

        private void FrmPayTicketPaper_Load(object sender, EventArgs e)
        {
            lblNwDate.Text = DateTime.Now.ToString("yyyy/MM/dd");
        }

        private void btnUserSelect_Click(object sender, EventArgs e)
        {
            using (UserDlg dlg = new UserDlg())
            {
                dlg.ShowDialog();
                usrno = FormData.str01;
                idname = FormData.str02;
                txtUserName.Text = FormData.str02;
            }
        }


        public bool CheckEmptyText()
        {
            using (FormUICTL control = new FormUICTL())
            {
                if (!pvmodel.CheckEmpty(txtRecPeople, "收款人"))
                {
                    return false;
                }
                else if (!pvmodel.CheckEmpty(txtRecCompany, "收款公司"))
                {
                    return false;
                }
                else if (lstStyle.SelectedIndex == -1)
                {
                    MessageBox.Show("請選擇電匯!");
                    return false;
                }else
                if (!pvmodel.CheckEmpty(txtBankIdPay, "銀行代碼"))
                {
                    return false;
                }
                else if (!pvmodel.CheckEmpty( txtAccountPay, "轉出帳號"))
                {
                    return false;
                }
                else if (!pvmodel.CheckEmpty(txtBankIdIn, "銀行代碼"))
                {
                    return false;
                }
                else if (!pvmodel.CheckEmpty(txtAccountIn, "轉入帳號"))
                {
                    return false;
                }
                else if (!pvmodel.CheckEmpty(txtAmount, "金額"))
                {
                    return false;
                }
                else if (!pvmodel.CheckEmpty(txtDiscount, "折扣"))
                {
                    return false;
                }
                else if (!pvmodel.CheckEmpty(txtPayableMoney, "應付金額"))
                {
                    return false;
                }
                else if (!pvmodel.CheckEmpty(txtUserName, "使用者"))
                {
                    return false;
                }
            }
            return true;
        }


        public bool CheckNumberControl()
        {
            using (FormUICTL control = new FormUICTL())
            {
                if (!pvmodel.CheckContrls(control, txtBankIdPay, "銀行代碼"))
                {
                    return false;
                }
                else if (!pvmodel.CheckContrls(control, txtAccountPay, "轉出帳號"))
                {
                    return false;
                }
                else if (!pvmodel.CheckContrls(control, txtBankIdIn, "銀行代碼"))
                {
                    return false;
                }
                else if (!pvmodel.CheckContrls(control, txtAccountIn, "轉入帳號"))
                {
                    return false;
                }
                else if (!pvmodel.CheckContrls(control, txtDiscount, "折扣"))
                {
                    return false;
                }
                else if (!pvmodel.CheckContrls(control, txtAmount, "金額"))
                {
                    return false;
                }
                else if (!pvmodel.CheckContrls(control, txtPayableMoney, "應付金額"))
                {
                    return false;
                }
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime nw = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                if (dtStart.Value < nw)
                {
                    MessageBox.Show("付款日期不能小於現在!");
                    return;
                }
                if (!CheckEmptyText())
                    return;
                if (!CheckNumberControl())
                    return;
                JINSHINFINANCE063 model = new JINSHINFINANCE063();
                model.AccAccountIn = txtAccountIn.Text;
                model.AccAccountPay = txtAccountPay.Text;
                model.PayDate = dtStart.Value;
                model.TicketNum = txtTicket.Text;                
                model.BankId = txtBankIdIn.Text;
                model.BankIdPay = txtBankIdPay.Text;
                model.GetDate = dtGetDate.Value;
                model.SupplyNo = DataClass.SupplyNo;
                model.PayPerson = txtUserName.Text;
                model.PayWay = Convert.ToInt32(lstStyle.SelectedIndex);
                model.RecPerson = txtRecPeople.Text;
                model.RecCompany = txtRecCompany.Text;
                model.Desc = txtReason.Text;
                model.AccountPayable = Convert.ToDouble(txtPayableMoney.Text);
                model.Discount = Convert.ToDouble(txtDiscount.Text);
                model.Amount = Convert.ToDouble(txtAmount.Text);
               
                model.CreateDate = DateTime.Now;
                model.CreatePerson = DataClass.empName;
                using (TableFrmNo tableno = new TableFrmNo())
                {
                    model.PaperNum =  tableno.GetTableNo(new Interface.Data.Services.File.CTATableDataNo() { Num=3, TableInt=4, SupplyNo=DataClass.SupplyNo });
                }
                using (AccountEntityDB content = new AccountEntityDB())
                {
                    using (AccountEntities entity = content.GetEntity())
                    {
                        entity.JINSHINFINANCE063.Add(model);
                        entity.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void txtTicket_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnC01_Click(object sender, EventArgs e)
        {
            using (CompanyDlg dlg = new CompanyDlg())
            {
                dlg.ShowDialog();
                bankid = FormData.str01;
                bankno = FormData.str02;
                txtBankIdPay.Text = FormData.str01;
                txtAccountPay.Text = FormData.str02;
            }
        }

        private void btnC02_Click(object sender, EventArgs e)
        {
            using (CompanyDlg dlg = new CompanyDlg())
            {
                dlg.formtype = 1;
                dlg.ShowDialog();
                bankid = FormData.str01;
                bankno = FormData.str02;
                txtBankIdIn.Text = FormData.str01;
                txtAccountIn.Text = FormData.str02;
            }
        }

        private void FrmPayTicketPaper_Shown(object sender, EventArgs e)
        {
            SysRescControlVModel.SetFixedWindow(this);
        }
    }
}
