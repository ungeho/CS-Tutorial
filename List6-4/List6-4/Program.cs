using System;

namespace List6_4
{
    //クラスの実装を隠蔽していないコード
    class Complex
    {
        //実部をきおくしておく（外部からの読み出し/書き換え可能）
        public double Re;
        //虚部をきおくしておく（外部からの読み出し/書き換え可能）
        public double Im;
        //絶対値を取り出す
        public double Abs()
        {
            //Math.Sqrtは平方根を求める関数
            return Math.Sqrt(Re * Re + Im * Im);
        }

    }
    //クラス利用側
    class ConcealSample
    {
        static void Main()
        {
            Complex c = new Complex();
            c.Re = 4; //フィールドに直接アクセス
            c.Im = 3; //フィールドに直接アクセス
            Console.Write("|c| = {0}\n", c.Abs());
        }
    }
}
