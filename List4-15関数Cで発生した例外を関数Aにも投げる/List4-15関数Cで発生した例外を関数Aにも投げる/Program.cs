using System;

namespace List4_15関数Cで発生した例外を関数Aにも投げる
{
    class Program
    {
        static void A()
        {
            try
            {
                B();
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception handled in A");
            }
            Console.WriteLine("Application exit");
        }
        static void B()
        {
            try
            {
                C();
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception handled in B");
                throw; // 受け取った例外を再度発生させる。
            }
        }
        static void C()
        {
            throw new Exception();
        }
        static void Main(string[] args)
        {
            A();
        }
    }
}
