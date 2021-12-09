using Quanlyhocsinh.Business;
using Quanlyhocsinh.DataAccess;
using Quanlyhocsinh.Entities;
using QuanlyhocsinhTHPT.Business;
using QuanlyhocsinhTHPT.DataAccess;
using QuanlyhocsinhTHPT.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quanlyhocsinh.View
{
    class Run
    {
        public List<Hocsinh> hocsinhs= new List<Hocsinh>();
        public List<LopHoc> lophocs = new List<LopHoc>();
        public List<Monhoc> monhocs= new List<Monhoc>();
        public List<Giaovien> giaoviens = new List<Giaovien>();
        public List<Bangdiem> bangdiems=new List<Bangdiem>();
        public int MenuRun()
        {
            int n = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("\t\t\t\t\t\t╔═══════════════════════════════════════════════════╗");
                Console.WriteLine("\t\t\t\t\t\t║          CHƯƠNG TRÌNH QUẢN LÝ Sinh Viên           ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     1. Quản lý sinh viên                          ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     2. Quản lý giáo viên                          ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     3. Quản lý môn học                            ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     4. Quản lý bảng điểm                          ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     5. Quản lý lớp học                            ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     6. Quay lại                                   ║");
                Console.WriteLine("\t\t\t\t\t\t║═══════════════════════════════════════════════════║");
                Console.WriteLine("\t\t\t\t\t\t║     Chọn:                                         ║");
                Console.WriteLine("\t\t\t\t\t\t╚═══════════════════════════════════════════════════╝");
                Console.SetCursorPosition(60, 15);
                try
                {
                    n = int.Parse(Console.ReadLine());//nhập n
                }
                catch
                {

                }
            } while (n < 1 || n > 6);//nếu n <1 hoặc lớn hơn 5 thì lặp lại
            return n;
        }
        BangdiemBLL bangdiemBLL;
        GiaovienBLL giaovienBLL;
        MonhocBLL monhocBLL;
        HocsinhBLL sinhvienBLL;
        BangdiemDAO bangdiemDAO;
        GiaovienDAO giaovienDAO;
        MonhocDAO monhocDAO;
        HocsinhDAO hocsinhDAO;
        LopHocBLL lophocBLL;
        LopHocDAO lophocDAO;
        Menu menu;
        public void Init()
        {

            bangdiemBLL = new BangdiemBLL();
             giaovienBLL = new GiaovienBLL();
             monhocBLL = new MonhocBLL();
             sinhvienBLL = new HocsinhBLL();
            lophocBLL = new LopHocBLL();
             bangdiemDAO = new BangdiemDAO();
             giaovienDAO = new GiaovienDAO();
             monhocDAO = new MonhocDAO();
            hocsinhDAO = new HocsinhDAO();
            lophocDAO = new LopHocDAO();
            hocsinhs = hocsinhDAO.LayDS();
            giaoviens = giaovienDAO.LayDS();
            lophocs= lophocDAO.LayDS();
            monhocs = monhocDAO.LayDS();
            bangdiems = bangdiemDAO.LayDS();
             menu = new Menu();
        }
        public void Start()
        {
            Init();
            while (true)
            {
                int chon = MenuRun();
                switch (chon)
                {
                    case 1:

                        do
                        {
                            //hocsinhs = new List<Hocsinh>();
                            hocsinhs = hocsinhDAO.LayDS();
                            chon = menu.MenuSV();
                            switch (chon)
                            {
                                case 1:
                                    sinhvienBLL.ThemHocSinh(ref hocsinhs,lophocs);
                                    hocsinhDAO.GhiThongTin(hocsinhs);
                                    break;
                                case 2:
                                    sinhvienBLL.HienThi(hocsinhs);
                                    Console.ReadLine();
                                    break;
                                case 3:
                                    Console.Write("Nhập mã SV cần sửa: ");
                                    sinhvienBLL.Sua(ref hocsinhs, Console.ReadLine());
                                    hocsinhDAO.GhiThongTin(hocsinhs);
                                    break;
                                case 4:
                                    Console.Write("Nhập mã SV cần xóa: ");
                                    sinhvienBLL.Xoa(ref hocsinhs, sinhvienBLL.TimKiem(hocsinhs, Console.ReadLine()));
                                    hocsinhDAO.GhiThongTin(hocsinhs);
                                    break;
                                case 5:
                                    Console.Write("Nhập mã SV cần tìm: ");
                                    sinhvienBLL.Hientimkiem(sinhvienBLL.TimKiem(hocsinhs, Console.ReadLine()));
                                    Console.ReadLine();
                                    break;
                            }
                        } while (chon != 6);
                        break;
                    case 2:

                        do
                        {
                            //giaoviens = new List<Giaovien>();
                            giaoviens = giaovienDAO.LayDS();
                            chon = menu.MenuGV();
                            switch (chon)
                            {
                                case 1:
                                    giaovienBLL.ThemGiaoVien(ref giaoviens);
                                    giaovienDAO.GhiThongTin(giaoviens);
                                    break;
                                case 2:
                                    giaovienBLL.HienThi(giaoviens);
                                    Console.ReadLine();
                                    break;
                                case 3:
                                    Console.Write("Nhập mã TB cần sửa: ");
                                    giaovienBLL.Sua(ref giaoviens, Console.ReadLine());
                                    giaovienDAO.GhiThongTin(giaoviens);
                                    break;
                                case 4:
                                    Console.Write("Nhập mã TB cần xóa: ");
                                    giaovienBLL.Xoa(ref giaoviens, giaovienBLL.TimKiem(giaoviens, Console.ReadLine()));
                                    giaovienDAO.GhiThongTin(giaoviens);
                                    break;
                                case 5:
                                    Console.Write("Nhập mã SV cần tìm: ");
                                    giaovienBLL.Hientimkiem(giaovienBLL.TimKiem(giaoviens, Console.ReadLine()));
                                    Console.ReadLine();
                                    break;
                            }
                        } while (chon != 6);
                        break;
                    case 3:

                        do
                        {
                            //monhocs = new List<Monhoc>();
                            monhocs = monhocDAO.LayDS();
                            chon = menu.MenuMH();
                            switch (chon)
                            {
                                case 1:
                                    monhocBLL.ThemMonHoc(ref monhocs,giaoviens);
                                    monhocDAO.GhiThongTin(monhocs);
                                    break;
                                case 2:
                                    monhocBLL.HienThi(monhocs);
                                    Console.ReadLine();
                                    break;
                                case 3:
                                    Console.Write("Nhập mã phòng TH cần sửa: ");
                                    monhocBLL.Sua(ref monhocs, Console.ReadLine());
                                    monhocDAO.GhiThongTin(monhocs);
                                    break;
                                case 4:
                                    Console.Write("Nhập mã phòng TH cần xóa: ");
                                    monhocBLL.Xoa(ref monhocs, monhocBLL.TimKiem(monhocs, Console.ReadLine()));
                                    monhocDAO.GhiThongTin(monhocs);
                                    break;
                                case 5:
                                    Console.Write("Nhập mã phòng TH cần tìm: ");
                                    monhocBLL.Hientimkiem(monhocBLL.TimKiem(monhocs, Console.ReadLine()));
                                    Console.ReadLine();
                                    break;
                            }
                        } while (chon != 6);
                        break;
                    case 4:

                        do
                        {
                            //bangdiems = new List<Bangdiem>();
                            bangdiems = bangdiemDAO.LayDS();
                            chon = menu.MenuBD();
                            switch (chon)
                            {
                                case 1:
                                    bangdiemBLL.ThemBangDiem(ref bangdiems,monhocs, hocsinhs);
                                    bangdiemDAO.GhiThongTin(bangdiems);
                                    break;
                                case 2:
                                    bangdiemBLL.HienThi(bangdiems);
                                    Console.ReadLine();
                                    break;
                                case 3:
                                    Console.Write("Nhập mã phòng TH cần trả: ");
                                    bangdiemBLL.Sua(ref bangdiems,monhocs, hocsinhs, Console.ReadLine());
                                    bangdiemDAO.GhiThongTin(bangdiems);
                                    break;
                                case 4:
                                    Console.Write("Nhập mã phòng TH cần xóa: ");
                                    bangdiemBLL.Xoa(ref bangdiems, bangdiemBLL.TimKiem(bangdiems, Console.ReadLine()));
                                    bangdiemDAO.GhiThongTin(bangdiems);
                                    break;
                                case 5:
                                    Console.Write("Nhập mã phòng TH cần tìm: ");
                                    bangdiemBLL.Hientimkiem(bangdiemBLL.TimKiem(bangdiems, Console.ReadLine()));
                                    Console.ReadLine();
                                    break;
                            }
                        } while (chon != 6);
                        break;
                    case 5:
                        do
                        {
                            //lophocs = new List<LopHoc>();
                            lophocs = lophocDAO.LayDS();
                            chon = menu.MenuLP();
                            switch (chon)
                            {
                                case 1:
                                    lophocBLL.ThemLopHoc(ref lophocs, giaoviens);
                                    lophocDAO.GhiThongTin(lophocs);
                                    break;
                                case 2:
                                    lophocBLL.HienThi(lophocs);
                                    Console.ReadLine();
                                    break;
                                case 3:
                                    Console.Write("Nhập mã lớp cần tìm: ");
                                    lophocBLL.Sua(ref lophocs, giaoviens, hocsinhs, Console.ReadLine());
                                    lophocDAO.GhiThongTin(lophocs);
                                    break;
                                case 4:
                                    Console.Write("Nhập mã phòng TH cần xóa: ");
                                    lophocBLL.Xoa(ref lophocs, lophocBLL.TimKiem(lophocs, Console.ReadLine()));
                                    lophocDAO.GhiThongTin(lophocs);
                                    break;
                                case 5:
                                    Console.Write("Nhập mã phòng TH cần tìm: ");
                                    lophocBLL.Hientimkiem(lophocBLL.TimKiem(lophocs, Console.ReadLine()));
                                    Console.ReadLine();
                                    break;
                            }
                        } while (chon != 6);
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                }
            }

        }
    }
}
