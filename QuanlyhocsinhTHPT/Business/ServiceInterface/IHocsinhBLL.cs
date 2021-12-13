using Quanlyhocsinh.Entities;
using QuanlyhocsinhTHPT.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanlyhocsinhTHPT.Business.ServiceInterface
{
    internal interface IHocsinhBLL
    {
        void ThemHocSinh(ref List<Hocsinh> hocsinhs, List<LopHoc> lopHocs);
        void HienThi(List<Hocsinh> sinhviens);
        void HienThiTheoLop(List<Hocsinh> sinhviens, string malop);
        void Hientimkiem(Hocsinh hs);
        void Hien1(Hocsinh hs);
        Hocsinh TimKiem(List<Hocsinh> hocsinhs, string mahs);
        void Sapxep(List<Hocsinh> hocsinhs);
        void Xoa(ref List<Hocsinh> hocsinhs, Hocsinh hs);
        void Sua(ref List<Hocsinh> hocsinhs, string mahs);
    }
}
