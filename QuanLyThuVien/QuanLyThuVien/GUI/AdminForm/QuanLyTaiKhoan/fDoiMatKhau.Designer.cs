
namespace QuanLyThuVien.GUI.AdminForm.QuanLyTaiKhoan
{
    partial class fDoiMatKhau
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TenTaiKhoan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_TenNguoiDung = new System.Windows.Forms.TextBox();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txt_matKhauMoi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_save = new FontAwesome.Sharp.IconButton();
            this.btn_cancel = new FontAwesome.Sharp.IconButton();
            this.lbl_image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_image)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm tài khoản";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_TenTaiKhoan
            // 
            this.txt_TenTaiKhoan.Enabled = false;
            this.txt_TenTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenTaiKhoan.Location = new System.Drawing.Point(254, 109);
            this.txt_TenTaiKhoan.Name = "txt_TenTaiKhoan";
            this.txt_TenTaiKhoan.ReadOnly = true;
            this.txt_TenTaiKhoan.Size = new System.Drawing.Size(251, 26);
            this.txt_TenTaiKhoan.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Thông tin chi tiết tài khoản";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(251, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên đăng nhập";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(251, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mật khẩu";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(551, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tên người dùng";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_TenNguoiDung
            // 
            this.txt_TenNguoiDung.Enabled = false;
            this.txt_TenNguoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenNguoiDung.Location = new System.Drawing.Point(554, 109);
            this.txt_TenNguoiDung.Name = "txt_TenNguoiDung";
            this.txt_TenNguoiDung.ReadOnly = true;
            this.txt_TenNguoiDung.Size = new System.Drawing.Size(251, 26);
            this.txt_TenNguoiDung.TabIndex = 14;
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MatKhau.Location = new System.Drawing.Point(254, 173);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.Size = new System.Drawing.Size(251, 26);
            this.txt_MatKhau.TabIndex = 15;
            this.txt_MatKhau.UseSystemPasswordChar = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txt_matKhauMoi
            // 
            this.txt_matKhauMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matKhauMoi.Location = new System.Drawing.Point(554, 173);
            this.txt_matKhauMoi.Name = "txt_matKhauMoi";
            this.txt_matKhauMoi.Size = new System.Drawing.Size(251, 26);
            this.txt_matKhauMoi.TabIndex = 25;
            this.txt_matKhauMoi.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(551, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Mật khẩu mới";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btn_save.IconColor = System.Drawing.Color.DimGray;
            this.btn_save.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_save.IconSize = 35;
            this.btn_save.Location = new System.Drawing.Point(488, 265);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(135, 34);
            this.btn_save.TabIndex = 23;
            this.btn_save.Text = "Đổi mật khẩu";
            this.btn_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btn_cancel.IconColor = System.Drawing.Color.DimGray;
            this.btn_cancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_cancel.IconSize = 35;
            this.btn_cancel.Location = new System.Drawing.Point(659, 265);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(135, 34);
            this.btn_cancel.TabIndex = 22;
            this.btn_cancel.Text = "Huỷ";
            this.btn_cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lbl_image
            // 
            this.lbl_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.lbl_image.Image = global::QuanLyThuVien.Properties.Resources.default_avatar;
            this.lbl_image.Location = new System.Drawing.Point(34, 87);
            this.lbl_image.Name = "lbl_image";
            this.lbl_image.Size = new System.Drawing.Size(150, 150);
            this.lbl_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lbl_image.TabIndex = 13;
            this.lbl_image.TabStop = false;
            // 
            // fDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(212)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(838, 328);
            this.Controls.Add(this.txt_matKhauMoi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.txt_MatKhau);
            this.Controls.Add(this.txt_TenNguoiDung);
            this.Controls.Add(this.lbl_image);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_TenTaiKhoan);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "fDoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fDoiMatKhau";
            ((System.ComponentModel.ISupportInitialize)(this.lbl_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_TenTaiKhoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox lbl_image;
        private System.Windows.Forms.TextBox txt_TenNguoiDung;
        private System.Windows.Forms.TextBox txt_MatKhau;
        private FontAwesome.Sharp.IconButton btn_cancel;
        private FontAwesome.Sharp.IconButton btn_save;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txt_matKhauMoi;
        private System.Windows.Forms.Label label6;
    }
}