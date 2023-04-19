using System;

namespace List4_8Maxfunc
{
    class ParamsTest
    {
        static void Main(string[] args)
        {
            //この中から最大値を探したい
            int a = 314, b = 159, c = 265, d = 358, e = 979;
            //いったん配列に格納し、
            int[] tmp = new int[] { a, b, c, d, e };
            //配列を引数としてMax関数を呼び出す
            int max = Max(tmp);
            Console.WriteLine($"{max}");
        }
        //max関数の定義
        static int Max(int[] a)
        {
            int max = a[0];
            for(int i = 1; i< a.Length; i++)
            {
                if (max < a[i])
                    max = a[i];
            }
            return max;
        }
    }
}
