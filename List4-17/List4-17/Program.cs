using System;

namespace List4_17
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 3;
            int[] array = new int[num];
            for (int i = 0; i < num; i++)
                array[i] = int.Parse(Console.ReadLine());
            int sum = 0;
            int sq_sum = 0;
            for(int i =0; i < num; i++)
            {
                int n = array[i];
                sum += n;
                sq_sum += n * n;
            }
            double mean = sum / num;
            double var = sq_sum / num - mean * mean;
            Console.WriteLine($"平均:{mean}\n分散:{var}");
        }
    }
}
