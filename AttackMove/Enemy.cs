using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AttackMove
{
    internal class Enemy
    {
        public string EnemyName { get; set; }
        public int HP {  get; set; }
        public Enemy( int hp,string enemyname)
        {
            HP = hp;
            EnemyName = enemyname;
            
        }
        public string EnemyAppearance()//敵の出現
        {
            return $"HP{HP}の{EnemyName}";
        }
    }
}
