using JINSHIN.FinanceAccount.Libary.VModels.AccControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceAccountProgram.FrmControl.Business.Dialog
{
    public partial class ResturantDlg : Form
    {
        public ResturantDlg()
        {
            InitializeComponent();
        }

        private void ResturantDlg_Shown(object sender, EventArgs e)
        {
            SysRescControlVModel.SetFixedWindow(this);
        }

        //public List<Acc_AffairsSetup> QueryAffairsDataModel(List<Acc_AffairsSetup> data, List<NameValues> keys)
        //{
        //    List<Acc_AffairsSetup> rs = new List<Acc_AffairsSetup>();
        //    foreach (var item in data)
        //    {
        //        if (control.SearchKeysInClass<Acc_AffairsSetup>(item, keys))
        //            rs.Add(item);
        //    }
        //    return rs;
        //}
    }
}
