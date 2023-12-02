using System;

namespace List7_5基底クラスのメンバーを隠蔽する
{
    class Base
    {
        public void Test()
        {
            //基底クラスBaseのTest()が呼ばれたら画面表示
            Console.WriteLine("Base.Test()");
        }
    }
    class Derived : Base
    {
        //基底クラスのTest()と同名のメソッド
        public void Test()
        {
            //派生クラスDerivedのTest()が呼ばれたら画面表示
            Console.WriteLine("Derived.Test()");
        }
    }

    class Test
    {
        static void Main()
        {
            Base b = new Base();
            b.Test(); //基底クラスBaseのTest()が呼ばれる。
            Derived d = new Derived();
            d.Test(); //派生クラスDerivedのTest()が呼ばれる。

            //BaseにキャストしてからTest()を呼ぶと
            //BaseのTest()が呼ばれる。
            Base b2 = d;
            b2.Test();
            //一時的な変数を使わずに、以下のように基底クラスのTestを呼び出す事も出来る
            //派生クラスのインスタンスが入った変数dを基底クラスbaseにキャストし、Testメソッドを呼び出している。
            ((Base)d).Test();

            //基底クラスの隠蔽は、意図したものを呼ぶことが出来ない厄介なバグになりがちな為
            //意図していない場合は避けた方が良い
        }
    }
}
