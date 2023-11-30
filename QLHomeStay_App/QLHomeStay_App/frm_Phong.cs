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
    public partial class frm_Phong : Form
    {
        public frm_Phong()
        {
            InitializeComponent();
        }

        private void btn_khu_Click(object sender, EventArgs e)
        {
            frm_Khu frm_Khu = new frm_Khu();
            frm_Khu.ShowDialog();
        }

        private void btn_loai_Click(object sender, EventArgs e)
        {
            frm_LoaiPhong frm_LoaiPhong = new frm_LoaiPhong();
            frm_LoaiPhong.ShowDialog();
        }
    }
}
