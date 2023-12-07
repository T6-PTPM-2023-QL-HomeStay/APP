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
    public partial class frmQLKH : DevExpress.XtraEditors.XtraForm
    {
        DAL_KHACHHANG kh = new DAL_KHACHHANG();
        public frmQLKH()
        {
            InitializeComponent();
            mATKComboBox.DataSource = kh.getMaTK();
            mATKComboBox.SelectedItem = 0;
        }

        private void btn_tk_Click(object sender, EventArgs e)
        {
            frm_QLTK frm_QLTK = new frm_QLTK();
            frm_QLTK.ShowDialog();
        }

        private void kHACHHANGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.kHACHHANGBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.qL_KH);
                MessageBox.Show("Lưu thành công");
            }
            catch
            {
                MessageBox.Show("Lưu thất bại");
            }

        }

        private void frmQLKH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_KH.KHACHHANG' table. You can move, or remove it, as needed.
            this.kHACHHANGTableAdapter.Fill(this.qL_KH.KHACHHANG);

        }
    }
}