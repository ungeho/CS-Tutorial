using System;

namespace List3_6前_匿名型
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            匿名型は名前のない"一時的"なクラス
            原則ローカル(関数内)で完結するように使用する
            */
            //型:<>f__AnonymousType0`2
            var x = new { Title = "V", Level = 12 };
            //型:<>f__AnonymousType0`2
            var y = new { Title = "V2", Level = 11 };
            //型:<>f__AnonymousType1`2
            var z = new { Title = "X", Difficulty = "Another" };
            //以下はOK:型が同じな為配列に出来る。
            //var p = new[] { x, y };
            //以下はNG:型が異なる為配列に出来ない。
            //var q = new[] { x , z};

            //以下はNG:明示的なnullの代入はコンパイルエラー
            //var x = new { Name = null };
            //以下はOK:これはsがstring型であることがわかる為、nullであってもOK
            //string s = null;
            //var y = new { Name = s};
        }
    }
}
