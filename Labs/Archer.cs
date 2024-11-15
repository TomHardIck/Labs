using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs
{
    public class Archer : Attacker, Moveable
    {
        public float damage;
        public void attack(Unit unit)
        {
            unit.receiveDamage(damage);
        }
    }
}
