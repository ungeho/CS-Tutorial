using System;

namespace List6_5複素数クラスの実装方法の変更
{
    class Complex
    {
        //絶対値を記憶しておく（外部からの読み出し/書き換え可能）
        public double Abs;
        //偏角を記憶しておく（外部からの読み出し/書き換え可能）
        public double Arg;
        //実部/虚部を書き換え
        public void Set(double x, double y)
        {
            this.Abs = Math.Sqrt(x * x + y * y);
            this.Arg = Math.Atan2(y, x);
        }
    }
    //クラス利用側
    class ConcealSample
    {
        static void Main()
        {
            Complex c = new Complex();
            c.Set(4, 3);
            //以下、クラスの利用側のコードも修正が必要
            //変更前: Console.WriteLine($"|c| ={c.Abs()}");
            Console.WriteLine($"|c| = {c.Abs}");
        }
    }
}
