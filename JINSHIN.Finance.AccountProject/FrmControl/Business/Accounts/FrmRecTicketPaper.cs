using FinanceAccountProgram.VModel.SN;
using JINSHIN.BUSINESS.LIBARY.Base;
using JINSHIN.BUSINESS.LIBARY.UIControls.FormUI;
using JINSHIN.BUSINESS.LIBARY.UIControls.GridView;
using JINSHIN.BUSINESS.LIBARY.VModel.PayForms;
using JINSHIN.FinanceAccount.Libary.Models.Forms;
using JINSHIN.FinanceAccount.Libary.Models.Payment;
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
    public partial class FrmRecTicketPaper : Form
    {
        private BaseGridViewCtl gridviewctl { get; set; }
        public string usrno { get; set; }
        public string idname { get; set; }
        public PaymentPaperVModel pvmodel { get; set; }
        public string bankid { get; set; }
        public string bankno { get; set; }
        public FrmRecTicketPaper()
        {
            InitializeComponent();
            gridviewctl = new BaseGridViewCtl();
            pvmodel = new PaymentPaperVModel();
        }

        private void FrmRecTicketPaper_Load(object sender, EventArgs e)
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
                else
                if (!pvmodel.CheckEmpty(txtBankIdPay, "銀行代碼"))
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
                else if (!pvmodel.CheckEmpty(txtTicketNum, "支票號碼"))
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
                else if (!pvmodel.CheckContrls(control, txtAmount, "金額"))
                {
                    return false;
                }
                else if (!pvmodel.CheckContrls(control, txtTicketNum, "支票號碼"))
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
                    MessageBox.Show("日期不能小於現在!");
                    return;
                }
                if (dtGetDate.Value < nw)
                {
                    MessageBox.Show("兌現日期不能小於現在!");
                    return;
                }

                if (!CheckEmptyText())
                    return;
                if (!CheckNumberControl())
                    return;

                JINSHINFINANCE062 model = new JINSHINFINANCE062();
             
                model.RecDate = dtStart.Value;
                model.PayPerson = txtPayPeople.Text;
                model.PayCompany = txtPayCompany.Text;
                model.PayWay = Convert.ToInt32(lstStyle.SelectedIndex);
                model.TicketNum = txtTicketNum.Text;
                model.GetDate = dtGetDate.Value;
                model.BankId = txtBankIdIn.Text;
                model.AccAccountIn = txtAccountIn.Text;
                model.BankIdPay = txtBankIdPay.Text;
                model.AccAccountPay = txtAccountPay.Text;
                model.SupplyNo = DataClass.SupplyNo;
                model.RecPerson = txtUserName.Text;                           
                model.Desc = txtReason.Text;
                model.Amount = Convert.ToDouble(txtAmount.Text);              
                model.CreateDate = DateTime.Now;
                model.CreatePerson = DataClass.empName;
                using (TableFrmNo tableno = new TableFrmNo())
                {
                    model.PaperNum =  tableno.GetTableNo(new Interface.Data.Services.File.CTATableDataNo() { Num=3, TableInt=5, SupplyNo=DataClass.SupplyNo });
                }
                using (AccountEntityDB content = new AccountEntityDB())
                {
                    using (AccountEntities entity = content.GetEntity())
                    {
                        entity.JINSHINFINANCE062.Add(model);
                        entity.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {

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

        private void FrmRecTicketPaper_Shown(object sender, EventArgs e)
        {
            SysRescControlVModel.SetFixedWindow(this);
        }
    }
}
