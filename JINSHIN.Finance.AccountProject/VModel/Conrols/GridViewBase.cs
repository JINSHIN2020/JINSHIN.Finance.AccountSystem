using FinanceAccountProgram.Models;
using FinanceAccountProgram.Models.UControl;
using JINSHIN.FinanceAccounting.DB;
using FinanceAccountProgram.VModel.Conrols.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using JINSHIN.BUSINESS.LIBARY.Models.UIControls;
using JINSHIN.BUSINESS.LIBARY.Models.UControl;

namespace FinanceAccountProgram.VModel.Conrols
{
    public class GridViewBase : JBase
    {
        public List<string> columns { get; set; }
        public AddQueryEnum datatype { get; set; }
        public GridViewControl gvComboList { get; set; }
        // public List<GridViewOperation> operations { get; set; }
        public GridViewBase()
        {
            //       operations = new List<GridViewOperation>();
        }
        public GridViewBase(AddQueryEnum datatype)
        {
            //  operations = new List<GridViewOperation>();
            gvComboList = new GridViewControl(datatype);
        }
        public void SetDataColumns(DataGridView dg, List<string> columns)
        {
            for (int i = 0; i < columns.Count; i++)
            {
                dg.Columns[i].HeaderText = columns[i];
            }
            dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        public void SetDataColumns(DataGridView dg)
        {
            for (int i = 0; i < columns.Count; i++)
            {
                dg.Columns[i].HeaderText = columns[i];
            }
            dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        public void SetDataColumns(DataGridView dg,List<int> cols)
        {
            for (int i = 0; i < columns.Count; i++)
            {
                dg.Columns[i].HeaderText = columns[i];
                dg.Columns[i].Width = cols[i];
            }
            dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private static void SetDGViewColumns(List<DataGridViewComboBoxColumn> dgvCombobox, DataGridViewCheckBoxColumn dgvcheck, List<Acc_Class> acctypes, List<Inv_Class> invtypes)
        {
            dgvCombobox[0].DataSource = invtypes; ;
            dgvCombobox[0].DisplayMember = "Name";
            dgvCombobox[0].ValueMember = "No";
            dgvCombobox[1].DataSource = acctypes;
            dgvCombobox[1].DisplayMember = "Name";
            dgvCombobox[1].ValueMember = "No";
            // dgvCombobox.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;               
            dgvcheck.FlatStyle = FlatStyle.Standard;
        }
        public void ReBindGridData<T>(DataGridView dgv, List<VarClass> columns, List<T> values)
        {
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                for (int j = 0; j < columns.Count; j++)
                {
                    //SetColumnsValueFromDB(dgv.Rows[i], columns[j],dgv.Rows[i].Cells[columns[j]]);
                }
                // SetColumnsValueFromDB(dgv.Rows[i], null,);
                //switch (columns[i].value)
                //{
                //    case "Combo":
                //        {
                //          //  DataGridViewComboBoxColumn column = new DataGridViewComboBoxColumn();
                //          //  dgv.Columns.Add(column);
                //        }
                //        break;
                //    case "check":
                //        {
                //          //  DataGridViewCheckBoxColumn column = new DataGridViewCheckBoxColumn();
                //          //  dgv.Columns.Add(column);
                //        }
                //        break;
                //    default:
                //        break;
                //}
            }
        }


        public void data_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView dg = sender as DataGridView;
            //     dg.Sort(dg.Columns[e.ColumnIndex], ListSortDirection.Ascending);
        }

        public void AutoGenerateColumns(DataGridView dgv, List<NameValues> columns)
        {
            dgv.Columns.Clear();
            for (int i = 0; i < columns.Count; i++)
            {
                switch (columns[i].value)
                {
                    case "Text":
                        {
                            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                            column.DataPropertyName = columns[i].name;
                            dgv.Columns.Add(column);

                        }
                        break;
                    case "Combo":
                        {
                            DataGridViewComboBoxColumn column = new DataGridViewComboBoxColumn();
                            switch (columns[i].combotype)
                            {
                                case BaseClassEnum.Acc_Detail:
                                    column.DataSource = gvComboList.datasource02;
                                    break;
                                case BaseClassEnum.Acc_Class:
                                    column.DataSource = gvComboList.datasource01;
                                    break;
                                case BaseClassEnum.Inv_Class:
                                    column.DataSource = gvComboList.datasource03;
                                    break;
                                default:
                                    break;
                            }
                            column.DisplayMember = "Name";
                            column.ValueMember = "No";
                            column.DataPropertyName = columns[i].name;
                            dgv.Columns.Add(column);
                        }
                        break;
                    case "Check":
                        {
                            DataGridViewCheckBoxColumn column = new DataGridViewCheckBoxColumn();
                            column.DataPropertyName = columns[i].name;
                            dgv.Columns.Add(column);
                        }
                        break;
                    default:
                        break;
                }
                dgv.Columns[i].HeaderText = columns[i].text;
                dgv.ColumnHeaderMouseClick += data_ColumnHeaderMouseClick;
            }
            columns.Clear();
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

 

        public void SetColumnsValueFromDB(DataGridViewRow row, VarClass vclass, object val)
        {
            row.Cells[vclass.value01].Value = val;
        }
        public void ExportDataGridView(string exportpath, string title, DataGridView dgControl)
        {            
            string filepath = exportpath + title + DateTime.Now.ToString("yyyyMMddHHmmss") + ".csv";
            StringBuilder sb = new StringBuilder();
            DataGridViewColumn col = default(DataGridViewColumn);
            string content = "";
            try
            {
                for (int i = 0; i < dgControl.Columns.Count; i++)
                {
                    col = dgControl.Columns[i];
                    content += col.HeaderText + ",";
                }
                sb.Append(content + Environment.NewLine);
                for (int i = 0; i < dgControl.Rows.Count; i++)
                {
                    content = "";
                    for (int j = 0; j < dgControl.Rows[i].Cells.Count; j++)
                    {
                        if (dgControl.Rows[i].Cells[j].Value != null)
                            content += dgControl.Rows[i].Cells[j].Value.ToString() + ",";
                        else
                            content += ",";
                    }
                    sb.Append(content + Environment.NewLine);
                }
                File.WriteAllText(filepath, sb.ToString(), Encoding.UTF8);
            }
            catch (Exception ex)
            {
                string str = ex.ToString();
            }
        }
    }
}
