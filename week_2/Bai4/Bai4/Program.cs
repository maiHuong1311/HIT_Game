namespace Bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap chuoi ban dau: ");
            String banDau = Console.ReadLine();
            Console.Write("Nhap chuoi can tim: ");
            String canTim = Console.ReadLine();
            Console.Write("Nhap chuoi can chen: ");
            String chen = Console.ReadLine();
            int a = banDau.IndexOf(canTim);
            if(a == -1)
                Console.WriteLine("Khong the ghep tu - doan khong ton tai");
            else
            {
                String sau = banDau.Insert(a, chen + " ");
                Console.Write("Chuoi sau khi chen: " + sau);
            }
        }
    }
}
