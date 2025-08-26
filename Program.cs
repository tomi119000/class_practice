using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("ムラビート", 150); //Personクラスのインスタンスを生成
            //p1.Name = "コタロー"; //プロパティを使って名前を変更
            p1.InfoDisplay(); //p1にメソッドを使わせてみる
            p1.AttackInfo(); //引数なしのAttackInfoを呼び出し

            Person p2 = new Person();
            p2.Nameset("マチビート");
            p2.HPSet(180);
            p2.InfoDisplay();
            p2.AttackInfo(1); //引数ありのAttackInfoを呼び出し

            Person p3 = new Person();
            p3.InfoDisplay();
            p3.AttackInfo(99); //引数ありのAttackInfoを呼び出し

        }
    }
}


