
using CardClick.Model.User;
using JINSHIN.Business.DataBase;
using JINSHIN.BUSINESS.LIBARY.Base;
using JINSHIN.BUSINESS.LIBARY.Events;
using JINSHIN.BUSINESS.LIBARY.Models.UIControls;
using JINSHIN.FinanceAccount.Libary.VModels.Users;
using JINSHIN.FinanceAccount.Libary.VModels.Users.Resc;
using JINSHIN.FinanceAccounting.DB;
using JINSHIN.Interface.Data.Services.User;
using JINSHIN.RegProcess.Liary.Content.Register.Base;
using JINSHIN.RegProcess.Liary.Content.Register.Users;
using JINSHIN.Work.TimeSystem;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CardClick.User
{
    public partial class UserUpdateFrm02 : Form
    {
        public string OUID { get; set; }
        public int posno { get; set; }
        public int dept_spply { get; set; }
        private OrgControl orgctl { get; set; }
        private UserFrmModel servercontrol { get; set; }
        public UIMsgControl uimsgctl { get; set; }
     //   public int deptno { get; set; }
        public UserUpdateFrm02(DataGridView dg,int deptno,int fdeptno_supply)
        {
            InitializeComponent();
            uimsgctl = new UIMsgControl();
            servercontrol = new UserFrmModel(dg,deptno,fdeptno_supply);
            orgctl = new OrgControl();
        }

        private void UserUpdateFrm_Load(object sender, EventArgs e)
        {
            FunctionControl fcontrol = new FunctionControl();
            try
            {
                UserInfoModel ap = new UserInfoModel() { OUID = OUID };
                CTAUSERrs data = servercontrol.GetUserInfoData(ap);
                if (data != null)
                {
                    List<NameValues> vals = fcontrol.GetClassDBObj<CTAUSERrs>(data);
                    if (vals.Count > 0)
                    {
                        FunctionControl func = new FunctionControl();
                        servercontrol.SetFormControls(func, vals, this.Controls);
                        func.Dispose();
                    }
                    txtNickNameVal.Text = data.NickName;
                    if (data.Gender)
                    {
                        rdMan.Checked = true;
                    }
                    else
                        rdFemal.Checked = true;

                    if (data.Photo != null)
                    {
                        if (data.Photo.Length > 0)
                        {
                            MemoryStream mstream = new MemoryStream(data.Photo);
                            Image img = Image.FromStream(mstream);
                            picphoto.Image = img;
                        }
                    }
                    txtDescriptionVal.Text = data.Description;
                }
                using (OrgControl orgctl = new OrgControl())
                {
                    orgctl.BuildeOrgDeptData(comDepts,DataClass.deptno_supno);
                    if (posno != -1)
                      orgctl.SetDeptJobData( posno, comDepts, comJobs,DataClass.deptno_supno);
                }
            }
            catch (Exception ex)
            {
                LogControl.LogAlarm(ex.ToString());
            }
            finally
            {
                fcontrol.Dispose();
            }
        }

        /// <summary>
        /// except controls
        /// </summary>
        /// <param name="vals"></param>
        private void SetFormControl(List<NameValues> vals)
        {
            DateTime Date = Convert.ToDateTime(vals.Where(o => o.name == "DevCdate").FirstOrDefault().dbvalue);
            bool autocall = Convert.ToBoolean(vals.Where(o => o.name == "AutoCall").FirstOrDefault().dbvalue);
            bool multiple = Convert.ToBoolean(vals.Where(o => o.name == "Multiple").FirstOrDefault().dbvalue);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (uimsgctl.GetMailFormat(txtUsrEMailVal.Text))
                    return;
                CTAREGUSERap user_ap = new CTAREGUSERap();
             //   user_ap.deptno = (comDepts.SelectedItem as JINSHINFINANCE006).DeptNo;
                user_ap.jobid = (comJobs.SelectedItem as JINSHINFINANCE007).JobID;
                var data = servercontrol.UpdateFunction(user_ap,OUID, this, picphoto, txtNickNameVal.Text);//.Result;
                if (!data)
                {
                    MessageModel.ShowMsg(ProjectResource.RegDeptValidMsg, MessageType.MsgBox).Wait();
                    user_ap.Dispose();
                    return;
                }            
                StatusMsgClass.RefreshForm<UserMgtFrm02>("UserMgtFrm");
                MessageModel.ShowMsg(ProjectResource.UpdateOk,MessageType.MsgBox).Wait();
            }
            catch (Exception ex)
            {
                LogControl.LogAlarm(ex.ToString());
                MessageModel.ShowMsg(ProjectResource.UpdateFail, MessageType.MsgBox).Wait();
            }
        }

        private void UserUpdateFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            StatusMsgClass.RefreshForm<UserMgtFrm02>("UserMgtFrm");
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (openDig.ShowDialog() == DialogResult.OK)
            {
                string filename = openDig.FileName;
                picphoto.ImageLocation = filename;
            }
        }

        private void comDepts_SelectedValueChanged(object sender, EventArgs e)
        {
            using (OrgControl ctl = new OrgControl())
            {
              ctl.BuildeOrgJobData(comDepts, comJobs, DataClass.deptno_supno);
            }
        }
    }
}
