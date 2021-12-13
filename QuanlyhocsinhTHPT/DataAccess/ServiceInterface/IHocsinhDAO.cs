using Quanlyhocsinh.Entities;
using QuanlyhocsinhTHPT.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanlyhocsinhTHPT.DataAccess.ServiceInterface
{
    internal interface IHocsinhDAO
    {
        void GhiThongTin(List<Hocsinh> hocsinhs);
        List<Hocsinh> LayDS();
    }
}
