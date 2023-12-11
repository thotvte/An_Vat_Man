using GUI.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.DAL
{
    public class BillDAL
    {
        private static BillDAL instance;

        public static BillDAL Instance
        {
            get { if (instance == null) instance = new BillDAL(); return BillDAL.instance; }
            private set { BillDAL.instance = value; }
        }
        private BillDAL() { }
        //thanh cong hoadon ID
        // thất bại -1 
        public int getuncheckBillidbytableId(int id)
        {
            DataTable data = ketnoisql.Instance.ExecuteQuery("select * from hoadon where idban = " + id + "and trangthai = 0");
            if (data.Rows.Count > 0)
            {
                Bill hoadondto = new Bill(data.Rows[0]);
                return hoadondto.ID;
            }
            return -1;
        }
        public void InsertBill(int id)
        {
            ketnoisql.Instance.ExecuteNonQuery("exec usp_thembill @idban", new object[]{id});
        }
        public int Getmaxidhoadon()
        {
            try
            {
                return (int)ketnoisql.Instance.ExecuteScalar("select MAX(id) from hoadon");
            }
            catch
            {

                return 1;
            }
        }
        public void CheckOut(int id, int discount, float totalprice)
        {
            string query = "update hoadon set ngayraban = getdate(), trangthai = 1," + "discount =" + discount + ",totalprice =" + totalprice + " where id =  " + id;
            ketnoisql.Instance.ExecuteNonQuery(query);
        }
        public DataTable GetBillListByDate(DateTime checkin, DateTime checkout)
        {
            return ketnoisql.Instance.ExecuteQuery("exec USP_GetListbillbydate @checkin , @checkout",new object[] {checkin,checkout});
        }
    }
}
