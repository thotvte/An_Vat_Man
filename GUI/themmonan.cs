using GUI.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class themmonan : Form 
    {
        
        public themmonan()
        {
            InitializeComponent();
            
        }

        private void bangthemmon_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            PictureBox p = sender as PictureBox;

            if (p != null)
            {
                open.Filter = "Image Files|*.jpg;*.jpeg;*.bmp;";
                open.FilterIndex = 1; // This sets the default filter to Image Files
                open.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures); // You can change the initial directory as needed

                if (open.ShowDialog() == DialogResult.OK)
                {
                    p.Image = Image.FromFile(open.FileName);
                }
            }
        }

        
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string tenmon = txbthemtenmon.Text;

            // Assuming txbthemidmonan.Text contains a valid integer value
            int categoryid = int.Parse(txbthemidmonan.Text);

            // Assuming txbthemgia.Text contains a valid float value
            float gia = float.Parse(txbthemgia.Text);
            if (FoodDAL.Instance.IsertFood(tenmon, categoryid, gia))
            {
                
                MessageBox.Show("Thêm món ăn thành công");
                
            }
            else
            {
                MessageBox.Show("Thêm món ăn thất bại");
            }
            
        }
        

        private void txbthemidmonan_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txbthemgia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbthemtenmon_TextChanged(object sender, EventArgs e)
        {

        }
        public static string SaveImage(PictureBox pictureBox, string txt)
        {
            string fname = txt + ".jpg";
            // Đường dẫn đầy đủ đến thư mục mới
            string folderPath = @"D:\FolderImgProduct";
            string pathString = "";
            try
            {
                // Kiểm tra xem thư mục đã tồn tại hay chưa
                if (!Directory.Exists(folderPath))
                {
                    // Nếu chưa tồn tại, tạo thư mục mới
                    Directory.CreateDirectory(folderPath);

                    pathString = Path.Combine(folderPath, fname);
                    if (pictureBox.Image != null)
                        pictureBox.Image.Save(pathString);
                    else
                        pathString = "";
                }
                else
                {
                    pathString = Path.Combine(folderPath, fname);
                    if (pictureBox.Image != null)
                        pictureBox.Image.Save(pathString);
                    else
                        pathString = "";
                }
                return pathString;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        private void themmonan_Layout(object sender, LayoutEventArgs e)
        {
            
        }
    }
}
