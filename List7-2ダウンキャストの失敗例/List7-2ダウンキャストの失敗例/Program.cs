using System;

namespace List7_2ダウンキャストの失敗例
{
    class Base {}
    class Derived1 : Base {}
    class Derived2 : Base {}

    class DowncastTest
    {
        static void Main()
        {
            //暗黙的に変換可能（同一クラス）
            Derived1 d1 = new Derived1();
            //暗黙的に変換可能（同一クラス）
            Derived2 d2 = new Derived2();

            Base b;
            Derived1 d;
            //同一クラス（Derived1の変数にDerived1のインスタンスを格納）なので問題なし
            d = d1;
            //アップキャスト（親クラスの変数に子クラスのインスタンスを格納）は問題なし（包含される為）
            //その為、暗黙的に変換可能
            b = d1;

            //ダウンキャスト（子クラスの変数に親クラスのインスタンスを格納）は明示的なキャストが必要
            d = (Derived1)b;


            //以下は問題あり、コンパイルは出来るが、実行時エラーを起こす。
            //Derived1の変数にDerived2のインスタンスを格納しているので、問題がある。
            //b = d2;
            //d = (Derived1)b;


            //ダウンキャストを行うには動的な型情報を取得する必要がある。
            //その為、動的な型情報を取得する為の構文として
            //is演算子
            //as演算子
            //がある。
        }
    }
}
