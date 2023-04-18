using System;

namespace List2_4Random
{
    class Random
    {
        uint seed;
        public Random(uint seed)
        {
            this.seed = seed;
        }
        public long Next()
        {
            //ここでわざとオーバーフローを無視する(unchecked)
            seed = unchecked(seed * 1664525 + 1013904223);
            return seed;
        }
        static void Main(string[] args)
        {
        }
    }
}
