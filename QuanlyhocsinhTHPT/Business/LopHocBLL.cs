using Quanlyhocsinh.Entities;
using QuanlyhocsinhTHPT.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanlyhocsinhTHPT.Business
{
    class LopHocBLL
    {
        public void ThemLopHoc(ref List<LopHoc> lopHocs, List<Giaovien> giaoviens)
        {
            LopHoc bd = new LopHoc();
            Console.Clear();
            Console.WriteLine("\t\t╔══════════════════════════════════════════════════════╗");
            Console.WriteLine("\t\t║        Nhập thông tin lớp học                        ║");
            Console.WriteLine("\t\t║══════════════════════════════════════════════════════║");
            Console.WriteLine("\t\t║      Nhập mã lớp:                                    ║");
            Console.WriteLine("\t\t║══════════════════════════════════════════════════════║");
            Console.WriteLine("\t\t║      Nhập tên tớp:                                   ║");
            Console.WriteLine("\t\t║══════════════════════════════════════════════════════║");
            Console.WriteLine("\t\t║      Nhập mã GVCN:                                   ║");
            Console.WriteLine("\t\t╚══════════════════════════════════════════════════════╝");
            do
            {
                bool kt = true;
                Console.SetCursorPosition(35, 3);
                bd.MaLop = Console.ReadLine();
                foreach (LopHoc item in lopHocs)
                {
                    if (item.MaLop.ToUpper().Equals(bd.MaLop.ToUpper()))
                    {
                        kt = false;
                    }
                }
                if (bd.MaLop.Trim() != "" && kt)
                {
                    break;
                }
            } while (true);
            do
            {
                Console.SetCursorPosition(37, 5);
                bd.TenLop = Console.ReadLine();
            } while (bd.TenLop.Trim()=="");
            do
            {
                bool kt = false;
                Console.SetCursorPosition(36, 7);
                bd.MaGVCN = Console.ReadLine();
                foreach (Giaovien item in giaoviens)
                {
                    if (item.MaGV.ToUpper().Equals(bd.MaGVCN.ToUpper()))
                    {
                        kt = true;
                    }
                }
                if (bd.MaGVCN != "" && kt)
                {
                    break;
                }
            } while (true);
            lopHocs.Add(bd);
        }
        public void HienThi(List<LopHoc> lopHocs)
        {
            Console.Clear();
            Console.WriteLine("║{0,-15}║{1,-25}║{2,-20}║{3,-15}║", "Mã Lớp", "Tên Lớp", "Mã GVCN", "Sĩ Số");
            foreach (LopHoc bd in lopHocs)
            {
                Hien1(bd);
            }
        }
        public void Hientimkiem(LopHoc bd)
        {//string MaSach,string TenSach,int SoLuongTon,string MaTL,string MaNXB,string MaTG
            Console.WriteLine("║{0,-15}║{1,-25}║{2,-20}║{3,-15}║", "Mã Lớp", "Tên Lớp", "Mã GVCN", "Sĩ Số");
            Console.WriteLine("║{0,-15}║{1,-25}║{2,-20}║{3,-15}║", bd.MaLop, bd.TenLop, bd.MaGVCN, bd.SiSO);
        }
        public void Hien1(LopHoc bd)
        {//string MaSach,string TenSach,int SoLuongTon,string MaTL,string MaNXB,string MaTG
            Console.WriteLine("║{0,-15}║{1,-25}║{2,-20}║{3,-15}║", bd.MaLop, bd.TenLop, bd.MaGVCN, bd.SiSO);
        }
        public LopHoc TimKiem(List<LopHoc> lopHocs, string maBD)
        {
            LopHoc bdtim = new LopHoc();
            foreach (LopHoc bd in lopHocs)
            {
                if (maBD.Equals(bd.MaLop))
                {
                    bdtim = bd;
                }
            }
            return bdtim;
        }
        public void Xoa(ref List<LopHoc> lopHocs, LopHoc bd)
        {

            lopHocs.Remove(bd);
        }
        public void Sua(ref List<LopHoc> lophocs, List<Giaovien> giaoviens, List<Hocsinh> hocsinhs, string maSV)
        {
            foreach (LopHoc bd in lophocs)
            {
                if (maSV.Equals(bd.MaLop))
                {
                    Console.Clear();
                    Console.WriteLine("\t\t╔══════════════════════════════════════════════════════╗");
                    Console.WriteLine("\t\t║         Sửa thông tin lớp học                        ║");
                    Console.WriteLine("\t\t║══════════════════════════════════════════════════════║");
                    Console.WriteLine("\t\t║       Sửa mã lớp:                                    ║");
                    Console.WriteLine("\t\t║══════════════════════════════════════════════════════║");
                    Console.WriteLine("\t\t║       Sửa tên tớp:                                   ║");
                    Console.WriteLine("\t\t║══════════════════════════════════════════════════════║");
                    Console.WriteLine("\t\t║       Sửa mã GVCN:                                   ║");
                    Console.WriteLine("\t\t╚══════════════════════════════════════════════════════╝");
                    do
                    {
                        bool kt = true;
                        Console.SetCursorPosition(35, 3);
                        string malp= Console.ReadLine();
                        
                        foreach (LopHoc item in lophocs)
                        {
                            if (item.MaLop.ToUpper().Equals(malp)&&!malp.Equals(bd.MaLop))
                            {
                                kt = false;
                            }
                            else
                            {
                                kt = true;
                            }
                        }
                        if (bd.MaLop.Trim() != "" && kt)
                        {
                            break;
                        }
                    } while (true);
                    do
                    {
                        Console.SetCursorPosition(37, 5);
                        bd.TenLop = Console.ReadLine();
                    } while (bd.TenLop.Trim() == "");
                    do
                    {
                        bool kt = false;
                        Console.SetCursorPosition(36, 7);
                        bd.MaGVCN = Console.ReadLine();
                        foreach (Giaovien item in giaoviens)
                        {
                            if (item.MaGV.ToUpper().Equals(bd.MaGVCN.ToUpper()))
                            {
                                kt = true;
                            }
                        }
                        if (bd.MaGVCN != "" && kt)
                        {
                            break;
                        }
                    } while (true);
                    int demHS = 0;
                    foreach (Hocsinh hs in hocsinhs)
                    {
                        if (hs.MaLop.Contains(bd.MaLop))
                        {
                            demHS++;
                        }
                    }
                    bd.SiSO = demHS;
                    break;

                }
            }
        }
    }
}
