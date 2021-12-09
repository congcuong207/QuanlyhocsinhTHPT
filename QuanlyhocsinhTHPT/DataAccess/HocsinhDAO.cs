using Quanlyhocsinh.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Quanlyhocsinh.DataAccess
{
    class HocsinhDAO
    {
        public void GhiThongTin(List<Hocsinh> hocsinhs)
        {
            //string maSV, string tenSV, string gioiTinh, DateTime ngaySinh, string maLop, string queQuan, string soDT
            StreamWriter writer = new StreamWriter("HocSinh.txt");
            foreach (Hocsinh sv in hocsinhs)
            {
                writer.WriteLine(sv.MaHS + "#" + sv.TenHS + "#" + sv.GioiTinh + "#" + sv.NgaySinh.ToString("yyyy/MM/dd") + "#" + sv.MaLop+"#"+sv.QueQuan+"#"+sv.SoDT);
            }
            writer.Close();
        }
        public List<Hocsinh> LayDS()
        {
            List<Hocsinh> sinhviens = new List<Hocsinh>();
            StreamReader sr = new StreamReader("HocSinh.txt");
            string s;
            while ((s = sr.ReadLine()) != null)
            {
                if (string.IsNullOrEmpty(s))
                    continue;
                string[] tmp = s.Split('#');
                sinhviens.Add(new Hocsinh(tmp[0], tmp[1], tmp[2], DateTime.Parse(tmp[3]), tmp[4], tmp[5], tmp[6]));

            }
            sr.Close();
            return sinhviens;

        }
    }
}
