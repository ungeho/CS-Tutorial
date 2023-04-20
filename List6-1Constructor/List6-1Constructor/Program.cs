using System;

namespace List6_1Constructor
{
    class Test
    {
        //Testクラスのコンストラクター
        public Test()
        {
            Console.WriteLine("Testクラスのコンストラクターが呼ばれました");
        }
    }
    class ConstructorSample
    {
        static void Main()
        {
            Console.WriteLine("Mainの先頭");
            //ここでTestクラスのコンストラクターが呼ばれる
            Test t = new Test();
            Console.WriteLine("Mainの末尾");
        }
    }
}
