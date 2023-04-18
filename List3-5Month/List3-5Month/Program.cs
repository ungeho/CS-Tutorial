using System;

namespace List3_5Month
{
    //byte型で値が1から始まる列挙型Monthを定義
    enum Month : byte
    {
        //Feburary以降は、自動的に2,3,...,12が割り当てられる
        January = 1, February, March, April,
        May, June, July, August,
        September, October, November, December
    }
    class EnumSample
    {
        static void Main()
        {
            for (int i = 1; i < 12; i++)
                //列挙型Monthのメンバーを文字列化して利用
                //右詰め2桁
                Console.WriteLine($"{i,2}月{(Month)i}");
        }
    }
}
