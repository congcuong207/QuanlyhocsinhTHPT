using Quanlyhocsinh.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanlyhocsinhTHPT.DataAccess.ServiceInterface
{
    internal interface IBangdiemDAO
    {
        void GhiThongTin(List<Bangdiem> bangdiems);
        List<Bangdiem> LayDS();
    }
}
