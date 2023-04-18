using System;

namespace List2_2ショートサーキット
{
    class Program
    {
        static bool Echo(string message)
        {
            Console.WriteLine(message);
            return true;
        } 
        static void Main(string[] args)
        {
            /*
            && や || はショートサーキット評価あり。
            a && b で aがfalseならbを評価しない。
            a || b で bがTrueならbを評価しない。
            無駄な評価を行わないのがショートサーキット評価
            */
            Console.WriteLine("ショートサーキット評価無し");
            var x = Echo("a") | Echo("b");
            Console.WriteLine("ショートサーキット評価有り");
            var y = Echo("a") || Echo("b");

            //null条件演算子
            //nullの時はnullを入れて、null出ない時は代入したい時
            //ある人の名前を取得する。
            //var name = person != null ? person.Name : null;
            //ある人のパートナーの名前を取得する。
            //var partner = person != null ? person.Partner : null;
            //var partnerName = partner != null ? partner.Name :null;
            //上記二つの３項演算子をnull条件演算子で表記すると
            //ある人の名前を取得する。
            //var name = person?.Name;
            //ある人のパートナーの名前を取得する。
            //var partner = person?.Partner?.Name;

            //nullの時にデフォルトの名前を使用する場合
            //var name = person?.Name ?? "No name";
            //var partner = person?.Partner?.Name ?? "No Name";

            //ある人の名前の、最初の文字を取得する
            //var firstLetter = person?.Name?[0];
        }
    }
}
