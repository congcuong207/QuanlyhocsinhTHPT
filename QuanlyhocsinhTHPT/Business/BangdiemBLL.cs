using Quanlyhocsinh.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quanlyhocsinh.Business
{
    class BangdiemBLL
    {
        public void ThemBangDiem(ref List<Bangdiem> bangdiems,List<Monhoc> monhocs, List<Hocsinh> hocsinhs)
        {
            Bangdiem bd = new Bangdiem();
            Console.Clear();
            Console.WriteLine("\t\t╔══════════════════════════════════════════════════════╗");
            Console.WriteLine("\t\t║        Nhập thông tin bảng điểm                      ║");
            Console.WriteLine("\t\t║══════════════════════════════════════════════════════║");
            Console.WriteLine("\t\t║      Nhập mã HS:                                     ║");
            Console.WriteLine("\t\t║══════════════════════════════════════════════════════║");
            Console.WriteLine("\t\t║      Nhập mã MH:                                     ║");
            Console.WriteLine("\t\t║══════════════════════════════════════════════════════║");
            Console.WriteLine("\t\t║      Nhập điểm giữa kì:                              ║");
            Console.WriteLine("\t\t║══════════════════════════════════════════════════════║");
            Console.WriteLine("\t\t║      Nhập điểm cuối kì:                              ║");
            Console.WriteLine("\t\t╚══════════════════════════════════════════════════════╝");
            do
            {
                bool kt = false;
                Console.SetCursorPosition(35, 3);
                bd.MaHS = Console.ReadLine();
                foreach (Hocsinh item in hocsinhs)
                {
                    if (item.MaHS.ToUpper().Equals(bd.MaHS.ToUpper()))
                    {
                        kt = true;
                    }
                }
                if (bd.MaHS != "" && kt)
                {
                    break;
                }
            } while (true);
            do
            {
                bool kt = false;
                Console.SetCursorPosition(36, 5);
                bd.MaMH = Console.ReadLine();
                foreach (Monhoc item in monhocs)
                {
                    if (item.MaMH.ToUpper().Equals(bd.MaMH.ToUpper()))
                    {
                        kt = true;
                    }
                }
                if (bd.MaHS != "" && kt)
                {
                    break;
                }
            } while (true);
            
             for (int i = 0; i < hocsinhs.Count; i++)
            {
                if (hocsinhs[i].MaHS.ToUpper().Equals(bd.MaHS.ToUpper())){
                    bd.TenHS=hocsinhs[i].TenHS;
                    
                }
            }
            Console.SetCursorPosition(36, 7);
            bd.DiemQT = Double.Parse(Console.ReadLine());
            Console.SetCursorPosition(40, 9);
            bd.DiemKTHP = Double.Parse(Console.ReadLine());
            bangdiems.Add(bd);
        }
        public void HienThi(List<Bangdiem> bangdiems)
        {
            Console.Clear();
            Console.WriteLine("║{0,-15}║{1,-25}║{2,-20}║{3,-15}║{4,-15}║", "Mã SV", "Tên SV", "Mã MH", "Điểm QT", "Điểm KTHP");
            foreach (Bangdiem bd in bangdiems)
            {
                Hien1(bd);
            }
        }
        public void Hientimkiem(Bangdiem bd)
        {//string MaSach,string TenSach,int SoLuongTon,string MaTL,string MaNXB,string MaTG
            Console.WriteLine("║{0,-15}║{1,-25}║{2,-20}║{3,-15}║{4,-15}║", "Mã SV", "Tên SV", "Mã MH", "Điểm QT", "Điểm KTHP");
            Console.WriteLine("║{0,-15}║{1,-25}║{2,-20}║{3,-15}║{4,-15}║", bd.MaHS, bd.TenHS, bd.MaMH, bd.DiemQT, bd.DiemKTHP);
        }
        public void Hien1(Bangdiem bd)
        {//string MaSach,string TenSach,int SoLuongTon,string MaTL,string MaNXB,string MaTG
            Console.WriteLine("║{0,-15}║{1,-25}║{2,-20}║{3,-15}║{4,-15}║", bd.MaHS, bd.TenHS, bd.MaMH, bd.DiemQT, bd.DiemKTHP);
        }
        public Bangdiem TimKiem(List<Bangdiem> bangdiems, string maBD)
        {
            Bangdiem bdtim = new Bangdiem();
            foreach (Bangdiem bd in bangdiems)
            {
                if (maBD.Equals(bd.MaHS))
                {
                    bdtim = bd;
                }
            }
            return bdtim;
        }
        public void Xoa(ref List<Bangdiem> bangdiems, Bangdiem bd)
        {

            bangdiems.Remove(bd);
        }
        public void Sua(ref List<Bangdiem> bangdiems, List<Monhoc> monhocs, List<Hocsinh> hocsinhs, string maSV)
        {
            foreach (Bangdiem bd in bangdiems)
            {
                if (maSV.Equals(bd.MaHS))
                {
                    Console.Clear();
                    Console.WriteLine("\t\t╔══════════════════════════════════════════════════════╗");
                    Console.WriteLine("\t\t║         Sửa thông tin bảng điểm                      ║");
                    Console.WriteLine("\t\t║══════════════════════════════════════════════════════║");
                    Console.WriteLine("\t\t║       Sửa mã SV:                                     ║");
                    Console.WriteLine("\t\t║══════════════════════════════════════════════════════║");
                    Console.WriteLine("\t\t║       Sửa mã MH:                                     ║");
                    Console.WriteLine("\t\t║══════════════════════════════════════════════════════║");
                    Console.WriteLine("\t\t║       Sửa điểm QT:                                   ║");
                    Console.WriteLine("\t\t║══════════════════════════════════════════════════════║");
                    Console.WriteLine("\t\t║       Sửa điểm KTHP:                                 ║");
                    Console.WriteLine("\t\t╚══════════════════════════════════════════════════════╝");
                    do
                    {
                        bool kt = false;
                        Console.SetCursorPosition(35, 3);
                        bd.MaHS = Console.ReadLine();
                        foreach (Hocsinh item in hocsinhs)
                        {
                            if (item.MaHS.ToUpper().Equals(bd.MaHS.ToUpper()))
                            {
                                kt = true;
                            }
                        }
                        if (bd.MaHS != "" && kt)
                        {
                            break;
                        }
                    } while (true);
                    do
                    {
                        bool kt = false;
                        Console.SetCursorPosition(36, 5);
                        bd.MaMH = Console.ReadLine();
                        foreach (Monhoc item in monhocs)
                        {
                            if (item.MaMH.ToUpper().Equals(bd.MaMH.ToUpper()))
                            {
                                kt = true;
                            }
                        }
                        if (bd.MaHS != "" && kt)
                        {
                            break;
                        }
                    } while (true);

                    for (int i = 0; i < hocsinhs.Count; i++)
                    {
                        if (hocsinhs[i].MaHS.ToUpper().Equals(bd.MaHS.ToUpper()))
                        {
                            bd.TenHS = hocsinhs[i].TenHS;

                        }
                    }
                    Console.SetCursorPosition(36, 7);
                    bd.DiemQT = Double.Parse(Console.ReadLine());
                    Console.SetCursorPosition(40, 9);
                    bd.DiemKTHP = Double.Parse(Console.ReadLine());
                  
                }
            }
        }
    }
}
