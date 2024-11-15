using FinanceAccountProgram.Models;
using FinanceAccountProgram.Models.Business;
using FinanceAccountProgram.Models.UControl;
using JINSHIN.FinanceAccounting.DB;
using FinanceAccountProgram.VModel.UsrControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectResourceData;
using JINSHIN.BUSINESS.LIBARY.UIControls.GridView;
using JINSHIN.BUSINESS.LIBARY.Models.UControl.GView;
using JINSHIN.BUSINESS.LIBARY.UIControls.FormMgt.EntityVModel;
using JINSHIN.BUSINESS.LIBARY.Base;

namespace FinanceAccountProgram.VModel.Business
{
    public class BusiDataModelControl :JBase
    {
        public BaseGridCtl gridviewctl { get; set; }
        public BusiDataModelControl()
        {
            gridviewctl = new BaseGridCtl();
        }

        /// <summary>
        /// 點餐及餐廳報表
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public List<DataModel> ConvertOrderDetailToDataModel(List<OrderDetailModel> data)
        {
            List<string> data01 = new List<string>() { "NO", "CDATE", "PROCLASS", "PNAME", "NUM", "PPRICE" };
            List<string> data02 = new List<string>() {
                "I02",  "DATA03", "DATA02","DATA01","D02", "D01"     };
            EntityControl control = new EntityControl(gridviewctl);
            List<DataModel> models = new List<DataModel>();
            int sn = 1;
            try
            {
                foreach (var item in data)
                {
                    DataModel dmodel = new DataModel();
                    control.EntityDataClass<OrderDetailModel, DataModel>(item, dmodel, data01, data02);
                    dmodel.I02 = sn;
                    models.Add(dmodel);
                    sn++;
                }
            }
            catch (Exception ex)
            {
                LogControl.LogAlarm(ex.ToString(), ProjectNameRsource.BusinessModelError);
            }

            return models;
        }
    }
}
