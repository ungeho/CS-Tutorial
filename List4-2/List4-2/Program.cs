using System;

namespace List4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            if(b == 0) 
            {
                Console.WriteLine("0が入力されました");
            }
            else
            {
                c = a / b;
                Console.WriteLine(c);
            }
        }
    }
}
