namespace QLHomeStay_App
{
    partial class frm_QLKM
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_QLKM));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label15 = new System.Windows.Forms.Label();
            this.dgv_khuyenmai = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_giatri = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dt_ngaybatdau = new System.Windows.Forms.DateTimePicker();
            this.dt_ngayketthuc = new System.Windows.Forms.DateTimePicker();
            this.txt_makm = new System.Windows.Forms.TextBox();
            this.txt_tenkm = new System.Windows.Forms.TextBox();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStripChucNang = new System.Windows.Forms.ToolStrip();
            this.btn_them = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btn_reset = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_khuyenmai)).BeginInit();
            this.toolStripChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1288, 730);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabPage3.Controls.Add(this.tableLayoutPanel1);
            this.tabPage3.Controls.Add(this.toolStripChucNang);
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(1280, 695);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Khuyến mãi";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.10377F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.748427F));
            this.tableLayoutPanel1.Controls.Add(this.label15, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgv_khuyenmai, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label12, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_giatri, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.dt_ngaybatdau, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.dt_ngayketthuc, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_makm, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_tenkm, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_soluong, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label11, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 6, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 31);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1272, 660);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.SetColumnSpan(this.label15, 7);
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(4, 0);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(1264, 30);
            this.label15.TabIndex = 14;
            this.label15.Text = "QUẢN LÝ KHUYẾN MÃI";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_khuyenmai
            // 
            this.dgv_khuyenmai.AllowUserToAddRows = false;
            this.dgv_khuyenmai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_khuyenmai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_khuyenmai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column6,
            this.Column4,
            this.Column5});
            this.tableLayoutPanel1.SetColumnSpan(this.dgv_khuyenmai, 7);
            this.dgv_khuyenmai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_khuyenmai.Location = new System.Drawing.Point(4, 124);
            this.dgv_khuyenmai.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgv_khuyenmai.Name = "dgv_khuyenmai";
            this.dgv_khuyenmai.ReadOnly = true;
            this.dgv_khuyenmai.RowHeadersWidth = 51;
            this.dgv_khuyenmai.RowTemplate.Height = 24;
            this.dgv_khuyenmai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_khuyenmai.Size = new System.Drawing.Size(1264, 534);
            this.dgv_khuyenmai.TabIndex = 15;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã khuyễn mãi";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên khuyễn mãi";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Số lượng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Giá trị";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ngày bắt đầu";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Ngày kết thúc";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(366, 30);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 22);
            this.label6.TabIndex = 16;
            this.label6.Text = "Mã khuyến mãi:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(366, 60);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 22);
            this.label9.TabIndex = 16;
            this.label9.Text = "Tên khuyễn mãi:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(728, 60);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 22);
            this.label12.TabIndex = 16;
            this.label12.Text = "Ngày bắt đầu:";
            // 
            // txt_giatri
            // 
            this.txt_giatri.Location = new System.Drawing.Point(909, 32);
            this.txt_giatri.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt_giatri.Name = "txt_giatri";
            this.txt_giatri.Size = new System.Drawing.Size(234, 29);
            this.txt_giatri.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(728, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ngày kết thúc:";
            // 
            // dt_ngaybatdau
            // 
            this.dt_ngaybatdau.Location = new System.Drawing.Point(909, 64);
            this.dt_ngaybatdau.Margin = new System.Windows.Forms.Padding(4);
            this.dt_ngaybatdau.Name = "dt_ngaybatdau";
            this.dt_ngaybatdau.Size = new System.Drawing.Size(234, 29);
            this.dt_ngaybatdau.TabIndex = 19;
            // 
            // dt_ngayketthuc
            // 
            this.dt_ngayketthuc.Location = new System.Drawing.Point(909, 98);
            this.dt_ngayketthuc.Margin = new System.Windows.Forms.Padding(4);
            this.dt_ngayketthuc.Name = "dt_ngayketthuc";
            this.dt_ngayketthuc.Size = new System.Drawing.Size(234, 29);
            this.dt_ngayketthuc.TabIndex = 19;
            // 
            // txt_makm
            // 
            this.txt_makm.Location = new System.Drawing.Point(547, 32);
            this.txt_makm.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt_makm.Name = "txt_makm";
            this.txt_makm.Size = new System.Drawing.Size(172, 29);
            this.txt_makm.TabIndex = 18;
            // 
            // txt_tenkm
            // 
            this.txt_tenkm.Location = new System.Drawing.Point(547, 62);
            this.txt_tenkm.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt_tenkm.Name = "txt_tenkm";
            this.txt_tenkm.Size = new System.Drawing.Size(172, 29);
            this.txt_tenkm.TabIndex = 18;
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(547, 96);
            this.txt_soluong.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(172, 29);
            this.txt_soluong.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(728, 30);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 22);
            this.label11.TabIndex = 16;
            this.label11.Text = "Giá trị:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 22);
            this.label2.TabIndex = 16;
            this.label2.Text = "Số lượng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1150, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 22);
            this.label3.TabIndex = 20;
            this.label3.Text = "(VNĐ)";
            // 
            // toolStripChucNang
            // 
            this.toolStripChucNang.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripChucNang.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_them,
            this.btnXoa,
            this.btnSua,
            this.btn_reset,
            this.toolStripSeparator1});
            this.toolStripChucNang.Location = new System.Drawing.Point(4, 4);
            this.toolStripChucNang.Name = "toolStripChucNang";
            this.toolStripChucNang.Size = new System.Drawing.Size(1272, 27);
            this.toolStripChucNang.TabIndex = 6;
            this.toolStripChucNang.Text = "toolStrip1";
            // 
            // btn_them
            // 
            this.btn_them.Image = ((System.Drawing.Image)(resources.GetObject("btn_them.Image")));
            this.btn_them.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(70, 24);
            this.btn_them.Text = "Thêm";
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(59, 24);
            this.btnXoa.Text = "Xoá";
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(58, 24);
            this.btnSua.Text = "Sửa";
            // 
            // btn_reset
            // 
            this.btn_reset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(49, 24);
            this.btn_reset.Text = "Reset";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "search.png");
            // 
            // frm_QLKM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 730);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_QLKM";
            this.Text = "QUẢN LÝ KHUYẾN MÃI";
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_khuyenmai)).EndInit();
            this.toolStripChucNang.ResumeLayout(false);
            this.toolStripChucNang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dgv_khuyenmai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_giatri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dt_ngaybatdau;
        private System.Windows.Forms.DateTimePicker dt_ngayketthuc;
        private System.Windows.Forms.TextBox txt_makm;
        private System.Windows.Forms.TextBox txt_tenkm;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStrip toolStripChucNang;
        private System.Windows.Forms.ToolStripButton btn_them;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btn_reset;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ImageList imageList1;
    }
}