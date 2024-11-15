using CardClick.Logs;
using CardClick.Model.User;
using CardClick.VModel;
using CardClick.VModel.Base;
using CardClick.VModel.Frm;
using CardClick.VModel.Frm.User;
using JINSHIN.Business.DataBase;
using JINSHIN.BUSINESS.ATTENDANCE.Config;
using JINSHIN.BUSINESS.ATTENDANCE.Models.Sys;
using JINSHIN.BUSINESS.ATTENDANCE.VModels.Base;
using JINSHIN.BUSINESS.ATTENDANCE.VModels.Business;
using JINSHIN.BUSINESS.LIBARY.Models.UIControls;
using JINSHIN.BUSINESS.LIBARY.UIControls.JINSHINChart;
using JINSHIN.Interface.Data.Services.File;
using JINSHIN.Interface.Data.Services.User;
using JINSHIN.Work.TimeSystem;
using JINSHIN.Work.TimeSystem.DataFile;
using JINSHIN.Work.TimeSystem.VModel.Business;
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
    public partial class FrmRegUser02 : Form
    {
        private OrgControl orgctl { get; set; }
        public UIMsgControl uimsgctl { get; set; }
        public int supplyno { get; set; }
        public int testint { get; set; }
        public FrmRegUser02()
        {
            InitializeComponent();
            uimsgctl = new UIMsgControl();
            usermodel = new UserVModel();
            orgctl = new OrgControl();

        }
        public UserVModel usermodel { get; set; }

        public bool CheckData()
        {
            if (string.IsNullOrEmpty(txtCompanyName.Text))
            {
                MessageBox.Show(Project.RegMsg001);
                return false;
            }
            else if (string.IsNullOrEmpty(txtIDName.Text))
            {
                MessageBox.Show(Project.RegMsg002);
                return false;
            }
            else if (string.IsNullOrEmpty(txtNickName.Text))
            {
                MessageBox.Show(Project.RegMsg003);
                return false;
            }
            else if (string.IsNullOrEmpty(txtusername.Text))
            {
                MessageBox.Show(Project.RegMsg005);
                return false;
            }
            else if (string.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show(Project.RegMsg009);
                return false;
            }
            else if (string.IsNullOrEmpty(txtAge.Text))
            {
                MessageBox.Show(Project.RegMsg008);
                return false;
            }
            return true;
        }
        private void btnADD_Click(object sender, EventArgs e)
        {
            if (!CheckData())
                return;
            if (uimsgctl.GetMailFormat(txtUsrEMail.Text))
                return;
            List<NameValues> vals = new List<NameValues>();
            FunctionControl func = new FunctionControl();
            UserInfoVModel servercontrol = new UserInfoVModel();
            CTAREGUSERap user = new CTAREGUSERap();
            user.username = txtusername.Text;
            if (comJobs.SelectedIndex == -1)
            {
                MessageModel.ShowMsg(ProjectResource.AddJobMsg, MessageType.MsgBox).Wait();
                return;
            }
            if (!servercontrol.CheckNameHas(user))
            {
                return;
            }
            try
            {
                foreach (var item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        TextBox txtcontrol = item as TextBox;
                        NameValues val = new NameValues();
                        val.name = txtcontrol.Name.Replace("txt", "");
                        val.dbvalue = txtcontrol.Text;
                        vals.Add(val);
                    }
                    usermodel.GetGroupBoxItem(vals, item);
                }              
                func.SetClassObj<CTAREGUSERap>(user, vals);               
                if (!string.IsNullOrEmpty(picphoto.ImageLocation))
                {
                    byte[] photo = CtlViewModel.GetJpgBytes(picphoto);
                    // File.ReadAllBytes(picphoto.ImageLocation);
                    user.photo = photo;
                }
                user.Regdate = DateTime.Now;
                user.Power = (comJobs.SelectedItem as JINSHINWORK007).JobPower.Value;
                user.deptno = (comDepts.SelectedItem as JINSHINWORK006).DeptNo;
                user.jobid = (comJobs.SelectedItem as JINSHINWORK007).JobID;
                user.CardType = 1;
                using (TableFrmNo formdata = new TableFrmNo())
                {
                    
                    using (EntityDB dbentity = new EntityDB())
                    {
                        using (InfoSysEntities entity = dbentity.GetEntity())
                        {
                            var supply = entity.JINSHINWORK012.Where(o => o.Supply == txtCompanyName.Text).FirstOrDefault();
                            int formid = entity.JINSHINWORK008.Where(o => o.FormTitle == Project.SnForm).FirstOrDefault().FormSn;
                            var codedata = default(JINSHINWORK004);
                            var machine = default(JINSHINWORK010);
                            if (supply != null)
                            {
                                codedata = entity.JINSHINWORK004.Where(o => o.SupplyNo == supply.No && o.FrmSn == formid).FirstOrDefault();
                                machine = entity.JINSHINWORK010.Where(o => o.No == 1).FirstOrDefault();
                            }
                            CTATableDataNo dataap = new CTATableDataNo();
                            if (codedata != null)
                            {
                                dataap.Num = codedata.Num.Value;
                                dataap.Title = codedata.SugKey ?? "";
                                if (supply != null)
                                    dataap.SupplyNo = supply.No;
                                user.GNO = string.IsNullOrEmpty(codedata.SugKey) ? supply.GNo.ToString() : "";
                                user.NoCode = codedata.SugKey == null || codedata.SugKey == "";
                            }
                            else
                            {
                                dataap.Num = WindowSettings.RegNoNum;
                                dataap.Title = "";                                
                                if (supply != null)
                                    dataap.SupplyNo = supply.No;
                                user.NoCode = true;
                                //if (codedata == null)
                                //    dataap.GNO = string.IsNullOrEmpty(supply.SugKey) ? supply.GNo.ToString() : "";
                            }
                            dataap.TableInt = 1;
                            user.SupplyNo = supply == null ? null : supply.No;
                            user.usrno = formdata.GetTableNo(dataap);
                            dataap.Dispose();
                        }
                    }
                  
                }
              //  user.clas
                bool exceptionrs =servercontrol.PostRegData(user);
                if (!exceptionrs)
                {
                    MessageModel.ShowMsg(ProjectResource.RegDeptValidMsg, MessageType.MsgBox).Wait();
                }
            }
            catch (Exception ex)
            {
                LogControl.LogAlarm(ex.ToString());
            }
            finally
            {
                func.Dispose();
                servercontrol.Dispose();
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (openDig.ShowDialog() == DialogResult.OK)
            {
                string filename = openDig.FileName;
                picphoto.ImageLocation = filename;
            }
        }

        private void UserRegFrm_Load(object sender, EventArgs e)
        {

        }

        private void UserRegFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            StatusMsgClass.RefreshForm<UserMgtFrm02>("UserMgtFrm");
        }

        private void FrmRegUser_Load(object sender, EventArgs e)
        {
            DataClass.deptno_supno = Convert.ToInt32(Project.DeptSupply);
            try
            {
                if (supplyno != -1)
                {
                    using (OrgControl orgctl = new OrgControl())
                    {
                        txtCompanyName.Text = orgctl.GetCompanyName(supplyno);
                    }
                    using (OrgControl orgctl = new OrgControl())
                    {
                        orgctl.BuildeOrgDeptData(comDepts, DataClass.deptno_supno);
                    }
                }
                else
                {
                    EmptyDeptData();
                }
                comDepts.SelectedIndex = 2;
                comJobs.SelectedIndex = 2;
            }
            catch (Exception ex)
            {
                LogControl.LogAlarm(ex.ToString());
            }
        }

        private void EmptyDeptData()
        {
            comDepts.DataSource = null;
            comDepts.Refresh();
            comJobs.DataSource = null;
            comJobs.Refresh();
        }

        private void comJobs_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comDepts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comDepts.DataSource == null)
            {
                MessageBox.Show(Project.RegSupply);
            }
            using (OrgControl ctl = new OrgControl())
            {
                comJobs.DataSource = null;
                ctl.BuildeOrgJobData(comDepts, comJobs, DataClass.deptno_supno);
            }
        }

        private void FrmRegUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            StatusMsgClass.RefreshForm<UserMgtFrm02>("UserMgtFrm");
        }

        private void txtCompanyName_Leave(object sender, EventArgs e)
        {
            using (OrgControl orgctl = new OrgControl())
            {
                orgctl.BuildeOrgDeptData(comDepts, DataClass.deptno_supno);
            }        
            //if ((testint % 2) == 0)
            //{
            //    using (OrgControl orgctl = new OrgControl())
            //    {
            //        orgctl.BuildeOrgDeptData(comDepts, DataClass.deptno_supno);
            //    }
            //}
            //else
            //{
            //    comDepts.DataSource = null;
            //    comDepts.Refresh();
            //}
        }

        private void comDepts_DropDown(object sender, EventArgs e)
        {            
            //if (string.IsNullOrEmpty(txtCompanyName.Text))
            //{
            //    MessageBox.Show("請輸入公司名稱");
            //    comDepts.DroppedDown = false;
            //    return;
            //}
        }

        private void txtIDName_TextChanged(object sender, EventArgs e)
        {
            txtNickName.Text = txtIDName.Text;
        }
    }
}
