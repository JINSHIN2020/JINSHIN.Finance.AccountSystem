using FinanceAccountProgram.VModel.SN;
using JINSHIN.BUSINESS.LIBARY.Base;
using JINSHIN.BUSINESS.LIBARY.UIControls.FormUI;
using JINSHIN.BUSINESS.LIBARY.UIControls.GridView;
using JINSHIN.BUSINESS.LIBARY.VModel.PayForms;
using JINSHIN.Finance.AccountSystem.Controls.Dlg;
using JINSHIN.FinanceAccount.Libary.Models.Forms;
using JINSHIN.FinanceAccount.Libary.Models.Payment;
using JINSHIN.FinanceAccount.Libary.VModels.AccControl;
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
    public partial class FrmPayPaper : Form
    {
       // private BaseGridViewCtl gridviewctl { get; set; }
        public string usrno { get; set; }
        public string idname { get; set; }
        public string bankid { get; set; }
        public string bankno { get; set; }
        public FrmPayPaper()
        {
            InitializeComponent();
        //    gridviewctl = new BaseGridViewCtl();
     
        }

        private void FrmPayPaper_Load(object sender, EventArgs e)
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime nw = new DateTime(DateTime.Now.Year,DateTime.Now.Month, DateTime.Now.Day);
                if (dtStart.Value < nw)
                {
                    MessageBox.Show("付款日期不能小於現在!");
                    return;
                }
                if (!CheckEmptyText())
                    return;
                if (!CheckNumberControl())
                    return;
                JINSHINFINANCE060 model = new JINSHINFINANCE060();
                model.AccAccountIn = txtAccountIn.Text;
                model.AccAccountPay = txtAccountPay.Text;
                model.CreateDate = DateTime.Now;
                model.Discount = Convert.ToDouble(txtDiscount.Text);
                model.BankId = txtBankIdIn.Text;
                model.SupplyNo = DataClass.SupplyNo;
                model.PayPerson = txtUserName.Text;
                model.PayWay = Convert.ToInt32(lstStyle.SelectedIndex);
                model.RecPerson = txtRecPeople.Text;
                model.RecCompany = txtRecCompany.Text;
                model.Desc = txtReason.Text;
                model.AccountPayable = Convert.ToDouble(txtPayableMoney.Text);
                model.Amount = Convert.ToDouble(txtAmount.Text);
                model.PayDate = dtStart.Value;
                model.CreatePerson = DataClass.empName;
                using (TableFrmNo tableno = new TableFrmNo())
                {
                  model.PaperNum =  tableno.GetTableNo(new Interface.Data.Services.File.CTATableDataNo() { Num=3, TableInt=2 ,SupplyNo=DataClass.SupplyNo});
                }
                using (AccountEntityDB content = new AccountEntityDB())
                {
                    using (AccountEntities entity = content.GetEntity())
                    {
                        entity.JINSHINFINANCE060.Add(model);
                        entity.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            { 
            
            }
        }

        public bool CheckEmptyText()
        {
            if (!CheckEmpty(txtRecPeople, "收款人"))
            {
                return false;
            }else if (!CheckEmpty(txtRecCompany, "收款公司"))
            {
                return false;
            }else if (lstStyle.SelectedIndex == -1)
            {
                MessageBox.Show("請選擇電匯!");
                return false;
            }else if (!CheckEmpty(txtBankIdPay, "銀行代碼"))
            {
                return false;
            }
            else if (!CheckEmpty(txtAccountPay, "轉出帳號"))
            {
                return false;
            }         
            else if (!CheckEmpty(txtBankIdIn, "銀行代碼"))
            {
                return false;
            }
            else if (!CheckEmpty(txtAccountIn, "轉入帳號"))
            {
                return false;
            }
            else if (!CheckEmpty(txtAmount, "金額"))
            {
                return false;
            }
            else if (!CheckEmpty(txtDiscount, "折扣"))
            {
                return false;
            }           
            else if (!CheckEmpty(txtPayableMoney, "應付金額"))
            {
                return false;
            }
            else if (!CheckEmpty(txtUserName, "使用者"))
            {
                return false;
            }
            return true;

        }

        public bool CheckNumberControl()
        {
            using (FormUICTL control = new FormUICTL())
            {
                if (!CheckContrls(control, txtBankIdPay,"銀行代碼"))
                {
                    return false;
                }
                else if (!CheckContrls(control, txtAccountPay, "轉出帳號"))
                {
                    return false;
                }
                else if (!CheckContrls(control, txtBankIdIn, "銀行代碼"))
                {
                    return false;
                }
                else if (!CheckContrls(control, txtAccountIn, "轉入帳號"))
                {
                    return false;
                }
                else if (!CheckContrls(control, txtDiscount, "折扣"))
                {
                    return false;
                }
                else if (!CheckContrls(control, txtAmount, "金額"))
                {
                    return false;
                }
                else if (!CheckContrls(control, txtPayableMoney, "應付金額"))
                {
                    return false;
                }
            }
            return true;
        }



        private bool CheckTimeCondtion(FormUICTL ctl,TextBox txt,string msg)
        {
            return CheckContrls(ctl,txt,msg);
        }

        private bool CheckEmpty(TextBox txt,string msg)
        {
            if (string.IsNullOrEmpty(txt.Text))
            {
                MessageBox.Show(msg +"不能為空白!");
                return false;
            }
            return true;
        }

        private  bool CheckContrls(FormUICTL ctl,TextBox txt,string msg)
        {            
            if (txt.Text.IndexOf(".") == -1)
            {
                if (!ctl.GetAllNumText(txt.Text))
                {
                    MessageBox.Show(msg +"必須是數字!");
                    return false;
                }
            }
            else
            {
                if (!ctl.GetNumText(txt.Text))
                {
                    MessageBox.Show(msg +"必須是數字!");
                    return false;
                }
            }
            return true;
        }

        private void txtBankIdPay_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstStyle_SelectedIndexChanged(object sender, EventArgs e)
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

        private void FrmPayPaper_Shown(object sender, EventArgs e)
        {
            SysRescControlVModel.SetFixedWindow(this);
        }
    }
}
