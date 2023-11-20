using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.DTO
{
    public class table
    {
        private int iD;
        private string tenban;
        private string trangthai;

        public table(int iD, string tenban, string trangthai)
        {
            this.ID = iD;
            this.Tenban = tenban;
            this.Trangthai = trangthai;         
        }
        public table(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Tenban = row["tenban"].ToString();
            this.Trangthai = row["trangthai"].ToString();
        }
        public string Tenban { get => tenban; set => tenban = value; }
        public int ID { get => iD; set => iD = value; }
        public string Trangthai { get => trangthai; set => trangthai = value; }
    }
}
