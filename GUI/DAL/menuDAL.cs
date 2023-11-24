using GUI.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.DAL
{
    public class menuDAL
    {
        private static menuDAL instance;

        public static menuDAL Instance
        {
            get { if (instance == null) instance = new menuDAL(); return menuDAL.instance; }
            private set { menuDAL.instance = value; }
        }
        private menuDAL() { }
        public List<menu>GetlistMenuByTable(int id)
        {
            List<menu> listmenu = new List<menu>();
            string query = "select f.tenmon , bi.count,f.gia,f.gia*bi.count as totalPrice from hoadon as b , thongtinhoadon as bi,menu as f where bi.idbill = b.id and bi.idfood = f.id and b.trangthai = 0 and b.idban =  " + id;
            DataTable data = ketnoisql.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                menu Menu = new menu(item);
                listmenu.Add(Menu);
            }
            return listmenu;
        }
    }
}
