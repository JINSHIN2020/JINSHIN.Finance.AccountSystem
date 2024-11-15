using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FinanceAccountProgram.VModel;
using JINSHIN.FinanceAccounting.DB;
using JINSHIN.FinanceAccount.Libary.VModels;
//using JINSHIN.BUSINESS.LIBARY.Models.UIControls;
using JINSHIN.BUSINESS.LIBARY.UIControls.FormMgt.EntityVModel;
using JINSHIN.BUSINESS.LIBARY.Models.UControl.GView;
using JINSHIN.BUSINESS.LIBARY.Resources;
using JINSHIN.BUSINESS.LIBARY.Models.UIControls;
using JINSHIN.Finance.AccountSystem;
using JINSHIN.FinanceAccounting.DB.VModel;
using JINSHIN.FinanceAccount.Libary.VModels.DB;

namespace FinanceAccountProgram.Controls
{
    public partial class DoubleTablesControl : UserControl
    {        
        private int detailkey = 0;
        private int detailaccid = 4;
        private int detailaccdesc = 5;
        private int masterkeydata = 0;
        public entityNames mastertype { get; set; }
        public List<NameValues> mvalues { get; set; }
        public entityNames detailtype { get; set; }
        public List<NameValues> detailvalues2 { get; set; }
        public DBClassCtl dbclassctl { get; set; }
        public FinanceEntityControl control { get; set; }
        public List<DataModel> mdata { get; set; }
        public List<DataModel> detaildata { get; set; }

        public EventHandler MAddClick;
        public EventHandler MUpdateClick;
        public EventHandler MDeleteClick;
        public EventHandler MQueryClick;
        public EventHandler DetailAddClick;
        public EventHandler DetailDelteClick;
        public EventHandler DetailUpdateClick;
        public EventHandler DetailDelteALLClick;
        public DataGridViewCellEventHandler GridSelectData { get; set; }
        public DoubleDataControls datacontrol { get; set; }



        public DoubleTablesControl()
        {
            InitializeComponent();
            dbMasterData.Font = new System.Drawing.Font(DataControl.DataGridFont, Convert.ToInt32(DataControl.DataGridFontSize));
            dgDetailData.Font = new System.Drawing.Font(DataControl.DataGridFont, Convert.ToInt32(DataControl.DataGridFontSize));

            datacontrol = new DoubleDataControls();
        
            detailvalues2 = new List<NameValues>();
            dbclassctl = new DBClassCtl();
            mdata = new List<DataModel>();
            detaildata = new List<DataModel>();
            btnMUpdate.Click += MUpdateClick;
            btnDetailUpdate.Click += DetailUpdateClick;
            btnMDelete.Click += MDeleteClick;
            btnDdelete.Click += DetailDelteClick;
            btnDDeleteAll.Click += DetailDelteALLClick;
        }

