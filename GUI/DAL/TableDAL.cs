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
           
    
    }
}
