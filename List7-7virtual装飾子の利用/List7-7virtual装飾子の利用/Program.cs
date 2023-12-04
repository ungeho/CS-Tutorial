using System;

namespace List7_7virtual装飾子の利用
{
    class Base
    {
        //基底クラスBaseのTest()メソッド
        //virtual装飾子をつける。
        public virtual void Test()
        {
            Console.WriteLine("Base.Test()");
        }
    }
    //Baseクラスを継承
    class Derived : Base
    {
        //派生クラスDerivedのTest()メソッド
        //override装飾子をつける。
        public override void Test()
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
            //変数aの動的な型はBaseなので
            //基底クラス（Base）のTest()メソッドが呼ばれる。
            a.Test();
            Base b = new Derived();
            //変数bの動的な型がDerivedなので
            //派生クラスDerivedのTest()メソッドが呼ばれる。
            b.Test();
            Derived c = new Derived();
            //変数cの動的な型はDerivedなので
            //派生クラスDerivedのTest()メソッドが呼ばれる。
            c.Test();

            //virtual装飾子をつけたメソッドのことを仮想メソッドと呼ぶ。
            //基底クラスのメソッドにvirtual装飾子をつけると
            //動的な型に基づいて呼び出されるメソッドが決まる。

            //また、基底クラスの仮想メソッド（virtual）を
            //派生クラスのオーバーライド（override:上に重なる）メソッドを明示的に付ける必要がある。
            //これは意図しないメソッドのオーバーライドやオーバーライドしたつもりになった事態を避ける為に必要。
        }
    }
}
