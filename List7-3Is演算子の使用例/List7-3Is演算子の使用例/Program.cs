using System;

namespace List7_3Is演算子の使用例
{
    class Base {}
    class Derived1 : Base {}
    class Derived2 : Base {}
    class DowncastTest
    {
        static void Main()
        {
            Base b;
            b = new Derived1();
            //Derived1の変数が明示的にキャスト可能かどうか
            // 変数名 is 型名 左辺の変数が右辺の型にキャスト可能ならTrue
            if (b is Derived1)
            {
                Console.WriteLine("b = new Derived1();");
                b = new Derived1();
            } else
            {
                Console.WriteLine("変数名bはDerived1()の型にキャストできません。");
            }
            //Derived2の変数が明示的にキャスト可能かどうか
            if (b is Derived2)
            {
                Console.WriteLine("b = new Derived2();");
            }
            else
            {
                Console.WriteLine("変数名bはDerived2()の型にキャストできません。");
            }
        }
    }
}
