using QuanlyhocsinhTHPT.DataAccess.ServiceInterface;
using QuanlyhocsinhTHPT.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace QuanlyhocsinhTHPT.DataAccess
{
    class ILopHocDAO:ILophocDAO
    {
        public void GhiThongTin(List<LopHoc> lopHocs)
        {
            //string maMH, string tenMH, string soTin, string maGV
            StreamWriter writer = new StreamWriter("LopHoc.txt");
            foreach (LopHoc lp in lopHocs)
            {
                writer.WriteLine(lp.MaLop + "#" + lp.TenLop + "#" + lp.MaGVCN + "#" + lp.SiSO);
            }
            writer.Close();
        }
        public List<LopHoc> LayDS()
        {
            List<LopHoc> lopHocs = new List<LopHoc>();
            StreamReader sr = new StreamReader("LopHoc.txt");
            string s;
            while ((s = sr.ReadLine()) != null)
            {
                if (string.IsNullOrEmpty(s))
                    continue;
                string[] tmp = s.Split('#');
                lopHocs.Add(new LopHoc(tmp[0], tmp[1], tmp[2],int.Parse(tmp[3])));

            }
            sr.Close();
            return lopHocs;

        }
    }
}
