using GUI.DAL;
using GUI.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;
using static System.Windows.Forms.ListViewItem;

namespace GUI
{
    public partial class quanlyban : Form
    {
        private account loginaccount;

        public account Loginaccount 
        {
            get { return loginaccount; }
            set { loginaccount = value; changeaccount(loginaccount.Quyen); }
        }

        public quanlyban(account acc)
        {
            this.loginaccount = acc;
            
            InitializeComponent();
            loadTable();
            loadCategory();
            loadcomboxtable(cbchuyenban);
            
        }
        void changeaccount(int quyen)
        {
            adminToolStripMenuItem.Enabled = quyen == 1;

        }
        void loadCategory()
        {
            List<Category> listcategory = CategoryDAL.Instance.GetlistCateGory();
            cbloai.DataSource = listcategory;
            cbloai.DisplayMember = "loai";
        }
        void LoadfoodListbyCategoryID(int id)
        {   
            List<Food> listfood = FoodDAL.Instance.GetFoodbyCategoryID(id);
            cbdoan.DataSource = listfood;
            cbdoan.DisplayMember = "tenmon";
        }
        void loadTable()
        {
            flpTable.Controls.Clear();
            List<table> danhSachBan = TableDAL.Instance.loadTableList();
            int x = 0; // Tọa độ x ban đầu
            int y = 0; // Tọa độ y ban đầu
            foreach (table item in danhSachBan)
            {
                Button btn = new Button() { Width = TableDAL.TableWidth, Height = TableDAL.TableHeight };
                btn.Tag = item;
                btn.Text = item.Tenban + Environment.NewLine + item.Trangthai;
                btn.Click += Btn_Click;
                btn.Location = new Point(x, y);
                flpTable.Controls.Add(btn);
                x += TableDAL.TableWidth;
                if (x >= flpTable.Width - TableDAL.TableWidth) // Nếu đã đủ rộng thì xuống dòng
                {
                    x = 0; // Đặt lại tọa độ x
                    y += TableDAL.TableHeight; // Dịch xuống dòng mới
                }
                switch (item.Trangthai)
                {
                    case "Trống":
                        btn.BackColor = Color.DeepSkyBlue;
                        break;
                    default:
                        btn.BackColor = Color.HotPink;
                        break;
                }
            }
        }

        void showbill(int id)
        {
            lsvhoadon.Items.Clear();
            List<GUI.DTO.menu> listBillinfo = menuDAL.Instance.GetlistMenuByTable(id);
            float totaPrice = 0;
            foreach (menu item in listBillinfo)
            {
                ListViewItem lsvitem = new ListViewItem(item.Tenmon.ToString());
                lsvitem.SubItems.Add(item.Count.ToString());
                lsvitem.SubItems.Add(item.Gia.ToString());
                lsvitem.SubItems.Add(item.TotalPrice.ToString());
                totaPrice += item.TotalPrice;
                lsvhoadon.Items.Add(lsvitem);

            }
            CultureInfo culture = new CultureInfo("vi-VN");
            txbTotaPrice.Text = totaPrice.ToString("c", culture);
            
        }
        void loadcomboxtable(ComboBox cb)
        {
            cb.DataSource = TableDAL.Instance.loadTableList();
            cb.DisplayMember = "tenban";
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            int tableid = ((sender as Button).Tag as table).ID;
            lsvhoadon.Tag = (sender as Button).Tag;
            showbill(tableid);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

           

        }
        /**/
        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thongtincanhan ttcn = new thongtincanhan(loginaccount);
            ttcn.ShowDialog();

