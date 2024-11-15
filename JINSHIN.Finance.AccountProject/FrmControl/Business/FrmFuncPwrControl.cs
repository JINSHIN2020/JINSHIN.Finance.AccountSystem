using FinanceAccountProgram.Models.Config;
using JINSHIN.Business.DataBase;
using JINSHIN.BUSINESS.LIBARY.Base;
using JINSHIN.BUSINESS.LIBARY.Models.DGGridView;
using JINSHIN.BUSINESS.LIBARY.UIControls.GridView;
using JINSHIN.Finance.AccountSystem.VModel.Finicial;
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


namespace JINSHIN.Finance.AccountSystem.FrmControl.Business
{
    public partial class FrmFuncPwrControl : Form
    {
        public List<JINSHINFINANCE016> data16lst { get; set; }
        public List<JINSHINFINANCE020> data20lst { get; set; }
        public List<JINSHINFINANCE066> data66lst { get; set; }
        public List<JINSHINFINANCE011> data11lst { get; set; }
     //   public List<JINSHINFINANCE020> detail { get; set; }
        public BaseGridViewCtl gridviewctl { get; set; }
        public List<FunctionViewModel> functionviewmodels { get; set; }
        public string powerText { get; set; }
        public string functionText { get; set; }
        public string classText { get; set; }
        public int? power { get; set; }
        private List<FunctionViewModel> viewmodel { get; set; }
        public FrmFuncPwrControl()
        {
            InitializeComponent();
            gridviewctl = new BaseGridViewCtl();
            data16lst = new List<JINSHINFINANCE016>();
            data66lst = new List<JINSHINFINANCE066>();
            data11lst = new List<JINSHINFINANCE011>();
            functionviewmodels = new List<FunctionViewModel>();
            viewmodel = new List<FunctionViewModel>();
        }

        private void FrmFuncPwrControl_Shown(object sender, EventArgs e)
        {
            LoadData01();
            LoadData02();

            if (lstPower.SelectedItem != null)
            {
                power = (lstPower.SelectedItem as JINSHINFINANCE016).Power;
                if (power == null)
                    power =0;
            }
            else
                power =0;
        }


        private void LoadData01()
        {
            using (AccountEntityDB dbentity = new AccountEntityDB())
            {
                using (AccountEntities entity = dbentity.GetEntity())
                {
                    data20lst = entity.JINSHINFINANCE020.Where(v => v.Enable == true).OrderBy(v => v.ProPos).ToList();
                    gridviewctl.SetGridColumns<Function_DGItem>(dgdata01, new Function_DGItem());
                    dgdata01.DataSource = null;
                    dgdata01.DataSource = data20lst;
                    OrderBy(dgdata01);
                }
            }
        }
        private void OrderBy(DataGridView dgdata)
        {
            for (int i = 0; i < dgdata.Rows.Count; i++)
            {
                dgdata.Rows[i].Cells[0].Value = (i+1).ToString();
            }
        }
        public void Refres()
        {
            LoadData01();
            LoadData02();
        }

        private void LoadData02()
        {
            functionviewmodels.Clear();
            using (AccountEntityDB dbentity = new AccountEntityDB())
            {
                using (AccountEntities entity = dbentity.GetEntity())
                {
                    data16lst = entity.JINSHINFINANCE016.OrderBy(v => v.Power).ToList();
                    lstNames.DataSource = data16lst;
                    lstNames.DisplayMember = "PName";
                    lstNames.ValueMember = "Power";

                    lstPower.DataSource = data16lst;
                    lstPower.DisplayMember = "PName";
                    lstPower.ValueMember = "Power";

                    data66lst = entity.JINSHINFINANCE066.OrderBy(v => v.ID).ToList();
                    lstClassType.DataSource = data66lst;
                    lstClassType.DisplayMember = "ClassName";
                    lstClassType.ValueMember = "ID";

                    data11lst = entity.JINSHINFINANCE011.OrderBy(v => v.No).ToList();
                    List<FunctionViewModel> viewmodel = ConvertToVModel(entity, data11lst);
                    functionviewmodels.AddRange(viewmodel);
                    gridviewctl.SetGridColumns<PwrFunction_DGIItem>(dgdata02, new PwrFunction_DGIItem());
                    dgdata02.DataSource = null;
                    dgdata02.DataSource = functionviewmodels.Where(v=>v.Power == power).OrderBy(v => v.ClassNo).ThenBy(v => v.ProName).ToList();
                    OrderBy(dgdata02);
                }
            }
        }

