using GUI.DAL;
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
using static System.ComponentModel.Design.ObjectSelectorEditor;


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
            loadlistbilldate(dtpkngaybatdau.Value, dtpkngayketthuc.Value);
            loaddatatimepickerbill();
            Loadkho();
            LoadKhachhang();
        }


        void loaddatatimepickerbill()
        {

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
        void LoadKhachhang()
        {
            string query = "select * from khachhang ";
            dtgvkhachhang.DataSource = ketnoisql.Instance.ExecuteQuery(query);
        }
        void Loadkho()
        {
            string query = "select * from kho ";
            dtgvkho.DataSource = ketnoisql.Instance.ExecuteQuery(query);
        }
        void Loaddanhmuc()
        {
            string query = "select * from danhmuc ";
            dtgvdanhmuc.DataSource = ketnoisql.Instance.ExecuteQuery(query);
        }

        private void dtgvma_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void Loadmonan()
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
            this.Hide();
            themmonan tma = new themmonan();
            tma.ShowDialog();
            this.Show();
            // Loadmonan();
        }
        
        private void txbtimkiemma_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

            suamonan sma = new suamonan();
            this.Hide();
            sma.ShowDialog();
            this.Show();
            Loadmonan();
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
            int idmonan = int.Parse(txbidma.Text);

            if (FoodDAL.Instance.DeleteFood(idmonan))
            {
                MessageBox.Show("Xóa món ăn thành công");
                Loadmonan();
            }
            else
            {
                MessageBox.Show("Xóa món ăn thất bại");
            }
        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            string tenban = txbthemban.Text;
            if (TableDAL.Instance.InsertTable(tenban))
            {
                MessageBox.Show("Thêm bàn thành công");
                loadban();
            }
            else
            {
                MessageBox.Show("Thêm bàn thất bại");
            }
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txbidban.Text);
            if (TableDAL.Instance.DeleteTable(id))
            {
                MessageBox.Show("xóa bàn thành công");
                loadban();
            }
            else
            {
                MessageBox.Show("xóa bàn thất bại");
            }
        }

        private void guna2Button23_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button21_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            string tenHienThi = txbtenhienthi.Text;
            string tenDangNhap = txbtendangnhap.Text;
            string matKhau = txbmatkhau.Text;

            if (int.TryParse(txbquyen.Text, out int quyen))
            {
                if (AcccountDAL.Instance.InsertTaiKhoan(tenHienThi, tenDangNhap, matKhau, quyen))
                {
                    MessageBox.Show("Thêm tài khoản thành công");
                    // Refresh your data or update the UI as needed
                    loadtaikhan();
                }
                else
                {
                    MessageBox.Show("Thêm tài khoản thất bại");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid integer for quyen.");
            }
        }

        private void panel31_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtgvdanhmuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvdanhmuc.Rows[e.RowIndex];
                txbloaimonan.Text = row.Cells["loai"].Value.ToString();
                txbiddanhmuc.Text = row.Cells["iddanhmuc"].Value.ToString();
            }
        }

        private void dtgvma_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvma.Rows[e.RowIndex];
                txbidma.Text = row.Cells["idma"].Value.ToString();
                txbtenmon.Text = row.Cells["tenmon"].Value.ToString();
                txbidfood.Text = row.Cells["idmonan"].Value.ToString();
                txbgia.Text = row.Cells["gia"].Value.ToString();

            }
        }

        private void dtgvban_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvban.Rows[e.RowIndex];
                txbidban.Text = row.Cells["id"].Value.ToString();
                txbtenban.Text = row.Cells["tenban"].Value.ToString();
                txbtrangthaiban.Text = row.Cells["trangthai"].Value.ToString();

            }
        }

        private void dtgvtk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvtk.Rows[e.RowIndex];
                txbtenhienthi.Text = row.Cells["tenhienthi"].Value.ToString();
                txbtendangnhap.Text = row.Cells["tendangnhap"].Value.ToString();
                txbmatkhau.Text = row.Cells["matkhau"].Value.ToString();
                txbquyen.Text = row.Cells["quyen"].Value.ToString();
            }
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {



        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btxemdoanhtu_Click(object sender, EventArgs e)
        {
            loadlistbilldate(dtpkngaybatdau.Value, dtpkngayketthuc.Value);
        }
        void loadlistbilldate(DateTime checkin, DateTime checkout)
        {
            dtgvdoanhthu.DataSource = BillDAL.Instance.GetBillListByDate(checkin, checkout);
        }

        private void dtgvdanhmuc_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txbidma_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            string loai = txbloaimonan.Text;
            int id = int.Parse(txbiddanhmuc.Text);

            if (FoodDAL.Instance.UpdateCategory(id, loai))
            {
                MessageBox.Show("Sửa món ăn thành công");
                Loaddanhmuc();
            }
            else
            {
                MessageBox.Show("Sửa món ăn thất bại");
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

            int id = int.Parse(txbiddanhmuc.Text);

            if (FoodDAL.Instance.DeleteCategory(id))
            {
                MessageBox.Show("Sửa món ăn thành công");
                Loaddanhmuc();
            }
            else
            {
                MessageBox.Show("Sửa món ăn thất bại");
            }

        }

        private void txbsuaban_Click(object sender, EventArgs e)
        {
            string tenban = txbthemban.Text;
            string trangthai = txbtrangthaiban.Text;
            int id = int.Parse(txbidban.Text);

            if (TableDAL.Instance.UpdateTable(id, tenban, trangthai))
            {
                MessageBox.Show("Cập nhật bàn thành công");
                loadban();
            }
            else
            {
                MessageBox.Show("Cập nhật bàn thất bại");
            }
        }

        private void guna2Button10_Click_1(object sender, EventArgs e)
        {
            
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            string tendangnhap = txbtendangnhap.Text;


            if (AcccountDAL.Instance.DeleteTaiKhoan(tendangnhap))
            {
                MessageBox.Show("Cập nhật bàn thành công");
                loadtaikhan();
            }
            else
            {
                MessageBox.Show("Cập nhật bàn thất bại");
            }
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bttimkiemma_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgvkhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvkhachhang.Rows[e.RowIndex];
                makhachhang.Text = row.Cells["id"].Value.ToString();
                hoten.Text = row.Cells["hoten"].Value.ToString();
                sodienthoai.Text = row.Cells["sodienthoai"].Value.ToString();
                diachi.Text = row.Cells["diachi"].Value.ToString();

            }
        }

        private void guna2TextBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
