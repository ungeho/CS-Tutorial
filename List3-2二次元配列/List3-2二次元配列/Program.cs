using System;

namespace List3_2二次元配列
{
    class ArraySample
    {
        static void Main()
        {
            //2次元配列の初期化
            int[,] rect1 =
            {
                {1,2,3 },
                {3,4,6 },
            };
            //2行目3列目の数値を表示
            Console.WriteLine(rect1[1, 2]);
        }
    }
}
