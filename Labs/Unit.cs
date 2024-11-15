using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs
{
    public class Unit : GameObject
    {
        
        public bool alive;
        public float hp;
        public Unit(int id, string name, int x, int y, bool alive, float hp) : base(id, name, x, y)
        {
            this.alive = alive;
            this.hp = hp;
        }

        public bool isAlive()
        {
            return alive;
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
