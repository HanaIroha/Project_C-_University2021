
namespace QuanLyThuVien.GUI.AdminForm.ThongKe
{
    partial class fThongKe
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_print = new FontAwesome.Sharp.IconButton();
            this.cbb_year = new System.Windows.Forms.ComboBox();
            this.cbb_month = new System.Windows.Forms.ComboBox();
            this.btnStatistic = new FontAwesome.Sharp.IconButton();
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel1.Controls.Add(this.btn_print);
            this.panel1.Controls.Add(this.cbb_year);
            this.panel1.Controls.Add(this.cbb_month);
            this.panel1.Controls.Add(this.btnStatistic);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(963, 56);
            this.panel1.TabIndex = 2;
            // 
            // btn_print
            // 
            this.btn_print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_print.FlatAppearance.BorderSize = 0;
            this.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_print.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btn_print.IconColor = System.Drawing.Color.DimGray;
            this.btn_print.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btn_print.IconSize = 25;
            this.btn_print.Location = new System.Drawing.Point(847, 12);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(104, 35);
            this.btn_print.TabIndex = 7;
            this.btn_print.Text = "In ra";
            this.btn_print.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // cbb_year
            // 
            this.cbb_year.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_year.FormattingEnabled = true;
            this.cbb_year.Location = new System.Drawing.Point(564, 21);
            this.cbb_year.Name = "cbb_year";
            this.cbb_year.Size = new System.Drawing.Size(72, 21);
            this.cbb_year.TabIndex = 6;
            // 
            // cbb_month
            // 
            this.cbb_month.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_month.FormattingEnabled = true;
            this.cbb_month.Items.AddRange(new object[] {
            "Tất cả",
            "Tháng 1",
            "Tháng 2",
            "Tháng 3",
            "Tháng 4",
            "Tháng 5",
            "Tháng 6",
            "Tháng 7",
            "Tháng 8",
            "Tháng 9",
            "Tháng 10",
            "Tháng 11",
            "Tháng 12"});
            this.cbb_month.Location = new System.Drawing.Point(642, 21);
            this.cbb_month.Name = "cbb_month";
            this.cbb_month.Size = new System.Drawing.Size(104, 21);
            this.cbb_month.TabIndex = 5;
            // 
            // btnStatistic
            // 
            this.btnStatistic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStatistic.FlatAppearance.BorderSize = 0;
            this.btnStatistic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistic.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStatistic.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.btnStatistic.IconColor = System.Drawing.Color.DimGray;
            this.btnStatistic.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnStatistic.IconSize = 25;
            this.btnStatistic.Location = new System.Drawing.Point(748, 12);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Size = new System.Drawing.Size(104, 35);
            this.btnStatistic.TabIndex = 0;
            this.btnStatistic.Text = "Hiển thị";
            this.btnStatistic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStatistic.UseVisualStyleBackColor = true;
            this.btnStatistic.Click += new System.EventHandler(this.btnStatistic_Click);
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.AllowUserToAddRows = false;
            this.dgvThongKe.AllowUserToDeleteRows = false;
            this.dgvThongKe.AllowUserToResizeColumns = false;
            this.dgvThongKe.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvThongKe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongKe.BackgroundColor = System.Drawing.Color.White;
            this.dgvThongKe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvThongKe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvThongKe.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThongKe.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThongKe.GridColor = System.Drawing.Color.White;
            this.dgvThongKe.Location = new System.Drawing.Point(0, 56);
            this.dgvThongKe.MultiSelect = false;
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThongKe.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvThongKe.RowHeadersVisible = false;
            this.dgvThongKe.RowHeadersWidth = 40;
            this.dgvThongKe.RowTemplate.Height = 25;
            this.dgvThongKe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThongKe.Size = new System.Drawing.Size(963, 669);
            this.dgvThongKe.TabIndex = 3;
            // 
            // fThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 725);
            this.Controls.Add(this.dgvThongKe);
            this.Controls.Add(this.panel1);
            this.Name = "fThongKe";
            this.Text = "Thống kê";
            this.Load += new System.EventHandler(this.fThongKe_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnStatistic;
        private System.Windows.Forms.DataGridView dgvThongKe;
        private System.Windows.Forms.ComboBox cbb_month;
        private System.Windows.Forms.ComboBox cbb_year;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private FontAwesome.Sharp.IconButton btn_print;
    }
}