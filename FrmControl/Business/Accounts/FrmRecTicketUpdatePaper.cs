using FinanceAccountProgram.Models.Config;
using FinanceAccountProgram.VModel.SN;
using JINSHIN.BUSINESS.LIBARY.UIControls.FormUI;
using JINSHIN.FinanceAccount.Libary.Models.Forms;
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
using JINSHIN.Finance.AccountSystem.Controls.Dlg;
using JINSHIN.FinanceAccount.Libary.VModels.AccControl;

namespace JINSHIN.Finance.AccountSystem.FrmControl.Business.Accounts
{
    public partial class FrmRecTicketUpdatePaper : Form
    {
        public PaymentPaperVModel pvmodel { get; set; }
        public string papernum { get; set; }
        private string usrno { get; set; }
        private string idname { get; set; }
        public string bankid { get; set; }
        public string bankno { get; set; }
        public FrmRecTicketUpdatePaper()
        {
            InitializeComponent();
            pvmodel = new PaymentPaperVModel();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckEmptyText())
                    return;
                if (!CheckNumberControl())
                    return;
                Updatejin62();
            }
            catch (Exception)
            {

            }
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
                else if (!pvmodel.CheckContrls(control, txtAmount, "金額"))
                {
                    return false;
                }
                else if (!pvmodel.CheckContrls(control, txtTicket, "支票號碼"))
                {
                    return false;
                }
            }
            return true;
        }


        public bool CheckEmptyText()
        {
            if (!pvmodel.CheckEmpty(txtPayPeople, "付款人"))
            {
                return false;
            }
            else if (!pvmodel.CheckEmpty(txtPayCompany, "付款公司"))
            {
                return false;
            }
            else if (lstStyle.SelectedIndex == -1)
            {
                MessageBox.Show("請選擇電匯!");
                return false;
            }
            else if (!pvmodel.CheckEmpty(txtBankIdPay, "銀行代碼"))
            {
                return false;
            }
            else if (!pvmodel.CheckEmpty(txtAccountPay, "轉出帳號"))
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
            else if (!pvmodel.CheckEmpty(txtUserName, "使用者"))
            {
                return false;
            }
            else if (!pvmodel.CheckEmpty(txtTicket, "支票"))
            {
                return false;
            }         
            return true;

        }



        private void Loadjin62()
        {
            JINSHINFINANCE062 model = default(JINSHINFINANCE062);
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    model = entity.JINSHINFINANCE062.Where(i => i.PaperNum == papernum).FirstOrDefault();
                    lblPaperNumVal.Text = papernum;
                    txtPayPeople.Text = model.PayPerson;
                    txtPayCompany.Text = model.PayCompany;
                    lstStyle.SelectedIndex = model.PayWay.Value;
                    txtTicket.Text = model.TicketNum;
                    dtGetDate.Value = model.RecDate.Value;
                    txtBankIdIn.Text = model.BankId;
                    txtAccountIn.Text =  model.AccAccountIn;
                    txtBankIdPay.Text = model.BankIdPay;
                    txtAccountPay.Text = model.AccAccountPay;
                    txtAmount.Text = model.Amount.Value.ToString("##0.###");
                    txtUserName.Text = model.RecPerson;
                    lblNwDate.Text = model.CreateDate.Value.ToString("yyyy/MM/dd");
                    txtReason.Text=model.Desc;                    
                    dtStart.Value = model.RecDate.Value;
                }
            }
        }



        private void Updatejin62()
        {
            JINSHINFINANCE062 model = default(JINSHINFINANCE062);
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    model = entity.JINSHINFINANCE062.Where(i => i.PaperNum == papernum).FirstOrDefault();
                    model.RecDate = dtStart.Value;
                    model.PayPerson = txtPayPeople.Text;
                    model.PayCompany = txtPayCompany.Text;
                    model.TicketNum = txtTicket.Text;
                    model.GetDate = dtGetDate.Value;
                    model.AccAccountIn = txtAccountIn.Text;
                    model.AccAccountPay = txtAccountPay.Text;
                    model.BankId = txtBankIdIn.Text;
                    model.BankIdPay = txtBankIdPay.Text;
                    model.PayWay = Convert.ToInt32(lstStyle.SelectedIndex);
                    model.Amount = Convert.ToDouble(txtAmount.Text);
                    model.RecPerson = txtUserName.Text;                   
                    model.Desc = txtReason.Text;                                     
                    entity.SaveChanges();
                }
            }
        }

        private void txtAccountPay_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmRecTicketUpdatePaper_Shown(object sender, EventArgs e)
        {
            Loadjin62();
            SysRescControlVModel.SetFixedWindow(this);
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
    }
}
