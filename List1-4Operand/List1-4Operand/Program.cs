using System;

namespace List1_4Operand
{
    class Program
    {
        static int Echo(int x)
        {
            //改行付きで表示する。
            Console.WriteLine(x);
            return x;
        }
        static void Main(string[] args)
        {
            //オペランドは左から評価される。
            var s = Echo(2) + Echo(3) * Echo(4);
        }
    }
}
