using System;

namespace List3_9タプルのメンバーへのアクセスと書き換え
{
    class Program
    {
        static void Main(string[] args)
        {
            //タプルの宣言
            (int level, string title) p;
            p.level = 12; //レベルの書き換え
            p.title = "AA"; //タイトルの書き換え
            Console.WriteLine(p.level); //Levelの読み取り
            (int, string) q;//メンバー名を省略したタプルの宣言
            //メンバー名を省略した場合、item1,item2のような名前でアクセスが可能
            q.Item1 = 5;
            q.Item2 = null;
            Console.WriteLine(q.Item1);
            //タプルは固定長の配列を便利に扱う程度に

            //タプルの分解
            var t = (1, 2, "foo");
            //タプルtを分解して変数x,y,zへ代入
            (int x, int y, string z) = t;
            Console.WriteLine($"{x}:{y}:{z}");
            //既存の変数に代入する場合
            //型推論で代入
            //var (x, y, z) = t; 
            //分解して代入、型が違う場合暗黙的な型変換が発生
            //(p, q, r) = t;
            //値の破棄も可能"_"の部分は破棄される
            //var (w, _, _, z) = (10, 20, 30, 40);
            //_ = 10;

            //タプル間の変換
            //タプルリテラルではx,yというメンバーを持っているが、t.pとt.qという名前で利用可能に
            //(int p, int q) t = (x: 1, y: 2);

            //分解代入と変換の組み合わせでswapを簡単に行える
            int a = 10, b = 20;
            (a, b) = (b, a);
            Console.WriteLine($"{a} {b}");

        }


    }
}