        private List<FunctionViewModel> ConvertToVModel(AccountEntities entity, List<JINSHINFINANCE011> data)
        {
            List<FunctionViewModel> rs = new List<FunctionViewModel>();
            foreach (var item in data)
            {
                FunctionViewModel viewmodel = new FunctionViewModel();
                viewmodel.No = item.No;
                var pwrdata = entity.JINSHINFINANCE016.Where(v => v.Power == item.Power).FirstOrDefault();
                viewmodel.Power = item.Power;
                if (pwrdata != null)
                {
                    powerText = pwrdata.PName;
                }
                viewmodel.PowerText = powerText;
                var proName = entity.JINSHINFINANCE020.Where(v => v.No == item.ProName).FirstOrDefault();
                if (proName != null)
                {
                    functionText = proName.ProName;
                }
                viewmodel.ProName = proName.No;
                viewmodel.ProNameText = functionText;
                var jin32 = entity.JINSHINFINANCE066.Where(v => v.ID == item.ClassNo).FirstOrDefault();
                if (jin32 != null)
                {
                    classText = jin32.ClassName;
                }
                viewmodel.ClassNo = item.ClassNo;
                viewmodel.ClassNameText = classText;
                rs.Add(viewmodel);
            }
            return rs;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Refres();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPwr.Text))
            {
                MessageBox.Show("請新增要刪除的角色權限");
                return;
            }
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("請新增要刪除的角色名稱");
                return;
            }
            using (AccountEntityDB dbentity = new AccountEntityDB())
            {
                using (AccountEntities entity = dbentity.GetEntity())
                {
                    for (int i = 0; i < dgdata01.SelectedRows.Count; i++)
                    {
                        JINSHINFINANCE011 jin11 = new JINSHINFINANCE011();
                        long classno = (lstClassType.SelectedItem as JINSHINFINANCE066).ID;
                        int pwr = Convert.ToInt32(txtPwr.Text);
                        var pwrlst = entity.JINSHINFINANCE011.Where(v => v.Power == pwr).ToList();
                        if (pwrlst.Count > 0)
                        {
                            MessageBox.Show("權限編碼已存在!");
                            return;
                        }
                        jin11.ClassNo = Convert.ToInt32(classno);
                        jin11.SupplyNo = DataClass.SupplyNo.Value;
                        jin11.ProName = dgdata01.SelectedRows[i].Cells["No"].Value.ToString();
                        jin11.Power = pwr;
                        jin11.ProOpen = true;
                        entity.JINSHINFINANCE011.Add(jin11);
                    }
                    JINSHINFINANCE016 jin16 = new JINSHINFINANCE016();
                    jin16.PName = txtName.Text;
                    jin16.Power = Convert.ToInt32(txtPwr.Text);
                    jin16.CDate = DateTime.Now;
                    entity.JINSHINFINANCE016.Add(jin16);
                    entity.SaveChanges();
                    Refres();
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (lstPower.SelectedItems == null || !(lstPower.SelectedItem is JINSHINFINANCE016))
            {
                MessageBox.Show("請選擇要刪除的角色");
                return;
            }
            using (AccountEntityDB dbentity = new AccountEntityDB())
            {
                using (AccountEntities entity = dbentity.GetEntity())
                {
                    int pwr = (lstPower.SelectedItem as JINSHINFINANCE016).Power.Value;
                    var jin11lst = entity.JINSHINFINANCE011.Where(v => v.Power == pwr).ToList();
                    entity.JINSHINFINANCE011.RemoveRange(jin11lst);

                    var jin16 = entity.JINSHINFINANCE016.Where(v => v.Power == pwr).FirstOrDefault();
                    entity.JINSHINFINANCE016.Remove(jin16);
                    entity.SaveChanges();
                }
                Refres();
            }
        }
        private void SearchFunctions()
        {
            string val = txtFunctionName.Text;
            var data11 = data20lst.Where(v => v.ProName.IndexOf(val) != -1 || val == "").ToList();
            dgdata01.DataSource = data11;
            OrderBy(dgdata01);
        }

        private void SearchClass()
        {
            string val = txtClass.Text;
            var jin32 = data66lst.Where(v => v.ClassName.IndexOf(val) != -1 || val == "").ToList();
            lstClassType.DataSource = jin32;
            lstClassType.DisplayMember = "ClassName";
            lstClassType.ValueMember = "ID";
        }
        private void btnQuer02_Click(object sender, EventArgs e)
        {
            SearchClass();
        }

        private void btnQuer03_Click(object sender, EventArgs e)
        {
            SearchFunctions();
        }

        private void btnQuer01_Click(object sender, EventArgs e)
        {
            SearchPower();
        }
        private void SearchPower()
        {
            string val = txtPowerName.Text;
            var jin16 = data16lst.Where(v => v.PName.IndexOf(val) != -1 || val == "").ToList();
            lstPower.DataSource = jin16;
            lstPower.DisplayMember = "PName";
            lstPower.ValueMember = "Power";
        }
        private void btnDelItem_Click(object sender, EventArgs e)
        {
            if (dgdata02.SelectedRows.Count > 0)
            {
                try
                {
                    int no = Convert.ToInt32(dgdata02.SelectedRows[0].Cells["No"].Value);
                    using (AccountEntityDB dbentity = new AccountEntityDB())
                    {
                        using (AccountEntities entity = dbentity.GetEntity())
                        {
                            var jin11 = entity.JINSHINFINANCE011.Where(v => v.No==no).FirstOrDefault();
                            entity.JINSHINFINANCE011.Remove(jin11);
                            entity.SaveChanges();
                            var val = functionviewmodels.Where(v => v.No == no).FirstOrDefault();
                            if (val != null)
                                functionviewmodels.Remove(val);

                            LoadManagerList();

                        }
                    }
                }
                catch (Exception ex)
                {
                    string str = ex.ToString();
                }
            }
        }


        private FunctionViewModel ConvertToModel(AccountEntities entity, JINSHINFINANCE011 data)
        {
            FunctionViewModel viewmodel = new FunctionViewModel();
            var pwrdata = entity.JINSHINFINANCE016.Where(v => v.Power == data.Power).FirstOrDefault();
            if (pwrdata != null)
            {
                powerText = pwrdata.PName;
            }
            viewmodel.Power = data.Power;
            viewmodel.PowerText = powerText;
            var proName = entity.JINSHINFINANCE020.Where(v => v.No == data.ProName).FirstOrDefault();
            if (proName != null)
            {
                functionText = proName.ProName;
            }
            viewmodel.ProName = proName.No;
            viewmodel.ProNameText = functionText;
            var jin32 = entity.JINSHINFINANCE066.Where(v => v.ID == data.ClassNo).FirstOrDefault();
            if (jin32 != null)
            {
                classText = jin32.ClassName;
            }
            viewmodel.ClassNo = data.ClassNo;
            viewmodel.ClassNameText = classText;
            return viewmodel;
        }

        private void RefreshPower02()
        {
            int power = 0;
            if (lstPower.SelectedItem != null)
            {
                power = (lstPower.SelectedItem as JINSHINFINANCE016).Power.Value;
            }
            dgdata02.DataSource = null;
            dgdata02.DataSource = functionviewmodels.Where(v => v.Power == power).ToList();
            OrderBy(dgdata02);
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (lstClassType.SelectedItems == null || !(lstClassType.SelectedItem is JINSHINFINANCE066))
            {
                MessageBox.Show("請選擇要新增的類別");
                return;
            }
            if (dgdata01.SelectedRows.Count > 0)
            {
                try
                {
                    for (int i = 0; i < dgdata01.SelectedRows.Count; i++)
                    {
                        string proname = Convert.ToString(dgdata01.SelectedRows[i].Cells["No"].Value);
                        using (AccountEntityDB dbentity = new AccountEntityDB())
                        {
                            using (AccountEntities entity = dbentity.GetEntity())
                            {
                                int pwr = (lstNames.SelectedItem as JINSHINFINANCE016).Power.Value;
                                var jin11 = entity.JINSHINFINANCE011.Where(v => v.SupplyNo == DataClass.SupplyNo
                                                    && v.ProName==proname && v.Power == pwr).FirstOrDefault();
                                if (jin11 != null)
                                {
                                    MessageBox.Show(proname+"已存在!");
                                    return;
                                }
                                else
                                {
                                    JINSHINFINANCE011 data = new JINSHINFINANCE011();
                                    long classno = (lstClassType.SelectedItem as JINSHINFINANCE066).ID;
                                    data.ClassNo = Convert.ToInt32(classno);
                                    data.SupplyNo = DataClass.SupplyNo.Value;
                                    data.ProName = dgdata01.SelectedRows[i].Cells["No"].Value.ToString();
                                    data.Power = pwr;
                                    data.ProOpen = true;
                                    entity.JINSHINFINANCE011.Add(data);
                                    entity.SaveChanges();
                                    functionviewmodels.Add(ConvertToModel(entity, data));
                                    RefreshPower02();
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    string str = ex.ToString();
                }
            }
        }

        private void txtFunctionName_TextChanged(object sender, EventArgs e)
        {
            SearchClass();
        }

        private void txtPowerName_TextChanged(object sender, EventArgs e)
        {
            SearchPower();
        }

        private void lstPower_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPower.SelectedItem != null)
            {
                int power = (lstPower.SelectedItem as JINSHINFINANCE016).Power.Value;
                //int power = (lstPower.SelectedItem as JINSHINFINANCE016).Power.Value;
                txtPowerVal.Text = power.ToString();
            }
        }

        private void LoadManagerList()
        {
            using (AccountEntityDB dbentity = new AccountEntityDB())
            {
                using (AccountEntities entity = dbentity.GetEntity())
                {
                    int pwr = (lstNames.SelectedItem as JINSHINFINANCE016).Power.Value;
                    var lst = entity.JINSHINFINANCE011.Where(v => v.Power == pwr).OrderBy(v => v.No).ToList();
                    List<FunctionViewModel> viewmodel = ConvertToVModel(entity, lst);
                    dgdata02.DataSource = null;
                    dgdata02.DataSource = viewmodel.OrderBy(v => v.ClassNo).ThenBy(v => v.ProName).ToList();
                    OrderBy(dgdata02);
                }
            }
        }

        private void lstNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadManagerList();
        }

        private void dgdata01_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (e.ColumnIndex == 3)
            {
                if (e.Value != null)
                {
                    if (Convert.ToBoolean(e.Value))
                    {
                        e.Value = "開啟";
                    }
                    else
                    {
                        e.Value = "關閉";
                    }
                }
            }
        }

        private void lstClassType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstClassType.SelectedIndex != -1)
            {
                int classno = Convert.ToInt32((lstClassType.SelectedItem as JINSHINFINANCE066).ID);
                using (AccountEntityDB entities = new AccountEntityDB())
                {
                    using (AccountEntities dbentity = entities.GetEntity())
                    {
                        var lst = dbentity.JINSHINFINANCE020.Where(v => v.ClassNo== classno).ToList();
                        dgdata01.DataSource = null;
                        dgdata01.DataSource = lst; 
                        OrderBy(dgdata01);
                    }
                }
            }
        }
    }
}
