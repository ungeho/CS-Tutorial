using System;

namespace List4_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            do //必ず一度は実行される
            {
                Console.Write("正の数を入力してください:");
                n = int.Parse(Console.ReadLine());
            }
            while (n < 1); //nが負数なら繰り返す
            Console.WriteLine($"あなたの入力した数値は{n}です");
        }
    }
}
