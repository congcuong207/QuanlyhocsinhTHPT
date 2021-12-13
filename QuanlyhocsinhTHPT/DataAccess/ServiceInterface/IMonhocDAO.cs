using Quanlyhocsinh.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanlyhocsinhTHPT.DataAccess.ServiceInterface
{
    internal interface IMonhocDAO
    {
        void GhiThongTin(List<Monhoc> monhocs);
        List<Monhoc> LayDS();
    }
}
