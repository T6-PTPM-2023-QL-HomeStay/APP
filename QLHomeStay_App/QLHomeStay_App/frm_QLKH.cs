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
    public partial class frm_QLKH : Form
    {
        public frm_QLKH()
        {
            InitializeComponent();
        }

        private void btn_tk_Click(object sender, EventArgs e)
        {
            frm_QLTK frm_QLTK = new frm_QLTK(); 
            frm_QLTK.ShowDialog();
        }
    }
}
