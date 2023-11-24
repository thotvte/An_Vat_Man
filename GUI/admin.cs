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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
            Loaddanhmuc();
            Loadmonan();
            loadtaikhan();
            loadban();
        }

        private void guna2TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void panel21_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {

        }

        private void dtgvdanhmuc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void Loaddanhmuc()
        {
            string query = "select * from danhmuc ";
            dtgvdanhmuc.DataSource = ketnoisql.Instance.ExecuteQuery(query);
        }

        private void dtgvma_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void Loadmonan()
        {
            string query = "select * from menu ";
            dtgvma.DataSource = ketnoisql.Instance.ExecuteQuery(query);
        }
        void loadtaikhan()
        {
            string query = "select * from taikhoan ";
            dtgvtk.DataSource = ketnoisql.Instance.ExecuteQuery(query);
        }
        void loadban()
        {
            string query = "select * from ban ";
            dtgvban.DataSource = ketnoisql.Instance.ExecuteQuery(query);
        }
        private void dtgvtk_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgvban_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btthemma_Click(object sender, EventArgs e)
        {
            themmonan themmonan = new themmonan();
            themmonan.ShowDialog();
            this.Show();
        }

        private void txbtimkiemma_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            
            suamonan sma = new suamonan();
            sma.ShowDialog();
            this.Show();
        }

        private void guna2Button18_Click(object sender, EventArgs e)
        {
            
            suakhuyenmai skm = new suakhuyenmai();
            skm.ShowDialog();
            this.Show();
        }

        private void guna2Button19_Click(object sender, EventArgs e)
        {
            
            themkhuyenmai tkm = new themkhuyenmai();
            tkm.ShowDialog();
            this.Show();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button23_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button21_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {

        }

        private void panel31_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
