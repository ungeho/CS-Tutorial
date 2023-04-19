using System;

namespace List4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new[] { 1, 2, 3, 4, 5 };
            var sum = 0;
            var i = 0;
            while(i < a.Length)
            {
                sum += a[i];
                i++;
            }
        }
    }
}
