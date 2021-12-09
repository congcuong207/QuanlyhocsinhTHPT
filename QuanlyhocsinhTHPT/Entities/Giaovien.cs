using System;
using System.Collections.Generic;
using System.Text;

namespace Quanlyhocsinh.Entities
{
    class Giaovien
    {
        string maGV;
        string tenGV;
        string gioTinh;
        DateTime namSinh;
        string soDT;
        public Giaovien()
        {

        }
        public Giaovien(string maGV, string tenGV, string gioTinh, DateTime namSinh, string soDT)
        {
            this.maGV = maGV;
            this.tenGV = tenGV;
            this.gioTinh = gioTinh;
            this.namSinh = namSinh;
            this.soDT = soDT;
        }

        public string MaGV { get => maGV; set => maGV = value; }
        public string TenGV { get => tenGV; set => tenGV = value; }
        public string GioTinh { get => gioTinh; set => gioTinh = value; }
        public DateTime NamSinh { get => namSinh; set => namSinh = value; }
        public string SoDT { get => soDT; set => soDT = value; }
    }
}
