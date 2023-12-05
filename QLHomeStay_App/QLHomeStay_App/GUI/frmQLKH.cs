using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHomeStay_App.GUI
{
    public partial class frmQLKH : DevExpress.XtraEditors.XtraForm
    {
        public frmQLKH()
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