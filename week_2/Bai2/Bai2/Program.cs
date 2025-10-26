namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- MENU ---");
            Console.WriteLine("1. Hinh tron");
            Console.WriteLine("2. Hinh chu nhat");
            Console.WriteLine("3. Hinh tam giac");
            Console.Write("Nhap lua chon: ");
            int choose = Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    Console.Write("Nhap ban kinh cua hinh tron: ");
                    double r = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Dien tich hinh tron la: " + (3.14 * r * r));
                    break;
                case 2:
                    Console.Write("Nhap chieu dai cua hinh chu nhat: ");
                    double leng = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Nhap chieu rong cua hinh chu nhat: ");
                    double wide = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Dien tich hinh chu nhat la: " + (leng * wide));
                    break;
                case 3:
                    Console.Write("Nhap day cua hinh tam giac");
                    double day = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Nhap chieu cao hinh tam giac");
                    double cao = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Dien tich hinh tam giac: " + (0.5 * day * cao));
                    break;
            }
        }
    }
}
