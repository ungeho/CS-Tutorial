using System;

namespace List6_7実装方法の変更
{
    //クラス定義
    class Complex
    {
        //実装は外部から隠蔽
        private double abs;//絶対値
        private double arg;//偏角
        //実部を取り出す
        public double Re()
        {
            return this.abs * Math.Cos(this.arg);
        }
        //実部を書き換え
        public void Re(double x)
        {
            double im = this.abs * Math.Sin(this.arg);
            this.abs = Math.Sqrt(x * x + im * im);
            this.arg = Math.Atan2(im, x);
        }
        //虚部を取り出す
        public double Im()
        {
            return this.abs * Math.Sin(this.arg);
        }
        //虚部を書き換え
        public void Im(double y)
        {
            double re = this.abs * Math.Cos(this.arg);
            this.abs = Math.Sqrt(y * y + re * re);
            this.arg = Math.Atan2(y, re);
        }
        public double Abs() { return this.abs; } // 絶対値を取り出す
    }

    //クラス利用側
    class ConsealSample
    {
        static void Main()
        {
            Complex c = new Complex();
            c.Re(4);
            c.Im(3);
            //クラス利用側は一切変更不要
            Console.WriteLine($"|c| = {c.Abs()}");
        }
    }
}
