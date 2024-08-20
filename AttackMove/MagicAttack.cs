using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttackMove
{
    internal class MagicAttack : IAttack
    {
        public string Attack()
        {
            return "魔法を使った！";
        }
    }
}
