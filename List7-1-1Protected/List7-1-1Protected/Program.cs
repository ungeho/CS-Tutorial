using System;

namespace List7_1_1Protected
{
    class Base
    {
        //外部からのアクセスを認める。
        public int PublicValue;
        //protected...クラスとそのクラスを継承する派生クラス内からのみアクセスを認める。
        protected int ProtectedValue;
        //クラス内からのみ、アクセスを認める。
        private int privateValue;
        void BaseTest()
        {
            //publicなのでOK
            PublicValue = 0;
            //クラス内なのでOK
            ProtectedValue = 0;
            //クラス内なのでOK
            privateValue = 0;
        }
    }
    class Deriived : Base
    {
        void DerivedTest()
        {
            //publicなのでOK!
            PublicValue = 0;
            //protectedは派生クラスからもアクセス可能！
            ProtectedValue = 0;
            //privateは派生クラスからアクセス出来ない（同一クラス内のみ）
            //privateValue = 0; //コンパイルエラー
        }
    }

    class Test
    {
        static void Main()
        {
            Base b = new Base();
            b.PublicValue = 0; //publicなのでOK!
            //b.ProtectedValue = 0; //コンパイルエラー（protectedは外部からアクセス不能、同一クラスと派生クラス内のみ）
            //b.privateValue = 0; //コンパイルエラー（privateは外部からアクセス不能、同一クラス内からのみ）
        }
    }
}
