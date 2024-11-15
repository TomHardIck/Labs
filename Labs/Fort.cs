using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Labs
{
    public class Fort : Attacker
    {
        public float damage;
        public void attack(Unit unit)
        {
            unit.receiveDamage(damage);
        }
    }
}
