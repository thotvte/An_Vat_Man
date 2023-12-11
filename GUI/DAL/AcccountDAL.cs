using GUI.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.DAL
{
    public class AcccountDAL
    {
        private static AcccountDAL instance;

        public static AcccountDAL Instance
        {
            get { if (instance == null) instance = new AcccountDAL(); return instance; }
            private set { instance = value; }
        }
        private AcccountDAL() { }
       public bool login(string tendangnhap, string matkhau)
        {
            //string query = "SELECT * FROM taikhoan WHERE tendangnhap = '" + tendangnhap + "' AND matkhau = '" + matkhau + "'";
            string query = "usp_dangnhap @tendangnhap , @matkhau";
            DataTable result = ketnoisql.Instance.ExecuteQuery(query,new object[] {tendangnhap,matkhau});
            return result.Rows.Count > 0;
        }

        public account GetAccountByuserName(string userName)
        {
            DataTable data = ketnoisql.Instance.ExecuteQuery("select * from taikhoan where tendangnhap ='" + userName + "'");
            foreach (DataRow item in data.Rows)
            {
                return new account(item);
            }
            return null;
        }

        public bool InsertTaiKhoan(string tenHienThi, string tenDangNhap, string matKhau, int quyen)
        {
            try
            {
                string query = string.Format("INSERT INTO taikhoan (tenhienthi, tendangnhap, matkhau, quyen) " +
                                             "VALUES (N'{0}', N'{1}', N'{2}', {3})", tenHienThi, tenDangNhap, matKhau, quyen);

                int result = ketnoisql.Instance.ExecuteNonQuery(query);
                return result > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }



        public bool DeleteTaiKhoan(string tendangnhap)
        {
            try
            {
                string query = string.Format("DELETE FROM taikhoan WHERE tendangnhap = N'{0}'", tendangnhap);

                int result = ketnoisql.Instance.ExecuteNonQuery(query);
                return result > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }
        
    }
}
