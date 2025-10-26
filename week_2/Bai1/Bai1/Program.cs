namespace Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.Write("Nhap do dai canh dau tien: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap do dai canh thu 2: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap do dai canh thu 3: ");
            c = Convert.ToDouble(Console.ReadLine());
            if (a == b && b == c)
                Console.WriteLine("Tam giac deu");
            else if (a == b || b == c || c == a)
                Console.WriteLine("Tam giac can");
            else if (a < b + c && b < a + c && c < a + b)
                Console.WriteLine("Tam giac thuong");
            else
                Console.WriteLine("Khong tao thanh tam giac");
        }
    }
}
