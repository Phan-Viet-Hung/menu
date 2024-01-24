using System;
using System.Collections;
using System.Linq;

class DienThoai
{
    public string MaDienThoai { get; set; }
    public string TenDienThoai { get; set; }
    public string ThuongHieu { get; set; }
}

class DienThoaiChiTiet : DienThoai
{
    public int DungLuong { get; set; }
    public string MauSac { get; set; }
    public int SoLuong { get; set; }
    public double GiaTien { get; set; }
    public bool TrangThai { get; set; }
}

class Program
{
    static ArrayList DanhSachDienThoai = new ArrayList();
    static ArrayList DanhSachDienThoaiChiTiet = new ArrayList();

    static void Main(string[] args)
    {
        int choice;
        do
        {
            Console.WriteLine("Quan Ly Cua Hang Dien Thoai");
            Console.WriteLine("1. Them dien thoai");
            Console.WriteLine("2. Them dien thoai chi tiet");
            Console.WriteLine("3. Tim dien thoai");
            Console.WriteLine("4. Dang/Ngung kinh doanh");
            Console.WriteLine("5. Thoat");
            Console.Write("Chon: ");

            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        ThemDienThoai();
                        break;
                    case 2:
                        ThemDienThoaiChiTiet();
                        break;
                    case 3:
                        TimDienThoai();
                        break;
                    case 4:
                        CapNhatTrangThaiKinhDoanh();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Lua chon khong hop le. Vui long chon lai.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Vui long nhap so.");
            }

        } while (true);
    }

    static void ThemDienThoai()
    {
        DienThoai dienThoai = new DienThoai();
        Console.Write("Nhap Ma Dien Thoai: ");
        dienThoai.MaDienThoai = Console.ReadLine();
        Console.Write("Nhap Ten Dien Thoai: ");
        dienThoai.TenDienThoai = Console.ReadLine();
        Console.Write("Nhap Thuong Hieu: ");
        dienThoai.ThuongHieu = Console.ReadLine();

        DanhSachDienThoai.Add(dienThoai);
        Console.WriteLine("Them dien thoai thanh cong.");
    }

    static void ThemDienThoaiChiTiet()
    {
        DienThoaiChiTiet dienThoaiChiTiet = new DienThoaiChiTiet();
        Console.Write("Nhap Ma Dien Thoai: ");
        string maDienThoai = Console.ReadLine();

        DienThoai dienThoai = (DienThoai)DanhSachDienThoai.Cast<DienThoai>().FirstOrDefault(x => x.MaDienThoai == maDienThoai);

        if (dienThoai != null)
        {
            dienThoaiChiTiet.MaDienThoai = dienThoai.MaDienThoai;
            Console.Write("Nhap Dung Luong: ");
            dienThoaiChiTiet.DungLuong = int.Parse(Console.ReadLine());
            Console.Write("Nhap Mau Sac: ");
            dienThoaiChiTiet.MauSac = Console.ReadLine();
            Console.Write("Nhap So Luong: ");
            dienThoaiChiTiet.SoLuong = int.Parse(Console.ReadLine());
            Console.Write("Nhap Gia Tien: ");
            dienThoaiChiTiet.GiaTien = double.Parse(Console.ReadLine());
            Console.Write("Nhap Trang Thai (true: dang kinh doanh, false: ngung kinh doanh): ");
            dienThoaiChiTiet.TrangThai = bool.Parse(Console.ReadLine());

            DanhSachDienThoaiChiTiet.Add(dienThoaiChiTiet);
            Console.WriteLine("Them dien thoai chi tiet thanh cong.");
        }
        else
        {
            Console.WriteLine("Ma Dien Thoai khong ton tai. Vui long them dien thoai truoc.");
        }
    }

    static void TimDienThoai()
    {
        Console.Write("Nhap Ma Dien Thoai: ");
        string maDienThoai = Console.ReadLine();

        int stt = 1;
        foreach (DienThoaiChiTiet dt in DanhSachDienThoaiChiTiet)
        {
            if (dt.MaDienThoai == maDienThoai)
            {
                Console.WriteLine($"STT: {stt}");
                Console.WriteLine($"Dung Luong: {dt.DungLuong}");
                Console.WriteLine($"Mau Sac: {dt.MauSac}");
                Console.WriteLine($"So Luong: {dt.SoLuong}");
                Console.WriteLine($"Gia Tien: {dt.GiaTien}");
                Console.WriteLine($"Trang Thai: {(dt.TrangThai ? "Dang kinh doanh" : "Ngung kinh doanh")}");
                stt++;
            }
        }
    }

    static void CapNhatTrangThaiKinhDoanh()
    {
        Console.Write("Nhap Ma Dien Thoai muon cap nhat trang thai: ");
        string maDienThoai = Console.ReadLine();

        DienThoaiChiTiet dt = (DienThoaiChiTiet)DanhSachDienThoaiChiTiet.Cast<DienThoaiChiTiet>().FirstOrDefault(x => x.MaDienThoai == maDienThoai);

        if (dt != null)
        {
            dt.TrangThai = !dt.TrangThai;
            Console.WriteLine($"Cap nhat trang thai thanh cong. Trang Thai hien tai: {(dt.TrangThai ? "Dang kinh doanh" : "Ngung kinh doanh")}");
        }
        else
        {
            Console.WriteLine("Ma Dien Thoai khong ton tai trong danh sach chi tiet. Vui long kiem tra lai.");
        }
    }
}
