using FinanceAccountProgram.Models.Config;
using JINSHIN.Business.DataBase;
using JINSHIN.BUSINESS.LIBARY.Base;
using JINSHIN.BUSINESS.LIBARY.Sercurity;
using JINSHIN.FinanceAccount.Libary.VModels.AccControl;
using JINSHIN.FinanceAccounting.DB;
using JINSHIN.FinanceAccounting.DB.VModel;
using JINSHIN.RegProcess.Liary.Content.Register.VModel.SN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceAccountProgram.FrmControl.Business
{
    public partial class FrmAboutLicense : Form
    {
        public FrmAboutLicense()
        {
            InitializeComponent();
        }

        private void gbcontent_Enter(object sender, EventArgs e)
        {

        }

        private void FrmAboutLicense_Load(object sender, EventArgs e)
        {
            int buytype = 0;
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    string snnum = "";
                    using (RegisterModel registermodel = new RegisterModel())
                    {
                        snnum = registermodel.GetSNName(RegisterSys.JINSHIN_FINANCE);
                    }
                    var supply = entity.JINSHINFINANCE012.Where(o => o.No == DataClass.SupplyNo)
                        .FirstOrDefault();
                    lblBuyCompany.Text = supply.Supply;
                    if (!DataClass.TrailLicense)
                    {
                        var devdata = entity.JINSHINFINANCE024.Where(o => o.Supply == DataClass.SupplyNo
                        && o.IsVerify == true).FirstOrDefault();
                    
                        var data01 = entity.JINSHINFINANCE028.Where(o => o.SnNum == snnum
                        && o.W02806 == true).OrderByDescending(v => v.CDate).ToList();

                        var data02 = entity.JINSHINFINANCE027.Where(o => o.SnNum == snnum
                        && o.IsCheck == true).FirstOrDefault();
                       

                        lblbuy.Text = "";
                        lblCopyrighttime.Text = "";
                        
                        lblReg.Text = "";
                        lbllicenseType.Text = "";
                        if (devdata != null)
                        {
                            lblReg.Text = devdata.CDate.Value.ToString("yyyy/MM/dd");
                        }
                        string buytime = "";                  
                        try
                        {
                            if (data02 != null)
                            {
                                buytype = 2;
                                buytime = data02.CDate.Value.ToString("yyyy/MM/dd");
                            }
                            else if (data01 != null)
                            {
                                foreach (var item in data01)
                                {
                                    buytime = Convert.ToDateTime(SSTCryptographer.GetSSTCryLink(item.W02804,
                                        DataClass.A05)).ToString("yyyy/MM/dd");
                                    buytype = 1;
                                    string endtime = Convert.ToDateTime(SSTCryptographer.GetSSTCryLink(item.W02805,
                                        DataClass.A05)).ToString("yyyy/MM/dd");
                                    lblCopyrighttime.Text = endtime;
                                }
                            }                        
                        }
                        catch (Exception ex)
                        {

                        }
                        lblbuy.Text = buytime;
                    }
                    else
                    {
                        buytype = 3;
                    }
                    switch (buytype)
                    {
                        case 1: { lbllicenseType.Text = "租用型"; } break;
                        case 2: { lbllicenseType.Text = "永久購買";
                                  lblCopyrighttime.Text = "沒有限制，除合約額外製定之條款例外";
                            } break;
                        case 3: 
                            {
                                lbllicenseType.Text = "試用";
                                lblCopyrighttime.Text = DataClass.Traildate.ToString("yyyy/MM/dd");
                                lblReg.Text = "試用";
                                lblbuy.Text = "試用";
                            }break;
                        default:;                           
                            break;
                    }
                    
                }
            }


           
        }

        private void lblbuy_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmAboutLicense_Shown(object sender, EventArgs e)
        {
            SysRescControlVModel.SetFixedWindow(this);
        }
    }
}
