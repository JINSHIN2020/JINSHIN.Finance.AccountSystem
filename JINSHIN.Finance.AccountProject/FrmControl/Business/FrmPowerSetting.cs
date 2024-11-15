using CardClick.Model.GridModel;
using CardClick.Model.User;
using JINSHIN.Business.DataBase;
using JINSHIN.BUSINESS.LIBARY.Models.UIControls;
using JINSHIN.BUSINESS.LIBARY.UIControls.GridView;
using JINSHIN.FinanceAccounting.DB.VModel;
using JINSHIN.FinanceAccounting.DB;
using JINSHIN.Work.TimeSystem;

using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using JINSHIN.BUSINESS.LIBARY.Base;
using JINSHIN.RegProcess.Liary.Content.Register;
using JINSHIN.BUSINESS.LIBARY.Models.DGGridView;
using FinanceAccountProgram.VModel;
using NPOI.HPSF;
using JINSHIN.FinanceAccount.Libary.VModels.GridView;

namespace CardClick.FormControl
{
    public partial class FrmPowerSetting : Form
    {
        private BaseGridViewCtl gridviewctl { get; set; }
        public List<string> manager = new List<string>() { "系統管理員", "主管", "職員" };
        public string userno { get; set; }
        public string username { get; set; }
        public int deptno { get; set; }
        public List<UserPowerModel> controls { get; set; }
        public List<JINSHINFINANCE016> jin16 { get; set; }
        public PrivilegeControl privilegecontrol { get; set; }
        public int thepower { get; set; }
        public List<NameValues> dataitems { get; set; }
        public FrmPowerSetting()
        {
            InitializeComponent();
            dataitems = new List<NameValues>();
            privilegecontrol = new PrivilegeControl();
            gridviewctl = new BaseGridViewCtl();
            controls = new List<UserPowerModel>();
            jin16 = new List<JINSHINFINANCE016>();
            //using (AccountEntityDB content = new AccountEntityDB())
            //{
            //    using (AccountEntities entity = content.GetEntity())
            //    {
            //        depts = entity.JINSHINFINANCE007.Where(o=>o.SupplyNo == DataClass.deptno_supno).ToList();
            //    }
            //}
        }

