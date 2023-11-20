using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            string query = "SELECT * FROM taikhoan WHERE tendangnhap = '" + tendangnhap + "' AND matkhau = '" + matkhau + "'";
            DataTable result = ketnoisql.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }
        
       
    }
}
