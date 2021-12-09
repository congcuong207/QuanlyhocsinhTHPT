using System;
using System.Collections.Generic;
using System.Text;

namespace Quanlyhocsinh.Entities
{
    class Bangdiem
    {
        string maHS;
        string maMH;
        string tenHS;
        double diemQT;
        double diemKTHP;
        public double DiemTB()
        {
            return (diemQT*2+diemKTHP*3)/5;
        }

        public Bangdiem()
        {
        }
        
        public Bangdiem(string maHS, string maMH, string tenHS, double diemQT, double diemKTHP)
        {
            this.MaHS = maHS;
            this.MaMH = maMH;
            this.TenHS = tenHS;
            this.DiemQT = diemQT;
            this.DiemKTHP = diemKTHP;
        }

        public string MaHS { get => maHS; set => maHS = value; }
        public string MaMH { get => maMH; set => maMH = value; }
        public string TenHS { get => tenHS; set => tenHS = value; }
        public double DiemQT { get => diemQT; set => diemQT = value; }
        public double DiemKTHP { get => diemKTHP; set => diemKTHP = value; }
    }
}
