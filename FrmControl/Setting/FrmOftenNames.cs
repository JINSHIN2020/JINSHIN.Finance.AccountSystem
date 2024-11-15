using JINSHIN.BUSINESS.LIBARY.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceAccountProgram.FrmControl
{
    public partial class FrmOftenNames : Form
    {
        public FrmOftenNames()
        {
            InitializeComponent();
            datagrid.Font = new System.Drawing.Font(DataControl.DataGridFont, Convert.ToInt32(DataControl.DataGridFontSize));
        }
    }
}
