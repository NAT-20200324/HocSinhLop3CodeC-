namespace HocSinhLop3_KTPM_
{
    partial class frmGiaoVien
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btDanhSachLop = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btLuuNhanXet = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.btTim = new System.Windows.Forms.Button();
            this.txtMaBaiTap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btLichSuLamBai = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbTaiKhoan = new System.Windows.Forms.ComboBox();
            this.giaoVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLHocSinhLop3DataSet2 = new HocSinhLop3_KTPM_.QLHocSinhLop3DataSet2();
            this.giaoVienTableAdapter = new HocSinhLop3_KTPM_.QLHocSinhLop3DataSet2TableAdapters.GiaoVienTableAdapter();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.btThoat = new System.Windows.Forms.Button();
            this.btHsKlBt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.giaoVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHocSinhLop3DataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(721, 177);
            this.dataGridView1.TabIndex = 0;
            // 
            // btDanhSachLop
            // 
            this.btDanhSachLop.Location = new System.Drawing.Point(12, 140);
            this.btDanhSachLop.Name = "btDanhSachLop";
            this.btDanhSachLop.Size = new System.Drawing.Size(139, 23);
            this.btDanhSachLop.TabIndex = 1;
            this.btDanhSachLop.Text = "Danh sách học sinh";
            this.btDanhSachLop.UseVisualStyleBackColor = true;
            this.btDanhSachLop.Click += new System.EventHandler(this.btDanhSachLop_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btLuuNhanXet);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtGhiChu);
            this.groupBox1.Controls.Add(this.btTim);
            this.groupBox1.Controls.Add(this.txtMaBaiTap);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTaiKhoan);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(721, 122);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btLuuNhanXet
            // 
            this.btLuuNhanXet.Location = new System.Drawing.Point(596, 86);
            this.btLuuNhanXet.Name = "btLuuNhanXet";
            this.btLuuNhanXet.Size = new System.Drawing.Size(119, 29);
            this.btLuuNhanXet.TabIndex = 8;
            this.btLuuNhanXet.Text = "Lưu nhận xét";
            this.btLuuNhanXet.UseVisualStyleBackColor = true;
            this.btLuuNhanXet.Click += new System.EventHandler(this.btLuuNhanXet_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nhận xét";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(123, 48);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(467, 67);
            this.txtGhiChu.TabIndex = 5;
            // 
            // btTim
            // 
            this.btTim.Location = new System.Drawing.Point(270, 16);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(75, 26);
            this.btTim.TabIndex = 4;
            this.btTim.Text = "Tìm";
            this.btTim.UseVisualStyleBackColor = true;
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // txtMaBaiTap
            // 
            this.txtMaBaiTap.Location = new System.Drawing.Point(452, 16);
            this.txtMaBaiTap.Name = "txtMaBaiTap";
            this.txtMaBaiTap.Size = new System.Drawing.Size(135, 26);
            this.txtMaBaiTap.TabIndex = 3;
            this.txtMaBaiTap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaBaiTap_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã bài tập";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(123, 16);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(135, 26);
            this.txtTaiKhoan.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản HS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 4;
            // 
            // btLichSuLamBai
            // 
            this.btLichSuLamBai.Location = new System.Drawing.Point(289, 140);
            this.btLichSuLamBai.Name = "btLichSuLamBai";
            this.btLichSuLamBai.Size = new System.Drawing.Size(139, 23);
            this.btLichSuLamBai.TabIndex = 5;
            this.btLichSuLamBai.Text = "Lịch sử làm bài";
            this.btLichSuLamBai.UseVisualStyleBackColor = true;
            this.btLichSuLamBai.Click += new System.EventHandler(this.btLichSuLamBai_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(320, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "**Giáo viên chỉ có thể nhận xét những học sinh trong lớp của mình";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(459, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "***Khi nhấn [Lịch sử làm bài], nếu không điền mã tài khoản thì sẽ hiện lịch sử là" +
    "m bài của lớp đó";
            // 
            // cbTaiKhoan
            // 
            this.cbTaiKhoan.DataSource = this.giaoVienBindingSource;
            this.cbTaiKhoan.DisplayMember = "TaiKhoan";
            this.cbTaiKhoan.FormattingEnabled = true;
            this.cbTaiKhoan.Location = new System.Drawing.Point(157, 142);
            this.cbTaiKhoan.Name = "cbTaiKhoan";
            this.cbTaiKhoan.Size = new System.Drawing.Size(126, 21);
            this.cbTaiKhoan.TabIndex = 8;
            this.cbTaiKhoan.ValueMember = "MaLop";
            this.cbTaiKhoan.SelectedIndexChanged += new System.EventHandler(this.cbTaiKhoan_SelectedIndexChanged);
            // 
            // giaoVienBindingSource
            // 
            this.giaoVienBindingSource.DataMember = "GiaoVien";
            this.giaoVienBindingSource.DataSource = this.qLHocSinhLop3DataSet2;
            // 
            // qLHocSinhLop3DataSet2
            // 
            this.qLHocSinhLop3DataSet2.DataSetName = "QLHocSinhLop3DataSet2";
            this.qLHocSinhLop3DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // giaoVienTableAdapter
            // 
            this.giaoVienTableAdapter.ClearBeforeFill = true;
            // 
            // txtLop
            // 
            this.txtLop.Location = new System.Drawing.Point(434, 143);
            this.txtLop.Name = "txtLop";
            this.txtLop.ReadOnly = true;
            this.txtLop.Size = new System.Drawing.Size(100, 20);
            this.txtLop.TabIndex = 9;
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(608, 349);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(125, 29);
            this.btThoat.TabIndex = 10;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btHsKlBt
            // 
            this.btHsKlBt.Location = new System.Drawing.Point(540, 140);
            this.btHsKlBt.Name = "btHsKlBt";
            this.btHsKlBt.Size = new System.Drawing.Size(187, 23);
            this.btHsKlBt.TabIndex = 11;
            this.btHsKlBt.Text = "Học sinh không làm bài tập";
            this.btHsKlBt.UseVisualStyleBackColor = true;
            this.btHsKlBt.Click += new System.EventHandler(this.btHsKlBt_Click);
            // 
            // frmGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 387);
            this.Controls.Add(this.btHsKlBt);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.txtLop);
            this.Controls.Add(this.cbTaiKhoan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btLichSuLamBai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btDanhSachLop);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmGiaoVien";
            this.Text = "frmGiaoVien";
            this.Load += new System.EventHandler(this.frmGiaoVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.giaoVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHocSinhLop3DataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btDanhSachLop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.TextBox txtMaBaiTap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Button btLuuNhanXet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btLichSuLamBai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbTaiKhoan;
        private QLHocSinhLop3DataSet2 qLHocSinhLop3DataSet2;
        private System.Windows.Forms.BindingSource giaoVienBindingSource;
        private QLHocSinhLop3DataSet2TableAdapters.GiaoVienTableAdapter giaoVienTableAdapter;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btHsKlBt;

    }
}