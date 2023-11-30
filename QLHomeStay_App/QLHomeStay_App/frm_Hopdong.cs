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
    public partial class frm_Hopdong : Form
    {
        public frm_Hopdong()
        {
            InitializeComponent();
        }

        private void btn_hopdong_Click(object sender, EventArgs e)
        {
            frm_CTHopDong frm_CTHopDong = new frm_CTHopDong();
            frm_CTHopDong.ShowDialog();
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
