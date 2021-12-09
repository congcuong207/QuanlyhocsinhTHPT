using Quanlyhocsinh.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quanlyhocsinh.Business
{
    class MonhocBLL
    {
        public void ThemMonHoc(ref List<Monhoc> monhocs,List<Giaovien> giaoviens)
        {
            Monhoc mh = new Monhoc();
            Console.Clear();
            Console.WriteLine("\t\t╔══════════════════════════════════════════════════════╗");
            Console.WriteLine("\t\t║        Nhập thông tin môn học                        ║");
            Console.WriteLine("\t\t║══════════════════════════════════════════════════════║");
            Console.WriteLine("\t\t║      Nhập mã MH:                                     ║");
            Console.WriteLine("\t\t║══════════════════════════════════════════════════════║");
            Console.WriteLine("\t\t║      Nhập Tên MH:                                    ║");
            Console.WriteLine("\t\t║══════════════════════════════════════════════════════║");
            Console.WriteLine("\t\t║      Nhập mã GV:                                     ║");
            Console.WriteLine("\t\t╚══════════════════════════════════════════════════════╝");
            do
            {
                bool kt = true;
                Console.SetCursorPosition(35, 3);
                mh.MaMH = Console.ReadLine();
                foreach (Monhoc item in monhocs)
                {
                    if (item.MaMH.ToUpper().Equals(mh.MaMH.ToUpper()))
                    {
                        kt = false;
                    }
                }
                if (mh.MaMH != "" && kt)
                {
                    break;
                }
            } while (true);
            Console.SetCursorPosition(36, 5);
            mh.TenMH = Console.ReadLine();
            do
            {
                bool kt = false;
                Console.SetCursorPosition(36, 7);
                mh.MaGV = Console.ReadLine();
                foreach(Giaovien gv in giaoviens)
                {
                    if (gv.MaGV.ToUpper().Contains(mh.MaGV.ToUpper()))
                    {
                        kt = true;
                    }
                }
                if (kt && mh.MaGV.Trim()=="")
                {
                    break;
                }
            }while(true);
           
                        monhocs.Add(mh);
        }
        public void HienThi(List<Monhoc> monhocs)
        {
            Console.Clear();
            Console.WriteLine("║{0,-15}║{1,-25}║{2,-20}║", "Mã MH", "Tên MH", "Mã GV");
            foreach (Monhoc mh in monhocs)
            {
                Hien1(mh);
            }
        }
        public void Hientimkiem(Monhoc mh)
        {
            Console.WriteLine("║{0,-15}║{1,-25}║{2,-20}║", "Mã MH", "Tên MH", "Mã GV");
            Console.WriteLine("║{0,-15}║{1,-25}║{2,-20}║", mh.MaMH, mh.TenMH, mh.MaGV);
        }
        public void Hien1(Monhoc mh)
        {
            Console.WriteLine("║{0,-15}║{1,-25}║{2,-20}║", mh.MaMH, mh.TenMH, mh.MaGV);
        }
        public Monhoc TimKiem(List<Monhoc> monhocs, string maMH)
        {
            Monhoc mhtim = new Monhoc();
            foreach (Monhoc mh in monhocs)
            {
                if (maMH.Equals(mh.MaMH))
                {
                    mhtim = mh;
                }
            }
            return mhtim;
        }
        public void Xoa(ref List<Monhoc> monhocs, Monhoc mh)
        {

            monhocs.Remove(mh);
        }
        public void Sua(ref List<Monhoc> monhocs, string maMH)
        {
            foreach (Monhoc mh in monhocs)
            {
                if (maMH.Equals(mh.MaMH))
                {
                    Console.WriteLine("\t\t╔══════════════════════════════════════════════════════╗");
                    Console.WriteLine("\t\t║        Nhập thông tin môn học                        ║");
                    Console.WriteLine("\t\t║══════════════════════════════════════════════════════║");
                    Console.WriteLine("\t\t║      Sửa mã MH:                                      ║");
                    Console.WriteLine("\t\t║══════════════════════════════════════════════════════║");
                    Console.WriteLine("\t\t║      Sửa Tên MH:                                     ║");
                    Console.WriteLine("\t\t║══════════════════════════════════════════════════════║");
                    Console.WriteLine("\t\t║      Sửa mã GV:                                      ║");
                    Console.WriteLine("\t\t╚══════════════════════════════════════════════════════╝");
                    do
                    {
                        bool kt = true;
                        Console.SetCursorPosition(35, 3);
                        string ma = Console.ReadLine();
                        foreach (Monhoc item in monhocs)
                        {
                            if (item.MaMH.ToUpper().Equals(ma.ToUpper()))
                            {
                                kt = false;
                            }
                        }
                        if (mh.MaMH != "" && kt)
                        {
                            mh.MaMH = ma;
                            break;
                        }
                    } while (true);
                    Console.SetCursorPosition(36, 5);
                    mh.TenMH = Console.ReadLine();
                    Console.SetCursorPosition(36, 7);
                    mh.MaGV = Console.ReadLine();
                }
            }
        }
    }
}
