using FinanceAccountProgram.Models.Config;
using FinanceAccountProgram.VModel.SN;
using JINSHIN.BUSINESS.LIBARY.UIControls.FormUI;
using JINSHIN.Finance.AccountSystem.Controls.Dlg;
using JINSHIN.FinanceAccount.Libary.Models.Forms;
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
    public partial class FrmPayTicketUpdate : Form
    {
        public PaymentPaperVModel pvmodel { get; set; }
        public string papernum { get; set; }
        private string usrno { get; set; }
        private string idname { get; set; }
        public string bankbase { get; set; }
        public string bankid { get; set; }
        public string bankno { get; set; }
        public FrmPayTicketUpdate()
        {
            InitializeComponent();
            bankbase = "808";
            pvmodel = new PaymentPaperVModel();
        }

        private void gb02_Enter(object sender, EventArgs e)
        {

        }

        private void txtBankIdPay_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBankIdIn_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTicket_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Loadjin63()
        {
            JINSHINFINANCE063 model = default(JINSHINFINANCE063);
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    model = entity.JINSHINFINANCE063.Where(i => i.PaperNum == papernum).FirstOrDefault();
                    lblPaperNumVal.Text = papernum;

                    dtStart.Value = model.PayDate.Value;
                    txtRecPeople.Text = model.RecPerson;
                    txtRecCompany.Text = model.RecCompany;

                    lstStyle.SelectedIndex = model.PayWay.Value;
                    txtTicket.Text = model.TicketNum;
                    dtGetDate.Value = model.GetDate.Value;

                    txtBankIdIn.Text = model.BankId;
                    txtBankIdPay.Text = model.BankIdPay;

                    txtAccountPay.Text = model.AccAccountPay;
                    txtAccountIn.Text = model.AccAccountIn;


                    txtAmount.Text = model.Amount.Value.ToString("##0.###");
                    txtDiscount.Text = model.Discount.Value.ToString("##0.###");
                    txtPayableMoney.Text = model.AccountPayable.Value.ToString("##0.###");
                        

                    txtUserName.Text = model.PayPerson;


                    lblNwDate.Text = model.CreateDate.Value.ToString("yyyy/MM/dd");
                    txtReason.Text=model.Desc;
                }
            }
        }


        private void Updatejin63()
        {
            JINSHINFINANCE063 model = default(JINSHINFINANCE063);
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    model = entity.JINSHINFINANCE063.Where(i => i.PaperNum == papernum).FirstOrDefault();

                    model.PayDate = dtStart.Value;
                    model.RecPerson = txtRecPeople.Text;
                    model.RecCompany = txtRecCompany.Text;


                    model.TicketNum = txtTicket.Text;
                    model.GetDate = dtGetDate.Value;
                    model.AccAccountIn = txtAccountIn.Text;
                    model.AccAccountPay = txtAccountPay.Text;
                    model.BankId = txtBankIdIn.Text;
                    model.BankIdPay = txtBankIdPay.Text;

                    model.Amount = Convert.ToDouble(txtAmount.Text);
                    model.Discount = Convert.ToDouble(txtDiscount.Text);
                    model.AccountPayable = Convert.ToDouble(txtPayableMoney.Text);

                    model.PayPerson = txtUserName.Text;
                    model.PayWay = Convert.ToInt32(lstStyle.SelectedIndex);
                
                    model.Desc = txtReason.Text;                                        
                    entity.SaveChanges();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Updatejin63();
        }

        private void FrmPayTicketUpdate_Shown(object sender, EventArgs e)
        {
            Loadjin63();
            SysRescControlVModel.SetFixedWindow(this);
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
    }
}
