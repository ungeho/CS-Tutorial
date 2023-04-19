using System;

namespace List5_1ComplexClass
{
    class Complex
    {
        //実部と虚部を記憶しておく
        //実部（外部からの読み出し/書き換えが可能）
        public double Re;
        //虚部（外部からの読み出し/書き換えが可能）
        public double Im;
        //絶対値を取り出す
        public double Abs()
        {
            //Math.Sqrtは平方根を求めるメソッド
            return Math.Sqrt(Re * Re + Im * Im);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //インスタンスを格納する為の変数を宣言
            //空っぽの状態を表すためにnullを代入
            Complex z = null;
            //newを使ってインスタンスを生成
            z = new Complex();
            //実部の値を変更
            z.Re = 3;
            //虚部の値を変更
            z.Im = 4;
            //zの絶対値を取得
            double abs = z.Abs();
            //abs=5と表示される
            Console.WriteLine($"abs = {abs}");
        }
    }
}
