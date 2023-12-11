using GUI.DTO;
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
    public partial class thongtincanhan : Form
    {
        private account loginaccount;

        public account Loginaccount
        {
            get { return loginaccount; }
            set { loginaccount = value; changeaccount(loginaccount); }
        }
        public thongtincanhan(account acc)
        {
            InitializeComponent();
            loginaccount = acc;
        }
        void changeaccount(account acc)
        {
            txbtaikhoan.Text = acc.Tendangnhap;
            txbmatkhau.Text = acc.Matkhau;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void thongtincanhan_Load(object sender, EventArgs e)
        {
            changeaccount(loginaccount);
        }
    }
}
