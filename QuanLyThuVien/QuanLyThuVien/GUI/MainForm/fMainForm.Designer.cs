
namespace QuanLyThuVien.GUI.MainForm
{
    partial class fMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMainForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btn_quanLyTaiKhoan = new FontAwesome.Sharp.IconButton();
            this.btn_thongKe = new FontAwesome.Sharp.IconButton();
            this.btn_baoTriDocGia = new FontAwesome.Sharp.IconButton();
            this.btn_quanLyMuonTra = new FontAwesome.Sharp.IconButton();
            this.btn_quanLySach = new FontAwesome.Sharp.IconButton();
            this.btn_xemSach = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btn_Home = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.IconUser = new FontAwesome.Sharp.IconButton();
            this.btn_maximize = new FontAwesome.Sharp.IconButton();
            this.btn_exit = new FontAwesome.Sharp.IconButton();
            this.btn_minimize = new FontAwesome.Sharp.IconButton();
            this.lbl_currentChildForm = new System.Windows.Forms.Label();
            this.icon_currentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_profile = new FontAwesome.Sharp.IconButton();
            this.btn_logout = new FontAwesome.Sharp.IconButton();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Home)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.panelStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_currentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(92)))), ((int)(((byte)(157)))));
            this.panelMenu.Controls.Add(this.btn_quanLyTaiKhoan);
            this.panelMenu.Controls.Add(this.btn_thongKe);
            this.panelMenu.Controls.Add(this.btn_baoTriDocGia);
            this.panelMenu.Controls.Add(this.btn_quanLyMuonTra);
            this.panelMenu.Controls.Add(this.btn_quanLySach);
            this.panelMenu.Controls.Add(this.btn_xemSach);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 611);
            this.panelMenu.TabIndex = 0;
            // 
            // btn_quanLyTaiKhoan
            // 
            this.btn_quanLyTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(92)))), ((int)(((byte)(157)))));
            this.btn_quanLyTaiKhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_quanLyTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btn_quanLyTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quanLyTaiKhoan.Font = new System.Drawing.Font("UVN Gio May", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quanLyTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.btn_quanLyTaiKhoan.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btn_quanLyTaiKhoan.IconColor = System.Drawing.Color.White;
            this.btn_quanLyTaiKhoan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_quanLyTaiKhoan.IconSize = 40;
            this.btn_quanLyTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_quanLyTaiKhoan.Location = new System.Drawing.Point(0, 440);
            this.btn_quanLyTaiKhoan.Name = "btn_quanLyTaiKhoan";
            this.btn_quanLyTaiKhoan.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btn_quanLyTaiKhoan.Size = new System.Drawing.Size(220, 60);
            this.btn_quanLyTaiKhoan.TabIndex = 6;
            this.btn_quanLyTaiKhoan.Text = "Quản lý tài khoản";
            this.btn_quanLyTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_quanLyTaiKhoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_quanLyTaiKhoan.UseVisualStyleBackColor = false;
            this.btn_quanLyTaiKhoan.Click += new System.EventHandler(this.btn_quanLyTaiKhoan_Click);
            // 
            // btn_thongKe
            // 
            this.btn_thongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(92)))), ((int)(((byte)(157)))));
            this.btn_thongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_thongKe.FlatAppearance.BorderSize = 0;
            this.btn_thongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thongKe.Font = new System.Drawing.Font("UVN Gio May", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thongKe.ForeColor = System.Drawing.Color.White;
            this.btn_thongKe.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btn_thongKe.IconColor = System.Drawing.Color.White;
            this.btn_thongKe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_thongKe.IconSize = 40;
            this.btn_thongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thongKe.Location = new System.Drawing.Point(0, 380);
            this.btn_thongKe.Name = "btn_thongKe";
            this.btn_thongKe.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btn_thongKe.Size = new System.Drawing.Size(220, 60);
            this.btn_thongKe.TabIndex = 5;
            this.btn_thongKe.Text = "Thống kê";
            this.btn_thongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_thongKe.UseVisualStyleBackColor = false;
            this.btn_thongKe.Click += new System.EventHandler(this.btn_thongKe_Click);
            // 
            // btn_baoTriDocGia
            // 
            this.btn_baoTriDocGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(92)))), ((int)(((byte)(157)))));
            this.btn_baoTriDocGia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_baoTriDocGia.FlatAppearance.BorderSize = 0;
            this.btn_baoTriDocGia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_baoTriDocGia.Font = new System.Drawing.Font("UVN Gio May", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_baoTriDocGia.ForeColor = System.Drawing.Color.White;
            this.btn_baoTriDocGia.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btn_baoTriDocGia.IconColor = System.Drawing.Color.White;
            this.btn_baoTriDocGia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_baoTriDocGia.IconSize = 40;
            this.btn_baoTriDocGia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_baoTriDocGia.Location = new System.Drawing.Point(0, 320);
            this.btn_baoTriDocGia.Name = "btn_baoTriDocGia";
            this.btn_baoTriDocGia.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btn_baoTriDocGia.Size = new System.Drawing.Size(220, 60);
            this.btn_baoTriDocGia.TabIndex = 3;
            this.btn_baoTriDocGia.Text = "Quản lý độc giả";
            this.btn_baoTriDocGia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_baoTriDocGia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_baoTriDocGia.UseVisualStyleBackColor = false;
            this.btn_baoTriDocGia.Click += new System.EventHandler(this.btn_baoTriDocGia_Click);
            // 
            // btn_quanLyMuonTra
            // 
            this.btn_quanLyMuonTra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(92)))), ((int)(((byte)(157)))));
            this.btn_quanLyMuonTra.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_quanLyMuonTra.FlatAppearance.BorderSize = 0;
            this.btn_quanLyMuonTra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quanLyMuonTra.Font = new System.Drawing.Font("UVN Gio May", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quanLyMuonTra.ForeColor = System.Drawing.Color.White;
            this.btn_quanLyMuonTra.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btn_quanLyMuonTra.IconColor = System.Drawing.Color.White;
            this.btn_quanLyMuonTra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_quanLyMuonTra.IconSize = 40;
            this.btn_quanLyMuonTra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_quanLyMuonTra.Location = new System.Drawing.Point(0, 260);
            this.btn_quanLyMuonTra.Name = "btn_quanLyMuonTra";
            this.btn_quanLyMuonTra.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btn_quanLyMuonTra.Size = new System.Drawing.Size(220, 60);
            this.btn_quanLyMuonTra.TabIndex = 4;
            this.btn_quanLyMuonTra.Text = "Quản lý mượn/trả";
            this.btn_quanLyMuonTra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_quanLyMuonTra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_quanLyMuonTra.UseVisualStyleBackColor = false;
            this.btn_quanLyMuonTra.Click += new System.EventHandler(this.btn_quanLyMuonTra_Click);
            // 
            // btn_quanLySach
            // 
            this.btn_quanLySach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(92)))), ((int)(((byte)(157)))));
            this.btn_quanLySach.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_quanLySach.FlatAppearance.BorderSize = 0;
            this.btn_quanLySach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quanLySach.Font = new System.Drawing.Font("UVN Gio May", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quanLySach.ForeColor = System.Drawing.Color.White;
            this.btn_quanLySach.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btn_quanLySach.IconColor = System.Drawing.Color.White;
            this.btn_quanLySach.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_quanLySach.IconSize = 40;
            this.btn_quanLySach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_quanLySach.Location = new System.Drawing.Point(0, 200);
            this.btn_quanLySach.Name = "btn_quanLySach";
            this.btn_quanLySach.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btn_quanLySach.Size = new System.Drawing.Size(220, 60);
            this.btn_quanLySach.TabIndex = 1;
            this.btn_quanLySach.Text = "Quản lý sách";
            this.btn_quanLySach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_quanLySach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_quanLySach.UseVisualStyleBackColor = false;
            this.btn_quanLySach.Click += new System.EventHandler(this.btn_quanLySach_Click);
            // 
            // btn_xemSach
            // 
            this.btn_xemSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(92)))), ((int)(((byte)(157)))));
            this.btn_xemSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_xemSach.FlatAppearance.BorderSize = 0;
            this.btn_xemSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xemSach.Font = new System.Drawing.Font("UVN Gio May", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xemSach.ForeColor = System.Drawing.Color.White;
            this.btn_xemSach.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btn_xemSach.IconColor = System.Drawing.Color.White;
            this.btn_xemSach.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_xemSach.IconSize = 40;
            this.btn_xemSach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xemSach.Location = new System.Drawing.Point(0, 140);
            this.btn_xemSach.Name = "btn_xemSach";
            this.btn_xemSach.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btn_xemSach.Size = new System.Drawing.Size(220, 60);
            this.btn_xemSach.TabIndex = 7;
            this.btn_xemSach.Text = "Xem sách";
            this.btn_xemSach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xemSach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_xemSach.UseVisualStyleBackColor = false;
            this.btn_xemSach.Click += new System.EventHandler(this.btn_xemSach_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btn_Home);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // btn_Home
            // 
            this.btn_Home.Image = ((System.Drawing.Image)(resources.GetObject("btn_Home.Image")));
            this.btn_Home.Location = new System.Drawing.Point(2, 22);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(215, 102);
            this.btn_Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Home.TabIndex = 0;
            this.btn_Home.TabStop = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(160)))));
            this.panelTitleBar.Controls.Add(this.panelStatus);
            this.panelTitleBar.Controls.Add(this.lbl_currentChildForm);
            this.panelTitleBar.Controls.Add(this.icon_currentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(964, 75);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // panelStatus
            // 
            this.panelStatus.Controls.Add(this.IconUser);
            this.panelStatus.Controls.Add(this.btn_maximize);
            this.panelStatus.Controls.Add(this.btn_exit);
            this.panelStatus.Controls.Add(this.btn_minimize);
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelStatus.Location = new System.Drawing.Point(774, 0);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(190, 75);
            this.panelStatus.TabIndex = 6;
            // 
            // IconUser
            // 
            this.IconUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconUser.ForeColor = System.Drawing.Color.White;
            this.IconUser.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.IconUser.IconColor = System.Drawing.Color.White;
            this.IconUser.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.IconUser.Location = new System.Drawing.Point(3, 27);
            this.IconUser.Name = "IconUser";
            this.IconUser.Size = new System.Drawing.Size(182, 48);
            this.IconUser.TabIndex = 6;
            this.IconUser.Text = "Phạm Minh Tư";
            this.IconUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IconUser.UseVisualStyleBackColor = true;
            this.IconUser.Click += new System.EventHandler(this.IconUser_Click);
            // 
            // btn_maximize
            // 
            this.btn_maximize.FlatAppearance.BorderSize = 0;
            this.btn_maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_maximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btn_maximize.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_maximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_maximize.IconSize = 25;
            this.btn_maximize.Location = new System.Drawing.Point(138, 3);
            this.btn_maximize.Name = "btn_maximize";
            this.btn_maximize.Size = new System.Drawing.Size(21, 18);
            this.btn_maximize.TabIndex = 4;
            this.btn_maximize.UseVisualStyleBackColor = false;
            this.btn_maximize.Click += new System.EventHandler(this.btn_maximize_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btn_exit.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_exit.IconSize = 25;
            this.btn_exit.Location = new System.Drawing.Point(164, 3);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(21, 18);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_minimize
            // 
            this.btn_minimize.FlatAppearance.BorderSize = 0;
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btn_minimize.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_minimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_minimize.IconSize = 25;
            this.btn_minimize.Location = new System.Drawing.Point(109, 3);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(21, 18);
            this.btn_minimize.TabIndex = 5;
            this.btn_minimize.UseVisualStyleBackColor = false;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // lbl_currentChildForm
            // 
            this.lbl_currentChildForm.AutoSize = true;
            this.lbl_currentChildForm.Font = new System.Drawing.Font("UVN Gio May", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_currentChildForm.ForeColor = System.Drawing.Color.White;
            this.lbl_currentChildForm.Location = new System.Drawing.Point(56, 36);
            this.lbl_currentChildForm.Name = "lbl_currentChildForm";
            this.lbl_currentChildForm.Size = new System.Drawing.Size(89, 22);
            this.lbl_currentChildForm.TabIndex = 1;
            this.lbl_currentChildForm.Text = "Trang chủ";
            // 
            // icon_currentChildForm
            // 
            this.icon_currentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(160)))));
            this.icon_currentChildForm.ForeColor = System.Drawing.Color.GhostWhite;
            this.icon_currentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.icon_currentChildForm.IconColor = System.Drawing.Color.GhostWhite;
            this.icon_currentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icon_currentChildForm.IconSize = 38;
            this.icon_currentChildForm.Location = new System.Drawing.Point(15, 29);
            this.icon_currentChildForm.Name = "icon_currentChildForm";
            this.icon_currentChildForm.Size = new System.Drawing.Size(47, 38);
            this.icon_currentChildForm.TabIndex = 0;
            this.icon_currentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(187)))), ((int)(((byte)(227)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 75);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(964, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(212)))), ((int)(((byte)(224)))));
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 84);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(964, 527);
            this.panelDesktop.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::QuanLyThuVien.Properties.Resources.flashbang;
            this.pictureBox1.Location = new System.Drawing.Point(220, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(547, 352);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_profile
            // 
            this.btn_profile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_profile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(160)))));
            this.btn_profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_profile.ForeColor = System.Drawing.Color.White;
            this.btn_profile.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_profile.IconColor = System.Drawing.Color.Black;
            this.btn_profile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_profile.Location = new System.Drawing.Point(998, 76);
            this.btn_profile.Name = "btn_profile";
            this.btn_profile.Size = new System.Drawing.Size(181, 34);
            this.btn_profile.TabIndex = 0;
            this.btn_profile.Text = "Thông tin tài khoản";
            this.btn_profile.UseVisualStyleBackColor = false;
            this.btn_profile.Visible = false;
            this.btn_profile.Click += new System.EventHandler(this.btn_profile_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(160)))));
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_logout.IconColor = System.Drawing.Color.Black;
            this.btn_logout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_logout.Location = new System.Drawing.Point(998, 110);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(181, 34);
            this.btn_logout.TabIndex = 1;
            this.btn_logout.Text = "Đăng xuất";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Visible = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // fMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.btn_profile);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "fMainForm";
            this.Text = "z";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Home)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icon_currentChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btn_quanLySach;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btn_quanLyTaiKhoan;
        private FontAwesome.Sharp.IconButton btn_thongKe;
        private FontAwesome.Sharp.IconButton btn_quanLyMuonTra;
        private FontAwesome.Sharp.IconButton btn_baoTriDocGia;
        private System.Windows.Forms.PictureBox btn_Home;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lbl_currentChildForm;
        private FontAwesome.Sharp.IconPictureBox icon_currentChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btn_minimize;
        private FontAwesome.Sharp.IconButton btn_maximize;
        private FontAwesome.Sharp.IconButton btn_exit;
        private System.Windows.Forms.Panel panelStatus;
        private FontAwesome.Sharp.IconButton btn_xemSach;
        private FontAwesome.Sharp.IconButton IconUser;
        private FontAwesome.Sharp.IconButton btn_profile;
        private FontAwesome.Sharp.IconButton btn_logout;
    }
}

