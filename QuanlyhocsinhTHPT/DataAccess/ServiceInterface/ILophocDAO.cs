using QuanlyhocsinhTHPT.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanlyhocsinhTHPT.DataAccess.ServiceInterface
{
    internal interface ILophocDAO
    {
        void GhiThongTin(List<LopHoc> lopHocs);
        List<LopHoc> LayDS();
    }
}
