using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHomeStay_App
{
    public partial class frm_CTHD : Form
    {
        public frm_CTHD()
        {
            InitializeComponent();
        }

        private void btn_dv_Click(object sender, EventArgs e)
        {
            frm_CTDV frm_CTDV = new frm_CTDV();
            frm_CTDV.ShowDialog();
        }
    }
}
