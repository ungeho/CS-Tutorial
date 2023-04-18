using System;

namespace List3_3varArray
{
    class ArraySample
    {
        static void Main(string[] args)
        {
            //{}内から型の推論が出来る為、型の宣言を省略
            var rect2 = new[,]
            {
                {1,2,3 },
                {4,5,6 }
            };
            //配列の配列(ジャグ配列)で型推論を使用
            var jug = new[]
            {
                //配列の配列なため、ギザギザな形も可能
                new[]{1,2,3},
                new[]{4,5,6,7},
            };
            Console.WriteLine(rect2[1, 2]);
            Console.WriteLine(jug[1][2]);
        }
    }
}
