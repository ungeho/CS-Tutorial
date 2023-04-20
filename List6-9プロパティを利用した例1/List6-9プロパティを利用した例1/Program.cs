using System;

namespace List6_9プロパティを利用した例1
{
    class Complex
    {
        //実装は外部から隠蔽
        private double re;
        private double im;
        //実部の取得/変更用のプロパティ
        public double Re
        {
            //このコードは意味的には以下のコードと同じ
            //public void SetRe(double value)
            //{this.re = value}
            //public double GetRe(){ return this.re; }
            set { this.re = value; }
            get { return this.re; }
        }
        //虚部の取得/変更用のプロパティ
        public double Im
        {
            set { this.im = value; }
            get { return this.im; }
        }
        //絶対値の取得用のプロパティ
        public double Abs
        {
            //読み取り専用プロパティ。setブロックを書かない
            get { return Math.Sqrt(re * re + im * im); }
        }
    }
    //クラス利用側
    class PropertySample
    {
        static void Main()
        {
            Complex c = new Complex();
            //フィールドと同じ感覚で使える
            c.Re = 4; //Reプロパティのsetアクセサーが呼び出される
            c.Im = 3; //Imプロパティのsetアクセサーが呼び出される
            //Reプロパティのgetアクセサーが呼び出される
            Console.Write($"|{c.Re} + ");
            //Imプロパティのgetアクセサーが呼び出される
            Console.Write($"{c.Im}| = ");
            //Absプロパティのgetアクセサーが呼び出される
            Console.WriteLine($"{c.Abs}");
        }
    }
}
