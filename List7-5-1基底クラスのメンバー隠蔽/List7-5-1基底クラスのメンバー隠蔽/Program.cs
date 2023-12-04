using System;

namespace List7_5_1基底クラスのメンバー隠蔽
{
    class Base
    {
        public void Test()
        {
            Console.WriteLine("Base.Test()");
        }
    }

    class Derived : Base
    {
        //基底クラスBaseのTest()と同じ名前のメソッド
        //基底クラスのメンバーを隠蔽するにはnewをつける必要がある。
        public new void Test()
        {
            Console.WriteLine("Derived.Test()");
        }
        public void Test2()
        {
            //派生クラスDerivedのTest()が呼ばれる。
            this.Test();
            //基底クラスBaseのTest()が呼ばれる。
            base.Test();
        }
    }

    //sealed(封印された)装飾子をつけてクラスを定義すると、継承を禁止する事が出来る。
    sealed class SealedClass { }

    //SealedClassは継承不可なのでコンパイルエラー
    //class aaa : SealedClass {}

    //継承する事で何かが実現できるようなクラスが明確にない限り、派生クラスを作らせるべきではない
    //派生されても問題なく動作するようにクラスを設計するのは大変
    //予めsealedをつけてクラスを定義し、後から継承が必要になった時にsealedを外せば問題なく動作する。

    class Program
    {
        static void Main()
        {
            Base b = new Base();
            b.Test();
            Derived d = new Derived();
            d.Test();

            Base b2 = d;
            b2.Test();
        }
    }
}
