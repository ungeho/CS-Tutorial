using System;

namespace List7_7_1sealed装飾子でオーバーライドを禁止
{
    class Base
    {
        //仮想メソッド
        public virtual void Test() { }
    }

    class Derived1 : Base
    {
        //overrideメソッドで、インスタンス化の時に静的な型がBase、動的な型がDerived1なら
        //動的な型（Derived1）のTestメソッドを上塗りする。
        //sealed装飾子は、クラスにつけた場合に継承を禁止に出来る。
        //メソッドにつけた場合、Derived1クラスのTest()メソッドをオーバーライド禁止にする。
        public sealed override void Test() { }
    }
    class Derived2 : Derived1
    {
        //Derived1クラスのTest()メソッドのオーバーライドは禁止されている為
        //以下の1行はコンパイルエラーになる。
        // public override void Test() { }
    }
}
