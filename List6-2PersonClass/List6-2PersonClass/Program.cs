using System;

namespace List6_2PersonClass
{
    class Person
    {
        public string Name; //名前
        public int Age; //年齢
        //引数なしのコンストラクター
        /*
        public Person()
        {
            //引数なしのとき、空文字と0
            this.Name = "";
            this.Age = 0;
        }
        */
        //引数付きのコンストラクター
        public Person(string name,int age)
        {
            //もろもろの初期化処理を書いておく
            this.Name = name;
            this.Age = age;
        }
        //名前のみを引数に取るコンストラクター
        //不足している年齢は-1として引数付きのコンストラクターを呼び出す
        public Person(string name):this(name,-1)
        {

        }
        //年齢のみを引数に取るコンストラクター
        //不足している名前は"名無しさん"として引数付きコンストラクターを呼ぶ
        public Person(int age):this("名無しさん",age)
        {

        }
        //引数なしのコンストラクター
        //名前を"名無しさん"年齢を-1として引数付きのコンストラクターを呼ぶ
        public Person() : this("名無しさん",-1)
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            Person p2 = new Person("ビスケット・クルーガー", 57);
            Console.WriteLine($"{nameof(p.Name)} = {p.Name}");
            Console.WriteLine($"{nameof(p.Age)} = {p.Age}");
            Console.WriteLine($"{nameof(p2.Name)} = {p2.Name}");
            Console.WriteLine($"{nameof(p2.Age)} = {p2.Age}");
        }
    }
}
