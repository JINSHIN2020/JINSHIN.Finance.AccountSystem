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
    public partial class FrmCompany : Form
    {
        private BaseGridViewCtl gridviewctl { get; set; }
        public string usrno { get; set; }
        public string idname { get; set; }
        public PaymentPaperVModel pvmodel { get; set; }
        public int supplyno { get; set; }
        public FrmCompany()
        {
            InitializeComponent();
            gridviewctl = new BaseGridViewCtl();
            pvmodel = new PaymentPaperVModel();
        }

        private void gb01_Enter(object sender, EventArgs e)
        {

        }

        private void FrmCompany_Load(object sender, EventArgs e)
        {
            lblNwDate.Text = DateTime.Now.ToString("yyyy/MM/dd");
        }

        private void label7_Click(object sender, EventArgs e)
        {

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
                else if (!pvmodel.CheckEmpty(txtPhone, "公司電話"))
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


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBankIdIn_TextChanged(object sender, EventArgs e)
        {

        }


        public void Savejin12()
        {


            JINSHINFINANCE012 model = default(JINSHINFINANCE012);
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    try
                    {
                        model = new JINSHINFINANCE012();
                        model.No = pvmodel.GetMaxNo();
                        model.SupAddress = txtAddress.Text;
                        model.SupKey = txtPreword.Text;
                        model.Supply = txtCompany.Text;
                        model.SupExt = txtArea.Text;
                        model.SupPhone = txtPhone.Text;
                        model.SupEmail = txtEmail.Text;
                    //    model.No = DataClass.SupplyNo.Value;

                        model.Email = txtContrEmail.Text;
                        model.IdName = txtUserName.Text;
                        model.IdNo = txtIdNo.Text;
                        model.UsrPhone =  txtContractPhone.Text;

                        model.BankIdPay = txtBankIdPay.Text;
                        model.BankIdRec = txtBankIdIn.Text;
                        model.AccAccountPay = txtAccountPay.Text;
                        model.AccAccountRec = txtAccountIn.Text;

                        entity.JINSHINFINANCE012.Add(model);
                        entity.SaveChanges();
                    }
                    catch (Exception ex)
                    { 
                    
                    }
                }
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdNo.Text.Length > 8)
                {
                    MessageBox.Show("統一編號數字不能大於8碼!");
                    return;
                }
                if (txtPreword.Text.Length > 5)
                {
                    MessageBox.Show("長度不能大於5!");
                    return;
                }
                if (!CheckEmptyText())
                    return;
                if (!CheckNumber_EmailControl())
                    return;
                Savejin12();
            }
            catch (Exception)
            {

                throw;
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

        private void FrmCompany_Shown(object sender, EventArgs e)
        {
            SysRescControlVModel.SetFixedWindow(this);
        }
    }
}
