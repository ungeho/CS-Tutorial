using System;

namespace List7_7_2仮想メソッドの利用例_多態性_
{
    //基底クラス（人間クラス）の定義
    class Person
    {
        protected string name; //名前
        protected int age;  //年齢
        //コンストラクター　インスタンス化の時の変数の初期化を必須にする。
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        //名前が変更される事は基本的にない為、ゲッターのみ設定。
        public string Name { get { return this.name; } }

        //年齢もゲッターのみを設定、基底クラスでは適当な値。
        public virtual int Age
        {
            get
            {
                //基底クラスでは特に意味のない値を返す。
                return 0;
            }
        }
    }
    //正直者のクラス。年齢を偽らない。
    //人間クラスを継承
    class Truepenny : Person
    {
        //コンストラクター
        //基底クラスのコンストラクターを呼び出す。
        public Truepenny(string name, int age)
            : base(name, age) { }

        public override int Age
        {
            get
            {
                //実年齢をそのまま返す。
                return this.age;
            }
        }
    }
    //嘘つきのクラス。
    //年齢でさばをよむ（歳を取るにつれ大幅に）
    class Liar : Person
    {
        //基底クラスのコンストラクターを呼び出す。
        public Liar(string name, int age) : base(name, age) { }
        public override int Age
        {
            get
            {
                //年齢を偽る
                if (this.age < 20) return this.age;
                if (this.age < 25) return this.age - 1;
                if (this.age < 30) return this.age - 2;
                if (this.age < 35) return this.age - 3;
                if (this.age < 40) return this.age - 4;
                return this.age - 5;
            }
        }
    }
    //いいかげんな人（Equivocator）のクラス
    //大体の年齢を答える
    class Equivocator : Person
    {
        public Equivocator(string name, int age) : base(name, age) { }

        public override int Age
        {
            get
            {
                //年齢を四捨五入した値を返す
                return ((this.age + 5) / 10) * 10;
            }
        }
    }
    //いくつになっても17歳のクラス
    class Seventeenist : Person
    {
        public Seventeenist(string name, int age) : base(name, age) { }

        public override int Age
        {
            get
            {
                //常に17を返す。
                return 17;
            }
        }
    }
}
