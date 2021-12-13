using Quanlyhocsinh.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanlyhocsinhTHPT.Business.ServiceInterface
{
    internal interface IGiaovienBLL
    {
        void ThemGiaoVien(ref List<Giaovien> giaoviens);
        void HienThi(List<Giaovien> giaoviens);
        void Hientimkiem(Giaovien gv);
        void Hien1(Giaovien gv);
        Giaovien TimKiem(List<Giaovien> giaoviens, string maGV);
        void Xoa(ref List<Giaovien> giaoviens, Giaovien gv);
        void Sua(ref List<Giaovien> giaoviens, string maGV);
    }
}
