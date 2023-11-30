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
    public partial class frm_KhuyenMai : Form
    {
        public frm_KhuyenMai()
        {
            InitializeComponent();
        }

        private void btn_khuyenmai_Click(object sender, EventArgs e)
        {
            frm_CTKM frm_CTKM = new frm_CTKM();
            frm_CTKM.ShowDialog();
        }

        private void btn_phong_Click(object sender, EventArgs e)
        {
            frm_Phong frm_Phong = new frm_Phong();
            frm_Phong.ShowDialog();
        }
    }
}
