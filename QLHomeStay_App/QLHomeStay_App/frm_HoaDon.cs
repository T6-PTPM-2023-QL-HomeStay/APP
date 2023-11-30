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
    public partial class frm_HoaDon : Form
    {
        public frm_HoaDon()
        {
            InitializeComponent();
        }

        private void btn_hd_Click(object sender, EventArgs e)
        {
            frm_CTHD frm_CTHD = new frm_CTHD();
            frm_CTHD.ShowDialog();
        }

        private void btn_kh_Click(object sender, EventArgs e)
        {
            frm_QLKH frm_QLKH = new frm_QLKH();
            frm_QLKH.ShowDialog();
        }

        

        private void btn_phong_Click(object sender, EventArgs e)
        {
            frm_Phong frm_Phong = new frm_Phong();
            frm_Phong.ShowDialog();
        }
    }
}
