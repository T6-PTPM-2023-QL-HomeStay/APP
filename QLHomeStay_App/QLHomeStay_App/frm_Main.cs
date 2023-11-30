using QLHomeStay_App.Resources;
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
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void btn_QLNV_Click(object sender, EventArgs e)
        {
            Frm_QLNV frm_QLNV = new Frm_QLNV();
            frm_QLNV.ShowDialog();
        }

        private void btn_QLKH_Click(object sender, EventArgs e)
        {
            frm_QLKH frm_QLKH = new frm_QLKH();
            frm_QLKH.ShowDialog();
        }

        private void btn_QLDG_Click(object sender, EventArgs e)
        {
            frm_DanhGia danhGia = new frm_DanhGia();
            danhGia.ShowDialog();
        }

        private void btn_QLP_Click(object sender, EventArgs e)
        {
            frm_Phong frm_Phong = new frm_Phong(); 
            frm_Phong.ShowDialog();
        }

        private void btn_QLHOPDONG_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_QLDV_Click(object sender, EventArgs e)
        {
            frm_DichVu frm_DichVu = new frm_DichVu();   
            frm_DichVu.ShowDialog();
        }

        private void btn_QLKM_Click(object sender, EventArgs e)
        {
            frm_KhuyenMai frm_KhuyenMai = new frm_KhuyenMai();
            frm_KhuyenMai.ShowDialog();
        }

        private void btn_QLHD_Click(object sender, EventArgs e)
        {
            frm_HoaDon frm_HoaDon = new frm_HoaDon();   
            frm_HoaDon.ShowDialog();
        }

        private void btn_QLTK_Click(object sender, EventArgs e)
        {
            frm_ThongKe frm_ThongKe = new frm_ThongKe();
            frm_ThongKe.ShowDialog();
        }
    }
}
