﻿using System;
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
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            frm_Main frm_Main = new frm_Main();
            frm_Main.ShowDialog();
        }
    }
}
