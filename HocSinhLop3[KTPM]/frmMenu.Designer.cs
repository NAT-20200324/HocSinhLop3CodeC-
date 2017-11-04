namespace HocSinhLop3_KTPM_
{
    partial class frmMenu
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
            this.btDkyHs = new System.Windows.Forms.Button();
            this.btDnhapHs = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMkhauDkyGv = new System.Windows.Forms.TextBox();
            this.btDkyGv = new System.Windows.Forms.Button();
            this.btDnhapGv = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btDkyHs);
            this.groupBox1.Controls.Add(this.btDnhapHs);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(721, 166);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Học Sinh";
            // 
            // btDkyHs
            // 
            this.btDkyHs.Location = new System.Drawing.Point(470, 50);
            this.btDkyHs.Name = "btDkyHs";
            this.btDkyHs.Size = new System.Drawing.Size(144, 72);
            this.btDkyHs.TabIndex = 1;
            this.btDkyHs.Text = "Đăng ký";
            this.btDkyHs.UseVisualStyleBackColor = true;
            this.btDkyHs.Click += new System.EventHandler(this.btDkyHs_Click);
            // 
            // btDnhapHs
            // 
            this.btDnhapHs.Location = new System.Drawing.Point(102, 50);
            this.btDnhapHs.Name = "btDnhapHs";
            this.btDnhapHs.Size = new System.Drawing.Size(144, 72);
            this.btDnhapHs.TabIndex = 0;
            this.btDnhapHs.Text = "Đăng nhập";
            this.btDnhapHs.UseVisualStyleBackColor = true;
            this.btDnhapHs.Click += new System.EventHandler(this.btDnhapHs_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtMkhauDkyGv);
            this.groupBox2.Controls.Add(this.btDkyGv);
            this.groupBox2.Controls.Add(this.btDnhapGv);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(721, 166);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giáo Viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mật khẩu để đăng ký";
            // 
            // txtMkhauDkyGv
            // 
            this.txtMkhauDkyGv.Location = new System.Drawing.Point(276, 92);
            this.txtMkhauDkyGv.Name = "txtMkhauDkyGv";
            this.txtMkhauDkyGv.Size = new System.Drawing.Size(161, 26);
            this.txtMkhauDkyGv.TabIndex = 3;
            // 
            // btDkyGv
            // 
            this.btDkyGv.Location = new System.Drawing.Point(470, 46);
            this.btDkyGv.Name = "btDkyGv";
            this.btDkyGv.Size = new System.Drawing.Size(144, 72);
            this.btDkyGv.TabIndex = 2;
            this.btDkyGv.Text = "Đăng ký";
            this.btDkyGv.UseVisualStyleBackColor = true;
            this.btDkyGv.Click += new System.EventHandler(this.btDkyGv_Click);
            // 
            // btDnhapGv
            // 
            this.btDnhapGv.Location = new System.Drawing.Point(102, 46);
            this.btDnhapGv.Name = "btDnhapGv";
            this.btDnhapGv.Size = new System.Drawing.Size(144, 72);
            this.btDnhapGv.TabIndex = 1;
            this.btDnhapGv.Text = "Đăng nhập";
            this.btDnhapGv.UseVisualStyleBackColor = true;
            this.btDnhapGv.Click += new System.EventHandler(this.btDnhapGv_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 358);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btDkyHs;
        private System.Windows.Forms.Button btDnhapHs;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btDkyGv;
        private System.Windows.Forms.Button btDnhapGv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMkhauDkyGv;

    }
}