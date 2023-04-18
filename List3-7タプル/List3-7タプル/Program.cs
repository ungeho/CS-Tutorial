using System;

namespace List3_7タプル
{
    class Program
    {
        static void Main(string[] args)
        {
            //整数と文字列をメンバーとして持つタプル型の変数p
            (int x, string y) p;
            //メンバー名を省略すると以下
            (int, string) q;
            //匿名型は読み取り専用だが、タプルは読み書き可能
        }
        //関数で使うと何処でも同じ処理を行える戻り値として使用
        public (int max,int min)GetFeatures(int[] values)
        {

        }
    }
}