        public void SetInit(entityNames mtype, entityNames dtype, FinanceEntityControl Fcontrol)
        {
            mvalues = new List<NameValues>();
            mastertype = mtype;
          //  detailtype = dtype;
            control = Fcontrol;
         }
        private  void btnMAdd_Click(object sender, EventArgs e)
        {
            if (lblAffairsSN.Text != "")
            {
                if (!(MessageBox.Show(FormCaption.AffairsMasterCaption01, accounting.FormDataTitle, MessageBoxButtons.OKCancel) == DialogResult.OK))
                {
                    return;
                }
            }
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    lblAffairsSN.Text = control.GetMaxNo(entity, mastertype).ToString();
                }
            }
            SetMvaluesIns();
            MAddClick(new object(), null);
            txtIDiaAccDesc.Text = "";
        }

        private void btnMQuery_Click(object sender, EventArgs e)
        {
            QueryMasterData();
        }

        private void QueryMasterData()
        {
            SetMvaluesSearch();
            dgDetailData.DataSource = null;
            MQueryClick(new object(), null);
        }

        public void SetMvaluesSearch()
        {
            mvalues.Clear();
            NameValues val = new NameValues();
            val.name = "SN";
            val.dbvalue = txtSN.Text == "" ? null : txtSN.Text.Trim();
            mvalues.Add(val);
            NameValues val01 = new NameValues();
            val01.name = "DescTitle";
            val01.dbvalue = txtDiaAccDesc.Text.Trim() == "" ? null : txtDiaAccDesc.Text.Trim();
            mvalues.Add(val01);
        }

        public void SetMvaluesIns()
        {
            mvalues.Clear();
            NameValues val = new NameValues();
            val.name = "SN";
            val.dbvalue = lblAffairsSN.Text == "" ? null : lblAffairsSN.Text.Trim();
            mvalues.Add(val);
            NameValues val01 = new NameValues();
            val01.name = "DescTitle";
            val01.dbvalue = txtIDiaAccDesc.Text.Trim() == "" ? null : txtIDiaAccDesc.Text.Trim();
            mvalues.Add(val01);
        }

        private void btnDetailAdd_Click(object sender, EventArgs e)
        {
            if (lblDescSN.Text != "")
            {
                if (!(MessageBox.Show(FormCaption.AffairsDetailCaption01, accounting.FormDataTitle, MessageBoxButtons.OKCancel) == DialogResult.OK))
                {
                    return; 
                }
            }
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    lblDescSN.Text = control.GetMaxNo(entity, detailtype).ToString();
                    SetIDetails();
                    DetailAddClick(new object(), null);
                    ClearDetail();
                }
            }
        }

        private void ClearDetail()
        {
            txDiaAccDesc01.Text = "";
            txDiaAccID.Text = "";
            lblDescSN.Text = "";
        }

        private void btnMUpdate_Click(object sender, EventArgs e)
        {
            SetMvaluesIns();
            MUpdateClick(new object(), null);
        }

        private void btnDetailUpdate_Click(object sender, EventArgs e)
        {
            SetIDetails();
            DetailUpdateClick(new object(), null);
        }



        private void SingleRowCardDataModify01(DataGridViewRow rws01)
        {
            try
            {
                lblAffairsSN.Text = rws01.Cells[masterkeydata].Value.ToString();
                object valdesc = rws01.Cells[2].Value ?? "";
                txtIDiaAccDesc.Text = valdesc.ToString();
                SetMvaluesIns();
           //     MQueryClick(new object(), null);
            }
            catch (Exception)
            {

 
            }
           
        }
        private void SingleRowCardDataModify02(DataGridViewRow rws01)
        {
          //  lblDescSN.Text = rws01.Cells[detailkey].Value.ToString();
            if (rws01.Cells.Count > 1)
            {
                try
                {
                    lblDescSN.Text = rws01.Cells[detailkey].Value.ToString();
                    txDiaAccID.Text = rws01.Cells[detailaccid].Value.ToString();
                    txDiaAccDesc01.Text = rws01.Cells[detailaccdesc].Value.ToString();
                    SetDetails(rws01);
                }
                catch (Exception)
                { 
                
                }
            }
        }

        public void SetIDetails()
        {
            detailvalues2.Clear();
            NameValues val02 = new NameValues();
            val02.name = "Desc02";
            val02.dbvalue = txDiaAccDesc01.Text.ToString() == "" ? null : txDiaAccDesc01.Text.ToString();
            val02.datatype = "string";

            //txtDesciddata
            NameValues val01 = new NameValues();
            val01.name = "DescID";
            val01.dbvalue = lblDescSN.Text.ToString() == "" ? null : lblDescSN.Text.ToString();
            val01.datatype = "int";


            NameValues val03 = new NameValues();
            val03.name = "Desc01";
            val03.dbvalue = txtIDiaAccDesc.Text.Trim() == "" ? null : txtIDiaAccDesc.Text.Trim();
            val03.datatype = "string";

            NameValues val05 = new NameValues();
            val05.name = "AffairsNo";
            val05.dbvalue = dbMasterData.SelectedRows[0].Cells[masterkeydata].Value.ToString().Trim() == "" ? null : dbMasterData.SelectedRows[0].Cells[masterkeydata].Value.ToString().Trim();
            val05.datatype = "int";


            NameValues val06 = new NameValues();
            val06.name = "Acc_ID";
            val06.dbvalue = txDiaAccID.Text.ToString() == "" ? null : txDiaAccID.Text.ToString();
            val06.datatype = "string";
            detailvalues2.Add(val01);
            detailvalues2.Add(val02);
            detailvalues2.Add(val03);
            detailvalues2.Add(val05);
            detailvalues2.Add(val06);
        }

        public void SetDetails(DataGridViewRow rws01)
        {
            detailvalues2.Clear();

            NameValues val02 = new NameValues();
            val02.name = "Desc02";
            val02.dbvalue = rws01.Cells[detailaccdesc].Value.ToString() == "" ? null : rws01.Cells[detailaccdesc].Value.ToString();
            val02.datatype = "string";

            //txtDesciddata
            NameValues val01 = new NameValues();
            val01.name = "DescID";
            val01.dbvalue = rws01.Cells[detailkey].Value.ToString() == "" ? null : rws01.Cells[detailkey].Value.ToString();
            val01.datatype = "int";


            NameValues val03 = new NameValues();
            val03.name = "Desc01";
            val03.dbvalue = txtIDiaAccDesc.Text.Trim() == "" ? null : txtIDiaAccDesc.Text.Trim();
            val03.datatype = "string";

            NameValues val05 = new NameValues();
            val05.name = "AffairsNo";
            val05.dbvalue = dbMasterData.SelectedRows[0].Cells[masterkeydata].Value.ToString().Trim() == "" ? null : dbMasterData.SelectedRows[0].Cells[masterkeydata].Value.ToString().Trim();
            val05.datatype = "int";


            NameValues val06 = new NameValues();
            val06.name = "Acc_ID";
            val06.dbvalue = rws01.Cells[detailaccid].Value.ToString() == "" ? null : rws01.Cells[detailaccid].Value.ToString();
            val06.datatype = "string";
            detailvalues2.Add(val01);
            detailvalues2.Add(val02);
            detailvalues2.Add(val03);
            detailvalues2.Add(val05);
            detailvalues2.Add(val06);
        }

        private void dbMasterData_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if ((dbMasterData.SelectedRows.Count > 0))
            {
                var rws = dbMasterData.SelectedRows[0];
                SingleRowCardDataModify01(rws);
            }
        }
        private void dbMasterData_SelectionChanged(object sender, EventArgs e)
        {
            if ((dbMasterData.SelectedRows.Count > 0))
            {
                var rws = dbMasterData.SelectedRows[0];
                SingleRowCardDataModify01(rws);
                if (datacontrol.QueryDCondition(Convert.ToInt32(mvalues[0].dbvalue), detailvalues2, dgDetailData))
                {
                    ClearDetail();
                }
            }
        }
        private void dgDetailData_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DetailRowSelected();
        }

        private void DetailRowSelected()
        {
            if ((dgDetailData.SelectedRows.Count > 0))
            {
                var rws = dgDetailData.SelectedRows[0];
                SingleRowCardDataModify02(rws);
            }
        }

        private void dgDetailData_SelectionChanged(object sender, EventArgs e)
        {
            if ((dgDetailData.SelectedRows.Count > 0))
            {
                var rws = dgDetailData.SelectedRows[0];
                SingleRowCardDataModify02(rws);
                //SetDetails();
                //MQueryClick(new object(), null);
            }
        }

        private void btnMDelete_Click(object sender, EventArgs e)
        {            
       //     SetMvaluesSearch();
            MDeleteClick(new object(), null);
            QueryMasterData();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDdelete_Click(object sender, EventArgs e)
        {
            //detail data had been interted in the grid
            DetailDelteClick(new object(), null);
            ClearDetail();
            QueryMasterData();
        }

        private void btnDDeleteAll_Click(object sender, EventArgs e)
        {
            //SetMvaluesSearch();
            DetailDelteALLClick(new object(), null);
            ClearDetail();
            QueryMasterData();
        }

        private void txtIDiaAccDesc_MouseUp(object sender, MouseEventArgs e)
        {
           // lblAffairsSN.Text = "";
        }

        private void dgDetailData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DetailRowSelected();
        }
    }
}
