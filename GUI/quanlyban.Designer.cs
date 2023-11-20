namespace GUI
{
    partial class quanlyban
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.taiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flpTable = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lsvhoadon = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbTotaPrice = new System.Windows.Forms.TextBox();
            this.btthanhtoan = new Guna.UI2.WinForms.Guna2Button();
            this.nmgiamgia = new System.Windows.Forms.NumericUpDown();
            this.btgiamgia = new Guna.UI2.WinForms.Guna2Button();
            this.cbchuyenban = new System.Windows.Forms.ComboBox();
            this.btchuyenban = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btthemmon = new Guna.UI2.WinForms.Guna2Button();
            this.nmslmonan = new System.Windows.Forms.NumericUpDown();
            this.cbloai = new System.Windows.Forms.ComboBox();
            this.cbdoan = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmgiamgia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmslmonan)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taiToolStripMenuItem,
            this.adminToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1182, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // taiToolStripMenuItem
            // 
            this.taiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinTàiKhoảnToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.taiToolStripMenuItem.Name = "taiToolStripMenuItem";
            this.taiToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.taiToolStripMenuItem.Text = "Tài khoản ";
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản ";
            this.thôngTinTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.thôngTinTàiKhoảnToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // flpTable
            // 
            this.flpTable.AutoScroll = true;
            this.flpTable.Location = new System.Drawing.Point(12, 31);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(469, 510);
            this.flpTable.TabIndex = 1;
            this.flpTable.Paint += new System.Windows.Forms.PaintEventHandler(this.flpTable_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lsvhoadon);
            this.panel2.Location = new System.Drawing.Point(487, 186);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(490, 355);
            this.panel2.TabIndex = 2;
            // 
            // lsvhoadon
            // 
            this.lsvhoadon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvhoadon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvhoadon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvhoadon.GridLines = true;
            this.lsvhoadon.HideSelection = false;
            this.lsvhoadon.Location = new System.Drawing.Point(0, 0);
            this.lsvhoadon.Name = "lsvhoadon";
            this.lsvhoadon.Size = new System.Drawing.Size(490, 355);
            this.lsvhoadon.TabIndex = 0;
            this.lsvhoadon.TileSize = new System.Drawing.Size(200, 36);
            this.lsvhoadon.UseCompatibleStateImageBehavior = false;
            this.lsvhoadon.View = System.Windows.Forms.View.Details;
            this.lsvhoadon.SelectedIndexChanged += new System.EventHandler(this.lsvhoadon_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn Giá ";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền ";
            this.columnHeader4.Width = 96;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.txbTotaPrice);
            this.panel3.Controls.Add(this.btthanhtoan);
            this.panel3.Controls.Add(this.nmgiamgia);
            this.panel3.Controls.Add(this.btgiamgia);
            this.panel3.Controls.Add(this.cbchuyenban);
            this.panel3.Controls.Add(this.btchuyenban);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(983, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(187, 510);
            this.panel3.TabIndex = 3;
            // 
            // txbTotaPrice
            // 
            this.txbTotaPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTotaPrice.ForeColor = System.Drawing.Color.Red;
            this.txbTotaPrice.Location = new System.Drawing.Point(14, 455);
            this.txbTotaPrice.Multiline = true;
            this.txbTotaPrice.Name = "txbTotaPrice";
            this.txbTotaPrice.ReadOnly = true;
            this.txbTotaPrice.Size = new System.Drawing.Size(154, 37);
            this.txbTotaPrice.TabIndex = 8;
            this.txbTotaPrice.Text = "0";
            this.txbTotaPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btthanhtoan
            // 
            this.btthanhtoan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btthanhtoan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btthanhtoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btthanhtoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btthanhtoan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btthanhtoan.ForeColor = System.Drawing.Color.White;
            this.btthanhtoan.Location = new System.Drawing.Point(14, 374);
            this.btthanhtoan.Name = "btthanhtoan";
            this.btthanhtoan.Size = new System.Drawing.Size(154, 42);
            this.btthanhtoan.TabIndex = 7;
            this.btthanhtoan.Text = "Thanh toán";
            // 
            // nmgiamgia
            // 
            this.nmgiamgia.Location = new System.Drawing.Point(14, 329);
            this.nmgiamgia.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmgiamgia.Name = "nmgiamgia";
            this.nmgiamgia.Size = new System.Drawing.Size(154, 22);
            this.nmgiamgia.TabIndex = 6;
            this.nmgiamgia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btgiamgia
            // 
            this.btgiamgia.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btgiamgia.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btgiamgia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btgiamgia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btgiamgia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btgiamgia.ForeColor = System.Drawing.Color.White;
            this.btgiamgia.Location = new System.Drawing.Point(14, 281);
            this.btgiamgia.Name = "btgiamgia";
            this.btgiamgia.Size = new System.Drawing.Size(154, 42);
            this.btgiamgia.TabIndex = 5;
            this.btgiamgia.Text = "Giảm giá";
            // 
            // cbchuyenban
            // 
            this.cbchuyenban.FormattingEnabled = true;
            this.cbchuyenban.Location = new System.Drawing.Point(14, 231);
            this.cbchuyenban.Name = "cbchuyenban";
            this.cbchuyenban.Size = new System.Drawing.Size(154, 24);
            this.cbchuyenban.TabIndex = 4;
            // 
            // btchuyenban
            // 
            this.btchuyenban.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btchuyenban.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btchuyenban.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btchuyenban.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btchuyenban.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btchuyenban.ForeColor = System.Drawing.Color.White;
            this.btchuyenban.Location = new System.Drawing.Point(14, 183);
            this.btchuyenban.Name = "btchuyenban";
            this.btchuyenban.Size = new System.Drawing.Size(154, 42);
            this.btchuyenban.TabIndex = 3;
            this.btchuyenban.Text = "Chuyển bàn";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.Screenshot_2023_11_10_0954271;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(487, 31);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(490, 149);
            this.panel4.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.pictureBox2);
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(232, 143);
            this.panel6.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GUI.Properties.Resources.z4892295400944_bd1eae379ba47df0189a3889160b50fc;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(229, 137);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btthemmon);
            this.panel5.Controls.Add(this.nmslmonan);
            this.panel5.Controls.Add(this.cbloai);
            this.panel5.Controls.Add(this.cbdoan);
            this.panel5.Location = new System.Drawing.Point(241, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(246, 143);
            this.panel5.TabIndex = 4;
            // 
            // btthemmon
            // 
            this.btthemmon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btthemmon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btthemmon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btthemmon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btthemmon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btthemmon.ForeColor = System.Drawing.Color.White;
            this.btthemmon.Location = new System.Drawing.Point(7, 74);
            this.btthemmon.Name = "btthemmon";
            this.btthemmon.Size = new System.Drawing.Size(102, 54);
            this.btthemmon.TabIndex = 2;
            this.btthemmon.Text = "Thêm";
            this.btthemmon.Click += new System.EventHandler(this.btthemmon_Click);
            // 
            // nmslmonan
            // 
            this.nmslmonan.Location = new System.Drawing.Point(160, 90);
            this.nmslmonan.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmslmonan.Name = "nmslmonan";
            this.nmslmonan.Size = new System.Drawing.Size(79, 22);
            this.nmslmonan.TabIndex = 3;
            this.nmslmonan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbloai
            // 
            this.cbloai.FormattingEnabled = true;
            this.cbloai.Location = new System.Drawing.Point(7, 3);
            this.cbloai.Name = "cbloai";
            this.cbloai.Size = new System.Drawing.Size(232, 24);
            this.cbloai.TabIndex = 0;
            this.cbloai.SelectedIndexChanged += new System.EventHandler(this.cbloai_SelectedIndexChanged);
            // 
            // cbdoan
            // 
            this.cbdoan.FormattingEnabled = true;
            this.cbdoan.Location = new System.Drawing.Point(7, 44);
            this.cbdoan.Name = "cbdoan";
            this.cbdoan.Size = new System.Drawing.Size(232, 24);
            this.cbdoan.TabIndex = 1;
            this.cbdoan.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // quanlyban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1182, 545);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "quanlyban";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý bàn ";
            this.Load += new System.EventHandler(this.quanlyban_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmgiamgia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmslmonan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem taiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.Panel flpTable;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView lsvhoadon;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbdoan;
        private System.Windows.Forms.ComboBox cbloai;
        private System.Windows.Forms.NumericUpDown nmslmonan;
        private Guna.UI2.WinForms.Guna2Button btthemmon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btgiamgia;
        private System.Windows.Forms.ComboBox cbchuyenban;
        private Guna.UI2.WinForms.Guna2Button btchuyenban;
        private System.Windows.Forms.TextBox txbTotaPrice;
        private Guna.UI2.WinForms.Guna2Button btthanhtoan;
        private System.Windows.Forms.NumericUpDown nmgiamgia;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}