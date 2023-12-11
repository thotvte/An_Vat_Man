using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.DTO
{
    public class account
    {
        public account(string tenhienthi, string tendangnhap, int quyen, string matkhau = null)
        {
            this.Tendangnhap = tendangnhap;
            this.Tenhienthi = tenhienthi;
            this.Matkhau = matkhau;
            this.Quyen = quyen;
        }
        public account(DataRow row)
        {
            this.Tendangnhap = row["tendangnhap"].ToString();
            this.Tenhienthi = row["tenhienthi"].ToString();
            this.Matkhau = row["Matkhau"].ToString();
            this.Quyen = (int)row["quyen"];
        }
        private string tenhiemthi;
        private string tendangnhap;
        private  string matkhau;
        private int quyen;
        public string Tenhienthi { get => tenhiemthi; set => tenhiemthi = value; }
        public string Tendangnhap { get => tendangnhap; set => tendangnhap = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
        public int Quyen { get => quyen; set => quyen = value; }
    }
}
