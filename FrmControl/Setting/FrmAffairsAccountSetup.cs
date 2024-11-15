using JINSHIN.FinanceAccounting.DB;
using FinanceAccountProgram.VModel.Conrols.GridView;
using FinanceAccountProgram.VModel.Conrols.ManageForm;
using FinanceAccountProgram.VModel.DiaryInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinanceAccountProgram.Models.Affairs;
using JINSHIN.FinanceAccount.Libary.Models.UControls.DGridView;
using JINSHIN.BUSINESS.LIBARY.UIControls.FormMgt.BindData;
using JINSHIN.BUSINESS.LIBARY.UIControls.GridView;
using JINSHIN.BUSINESS.LIBARY.Models.UIControls;
using JINSHIN.FinanceAccount.Libary.VModels.UIControls;
using JINSHIN.Finance.AccountSystem;
using JINSHIN.FinanceAccount.Libary.VModels;
using JINSHIN.FinanceAccounting.DB.VModel;
using JINSHIN.BUSINESS.LIBARY.Resources;
using JINSHIN.FinanceAccount.Libary.Models.Forms;
using JINSHIN.FinanceAccount.Libary.VModels.AccControl;

namespace FinanceAccountProgram.FrmControl
{
    public partial class FrmAffairsAccountSetup : Form
    {
        public MDControlVModel controlmodel { get; set; }
        public TextControlBind txtcontrolbind { get; set; }
        public FunctionControl fcontrol { get; set; }
        public int selectedno { get; set; }
        public JINSHINFINANCE050 selectedval { get; set; }
        public BaseGridCtl gridviewctl { get; set; }
        public int dNo { get; set; }
        public int mNo { get; set; }
        public AffairsTypes affairType { get; set; }
        public FrmAffairsAccountSetup()
        {
            InitializeComponent();            
            controlmodel = new MDControlVModel();
            txtcontrolbind = new TextControlBind();
            fcontrol = new FunctionControl();
            gridviewctl = new BaseGridCtl();
            using (FormControlVModel ctlmodel = new FormControlVModel())
            {
                ctlmodel.ControlResolution(this);
            }
            
           // SysRescControlVModel.Let1366ToMaxWindowSize(this);
        }

        private void FrmAffairsAccountSetup_Load(object sender, EventArgs e)
        {
            SearchData();
        }

        private void SearchData()
        {
            controlmodel.GetMasterData(coDiaryClass);
            coDiaryClass.SelectedIndex = 0;
            controlmodel.Query_Class(Convert.ToInt32(coDiaryClass.SelectedValue), coDiaryData);
            if (coDiaryData.Items.Count > 0)
            {
                coDiaryData.SelectedIndex = 0;
                QueryData(false);
            }
        }

        private void QueryData(bool IsShowMsg)
        {
            if (coDiaryData.SelectedIndex != -1 && coDiaryClass.SelectedIndex != -1)
            {
                GetData(Convert.ToInt32(coDiaryData.SelectedValue));
            }
            else
            {
                if (IsShowMsg)
                {
                    MessageBox.Show(FormCaption.BookDiaryCatpion01, "對話框");
                   return;
                }
            }
        }

        private List<AffairsAccountModel> ConvertDBookVModel(AccountEntities entity, List<JINSHINFINANCE037> mains, List<JINSHINFINANCE034> Mmains)
        {
            List<AffairsAccountModel> vals = new List<AffairsAccountModel>();
            foreach (var item in mains)
            {
                foreach (var v in Mmains)
                {
                    try
                    { 
                        vals.AddRange(entity.JINSHINFINANCE050.Where(o => o.Ddatalink == item.No && o.Mdatalink == v.No).Select(i =>
                           new AffairsAccountModel()
                           {
                               accid = i.AccId,
                               amount = i.Amount ?? 0,
                               IsDefault = i.IsDefault ?? false,
                               createtime = i.CreateTime.Value,
                               datatype = i.datatype.Value,
                               no = i.No,
                               sn = i.Sn.Value,
                               DdataText = item.Name,
                               MdataText = v.Name,
                               classtext = i.classtext ?? "",
                               classtype = i.classtype
                           }).ToList());                    
                    }
                    catch (Exception)
                    {

                 //       throw;
                    }
                }
            }
            return vals;
        }

        private List<AffairsAccountModel> ConvertDBookVModel(AccountEntities entity, List<JINSHINFINANCE037> mains, List<JINSHINFINANCE034> Mmains, int datatype)
        {
            List<AffairsAccountModel> vals = new List<AffairsAccountModel>();
            foreach (var item in mains)
            {
                foreach (var v in Mmains)
                {
                    vals = entity.JINSHINFINANCE050.Where(o => o.Ddatalink == item.No && o.Mdatalink == v.No && o.datatype == datatype).Select(i =>
                       new AffairsAccountModel()
                       {
                           accid = i.AccId,
                           amount = i.Amount ?? 0,
                           IsDefault = i.IsDefault ?? false,
                           classtext = i.classtext,
                           createtime = i.CreateTime.Value,
                           datatype = i.datatype.Value,
                           no = i.No,
                           sn = i.Sn.Value,
                           DdataText = item.Name,
                           MdataText = v.Name
                       }).ToList();
                }
            }
            return vals;
        }

