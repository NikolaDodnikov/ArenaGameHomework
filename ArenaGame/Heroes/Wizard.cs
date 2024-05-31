using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Wizard : Hero
    {
        private int hitCount;
        private double damageCoef;
        public Wizard(string name, double armor, double strenght, IWeapon weapon) : base(name, armor, strenght, weapon)
        {
            hitCount = 0;
            damageCoef = 0.9;
        }

        public override double Attack()
        {
            if(hitCount > 10)
            {
                hitCount = 0;
                damageCoef = 0.9;
            }
            hitCount++;
            damageCoef += 0.1;
            return base.Attack()*damageCoef;
        }
    }

}

