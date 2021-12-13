using System;
using System.Collections.Generic;
using System.Text;

namespace QuanlyhocsinhTHPT.Entities
{
    class Hocsinh
    {
        string maHS;
        string tenHS;
        string gioiTinh;
        DateTime ngaySinh;
        string maLop;
        string queQuan;
        string soDT;
        public Hocsinh()
        {

        }
        public Hocsinh(string maHS, string tenHS, string gioiTinh, DateTime ngaySinh, string maLop, string queQuan, string soDT)
        {
            this.maHS = maHS;
            this.tenHS = tenHS;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
            this.maLop = maLop;
            this.queQuan = queQuan;
            this.soDT = soDT;
        }

        public string MaHS { get => maHS; set => maHS = value; }
        public string TenHS { get => tenHS; set => tenHS = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string MaLop { get => maLop; set => maLop = value; }
        public string QueQuan { get => queQuan; set => queQuan = value; }
        public string SoDT { get => soDT; set => soDT = value; }
    }
}
