using Quanlyhocsinh.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanlyhocsinhTHPT.Business.ServiceInterface
{
    internal interface IMonhocBLL
    {
        void ThemMonHoc(ref List<Monhoc> monhocs, List<Giaovien> giaoviens);
        void HienThi(List<Monhoc> monhocs);
        void Hientimkiem(Monhoc mh);
        void Hien1(Monhoc mh);
        Monhoc TimKiem(List<Monhoc> monhocs, string maMH);
        void Xoa(ref List<Monhoc> monhocs, Monhoc mh);
        void Sua(ref List<Monhoc> monhocs, string maMH);
    }
}
