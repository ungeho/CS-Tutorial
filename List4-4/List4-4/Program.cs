using System;

namespace List4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //ユーザーの入力値を変数sに代入
            var s = Console.ReadLine();
            switch(s)
            {
                case "one":
                    Console.WriteLine(1);
                    break;
                case "two":
                    Console.WriteLine(2);
                    break;
                case "three":
                    Console.WriteLine(3);
                    break;
            }
        }
    }
}
