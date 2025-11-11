using System;

namespace btvn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QLCongNhan qLCongNhan = new QLCongNhan();
            int choice;
            Console.WriteLine("===== MENU QUAN LY CONG NHAN =====");
            Console.WriteLine("1. Them cong nhan");
            Console.WriteLine("2. Hien thi danh sach");
            Console.WriteLine("3. Sap xep theo ho ten, luong");
            Console.WriteLine("4. Tim cong nhan theo ma");
            Console.WriteLine("5. Thoat");
            do
            {
                Console.Write("Chon chuc nang: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1: 
                        qLCongNhan.themCongNhan(); 
                        break;
                    case 2: 
                        qLCongNhan.HienThiDanhSach(); 
                        break;
                    case 3:
                        qLCongNhan.SapXep(); 
                        break;
                    case 4:
                        qLCongNhan.timNhanVien(); 
                        break;
                    case 5:
                        return;
                    default: 
                        Console.WriteLine("Lua chon khong hop le!");
                        break;
                }

            } while (choice != 5);
        }
    }
}

