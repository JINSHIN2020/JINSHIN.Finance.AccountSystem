using FinanceAccountProgram.Models.AddQueryDataForm;
using FinanceAccountProgram.Models.Config;
using FinanceAccountProgram.Models.UControl;
using FinanceAccountProgram.VModel;
using FinanceAccountProgram.VModel.AddQueryDataForm;
using FinanceAccountProgram.VModel.Money;
using JINSHIN.BUSINESS.LIBARY.UIControls.GridView;
using JINSHIN.Finance.AccountSystem.Models.Models;
using JINSHIN.FinanceAccount.Libary.Models.Base;
using JINSHIN.FinanceAccount.Libary.VModels.AccControl;
using JINSHIN.FinanceAccount.Libary.VModels.GridView;
using JINSHIN.FinanceAccounting.DB;
using JINSHIN.FinanceAccounting.DB.VModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace JINSHIN.Finance.AccountSystem.FrmControl.Business.YearIntegration
{
    public partial class FrmYearIntegration : Form
    {
        public MoneyVModel moneymodel { get; set; }
        public List<JINSHINFINANCE047> jin047 { get; set; }
        public List<JINSHINFINANCE033> select033 { get; set; }
        public List<JINSHINFINANCE035> jin035 { get; set; }
        public List<JINSHINFINANCE035> checked_list { get; set; }     
        public List<JINSHINFINANCE031> jin031 { get; set; }
        public List<JINSHINFINANCE033> jin033 { get; set; }
        public int txtyear { get; set; }
        public PathModel pathmodel { get; set; }
        public BaseGridViewCtl gridviewctl { get; set; }
        public FrmYearIntegration()
        {
            InitializeComponent();
            gridviewctl = new BaseGridViewCtl();
            moneymodel = new MoneyVModel();
            jin047 = new List<JINSHINFINANCE047>();
            jin035 = new List<JINSHINFINANCE035>();
            jin033 = new List<JINSHINFINANCE033>();
            pathmodel = new PathModel();
            select033 = new List<JINSHINFINANCE033>();
            jin031 = new List<JINSHINFINANCE031>();
            checked_list = new List<JINSHINFINANCE035>();
            SysRescControlVModel.Let1366ToMaxWindowSize(this);
        }

        private void gbData_Enter(object sender, EventArgs e)
        {

        }

        private void btnMoney_Click(object sender, EventArgs e)
        {
            DisplayAll();
        }

        private void DisplayAll()
        {
            DataParams params01 = new DataParams();
            try
            { 
                int year = Convert.ToInt32(txtYear.Text);
                int month = Convert.ToInt32(lstMonths.SelectedItem);
                foreach (var item in select033)
                {
                    params01.yiModels.Add(new Models.Models.YearIntegrationModel()
                    {
                        accid = item.Acc_ID,
                        desc = item.Desc02,
                        month =  month,
                        year = year
                    });
                }
                params01.year = year;
                params01.data001.value = 2;
                params01.data006.value = -1;
                params01.data002.value = lstMonths.SelectedIndex + 1;
                params01.data006.value = cokMonMALL.Checked ? 1 : 2;
                MoneyDataShowSet(params01);
            }
            catch (Exception ex)
            {

            }
        }


        private int GetValidItemRec()
        {
            var rec_data = moneymodel.accmodel.ctl03.acc_VerifyItmes.GroupBy(o => o.Rec_Type)
                            .Select(i => new { cnt = i.Sum(o => o.Rec_Type), rec_type = i.First().Rec_Type });
            int rec_check = 0;
            int nowcnt = 0;
            foreach (var t in rec_data)
            {
                if (t.cnt > nowcnt)
                {
                    rec_check = t.rec_type.Value;
                }
                nowcnt = t.cnt.Value;
            }

            return rec_check;
        }



        private JINSHINFINANCE047Flow AnalyzeAccItems(List<JINSHINFINANCE035> data, int Rec_Type)
        {
            JINSHINFINANCE047Flow rs = new JINSHINFINANCE047Flow();
            List<JINSHINFINANCE035> values = new List<JINSHINFINANCE035>();
            foreach (var i in data)
                values.Add(i);
            List<JINSHINFINANCE035> values01 = default(List<JINSHINFINANCE035>);
            List<JINSHINFINANCE035> values02 = default(List<JINSHINFINANCE035>);
            List<JINSHINFINANCE035> values03 = default(List<JINSHINFINANCE035>);
            if (Rec_Type == 11)
            {
                values01 = new List<JINSHINFINANCE035>();
                values02 = new List<JINSHINFINANCE035>();
                values03 = new List<JINSHINFINANCE035>();
            }
            else
            {
                values01 = new List<JINSHINFINANCE035>();
                values02 = new List<JINSHINFINANCE035>();
            }
            var dataval = values.GroupBy(o => new { o.Verify_Month, o.Amount }).ToList();
            if (Rec_Type == 11)
            {
                rs.getCheckItem = dataval.Where(o => o.Count() != 2).Count() > 0;
            }
            else
            {
                rs.getCheckItem = dataval.Where(o => o.Count() != 1).Count() > 0;
            }
            int datacnt = 0;
            JINSHINFINANCE035 item = default(JINSHINFINANCE035);
            foreach (var val in dataval)
            {
                datacnt = val.Count();
                if (Rec_Type == 11)
                {
                    if (datacnt != 2)
                    {
                        if ((datacnt == 1))
                        {
                            if ((val.First().Acc_Desc.IndexOf("去年12月") == -1) && (val.First().Acc_Desc.IndexOf("12月") == -1))
                            {
                                values01.Add(val.First());
                                //  values02.Add(val.First());
                            }
                            else
                            {
                                values01.Add(val.First());
                            }
                        }
                        else values03.Add(val.First());
                    }
                    else
                        foreach (var v in val)
                            values01.Add(v);
                }
                else
                {
                    if (datacnt != 1)
                    {
                        item = val.FirstOrDefault();
                        if (item != null)
                            values02.Add(val.First());
                    }
                    else
                    {
                        foreach (var v in val)
                            values01.Add(v);
                    }
                }
            }
            values01 = values01.OrderBy(o => o.Verify_Month).ToList();
            rs.data01 = values01;
            rs.data02 = values02;
            rs.data03 = values03;
            rs.Rec_Type = Rec_Type;
            return rs;
        }

        private void btnMoneyVeriy_Click(object sender, EventArgs e)
        {         
            try
            {
                    List<JINSHINFINANCE047> veriItem_view = new List<JINSHINFINANCE047>();
                    List<string> acc_no = new List<string>();
                    string verify_accid = "";
                    string cost_accid = "";
                    DateTime verify_dt = default(DateTime);
                    DateTime cost_dt = default(DateTime);
                    bool ischeck = false;
                    foreach (var i in moneymodel.accmodel.ctl03.acc_VerifyItmes)
                    {
                        ischeck = false;
                        for (int v = 0; v < moneymodel.accmodel.ctl03.acc_CostItmes.Count; v++)
                        {
                            moneymodel.accmodel.ctl03.acc_CostItmes[v].Is_Fill = false;
                            verify_dt = i.Acc_Date.Value;
                            cost_dt = moneymodel.accmodel.ctl03.acc_CostItmes[v].Cost_Date.Value;
                            cost_accid = i.Acc_ID;
                            verify_accid = moneymodel.accmodel.ctl03.acc_CostItmes[v].Acc_ID;
                            if ((verify_dt == cost_dt) && (cost_accid == verify_accid))
                            {
                                acc_no.Add(moneymodel.accmodel.ctl03.acc_CostItmes[v].Acc_No);
                                ischeck = true;
                            }
                        }
                        if (!ischeck)
                        {
                           veriItem_view.Add(i);
                        }
                    }

                    List<JINSHINFINANCE035> dstcheck = new List<JINSHINFINANCE035>();
                    List<JINSHINFINANCE035> dstok = new List<JINSHINFINANCE035>();
                    foreach (var no in acc_no)
                    {
                        foreach (var item in moneymodel.accmodel.ctl03.acc_CostItmes)
                        {
                            if (no != item.Acc_No)
                            {
                                dstcheck.Add(item);
                            }
                            else
                            {
                                item.Is_Fill = true;
                                dstok.Add(item);
                            }
                        }
                    }
                dataMoney01.DataSource = null;
                dataMoney01.DataSource = moneymodel.accmodel.ctl03.acc_CostItmes;
                dataMoney02Un.DataSource = null;
                dataMoney02Un.DataSource = veriItem_view;
            }
            catch (Exception ex)
            {

            }

                //var vitem = acc_veriItem.Where(o => o.Acc_ID == txtMCostAccID.Text.Trim()).FirstOrDefault();
                //string accid = vitem.Acc_ID;
                //string countcompare = verifyitem.data01.Count != acc_veriItem.Count 
                //    ? "帳目數量為" + verifyitem.data01.Count.ToString()  + Environment.NewLine + "帳務實際數量為"
                //    + acc_veriItem.Count.ToString() : "";
                //List<string> datamsg = new List<string>();

                //if (!string.IsNullOrEmpty(accid))
                //{
                //    foreach (var item in verifyitem.data01)
                //    {
                //        verifyitem.result = false;
                //        foreach (var it in acc_veriItem)
                //        {
                //            if ((item.Cost_M == 3) && (it.Verify_Month == 3))
                //            {
                //                //  string str = "";
                //            }
                //            content = fc.CheckClassKeyByVal<JINSHINFINANCE035, JINSHINFINANCE047>(cols, item, it);
                //            if (content != "")
                //            {
                //                verifyitem.result = true;
                //                it.isMap = true;
                //                msg = sn.ToString() + "." + content + Environment.NewLine;
                //                msg = msg + "yes";
                //                break;
                //            }
                //            else
                //            {
                //                content = fc.CheckClassKeyByVal<JINSHINFINANCE035, JINSHINFINANCE047>(colsmoney, item, it);
                //                if (content != "")
                //                {
                //                    if (item.Amount != it.Amount)
                //                    {
                //                        verifyitem.result = true;
                //                        it.isMap = true;
                //                        msg = sn.ToString() + "." + content + Environment.NewLine;
                //                        msg = msg + "金額不同";
                //                        lstMoneyMsg.Items.Add("= = = = = = = = = = = = =");
                //                        lstMoneyMsg.Items.Add(msg);
                //                        lstMoneyMsg.Items.Add("= = = = = = = = = = = = =");
                //                        verifyitem.errorcnt = verifyitem.errorcnt + 1;
                //                        SetVerifyModelToView(verifyitem, item);
                //                    }
                //                }
                //            }
                //        }
                //        if (!verifyitem.result)
                //        {
                //            verifyitem.errorcnt = verifyitem.errorcnt + 1;
                //            SetVerifyModelToView(verifyitem, item);
                //            msg = sn.ToString() + ".";
                //            //    lstMoneyMsg.Items.Add("");
                //            lstMoneyMsg.Items.Add("多的帳目:"+msg + "會科:" + item.Acc_ID + " 月份:" + item.Verify_Month + " 金額:" + item.Amount);
                //        }
                //        sn = sn + 1;
                //    }

                //    if (countcompare != "")
                //    {
                //        lstMoneyMsg.Items.Add(countcompare);
                //    }

                //    acc_veriItem.ForEach(o => {
                //        if (!o.isMap)
                //        {
                //            datamsg.Add("應增加帳務的資料:" + o.Acc_Date.Value.ToString("yyyyMMdd") + ",月份:" + o.Verify_Month.ToString() + ",編號:" + o.Acc_ID.ToString() + ",金額:" + o.Amount.ToString());
                //            verifyitem.errorcnt = verifyitem.errorcnt + 1;
                //        }
                //    });

                //    if (datamsg.Count > 0)
                //    {
                //        foreach (var item in datamsg)
                //        {
                //            lstMoneyMsg.Items.Add(item);
                //        }
                //    }
                //    if (verifyitem.getCheckItem == true)
                //    {
                //        var checkdata = acc_veriItem.Where(o => o.isMap == false);
                //        if (checkdata.Count() > 0)
                //        {
                //            lstMoneyMsg.Items.Add("= = = = = =帳目異常檢查= = = = = = =");
                //            foreach (var i in checkdata)
                //            {
                //                lstMoneyMsg.Items.Add("確認此月帳目.會科:" + i.Acc_ID + " 月份:" + i.Verify_Month + " 金額:" + i.Amount);
                //                verifyitem.errorcnt = verifyitem.errorcnt + 1;
                //                SetVerifyModelToView(verifyitem, i);
                //            }
                //            lstMoneyMsg.Items.Add("= = = = = = = = = = = = = = = = = = = ");
                //        }
                //        if (verifyitem.data02.Count() > 0)
                //        {
                //            lstMoneyMsg.Items.Add("= = = = = =帳目過多檢查= = = = = = = = =");
                //            foreach (var ve in verifyitem.data02)
                //            {
                //                lstMoneyMsg.Items.Add("確認此月帳目.會科:" + ve.Acc_ID + " 月份:" + ve.Verify_Month + " 金額:" + ve.Amount);
                //                verifyitem.errorcnt = verifyitem.errorcnt + 1;
                //            }
                //            if (verifyitem.data03 != null)
                //            {
                //                foreach (var ve in verifyitem.data03)
                //                {
                //                    lstMoneyMsg.Items.Add("確認此月帳目.會科:" + ve.Acc_ID + " 月份:" + ve.Verify_Month + " 金額:" + ve.Amount);
                //                    verifyitem.errorcnt = verifyitem.errorcnt + 1;
                //                }
                //            }
                //            lstMoneyMsg.Items.Add("= = = = = = = = = = = = = = = = = = = ");
                //        }
                //    }

                //    foreach (var item in acc_veriItem)
                //    {
                //        foreach (var i in verifyitem.data05)
                //        {
                //            if (i.Verify_Month == item.Verify_Month)
                //            {
                //                i.DstAmount = item.Amount.Value;
                //                i.DstMonth = item.Verify_Month;
                //            }
                //        }
                //    }

                //    if (verifyitem.errorcnt != 0)
                //    {
                //        lstMoneyMsg.Items.Add("比對後，兩方帳目金額及數量異常共" + verifyitem.errorcnt + "項.");
                //        verifyitem.data05 = verifyitem.data05.OrderBy(o => o.Verify_Month).ToList();
                //        foreach (var item in verifyitem.data05)
                //        {
                //            if (item.Verify_Month != item.Cost_M)
                //            {
                //                var contents = moneymodel.accmodel.ctl03.acc_CostItmes.Where(o => (o.Acc_ID == item.Acc_ID && o.Amount == item.DstAmount
                //                && o.Cost_M == item.DstMonth)||((o.Acc_Desc.IndexOf(item.DstMonth.ToString() +"月") != -1) && o.Amount == item.DstAmount)).ToList();

                //                lstMoneyMsg.Items.Add("正確帳目.會科:" + item.Acc_ID + " 月份:" + item.DstMonth + " 金額:" + item.DstAmount);
                //                foreach (var t in contents)
                //                {
                //                    lstMoneyMsg.Items.Add("建議此月帳目.會科:" + t.Acc_ID + " 月份:" + t.Verify_Month + " 帳目月:" + t.Cost_M + " 金額:" + t.Amount);
                //                }
                //            }
                //        }
                //    }
                //    else
                //        lstMoneyMsg.Items.Add("核定通過.");
                //}            
        }

        private static void SetVerifyModelToView(JINSHINFINANCE047Flow verifyitem, JINSHINFINANCE047 item)
        {
            verifyitem.data05.Add(new JINSHINFINANCE035View()
            {
                Acc_Desc = item.Descrip,
                Acc_ID = item.Acc_ID,
                Amount = item.Amount,
                Rec_Type = item.Rec_Type,
                Verify_Month = Convert.ToByte(item.Verify_Month)
            });
        }

        private static void SetVerifyModelToView(JINSHINFINANCE047Flow verifyitem, JINSHINFINANCE035 item)
        {
            verifyitem.data05.Add(new JINSHINFINANCE035View()
            {
                Acc_Desc = item.Acc_Desc,
                Acc_ID = item.Acc_ID,
                Acc_No = item.Acc_No,
                Cost_M = item.Cost_M,
                Amount = item.Amount,
                Cost_Date = item.Cost_Date,
                DataType = item.DataType,
                Invoice_No = item.Invoice_No,
                Rec_Type = item.Rec_Type,
                Verify_Month = item.Verify_Month,
                SN = item.SN
            });
        }
        private void btnCancelCheck_Click(object sender, EventArgs e)
        {
            List<JINSHINFINANCE035> unchecks = new List<JINSHINFINANCE035>();
            unchecks = GetVerifyList(unchecks);
            using (MoneyVerifyClass model = new MoneyVerifyClass())
            {
                model.CancelVerify(unchecks);
                DisplayAll();
            }
        }

        private List<JINSHINFINANCE035> GetVerifyList(List<JINSHINFINANCE035> data)
        {
            foreach (var item in moneymodel.accmodel.ctl03.acc_CostItmes)
            {
                for (int i = 0; i < dataMoney01.SelectedRows.Count; i++)
                {
                    if (Convert.ToInt32(dataMoney01.SelectedRows[i].Cells[0].Value) == item.SN)
                    {
                        data.Add(item);
                    }
                }
            }
            return data;
        }

        private void btnVierfyAcc_Click(object sender, EventArgs e)
        {
            //if (chVerify.Checked)
            //{
                using (MoneyVerifyClass model = new MoneyVerifyClass())
                {
                    model.CheckVerify(moneymodel.accmodel.ctl03.acc_CostItmes);
                    DisplayAll();
                }
            //}
            //else
            //{
            //    MessageBox.Show("請先顯示已審核的項目!");
            //}
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            using (GridViewBase grid = new GridViewBase())
            {
                grid.ExportDataGridView(pathmodel.exportPath, "Acc_YearIntegration", dataMoney01);
            }
        }

        private void MoneyDataShowSet(DataParams params01)
        {
            if (moneymodel.accmodel.ctl03.acc_CostItmes != null)
                moneymodel.accmodel.ctl03.acc_CostItmes.Clear();
            if (moneymodel.accmodel.ctl03.acc_VerifyItmes != null)
                moneymodel.accmodel.ctl03.acc_VerifyItmes.Clear();            
            moneymodel.accmodel.ctl03.SetInit();
            moneymodel.SetConditionData(dataMoney02, AddQueryEnum.JINSHINFINANCE047, params01);
            moneymodel.SetGridColumns(dataMoney02Un, AddQueryEnum.JINSHINFINANCE047);
            moneymodel.accmodel.DataShow<JINSHINFINANCE047>(dataMoney02, params01);
            moneymodel.SetConditionData(dataMoney01, AddQueryEnum.Acc_CostData, params01);
            moneymodel.accmodel.DataShow<JINSHINFINANCE035>(dataMoney01, params01);
        }


        private void btnFrmExports_Click(object sender, EventArgs e)
        {
            int year = Convert.ToInt32(txtYear.Text);
            LoadJin031(year);           
        }





        public List<JINSHINFINANCE047> GetDecriptionInfo(string val)
        {
            var setting = jin047.Where(v => v.Descrip == val).ToList();

            dgview_setting.DataSource = setting;
            return setting;
        }

        private List<string> LoadDescription()
        {
            List<string> rs = new List<string>();
            var values = jin047.GroupBy(v => v.Descrip).ToList();
            foreach (var item in values)
            {
                rs.Add(item.FirstOrDefault().Descrip);
            }
            return rs;
        }




        private void LoadJin031(int year)
        {
            List<YearIntegrationModel> ymodel = new List<YearIntegrationModel>();
            using (AccountEntityDB content = new AccountEntityDB())
            {
                using (AccountEntities entity = content.GetEntity())
                {
                    jin047 = entity.JINSHINFINANCE047.ToList();
                    var jinname = jin047.GroupBy(v => v.Descrip).ToList();
                    jin031 = entity.JINSHINFINANCE031.ToList();
                    foreach (var item in jinname)
                    {
                        string dataval = item.FirstOrDefault().Descrip;
                        YearIntegrationModel model = new YearIntegrationModel();
                        model.desc = dataval;
                        var jinval = jin031.Where(v => v.DescTitle == dataval).FirstOrDefault();
                        if (jinval != null)
                        {
                            model.YesNo = "Y";
                            model.desc02 = jinval.DescTitle;
                        }
                        else
                            model.YesNo = "";
                        ymodel.Add(model);
                    }
                    jin033 = entity.JINSHINFINANCE033.ToList();
                   
                    dgview_class.DataSource = null;
                    dgview_class.DataSource = ymodel;
                    //string val = "";
                    for (int i = 0; i < dgview_class.Rows.Count; i++)
                    {
                        dgview_class.Rows[i].Cells[0].Value = (i+1).ToString();                       
                    }
                }
            }
        }

        private void lstItems_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void FrmYearIntegration_Shown(object sender, EventArgs e)
        {
            dgview_class.DataSource = null;
            gridviewctl.SetGridColumns<Class_DgItems>(dgview_class, new Class_DgItems());
            dgview_setting.DataSource = null;
            gridviewctl.SetGridColumns<ClassData_DGitems>(dgview_setting, new ClassData_DGitems());
            LoadJin031(DateTime.Now.Year);
            SysRescControlVModel.SetFixedWindow(this);
        }

        private void dgview_class_SelectionChanged(object sender, EventArgs e)
        {
            object val = dgview_class.CurrentRow.Cells[2].Value;
            if (val != null)
            {
                string selectvalue = val.ToString();
                var data = jin033.Where(v => v.Desc01 == selectvalue && v.AffairsNo != null).ToList();
                select033.Clear();
                if (data.Count > 0)
                {
                    select033 = jin033.Where(v => v.AffairsNo == data[0].AffairsNo).ToList();
                }
                dgview_setting.DataSource = null;
                dgview_setting.DataSource = select033;
                for (int i = 0; i < dgview_setting.Rows.Count; i++)
                {
                    dgview_setting.Rows[i].Cells[0].Value = (i +1).ToString();
                }
            }
            else
                dgview_setting.DataSource = null;
        }

        private void chVerify_CheckedChanged(object sender, EventArgs e)
        {
            if (chVerify.Checked)
            {
                checked_list = GetVerifyData(chVerify.Checked);
                dataMoney01.DataSource = null;
                dataMoney01.DataSource = checked_list;
            }
            else
            {
                DisplayAll();
            }
        }

        private List<JINSHINFINANCE035> GetVerifyData(bool check)
        {
            List<JINSHINFINANCE035> rsdata = new List<JINSHINFINANCE035>();            
            for (int i = 0; i < dataMoney01.Rows.Count; i++)
            {
                
                object fill = dataMoney01.Rows[i].Cells["Is_Fill"].Value;
                if (fill != null)
                {
                    if (Convert.ToBoolean(fill) && check)
                    {
                       rsdata = SetDataTo(rsdata, i);
                    }
                    else if (!check && !Convert.ToBoolean(fill))
                    {
                        rsdata = SetDataTo(rsdata, i);
                    }
                }
                else
                {
                    if (!check)
                    {
                        rsdata = SetDataTo(rsdata, i);
                    }
                }
            }
            return rsdata;
        }

        private List<JINSHINFINANCE035> SetDataTo(List<JINSHINFINANCE035> rsdata, int i)
        {
            int sn = Convert.ToInt32(dataMoney01.Rows[i].Cells["sn"].Value);
            var valdata = moneymodel.accmodel.ctl03.acc_CostItmes.Where(v => v.SN == sn).FirstOrDefault();
            if (valdata != null)
                rsdata.Add(valdata);
            return rsdata;
        }

        private void chAll_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void dataMoney01_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                if (e.Value != null)
                {
                    bool check = Convert.ToBoolean(e.Value);
                    if (check)
                        e.Value = "V";
                    else
                        e.Value = "";
                }
            }
            if (e.ColumnIndex == 10)
            {
                if (e.Value != null)
                {
                    bool check = Convert.ToBoolean(e.Value);
                    if (check)
                        e.Value = "V";
                    else
                        e.Value = "";
                }
            }
        }
    }
}
 