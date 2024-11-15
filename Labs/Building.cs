using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs
{
    public class Building : GameObject
    {
        
        public bool built;
        public float hp;
        public Building(int id, string name, int x, int y, bool built, float hp) : base(id, name, x, y)
        {
            this.built = built;
            this.hp = hp;
        }

        public bool isBuilt()
        {
            return built;
        }

        public float getHp()
        {
            return hp;
        }

        public void receiveDamage(float damage)
        {
            this.hp -= damage;
        }
    }
}
