using DevExpress.XtraEditors;
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
    public partial class frmQLPhong : DevExpress.XtraEditors.XtraForm
    {
        public frmQLPhong()
        {
            InitializeComponent();
            dataGridView1.DataSource = phong.getAllPhong();
            cbo_loai.DataSource = l.getTenLP();
            cbo_khu.DataSource = KHU.getMaKhu();
            cbo_loai.SelectedItem = 0;
            cbo_khu.SelectedItem = 0;
           
            string[] t = { "Đã thuê", "Trống" };
            cbbtrangThai.DataSource = t;
            cbbtrangThai.SelectedIndex = 0;
        }
        DAL_PHONG phong = new DAL_PHONG();
        DAL_LOAI l = new DAL_LOAI();
        DAL_KHU KHU = new DAL_KHU();
        private void btn_khu_Click(object sender, EventArgs e)
        {
            frm_Khu khu = new frm_Khu();
            khu.ShowDialog();
        }

        private void btn_loai_Click(object sender, EventArgs e)
        {
           
        }

        
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dataGridView1.SelectedRows[0];
                txt_maphong.Text = r.Cells[0].Value.ToString();
                cbo_loai.Text = r.Cells[1].Value.ToString();
                cbo_khu.Text = r.Cells[2].Value.ToString();
                txt_tenphong.Text = r.Cells[3].Value.ToString();
                txt_soluong.Text = r.Cells[4].Value.ToString();
                cbbtrangThai.Text = r.Cells[5].Value.ToString();

            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn có chắc muốn Nhận phòng?", "Xác nhận", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {

                if (phong.updatePhong(txt_maphong.Text,cbo_loai.Text,cbo_khu.Text,txt_tenphong.Text,int.Parse(txt_soluong.Text),cbbtrangThai.SelectedItem.ToString()))
                    MessageBox.Show("Nhận phòng thành công!");
                else
                    MessageBox.Show("Nhận phòng thất bại!");
                dataGridView1.DataSource = phong.getAllPhong();
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn có chắc muốn Trả phòng?", "Xác nhận", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {

                if (phong.updatePhong(txt_maphong.Text, cbo_loai.Text, cbo_khu.Text, txt_tenphong.Text, int.Parse(txt_soluong.Text), cbbtrangThai.SelectedItem.ToString()))
                    MessageBox.Show("Trả phòng thành công!");
                else
                    MessageBox.Show("Trả phòng thất bại!");
                dataGridView1.DataSource = phong.getAllPhong();
            }

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = phong.getAllPhong();
        }
    }
}