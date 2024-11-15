using FinanceAccountProgram.Models;
using JINSHIN.BUSINESS.LIBARY.Models;
using JINSHIN.BUSINESS.LIBARY.Base;
using JINSHIN.BUSINESS.LIBARY.Models.UControl.Frm;
using JINSHIN.BUSINESS.LIBARY.VModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceAccountProgram.VModel.Conrols.ManageForm
{
    public class FormControlVModel : JBase
    {
        public void ControlResolution(Form frm)
        {
            using (SystemControl syscontrol = new SystemControl())
            {
                CustomFrmDgn custDgn = syscontrol.GetResolution(frm);
                syscontrol.LoadControlFromRes(frm, custDgn.value);
            }
        }

        public void ControlResolutionPageUserData(Form frm,string userctl,string lstname,List<string> names)
        {
            using (SystemControl syscontrol = new SystemControl())
            {
                CustomFrmDgn custDgn = syscontrol.GetResolution(frm);
                syscontrol.LoadControlFromUserRes(frm, custDgn.value, userctl, custDgn.value,lstname);
        //        syscontrol.LoadUserControlFrmLst(frm, userctl, custDgn.value, lstname);
            }
        }

        public void ControlResolutionUserControl(Form frm, string userctl)
        {
            using (SystemControl syscontrol = new SystemControl())
            {
                CustomFrmDgn custDgn = syscontrol.GetResolution(frm);
                syscontrol.LoadUserControlFromRes(frm,userctl, float.Parse(ControlModel.parpam03.ToString()));
            }
        }
    }
}
