namespace HocSinhLop3_KTPM_
{
    partial class frmDkyGv
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btDKyGv = new System.Windows.Forms.Button();
            this.dtNsinhGv = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.cbLopPtrach = new System.Windows.Forms.ComboBox();
            this.lopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLHocSinhLop3DataSet = new HocSinhLop3_KTPM_.QLHocSinhLop3DataSet();
            this.txtDkyTenGv = new System.Windows.Forms.TextBox();
            this.txtDkyTdemGv = new System.Windows.Forms.TextBox();
            this.txtDkyHoGv = new System.Windows.Forms.TextBox();
            this.txtDkyNlaiMkhauGv = new System.Windows.Forms.TextBox();
            this.txtDkyMkhauGv = new System.Windows.Forms.TextBox();
            this.txtDkyTkhoanGv = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lopTableAdapter = new HocSinhLop3_KTPM_.QLHocSinhLop3DataSetTableAdapters.LopTableAdapter();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDthoaiGv = new System.Windows.Forms.TextBox();
            this.txtDchiGv = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHocSinhLop3DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDchiGv);
            this.groupBox1.Controls.Add(this.txtDthoaiGv);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btDKyGv);
            this.groupBox1.Controls.Add(this.dtNsinhGv);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbLopPtrach);
            this.groupBox1.Controls.Add(this.txtDkyTenGv);
            this.groupBox1.Controls.Add(this.txtDkyTdemGv);
            this.groupBox1.Controls.Add(this.txtDkyHoGv);
            this.groupBox1.Controls.Add(this.txtDkyNlaiMkhauGv);
            this.groupBox1.Controls.Add(this.txtDkyMkhauGv);
            this.groupBox1.Controls.Add(this.txtDkyTkhoanGv);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(721, 334);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin giáo viên";
            // 
            // btDKyGv
            // 
            this.btDKyGv.Location = new System.Drawing.Point(570, 256);
            this.btDKyGv.Name = "btDKyGv";
            this.btDKyGv.Size = new System.Drawing.Size(144, 72);
            this.btDKyGv.TabIndex = 17;
            this.btDKyGv.Text = "Đăng ký";
            this.btDKyGv.UseVisualStyleBackColor = true;
            this.btDKyGv.Click += new System.EventHandler(this.btDKyGv_Click);
            // 
            // dtNsinhGv
            // 
            this.dtNsinhGv.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNsinhGv.Location = new System.Drawing.Point(544, 188);
            this.dtNsinhGv.Name = "dtNsinhGv";
            this.dtNsinhGv.Size = new System.Drawing.Size(171, 26);
            this.dtNsinhGv.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(383, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Ngày sinh giáo viên";
            // 
            // cbLopPtrach
            // 
            this.cbLopPtrach.DataSource = this.lopBindingSource;
            this.cbLopPtrach.DisplayMember = "TenLop";
            this.cbLopPtrach.Location = new System.Drawing.Point(154, 186);
            this.cbLopPtrach.Name = "cbLopPtrach";
            this.cbLopPtrach.Size = new System.Drawing.Size(171, 28);
            this.cbLopPtrach.TabIndex = 18;
            this.cbLopPtrach.ValueMember = "MaLop";
            // 
            // lopBindingSource
            // 
            this.lopBindingSource.DataMember = "Lop";
            this.lopBindingSource.DataSource = this.qLHocSinhLop3DataSet;
            // 
            // qLHocSinhLop3DataSet
            // 
            this.qLHocSinhLop3DataSet.DataSetName = "QLHocSinhLop3DataSet";
            this.qLHocSinhLop3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtDkyTenGv
            // 
            this.txtDkyTenGv.Location = new System.Drawing.Point(544, 138);
            this.txtDkyTenGv.Name = "txtDkyTenGv";
            this.txtDkyTenGv.Size = new System.Drawing.Size(171, 26);
            this.txtDkyTenGv.TabIndex = 12;
            // 
            // txtDkyTdemGv
            // 
            this.txtDkyTdemGv.Location = new System.Drawing.Point(544, 88);
            this.txtDkyTdemGv.Name = "txtDkyTdemGv";
            this.txtDkyTdemGv.Size = new System.Drawing.Size(171, 26);
            this.txtDkyTdemGv.TabIndex = 11;
            // 
            // txtDkyHoGv
            // 
            this.txtDkyHoGv.Location = new System.Drawing.Point(543, 38);
            this.txtDkyHoGv.Name = "txtDkyHoGv";
            this.txtDkyHoGv.Size = new System.Drawing.Size(171, 26);
            this.txtDkyHoGv.TabIndex = 10;
            // 
            // txtDkyNlaiMkhauGv
            // 
            this.txtDkyNlaiMkhauGv.Location = new System.Drawing.Point(154, 138);
            this.txtDkyNlaiMkhauGv.Name = "txtDkyNlaiMkhauGv";
            this.txtDkyNlaiMkhauGv.Size = new System.Drawing.Size(171, 26);
            this.txtDkyNlaiMkhauGv.TabIndex = 9;
            this.txtDkyNlaiMkhauGv.UseSystemPasswordChar = true;
            // 
            // txtDkyMkhauGv
            // 
            this.txtDkyMkhauGv.Location = new System.Drawing.Point(154, 88);
            this.txtDkyMkhauGv.Name = "txtDkyMkhauGv";
            this.txtDkyMkhauGv.Size = new System.Drawing.Size(171, 26);
            this.txtDkyMkhauGv.TabIndex = 8;
            this.txtDkyMkhauGv.UseSystemPasswordChar = true;
            // 
            // txtDkyTkhoanGv
            // 
            this.txtDkyTkhoanGv.Location = new System.Drawing.Point(154, 38);
            this.txtDkyTkhoanGv.Name = "txtDkyTkhoanGv";
            this.txtDkyTkhoanGv.Size = new System.Drawing.Size(171, 26);
            this.txtDkyTkhoanGv.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Lớp phụ trách";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(383, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tên giáo viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nhập lại mật khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(383, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên đệm giáo viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(383, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ giáo viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản";
            // 
            // lopTableAdapter
            // 
            this.lopTableAdapter.ClearBeforeFill = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Điên thoại";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 291);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Địa chỉ";
            // 
            // txtDthoaiGv
            // 
            this.txtDthoaiGv.Location = new System.Drawing.Point(154, 239);
            this.txtDthoaiGv.Name = "txtDthoaiGv";
            this.txtDthoaiGv.Size = new System.Drawing.Size(171, 26);
            this.txtDthoaiGv.TabIndex = 21;
            // 
            // txtDchiGv
            // 
            this.txtDchiGv.Location = new System.Drawing.Point(154, 285);
            this.txtDchiGv.Name = "txtDchiGv";
            this.txtDchiGv.Size = new System.Drawing.Size(366, 26);
            this.txtDchiGv.TabIndex = 22;
            // 
            // frmDkyGv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 358);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDkyGv";
            this.Text = "frmDkyGv";
            this.Load += new System.EventHandler(this.frmDkyGv_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHocSinhLop3DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDkyTenGv;
        private System.Windows.Forms.TextBox txtDkyTdemGv;
        private System.Windows.Forms.TextBox txtDkyHoGv;
        private System.Windows.Forms.TextBox txtDkyNlaiMkhauGv;
        private System.Windows.Forms.TextBox txtDkyMkhauGv;
        private System.Windows.Forms.TextBox txtDkyTkhoanGv;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbLopPtrach;
        private System.Windows.Forms.DateTimePicker dtNsinhGv;
        private System.Windows.Forms.Button btDKyGv;
        private QLHocSinhLop3DataSet qLHocSinhLop3DataSet;
        private System.Windows.Forms.BindingSource lopBindingSource;
        private QLHocSinhLop3DataSetTableAdapters.LopTableAdapter lopTableAdapter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDchiGv;
        private System.Windows.Forms.TextBox txtDthoaiGv;
    }
}