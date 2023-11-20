using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.DTO
{
    public class Bill
    {
        public Bill(int iD, DateTime? ngayraban, DateTime? ngayvaoban, int trangthai)
        {
            this.ID = iD;
            this.Ngayraban = ngayraban;
            this.Ngayraban = ngayraban;
            this.Trangthai = trangthai;
        }
        public Bill(DataRow row)
        {
            this.ID = (int)row["iD"];
            this.Ngayvaoban = (DateTime?)row["ngayvaoban"];

            var ngayrabantemp = row["ngayraban"];
            if (ngayrabantemp.ToString() != "")
            {
                this.Ngayraban = (DateTime?)ngayrabantemp;
            }

            this.Trangthai = (int)row["trangthai"];
        }
        private int trangthai;
        private DateTime? ngayraban;
        private DateTime? ngayvaoban;
        private int iD;

        public int ID { get => iD; set => iD = value; }
        public DateTime? Ngayvaoban { get => ngayvaoban; set => ngayvaoban = value; }
        public DateTime? Ngayraban { get => ngayraban; set => ngayraban = value; }
        public int Trangthai { get => trangthai; set => trangthai = value; }
    }
}
