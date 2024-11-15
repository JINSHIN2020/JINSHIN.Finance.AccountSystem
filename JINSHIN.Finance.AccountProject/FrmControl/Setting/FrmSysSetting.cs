using FinanceAccountProgram.Models;
using FinanceAccountProgram.Models.Config;
using JINSHIN.Finance.AccountSystem.Resources;
using JINSHIN.FinanceAccounting.DB;
using FinanceAccountProgram.VModel;
using FinanceAccountProgram.VModel.Business;
using FinanceAccountProgram.VModel.Conrols;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinanceAccountProgram.VModel.Conrols.ManageForm;
using JINSHIN.BUSINESS.LIBARY.Resources;
using JINSHIN.BUSINESS.LIBARY.UIControls.GridView;
using JINSHIN.FinanceAccount.Libary.Models.Base;
using JINSHIN.FinanceAccount.Libary.Config;
using JINSHIN.FinanceAccount.Libary.VModels;
using JINSHIN.FinanceAccounting.DB.VModel;
using JINSHIN.FinanceAccount.Libary.VModels.Config;
using JINSHIN.FinanceAccount.Libary.VModels.AccControl;

namespace FinanceAccountProgram.FrmControl
{
    public partial class FrmSysSetting : Form
    {
        public DBClassCtl dbclassctl { get; set; }
        public ClassTypeConfig<object> tab06 { get; set; }
        public ClassTypeConfig<JINSHINFINANCE034> tab07 { get; set; }
        public FrmSysSetting()
        {
            InitializeComponent();
            datagrid.Font = new System.Drawing.Font(DataControl.DataGridFont, Convert.ToInt32(DataControl.DataGridFontSize));
            dgClassData.Font = new System.Drawing.Font(DataControl.DataGridFont, Convert.ToInt32(DataControl.DataGridFontSize));
            using (FormControlVModel ctlmodel = new FormControlVModel())
            {
                ctlmodel.ControlResolutionPageUserData(this, "masterCtl01", "lstClassName",new List<string>());
            }
            dbclassctl = new DBClassCtl();
            tab06 = new ClassTypeConfig<object>();
            tab06.types = DBClassType.Acc_Class;
            tab07 = new ClassTypeConfig<JINSHINFINANCE034>();
            tab07.types = DBClassType.Acc_DetailClass;
        }

