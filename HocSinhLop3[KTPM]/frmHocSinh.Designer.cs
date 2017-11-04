namespace HocSinhLop3_KTPM_
{
    partial class frmHocSinh
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btXemKq = new System.Windows.Forms.Button();
            this.btTiepTuc = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSo1 = new System.Windows.Forms.TextBox();
            this.txtKq = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbDau = new System.Windows.Forms.Label();
            this.txtSo2 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btXemLichSu = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btXemThongTin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btXemKq);
            this.groupBox1.Controls.Add(this.btTiepTuc);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(721, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Làm bài tập";
            // 
            // btXemKq
            // 
            this.btXemKq.Location = new System.Drawing.Point(579, 114);
            this.btXemKq.Name = "btXemKq";
            this.btXemKq.Size = new System.Drawing.Size(136, 34);
            this.btXemKq.TabIndex = 7;
            this.btXemKq.Text = "Xem kết quả";
            this.btXemKq.UseVisualStyleBackColor = true;
            this.btXemKq.Click += new System.EventHandler(this.btXemKq_Click);
            // 
            // btTiepTuc
            // 
            this.btTiepTuc.Location = new System.Drawing.Point(430, 114);
            this.btTiepTuc.Name = "btTiepTuc";
            this.btTiepTuc.Size = new System.Drawing.Size(136, 34);
            this.btTiepTuc.TabIndex = 6;
            this.btTiepTuc.Text = "Tiếp tục";
            this.btTiepTuc.UseVisualStyleBackColor = true;
            this.btTiepTuc.Click += new System.EventHandler(this.btTiepTuc_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSo1);
            this.panel1.Controls.Add(this.txtKq);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbDau);
            this.panel1.Controls.Add(this.txtSo2);
            this.panel1.Location = new System.Drawing.Point(6, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 123);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // txtSo1
            // 
            this.txtSo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSo1.Location = new System.Drawing.Point(3, 36);
            this.txtSo1.Multiline = true;
            this.txtSo1.Name = "txtSo1";
            this.txtSo1.ReadOnly = true;
            this.txtSo1.Size = new System.Drawing.Size(100, 50);
            this.txtSo1.TabIndex = 0;
            this.txtSo1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtKq
            // 
            this.txtKq.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKq.Location = new System.Drawing.Point(315, 36);
            this.txtKq.Multiline = true;
            this.txtKq.Name = "txtKq";
            this.txtKq.Size = new System.Drawing.Size(100, 50);
            this.txtKq.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(271, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "=";
            // 
            // lbDau
            // 
            this.lbDau.AutoSize = true;
            this.lbDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDau.Location = new System.Drawing.Point(115, 45);
            this.lbDau.Name = "lbDau";
            this.lbDau.Size = new System.Drawing.Size(32, 33);
            this.lbDau.TabIndex = 3;
            this.lbDau.Text = "+";
            // 
            // txtSo2
            // 
            this.txtSo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSo2.Location = new System.Drawing.Point(159, 36);
            this.txtSo2.Multiline = true;
            this.txtSo2.Name = "txtSo2";
            this.txtSo2.ReadOnly = true;
            this.txtSo2.Size = new System.Drawing.Size(100, 50);
            this.txtSo2.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(430, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(285, 84);
            this.listBox1.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 184);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(721, 122);
            this.dataGridView1.TabIndex = 1;
            // 
            // btXemLichSu
            // 
            this.btXemLichSu.Location = new System.Drawing.Point(12, 312);
            this.btXemLichSu.Name = "btXemLichSu";
            this.btXemLichSu.Size = new System.Drawing.Size(136, 34);
            this.btXemLichSu.TabIndex = 7;
            this.btXemLichSu.Text = "Xem lịch sử làm bài";
            this.btXemLichSu.UseVisualStyleBackColor = true;
            this.btXemLichSu.Click += new System.EventHandler(this.btXemLichSu_Click);
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(591, 312);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(136, 34);
            this.btThoat.TabIndex = 8;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(154, 326);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 20);
            this.textBox1.TabIndex = 9;
            // 
            // btXemThongTin
            // 
            this.btXemThongTin.Location = new System.Drawing.Point(442, 312);
            this.btXemThongTin.Name = "btXemThongTin";
            this.btXemThongTin.Size = new System.Drawing.Size(136, 34);
            this.btXemThongTin.TabIndex = 10;
            this.btXemThongTin.Text = "Xem thông tin tài khoản";
            this.btXemThongTin.UseVisualStyleBackColor = true;
            this.btXemThongTin.Click += new System.EventHandler(this.btXemThongTin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(354, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "**Phép chia lấy kết quả gần bằng(vd: 4 / 3 = 1.3333 thì ghi kết quả là 1). ";
            // 
            // frmHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 374);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btXemThongTin);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btXemLichSu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmHocSinh";
            this.Load += new System.EventHandler(this.frmHocSinh_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbDau;
        private System.Windows.Forms.TextBox txtKq;
        private System.Windows.Forms.TextBox txtSo2;
        private System.Windows.Forms.TextBox txtSo1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btXemKq;
        private System.Windows.Forms.Button btTiepTuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btXemLichSu;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btXemThongTin;
        private System.Windows.Forms.Label label3;
    }
}