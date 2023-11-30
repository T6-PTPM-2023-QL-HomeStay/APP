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
namespace QLHomeStay_App.Resources

{
    public partial class frm_DichVu : Form
    {
        DAL_DICHVU dICHVU = new DAL_DICHVU();
       
        public frm_DichVu()
        {
            InitializeComponent();
           
            dgv_dv.DataSource = dICHVU.ConvertDICHVUsToDataTable();
            dgv_dv.Columns["MADV"].HeaderText = "Mã DV";
            dgv_dv.Columns["TENDV"].HeaderText = "Tên DV";
            dgv_dv.Columns["MAPHONG"].HeaderText = "Mã Phòng";
            cbo_phong.DataSource = dICHVU.loadPhong();

        }
        
        private void btn_phong_Click(object sender, EventArgs e)
        {
            frm_Phong frm_Phong = new frm_Phong();
            frm_Phong.ShowDialog();
            
        }
        
        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_madv.Text.Trim() == string.Empty || txt_tendv.Text.Trim() == string.Empty || cbo_phong.SelectedIndex<0)
                MessageBox.Show("Vui lòng điền đủ thông tin");
            else
            {
                DialogResult d = MessageBox.Show("Bạn có chắc muốn Thêm?", "Xác nhận", MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)
                {
                    DICHVU p = new DICHVU
                    {
                        MADV = txt_madv.Text,
                        TENDV = txt_tendv.Text,
                        MAPHONG = cbo_phong.SelectedItem.ToString(),
                        
                    };
                    if (dICHVU.themDichVu(p))
                    {
                        MessageBox.Show("Thêm thành công!");
                        dgv_dv.DataSource = dICHVU.ConvertDICHVUsToDataTable();
                    }

                    else
                        MessageBox.Show("Thêm thất bại!");
                   
                }
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {

            string maNP = txt_madv.Text;

            DialogResult d = MessageBox.Show("Bạn có chắc muốn Xóa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                if (dICHVU.xoaDichVu(maNP))
                    MessageBox.Show("Xóa thành công!");
                else
                    MessageBox.Show("Xóa thất bại!");
                dgv_dv.DataSource = dICHVU.ConvertDICHVUsToDataTable();

            }

        }
       
        
    

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn có chắc muốn Sửa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                DICHVU p = new DICHVU
                {
                    MADV = txt_madv.Text.Trim(),
                    TENDV = txt_tendv.Text,
                    MAPHONG =cbo_phong.SelectedIndex.ToString(),
                    
                };
                if (dICHVU.suaDichVu(p))
                    MessageBox.Show("Sửa thành công!");
                else
                    MessageBox.Show("Sửa thất bại!");
                dgv_dv.DataSource = dICHVU.GetDICHVUs();
            }
        }
    }
}
