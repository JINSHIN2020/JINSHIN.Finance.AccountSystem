using FinanceAccountProgram.FrmControl.Business.Dialog;
using FinanceAccountProgram.Models.Business;
using FinanceAccountProgram.Models.UControl;
using FinanceAccountProgram.VModel.Business;
using FinanceAccountProgram.VModel.Conrols.GridView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JINSHIN.FinanceAccounting.DB;
using FinanceAccountProgram.VModel.Conrols.ManageForm;
using JINSHIN.BUSINESS.LIBARY.Models.UControl.GView;
using JINSHIN.BUSINESS.LIBARY.Resources;
using JINSHIN.BUSINESS.LIBARY.Models.UIControls;
using JINSHIN.Finance.AccountSystem;
using JINSHIN.FinanceAccount.Libary.VModels;
using JINSHIN.FinanceAccounting.DB.VModel;
using JINSHIN.BUSINESS.LIBARY.UIControls.FormUI;
using JINSHIN.FinanceAccount.Libary.VModels.AccControl;

namespace FinanceAccountProgram.FrmControl.Business
{
    public partial class FrmRestaurantFood : Form
    {
        public VRestaurantFood vmodel { get; set; }
        public RestaurantModel restmodel { get; set; }

        private List<TextBox> values { get; set; }
        public int masterkeydata = 1;

        public FrmRestaurantFood()
        {
            InitializeComponent();
            values = new List<TextBox>();
            vmodel = new VRestaurantFood();
            restmodel = new RestaurantModel();
            using (FormControlVModel ctlmodel = new FormControlVModel())
            {
                ctlmodel.ControlResolution(this);
            }
            dgClassData.Font = new System.Drawing.Font(DataControl.DataGridFont, Convert.ToInt32(DataControl.DataGridFontSize));
        }

        private void FrmRestaurantFood_Load(object sender, EventArgs e)
        {

        }

        public void ClearALL()
        {
            for (int i = 0; i < values.Count; i++)
            {
                values[i].Text = "";
            }        
        }

        public void SetTextValue(DataGridViewRow dr)
        {
            values.Clear();
            values.Add(txtClass);
            values.Add(txtName);
            values.Add(txtNum);
            values.Add(txtPrice);
            values.Add(txtDiscount);
            for (int j = 0; j < values.Count; j++)
            {
                for (int i = 0; i < restmodel.columns.Count; i++)
                {
                    if (restmodel.columns[i].ToUpper().ToString().IndexOf(values[j].Name.ToUpper().Substring(3, values[j].Name.Length - 3)) != -1)
                    {
                       if (dr.Cells[i].Value != null)
                         values[j].Text = dr.Cells[i].Value.ToString();
                       break;
                    }
                }
            }
            
        }

        public void ClearData()
        {
            values.Clear();
            values.Add(txtClass);
            values.Add(txtName);
            values.Add(txtNum);
            values.Add(txtPrice);
            values.Add(txtDiscount);
            for (int i = 0; i < values.Count; i++)
            {
                values[i].Text = "";
            }
        }
        public bool SetMvaluesIns()
        {
            List<string> columns = new List<string>() { "ProClass", "PName","Num", "PPrice", "Discount" };
            List<string> datatypes = new List<string>() {"string","string","int","decimal","decimal" };
            values.Clear();
            values.Add(txtClass);
            values.Add(txtName);
            values.Add(txtNum);
            values.Add(txtPrice);
            bool checkempty = false;
            for (int i = 0; i < values.Count; i++)
            {
                if (string.IsNullOrEmpty(values[i].Text))
                {
                    checkempty = true;
                    break;
                }
            }
            //if (lblSnData.Text.Trim() == "")
            //{
            //    MessageBox.Show(FormCaption.AccProductMsg001);
            //    return true;
            //}
            if (checkempty)
            {
                MessageBox.Show(FormCaption.AccProductMsg001);
                return true;
            }
            values.Add(txtDiscount);
            
            vmodel.mvalues.Clear();
            for (int i = 0; i < columns.Count; i++)
            {
                NameValues val01 = new NameValues();
                val01.name = columns[i];
                val01.datatype = datatypes[i];
                val01.dbvalue = values[i].Text == "" ? null : values[i].Text.Trim();
                vmodel.mvalues.Add(val01);
            }
            return false;
        }

