using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttackMove
{
    internal class SwordAttack : IAttack
    {
        public string Attack()
        {
            return "剣で攻撃した！";
        }
    }
}
