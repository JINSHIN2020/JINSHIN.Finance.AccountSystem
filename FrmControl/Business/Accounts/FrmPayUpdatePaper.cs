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
    public partial class Frm_UPayPaper : Form
    {
        public PaymentPaperVModel pvmodel { get; set; }
        public string papernum { get; set; }
        private string usrno { get; set; }
        private string idname { get; set; }
        public string bankbase { get; set; }
        public string bankid { get; set; }
        public string bankno { get; set; }
        public Frm_UPayPaper()
        {
            InitializeComponent();
            pvmodel = new PaymentPaperVModel();
            bankbase = "808";
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void FrmPayUpdatePaper_Load(object sender, EventArgs e)
        {

        }

        private void gb02_Enter(object sender, EventArgs e)
        {

        }

        private void lstStyle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txtBankIdPay_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblPapernumVal_Shown(object sender, EventArgs e)
        {
            Loadjin60();
            SysRescControlVModel.SetFixedWindow(this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {              
                if (!CheckEmptyText())
                    return;
                if (!CheckNumberControl())
                    return;
                Updatejin60();
            }
            catch (Exception)
            {

            }
        }

        private void Updatejin60()
        {
            JINSHINFINANCE060 model = default(JINSHINFINANCE060);
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    model = entity.JINSHINFINANCE060.Where(i => i.PaperNum == papernum).FirstOrDefault();
                    model.AccAccountIn = txtAccountIn.Text;  
                    model.AccAccountPay = txtAccountPay.Text;              
                    model.Discount = Convert.ToDouble(txtDiscount.Text);
                    model.BankId = txtBankIdIn.Text;
                    model.PayPerson = txtUserName.Text;
                    model.PayWay = Convert.ToInt32(lstStyle.SelectedIndex);
                    model.RecPerson = txtRecPeople.Text;
                    model.RecCompany = txtRecCompany.Text;
                    model.Desc = txtReason.Text;
                    model.AccountPayable = Convert.ToDouble(txtPayableMoney.Text);
                    model.Amount = Convert.ToDouble(txtAmount.Text);
                    model.PayDate = dtStart.Value;
                    entity.SaveChanges();
                }
            }
        }

        private void Loadjin60()
        { 
            JINSHINFINANCE060 model = default(JINSHINFINANCE060);
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    model = entity.JINSHINFINANCE060.Where(i => i.PaperNum == papernum).FirstOrDefault();
                    lblPaperNumVal.Text = papernum;
                    txtAccountIn.Text =  model.AccAccountIn;
                    txtAccountPay.Text = model.AccAccountPay;
                    txtDiscount.Text = model.Discount.Value.ToString("##0.###");
                    txtBankIdIn.Text = model.BankId;

                    txtBankIdPay.Text = bankbase;
                    txtUserName.Text = model.PayPerson;
                    lstStyle.SelectedIndex = model.PayWay.Value;
                    txtRecPeople.Text = model.RecPerson;

                    lblNwDate.Text = model.CreateDate.Value.ToString("yyyy/MM/dd");
                    txtRecCompany.Text = model.RecCompany;
                    txtReason.Text=model.Desc;
                    txtPayableMoney.Text =  model.AccountPayable.Value.ToString("##0.###");
                    txtAmount.Text = model.Amount.Value.ToString("##0.###");
                    dtStart.Value = model.PayDate.Value;
                }
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


        public bool CheckEmptyText()
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
            return true;

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
