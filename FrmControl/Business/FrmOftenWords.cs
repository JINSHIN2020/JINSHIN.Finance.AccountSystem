using JINSHIN.Finance.AccountSystem;
using FinanceAccountProgram.Models.UControl;
using JINSHIN.FinanceAccounting.DB;
using FinanceAccountProgram.VModel.Business;
using FinanceAccountProgram.VModel.Conrols.GridView;
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
using FinanceAccountProgram.Controls;
using FinanceAccountProgram.VModel.Conrols.ManageForm;
using JINSHIN.BUSINESS.LIBARY.UIControls.FormMgt.EntityVModel;
using JINSHIN.BUSINESS.LIBARY.UIControls.GridView;
using JINSHIN.BUSINESS.LIBARY.Models.UControl.GView;
using JINSHIN.BUSINESS.LIBARY.Models.UIControls;
using JINSHIN.FinanceAccount.Libary.VModels;
using JINSHIN.FinanceAccounting.DB.VModel;
using JINSHIN.BUSINESS.LIBARY.UIControls.FormUI;
using JINSHIN.FinanceAccount.Libary.VModels.AccControl;

namespace FinanceAccountProgram.FrmControl.Business
{
    public partial class FrmOftenWords : Form
    {
        VAcc_Words wordctl = new VAcc_Words();
        public BaseGridCtl gridviewctl { get; set; }
        public EntityControl control { get; set; }
        public FrmOftenWords()
        {
            InitializeComponent();
            gridviewctl = new BaseGridCtl();
            control = new EntityControl(gridviewctl);
            masterUI1.SetInit();
            masterUI1.MUpdateClick += btnMUpdate_Click;
            masterUI1.MAddClick += btnMADD_Click;
            masterUI1.MQueryClick += btnMQuery_Click;
            masterUI1.MDeleteClick += btnMasterDelete_Click;
            using (FormControlVModel ctlmodel = new FormControlVModel())
            {
                ctlmodel.ControlResolution(this);
            }
        }

        private void masterUI1_Load(object sender, EventArgs e)
        {

        }
        private void btnMasterDelete_Click(object sender, EventArgs e)
        {
            masterUI1.SetMvaluesIns();
            if (masterUI1.mvalues[0].dbvalue != null)
            {
                using (AccountEntityDB content = new AccountEntityDB())
                {
                    using (AccountEntities entity = content.GetEntity())
                    {
                        int sn = Convert.ToInt32(masterUI1.mvalues[0].dbvalue);
                        var data = entity.JINSHINFINANCE042.Where(o => o.No == sn).FirstOrDefault();
                        if (data != null)
                        {
                            entity.JINSHINFINANCE042.Remove(data);
                            entity.SaveChanges();
                        }
                        else
                        {
                            MessageBox.Show(FormCaption.BookConvertCpation01);
                        }

                    }
                }
            }

        }
        private void btnMUpdate_Click(object sender, EventArgs e)
        {
            UpdateOftenWord();
        }

        private void QueryMCondition()
        {
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    List<string> data01 = new List<string>() { "NO", "SNAME" };
                    List<string> data02 = new List<string>() { "I01", "DATA01" };
                    List<JINSHINFINANCE042> data = QueryOftenWordDataModel(entity.JINSHINFINANCE042.ToList(), masterUI1.mvalues);
                    List<DataModel> models = new List<DataModel>();
                    int sn = 1;
                    try
                    {
                        foreach (var item in data)
                        {
                            DataModel dmodel = new DataModel();
                            control.EntityDataClass<JINSHINFINANCE042, DataModel>(item, dmodel, data01, data02);
                            dmodel.Sn = sn;
                            models.Add(dmodel);
                            sn++;
                        }
                    }
                    catch (Exception ex)
                    {
                        LogControl.LogAlarm(ex.ToString(), "常用字詞");
                    }
                    RefreshAcc_Master(models);
                }
            }
        }
        private void btnMADD_Click(object sender, EventArgs e)
        {
            InsertOfftenWordsSetup();
        }
        private void btnMQuery_Click(object sender, EventArgs e)
        {
            masterUI1.SetMvaluesSearch();
            QueryMCondition();
        }
        private void RefreshAcc_Master(List<DataModel> datalist)
        {
            gridviewctl.SetGridColumns<Acc_OfftenWords_DGItem>(masterUI1.dbMasterData, new Acc_OfftenWords_DGItem());
            masterUI1.dbMasterData.DataSource = datalist;
        }

        public void InsertOfftenWordsSetup()
        {
            JINSHINFINANCE042 val = new JINSHINFINANCE042();
            FunctionControl func = new FunctionControl();
            func.SetClassObj<JINSHINFINANCE042>(new List<string>() {"no"},val, masterUI1.mvalues);
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    var data = entity.JINSHINFINANCE042.Where(o => o.SName == val.SName).FirstOrDefault();
                    if (data != null)
                    {
                        MessageBox.Show(FormCaption.BookDescCaption01);
                    }
                    else
                    {
                        val.CDate = DateTime.Now;
                        entity.JINSHINFINANCE042.Add(val);
                        entity.SaveChanges();
                    }
                }
            }
            func.Dispose();
            masterUI1.SetMvaluesSearch();
            QueryMCondition();
        }


        public void UpdateOftenWord()
        {
            JINSHINFINANCE042 val = new JINSHINFINANCE042();
            FunctionControl func = new FunctionControl();
            func.SetClassObj<JINSHINFINANCE042>(val, masterUI1.mvalues);
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    var data = entity.JINSHINFINANCE042.Where(o => o.No == val.No).FirstOrDefault();
                    if (data != null)
                    {
                        data.SName = val.SName;
                        data.UDate = DateTime.Now;
                        //  entity.Acc_AffairsSetup.Add(val);
                        entity.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show(FormCaption.BookDescCaption02);
                    }
                }
            }
            func.Dispose();
            masterUI1.SetMvaluesSearch();
            QueryMCondition();
        }



        public List<DataModel> QueryJINSHINFINANCE042(List<JINSHINFINANCE042> data, List<string> data01, List<string> data02)
        {
            List<DataModel> rs = new List<DataModel>();
            foreach (var item in data)
            {
                DataModel i = new DataModel();
                control.EntityDataClass<JINSHINFINANCE042, DataModel>(item, i, data01, data02);
                rs.Add(i);
            }
            return rs;
        }

        public List<JINSHINFINANCE042> QueryOftenWordDataModel(List<JINSHINFINANCE042> data, List<NameValues> keys)
        {
            List<JINSHINFINANCE042> rs = new List<JINSHINFINANCE042>();
            foreach (var item in data)
            {
                if (control.SearchKeysInClass<JINSHINFINANCE042>(item, keys))
                    rs.Add(item);
            }
            return rs;
        }

        private void FrmOftenWords_Shown(object sender, EventArgs e)
        {
            SysRescControlVModel.SetFixedWindow(this);
        }
    }
}
