using GUI.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.DAL
{
    public class TableDAL
    {
        private static TableDAL instance;

        public static TableDAL Instance
        {
            get { if (instance == null) instance = new TableDAL(); return instance; }
            private set { instance = value; }
        }
        public static int TableWidth = 111;
        public static int TableHeight = 111;
        private TableDAL() { }
        public void SwitchTable(int id1,int id2)
        {
            ketnoisql.Instance.ExecuteQuery("USP_SwitchTable1 @idtable1 , @idtable2",new object[] {id1,id2});
        }
        public List<table> loadTableList()
        {
            List<table> tableList = new List<table>();
            DataTable data = ketnoisql.Instance.ExecuteQuery("exec USP_Gettablelist");
            foreach (DataRow item in data.Rows)
            {
                table Table = new table(item);
                tableList.Add(Table);                
            }
            return tableList;
        }

        public bool InsertTable(string tenban)
        {
            string query = string.Format("INSERT INTO ban (tenban) VALUES (N'{0}')", tenban);
            int result = ketnoisql.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateTable(int id, string tenban,String trangthai)
        {
            string query = string.Format("UPDATE ban SET tenban = N'{0}',trangthai = N'{1}'  WHERE id = {2}", tenban, trangthai, id);
            int result = ketnoisql.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteTable(int id)
        {
            string query = string.Format("DELETE FROM ban WHERE id = {0}", id);
            int result = ketnoisql.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
