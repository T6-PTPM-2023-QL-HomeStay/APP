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
    public partial class frmQLDG : DevExpress.XtraEditors.XtraForm
    {
        public frmQLDG()
        {
            InitializeComponent();
        }

        private void btn_kh_Click(object sender, EventArgs e)
        {
            frmQLKH qlkh = new frmQLKH();
            qlkh.ShowDialog();
        }
    }
}