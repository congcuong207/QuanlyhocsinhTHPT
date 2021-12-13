using Quanlyhocsinh.Entities;
using QuanlyhocsinhTHPT.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanlyhocsinhTHPT.Business.ServiceInterface
{
    internal interface IBangdiemBLL
    {
        void ThemBangDiem(ref List<Bangdiem> bangdiems, List<Monhoc> monhocs, List<Hocsinh> hocsinhs);
        void HienThi(List<Bangdiem> bangdiems);
        void Hientimkiem(Bangdiem bd);
        void Hien1(Bangdiem bd);
        Bangdiem TimKiem(List<Bangdiem> bangdiems, string maBD);
        void Xoa(ref List<Bangdiem> bangdiems, Bangdiem bd);
        void Sua(ref List<Bangdiem> bangdiems, List<Monhoc> monhocs, List<Hocsinh> hocsinhs, string maSV);

    }
}
