using System;

namespace List7_6同名メソッド存在下での呼び出し
{
    class Base
    {
        //基底クラスBaseのTest()メソッド
        public void Test()
        {
            Console.WriteLine("Base.Test()");
        }
    }
    //Baseクラスを継承
    class Derived:Base
    {
        //派生クラスDerivedのTest()メソッド
        public new void Test()
        {
            Console.WriteLine("Derived.Test()");
        }
    }
    class NonVirtualTest
    {
        static void Main()
        {
            //インスタンス化
            Base a = new Base();
            //変数aの静的な型はBaseなので
            //基底クラス（Base）のTest()メソッドが呼ばれる。
            a.Test();
            Base b = new Derived();
            //変数bの静的な型もBaseなので
            //基底クラスBaseのTest()メソッドが呼ばれる。
            b.Test();
            Derived c = new Derived();
            //変数cの静的な型はDerivedなので
            //派生クラスDerivedのTest()メソッドが呼ばれる。
            c.Test();

            //仮想メソッド
            //C#では、何も指定しない通常のメソッド呼び出しで基底クラスと派生クラスに同名のメソッドがある場合
            //静的な型によって呼び出されるメソッドが決定される。
        }
    }
}
