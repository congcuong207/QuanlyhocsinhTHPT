using Quanlyhocsinh.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanlyhocsinhTHPT.DataAccess.ServiceInterface
{
    internal interface IGiaovienDAO
    {
        void GhiThongTin(List<Giaovien> giaoviens);
        List<Giaovien> LayDS();
    }
}
