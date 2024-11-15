using FinanceAccountProgram.VModel.SN;
using JINSHIN.BUSINESS.LIBARY.Base;
using JINSHIN.BUSINESS.LIBARY.UIControls.FormUI;
using JINSHIN.BUSINESS.LIBARY.UIControls.GridView;
using JINSHIN.BUSINESS.LIBARY.VModel.PayForms;
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

namespace JINSHIN.Finance.AccountSystem.FrmControl.Business.CompanyMgt
{
    public partial class FrmCompanyUpdate : Form
    {
        private BaseGridViewCtl gridviewctl { get; set; }
        public string usrno { get; set; }
        public string idname { get; set; }
        public PaymentPaperVModel pvmodel { get; set; }
        public int supplyno { get; set; }
        public FrmCompanyUpdate()
        {
            InitializeComponent();
            gridviewctl = new BaseGridViewCtl();
            pvmodel = new PaymentPaperVModel();
        }

        private void lblPapernumval_Click(object sender, EventArgs e)
        {

        }

        private void lblPapernum_Click(object sender, EventArgs e)
        {

        }

        private void FrmCompanyUpdate_Load(object sender, EventArgs e)
        {
            lblNwDate.Text = DateTime.Now.ToString("yyyy/MM/dd");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdNo.Text.Length > 8)
                {
                    MessageBox.Show("統一號數字不能大於8碼!");
                    return;
                }
                if (txtPreword.Text.Length > 5)
                {
                    MessageBox.Show("縮寫長度不能大於5碼!");
                    return;
                }
                if (!CheckEmptyText())
                    return;
                if (!CheckNumber_EmailControl())
                    return;
                Updatejin12();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool CheckEmptyText()
        {
            using (FormUICTL control = new FormUICTL())
            {
                if (!pvmodel.CheckEmpty(txtIdNo, "統一編號"))
                {
                    return false;
                }
                else if (!pvmodel.CheckEmpty(txtCompany, "公司名稱"))
                {
                    return false;
                }
                else if (!pvmodel.CheckEmpty(txtArea, "郵遞區號"))
                {
                    return false;
                }
                else if (!pvmodel.CheckEmpty(txtAddress, "公司地址"))
                    return false;
                else if (!pvmodel.CheckEmpty(txtContractPhone, "公司電話"))
                    return false;
                else if (!pvmodel.CheckEmpty(txtEmail, "Email"))
                    return false;
                else if (!pvmodel.CheckEmpty(txtBankIdPay, "銀行代碼"))
                    return false;
                else if (!pvmodel.CheckEmpty(txtAccountPay, "轉出帳號"))
                    return false;
                else if (!pvmodel.CheckEmpty(txtBankIdIn, "銀行代碼"))
                    return false;
                else if (!pvmodel.CheckEmpty(txtAccountIn, "轉入帳號"))
                    return false;
                else if (!pvmodel.CheckEmpty(txtUserName, "聯絡人"))
                    return false;
                else if (!pvmodel.CheckEmpty(txtContractPhone, "聯絡電話"))
                    return false;
                else if (!pvmodel.CheckEmpty(txtEmail, "Email"))
                    return false;
                return true;
            }
        }

        public bool CheckNumber_EmailControl()
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
                else if (!pvmodel.CheckContrls(control, txtIdNo, "統一編號"))
                {
                    return false;
                }
                else if (!pvmodel.CheckContrls(control, txtArea, "郵遞區號"))
                {
                    return false;
                }
                else if (!pvmodel.CheckEmail(control, txtEmail, "公司Email"))
                    return false;
                else if (!pvmodel.CheckEmail(control, txtContrEmail, "聯絡人Email"))
                    return false;
            }
            return true;

        }

        private void Updatejin12()
        {
            JINSHINFINANCE012 model = default(JINSHINFINANCE012);
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    model = entity.JINSHINFINANCE012.Where(i => i.No == supplyno).FirstOrDefault();
                    model.SupAddress = txtAddress.Text;
                    model.SupKey = txtPreword.Text;
                    model.Supply = txtCompany.Text;
                    model.SupExt = txtArea.Text;
                    model.SupPhone = txtPhone.Text;
                    model.SupEmail = txtEmail.Text;

                    model.Email = txtContrEmail.Text;
                    model.IdName = txtUserName.Text;
                    model.IdNo = txtIdNo.Text;
                    model.UsrPhone =  txtContractPhone.Text;

                    model.BankIdPay = txtBankIdPay.Text;
                    model.BankIdRec = txtBankIdIn.Text;
                    model.AccAccountPay = txtAccountPay.Text;
                    model.AccAccountRec = txtAccountIn.Text;

                    entity.SaveChanges();
                }
            }
        }

        private void Loadjin12()
        {
            JINSHINFINANCE012 model = default(JINSHINFINANCE012);
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    model = entity.JINSHINFINANCE012.Where(i => i.No == supplyno).FirstOrDefault();
                    txtAddress.Text = model.SupAddress;
                    txtCompany.Text = model.Supply;
                    txtArea.Text = model.SupExt;
                    txtAddress.Text = model.SupAddress;
                    txtPreword.Text = model.SupKey;
                    txtPhone.Text = model.SupPhone;
                    txtEmail.Text = model.SupEmail;
                    txtContrEmail.Text    = model.Email;
                    txtBankIdPay.Text = model.BankIdPay;
                    txtBankIdIn.Text = model.BankIdRec;
                    txtAccountPay.Text = model.AccAccountPay;
                    txtAccountIn.Text = model.AccAccountRec;
                    txtUserName.Text = model.IdName;
                    txtContractPhone.Text = model.SupPhone;                         
                    txtIdNo.Text = model.IdNo;
               }
            }            
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

        private void txtBankIdPay_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContractPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContrEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBankIdIn_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtArea_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCompany_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAccountPay_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmCompanyUpdate_Shown(object sender, EventArgs e)
        {
            lblPapernumval.Text = supplyno.ToString();
            Loadjin12();
            SysRescControlVModel.SetFixedWindow(this);
        }
    }
}