        public void UpdateAccProductSetup()
        {          
            FunctionControl func = new FunctionControl();
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    int sn = Convert.ToInt32(lblSnData.Text);
                    var data = entity.JINSHINFINANCE045.Where(o => o.Sn == sn && o.IsDelete == false || o.IsDelete == null).FirstOrDefault();
                    func.SetClassObj<JINSHINFINANCE045>(data, vmodel.mvalues);
                    if (data != null)
                    {
                        data.UDate = DateTime.Now;
                        entity.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show(FormCaption.BookDescCaption02);
                    }
                }
            }
            func.Dispose();
            QueryMCondition();
        }


        private bool CheckData()
        {
            using (FormUICTL ctl = new FormUICTL())
            {
                if (ctl.GetNumText(txtNum.Text) || ctl.GetNumText(txtPrice.Text) || ctl.GetNumText(txtDiscount.Text))
                {
                    MessageBox.Show(FormCaption.BookDescCaption01);
                    return false;
                }
            }
            return true;
        }
        private void btnClassAdd_Click(object sender, EventArgs e)
        {
            if (SetMvaluesIns())
                return;
            JINSHINFINANCE045 val = new JINSHINFINANCE045();
            FunctionControl func = new FunctionControl();
            func.SetClassObj<JINSHINFINANCE045> (val, vmodel.mvalues);
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    try
                    {
                        var data = entity.JINSHINFINANCE045.Where(o => o.PName == val.PName && o.ProClass == val.ProClass).FirstOrDefault();
                        if (data != null)
                        {
                            MessageBox.Show(FormCaption.BookDescCaption01);
                        }
                        else                     
                        {
                            val.CDate = DateTime.Now;
                            entity.JINSHINFINANCE045.Add(val);
                            entity.SaveChanges();
                        }
                    }
                    catch (Exception ex)
                    {
                        string str = ex.ToString();
                    }
                }
            }
            ClearData();
            func.Dispose();
            QueryMCondition();
        }

        private void QueryMCondition()
        {
            var data = vmodel.GetALL<JINSHINFINANCE045>().Where(o=>o.IsDelete ==false || o.IsDelete == null).Take(Convert.ToInt32(txtDataCnt.Text)).ToList();
            lblDataAllCnt.Text = data.Count.ToString();
            dgClassData.DataSource = data;
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    List<DataModel> models = new List<DataModel>();
                    int sn = 1;
                    foreach (var item in data)
                    {
                        DataModel dmodel = new DataModel();
                        vmodel.control.EntityDataClass<JINSHINFINANCE045, DataModel>(item, dmodel, restmodel.data01, restmodel.data02);
                        dmodel.I02 = sn;
                        models.Add(dmodel);
                        sn++;
                    }
                    RefreshAcc_Master(models);
                }
            }
        }

        private void RefreshAcc_Master(List<DataModel> datalist)
        {
            vmodel.gridviewctl.SetGridColumns<Acc_Product_DGItems>(dgClassData, new Acc_Product_DGItems());
            dgClassData.DataSource = datalist;
        }
        private void btnQuery_Click(object sender, EventArgs e)
        {
            QueryMCondition();
        }

        private void btnClassUpdate_Click(object sender, EventArgs e)
        {
            if (!SetMvaluesIns())
            {
                UpdateAccProductSetup();
                ClearData();
            }
        }

        private void txtClass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtName.Focus();
            }
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNum.Focus();
            }
            
        }

        private void txtNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPrice.Focus();
            }
        }

        private void txtDiscount_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtPrice_ImeModeChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDiscount.Focus();
            }
        }

        private void dgClassData_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            if ((dgClassData.SelectedRows.Count > 0))
            {
                var rws = dgClassData.SelectedRows[0];
                SingleRowCardDataModify01(rws);
            }
        }

        private void SingleRowCardDataModify01(DataGridViewRow rws01)
        {
            try
            {
                if (rws01.Cells[masterkeydata].Value != null)
                {
                    lblSnData.Text = rws01.Cells[masterkeydata].Value.ToString();
                    object valdesc = rws01.Cells[2].Value ?? "";
                    txtClass.Text = valdesc.ToString();
                    SetTextValue(rws01);
                }
            }
            catch (Exception)
            {


            }

        }

        private void dgClassData_SelectionChanged(object sender, EventArgs e)
        {
            if ((dgClassData.SelectedRows.Count > 0))
            {
                var rws = dgClassData.SelectedRows[0];
                SingleRowCardDataModify01(rws);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    int sn = Convert.ToInt32(lblSnData.Text);
                    var data = entity.JINSHINFINANCE045.Where(o => o.Sn == sn && o.IsDelete == false || o.IsDelete == null).FirstOrDefault();
                    if (data != null)
                    {
                        data.IsDelete = true;
                        entity.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show(FormCaption.BookConvertCpation01);
                    }
                }
            }
            SetMvaluesIns();
            QueryMCondition();
        }

        private void FrmRestaurantFood_Shown(object sender, EventArgs e)
        {
            SysRescControlVModel.SetFixedWindow(this);
        }
    }
}
