using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinanceAccountProgram.VModel.UsrControl;
using JINSHIN.Alayway.Frameworks.VModels.UIControl.DGridView;
using FinanceAccountProgram.VModel;
using FinanceAccountProgram.Models.UControl;
using JINSHIN.BUSINESS.LIBARY.UIControls.FormMgt.EntityVModel;
using JINSHIN.BUSINESS.LIBARY.Models.UIControls;
using JINSHIN.BUSINESS.LIBARY.Models.UControl.GView;
using JINSHIN.BUSINESS.LIBARY.Resources;
using JINSHIN.BUSINESS.LIBARY.UIControls.GridView;

namespace FinanceAccountProgram.Controls
{
    public partial class MasterUI : UserControl
    {
        private int masterkeydata = 0;
        public entityNames mastertype1 { get; set; }
        public List<NameValues> mvalues { get; set; }
        public DBClassCtl dbclassctl { get; set; }
        public EntityControl control { get; set; }
        public List<DataModel> mdata = new List<DataModel>();
        public EventHandler MAddClick;
        public EventHandler MUpdateClick;
        public EventHandler MDeleteClick;
        public EventHandler MQueryClick;
        public MasterUI()
        {
            InitializeComponent();
            dbMasterData.Font = new System.Drawing.Font(DataControl.DataGridFont, Convert.ToInt32(DataControl.DataGridFontSize));

        }

        
        public void SetInit()
        {
            mastertype1 = new entityNames();
            mvalues = new List<NameValues>();
            dbclassctl = new DBClassCtl();
            mdata = new List<DataModel>();
            control = new EntityControl(new BaseGridCtl());
            btnMUpdate.Click += MUpdateClick;
            btnMDelete.Click += MDeleteClick;
            btnMAdd.Click += MAddClick;
            btnMQuery.Click += MQueryClick;
        }
        public void SetInit(entityNames mtype, EntityControl Fcontrol)
        {
            mastertype1 = mtype;
            control = Fcontrol;
        }
        private void QueryMasterData()
        {
            SetMvaluesSearch();
            MQueryClick(new object(), null);
            SelectRowDisplayData();
        }

        public void SetMvaluesSearch()
        {
            mvalues.Clear();
            NameValues val = new NameValues();
            val.name = "No";
            val.dbvalue = txtSN.Text == "" ? null : txtSN.Text.Trim();
            mvalues.Add(val);
            NameValues val01 = new NameValues();
            val01.name = "SName";
            val01.dbvalue = txtAccName.Text.Trim() == "" ? null : txtAccName.Text.Trim();
            mvalues.Add(val01);
        }

        public void SetMvaluesIns()
        {
            mvalues.Clear();
            NameValues val = new NameValues();
            val.name = "No";
            val.dbvalue = lblSN.Text == "" ? null : lblSN.Text.Trim();
            mvalues.Add(val);
            NameValues val01 = new NameValues();
            val01.name = "SName";
            val01.dbvalue = txtIAccName.Text.Trim() == "" ? null : txtIAccName.Text.Trim();
            mvalues.Add(val01);
        }

        private void btnMUpdate_Click(object sender, EventArgs e)
        {
            SetMvaluesIns();
            MUpdateClick(new object(), null);
        }

        private void btnMDelete_Click(object sender, EventArgs e)
        {
            MDeleteClick(new object(), null);
            QueryMasterData();
        }

        public void ClearALL()
        {
            lblSN.Text = "";
            txtIAccName.Text = "";
        }

        private void btnMAdd_Click(object sender, EventArgs e)
        {
            SetMvaluesIns();
            MAddClick(new object(), null);
            txtIAccName.Text = "";
        }

        private void btnMQuery_Click(object sender, EventArgs e)
        {
            QueryMasterData();
        }

        private void dbMasterData_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            SelectRowDisplayData();
        }

        private void SelectRowDisplayData()
        {
            if ((dbMasterData.SelectedRows.Count > 0))
            {
                var rws = dbMasterData.SelectedRows[0];
                SingleRowCardDataModify01(rws);
            }
        }

        private void SingleRowCardDataModify01(DataGridViewRow rws01)
        {
            try
            {
                lblSN.Text = rws01.Cells[masterkeydata].Value.ToString();
                object valdesc = rws01.Cells[2].Value ?? "";
                txtIAccName.Text = valdesc.ToString();
                SetMvaluesIns();
                //     MQueryClick(new object(), null);
            }
            catch (Exception)
            {


            }

        }

        private void dbMasterData_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
