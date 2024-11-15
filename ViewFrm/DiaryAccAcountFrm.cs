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
using JINSHIN.BUSINESS.LIBARY.Resources;
using JINSHIN.Finance.AccountSystem;
using JINSHIN.FinanceAccount.Libary.VModels;
using JINSHIN.FinanceAccounting.DB.VModel;
using JINSHIN.FinanceAccount.Libary.VModels.AccControl;

namespace FinanceAccountProgram.ViewFrm
{
    public partial class DiaryAccAcountFrm : Form
    {
        public DataGridView dgv { get; set; }
        public MDControlVModel controlmodel  { get; set; }
    public int sn { get; set; }
        public DiaryAccAcountFrm()
        {
            InitializeComponent();
            controlmodel = new MDControlVModel();
        }

        private void DiaryAccAcountFrm_Load(object sender, EventArgs e)
        {
            controlmodel.GetMasterData(coDiaryClass);
            coDiaryClass.SelectedIndex = 0;
            controlmodel.Query_Class(Convert.ToInt32(coDiaryClass.SelectedValue), coDiaryData);
            if (coDiaryData.Items.Count > 0)
            {
                coDiaryData.SelectedIndex = 0;
                QueryData(false);
            }
            dgAccContents.Font = new System.Drawing.Font(DataControl.DataGridFont, Convert.ToInt32(DataControl.DataGridFontSize));
            //dgAccContents
        }

        private void GetData(int dno)
        {
            List<DiaryBookVModel> items = default(List<DiaryBookVModel>);
            string str = txtAffairName.Text.Trim();
            if (str != "")
             items = GetNameAccountEnttiy(str);
            else
             items = GetSelecttionEntity(dno, items);

            for (int i = 0; i < items.Count; i++)
            {
                items[i].sn = i + 1;
            }
            dgAccContents.DataSource = items;
            AccoutnEntriesGridView gridviewcols = new AccoutnEntriesGridView();
            gridviewcols.SetAccConfirmGridColumns(dgAccContents);
            dgAccContents.Refresh();
        }

        private List<DiaryBookVModel> GetSelecttionEntity(int dno, List<DiaryBookVModel> items)
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    int Mno = (coDiaryClass.SelectedItem as JINSHINFINANCE034).No;
                    int datatype = 0;
                    if (txDataType.Text != "")
                    {
                        int.TryParse(txDataType.Text, out datatype);
                        var mains = entity.JINSHINFINANCE037.Where(o => o.No == dno && o.MaNo == Mno).ToList();
                        var Mmains = entity.JINSHINFINANCE034.Where(o => o.No == Mno).ToList();
                        items = ConvertDBookVModel(entity, mains, Mmains, datatype);
                    }
                    else
                    {
                        if (coDiaryClass.SelectedItem != null)
                        {
                            var mains = entity.JINSHINFINANCE037.Where(o => o.No == dno && o.MaNo == Mno).ToList();
                            var Mmains = entity.JINSHINFINANCE034.Where(o => o.No == Mno).ToList();
                            items = ConvertDBookVModel(entity, mains, Mmains);
                        }
                        else
                            MessageBox.Show("沒有選擇類別", "對話框");
                    }
                }
            }

            return items;
        }

        private List<DiaryBookVModel> GetNameAccountEnttiy(string str)
        {
            List<DiaryBookVModel> items;
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    var mains = entity.JINSHINFINANCE037.Where(o => (o.Name.IndexOf(str) != -1)).ToList();
                    var Mmains = entity.JINSHINFINANCE034.ToList();
                    items = ConvertDBookVModel(entity, mains, Mmains);
                }
            }
            return items;
        }

        private List<DiaryBookVModel> ConvertDBookVModel(AccountEntities entity, List<JINSHINFINANCE037> mains, List<JINSHINFINANCE034> Mmains)
        {
            List<DiaryBookVModel> vals = new List<DiaryBookVModel>();
            foreach (var item in mains)
            {
                foreach (var v in Mmains)
                {
                    vals.AddRange(entity.JINSHINFINANCE050.Where(o => o.Ddatalink == item.No && o.Mdatalink == v.No).Select(i =>
                       new DiaryBookVModel()
                       {
                           accid = i.AccId,
                           createtime = i.CreateTime.Value,
                           datatype = i.datatype.Value,
                           no = i.No,
                           sn = i.Sn.Value,
                           DdataText = item.Name,
                           MdataText = v.Name
                       }).ToList());
                }
            }
            return vals;
        }

        private List<DiaryBookVModel> ConvertDBookVModel(AccountEntities entity, List<JINSHINFINANCE037> mains, List<JINSHINFINANCE034> Mmains,int datatype)
        {
            List<DiaryBookVModel> vals = new List<DiaryBookVModel>();
            foreach (var item in mains)
            {
                foreach (var v in Mmains)
                {
                    vals = entity.JINSHINFINANCE050.Where(o => o.Ddatalink == item.No && o.Mdatalink == v.No && o.datatype == datatype).Select(i =>
                       new DiaryBookVModel()
                       {
                           accid = i.AccId,
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
        private void coDiaryList_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void btnAccQuery_Click(object sender, EventArgs e)
        {
            QueryData(true);
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
                  MessageBox.Show(FormCaption.BookDiaryCatpion01, "對話框");
            }
        }

        private void txDataType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                QueryData(true);
            }
        }

        private void dgAccContents_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            List<JINSHINFINANCE035> data = new List<JINSHINFINANCE035>();
            foreach (var item in dgAccContents.SelectedRows)
            {
                JINSHINFINANCE035 v = new JINSHINFINANCE035();
                v.Acc_ID = (item as DataGridViewRow).Cells[3].Value.ToString();
                v.DataType = byte.Parse((item as DataGridViewRow).Cells[4].Value.ToString());
                v.Item = int.Parse((item as DataGridViewRow).Cells[6].Value.ToString());
                data.Add(v);
            }
            List<JINSHINFINANCE035> items = new List<JINSHINFINANCE035>();
            if (items != null)
                items.Clear();
            items.AddRange(data.OrderBy(o=>o.Item).ToList());
            sn = 1;
            foreach (var item in items)
            {
                item.SN = sn;
                sn++;
            }
            dgv.DataSource = items;
            AccAccountsGridView accountsgridview = new AccAccountsGridView();
            accountsgridview.SetAccConfirmGridColumns(dgv);
        }

        private void coDiaryData_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void coDiaryData_SelectedValueChanged(object sender, EventArgs e)
        {
         
        }

        private void coDiaryClass_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private void coDiaryData_TextChanged(object sender, EventArgs e)
        {
            if (!(coDiaryData.SelectedValue is JINSHINFINANCE037))
            {
                QueryData(false);
            }
        }

        private void coDiaryClass_TextChanged(object sender, EventArgs e)
        {
            if (!(coDiaryClass.SelectedValue is JINSHINFINANCE034))
            {
                controlmodel.Query_Class(Convert.ToInt32(coDiaryClass.SelectedValue), coDiaryData);                
            }
        }

        private void DiaryAccAcountFrm_Shown(object sender, EventArgs e)
        {
            SysRescControlVModel.SetFixedWindow(this);
        }
    }
}
