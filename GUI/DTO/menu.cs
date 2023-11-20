using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Compilation;

namespace GUI.DTO
{
    public class menu
    {
        public menu(string tenmon, int count, float gia, float totalPrice = 0)
        {
            this.tenmon = tenmon;
            this.count = count;
            this.Gia = gia;
            this.totalPrice = totalPrice;

        }
        public menu(DataRow row)
        {
            this.tenmon = row["tenmon"].ToString();
            this.count = (int)row["count"];
            this.Gia = (float)Convert.ToDouble(row["gia"].ToString());
            this.totalPrice = (float)Convert.ToDouble(row["totalPrice"].ToString());

        }
        private string tenmon;
        private int count;
        private float gia;
        private float totalPrice;

        public string Tenmon { get => tenmon; set => tenmon = value; }
        public int Count { get => count; set => count = value; }
        
        public float TotalPrice { get => totalPrice; set => totalPrice = value; }
        public float Gia { get => gia; set => gia = value; }
    }
}
