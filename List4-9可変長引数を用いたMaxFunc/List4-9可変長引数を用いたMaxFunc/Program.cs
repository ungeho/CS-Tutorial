using System;

namespace List4_9可変長引数を用いたMaxFunc
{
    class ParamsTest
    {
        static void Main(string[] args)
        {
            //この中から最大値を探したい
            int a = 314, b = 159, c = 265, d = 358, e = 979;
            //自動的に配列を作って値を格納してくれるので、変数を直接使える
            int max = Max(a, b, c, d, e);
            Console.WriteLine($"{max}");
        }
        //max関数の定義
        //paramsキーワードを付与する事で、可変長引数になる
        static int Max(params int[] a)
        {
            int max = a[0];
            for(int i = 1; i < a.Length; i++)
            {
                if (max < a[i])
                    max = a[i];
            }
            return max;
        }
    }
}
