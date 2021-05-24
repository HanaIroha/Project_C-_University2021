
namespace QuanLyThuVien.GUI.ManagerForm.QuanLyDocGia
{
    partial class fDeleteEntry
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
            this.cbb_ngayxoa = new System.Windows.Forms.ComboBox();
            this.btn_save = new FontAwesome.Sharp.IconButton();
            this.btn_cancel = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbb_ngayxoa
            // 
            this.cbb_ngayxoa.FormattingEnabled = true;
            this.cbb_ngayxoa.Items.AddRange(new object[] {
            "7 Lưu trữ cuối",
            "30 Lưu trữ cuối",
            "Toàn bộ (Trừ hôm nay)"});
            this.cbb_ngayxoa.Location = new System.Drawing.Point(190, 21);
            this.cbb_ngayxoa.Name = "cbb_ngayxoa";
            this.cbb_ngayxoa.Size = new System.Drawing.Size(169, 21);
            this.cbb_ngayxoa.TabIndex = 0;
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
            this.btn_save.Location = new System.Drawing.Point(52, 76);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(116, 34);
            this.btn_save.TabIndex = 25;
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
            this.btn_cancel.Location = new System.Drawing.Point(213, 76);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(116, 34);
            this.btn_cancel.TabIndex = 24;
            this.btn_cancel.Text = "Huỷ";
            this.btn_cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Chọn số ngày muốn xoá";
            // 
            // fDeleteEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(212)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(371, 130);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.cbb_ngayxoa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fDeleteEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fDeleteEntry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbb_ngayxoa;
        private FontAwesome.Sharp.IconButton btn_save;
        private FontAwesome.Sharp.IconButton btn_cancel;
        private System.Windows.Forms.Label label1;
    }
}