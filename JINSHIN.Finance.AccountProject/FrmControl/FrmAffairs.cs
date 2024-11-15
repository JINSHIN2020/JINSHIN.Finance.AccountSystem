using FinanceAccountProgram.Models.Config;
using FinanceAccountProgram.Models.UControl;
using FinanceAccountProgram.Models.UpdateForm;
using JINSHIN.Finance.AccountSystem.Resources;
using JINSHIN.FinanceAccounting.DB;
using FinanceAccountProgram.ViewFrm;
using FinanceAccountProgram.VModel;
using FinanceAccountProgram.VModel.Affairs;
using FinanceAccountProgram.VModel.Conrols;
using FinanceAccountProgram.VModel.Conrols.QueryModel;
using FinanceAccountProgram.VModel.UsrControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinanceAccountProgram.VModel.Conrols.ManageForm;
using JINSHIN.BUSINESS.LIBARY.UIControls.GridView;
using JINSHIN.BUSINESS.LIBARY.VModel;
using JINSHIN.FinanceAccount.Libary.Config;
using JINSHIN.FinanceAccount.Libary.VModels;
using JINSHIN.FinanceAccounting.DB.VModel;
using JINSHIN.FinanceAccount.Libary.VModels.AccControl;

namespace FinanceAccountProgram.FrmControl
{
    public partial class FrmAffairs : Form
    {
        public List<Button> btns { get; set; }
        public List<string> titles { get; set; }
        public UpdateFormEnum01 uftype01 { get; set; }
        public int uftypeval { get; set; }
        public List<int> diffcnt { get; set; }
        public GridViewBase gvbase { get; set; }
        public MoneyVModel moneymodel { get; set; }
        public DataParams params01 { get; set; }
        public UpdateFormVModel model { get; set; }       
        private PathModel pathmodel { get; set; }
        public FrmAffairs()
        {
            InitializeComponent();
            btns = new List<Button>();
            pathmodel = new PathModel();         
        }

        private void btnclick(object sender, EventArgs e)
        {
            int datalink = Convert.ToInt32((sender as Button).Tag);
            AffairsFormDlg idatafrm = new AffairsFormDlg();
            idatafrm.datalink = datalink;
            bool Nodata = idatafrm.SetInit();
            if (!Nodata)
              idatafrm.Show();
        }

     

        private void FrmAffairs_Shown(object sender, EventArgs e)
        {
            SysRescControlVModel.SetFixedWindow(this);
        }

        private void plControls_Paint(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        /// titles 顯示buttons文字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAffairs_Load(object sender, EventArgs e)
        {
            if (AccountingReso.yearnow == 0)
            {
                AccountingReso.yearnow = DateTime.Now.Year;
            }
            CreateButtons();
            using (FormControlVModel ctlmodel = new FormControlVModel())
            {
                ctlmodel.ControlResolution(this);
            }
        }

        private void CreateButtons()
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    var accounts = entity.JINSHINFINANCE031.ToList();
                    btns.Clear();
                    foreach (var item in accounts)
                    {
                        Button btn = new Button()
                        {
                            Text = item.DescTitle,
                            Tag = item.SN
                            ,
                            Font = new Font("新細明體", 14)
                        };
                        btn.Click += btnclick;
                        btns.Add(btn);
                    }
                    PanelContrlData plcontrol = new PanelContrlData(plControls, Convert.ToInt32(txtCol.Text), btns.Count);
                    plcontrol.SetButtonInfo(btns, btns.Count, Convert.ToInt32(txtWidth.Text), Convert.ToInt32(txtHeight.Text));
                    plcontrol.ctable.SetTablePoints(plcontrol.MaxContentHeight);
                    plcontrol.PanelAddControl(true, plControls, titles);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CreateButtons();
        }
    }
}