            this.Show();
        }
        /**/
        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Loginaccount != null && Loginaccount.Quyen == 1)
            {
                // Người dùng có quyền admin, mở form admin
                admin adm = new admin();
                this.Hide();
                adm.ShowDialog();
                this.Show();
            }
            else
            {
                // Người dùng không có quyền admin, thông báo lỗi
                MessageBox.Show("Bạn không có quyền truy cập vào form admin!");
            }

            /*admin adm = new admin();
            this.Hide();
            adm.ShowDialog();
            this.Show();*/
        }
        
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void lsvhoadon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void quanlyban_Load(object sender, EventArgs e)
        {

        }

        private void cbloai_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if(cb.SelectedItem == null)
                return;
            Category selected = cb.SelectedItem as Category;
            id = selected.Id;
            LoadfoodListbyCategoryID(id);
        }

        private void btthemmon_Click(object sender, EventArgs e)
        {
            table Table = lsvhoadon.Tag as table;
            int idbill = BillDAL.Instance.getuncheckBillidbytableId(Table.ID);
            int idfood = (cbdoan.SelectedItem as Food).Id;
            int count = (int)nmslmonan.Value;
            if (idbill == -1)
            {
                BillDAL.Instance.InsertBill(Table.ID);
                BillinfoDAL.Instance.InserBillInfo(BillDAL.Instance.Getmaxidhoadon(), idfood, count);
            }
            else
            {
                BillinfoDAL.Instance.InserBillInfo(idbill, idfood, count);
            }
            showbill(Table.ID);
            loadTable();
        }

        private void flpTable_Paint(object sender, PaintEventArgs e)
        {

        }

        /* private void btthanhtoan_Click(object sender, EventArgs e)
         {
             table table = lsvhoadon.Tag as table;
             int idbill = BillDAL.Instance.getuncheckBillidbytableId(table.ID);
             int discount = (int)nmgiamgia.Value;
             double totalprice = Convert.ToDouble(txbTotaPrice.Text.Split(',')[0]);
             double finalTotaprice = totalprice - (totalprice / 100) * discount;
            
            if (idbill != -1)
            {
                if (MessageBox.Show(string.Format("Bạn có chắc thanh toán hóa đơn cho bàn {0}\n Tổng tiền - (Tổng tiền/100) x Giảm giá = {1} - {{1} / 100} x {2} = {3} ", table.Tenban, totalprice, discount, finalTotaprice), "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    BillDAL.Instance.CheckOut(idbill,discount);
                     showbill(table.ID);
                     loadTable();
                 }
             }
         } */
        private void btthanhtoan_Click(object sender, EventArgs e)
        {
            // Đoạn code này bị lỗi mọi vì kiểu dữ liệu table trùng với tên của class, đoạn code nên được viết lại để tránh nhầm lẫn
            // Giả sử kiểu dữ liệu table được sửa thành TableDTO cụ thể
            table table = lsvhoadon.Tag as table;

            int idbill = BillDAL.Instance.getuncheckBillidbytableId(table.ID);
            int discount = (int)nmgiamgia.Value;

            // Sử dụng kiểu dữ liệu decimal thay vì double để tránh lỗi làm tròn số khi tính toán với tiền tệ
            decimal totalprice = Convert.ToDecimal(txbTotaPrice.Text.Split(',')[0]);
            decimal finalTotaprice = totalprice - (totalprice / 100) * discount;

            if (idbill != -1)
            {
                // Đoạn mã dưới đây cần được sửa lại cách hiển thị dữ liệu trong MessageBox
                // Đây là cách sửa với định dạng số thập phân
                if (MessageBox.Show($"Bạn có chắc thanh toán hóa đơn cho bàn {table.Tenban}\n Tổng tiền - (Tổng tiền/100) x Giảm giá\n => {totalprice.ToString("N2")} - ({totalprice.ToString("N2")} / 100) x {discount} = {finalTotaprice.ToString("N2")}", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    BillDAL.Instance.CheckOut(idbill, discount,(float)finalTotaprice);
                    showbill(table.ID);
                    loadTable();
                }
            }
        }

        private void txbTotaPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void btchuyenban_Click(object sender, EventArgs e)
        {
            int id1 = (lsvhoadon.Tag as table).ID;
            int id2 = (cbchuyenban.SelectedItem as table).ID;
            if(MessageBox.Show(string.Format("Bạn có thật sự muốn chuyển bàn {0} qua bàn {1}", (lsvhoadon.Tag as table).Tenban, (cbchuyenban.SelectedItem as table).Tenban),"Thông báo",MessageBoxButtons.OKCancel)==System.Windows.Forms.DialogResult.OK)
            {
                TableDAL.Instance.SwitchTable(id1, id2);
                loadTable();
            }
            
        }

        private void taiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void muaMangVềToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng này đang được cập nhật !!!");
        }
    }
}
