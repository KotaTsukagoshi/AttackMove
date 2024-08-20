using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttackMove
{
    public class Character
    {
        public string Name { get; set; }
        public IAttack AttackType { get; set; }

        public Character(string name, IAttack attackType)
        {
            Name = name;
            AttackType = attackType;
        }

        public string PerformAttack()
        {
            return $"{Name}は{AttackType.Attack()}";
        }
    }
}
