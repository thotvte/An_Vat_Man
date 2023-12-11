using GUI.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.DAL
{
    internal class FoodDAL
    {
        private static FoodDAL instance;

        public static FoodDAL Instance
        {
            get { if (instance == null) instance = new FoodDAL(); return FoodDAL.instance; }
            private set { FoodDAL.instance = value; }
        }
        private FoodDAL() { }
        public List<Food> GetFoodbyCategoryID(int id)
        {
            List<Food> list = new List<Food>();
            string query = "select * from menu where idmonan = " + id;
            DataTable data = ketnoisql.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }
            return list;
        }
        public bool IsertFood(string tenmon, int id, float gia)
        {
            string query = string.Format("insert into menu(tenmon, idmonan, gia) values (N'{0}', {1}, {2})", tenmon, id, gia);
            int result = ketnoisql.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        
        public bool UpdateFood(int id, int idmonan, string tenmon, float gia)
        {
            string query = string.Format("UPDATE menu SET tenmon = N'{0}', idmonan ={1} , gia = {2} WHERE id = {3}", tenmon, idmonan, gia, id);
            int result = ketnoisql.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteFood(int id)
        {
            string query = string.Format("DELETE FROM menu WHERE id = {0}", id);
            int result = ketnoisql.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool InsertCategory(string loai)
        {
            string query = string.Format("INSERT INTO danhmuc(loai) VALUES (N'{0}')", loai);
            int result = ketnoisql.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateCategory(int id, string loai)
        {
            string query = string.Format("UPDATE danhmuc SET loai = N'{0}' WHERE id = {1}", loai, id);
            int result = ketnoisql.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteCategory(int id)
        {
            string query = string.Format("DELETE FROM danhmuc WHERE id = {0}", id);
            int result = ketnoisql.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
       
    } 
}

