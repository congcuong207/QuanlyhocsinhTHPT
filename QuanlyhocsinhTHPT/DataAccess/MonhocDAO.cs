using Quanlyhocsinh.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Quanlyhocsinh.DataAccess
{
    class MonhocDAO
    {
        public void GhiThongTin(List<Monhoc> monhocs)
        {
            //string maMH, string tenMH, string soTin, string maGV
            StreamWriter writer = new StreamWriter("MonHoc.txt");
            foreach (Monhoc mh in monhocs)
            {
                writer.WriteLine(mh.MaMH + "#" + mh.TenMH + "#"  + mh.MaGV);
            }
            writer.Close();
        }
        public List<Monhoc> LayDS()
        {
            List<Monhoc> monhocs = new List<Monhoc>();
            StreamReader sr = new StreamReader("MonHoc.txt");
            string s;
            while ((s = sr.ReadLine()) != null)
            {
                if (string.IsNullOrEmpty(s))
                    continue;
                string[] tmp = s.Split('#');
                monhocs.Add(new Monhoc(tmp[0], tmp[1], tmp[2]));

            }
            sr.Close();
            return monhocs;

        }
    }
}
