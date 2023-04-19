using System;

namespace List4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int price, n;
            price = int.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());
            if (n < 0 || price < 0)
                Console.WriteLine("無効な価格、または無効な個数が入力されました");
            else if ((n * price) >= 1000)
                Console.WriteLine("送料無料です");
            else
                Console.WriteLine("送料が別途かかります");
        }
    }
}
