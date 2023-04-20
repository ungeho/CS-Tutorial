using System;

namespace List6_10プロパティを利用した例2
{
    //クラス定義
    class Complex
    {
        //実装は外部から隠蔽
        private double abs;//絶対値を記憶しておく
        private double arg;//偏角を記憶しておく
        //実部の取得/変更用のプロパティ
        public double Re
        {
            set
            {
                double im = this.abs * Math.Sin(this.arg);
                //引数の値がvalueに入っている
                this.abs = Math.Sqrt(value * value + im * im);
                this.arg = Math.Atan2(im, value);

            }
            get
            {
                return this.abs * Math.Cos(this.arg);
            }
        }
        //虚部の取得/変更用のプロパティ
        public double Im
        {
            set
            {
                double re = this.abs * Math.Cos(this.arg);
                this.abs = Math.Sqrt(value * value + re * re);
                this.arg = Math.Atan2(value, re);
            }
            get
            {
                return this.abs * Math.Sin(this.arg);
            }
        }
        //絶対値取得用のプロパティ
        public double Abs
        {
            get
            {
                return this.abs;
            }
        }
    }
    //クラス利用例
    class PropertySample
    {
        static void Main()
        {
            Complex c = new Complex();
            //クラス利用側は一切変更せず
            c.Re = 4;
            c.Im = 3;
            Console.WriteLine($"|{c.Re} + {c.Im}i| = {c.Abs}");
        }
    }
}
