namespace QLHomeStay_App
{
    partial class frm_QLTK
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSearchNV = new System.Windows.Forms.TextBox();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_them = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabNV = new System.Windows.Forms.TabControl();
            this.tabSearchNV = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbo_quyen = new System.Windows.Forms.ComboBox();
            this.txt_mk = new System.Windows.Forms.TextBox();
            this.txt_tendangnhap = new System.Windows.Forms.TextBox();
            this.txt_matk = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_capnhat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_tk = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.tabNV.SuspendLayout();
            this.tabSearchNV.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tk)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchNV
            // 
            this.txtSearchNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSearchNV.Location = new System.Drawing.Point(1103, 73);
            this.txtSearchNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchNV.Name = "txtSearchNV";
            this.txtSearchNV.Size = new System.Drawing.Size(272, 30);
            this.txtSearchNV.TabIndex = 30;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "diachi";
            this.Column2.HeaderText = "Địa chỉ";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.btn_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_them.ForeColor = System.Drawing.Color.White;
            this.btn_them.Location = new System.Drawing.Point(44, 524);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(133, 52);
            this.btn_them.TabIndex = 74;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label4.Location = new System.Drawing.Point(120, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 72;
            this.label4.Text = "Mã TK:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label6.Location = new System.Drawing.Point(96, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 25);
            this.label6.TabIndex = 70;
            this.label6.Text = "Mật khẩu:";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "sdt";
            this.Column8.HeaderText = "SĐT";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 125;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "hotennv";
            this.Column7.HeaderText = "Họ tên";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "iduser";
            this.Column6.HeaderText = "ID User";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // tabNV
            // 
            this.tabNV.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabNV.Controls.Add(this.tabSearchNV);
            this.tabNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabNV.Location = new System.Drawing.Point(-230, -37);
            this.tabNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabNV.Name = "tabNV";
            this.tabNV.SelectedIndex = 0;
            this.tabNV.Size = new System.Drawing.Size(1744, 820);
            this.tabNV.TabIndex = 5;
            // 
            // tabSearchNV
            // 
            this.tabSearchNV.BackColor = System.Drawing.Color.White;
            this.tabSearchNV.Controls.Add(this.guna2Button1);
            this.tabSearchNV.Controls.Add(this.groupBox2);
            this.tabSearchNV.Controls.Add(this.groupBox1);
            this.tabSearchNV.Controls.Add(this.label16);
            this.tabSearchNV.Controls.Add(this.txtSearchNV);
            this.tabSearchNV.Location = new System.Drawing.Point(4, 4);
            this.tabSearchNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabSearchNV.Name = "tabSearchNV";
            this.tabSearchNV.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabSearchNV.Size = new System.Drawing.Size(1736, 787);
            this.tabSearchNV.TabIndex = 1;
            this.tabSearchNV.Text = "Chi Tiết";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbo_quyen);
            this.groupBox2.Controls.Add(this.txt_mk);
            this.groupBox2.Controls.Add(this.txt_tendangnhap);
            this.groupBox2.Controls.Add(this.txt_matk);
            this.groupBox2.Controls.Add(this.btn_them);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.btn_xoa);
            this.groupBox2.Controls.Add(this.btn_capnhat);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(243, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(566, 601);
            this.groupBox2.TabIndex = 63;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin tài khoản";
            // 
            // cbo_quyen
            // 
            this.cbo_quyen.FormattingEnabled = true;
            this.cbo_quyen.Location = new System.Drawing.Point(224, 324);
            this.cbo_quyen.Name = "cbo_quyen";
            this.cbo_quyen.Size = new System.Drawing.Size(306, 30);
            this.cbo_quyen.TabIndex = 78;
            // 
            // txt_mk
            // 
            this.txt_mk.Location = new System.Drawing.Point(224, 266);
            this.txt_mk.Name = "txt_mk";
            this.txt_mk.Size = new System.Drawing.Size(306, 28);
            this.txt_mk.TabIndex = 77;
            // 
            // txt_tendangnhap
            // 
            this.txt_tendangnhap.Location = new System.Drawing.Point(224, 214);
            this.txt_tendangnhap.Name = "txt_tendangnhap";
            this.txt_tendangnhap.Size = new System.Drawing.Size(306, 28);
            this.txt_tendangnhap.TabIndex = 77;
            // 
            // txt_matk
            // 
            this.txt_matk.Location = new System.Drawing.Point(224, 158);
            this.txt_matk.Name = "txt_matk";
            this.txt_matk.Size = new System.Drawing.Size(306, 28);
            this.txt_matk.TabIndex = 77;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label7.Location = new System.Drawing.Point(39, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 25);
            this.label7.TabIndex = 68;
            this.label7.Text = "Tên đăng nhập:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label13.Location = new System.Drawing.Point(120, 329);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 25);
            this.label13.TabIndex = 63;
            this.label13.Text = "Quyền:";
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_xoa.ForeColor = System.Drawing.Color.White;
            this.btn_xoa.Location = new System.Drawing.Point(356, 525);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(133, 51);
            this.btn_xoa.TabIndex = 62;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.btn_capnhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_capnhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_capnhat.ForeColor = System.Drawing.Color.White;
            this.btn_capnhat.Location = new System.Drawing.Point(201, 525);
            this.btn_capnhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(133, 51);
            this.btn_capnhat.TabIndex = 61;
            this.btn_capnhat.Text = "Cập nhật";
            this.btn_capnhat.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_tk);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(847, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 601);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách tài khoản";
            // 
            // dgv_tk
            // 
            this.dgv_tk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tk.Location = new System.Drawing.Point(23, 34);
            this.dgv_tk.Name = "dgv_tk";
            this.dgv_tk.RowHeadersWidth = 51;
            this.dgv_tk.RowTemplate.Height = 24;
            this.dgv_tk.Size = new System.Drawing.Size(600, 542);
            this.dgv_tk.TabIndex = 0;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label16.Location = new System.Drawing.Point(973, 76);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(106, 25);
            this.label16.TabIndex = 31;
            this.label16.Text = "Tìm kiếm:";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "chucvu";
            this.Column3.HeaderText = "Chức vụ";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "luong";
            this.Column1.HeaderText = "Lương";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "idnv";
            this.Column5.HeaderText = "ID Nhân viên";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.guna2Button1.ForeColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Image = global::QLHomeStay_App.Properties.Resources.search1;
            this.guna2Button1.ImageSize = new System.Drawing.Size(35, 35);
            this.guna2Button1.Location = new System.Drawing.Point(1397, 73);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(60, 36);
            this.guna2Button1.TabIndex = 146;
            // 
            // frm_QLTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 746);
            this.Controls.Add(this.tabNV);
            this.Name = "frm_QLTK";
            this.Text = "QUẢN LÝ TÀI KHOẢN";
            this.tabNV.ResumeLayout(false);
            this.tabSearchNV.ResumeLayout(false);
            this.tabSearchNV.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.TabControl tabNV;
        private System.Windows.Forms.TabPage tabSearchNV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_capnhat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_tk;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TextBox txt_mk;
        private System.Windows.Forms.TextBox txt_tendangnhap;
        private System.Windows.Forms.TextBox txt_matk;
        private System.Windows.Forms.ComboBox cbo_quyen;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}