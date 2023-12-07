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
    public partial class frmQLHD : DevExpress.XtraEditors.XtraForm
    {
        public frmQLHD()
        {
            InitializeComponent();
            mAKHComboBox.DataSource = kh.getAllMaKH();
            mAKHComboBox.SelectedItem = 0;

        }
        DAL_KHACHHANG kh = new DAL_KHACHHANG();
        DALL_HOADON hd = new DALL_HOADON();

        private void hOADONBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {


        }


        private void frmQLHD_Load(object sender, EventArgs e)
        {
           dataGridView1.DataSource= hd.GetHOADONs();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (mAHDSpinEdit1.Text.Trim() == string.Empty || mAKHComboBox.Text.Trim() == string.Empty || nGAYTAODateEdit.Text.Trim() == string.Empty)
                MessageBox.Show("Vui lòng điền đủ thông tin");
            else
            {
                DialogResult d = MessageBox.Show("Bạn có chắc muốn Thêm?", "Xác nhận", MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)
                {

                    if (hd.insertHD(int.Parse(mAHDSpinEdit1.Text), mAKHComboBox.SelectedItem.ToString(), DateTime.Parse(nGAYTAODateEdit.Text)))
                    {
                        MessageBox.Show("Thêm thành công!");
                        dataGridView1.DataSource = hd.GetHOADONs();
                        
                        
                    }

                    else
                        MessageBox.Show("Thêm thất bại!");

                }
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            int maloai = int.Parse(mAHDSpinEdit1.Text);

            DialogResult d = MessageBox.Show("Bạn có chắc muốn Xóa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                if (hd.xoaHD(maloai))
                    MessageBox.Show("Xóa thành công!");
                else
                    MessageBox.Show("Xóa thất bại!");
                dataGridView1.DataSource = hd.GetHOADONs();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn có chắc muốn Sửa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {

                if (hd.updateHD(int.Parse(mAHDSpinEdit1.Text), mAKHComboBox.SelectedItem.ToString(), DateTime.Parse(nGAYTAODateEdit.Text)))
                    MessageBox.Show("Sửa thành công!");
                else
                    MessageBox.Show("Sửa thất bại!");
                dataGridView1.DataSource = hd.GetHOADONs();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dataGridView1.SelectedRows[0];
                mAHDSpinEdit1.Text = r.Cells[0].Value.ToString().Trim();
                mAKHComboBox.Text = r.Cells[1].Value.ToString().Trim();
                nGAYTAODateEdit.Text = r.Cells[2].Value.ToString().Trim();
              //  cbo_quyen.Text = r.Cells[3].Value.ToString().Trim();
            }
        }

        private void btn_CTHD_Click(object sender, EventArgs e)
        {
            frmCTHD t = new frmCTHD();
            t.Show();
        }
    }

}
