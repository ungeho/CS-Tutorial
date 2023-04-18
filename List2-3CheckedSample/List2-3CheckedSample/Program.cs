using System;

namespace List2_3CheckedSample
{
    class CheckedSample
    {
        static void Main()
        {
            try
            {
                //オーバーフローのチェック
                checked
                {
                    //符号付き8bit
                    sbyte a = 64;
                    sbyte b = 65;

                    //オーバーフローにより例外が発生
                    sbyte c = (sbyte)(a + b);
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("オーバーフロー例外。下記にエラーメッセージを表示");
                Console.Write(ex.Message);
            }
        }
    }
}
