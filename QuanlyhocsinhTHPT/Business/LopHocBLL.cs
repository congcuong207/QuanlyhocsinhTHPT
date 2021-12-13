using Quanlyhocsinh.Business;
using Quanlyhocsinh.Entities;
using QuanlyhocsinhTHPT.Business.ServiceInterface;
using QuanlyhocsinhTHPT.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanlyhocsinhTHPT.Business
{
    class LopHocBLL:ILophocBLL
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
            Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                  Danh sách lớp                               ║");
            Console.WriteLine("║══════════════════════════════════════════════════════════════════════════════║");
            Console.WriteLine("║{0,-15}║{1,-25}║{2,-20}║{3,-15}║", "Mã Lớp", "Tên Lớp", "Mã GVCN", "Sĩ Số");
            foreach (LopHoc bd in lopHocs)
            {
                Hien1(bd);
            }
            Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════╝");

        }
        public void Hientimkiem(LopHoc bd,List<Hocsinh>hocsinhs)
        {//string MaSach,string TenSach,int SoLuongTon,string MaTL,string MaNXB,string MaTG
            Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                  Danh sách lớp                               ║");
            Console.WriteLine("║══════════════════════════════════════════════════════════════════════════════║");
            Console.WriteLine("║{0,-15}║{1,-25}║{2,-20}║{3,-15}║", "Mã Lớp", "Tên Lớp", "Mã GVCN", "Sĩ Số");
            Console.WriteLine("║{0,-15}║{1,-25}║{2,-20}║{3,-15}║", bd.MaLop, bd.TenLop, bd.MaGVCN, bd.SiSO);
            Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════╝");


            HocsinhBLL hs = new HocsinhBLL();
            hs.HienThiTheoLop(hocsinhs,bd.MaLop);
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
        public void Sua(ref List<LopHoc> lophocs, List<Giaovien> giaoviens, List<Hocsinh> hocsinhs, string maHS)
        {
            foreach (LopHoc bd in lophocs)
            {
                if (maHS.Equals(bd.MaLop))
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

        public void Thongke(List<Hocsinh> hocsinhs,List<Bangdiem>bangdiems, string maHS)
        {
            double tonggioi=0;
            double tongkha =0;
            double tonghs =0;
            double tongtrungbinh =0;
            bool kt =false;
            double tongyeu = 0;
            foreach (Hocsinh lh in hocsinhs)
            {
                
                if (lh.MaLop.ToUpper().Equals(maHS.ToUpper())){
                    kt = true;
                    tonghs++;
                    foreach (Bangdiem bd in bangdiems)
                    {
                        if (lh.MaHS.ToUpper().Equals(bd.MaHS.ToUpper()))
                        {
                            if (bd.DiemTB() >= 8.0)
                            {
                                tonggioi++;
                            }
                            else if(bd.DiemTB() >= 7.0)
                            {
                                tongkha++;
                            }
                            else if (bd.DiemTB() >= 5)
                            {
                                tongtrungbinh++;
                            }
                            else
                            {
                                tongyeu++;
                            }
                        }
                    }
                }
            }
            if (kt) {
                Console.WriteLine("% Học sinh giỏi: " + (tonggioi/tonghs)*100+"%");
                Console.WriteLine("% Học sinh khá: " + (tongkha / tonghs) * 100 + "%");
                Console.WriteLine("% Học sinh trung bình: " + (tongtrungbinh / tonghs) * 100 + "%");
                Console.WriteLine("% Học sinh yếu: " + (tongyeu / tonghs) * 100 + "%");
            }
            
        }
    }
}
