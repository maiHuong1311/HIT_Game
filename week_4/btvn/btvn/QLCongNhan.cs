using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace btvn
{
    internal class QLCongNhan
    {
        public List<CongNhan> congNhan = new List<CongNhan>();
        public void themCongNhan()
        {
            Console.Write("Nhap ma cong nhan: ");
            string maCN = Console.ReadLine();
            foreach(CongNhan x in congNhan)
            {
                if(x.MaCN == maCN)
                {
                    Console.WriteLine("Da ton tai cong nhan");
                    return;
                }
            }

            Console.Write("Nhap ho ten: ");
            string hoTen = Console.ReadLine();
            int tuoi;
            do
            {
                Console.Write("Nhap tuoi: ");
                tuoi = Convert.ToInt32(Console.ReadLine());
            } while (tuoi < 0);

            Console.Write("Nhap dia chi: ");
            string diaChi = Console.ReadLine();

            Console.WriteLine("Chuc vu");
            Console.WriteLine("0. Truong nhom");
            Console.WriteLine("1. Pho nhom");
            Console.WriteLine("2. Cong nhan bac 3");
            Console.WriteLine("3. Cong nhan bac 2");
            Console.WriteLine("4. Cong nhan bac 1");
            Console.WriteLine("5. Khac");
            Console.WriteLine("Chon chuc vu:");
            int cv = Convert.ToInt32(Console.ReadLine());
            ChucVu chucVu = (ChucVu)cv;
            CongNhan cn = new CongNhan(hoTen, tuoi, diaChi, maCN, chucVu);
            congNhan.Add(cn);
        }

        public void HienThiDanhSach()
        {
            if (congNhan.Count == 0)
            {
                Console.WriteLine("Danh sach trong!");
                return;
            }
            else
            {
                Console.WriteLine("Danh sach cong nhan");
                foreach(CongNhan x in congNhan)
                    Console.WriteLine(x.ToString());
            }
        }

        public void SapXep()
        {
            for (int i = 0; i < congNhan.Count - 1; i++)
            {
                for (int j = i + 1; j < congNhan.Count; j++)
                {
                    CongNhan cn1 = congNhan[i];
                    CongNhan cn2 = congNhan[j];

                    int soSanhTen = cn1.Name.CompareTo(cn2.Name);

                    if (soSanhTen > 0)
                    {
                        congNhan[i] = cn2;
                        congNhan[j] = cn1;
                    }
                    else if (soSanhTen == 0 && cn1.TinhLuong() > cn2.TinhLuong())
                    {
                        congNhan[i] = cn2;
                        congNhan[j] = cn1;
                    }
                }
            }
            Console.WriteLine("Danh sach sau khi sap xep:");
            HienThiDanhSach();
        }
        public void timNhanVien()
        {
            Console.Write("Nhap ma nhan vien can tim: ");
            string ma = Console.ReadLine();
            bool found = false;
            foreach(CongNhan x in congNhan) 
            {
                if(ma == x.MaCN)
                {
                    Console.WriteLine("Thong tin nhan vien can tim: ");
                    Console.WriteLine(x.ToString());
                    found = true;
                    break;
                }
            }
            if(!found)
                Console.WriteLine("Khong tim thay nhan vien");
        }
    }
}
