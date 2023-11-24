using GUI.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.DAL
{
    public class BillinfoDAL
    {
        private static BillinfoDAL instance;

        public static BillinfoDAL Instance
        {
            get { if (instance == null) instance = new BillinfoDAL(); return BillinfoDAL.instance; }

            private set => instance = value;
        }
        private BillinfoDAL() { }
        public List<Billinfo> Getlistbillinfo(int id)
        {
            List<Billinfo> Getlistbillinfo = new List<Billinfo>();
            DataTable data = ketnoisql.Instance.ExecuteQuery("select * from thongtinhoadon where idbill = " + id);
            foreach (DataRow item in data.Rows)
            {
                Billinfo thongtin = new Billinfo(item);
                Getlistbillinfo.Add(thongtin);
            }
            return Getlistbillinfo;
        }
        public void InserBillInfo(int idbill, int idfood, int count)
        {
            ketnoisql.Instance.ExecuteNonQuery("usp_insertBillinfo @idbill , @idfood , @count ", new object[] { idbill , idfood , count });
        }
    }
}
