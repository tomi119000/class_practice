using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace class_practice
{
    // Class名(Warrior)の後ろに：Personと書くことでPersonクラスを継承
    // privateのものは継承できない。protectedのものは継承できる
    internal class Warrior : Person 
    {
        // コンストラクタを作成する
        public Warrior(string n, int h)
        {
            name = n; // 親クラスのprotected変数nameにアクセスできる
            hp = h;   // 親クラスのprotected変数hpにアクセスできる
            info = "強い剣士"; // 親クラスのprotected変数infoにアクセスできる
        }

        // ↑のWarriorコンストラクタから引数なしコンストラクタをつくる
        public Warrior() : this("タンジーロ", 500) { }

        // 継承したメソッドをオーバーライド（上書き）して違う機能に書き換える
        public override void AttackInfo(int x)
        {
            switch(x)
            {
                case 1:
                    Console.WriteLine("技：縦切り");
                    break;
                case 2: 
                    Console.WriteLine("技：横切り");
                    break;  
                case 3:
                    Console.WriteLine("技：連続切り");
                    break;
                default:
                    Console.WriteLine("技：みねうち");
                    break;
            }
        }

        // 引数なしのAttackInfoメソッドもオーバーライドしてみる
        public override void AttackInfo()
        {
            Console.WriteLine("技：みねうち");
        }

        // まったく新しい独自の命令（戻りありメソッド）
        // string型の何かデータが戻ってくるメソッド
        public string Special()
        {
            string message = "家族を絶対に守る！";
            return message; 
        }
    }   
}
