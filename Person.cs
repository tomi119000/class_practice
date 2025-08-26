using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_practice
{
    internal class Person
    {
        //変数
        protected string name; //キャラの名前
        protected int level; //レベル
        protected int hp; //体力
        protected string info = "ただの村人"; //キャラ属性の特徴

        //実体化した際に基本的な情報は入るように設計する(=初期化 =コンストラクタ）
        //下記は引数なしコンストラクタ
        public Person()
        {
            name = "イッパンジーン"; //初期値
            level = 1; //初期値
            hp = 100; //初期値
        }

        //引数ありコンストラクタ
        public Person(string n, int h)
        {
            name = n;
            level = 1;
            hp = h;
        }

        //命令（メソッド）
        //そのキャラの情報を表示するメソッド
        public void InfoDisplay()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("---------------------");
            Console.WriteLine("名前：" + name); //ctl + Dで行を↓に複製可能
            Console.WriteLine("レベル：" + level);
            Console.WriteLine("体力：" + hp);
            Console.WriteLine(info);
        }
        //１．メソッドを用意してprotectedの変数に干渉する
       　 //名前を変更するメソッド
        public void Nameset(string value)
        {
            name = value;
        }

      　  //HPを変更するメソッド
        public void HPSet(int value)
        {
            hp = value;
        }

        //メンバ変数に干渉するためのプロパティ(プロパティを用意して干渉する）
        //Nameという言い方ならnameに鑑賞できるように設計
        public string Name
        {
            get { return name; } //getは読み取り専用。本来不干渉のnameにアクセスできる
            set { name = value; } //setは代入専用
        }

        //技をひとつ公表するメソッド
        //オーバーロードして、引数ありと引数無しの2種類作っておく
        //引数ありのAttackInfoメソッドをvirtualメソッドにして、別のClassでオーバーライドできるようにする
        public virtual void AttackInfo(int x)
        {
            switch(x)
            {
                case 1:
                    Console.WriteLine("技：必殺の右ストレート");
                    break;
                default:
                    Console.WriteLine("技：渾身のタックル");
                    break;
            }
        }

        public virtual void AttackInfo()
        {
            Console.WriteLine("技：渾身のタックル");
        }
    }
}
