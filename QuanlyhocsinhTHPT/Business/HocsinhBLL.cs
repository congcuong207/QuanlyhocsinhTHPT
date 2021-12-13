using Quanlyhocsinh.Entities;
using QuanlyhocsinhTHPT.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quanlyhocsinh.Business
{
    class HocsinhBLL
    {
        public void ThemHocSinh(ref List<Hocsinh> hocsinhs,List<LopHoc> lopHocs)
        {
            Hocsinh hs = new Hocsinh();
            Console.Clear();
            Console.WriteLine("\t\t╔══════════════════════════════════════════════════════╗");
            Console.WriteLine("\t\t║        Nhập thông tin học sinh                       ║");
            Console.WriteLine("\t\t║══════════════════════════════════════════════════════║");
            Console.WriteLine("\t\t║      Nhập mã HS:                                     ║");
            Console.WriteLine("\t\t║══════════════════════════════════════════════════════║");
            Console.WriteLine("\t\t║      Nhập tên HS:                                    ║");
            Console.WriteLine("\t\t║══════════════════════════════════════════════════════║");
            Console.WriteLine("\t\t║      Nhập giới tính:                                 ║");
            Console.WriteLine("\t\t║══════════════════════════════════════════════════════║");
            Console.WriteLine("\t\t║      Nhập ngày sinh:                   (yyyy/MM/dd)  ║");
            Console.WriteLine("\t\t║══════════════════════════════════════════════════════║");
            Console.WriteLine("\t\t║      Nhập mã lớp:                                    ║");
            Console.WriteLine("\t\t║══════════════════════════════════════════════════════║");
            Console.WriteLine("\t\t║      Nhập quê quán:                                  ║");
            Console.WriteLine("\t\t║══════════════════════════════════════════════════════║");
            Console.WriteLine("\t\t║      Nhập số ĐT:                                     ║");
            Console.WriteLine("\t\t╚══════════════════════════════════════════════════════╝");
            do
            {
                bool kt = true;
                Console.SetCursorPosition(35, 3);
                hs.MaHS = Console.ReadLine();
                foreach (Hocsinh item in hocsinhs)
                {
                    if (item.MaHS.ToUpper().Equals(hs.MaHS.ToUpper()))
                    {
                        kt = false;
                    }
                }
                if (hs.MaHS != ""&&kt)
                {
                    break;
                }
            }while(true);
            Console.SetCursorPosition(36, 5);
             hs.TenHS = Console.ReadLine();
            Console.SetCursorPosition(40, 7);
             hs.GioiTinh = Console.ReadLine();
            do
            {
                bool kt=true; 
                try{
                    Console.SetCursorPosition(41, 9);
                    hs.NgaySinh = DateTime.Parse(Console.ReadLine());

                }
                catch
                {
                    kt=false;
                }
                if (kt)
                {
                    break;
                }
            } while (true);
            do
            {
                bool kt= false;
                Console.SetCursorPosition(38, 11);
                hs.MaLop = Console.ReadLine();
                
                foreach(LopHoc lh in lopHocs)
                {
                    if (lh.MaLop.ToUpper().Equals(hs.MaLop.ToUpper()))
                    {
                        kt = true;
                    }
                }
                if (kt)
                {
                    break;
                }
            }while (true);
            Console.SetCursorPosition(38, 13);
            hs.QueQuan = Console.ReadLine();
            Console.SetCursorPosition(35, 15);
            hs.SoDT = Console.ReadLine();
            hocsinhs.Add(hs);
        }
        public void HienThi(List<Hocsinh> sinhviens)
        {
            Console.Clear();
            Console.WriteLine("║{0,-15}║{1,-25}║{2,-20}║{3,-15}║{4,-15}║{5,-25}║{6,-15}║", "Mã hs", "Tên hs", "Giới Tính", "Ngày Sinh", "Mã Lớp", "Quê quán","Số ĐT");
            foreach (Hocsinh hs in sinhviens)
            {
                Hien1(hs);
            }
        }
        public void HienThiTheoLop(List<Hocsinh> sinhviens,string malop)
        {
            Console.Clear();
            Console.WriteLine("║{0,-15}║{1,-25}║{2,-20}║{3,-15}║{4,-15}║{5,-25}║{6,-15}║", "Mã hs", "Tên hs", "Giới Tính", "Ngày Sinh", "Mã Lớp", "Quê quán", "Số ĐT");
            foreach (Hocsinh hs in sinhviens)
            {
                if(malop.ToUpper().Equals(hs.MaLop.ToUpper()))
                {
                    Hien1(hs);
                }    
            }
        }
        public void Hientimkiem(Hocsinh hs)
        {//string MaSach,string TenSach,int SoLuongTon,string MaTL,string MaNXB,string MaTG
            Console.WriteLine("║{0,-15}║{1,-25}║{2,-20}║{3,-15}║{4,-15}║{5,-25}║{6,-15}║", "Mã hs", "Tên hs", "Giới Tính", "Ngày Sinh", "Mã Lớp", "Quê quán", "Số ĐT");
            Console.WriteLine("║{0,-15}║{1,-25}║{2,-20}║{3,-15}║{4,-15}║{5,-25}║{6,-15}║", hs.MaHS, hs.TenHS, hs.GioiTinh, hs.NgaySinh.ToString("yyyy/MM/dd"), hs.MaLop, hs.QueQuan,hs.SoDT);
        }
        public void Hien1(Hocsinh hs)
        {//string MaSach,string TenSach,int SoLuongTon,string MaTL,string MaNXB,string MaTG
            Console.WriteLine("║{0,-15}║{1,-25}║{2,-20}║{3,-15}║{4,-15}║{5,-25}║{6,-15}║", hs.MaHS, hs.TenHS, hs.GioiTinh, hs.NgaySinh.ToString("yyyy/MM/dd"), hs.MaLop, hs.QueQuan, hs.SoDT);
        }
        public Hocsinh TimKiem(List<Hocsinh> hocsinhs, string mahs)
        {
            Hocsinh hstim=new Hocsinh();
            foreach (Hocsinh hs in hocsinhs)
            {
                if (mahs.Equals(hs.MaHS)|| hs.TenHS.ToUpper().IndexOf( mahs.ToUpper())>0)
                {
                    hstim= hs;
                }
            }
            return hstim;
        }
        public void Sapxep(List<Hocsinh> hocsinhs)
        {
            //hocsinhs.Sort((o1, o2) => o1.TenHS.Split(" ")[o1.TenHS.Split(" ").Length - 1].CompareTo(o2.TenHS.Split(" ")[o2.TenHS.Split(" ").Length - 1]));//Sắp xếp theo tên
            hocsinhs.Sort((o1, o2) => o1.MaLop.CompareTo(o2.MaLop));//Sắp xếp theo mã lớp
            HienThi(hocsinhs);

        }
        public void Xoa(ref List<Hocsinh> hocsinhs, Hocsinh hs)
        {

            hocsinhs.Remove(hs);
        }
        public void Sua(ref List<Hocsinh> hocsinhs, string mahs)
        {
            Console.Clear();
            foreach (Hocsinh hs in hocsinhs)
            {
                if (mahs.Equals(hs.MaHS))
                {
                    Console.WriteLine("\t\t╔══════════════════════════════════════════════════════╗");
                    Console.WriteLine("\t\t║         Sửa thông tin sinh viên                      ║");
                    Console.WriteLine("\t\t║══════════════════════════════════════════════════════║");
                    Console.WriteLine("\t\t║      Sửa mã hs:                                      ║");
                    Console.WriteLine("\t\t║══════════════════════════════════════════════════════║");
                    Console.WriteLine("\t\t║      Sửa tên hs:                                     ║");
                    Console.WriteLine("\t\t║══════════════════════════════════════════════════════║");
                    Console.WriteLine("\t\t║      Sửa giới tính:                                  ║");
                    Console.WriteLine("\t\t║══════════════════════════════════════════════════════║");
                    Console.WriteLine("\t\t║      Sửa ngày sinh:                    (yyyy/MM/dd)  ║");
                    Console.WriteLine("\t\t║══════════════════════════════════════════════════════║");
                    Console.WriteLine("\t\t║      Sửa mã lớp:                                     ║");
                    Console.WriteLine("\t\t║══════════════════════════════════════════════════════║");
                    Console.WriteLine("\t\t║      Sửa quê quán:                                   ║");
                    Console.WriteLine("\t\t║══════════════════════════════════════════════════════║");
                    Console.WriteLine("\t\t║      Sửa số ĐT:                                      ║");
                    Console.WriteLine("\t\t╚══════════════════════════════════════════════════════╝");
                    do
                    {
                        bool kt = true;
                        Console.SetCursorPosition(35, 3);
                        string ma = Console.ReadLine();
                        foreach (Hocsinh item in hocsinhs)
                        {
                            if (item.MaHS.ToUpper().Equals(ma.ToUpper()))
                            {
                                kt = false;
                            }
                            else if(ma.ToUpper().Equals(hs.MaHS))
                            {
                                kt = true;
                                break;
                            }    
                        }
                        if (hs.MaHS != "" && kt)
                        {
                            hs.MaHS=ma;
                            break;
                        }
                    } while (true);
                    Console.SetCursorPosition(36, 5);
                    hs.TenHS = Console.ReadLine();
                    Console.SetCursorPosition(40, 7);
                    hs.GioiTinh = Console.ReadLine();
                    do
                    {
                        bool kt = true;
                        try
                        {
                            Console.SetCursorPosition(41, 9);
                            hs.NgaySinh = DateTime.Parse(Console.ReadLine());

                        }
                        catch
                        {
                            kt = false;
                        }
                        if (kt)
                        {
                            break;
                        }
                    } while (true);
                    Console.SetCursorPosition(38, 11);
                    hs.MaLop = Console.ReadLine();
                    Console.SetCursorPosition(38, 13);
                    hs.QueQuan = Console.ReadLine();
                    Console.SetCursorPosition(35, 15);
                    hs.SoDT = Console.ReadLine();

                }
            }
        }
    }
}
