using  System.Collections.Generic;
namespace Bai1
{
    internal class Program
    {
        public static Boolean KiemTraHopLe(String s)
        {
            Stack<char> stack = new Stack<char>();
            bool check = true;
            foreach (char c in s)
            {
                if (c == '{' || c == '[' || c == '(')
                    stack.Push(c);
                else if(c == '}' || c == ']' || c == ')')
                {
                    if (stack.Count == 0)
                    {
                        check = false;
                        break;
                    }
                    char open = stack.Pop();
                    if (c == '}' && open != '{' || c == ']' && open != '[' || c == ')' && open != '(')
                    {
                        check = false;
                        break;
                    }
                }
            }
            return check;
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap chuoi: ");
            String s = Console.ReadLine();
            if (KiemTraHopLe(s))
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }   
    }
}
