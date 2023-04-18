using System;

namespace List2_1三項演算子
{
    class Program
    {
        static void Main()
        {
            //コンソールから入力を受け取りint型に変換して変数xに代入
            int x = int.Parse(Console.ReadLine());
            //比較 x > 5 が Trueなら10 Falseなら0
            int y = (x > 5) ? 10 : 0;
            Console.WriteLine(y);

            //nonNullStrに strがnullなら"default string" strがnullでないならstrを代入
            //string nonNullStr = str != null ? str : "default string";
            //同じ事をnull合体演算で簡単に表記可能
            //string nonNullStr = str ?? "default string"
        }
    }
}
