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
            Console.WriteLine(p1.Name); //プロパティを使って名前を取得
            p1.InfoDisplay(); //p1にメソッドを使わせてみる
        }
    }
}


