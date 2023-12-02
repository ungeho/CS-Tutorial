using System;

namespace List7_4as演算子の使用例
{
    class Base {}
    class Derived1 : Base {}
    class Derived2 : Base {}

    class DowncastTest
    {
        static void Main()
        {
            Base b;
            Derived1 d;
            b = new Derived1();
            //Derived1の変数をDerived1としてDerived1の変数に代入
            d = b as Derived1;
            if(d != null)
            {
                //型変換可能な為、こちらが呼び出される。
                Console.WriteLine("b = new Derived1();");
            } else
            {
                Console.WriteLine("変数bはDerived1に型変換できませんでした。");
            }
            b = new Derived2();
            //Derived2の変数をDerived1としてDerived1の変数に代入
            //型変換出来ないので結果はnull
            d = b as Derived1;
            if (d != null)
            {
                Console.WriteLine("b = new Derived2();");
            }
            else
            {
                Console.WriteLine("変数bはDerived1に型変換できませんでした。");
            }


            //仕様上、失敗の可能性があり、かつ失敗しても代替処理が容易出来る場合にはas演算子を使う。
            //失敗しないはず、あるいは失敗したならプログラムが続行不能である場合にはキャストを使う。
        }
    }
}
