using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.DTO
{
    public class Food
    {
        public Food(int id, string tenmon, int idmonan, float gia)
        {
            this.Id = id;
            this.Tenmon = tenmon;
            this.Idmonan = idmonan;
            this.Gia = gia;
        }
        
        public Food(DataRow row) 
        {
            this.Id = (int)row["id"];
            this.Tenmon = row["tenmon"].ToString();
            this.Idmonan = (int)row["idmonan"];
            this.Gia = (float)Convert.ToDouble(row["gia"].ToString());
        }


        private int id;
        private string tenmon;
        private int idmonan;
        private float gia;



        public int Id { get => id; set => id = value; }
        public string Tenmon { get => tenmon; set => tenmon = value; }
        public int Idmonan { get => idmonan; set => idmonan = value; }
        public float Gia { get => gia; set => gia = value; }
    }
}
