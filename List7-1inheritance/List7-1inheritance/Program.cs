using System;

namespace List7_1inheritance
{
    //人間クラス（親クラス）
    class Person
    {
        //privateにして実装を隠蔽
        private string name; //名前
        private int age; //年齢
        //コンストラクター、インスタンス化をするときのメンバ変数への代入を必須にする。
        public Person(string name,int age)
        {
            this.name = name;
            this.age = age;
        }
        //セッターとゲッター
        public string Name
        {
            set { this.name = value; }
            get { return this.name;  }
        }
        public int Age
        {
            set { this.age = value; }
            get { return this.age;  }
        }
    }
    //人間クラスを継承した学生クラス
    class Student : Person //Personクラスを継承する
    {
        //privateにして実装を隠蔽
        private int id; //学籍番号
        //コンストラクター、インスタンス化をするときのメンバ変数への代入を必須にする。
        public Student(string name, int age, int id) 
            : base(name, age) //基底クラスのコンストラクターを呼び出す（親クラス名ではなく、base）
        {
            this.id = id;
        }
        public int Id
        {
            set { this.id = value; }
            get { return this.id;  }
        }
    }

    //基底クラスBaseと派生クラスDerivedの例
    //親クラス（基底クラス）Base
    class Base
    {
        public Base()
        {
            Console.WriteLine("Baseクラスのコンストラクターが呼ばれました。");
        }
    }
    //子クラス（派生クラス）Derived
    class Derived : Base
    {
        public Derived()
        {
            Console.WriteLine("Derivedクラスのコンストラクターが呼ばれました。");
        }
    }


    //クラス利用側
    class InheritTest
    {
        //メイン関数
        static void Main()
        {
            //人間のインスタンス化
            Person p1 = new Person("天野舞耶",23);
            //p1.Name = "天野舞耶";
            //p1.Age = 23;
            //学生のインスタンス化
            Student s1 = new Student("周防達也",18, 50012);
            //Personクラスのメンバー変数をそのまま利用できる。
            //s1.Name = "周防達也";
            //s1.Age = 18;
            //s1.Id = 50012;
            //StudentクラスはPersonクラスとして扱う事が出来る。
            Person p2 = s1;
            //しかし、PersonクラスはStudentクラスとして扱うことは出来ない。
            //この1行はエラーになる
            //Student s2 = p1;



            //まずBaseクラスのコンストラクターが呼ばれ、
            //そのあとにDerivedクラスのコンストラクターが呼ばれる。
            //また、インスタンス化する時
            //左辺は静的な型（コンパイル時に型が確定する。）
            //右辺の実際に格納されているインスタンスの型は動的な型と呼ばれる。
            //左辺の静的な型の情報を得るにはtypeof演算子
            //typeof(クラス名) を利用し
            //右辺の動的な型の情報を得るには
            //変数名.GetType を利用する。
            Derived d = new Derived();
        }
    }
}
