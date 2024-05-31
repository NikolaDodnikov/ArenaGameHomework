using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Archer : Hero
    {
        private int hitCount;

   
        public Archer(string name, double armor, double strenght, IWeapon weapon) : base(name, armor, strenght, weapon)
        {
            hitCount = 0;
        }

        public override double Attack()
        {
            hitCount++;
            if (hitCount == 2)
            {
                hitCount = 0;
                return base.Attack() + 2; 
                
            }
            return base.Attack();
        }

    }
}
