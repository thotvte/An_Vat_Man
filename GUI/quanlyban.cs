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
        public quanlyban()
        {
            InitializeComponent();
            loadTable();
            loadCategory();
            

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

        private void Btn_Click(object sender, EventArgs e)
        {
            int tableid = ((sender as Button).Tag as table).ID;
            lsvhoadon.Tag = (sender as Button).Tag;
            showbill(tableid);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

           

        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thongtincanhan ttcn = new thongtincanhan();
            ttcn.ShowDialog();
            this.Show();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin admin = new admin();
            admin.ShowDialog();
            this.Show();
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
        }

        private void flpTable_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
