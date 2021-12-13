using Quanlyhocsinh.Entities;
using QuanlyhocsinhTHPT.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanlyhocsinhTHPT.Business.ServiceInterface
{
    internal interface ILophocBLL
    {
        void ThemLopHoc(ref List<LopHoc> lopHocs, List<Giaovien> giaoviens);
        void HienThi(List<LopHoc> lopHocs);
        void Hientimkiem(LopHoc bd, List<Hocsinh> hocsinhs);
        void Hien1(LopHoc bd);
        LopHoc TimKiem(List<LopHoc> lopHocs, string maBD);
        void Xoa(ref List<LopHoc> lopHocs, LopHoc bd);
        void Sua(ref List<LopHoc> lophocs, List<Giaovien> giaoviens, List<Hocsinh> hocsinhs, string maHS);
        void Thongke(List<Hocsinh> hocsinhs, List<Bangdiem> bangdiems, string maHS);
    }
}
