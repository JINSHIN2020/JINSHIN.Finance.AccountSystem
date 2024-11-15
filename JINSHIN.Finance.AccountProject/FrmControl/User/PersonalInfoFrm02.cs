using CardClick.Logs;
using CardClick.Model.User;
using CardClick.VModel.Frm.User;
using JINSHIN.Business.DataBase;
using JINSHIN.BUSINESS.LIBARY.Models.UIControls;
using JINSHIN.Interface.Data.Services.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardClick.User
{
    public partial class PersonalInfoFrm02 : Form
    {
        public string OUID { get; set; }
        private UserVModel usermodel { get; set; }
        private UserInfoVModel servercontrol { get; set; }
        public PersonalInfoFrm02()
        {
            InitializeComponent();
            usermodel = new UserVModel();
            servercontrol = new UserInfoVModel();
        }

        private void PersonalInfoFrm_Load(object sender, EventArgs e)
        {
            FunctionControl fcontrol = new FunctionControl();
            try
            {
                UserInfoModel ap = new UserInfoModel() { OUID = OUID };
                JINSHINWORK018 data = servercontrol.GetUserInfoData(ap);
                if (data != null)
                {
                    usermodel.SetUserFormLables(fcontrol, data, this.Controls);
                    if (data.Photo != null)
                    {
                        MemoryStream mstream = new MemoryStream(data.Photo);
                        Image img = Image.FromStream(mstream);
                        picPhoto.Image = img;
                    }
                    txtDescription.Text = data.Description;
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
    }
}
