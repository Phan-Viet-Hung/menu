using menu;
using System;
using System.Collections.Generic;

class Program
{
    static List<Giay> danhSachGiay = new List<Giay>();

    static void Main()
    {
        int luaChon;
        do
        {
            Menu();
            Console.Write("Nhap lua chon cua ban: ");
            luaChon = int.Parse(Console.ReadLine());

            switch (luaChon)
            {
                case 1:
                    ThemMoiGiay();
                    break;
                case 2:
                    HienThiDanhSachGiay();
                    break;
                case 3:
                    
                    break;
                default:
                    Console.WriteLine("Lua chon khong hop le. Vui long nhap lai.");
                    break;
            }

        } while (luaChon != 4);
    }

    static void Menu()
    {
        Console.WriteLine("------------------------");
        Console.WriteLine("Cua hang ban giay NET101");
        Console.WriteLine("1. Them moi mot doi Giay");
        Console.WriteLine("2. Danh sach Giay");
        Console.WriteLine("3. Mua Giay");
        Console.WriteLine("4. Thoat");
        Console.WriteLine("------------------------");
    }

    static void ThemMoiGiay()
    {
        Console.Write("Nhap ma giay: ");
        string giayId = Console.ReadLine();
        Console.Write("Nhap ten giay: ");
        string tenGiay = Console.ReadLine();
        Console.Write("Nhap thuong hieu: ");
        string thuongHieu = Console.ReadLine();
        Console.Write("Nhap size: ");
        int size = int.Parse(Console.ReadLine());
        Console.Write("Nhap mau sac: ");
        string mauSac = Console.ReadLine();
        Console.Write("Nhap gia: ");
        double gia = double.Parse(Console.ReadLine());
        Console.Write("Nhap ton kho: ");
        int tonKho = int.Parse(Console.ReadLine());

        Giay giayMoi = new Giay(giayId, tenGiay, thuongHieu, size, mauSac, gia, tonKho);
        danhSachGiay.Add(giayMoi);
        

        Console.WriteLine("Them moi giay thanh cong!");
    }

    static void HienThiDanhSachGiay()
    {
        Console.WriteLine("Danh sach cac doi giay:");
        foreach (var giay in danhSachGiay)
        {
            Console.WriteLine($"ID: {giay.giayId}, Ten: {giay.tenGiay}, Thuong Hieu: {giay.thuongHieu}, Size: {giay.size}, Mau Sac: {giay.mauSac}, Gia: {giay.gia}, Ton Kho: {giay.tonKho}");
        }
    }
}