        private List<AffairsAccountModel> GetSelecttionEntity(int dno, List<AffairsAccountModel> items)
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    int Mno = (coDiaryClass.SelectedItem as JINSHINFINANCE034).No;
                    if (coDiaryClass.SelectedItem != null)
                    {
                        var mains = entity.JINSHINFINANCE037.Where(o => o.No == dno && o.MaNo == Mno).ToList();
                        var Mmains = entity.JINSHINFINANCE034.Where(o => o.No == Mno).ToList();
                        items = ConvertDBookVModel(entity, mains, Mmains);
                    }
                    else
                    {
                        MessageBox.Show("沒有選擇類別", "對話框");
                        return items;
                    }
                }
            }
            return items;
        }

        private void GetData(int dno)
        {
            List<AffairsAccountModel> items = default(List<AffairsAccountModel>);
            items = GetSelecttionEntity(dno, items).OrderBy(o=>o.sn).ToList();
            for (int i = 0; i < items.Count; i++)
            {
                items[i].DataSn = i + 1;
            }
            dgAccContents.DataSource = items;
            gridviewctl.SetGridColumns<AccountAffairsDGItems>(dgAccContents, new AccountAffairsDGItems());
            dgAccContents.Refresh();
        }

        private void LoadControlsValues(JINSHINFINANCE050 data)
        {
            coDiaryClass.SelectedValue = data.Mdatalink;
            coDiaryData.SelectedValue = data.Ddatalink;
            chDefault.Checked = data.IsDefault ?? false;
            using (TextControlBind txtbind = new TextControlBind())
            {
                txtbind.LoadControlsItem(gbInputs, data);
            }
        }

        private void btnAccSave_Click(object sender, EventArgs e)
        {
            if (!(coDiaryData.SelectedIndex != -1 && coDiaryClass.SelectedIndex != -1))
            {
               MessageBox.Show(FormCaption.BookDiaryCatpion01, "對話框");
               return;
            }
            if (selectedval == null)
            {
                MessageBox.Show(FormCaption.BookAffairsAccountCaption01, "對話框");
                return;
            }
            TextControlBind txtbind = new TextControlBind();
            try
            {
                using (AccountEntityDB content = new AccountEntityDB())
                {
                    using (AccountEntities entity = content.GetEntity())
                    {

                        JINSHINFINANCE050 accountentity = entity.JINSHINFINANCE050.Where(o => o.No == selectedval.No).FirstOrDefault();
                        if (accountentity != null)
                        {
                            List<NameValues> values = SetEntityData(accountentity, txtbind, entity);
                            txtbind.affair_type = affairType;  
                            txtbind.SetData(values, accountentity);
                            entity.SaveChanges();
                            QueryData(false);
                        }
                        else
                        {
                            MessageBox.Show(FormCaption.BookAffairsAccountCaption01, "對話框");
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string str = ex.ToString();
            }
            finally {
                txtbind.Dispose();
            }
        }

        private List<NameValues> SetEntityData(JINSHINFINANCE050 accountentity, TextControlBind txtbind, AccountEntities entity)
        {
            int Mno = (coDiaryClass.SelectedItem as JINSHINFINANCE034).No;
            int dno = Convert.ToInt32(coDiaryData.SelectedValue);
            var mains = entity.JINSHINFINANCE037.Where(o => o.No == dno && o.MaNo == Mno).ToList();
            accountentity.Mdatalink = Mno;
            accountentity.Ddatalink = dno;
            accountentity.IsDefault = chDefault.Checked;
            accountentity.CreateTime = DateTime.Now;
            List<NameValues> values = txtbind.GetControlsItem(gbInputs);
            return values;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!(coDiaryData.SelectedIndex != -1 && coDiaryClass.SelectedIndex != -1))
            {
                MessageBox.Show(FormCaption.BookDiaryCatpion01, "對話框");
                return;
            }
            else
            {
                try
                {
                    if (selectedval != null)
                    {
                        using (AccountEntityDB content = new AccountEntityDB())
                        {
                            using (AccountEntities entity = content.GetEntity())
                            {
                                var val = entity.JINSHINFINANCE050.Where(o => o.No == selectedval.No).FirstOrDefault();
                                if (val != null)
                                {
                                    entity.JINSHINFINANCE050.Remove(val);
                                    entity.SaveChanges();
                                }
                            }
                        }
                        QueryData(false);
                    }
                    else
                    {
                        MessageBox.Show(FormCaption.BookAffairsAccountCaption02, "對話框");
                        return;
                    }
                }
                catch (Exception ex)
                {
                    string str = ex.ToString();
                }
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            QueryData(false);
        }

        private void dgAccContents_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            SelectDataRow(sender);
        }

        private void SelectDataRow(object sender)
        {
            if ((sender as DataGridView).CurrentRow != null)
            {
                using (AccountEntityDB content = new AccountEntityDB())
                {
                    using (AccountEntities entity = content.GetEntity())
                    {
                        selectedno = Convert.ToInt32((sender as DataGridView).CurrentRow.Cells[0].Value);
                        selectedval = entity.JINSHINFINANCE050.Where(o => o.No == selectedno).FirstOrDefault();
                        LoadControlsValues(selectedval);
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void coDiaryClass_TextChanged(object sender, EventArgs e)
        {
            if (!(coDiaryClass.SelectedValue is JINSHINFINANCE034))
            {
                controlmodel.Query_Class(Convert.ToInt32(coDiaryClass.SelectedValue), coDiaryData);
            }
        }

        private void coDiaryData_TextChanged(object sender, EventArgs e)
        {
            if (!(coDiaryData.SelectedValue is JINSHINFINANCE037))
            {
                QueryData(false);
            }
            if (coDiaryData.SelectedValue == null)
                DataSelectedInit();
            else if (!(coDiaryData.SelectedValue is JINSHINFINANCE037))
            {
              if (int.Parse(coDiaryData.SelectedValue.ToString()) == 0)
                 DataSelectedInit();
            }
        }

        private void coDiaryClass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void coDiaryClass_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!(coDiaryClass.SelectedValue is JINSHINFINANCE034))
            {
                mNo = Convert.ToInt32(coDiaryClass.SelectedValue);
            }
        }

        private void coDiaryData_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!(coDiaryData.SelectedValue is JINSHINFINANCE037))
            {
                dNo = Convert.ToInt32(coDiaryData.SelectedValue);
            }
            else
            {
                DataSelectedInit();
            }
        }

        private void DataSelectedInit()
        {
            selectedval = null;
            selectedno = -1;
            dNo = -1;
            mNo = -1;
        }

        private void dgAccContents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectDataRow(sender);
        }

        private void dgAccContents_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SelectDataRow(sender);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtAmount005.Text == "")
            {
                MessageBox.Show("金額不能為空，不需要請填0", "對話框");
                return;
            }

            if (!(coDiaryData.SelectedIndex != -1 && coDiaryClass.SelectedIndex != -1))
            {
                MessageBox.Show(FormCaption.BookDiaryCatpion01, "對話框");
                return;
            }
            JINSHINFINANCE050 accountentity = new JINSHINFINANCE050();
            TextControlBind txtbind = new TextControlBind();
            try
            {
                int blankcnt = 0;
                using (AccountEntityDB content = new AccountEntityDB())
                {
                    using (AccountEntities entity = content.GetEntity())
                    {
                        List<NameValues> values = SetEntityData(accountentity, txtbind, entity);
                        foreach (var item in values)
                        {
                            if (item.dbvalue == null && item.name.ToUpper() != "AMOUNT")
                            {
                                blankcnt = blankcnt + 1;
                            }
                            else if (item.dbvalue.ToString() == "" && item.name.ToUpper() != "AMOUNT")
                            {
                                blankcnt = blankcnt + 1;
                            }
                        }
                        if (blankcnt > 0)
                        {
                            MessageBox.Show(FormCaption.BookAffairsAccountCaption03, "對話框");
                            return;
                        }
                        txtbind.affair_type = affairType;
                        txtbind.SaveControlsItem(values, accountentity);
                        QueryData(false);
                    }
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                txtbind.Dispose();
            }
        }

        private void FrmAffairsAccountSetup_Shown(object sender, EventArgs e)
        {
            dgAccContents.Font = new System.Drawing.Font(DataControl.DataGridFont, Convert.ToInt32(DataControl.DataGridFontSize));
        }

        private void lstClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (lstClass.SelectedIndex)
            {
                case 2:affairType = AffairsTypes.PayCost;break;
                case 1:affairType = AffairsTypes.RecCost;break;
                case 4:affairType = AffairsTypes.PayTicket;break;
                case 3:affairType = AffairsTypes.RecTicket;break;                   
            }
        }


        private void dgAccContents_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex ==4)
            {
                int datatype = Convert.ToInt32(e.Value);
                switch (datatype)
                {
                    case 2:
                        {
                            e.Value = "付款單";
                        }
                        break;
                    case 1:
                        {
                            e.Value = "收款單";
                        }
                        break;
                    case 4:
                        {
                            e.Value = "應付票據";
                        }
                        break;
                    case 3:
                        {
                            e.Value = "應收票據";
                        }
                        break;
                }
            }
            else if (e.ColumnIndex == 10)
            {
                if (Convert.ToBoolean(e.Value))
                {
                    e.Value = "是";
                }
                else if (!Convert.ToBoolean(e.Value))
                {
                    e.Value = "否";
                }
            }
            else if (e.ColumnIndex == 11)
            {
                if (e.Value != null)
                {
                    e.Value = Convert.ToDateTime(e.Value).ToString("yyyy/MM/dd");
                }               
            }

        }

        private void dgAccContents_CellLeave(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
