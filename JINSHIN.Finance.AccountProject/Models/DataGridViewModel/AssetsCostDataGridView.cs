﻿using FinanceAccountProgram.VModel.Conrols.Model;
using JINSHIN.BUSINESS.LIBARY.Models.UIControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JINSHIN.BUSINESS.LIBARY.Base;

namespace FinanceAccountProgram.Models.DataGridViewModel
{
    public class AssetsCostDataGridView :JBase
    {
        public List<NameValues> columns { get; set; }
        public AssetsCostDataGridView()
        {
            columns = new List<NameValues>();
            columns.Add(new NameValues() { name = "sn", value = "Text", text = "序號" });
            columns.Add(new NameValues() { name = "date", value = "Text", text = "日期" });
            columns.Add(new NameValues() { name = "acc_no", value = "Text", text = "傳票" });
            columns.Add(new NameValues() { name = "item", value = "Text", text = "項目" });
            columns.Add(new NameValues() { name = "acc_id", value = "Text", text = "科目" });
            columns.Add(new NameValues() { name = "desc", value = "Text", text = "描述" });
            columns.Add(new NameValues() { name = "Org_amount", value = "Text", text = "金額" });
            columns.Add(new NameValues() { name = "Dst_amount", value = "Text", text = "試算金額" });
            columns.Add(new NameValues() { name = "lend", value = "Text", text = "借/貸" });
        }
    }
}