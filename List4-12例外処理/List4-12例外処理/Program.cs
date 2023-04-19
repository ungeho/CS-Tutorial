using System;

namespace List4_12例外処理
{
    class ExceptionSample
    {
        //文字->整数に変換する関数CharToInt
        static int CharToInt(char c)
        {
            if (c < '0' || '9' < c)
                throw new FormatException(); //例外を投げる
            return c - '0';
        }
        //文字列->整数に変換する関数StringToInt
        static int StringToInt(string str)
        {
            int val = 0;
            foreach(char c in str)
            {
                int i = CharToInt(c);
                val = val * 10 + i;
            }
            return val;
        }
        static int IntDiv(string lhs,string rhs)
        {
            int l = StringToInt(lhs);
            int r = StringToInt(rhs);
            return l / r;
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine($"{StringToInt("12345")}");
                //数字以外の文字が含まれている。
                //Console.WriteLine($"{StringToInt("12a45")}");
                Console.WriteLine(IntDiv("12345","10"));
                //FormatException 例外が投げられる。
                //Console.WriteLine(IntDiv("12a45", "10"));
                //ここで0除算をしようとしたため、DivideByZeroExeption例外が投げられる
                Console.WriteLine(IntDiv("12345", "0"));
            }
            //catch (FormatException)
            //FormatException or DivideByZeroExceptionが投げられた時の処理
            catch(Exception e) when (e is FormatException || e is DivideByZeroException)
            {
                Console.WriteLine("想定外の文字列が入力されました");
            }
        }
    }
}
