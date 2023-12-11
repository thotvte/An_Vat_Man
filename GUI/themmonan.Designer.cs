namespace GUI
{
    partial class themmonan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureSp = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbthemtenmon = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbthemgia = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbthemidmonan = new Guna.UI2.WinForms.Guna2TextBox();
            this.btbthemmonan = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSp)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Olive;
            this.panel1.Controls.Add(this.pictureSp);
            this.panel1.Location = new System.Drawing.Point(53, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 208);
            this.panel1.TabIndex = 0;
            // 
            // pictureSp
            // 
            this.pictureSp.Image = global::GUI.Properties.Resources.istockphoto_1194891687_612x612;
            this.pictureSp.Location = new System.Drawing.Point(3, 3);
            this.pictureSp.Name = "pictureSp";
            this.pictureSp.Size = new System.Drawing.Size(388, 202);
            this.pictureSp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSp.TabIndex = 0;
            this.pictureSp.TabStop = false;
            this.pictureSp.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(468, 48);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(23, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÊM MÓN MỚI";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightGray;
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.txbthemtenmon);
            this.panel6.Controls.Add(this.txbthemgia);
            this.panel6.Controls.Add(this.txbthemidmonan);
            this.panel6.Location = new System.Drawing.Point(53, 318);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(394, 207);
            this.panel6.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tên món ăn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Giá (VNĐ)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "ID Món ăn";
            // 
            // txbthemtenmon
            // 
            this.txbthemtenmon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbthemtenmon.DefaultText = "";
            this.txbthemtenmon.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbthemtenmon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbthemtenmon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbthemtenmon.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbthemtenmon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbthemtenmon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbthemtenmon.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbthemtenmon.Location = new System.Drawing.Point(22, 145);
            this.txbthemtenmon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbthemtenmon.Name = "txbthemtenmon";
            this.txbthemtenmon.PasswordChar = '\0';
            this.txbthemtenmon.PlaceholderText = "";
            this.txbthemtenmon.SelectedText = "";
            this.txbthemtenmon.Size = new System.Drawing.Size(150, 30);
            this.txbthemtenmon.TabIndex = 7;
            this.txbthemtenmon.TextChanged += new System.EventHandler(this.txbthemtenmon_TextChanged);
            // 
            // txbthemgia
            // 
            this.txbthemgia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbthemgia.DefaultText = "";
            this.txbthemgia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbthemgia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbthemgia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbthemgia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbthemgia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbthemgia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbthemgia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbthemgia.Location = new System.Drawing.Point(215, 48);
            this.txbthemgia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbthemgia.Name = "txbthemgia";
            this.txbthemgia.PasswordChar = '\0';
            this.txbthemgia.PlaceholderText = "";
            this.txbthemgia.SelectedText = "";
            this.txbthemgia.Size = new System.Drawing.Size(150, 30);
            this.txbthemgia.TabIndex = 5;
            this.txbthemgia.TextChanged += new System.EventHandler(this.txbthemgia_TextChanged);
            // 
            // txbthemidmonan
            // 
            this.txbthemidmonan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbthemidmonan.DefaultText = "";
            this.txbthemidmonan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbthemidmonan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbthemidmonan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbthemidmonan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbthemidmonan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbthemidmonan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbthemidmonan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbthemidmonan.Location = new System.Drawing.Point(22, 48);
            this.txbthemidmonan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbthemidmonan.Name = "txbthemidmonan";
            this.txbthemidmonan.PasswordChar = '\0';
            this.txbthemidmonan.PlaceholderText = "";
            this.txbthemidmonan.SelectedText = "";
            this.txbthemidmonan.Size = new System.Drawing.Size(150, 30);
            this.txbthemidmonan.TabIndex = 2;
            this.txbthemidmonan.TextChanged += new System.EventHandler(this.txbthemidmonan_TextChanged);
            // 
            // btbthemmonan
            // 
            this.btbthemmonan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btbthemmonan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btbthemmonan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btbthemmonan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btbthemmonan.FillColor = System.Drawing.Color.SeaGreen;
            this.btbthemmonan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btbthemmonan.ForeColor = System.Drawing.Color.White;
            this.btbthemmonan.Location = new System.Drawing.Point(53, 531);
            this.btbthemmonan.Name = "btbthemmonan";
            this.btbthemmonan.Size = new System.Drawing.Size(394, 37);
            this.btbthemmonan.TabIndex = 8;
            this.btbthemmonan.Text = "Thêm món ăn ";
            this.btbthemmonan.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // themmonan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(506, 635);
            this.Controls.Add(this.btbthemmonan);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "themmonan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "bangthemmon";
            this.Load += new System.EventHandler(this.bangthemmon_Load);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.themmonan_Layout);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureSp)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureSp;
        private System.Windows.Forms.Panel panel6;
        private Guna.UI2.WinForms.Guna2Button btbthemmonan;
        private Guna.UI2.WinForms.Guna2TextBox txbthemtenmon;
        private Guna.UI2.WinForms.Guna2TextBox txbthemgia;
        private Guna.UI2.WinForms.Guna2TextBox txbthemidmonan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}