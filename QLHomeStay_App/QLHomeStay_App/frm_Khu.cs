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
    public partial class frm_Khu : Form
    {
        DAL_KHU khu = new DAL_KHU();
        public frm_Khu()
        {                    
            InitializeComponent();
            dgv_khu.DataSource = khu.ConvertKHUsToDataTable();
            dgv_khu.Columns["MAKHU"].HeaderText = "Mã Khu";
            dgv_khu.Columns["TENKHU"].HeaderText = "Tên Tên Khu";            
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_makhu.Text.Trim() == string.Empty || txt_tenkhu.Text.Trim() == string.Empty )
                MessageBox.Show("Vui lòng điền đủ thông tin");
            else
            {
                DialogResult d = MessageBox.Show("Bạn có chắc muốn Thêm?", "Xác nhận", MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)
                {
                    KHU p = new KHU
                    {
                        MAKHU = txt_makhu.Text,
                        TENKHU = txt_tenkhu.Text,                     

                    };
                    if (khu.themKhu(p))
                    {
                        MessageBox.Show("Thêm thành công!");
                        dgv_khu.DataSource = khu.ConvertKHUsToDataTable();
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
                KHU p = new KHU
                {
                    MAKHU = txt_makhu.Text,
                    TENKHU = txt_tenkhu.Text,

                };
                if (khu.suaDichVu(p))
                    MessageBox.Show("Sửa thành công!");
                else
                    MessageBox.Show("Sửa thất bại!");
                dgv_khu.DataSource = khu.GetKHUs();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string makhu = txt_makhu.Text;

            DialogResult d = MessageBox.Show("Bạn có chắc muốn Xóa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                if (khu.xoaKhu(makhu))
                    MessageBox.Show("Xóa thành công!");
                else
                    MessageBox.Show("Xóa thất bại!");
                dgv_khu.DataSource = khu.ConvertKHUsToDataTable();
            }
        }

        private void dgv_khu_Click(object sender, EventArgs e)
        {
            txt_makhu.Text = dgv_khu.CurrentRow.Cells[0].Value.ToString();
            txt_tenkhu.Text = dgv_khu.CurrentRow.Cells[1].Value.ToString();
        }

        private void tabSearchNV_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string tenkhu = txtSearchNV.Text;
            bool found = khu.search(tenkhu);
            if (found)
            {
                dgv_khu.DataSource = khu.ConvertKHUsToDataTable();
            }
            else
            {
                MessageBox.Show("Không tìm thấy khu có tên: " + tenkhu);
            }
        }
    }
}
