
using JINSHIN.BUSINESS.LIBARY.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceAccountProgram.VModel.FormMaintain
{
    public class FormControlVModel:JBase
    {
        /// <summary>
        /// 0:Hide
        /// 1:Show
        /// 2:Close
        /// </summary>
        /// <param name="formname"></param>
        /// <param name="formstatus"></param>
        public Form ControlFormStatus(string formname, int formstatus)
        {
            Form frm = null;
            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                if (Application.OpenForms[i].Name == formname)
                {
                    if (formstatus == 1)
                    {
                        Application.OpenForms[i].Show();                      
                    }
                    else if (formstatus == 2)
                    {
                        Application.OpenForms[i].Close();
                    }
                    else if (formstatus == 0)
                    {
                        Application.OpenForms[i].Hide();
                    }
                    return Application.OpenForms[i];
                }
            }
            return frm;
        }

      
        public Form FindForm(string formname)
        {
            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                if (Application.OpenForms[i].Name.ToUpper() == formname.ToUpper())
                {
                    return Application.OpenForms[i] as Form;
                }
            }
            return default(Form);
        }

        /// <summary>
        /// 先關掉非主表單的表單
        /// </summary>
        /// <param name="mainform"></param>
        /// <returns></returns>
        public bool CloseForms(string mainform)
        {
            try
            {
                for (int i = 0; i < Application.OpenForms.Count; i++)
                {
                    if (Application.OpenForms[i].Name.ToUpper() != mainform.ToUpper())
                    {
                        Application.OpenForms[i].Close();
                    }
                }
                for (int i = 0; i < Application.OpenForms.Count; i++)
                {
                    if (Application.OpenForms[i].Name.ToUpper() == mainform.ToUpper())
                    {
                        Application.OpenForms[i].Close();
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }


    }
}
