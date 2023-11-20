using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.DTO
{
    public class Category
    {
        public Category(int id, string loai)
        {
            this.Id = id;
            this.Loai = loai;
        }
        public Category(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Loai = row["Loai"].ToString();
        }
        private int id;
        private string loai;

        public int Id { get => id; set => id = value; }
        public string Loai { get => loai; set => loai = value; }
    }
}
