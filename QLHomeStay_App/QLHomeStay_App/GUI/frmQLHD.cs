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
    public partial class frmQLHD : DevExpress.XtraEditors.XtraForm
    {
        public frmQLHD()
        {
            InitializeComponent();
        }

        private void btn_kh_Click(object sender, EventArgs e)
        {
            frmQLKH kh = new frmQLKH();
            kh.ShowDialog();
        }

        private void btn_dv_Click(object sender, EventArgs e)
        {
            frmQLDV frmQLDV = new frmQLDV();
            frmQLDV.ShowDialog();
        }

        private void btn_phong_Click(object sender, EventArgs e)
        {
            frmQLPhong phong = new frmQLPhong();
            phong.ShowDialog();
        }
    }
}