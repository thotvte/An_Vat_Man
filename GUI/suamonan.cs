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
    public partial class suamonan : Form
    {
        public suamonan()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string tenmon = txbsuatenmon.Text;

            // Assuming txbidsuamon.Text contains a valid integer value
            int idmonan = int.Parse(txbidsuamon.Text);

            // Assuming txbthemgia.Text contains a valid float value
            float gia = float.Parse(txbidsuagia.Text);

            // Assuming txbidsua.Text contains a valid integer value
            int id = int.Parse(txbidsua.Text);

            if (FoodDAL.Instance.UpdateFood(id, idmonan, tenmon, gia))
            {
                MessageBox.Show("Sửa món ăn thành công");
            }
            else
            {
                MessageBox.Show("Sửa món ăn thất bại");
            }
        }
    }
}
