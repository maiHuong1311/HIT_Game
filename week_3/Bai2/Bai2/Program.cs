namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap chuoi muon dao nguoc: ");
            String s = Console.ReadLine();
            String s2 = "";
            for(int i = s.Length - 1; i >= 0; i--)
            {
                s2 += s[i];
            }
            Console.WriteLine("Chuoi sau khi dao nguoc: " + s2);
        }
    }
}
