using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHomeStay_App.GUI
{
    public partial class CTHD : Form
    {
        public CTHD()
        {
            InitializeComponent();
        }

        private void cTHDBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cTHDBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qL_KH);

        }

        private void CTHD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_KH.CTHD' table. You can move, or remove it, as needed.
            this.cTHDTableAdapter.Fill(this.qL_KH.CTHD);

        }
    }
}
