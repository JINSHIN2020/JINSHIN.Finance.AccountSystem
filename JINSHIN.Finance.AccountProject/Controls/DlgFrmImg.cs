using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JINSHIN.Finance.AccountSystem.Controls
{
    public partial class DlgFrmImg : Form
    {
        public string filepath { get; set; }
        public DlgFrmImg()
        {
            InitializeComponent();
        }

        private void DlgFrmImg_Load(object sender, EventArgs e)
        {
            picimg.ImageLocation = filepath;
        }

        private void picimg_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
