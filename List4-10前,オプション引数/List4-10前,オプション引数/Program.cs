using System;

namespace List4_10前_オプション引数
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sum(0,0,0)と同じ
            int s1 = Sum();
            //Sum(1,0,0)と同じ
            int s2 = Sum(1);
            //Sum(1,2,0)と同じ
            int s3 = Sum(1,2);

        }
        //引数の値を指定していない時の規定の値を設定出来る。
        //省略可能な引数は必須引数の後でなければいけない為
        //Sum(int x = 0,int y = 0,int z) はNG
        //Sum(int x,int y,int z = 0) はOK
        //ただし,オプション引数の後ろにparamsはOK
        //Sum(int x,int y,int z = 0,params int[] rest) はOK

        //同じ形で呼び出せる場合の関数のオーバーロードの優先度は
        // オプションなし > オプションあり > 可変長引数　の優先順で呼び出される
        static int Sum(int x = 0,int y = 0,int z = 0)
        {
            return x + y + z;
        }
    }
}
