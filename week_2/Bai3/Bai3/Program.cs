namespace Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap mot so nguyen duong: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i = 1;  i <= n; i++)
            {
                for(int j = i; j < n; j++)
                    Console.Write(" ");
                for(int j = 1; j <= i; j++)
                    Console.Write(j);
                for(int j = i - 1; j>=1; j--)
                    Console.Write(j);
                Console.WriteLine();
            }
        }
    }
}
