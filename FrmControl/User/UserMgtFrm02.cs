using CardClick.UsrControl;
using CardClick.VModel.Frm.User;
using CardClick.VModel.Inc;
using JINSHIN.RegProcess.Liary.Content.Register.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardClick.User
{
    public partial class UserMgtFrm02 : Form, FormControlInc
    {
        private int rowindex { get; set; }
        private int dgvkeyidx { get; set; }
        public UserFrmModel model { get; set; }
        public string OUID { get; set; }
        public int rindex { get; set; }
        public int deptno { get; set; }
        public int deptno_supply { get; set; }
        public UserMgtFrm02(int fdeptno,int deptnoval)
        {
            InitializeComponent();
            deptno = fdeptno;
            deptno_supply = deptnoval;
            model = new UserFrmModel(datagrid,fdeptno, deptnoval);
            rindex = 0;
        }

        private void UserMgtFrm_Load(object sender, EventArgs e)
        {
            dgvkeyidx = 7;
            model.toolbar1 = dataToolBar1;
            model.formtool.keyidx = dgvkeyidx;
            model.formtool.var01index = 8;
            model.toolbar1.QueryFunction = btnQuery_Click;
            model.SetFormParamter(this, datagrid, dataToolBar1, datePickStart.Value, datePickEnd.Value, txtIdName.Text);
            dataToolBar1.SetData(datagrid);
            dataToolBar1.data = model.formtool;
            LoadTopData();
            lblNoData.Location = datagrid.PointToClient(lblNoData.PointToScreen(Point.Empty));
            lblNoData.BackColor = Color.Transparent;
            lblNoData.Parent = datagrid;
            //  btnQuery_Click(new object(), null);
        }
        public void btnQuery_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        public void DisplayNoData()
        {
            if (datagrid.Rows.Count == 0)
            {
                lblNoData.Visible = true;
            }
            else
                lblNoData.Visible = false;
        }
        public void LoadTopData()
        {
            model.RefreshControls(datePickStart.Value, datePickEnd.Value, txtIdName.Text);
            if (datagrid.CurrentRow != null)
                rindex = datagrid.CurrentRow.Index;
            model.LoadTopData(deptno);
            DisplayNoData();
            //datagrid.Rows[rindex].Selected = true;
        }

        public void LoadData()
        {
            model.RefreshControls(datePickStart.Value, datePickEnd.Value, txtIdName.Text);          
            if (datagrid.CurrentRow != null)
              rindex = datagrid.CurrentRow.Index;            
            model.LoadListData(deptno);
            DisplayNoData();
            //datagrid.Rows[rindex].Selected = true;
        }

        private void dataToolBar1_Load(object sender, EventArgs e)
        {

        }

        private void datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void datagrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
