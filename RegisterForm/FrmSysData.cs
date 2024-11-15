
using JINSHIN.Business.DataBase;
using JINSHIN.BUSINESS.LIBARY.Sercurity;
using JINSHIN.Finance.AccountSystem.Config;
using JINSHIN.FinanceAccount.Libary.VModels.AccControl;
using JINSHIN.FinanceAccount.Libary.VModels.Config;
using JINSHIN.FinanceAccounting.DB;
using JINSHIN.FinanceAccounting.DB.VModel;
using JINSHIN.RegProcess.Liary.Content.Register;
using JINSHIN.RegProcess.Liary.UIControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace JINSHIN.Finance.AccountSystem.RegisterForm
{
    public partial class FrmSysData : Form
    {
        private List<TextBox> txts { get; set; }
        public UIMsgControl uimsgctl { get; set; }
        public FrmSysData()
        {
            InitializeComponent();
            uimsgctl = new UIMsgControl();
            txts = new List<TextBox>();
            txts.Add(txtadr01);
            txts.Add(txtadr02);
            txts.Add(txtadr03);
            txts.Add(txtadr05);
        }

        private void FrmSysData_Load(object sender, EventArgs e)
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    try
                    {
                        using (SysSettingCtl ctl = new SysSettingCtl())
                        {
                            string srvadr = ctl.LoadData(Project.SrvDataName);
                            WindowSetting.SrvIP = srvadr;
                            string[] vals = srvadr.Split('.');
                            for (int i = 0; i < vals.Length; i++)
                            {
                                txts[i].Text = vals[i];
                            }
                        }
                    }
                    finally
                    {
                        entity.Dispose();
                    }
                }
            
            }          
        }

        private void btnSaveAdrData_Click(object sender, EventArgs e)
        {
            string adrdata = "";
            for (int i = 0; i < txts.Count; i++)
            {
                if (uimsgctl.GetALLNumFormat(txts[i].Text))
                {
                    return;
                }
            }
            for (int i = 0; i < txts.Count -1; i++)
            {
                adrdata += txts[i].Text += ".";
            }
            adrdata += txts[3].Text;
            using (SysSettingControl ctl = new SysSettingControl())
            {
                ctl.SaveData(adrdata, Project.SrvDataName);
                WindowSetting.SrvIP = adrdata;
                MessageBox.Show("完成");
            }
#if (DEBUG)
            WindowSetting.SrvIP = adrdata;
            WindowSetting.OnServiceWeb = adrdata + WindowSetting.OnServicePort;
            //WindowSetting.SrvIP = srvadr;
            //WindowSetting.OnServiceWeb = srvadr + WindowSetting.OnServicePort;
#endif

        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            using (SysSettingControl ctl = new SysSettingControl())
            {
                ctl.SaveData(Project.SrvPoint, Project.SrvDataName);
                WindowSetting.SrvIP = Project.SrvPoint;
                MessageBox.Show("完成");
            }
        }

        private void FrmSysData_Shown(object sender, EventArgs e)
        {
            SysRescControlVModel.SetFixedWindow(this);
        }
    }
}
