using GUI.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class dangnhap : Form
    {
        public dangnhap()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        bool login(string tendangnhap , string matkhau)
        {
            return AcccountDAL.Instance.login(tendangnhap,matkhau);
        }
        private void btbdangnhap_Click(object sender, EventArgs e)
        {
            string tendangnhap = txbtaikhoan.Text;
            string matkhau = txbmatkhau.Text;
            if(login(tendangnhap, matkhau))
            {
                this.Hide();
                quanlyban qlb = new quanlyban();
                qlb.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác !!");
            }
            
        }
        
    }
}
