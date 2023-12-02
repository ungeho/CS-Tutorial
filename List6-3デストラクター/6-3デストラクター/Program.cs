using System;

namespace List6_3デストラクター
{
    class Test
    {
        public Test()
        {
            Console.WriteLine("Testクラスのコンストラクターが呼ばれました");
        }
        ~Test()
        {
            Console.WriteLine("Testクラスのデストラクターが呼ばれました");
        }
    }

   class DestructorSample
    {
        static void Main()
        {
            Console.WriteLine("1");
            //ここでTestクラスのコンストラクターが呼ばれる
            Test t = new Test();
            Console.WriteLine("2");
            t = null;
            //生成したインスタンスはもう利用されなくなるが、デストラクターはまだ呼ばれない
            Console.Write("3\n");
        }
    }

}
