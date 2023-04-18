using System;

namespace List3_1Array
{
    class ArraySample
    {
        static void Main(string[] args)
        {
            //配列の宣言
            //最後の数字の後の,は無くても問題ないが、ソースコードを自動生成する際に,があっても許容されるのは便利
            var x = new[] { 9, 15, 32 ,};
            x[1] = 4; //2番目の値を書き換える。
            foreach(int i in x)
            {
                Console.WriteLine(i);
            }

        }
    }
}
