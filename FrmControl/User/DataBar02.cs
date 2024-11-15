using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JINSHIN.BUSINESS.LIBARY.Models.UIControls.ToolBars;
using CardClick.Logs;
using CardClick.VModel.Frm.User;

namespace CardClick.UsrControl
{
    public partial class DataBar02 : UserControl
    {
        public DataGridView dgv { get; set; }
        public EventHandler NewFunction { get; set; }
        public EventHandler QueryFunction { get; set; }
        public EventHandler DeleteFunction { get; set; }
        public EventHandler UpdateFunction { get; set; }
        public ToolBarModel data { get; set; }

      //  public UserFrmModel model { get; set; }
        public void SetData(DataGridView val)
        {
            data = new ToolBarModel();
            dgv = val;
            dgv.KeyUp += ViewFastKey;
            dgv.SelectionChanged += dgv_SelectionChanged;
            dgv.RowEnter += datagrid_RowEnter;
            btnQuery.Click += QueryFunction;
            btnNew.Click += NewFunction;
            btnUpdate.Click += UpdateFunction;
            btnDelete.Click += DeleteFunction;
        }
        public void datagrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv.Rows.Count > 0)
                {
                    if (e.RowIndex != -1)
                    {
                        data.No = dgv.Rows[e.RowIndex].Cells[data.keyidx].Value.ToString();
                        data.var01 = dgv.Rows[e.RowIndex].Cells[data.var01index].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                LogControl.LogAlarm(ex.ToString());
            }

        }
        public void ViewFastKey(object obj, KeyEventArgs args)
        {
            if (args.KeyCode == Keys.F1)
            {
                btnQuery.Invoke(QueryFunction);
            }
            else if (args.KeyCode == Keys.F2)
            {
                btnNew.Invoke(NewFunction);
            }
            else if (args.KeyCode == Keys.F3)
            {
                btnUpdate.Invoke(UpdateFunction);
            }
            else if (args.KeyCode == Keys.F5)
            {
                btnDelete.Invoke(DeleteFunction);
            }
        }

        public DataBar02()
        {
            InitializeComponent();
            tooltip_control.SetToolTip(btnQuery, "F1");
            tooltip_control.SetToolTip(btnNew, "F2");
            tooltip_control.SetToolTip(btnUpdate, "F3");
            tooltip_control.SetToolTip(btnDelete, "F5");

        }
        public void dgv_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgv.SelectedRows.Count > 0)
                {
                    data.No = dgv.SelectedRows[0].Cells[data.keyidx].Value.ToString();
                    data.var01 = dgv.SelectedRows[0].Cells[data.var01index].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                LogControl.LogAlarm(ex.ToString());                
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
