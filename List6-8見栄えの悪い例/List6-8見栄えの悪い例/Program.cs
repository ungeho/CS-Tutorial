using System;

namespace List6_8見栄えの悪い例
{
    //プロパティを使わない例
    class Complex
    {
        //実装は外部から隠蔽(prvateにしておく)
        //基本的にクラスの外部に公開したいもの以外はprivateにしておく
        private double re;//実部
        private double im;//虚部
        //メソッドを通してオブジェクトの状態を取得/変更する
        //フィールドの値の取得/変更を行う為のメソッドはアクセサーと呼ばれる。
        //アクセサーのメソッド名はGetRe()やvoid SetRe(double)のようにGet/Setで始まるメソッド名で使う事が多い
        public double Re() { return this.re; } //実部を取り出す
        public void Re(double x) { this.re = x; }//実部を書き換え
        public double Im() { return this.im; } //虚部を取り出す
        public void Im(double y) { this.im = y; } //虚部を書き換え
        //絶対値を取り出す
        public double Abs() { return Math.Sqrt(re * re + im * im); }
    }
    class ConsealSample
    {
        static void Main()
        {
            // x = 5 + 1i
            Complex x = new Complex();
            x.Re(5); //x.re = 5
            x.Im(1); //x.im = 1
            // y = -2 + 3i
            Complex y = new Complex();
            y.Re(-2); //x.re = -2
            y.Im(3); //x.im = 3
            Complex z = new Complex();
            z.Re(x.Re() + y.Re()); // z.re = x.re + y.re
            z.Im(x.Im() + y.Im()); // z.im = x.im + y.im
            Console.WriteLine($"|{z.Re()} + {z.Im()}i| = {z.Abs()}");
            //|3 + 4i| = 5 と表示される
        }
    }
}
