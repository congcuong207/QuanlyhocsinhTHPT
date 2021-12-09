using Quanlyhocsinh.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Quanlyhocsinh.DataAccess
{
    class BangdiemDAO
    {
        public void GhiThongTin(List<Bangdiem> bangdiems)
        {
            //string maSV, string maMH, string tenSV, double diemQT, double diemKTHP
            StreamWriter writer = new StreamWriter("BangDiem.txt");
            foreach (Bangdiem bd in bangdiems)
            {
                writer.WriteLine(bd.MaHS + "#" + bd.MaMH + "#" + bd.TenHS + "#" + bd.DiemQT+ "#" + bd.DiemKTHP);
            }
            writer.Close();
        }
        public List<Bangdiem> LayDS()
        {
            List<Bangdiem> bangdiems = new List<Bangdiem>();
            StreamReader sr = new StreamReader("BangDiem.txt");
            string s;
            while ((s = sr.ReadLine()) != null)
            {
                if (string.IsNullOrEmpty(s))
                    continue;
                string[] tmp = s.Split('#');
                bangdiems.Add(new Bangdiem(tmp[0], tmp[1], tmp[2], double.Parse(tmp[3]), double.Parse(tmp[4])));

            }
            sr.Close();
            return bangdiems;

        }
    }
}
