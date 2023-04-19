using System;

namespace List4_14_例外をthrowする関数を呼び出す関数_を呼び出す関数
{
    class Program
    {
        static void A()
        {
            try
            {
                B();
            }
            catch ( Exception e)
            {
                Console.WriteLine("Exception handled in A");
            }
            Console.WriteLine("Application exit");
        }
        static void B()
        {
            C();
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
