using System;

namespace List6_6クラスの実装を隠蔽したコード
{
    //クラス定義
    class Complex
    {
        //実装は外部から隠蔽(prvateにしておく)
        //基本的にクラスの外部に公開したいもの以外はprivateにしておく
        private double re;//実部
        private double im;//虚部
        //メソッドを通してオブジェクトの状態を取得/変更する
        public double Re() { return this.re; } //実部を取り出す
        public void Re(double x) { this.re = x; }//実部を書き換え
        public double Im() { return this.im; } //虚部を取り出す
        public void Im(double y) { this.im = y; } //虚部を書き換え
        //絶対値を取り出す
        public double Abs() { return Math.Sqrt(re * re + im * im); }
    }
    //クラス利用側
    class ConcealSample
    {
        static void Main()
        {
            Complex c = new Complex();
            c.Re(4);
            c.Im(3);
            Console.WriteLine($"|c| = {c.Abs()}");
        }
    }
}
