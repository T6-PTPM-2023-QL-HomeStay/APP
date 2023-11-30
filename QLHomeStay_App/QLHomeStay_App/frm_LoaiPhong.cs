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
    public partial class frm_LoaiPhong : Form
    {
        DAL_LOAI loai = new DAL_LOAI();
        public frm_LoaiPhong()
        {
            InitializeComponent();
            dgv_loai.DataSource = loai.GetLOAIPHONGs();
            dgv_loai.Columns["MALOAI"].HeaderText = "Mã Loại";
            dgv_loai.Columns["TENLOAI"].HeaderText = "Tên loại";
            dgv_loai.Columns["GIAPH"].HeaderText = "Giá phòng";
           

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_maloai.Text.Trim() == string.Empty || txt_tenloai.Text.Trim() == string.Empty || txt_giaphong.Text.Trim() == string.Empty)
                MessageBox.Show("Vui lòng điền đủ thông tin");
            else
            {
                DialogResult d = MessageBox.Show("Bạn có chắc muốn Thêm?", "Xác nhận", MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)
                {
                    LOAIPHONG p = new LOAIPHONG
                    {
                        MALOAI = txt_maloai.Text,
                        TENLOAI = txt_tenloai.Text,
                        GIAPH = double.Parse(txt_giaphong.Text),
                    };
                    if (loai.themLOAIPHONG(p))
                    {
                        MessageBox.Show("Thêm thành công!");
                        dgv_loai.DataSource = loai.GetLOAIPHONGs();
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
                LOAIPHONG p = new LOAIPHONG
                {
                    MALOAI = txt_maloai.Text,
                    TENLOAI = txt_tenloai.Text,
                    GIAPH = double.Parse(txt_giaphong.Text),
                };
                if (loai.suaLoai(p))
                    MessageBox.Show("Sửa thành công!");
                else
                    MessageBox.Show("Sửa thất bại!");
                dgv_loai.DataSource = loai.GetLOAIPHONGs();
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string maloai = txt_maloai.Text;

            DialogResult d = MessageBox.Show("Bạn có chắc muốn Xóa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                if (loai.xoaLOAIPHONG(maloai))
                    MessageBox.Show("Xóa thành công!");
                else
                    MessageBox.Show("Xóa thất bại!");
                dgv_loai.DataSource = loai.GetLOAIPHONGs();
            }
        }

        private void dgv_loai_Click(object sender, EventArgs e)
        {
            txt_maloai.Text = dgv_loai.CurrentRow.Cells[0].Value.ToString();
            txt_tenloai.Text = dgv_loai.CurrentRow.Cells[1].Value.ToString();
            txt_giaphong.Text = dgv_loai.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