        private void btnSetup_Click(object sender, EventArgs e)
        {
            using (SysSettingCtl setting = new SysSettingCtl())
            {
                if (!setting.GetNumberText(txtNum.Text))
                  MessageBox.Show("編碼位數一定要輸入數字!");
            }

            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    var setup = entity.JINSHINFINANCE017.ToList();
                    List<string> names = new List<string>() { "AccNoNum", "AccNo" };
                    List<string> vals = new List<string>() { Diary.Default.AccNoNum, Diary.Default.AccNo, 
                        Diary.Default.AccNoDate };
                    List<TextBox> txts = new List<TextBox>() { txtNum, txtNoText };
                    int idx = 0;
                    foreach (var item in names)
                    {
                        var data = setup.Where(o => o.SysName == item).FirstOrDefault();
                        if (data != null)
                        {
                            SetValue(vals, txts, idx, data);
                        }
                        else
                        {
                            JINSHINFINANCE017 syssetup = new JINSHINFINANCE017();
                            syssetup.SysName = item;
                            syssetup.CreateTime = DateTime.Now;
                            SetValue(vals, txts, idx, syssetup);
                            entity.JINSHINFINANCE017.Add(syssetup);
                        }
                        idx++;
                    }
                    var value = setup.Where(o => o.SysName == "AccNoDate").FirstOrDefault();
                    if (value != null)
                    {
                        SetValue(vals, lstYMD, idx, value);
                    }
                    else
                    {
                        JINSHINFINANCE017 syssetup = new JINSHINFINANCE017();
                        syssetup.SysName = "AccNoDate";
                        syssetup.CreateTime = DateTime.Now;
                        SetValue(vals, lstYMD, idx, syssetup);
                        entity.JINSHINFINANCE017.Add(syssetup);
                    }
                    entity.SaveChanges();
                    btnQuery_Click(new object(), null);
                    using (SysSettingCtl ctl = new SysSettingCtl())
                    {
                        AccountingReso.yearnow = Convert.ToInt32(ctl.LoadData("AccYear"));
                    }

                }
            }
        }

        private void SetValue(List<string> vals, List<TextBox> txts, int idx, JINSHINFINANCE017 data)
        {
            if (string.IsNullOrEmpty(txts[idx].Text))
            {
                data.SysVal = vals[idx];
            }
            else
            {
                data.SysVal = txts[idx].Text;
            }
        }

        private void SetValue(List<string> vals, ListBox lst, int idx, JINSHINFINANCE017 data)
        {
            if (string.IsNullOrEmpty(lst.Text))
            {
                data.SysVal = vals[idx];
            }
            else
            {
                data.SysVal = lst.Text;
            }
        }

        private void txtNoText_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lstYMD.Focus();
            }
        }

        private void txtYMD_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNum.Focus();
            }
        }

        private void txtNum_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSetup_Click(null, null);
            }
        }

        private void masterUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void btnClassAdd_Click(object sender, EventArgs e)
        {
            if (coClassType.SelectedIndex == 0)
            {
                txClassNO.Text = dbclassctl.GetClassNameMaxInt(DBClassType.Acc_Class).ToString();
                tab06.types = DBClassType.Acc_Class;
            }
            else if (coClassType.SelectedIndex == 1)
            {
                txClassNO.Text = dbclassctl.GetClassNameMaxInt(DBClassType.Inv_Class).ToString();
                tab06.types = DBClassType.Inv_Class;
            }          
            txClassNO.Focus();
            Query_Class();
        }
        private void Query_Class()
        {
            if (tab06.types == DBClassType.Acc_Class)
            {
                List<JINSHINFINANCE034> rs = dbclassctl.QueryAcc_Class();
                dgClassData.DataSource = rs;
            }
            //憑證
            else if (tab06.types == DBClassType.Inv_Class)
            {
                List<JINSHINFINANCE057> rs = dbclassctl.QueryInv_Class();
                dgClassData.DataSource = rs;
            }

            if (dgClassData.Rows.Count > 0)
            {
                using (GridViewFinanceBase gvbase = new GridViewFinanceBase(AddQueryEnum.None))
                {
                    gvbase.columns = new List<string>() { "序號", "名稱", "建立日期" };
                    gvbase.SetDataColumns(dgClassData,new List<int>() {100,200,200 });
                }
            }
            dgClassData.Refresh();
        }
        private void btnClassUpdate_Click(object sender, EventArgs e)
        {
            Query_Class();
        }

      
        private void btnYearSetup_Click(object sender, EventArgs e)
        {
            using (SysSettingCtl setting = new SysSettingCtl())
            {
                if (!setting.GetNumberText(txtSYear.Text))
                    MessageBox.Show(MsgText.SysSettingNumMsg);
                string resource_name = "AccYear";
                using (AccountEntityDB content = new AccountEntityDB())
                {
                    using (AccountEntities account = content.GetEntity())
                    {
                        var data = account.JINSHINFINANCE017.Where(o => o.SysName == resource_name).FirstOrDefault();
                        if (data != null)
                        {
                            data.SysVal = txtSYear.Text;
                        }
                        else
                        {
                            JINSHINFINANCE017 sys = new JINSHINFINANCE017();
                            sys.SysName = resource_name;
                            sys.SysVal = txtSYear.Text;
                            sys.CreateTime = DateTime.Now;
                            account.JINSHINFINANCE017.Add(sys);
                        }
                        account.SaveChanges();
                        using (SysSettingCtl ctl = new SysSettingCtl())
                        {
                            AccountingReso.yearnow = Convert.ToInt32(ctl.LoadData("AccYear"));
                        }
                    }
                }
            }
            btnQuery_Click(new object(), null);
        }

      
        private void tabSysParameterSetup_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((sender as TabControl).SelectedTab.Name)
            {
                case "tabInvClassMgt": {
                        coClassType.SelectedIndex = 1;
                        var vals = dbclassctl.QueryAcc_Class().OrderBy(o => o.No).ToList();
                        Query_Class();
                    } break;
                case "tabAccountClassMgt":
                    {
                        tab07.types = DBClassType.Acc_DetailClass;
                        using (AccountEntityDB content = new AccountEntityDB())
                            using (AccountEntities entity = content.GetEntity())
                                tab07.mclass = entity.JINSHINFINANCE034.ToList();
                        masterCtl01.dbclassctl = dbclassctl;
                        masterCtl01.tab06 = tab07;
                        masterCtl01.lstClassNamedata.DataSource = tab07.mclass;
                        masterCtl01.lstClassNamedata.DisplayMember = "name";
                        masterCtl01.lstClassNamedata.ValueMember = "No";
                        masterCtl01.SetInit();
                    }
                    break;
                default:
                    break;
            }
        }

        private void coClassType_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cobo = sender as ComboBox;
            switch (cobo.SelectedIndex)
            {
                case 0:
                    tab06.types = DBClassType.Acc_Class;
                    break;
                case 1:
                    tab06.types = DBClassType.Inv_Class;
                    break;
                default:
                    break;
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    var datalist = entity.JINSHINFINANCE017.OrderBy(o => o.No).ToList();
                    datagrid.DataSource = datalist;                    
                    if (datagrid.Rows.Count > 0)
                    {
                        for (int i = 0; i < datalist.Count; i++)
                        {
                            datalist[i].No = i + 1;
                        }
                        using (GridViewFinanceBase gvbase = new GridViewFinanceBase(AddQueryEnum.None))
                        {
                            gvbase.columns = new List<string>() { "序號", "名稱", "值", "建立日期" };
                            List<string> fields = new List<string>() {"No","SysName","SysVal","CreateTime" };
                            gvbase.SetDataColumns(datagrid, new List<int>() { 80, 200, 200, 220 },fields);
                            fields.Clear();
                        }
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否確認要刪除!", "對話框", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int idx = dgClassData.CurrentRow.Index;
                int datano = int.Parse(dgClassData.Rows[idx].Cells[0].Value.ToString());
                using (AccountEntityDB content = new AccountEntityDB())
                {
                    using (AccountEntities entities = content.GetEntity())
                    {
                        switch (tab06.types)
                        {
                            case DBClassType.AccountBook:
                                break;
                            case DBClassType.InvoiceBook:
                                break;
                            case DBClassType.Acc_Class:
                                {
                                    var accclass01 = entities.JINSHINFINANCE034.Where(o => o.No == datano).FirstOrDefault();
                                    entities.JINSHINFINANCE034.Remove(accclass01);
                                }
                                break;
                            case DBClassType.Inv_Class:
                                {
                                    var accclass02 = entities.JINSHINFINANCE057.Where(o => o.No == datano).FirstOrDefault();
                                    entities.JINSHINFINANCE057.Remove(accclass02);
                                }
                                break;
                            case DBClassType.Acc_DetailClass:
                                break;
                            default:
                                break;
                        }
                        entities.SaveChanges();
                        Query_Class();
                    }
                }
            }
        }

        private void txClassName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dbclassctl.InsertClassData(txClassName.Text,Convert.ToInt32(txClassNO.Text),tab06.types);
                Query_Class();
            }
        }

        private void btnAddInv_Click(object sender, EventArgs e)
        {
            dbclassctl.InsertClassData(txClassName.Text, Convert.ToInt32(txClassNO.Text), tab06.types);
            Query_Class();
        }

        private void FrmSysSetting_Shown(object sender, EventArgs e)
        {
            SysRescControlVModel.SetFixedWindow(this);
        }
    }
}
