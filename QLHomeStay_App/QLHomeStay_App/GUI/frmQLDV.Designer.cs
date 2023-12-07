namespace QLHomeStay_App.GUI
{
    partial class frmQLDV
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_sua = new Guna.UI2.WinForms.Guna2Button();
            this.btn_xoa = new Guna.UI2.WinForms.Guna2Button();
            this.btn_them = new Guna.UI2.WinForms.Guna2Button();
            this.txt_tendv = new System.Windows.Forms.TextBox();
            this.txt_madv = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_giaBan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.guna2GroupBox2.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1154, 308);
            this.dataGridView1.TabIndex = 0;
          //  this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.Controls.Add(this.dataGridView1);
            this.guna2GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox2.Location = new System.Drawing.Point(0, 395);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(1154, 348);
            this.guna2GroupBox2.TabIndex = 3;
            this.guna2GroupBox2.Text = "Danh sách dịch vụ";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.groupBox2);
            this.guna2GroupBox1.Controls.Add(this.pictureBox1);
            this.guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(1154, 395);
            this.guna2GroupBox1.TabIndex = 2;
            this.guna2GroupBox1.Text = "Thông tin chi tiết";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_giaBan);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btn_sua);
            this.groupBox2.Controls.Add(this.btn_xoa);
            this.groupBox2.Controls.Add(this.btn_them);
            this.groupBox2.Controls.Add(this.txt_tendv);
            this.groupBox2.Controls.Add(this.txt_madv);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(388, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(766, 355);
            this.groupBox2.TabIndex = 139;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin dịch vụ";
            // 
            // btn_sua
            // 
            this.btn_sua.BorderColor = System.Drawing.Color.Transparent;
            this.btn_sua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_sua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_sua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_sua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_sua.FillColor = System.Drawing.Color.Transparent;
            this.btn_sua.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.btn_sua.ForeColor = System.Drawing.Color.Transparent;
            this.btn_sua.Image = global::QLHomeStay_App.Properties.Resources.refresh;
            this.btn_sua.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_sua.Location = new System.Drawing.Point(442, 234);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(101, 80);
            this.btn_sua.TabIndex = 160;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BorderColor = System.Drawing.Color.Transparent;
            this.btn_xoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_xoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_xoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_xoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_xoa.FillColor = System.Drawing.Color.Transparent;
            this.btn_xoa.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.btn_xoa.ForeColor = System.Drawing.Color.Transparent;
            this.btn_xoa.Image = global::QLHomeStay_App.Properties.Resources.remove;
            this.btn_xoa.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_xoa.Location = new System.Drawing.Point(283, 234);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(101, 80);
            this.btn_xoa.TabIndex = 161;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.BorderColor = System.Drawing.Color.Transparent;
            this.btn_them.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_them.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_them.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_them.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_them.FillColor = System.Drawing.Color.Transparent;
            this.btn_them.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.btn_them.ForeColor = System.Drawing.Color.Transparent;
            this.btn_them.Image = global::QLHomeStay_App.Properties.Resources.checked3;
            this.btn_them.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_them.Location = new System.Drawing.Point(112, 234);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(101, 80);
            this.btn_them.TabIndex = 162;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // txt_tendv
            // 
            this.txt_tendv.Location = new System.Drawing.Point(251, 118);
            this.txt_tendv.Name = "txt_tendv";
            this.txt_tendv.Size = new System.Drawing.Size(215, 28);
            this.txt_tendv.TabIndex = 145;
            // 
            // txt_madv
            // 
            this.txt_madv.Location = new System.Drawing.Point(251, 67);
            this.txt_madv.Name = "txt_madv";
            this.txt_madv.Size = new System.Drawing.Size(215, 28);
            this.txt_madv.TabIndex = 145;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(99, 125);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 21);
            this.label10.TabIndex = 135;
            this.label10.Text = "Tên dịch vụ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(99, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 21);
            this.label1.TabIndex = 131;
            this.label1.Text = "Mã dịch vụ:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::QLHomeStay_App.Properties.Resources.food_trolley;
            this.pictureBox1.Location = new System.Drawing.Point(0, 40);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(388, 355);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 112;
            this.pictureBox1.TabStop = false;
            // 
            // txt_giaBan
            // 
            this.txt_giaBan.Location = new System.Drawing.Point(251, 173);
            this.txt_giaBan.Name = "txt_giaBan";
            this.txt_giaBan.Size = new System.Drawing.Size(215, 28);
            this.txt_giaBan.TabIndex = 164;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(99, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 163;
            this.label2.Text = "Đơn giá:";
            // 
            // frmQLDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 743);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.guna2GroupBox1);
            this.Name = "frmQLDV";
            this.Text = "DỊCH VỤ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_tendv;
        private System.Windows.Forms.TextBox txt_madv;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_sua;
        private Guna.UI2.WinForms.Guna2Button btn_xoa;
        private Guna.UI2.WinForms.Guna2Button btn_them;
        private System.Windows.Forms.TextBox txt_giaBan;
        private System.Windows.Forms.Label label2;
    }
}