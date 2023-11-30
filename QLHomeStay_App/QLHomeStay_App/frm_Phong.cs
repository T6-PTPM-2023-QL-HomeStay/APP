using DAL;
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
        DAL_PHONG ph = new DAL_PHONG();
        public frm_Phong()
        {
            InitializeComponent();
            dgv_phong.DataSource = ph.GetPHONGs();
            dgv_phong.Columns["MAPHONG"].HeaderText = "Mã Phòng";
            dgv_phong.Columns["TENPHONG"].HeaderText = "Tên Phòng";
            dgv_phong.Columns["MAKHU"].HeaderText = "Mã khu";
            dgv_phong.Columns["MALOAIPHONG"].HeaderText = "Mã loại phòng";
            dgv_phong.Columns["SOLUONGNGUOIO"].HeaderText = "Số lượng người ở";
            cbo_khu.DataSource = ph.loadKhu();
            cbo_loai.DataSource = ph.loadLoai();
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

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_maphong.Text.Trim() == string.Empty || txt_tenphong.Text.Trim() == string.Empty || txt_soluong.Text.Trim() == string.Empty)
                MessageBox.Show("Vui lòng điền đủ thông tin");
            else
            {
                DialogResult d = MessageBox.Show("Bạn có chắc muốn Thêm?", "Xác nhận", MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)
                {
                    PHONG p = new PHONG
                    {
                        MAPHONG = txt_maphong.Text,
                        TENPHONG = txt_tenphong.Text,
                        MAKHU = cbo_khu.SelectedItem.ToString(),
                        MALOAIPHONG = cbo_loai.SelectedItem.ToString(),
                        SOLUONGNGUOIO = int.Parse(txt_soluong.Text),                       
                    };
                    if (ph.themPHONG(p))
                    {
                        MessageBox.Show("Thêm thành công!");
                        dgv_phong.DataSource = ph.GetPHONGs();
                    }

                    else
                        MessageBox.Show("Thêm thất bại!");

                }
            }
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn có chắc muốn Sửa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                PHONG p = new PHONG
                {
                    MAPHONG = txt_maphong.Text,
                    TENPHONG = txt_tenphong.Text,
                    MAKHU = cbo_khu.SelectedItem.ToString(),
                    MALOAIPHONG = cbo_loai.SelectedItem.ToString(),
                    SOLUONGNGUOIO = int.Parse(txt_soluong.Text),
                };
                if (ph.suaPHONG(p))
                    MessageBox.Show("Sửa thành công!");
                else
                    MessageBox.Show("Sửa thất bại!");
                dgv_phong.DataSource = ph.GetPHONGs();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string maph = txt_maphong.Text;

            DialogResult d = MessageBox.Show("Bạn có chắc muốn Xóa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                if (ph.xoaPHONG(maph))
                    MessageBox.Show("Xóa thành công!");
                else
                    MessageBox.Show("Xóa thất bại!");
                dgv_phong.DataSource = ph.GetPHONGs();
            }
        }

        private void dgv_phong_Click(object sender, EventArgs e)
        {
            txt_maphong.Text = dgv_phong.CurrentRow.Cells[0].Value.ToString();
            txt_tenphong.Text = dgv_phong.CurrentRow.Cells[1].Value.ToString();
            cbo_khu.Text = dgv_phong.CurrentRow.Cells[2].Value.ToString();
            cbo_loai.Text = dgv_phong.CurrentRow.Cells[3].Value.ToString();
            txt_soluong.Text = dgv_phong.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
