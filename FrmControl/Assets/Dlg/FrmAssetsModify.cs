using JINSHIN.BUSINESS.LIBARY.Models.UIControls;
using JINSHIN.BUSINESS.LIBARY.UIControls.FormUI;
using JINSHIN.FinanceAccount.Libary.VModels.AccControl;
using JINSHIN.FinanceAccount.Libary.VModels.Assets;
using JINSHIN.FinanceAccounting.DB;
using JINSHIN.FinanceAccounting.DB.VModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JINSHIN.Finance.AccountSystem.FrmControl.Assets.Dlg
{
    public partial class FrmAssetsModify : Form
    {
        public FrmAssetsMgt mgt { get; set; }
        public AssetsFormVModel pvmodel { get; set; }
        public JINSHINFINANCE051 smodel { get; set; }
        public int classno { get; set; }
        public int classitem { get; set; }
        public FrmAssetsModify()
        {
            InitializeComponent();
            pvmodel = new AssetsFormVModel();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckEmptyText())
                    return;
                if (!CheckNumberControl())
                    return;
                Updatejin51();
                mgt.AssetsItemsALL();
                MessageBox.Show("儲存完成!");
                Close();
            }
            catch (Exception)
            {

            }
        }

        private void Updatejin51()
        {
            JINSHINFINANCE051 model = default(JINSHINFINANCE051);
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    model = entity.JINSHINFINANCE051.Where(i => i.ClassNo == smodel.ClassNo && i.Item == smodel.Item).FirstOrDefault();
                    JINSHINFINANCE051 newmodel = new JINSHINFINANCE051();
                    using (FunctionControl func = new FunctionControl())
                    {
                        func.ClassCopyTo<JINSHINFINANCE051, JINSHINFINANCE051>(model, newmodel);
                    }
                    entity.JINSHINFINANCE051.Remove(model);
                    model = newmodel;
                    model.ClassNo = Convert.ToInt32(txtClass.Text);
                    model.Item =  Convert.ToInt32(txtClassNo.Text);
                    model.BuyDate = dtStartDate.Value;
                    model.AssetsName = txtAssetsName.Text;
                    model.Acc_ID = txtAccids.Text;
                    model.Cnt = Convert.ToInt32(txtNum.Text);
                    model.Unit = txtUnit.Text;
                    model.Price = Convert.ToDecimal(txtPrice.Text);
                    model.MachineYear = Convert.ToDecimal(txtCanUsed.Text);
                    model.Acc_Type =Convert.ToInt32(txtClassType.Text);
                    model.Remark = txtRemark.Text;
                    model.DepreciateFormula = Convert.ToDecimal(txtFormula.Text);
                    model.IsFinance = chCountry.Checked ? 1 : 0;
                    entity.JINSHINFINANCE051.Add(model);
                    entity.SaveChanges();
                }
            }
        }

        private void Loadjin51()
        {
           // JINSHINFINANCE051 smodel = default(JINSHINFINANCE051);
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    smodel = entity.JINSHINFINANCE051.Where(i => i.ClassNo == classno && i.Item ==classitem).FirstOrDefault();
                    dtStartDate.Value = smodel.BuyDate.Value;
                    txtClass.Text = smodel.ClassNo.ToString();
                    txtClassNo.Text =  smodel.Item.ToString();

                    txtAssetsName.Text = smodel.AssetsName;
                    txtAccids.Text = smodel.Acc_ID.ToString();
                    txtNum.Text = smodel.Cnt.ToString();
                    txtUnit.Text = smodel.Unit;
                    txtPrice.Text = smodel.Price.ToString();

                    txtCanUsed.Text = smodel.MachineYear.ToString();
                    txtClassType.Text = smodel.Acc_Type.ToString();
                    txtRemark.Text = smodel.Remark;
                    txtFormula.Text = smodel.DepreciateFormula.ToString();
                    chCountry.Checked = smodel.IsFinance == 0 ? false : true;
			
                }
            }
        }


        public bool CheckNumberControl()
        {
            using (FormUICTL control = new FormUICTL())
            {
                if (!pvmodel.CheckContrls(control, txtAccids, "會科"))
                {
                    return false;
                }
                else if (!pvmodel.CheckContrls(control, txtNum, "數量"))
                {
                    return false;
                }
                else if (!pvmodel.CheckContrls(control, txtPrice, "原價"))
                {
                    return false;
                }
                else if (!pvmodel.CheckContrls(control, txtCanUsed, "耐用年限"))
                {
                    return false;
                }
                else if (!pvmodel.CheckContrls(control, txtFormula, "提列殘值公式"))
                {
                    return false;
                }
            }
            return true;
        }


        public bool CheckEmptyText()
        {
            if (!pvmodel.CheckEmpty(txtClass, "分類"))
            {
                return false;
            }
            else if (!pvmodel.CheckEmpty(txtClassNo, "項目"))
            {
                return false;
            }
            else if (!pvmodel.CheckEmpty(txtAssetsName, "財產名稱"))
            {
                return false;
            }
            else if (!pvmodel.CheckEmpty(txtAccids, "會科"))
            {
                return false;
            }
            else if (!pvmodel.CheckEmpty(txtUnit, "單位"))
            {
                return false;
            }
            else if (!pvmodel.CheckEmpty(txtNum, "數量"))
            {
                return false;
            }
            else if (!pvmodel.CheckEmpty(txtPrice, "原價"))
            {
                return false;
            }
            else if (!pvmodel.CheckEmpty(txtCanUsed, "耐用年限"))
            {
                return false;
            }
            else if (!pvmodel.CheckEmpty(txtClassType, "類別"))
            {
                return false;
            }
            else if (!pvmodel.CheckEmpty(txtFormula, "提列殘值公式"))
            {
                return false;
            }
            return true;
        }

        private void FrmAssetsModify_Shown(object sender, EventArgs e)
        {
            Loadjin51();
            SysRescControlVModel.SetFixedWindow(this);
        }
    }
}
