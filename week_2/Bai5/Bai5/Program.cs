namespace Bai5
{
    internal class Program
    {
        public static double TinhTB(double[] arr)
        {
            double TB = 0;
            foreach(double x in arr) 
                TB += x;
            return TB / arr.Length;
        }
        public static double Max(double[] arr)
        {
            double max = arr[0];
            foreach(double x in arr)
            {
                if(x > max)
                    max = x;
            }
            return max;
        }
        public static double Min(double[] arr)
        {
            double min = arr[0];
            foreach (double x in arr)
            {
                if (x < min)
                    min = x;
            }
            return min;
        }
        public static double TiLe(double[] arr)
        {
            int count = 0;
            foreach(int x in arr)
            {
                if(x >= 5)
                    count++;
            }
            return ((double)count / arr.Length) * 100;
        }
        public static void PhanLoai(double[] arr)
        {
            int gioi = 0, kha = 0, tb = 0, yeu = 0;
            foreach(int x in arr)
            {
                if (x >= 8)
                    gioi++;
                else if (6.5 <= x && x <= 7.9)
                    kha++;
                else if (5.0 <= x && x <= 6.4)
                    tb++;
                else
                    yeu++;
            }
            Console.WriteLine("Phan loai: ");
            Console.WriteLine("Gioi: " + gioi);
            Console.WriteLine("Kha: " + kha);
            Console.WriteLine("TB: " + tb);
            Console.WriteLine("Yeu: " + yeu);
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap so hoc sinh cua lop: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] diem = new double[n];
            for(int i = 0; i < n; i++) 
            {
                Console.Write("Diem cua hoc sinh " + (i + 1) + ": ");
                diem[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Diem trung binh: " + TinhTB(diem));
            Console.WriteLine("Diem cao nhat: " + Max(diem));
            Console.WriteLine("Diem thap nhat: " + Min(diem));
            Console.WriteLine("Ti le dat: " + TiLe(diem) + "%");
            PhanLoai(diem);
        }
    }
}
