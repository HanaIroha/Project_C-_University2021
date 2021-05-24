
namespace QuanLyThuVien.GUI.AdminForm.QuanLySach
{
    partial class fAddSach
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
            this.cbb_danhMuc = new System.Windows.Forms.ComboBox();
            this.txt_tenSach = new System.Windows.Forms.TextBox();
            this.txt_sl = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_tacGia = new System.Windows.Forms.TextBox();
            this.txt_tenNXB = new System.Windows.Forms.TextBox();
            this.txt_namXB = new System.Windows.Forms.TextBox();
            this.txt_giaMuon = new System.Windows.Forms.TextBox();
            this.txt_lanXB = new System.Windows.Forms.NumericUpDown();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_save = new FontAwesome.Sharp.IconButton();
            this.btn_cancel = new FontAwesome.Sharp.IconButton();
            this.btn_changeImage = new FontAwesome.Sharp.IconButton();
            this.lbl_image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_lanXB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_image)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm sách";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbb_danhMuc
            // 
            this.cbb_danhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_danhMuc.FormattingEnabled = true;
            this.cbb_danhMuc.Location = new System.Drawing.Point(254, 81);
            this.cbb_danhMuc.Name = "cbb_danhMuc";
            this.cbb_danhMuc.Size = new System.Drawing.Size(251, 28);
            this.cbb_danhMuc.TabIndex = 1;
            // 
            // txt_tenSach
            // 
            this.txt_tenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenSach.Location = new System.Drawing.Point(254, 147);
            this.txt_tenSach.Name = "txt_tenSach";
            this.txt_tenSach.Size = new System.Drawing.Size(251, 26);
            this.txt_tenSach.TabIndex = 2;
            // 
            // txt_sl
            // 
            this.txt_sl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sl.Location = new System.Drawing.Point(254, 275);
            this.txt_sl.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.txt_sl.Name = "txt_sl";
            this.txt_sl.Size = new System.Drawing.Size(251, 26);
            this.txt_sl.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Thông tin chi tiết sách";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(251, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên sách";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(551, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tác giả";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(251, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tên nhà xuất bản";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(251, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Danh mục";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(551, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Năm xuất bản";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(692, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Lần xuất bản";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(254, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "Số lượng";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(554, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "Giá mượn";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_tacGia
            // 
            this.txt_tacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tacGia.Location = new System.Drawing.Point(554, 147);
            this.txt_tacGia.Name = "txt_tacGia";
            this.txt_tacGia.Size = new System.Drawing.Size(251, 26);
            this.txt_tacGia.TabIndex = 14;
            // 
            // txt_tenNXB
            // 
            this.txt_tenNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenNXB.Location = new System.Drawing.Point(254, 211);
            this.txt_tenNXB.Name = "txt_tenNXB";
            this.txt_tenNXB.Size = new System.Drawing.Size(251, 26);
            this.txt_tenNXB.TabIndex = 15;
            // 
            // txt_namXB
            // 
            this.txt_namXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_namXB.Location = new System.Drawing.Point(554, 211);
            this.txt_namXB.Name = "txt_namXB";
            this.txt_namXB.Size = new System.Drawing.Size(110, 26);
            this.txt_namXB.TabIndex = 16;
            this.txt_namXB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_namXB_KeyPress);
            // 
            // txt_giaMuon
            // 
            this.txt_giaMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_giaMuon.Location = new System.Drawing.Point(554, 276);
            this.txt_giaMuon.Name = "txt_giaMuon";
            this.txt_giaMuon.Size = new System.Drawing.Size(251, 26);
            this.txt_giaMuon.TabIndex = 18;
            this.txt_giaMuon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_giaMuon_KeyPress);
            // 
            // txt_lanXB
            // 
            this.txt_lanXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lanXB.Location = new System.Drawing.Point(695, 211);
            this.txt_lanXB.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_lanXB.Name = "txt_lanXB";
            this.txt_lanXB.Size = new System.Drawing.Size(110, 26);
            this.txt_lanXB.TabIndex = 19;
            this.txt_lanXB.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
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
            this.btn_save.Location = new System.Drawing.Point(525, 347);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(116, 34);
            this.btn_save.TabIndex = 23;
            this.btn_save.Text = "Lưu";
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
            this.btn_cancel.Location = new System.Drawing.Point(689, 347);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(116, 34);
            this.btn_cancel.TabIndex = 22;
            this.btn_cancel.Text = "Huỷ";
            this.btn_cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_changeImage
            // 
            this.btn_changeImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.btn_changeImage.FlatAppearance.BorderSize = 0;
            this.btn_changeImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_changeImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_changeImage.IconChar = FontAwesome.Sharp.IconChar.ExchangeAlt;
            this.btn_changeImage.IconColor = System.Drawing.Color.DimGray;
            this.btn_changeImage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_changeImage.IconSize = 35;
            this.btn_changeImage.Location = new System.Drawing.Point(50, 252);
            this.btn_changeImage.Name = "btn_changeImage";
            this.btn_changeImage.Size = new System.Drawing.Size(116, 34);
            this.btn_changeImage.TabIndex = 21;
            this.btn_changeImage.Text = "Thay ảnh";
            this.btn_changeImage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_changeImage.UseVisualStyleBackColor = false;
            this.btn_changeImage.Click += new System.EventHandler(this.btn_changeImage_Click);
            // 
            // lbl_image
            // 
            this.lbl_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.lbl_image.Image = global::QuanLyThuVien.Properties.Resources.default_book;
            this.lbl_image.Location = new System.Drawing.Point(34, 87);
            this.lbl_image.Name = "lbl_image";
            this.lbl_image.Size = new System.Drawing.Size(150, 150);
            this.lbl_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lbl_image.TabIndex = 13;
            this.lbl_image.TabStop = false;
            // 
            // fAddSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(212)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(838, 409);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_changeImage);
            this.Controls.Add(this.txt_lanXB);
            this.Controls.Add(this.txt_giaMuon);
            this.Controls.Add(this.txt_namXB);
            this.Controls.Add(this.txt_tenNXB);
            this.Controls.Add(this.txt_tacGia);
            this.Controls.Add(this.lbl_image);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_sl);
            this.Controls.Add(this.txt_tenSach);
            this.Controls.Add(this.cbb_danhMuc);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "fAddSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fAddSach";
            ((System.ComponentModel.ISupportInitialize)(this.txt_sl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_lanXB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_danhMuc;
        private System.Windows.Forms.TextBox txt_tenSach;
        private System.Windows.Forms.NumericUpDown txt_sl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox lbl_image;
        private System.Windows.Forms.TextBox txt_tacGia;
        private System.Windows.Forms.TextBox txt_tenNXB;
        private System.Windows.Forms.TextBox txt_namXB;
        private System.Windows.Forms.TextBox txt_giaMuon;
        private System.Windows.Forms.NumericUpDown txt_lanXB;
        private FontAwesome.Sharp.IconButton btn_changeImage;
        private FontAwesome.Sharp.IconButton btn_cancel;
        private FontAwesome.Sharp.IconButton btn_save;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}