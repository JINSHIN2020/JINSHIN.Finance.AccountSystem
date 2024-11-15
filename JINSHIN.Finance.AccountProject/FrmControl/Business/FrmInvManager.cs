using FinanceAccountProgram.Models;
using FinanceAccountProgram.Models.Config;
using FinanceAccountProgram.Models.Config.UpdataeForm;
using FinanceAccountProgram.Models.UpdateForm;
using FinanceAccountProgram.VModel;
using FinanceAccountProgram.VModel.AddQueryForm;
using FinanceAccountProgram.VModel.UsrControl;
using JINSHIN.BUSINESS.LIBARY.Models.UControl.Frm;
using JINSHIN.BUSINESS.LIBARY.VModel;
using JINSHIN.FinanceAccount.Libary.Models.Base;
using JINSHIN.FinanceAccount.Libary.VModels.AccControl;
using System;
using System.Windows.Forms;

namespace FinanceAccountProgram.FrmControl
{
    public partial class FrmInvManager : Form
    {
        public DBClassCtl dbclassctl { get; set; }
        public PathModel pathmodel { get; set; }
        public FrmInvManager()
        {
            InitializeComponent();
            dbclassctl = new DBClassCtl();
            pathmodel = new PathModel();            
            using (SystemControl syscontrol = new SystemControl())
            {               
                CustomFrmDgn custDgn = syscontrol.GetResolution(this);
                double val = 0;
                if (custDgn.name == "1920")
                    val = 1.2;
                else if (custDgn.name == "1366")
                    val = 2.5;
                else
                    val = 1.2;
                syscontrol.LoadControlFrmLst(this, custDgn.value, "lstUpdateMonths", val);
                SysRescControlVModel.Let1366ToMaxWindowSize(this,false);
            }
        }

      

        private void updateListForm1_Load(object sender, EventArgs e)
        {

        }


        private void SetListBox(ListBox ctl, string name, string no)
        {
            ctl.DisplayMember = name;
            ctl.ValueMember = no;
        }
        private void FrmInvManager_Shown(object sender, EventArgs e)
        {
            using (UpdateFormVModel updatemodel = new UpdateFormVModel(updateVerifyAcc.dgdataview, 
                AddQueryEnum.Acc_VerifyCostData, UpdateFormEnum01.None))
            {
                #region Variable init 
                updateVerifyAcc.datatype = AddQueryEnum.Acc_VerifyCostData;
                updateVerifyAcc.ctl01 = new Acc_CostDataQuery();
                updateVerifyAcc.ctl01.dbclass = dbclassctl;
                updateVerifyAcc.dataUpdateCenter = pathmodel.dataUpdateCenter;
                #endregion
                updateVerifyAcc.SetInit(updatemodel);
                updateVerifyAcc.listboxs[0].DataSource = dbclassctl.GetAcc_Class();
                SetListBox(updateVerifyAcc.listboxs[0], "Name", "No");
                updateVerifyAcc.listboxs[1].DataSource = dbclassctl.GetAcc_ContentClass();
                SetListBox(updateVerifyAcc.listboxs[1], "Name", "No");
                updateVerifyAcc.listboxs[2].DataSource = dbclassctl.QueryInv_Class();
                SetListBox(updateVerifyAcc.listboxs[2], "Name", "No");
                FormConfig.CostItemInitCnt =  Convert.ToInt32(updateVerifyAcc.Cnt);
                SysRescControlVModel.SetFixedWindow(this);
            }
        }

        private void FrmInvManager_Load(object sender, EventArgs e)
        {

        }
    }
}
