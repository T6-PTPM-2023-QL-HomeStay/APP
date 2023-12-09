using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Windows.Forms;

namespace QLHomeStay_App
{
    public partial class frm_QLTK : Form
    {
        DAL_NHANVIEN dalNV = new DAL_NHANVIEN();

        public frm_QLTK()
        {
            InitializeComponent();
            loadDataDefault();
        }

        public void loadDataDefault()
        {
            //dgv_tk.DataSource = null;
            //dgv_tk.DataSource = dalNV.getAllTaiKhoan();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_matk.Text.Trim() == string.Empty || txt_tendangnhap.Text.Trim() == string.Empty || txt_mk.Text.Trim() == string.Empty || cbo_quyen.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng điền đủ thông tin!");
                return;
            }

            if (dalNV.checkExistTenDN(txt_tendangnhap.Text.Trim()))
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại!");
                return;
            }

            if (dalNV.checkExistMaTaiKhoan(txt_matk.Text.Trim()))
            {
                MessageBox.Show("Mã tài khoản đã tồn tại!");
                return;
            }

            DialogResult result = MessageBox.Show("Xác nhận Thêm thông tin tài khoản?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (dalNV.insertTaiKhoan(txt_matk.Text.Trim(), txt_tendangnhap.Text.Trim(), txt_mk.Text.Trim(), cbo_quyen.SelectedItem.ToString().Trim()))
                {

                    MessageBox.Show("Thêm thông tin tài khoản thành công!");
                    loadDataDefault();
                }
                else
                    MessageBox.Show("Thêm tài khoản thất bại!");
            }
        }

        private void dgv_tk_SelectionChanged(object sender, EventArgs e)
        {
            //if (dgv_tk.SelectedRows.Count > 0)
            //{
            //    DataGridViewRow r = dgv_tk.SelectedRows[0];
            //    txt_matk.Text = r.Cells[0].Value.ToString().Trim();
            //    txt_tendangnhap.Text = r.Cells[1].Value.ToString().Trim();
            //    txt_mk.Text = r.Cells[2].Value.ToString().Trim();
            //    cbo_quyen.Text = r.Cells[3].Value.ToString().Trim();
            //}
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            //if (dgv_tk.SelectedRows.Count > 0)
            //{
            //    DataGridViewRow r = dgv_tk.SelectedRows[0];
            //    string maTK = r.Cells[0].Value.ToString().Trim();

            //    if (txt_mk.Text.Trim() == string.Empty || cbo_quyen.SelectedIndex < 0)
            //    {
            //        MessageBox.Show("Vui lòng điền đủ thông tin!");
            //        return;
            //    }

            //    DialogResult result = MessageBox.Show("Xác nhận Sửa thông tin tài khoản?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //    if (result == DialogResult.Yes)
            //    {
            //        if (dalNV.updateTaiKhoan(maTK, txt_mk.Text.Trim(), cbo_quyen.SelectedItem.ToString().Trim()))
            //        {

            //            MessageBox.Show("Sửa thông tin tài khoản thành công!");
            //            loadDataDefault();
            //        }
            //        else
            //            MessageBox.Show("Sửa tài khoản thất bại!");
            //    }
            //}
            //else
            //    MessageBox.Show("Vui lòng chọn!");
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            //if (dgv_tk.SelectedRows.Count > 0)
            //{
            //    DataGridViewRow r = dgv_tk.SelectedRows[0];
            //    string maTK = r.Cells[0].Value.ToString().Trim();

            //    DialogResult result = MessageBox.Show("Xác nhận Xóa thông tin tài khoản?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //    if (result == DialogResult.Yes)
            //    {
            //        if (dalNV.xoaTaiKhoan(maTK))
            //        {

            //            MessageBox.Show("Xóa thông tin tài khoản thành công!");
            //            loadDataDefault();
            //        }
            //        else
            //            MessageBox.Show("Xóa tài khoản thất bại!");
            //    }
            //}
            //else
            //    MessageBox.Show("Vui lòng chọn!");
        }

        private void dgv_tk_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_QLTK_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_KH.TAIKHOAN' table. You can move, or remove it, as needed.
            this.tAIKHOANTableAdapter.Fill(this.qL_KH.TAIKHOAN);

        }
    }
}
