using System;

namespace List4_7
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new[] { 1, 2, 3, 4, 5 };
            var sum = 0;
            //iが配列の長さ(a.Length)になるまで
            //1増やしながら繰り返す(=全ての要素を取り出す)
            for(var i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
        }
    }
}
