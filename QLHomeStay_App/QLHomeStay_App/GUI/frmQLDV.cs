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
    public partial class frmQLDV : DevExpress.XtraEditors.XtraForm
    {
        public frmQLDV()
        {
            InitializeComponent();
            //dataGridView1.DataSource = dv.GetDICHVUs();
        }
        DAL_DICHVU dv = new DAL_DICHVU();
        private void btn_phong_Click(object sender, EventArgs e)
        {
            frmQLPhong ph  = new frmQLPhong();
            ph.ShowDialog();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_madv.Text.Trim() == string.Empty || txt_tendv.Text.Trim() == string.Empty)
                MessageBox.Show("Vui lòng điền đủ thông tin");
            else
            {
                DialogResult d = MessageBox.Show("Bạn có chắc muốn Thêm?", "Xác nhận", MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)
                {

                    if (dv.insertDV(int.Parse(txt_madv.Text), txt_tendv.Text,float.Parse(txt_giaBan.Text)))
                    {
                        MessageBox.Show("Thêm thành công!");
                        //dataGridView1.DataSource = dv.GetDICHVUs();
                    }

                    else
                        MessageBox.Show("Thêm thất bại!");

                }
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            int maloai = int.Parse(txt_madv.Text);

            DialogResult d = MessageBox.Show("Bạn có chắc muốn Xóa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                if (dv.xoaDV(maloai))
                    MessageBox.Show("Xóa thành công!");
                else
                    MessageBox.Show("Xóa thất bại!");
                //dataGridView1.DataSource = dv.GetDICHVUs();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn có chắc muốn Sửa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {

                if (dv.updateDV(int.Parse(txt_madv.Text), txt_tendv.Text, float.Parse(txt_giaBan.Text)))
                    MessageBox.Show("Sửa thành công!");
                else
                    MessageBox.Show("Sửa thất bại!");
                //dataGridView1.DataSource = dv.GetDICHVUs();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //if (dataGridView1.SelectedRows.Count > 0)
            //{
            //    DataGridViewRow r = dataGridView1.SelectedRows[0];
            //    txt_madv.Text = r.Cells[0].Value.ToString().Trim();
            //    txt_tendv.Text = r.Cells[1].Value.ToString().Trim();
            //    txt_giaBan.Text = r.Cells[2].Value.ToString().Trim();
             
            //}
        }

      
    }
}