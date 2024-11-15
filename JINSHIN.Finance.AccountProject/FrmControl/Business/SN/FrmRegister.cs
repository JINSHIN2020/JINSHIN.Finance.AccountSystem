using FinanceAccountProgram.Models.Config;
using JINSHIN.BUSINESS.LIBARY.Base;
using JINSHIN.BUSINESS.LIBARY.Sercurity;
using JINSHIN.Finance.AccountSystem.Config;
using JINSHIN.FinanceAccount.Libary.VModels.AccControl;
using JINSHIN.FinanceAccounting.DB;
using JINSHIN.FinanceAccounting.DB.VModel;
using JINSHIN.RegProcess.Liary.Content.Register.Sercurity;
using JINSHIN.WORK.Resource;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JINSHIN.Finance.AccountSystem.FrmControl.Business.SN
{
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            using (SercurityControl control = new SercurityControl())
            {
                DevInfo dev = control.GetPhyData();
                string pass = ProjectData.DataPass;
                string val01 = SSTCryptographer.SetCryLink(dev.devdata, pass);
                string val02 = SSTCryptographer.SetCryLink(dev.hostname, pass);
                //val = SSTCryptographer.GetCryLink(val, pass);
                using (AccountEntityDB content = new AccountEntityDB())
                {
                    using (AccountEntities entity = content.GetEntity())
                    {
                        int month = 0;
                        var val = entity.JINSHINFINANCE030.Where(i => i.IdNo == txtIds.Text).FirstOrDefault();
                        if (val == null)
                        {
                            JINSHINFINANCE030 data = new JINSHINFINANCE030();
                            data.OUID = DataClass.OUID;
                            data.UsrNo = DataClass.usrno;
                            data.A01 = val01;
                            data.A02 = val02;
                            data.SnNum = "";
                            data.IdNo = txtIds.Text;
                            data.CDate = DateTime.Now;
                            data.Supply = txtCompanyName.Text;
                            int.TryParse(txtMonths.Text,out month);
                            data.RegMonth = month;
                          //  data.
                            entity.JINSHINFINANCE030.Add(data);
                            entity.SaveChanges();
                            MessageBox.Show("完成!");
                        }
                        else
                            MessageBox.Show("資料已儲存!");
                    }
                }
            }
        }

        private void FrmRegister_Shown(object sender, EventArgs e)
        {
            using (SercurityControl control = new SercurityControl())
            {
                DevInfo dev = control.GetPhyData();
                txtComputerName.Text = dev.hostname;
                string macadr = dev.devdata;
                txtm01.Text = macadr.Substring(0, 2);
                txtm02.Text = macadr.Substring(2, 2);
                txtm03.Text = macadr.Substring(4, 2);
                txtm04.Text = macadr.Substring(6, 2);
                txtm05.Text = macadr.Substring(8, 2);
                txtm06.Text = macadr.Substring(10, 2);
            }
            SysRescControlVModel.SetFixedWindow(this);
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