        private void FrmPowerSetting_Load(object sender, EventArgs e)
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    List<JINSHINFINANCE018> users = default(List<JINSHINFINANCE018>);
                    if (DataClass.username == Project.SuperUser)
                        users = entity.JINSHINFINANCE018.OrderBy(o=>o.IDName).ToList();
                    else
                        users = entity.JINSHINFINANCE018.Where(o => o.SupplyNo == DataClass.SupplyNo 
                      ).OrderBy(o=>o.IDName).ToList();
                    if (users.Count > 0)
                    {
                        var usr = users.FirstOrDefault();
                        DisplayUserInfo(entity,users, usr);
                    }
                }
            }
            //lblNoData.Location = datagrid.PointToClient(lblNoData.PointToScreen(Point.Empty));
            //lblNoData.BackColor = Color.Transparent;
            //lblNoData.Parent = datagrid;
        }

        private void DisplayUserInfo(AccountEntities entity,List<JINSHINFINANCE018> usrs, JINSHINFINANCE018 usr)
        {
            userno = usr.UsrNo;
            username = usr.UserName;
            lblNoVal.Text = userno;
            lblNameVal.Text = username;
            DisplayData(usrs,DataClass.deptno_supno);
            try
            {
              var posno = usr.PosNo;
             // deptno = entity.JINSHINWORK007.Where(o => o.PosNo == posno).FirstOrDefault().DeptNo.Value;              
              LoadPowerList(entity, DataClass.deptno_supno);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void LoadPowerList(AccountEntities entity,int deptsupply)
        {
            //var depts = entity.JINSHINWORK007.Where(o => o.DeptNo == deptno 
            //&& o.SupplyNo == deptsupply).ToList();
            jin16 = entity.JINSHINFINANCE016.ToList();
            dataitems.Clear();
            int idx = 0;
            foreach (var item in jin16.OrderBy(o => o.Power.Value))
            {
                dataitems.Add(new NameValues() { name = item.PName, idx = item.Power.Value });
                idx++;
            }
            lstPower.DataSource = dataitems;
            lstPower.DisplayMember = "name";
            lstPower.ValueMember = "idx";
        }

        private void DisplayData(List<JINSHINFINANCE018> users,int deptsupply)
        {
            controls= ConvertSystemVModel(users, deptsupply);
            gridviewctl.SetGridColumns<PowerControl_DGItem>(datagrid, new PowerControl_DGItem());           
            datagrid.DataSource = controls;
            if (controls.Count > 0)
            {
                int idx = 0;
                //var names = lstPower.DataSource as List<NameValues>;
                idx =dataitems.FindIndex(v => v.idx==thepower);
                lstPower.SelectedIndex = idx;
            }
            else
                lstPower.SelectedIndex = 0;
        }

        private List<UserPowerModel> ConvertSystemVModel(List<JINSHINFINANCE018> values,int deptsupply)
        {
            FunctionControl functl = new FunctionControl();
            List<UserPowerModel> rs = new List<UserPowerModel>();
            for (int i = 0; i < values.Count; i++)
            {
                UserPowerModel val = new UserPowerModel(deptsupply);
                val.DataSn = i + 1;
                functl.ClassCopyTo<JINSHINFINANCE018, UserPowerModel>(values[i], val);
                rs.Add(val);
            }
            functl.Dispose();
            return rs;
        }
        private void btnSetup_Click(object sender, EventArgs e)
        {

            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    var usr = entity.JINSHINFINANCE018.Where(o => o.UsrNo == lblNoVal.Text).FirstOrDefault();
                    int pwr = (lstPower.SelectedItem as NameValues).idx;
                    //var jw7 = entity.JINSHINFINANCE007.ToList();
                    //var deptJobs = entity.JINSHINFINANCE007.Where(o => o.DeptNo == deptno && o.JobPower == pwr 
                    //&& o.SupplyNo == DataClass.deptno_supno).FirstOrDefault();
                    //usr.PosNo = deptJobs.PosNo;
                    usr.Power = pwr;
                    entity.SaveChanges();               
                    //var data = controls.Where(o => o.UsrNo == lblNoVal.Text).FirstOrDefault();
                    //data.PosNo = usr.PosNo;
                }
            }
            //datagrid.CurrentRow.Cells[6].Value = (lstPower.SelectedItem as NameValues).name;
            datagrid.Refresh();
            DisplayQuery();

        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            DisplayQuery();
        }




        private void DisplayQuery()
        {
            string search = txtName.Text.Trim();
            if (lstPower.SelectedItem != null)
                thepower = Convert.ToInt32((lstPower.SelectedItem as NameValues).idx);
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    List<JINSHINFINANCE018> users = default(List<JINSHINFINANCE018>);
                    if (DataClass.username == Project.SuperUser)
                      users = entity.JINSHINFINANCE018.Where(o => (o.IDName.ToUpper().IndexOf( search.ToUpper()) !=-1 || search == null || search == "")).ToList();
                    else
                      users = entity.JINSHINFINANCE018.Where(o => o.SupplyNo == DataClass.SupplyNo && (o.IDName.ToUpper().IndexOf(search.ToUpper()) !=-1
                      || search == null || search == "")).ToList();
                    DisplayData(users,DataClass.deptno_supno);
                }
            }
        }

        public void SetItemIndex(int power)
        {
            NameValues val = new NameValues() { name = manager[power], idx = power };
            lstPower.SelectedItem = val;
            lstPower.SelectedIndex = lstPower.FindStringExact(manager[power]);
            gridviewctl.SetDataGridView(datagrid);
            
        }

        private void datagrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    string userno = datagrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                    var usr = entity.JINSHINFINANCE018.Where(o => o.UsrNo == userno).FirstOrDefault();
                    userno = usr.UsrNo;
                    username = usr.UserName;
                    lblNoVal.Text = userno;
                    lblNameVal.Text = username;
                  //  var val =depts.Where(o => o.PosNo == usr.PosNo && o.SupplyNo == DataClass.deptno_supno).FirstOrDefault();

                    SetItemIndex(DataClass.power.Value);
                }
            }
        }

        private void datagrid_SelectionChanged(object sender, EventArgs e)
        {
         
        }

        private void datagrid_MouseClick(object sender, MouseEventArgs e)
        {
           // SetCell(sender);
        }

        private void SetCell(object sender)
        {
            int index = (sender as DataGridView).CurrentRow.Index;
            gridviewctl.idx = index;
        }

        private void datagrid_MouseDown(object sender, MouseEventArgs e)
        {
        //    SetCell(sender);
        }

        private void datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         //   SetCell(sender);
        }

        private void datagrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
          //  SetCell(sender);
        }

        private void txtName_KeyUp(object sender, KeyEventArgs e)
        {
            DisplayQuery();
        }

        private void datagrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                if (e.Value != null)
                {
                    int pwr = Convert.ToInt32(e.Value);
                    var jin16data = jin16.Where(v => v.Power == pwr).FirstOrDefault();
                    if (jin16data != null)
                    {
                        e.Value = jin16data.PName;
                    }
                }              
            }
        }

        private void lstPower_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  if (lstPower.SelectedItem != null)
             
        }
    }
}
