
namespace QuanLyThuVien.GUI.ManagerForm.XemSach
{
    partial class fXemSach
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbb_search = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.AnhS = new System.Windows.Forms.DataGridViewImageColumn();
            this.MaS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LanXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel1.Controls.Add(this.cbb_search);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(963, 56);
            this.panel1.TabIndex = 2;
            // 
            // cbb_search
            // 
            this.cbb_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_search.FormattingEnabled = true;
            this.cbb_search.Items.AddRange(new object[] {
            "Tên sách",
            "Tác giả",
            "Nhà xuất bản",
            "Tên danh mục",
            "Năm xuất bản"});
            this.cbb_search.Location = new System.Drawing.Point(516, 19);
            this.cbb_search.Name = "cbb_search";
            this.cbb_search.Size = new System.Drawing.Size(98, 21);
            this.cbb_search.TabIndex = 3;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(631, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSearch.Size = new System.Drawing.Size(229, 23);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearch.IconColor = System.Drawing.Color.DimGray;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnSearch.IconSize = 25;
            this.btnSearch.Location = new System.Drawing.Point(866, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(91, 35);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvSach
            // 
            this.dgvSach.AllowUserToAddRows = false;
            this.dgvSach.AllowUserToDeleteRows = false;
            this.dgvSach.AllowUserToResizeColumns = false;
            this.dgvSach.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvSach.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSach.BackgroundColor = System.Drawing.Color.White;
            this.dgvSach.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSach.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSach.ColumnHeadersHeight = 40;
            this.dgvSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AnhS,
            this.MaS,
            this.TenS,
            this.TacGia,
            this.TenNXB,
            this.TenDanhMuc,
            this.NamXB,
            this.LanXB,
            this.SoLuong,
            this.GiaMuon});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSach.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSach.GridColor = System.Drawing.Color.White;
            this.dgvSach.Location = new System.Drawing.Point(0, 56);
            this.dgvSach.MultiSelect = false;
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSach.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSach.RowHeadersVisible = false;
            this.dgvSach.RowHeadersWidth = 40;
            this.dgvSach.RowTemplate.Height = 100;
            this.dgvSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSach.Size = new System.Drawing.Size(963, 669);
            this.dgvSach.TabIndex = 3;
            // 
            // AnhS
            // 
            this.AnhS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.AnhS.DataPropertyName = "AnhS";
            this.AnhS.HeaderText = "Ảnh";
            this.AnhS.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.AnhS.Name = "AnhS";
            this.AnhS.ReadOnly = true;
            this.AnhS.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AnhS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // MaS
            // 
            this.MaS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MaS.DataPropertyName = "MaS";
            this.MaS.FillWeight = 93.72616F;
            this.MaS.HeaderText = "Mã sách";
            this.MaS.Name = "MaS";
            this.MaS.ReadOnly = true;
            this.MaS.Width = 90;
            // 
            // TenS
            // 
            this.TenS.DataPropertyName = "TenS";
            this.TenS.FillWeight = 101.9272F;
            this.TenS.HeaderText = "Tên sách";
            this.TenS.Name = "TenS";
            this.TenS.ReadOnly = true;
            // 
            // TacGia
            // 
            this.TacGia.DataPropertyName = "TacGia";
            this.TacGia.FillWeight = 101.9272F;
            this.TacGia.HeaderText = "Tác giả";
            this.TacGia.Name = "TacGia";
            this.TacGia.ReadOnly = true;
            // 
            // TenNXB
            // 
            this.TenNXB.DataPropertyName = "TenNXB";
            this.TenNXB.FillWeight = 101.9272F;
            this.TenNXB.HeaderText = "Tên nhà xuất bản";
            this.TenNXB.Name = "TenNXB";
            this.TenNXB.ReadOnly = true;
            // 
            // TenDanhMuc
            // 
            this.TenDanhMuc.DataPropertyName = "TenDanhMuc";
            this.TenDanhMuc.FillWeight = 101.9272F;
            this.TenDanhMuc.HeaderText = "Tên danh mục";
            this.TenDanhMuc.Name = "TenDanhMuc";
            this.TenDanhMuc.ReadOnly = true;
            this.TenDanhMuc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // NamXB
            // 
            this.NamXB.DataPropertyName = "NamXB";
            this.NamXB.FillWeight = 101.9272F;
            this.NamXB.HeaderText = "Năm xuất bản";
            this.NamXB.Name = "NamXB";
            this.NamXB.ReadOnly = true;
            // 
            // LanXB
            // 
            this.LanXB.DataPropertyName = "LanXB";
            this.LanXB.FillWeight = 101.9272F;
            this.LanXB.HeaderText = "Lần xuất bản";
            this.LanXB.Name = "LanXB";
            this.LanXB.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.FillWeight = 92.78349F;
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            this.SoLuong.Width = 90;
            // 
            // GiaMuon
            // 
            this.GiaMuon.DataPropertyName = "GiaMuon";
            this.GiaMuon.FillWeight = 101.9272F;
            this.GiaMuon.HeaderText = "Giá mượn";
            this.GiaMuon.Name = "GiaMuon";
            this.GiaMuon.ReadOnly = true;
            // 
            // fXemSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 725);
            this.Controls.Add(this.dgvSach);
            this.Controls.Add(this.panel1);
            this.Name = "fXemSach";
            this.Text = "Xem sách";
            this.Load += new System.EventHandler(this.fQuanLySach_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearch;
        private FontAwesome.Sharp.IconButton btnSearch;
        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.DataGridViewImageColumn AnhS;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn LanXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaMuon;
        private System.Windows.Forms.ComboBox cbb_search;
    }
}