using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace btvn
{
    public enum ChucVu
    {
        TruongNhom,
        PhoNhom,
        CongNhanBac3,
        CongNhanBac2,
        CongNhanBac1,
        Khac
    }
    internal class CongNhan : Person
    {
        private String maCN;
        private ChucVu chucVu;
        public CongNhan() {}

        public CongNhan(string name, int age, string address, String maCN, ChucVu chucVu) : base(name, age, address)
        {
            this.maCN = maCN;
            this.chucVu = chucVu;
        }
        public String MaCN { get =>  maCN; set => maCN = value;}
        public ChucVu ChucVu { get => chucVu; set => chucVu = value;}
        public double TinhLuong()
        {
            double heSoLuong;
            switch(chucVu)
            {
                case ChucVu.TruongNhom:
                    heSoLuong = 3.0;
                    break;
                case ChucVu.PhoNhom:
                    heSoLuong = 2.5;
                    break;
                case ChucVu.CongNhanBac3:
                    heSoLuong = 2.0;
                    break;
                case ChucVu.CongNhanBac2:
                    heSoLuong = 1.5;
                    break;
                case ChucVu.CongNhanBac1:
                    heSoLuong = 1.2;
                    break;
                default:
                    heSoLuong = 1.0;
                    break;
            }
            return heSoLuong * 8000000;
        }
        public override string ToString() 
        {
            return base.ToString() + $", Id: {maCN}, Chuc vụ: {chucVu}, Luong: {TinhLuong()} VND";
        }
    }
}
