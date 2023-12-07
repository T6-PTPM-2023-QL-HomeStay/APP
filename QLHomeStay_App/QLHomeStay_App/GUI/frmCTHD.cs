using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace QLHomeStay_App.GUI
{
    public partial class frmCTHD : Form
    {
        DAL_KHACHHANG kh = new DAL_KHACHHANG();
        DALL_HOADON hd = new DALL_HOADON();
        DAL_DICHVU dv = new DAL_DICHVU();
        DAL_PHONG p = new DAL_PHONG();
        public frmCTHD()
        {
            InitializeComponent();
            cbbMaHd.DataSource = hd.getmaHD();
            cbbMaHd.SelectedItem = 0;
            cbbMaPhong.DataSource = p.getMaPhong();
            cbbMaPhong.SelectedItem = 0;
            cbbMaDV.DataSource = dv.getMaDV();
            cbbMaDV.SelectedItem = 0;
        }

        private void frmCTHD_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = hd.GetCTHDs();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
           
                DialogResult d = MessageBox.Show("Bạn có chắc muốn Thêm?", "Xác nhận", MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)
                {

                    if (hd.insertCTHD(int.Parse(cbbMaDV.Text), int.Parse(cbbMaHd.SelectedItem.ToString()),cbbMaPhong.Text,float.Parse(txtTong.Text)))
                    {
                        MessageBox.Show("Thêm thành công!");
                        dataGridView1.DataSource = hd.GetCTHDs();


                    }

                    else
                        MessageBox.Show("Thêm thất bại!");

                }
            }
        
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            int maloai = int.Parse(cbbMaHd.Text);

            DialogResult d = MessageBox.Show("Bạn có chắc muốn Xóa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                if (hd.xoaHD(maloai))
                    MessageBox.Show("Xóa thành công!");
                else
                    MessageBox.Show("Xóa thất bại!");
                dataGridView1.DataSource = hd.GetCTHDs();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn có chắc muốn Sửa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {

                if (hd.updateCTHD(int.Parse(cbbMaHd.SelectedItem.ToString()),float.Parse(txtTong.Text)))
                    MessageBox.Show("Sửa thành công!");
                else
                    MessageBox.Show("Sửa thất bại!");
                dataGridView1.DataSource = hd.GetCTHDs();
            }
        }

    }
}
