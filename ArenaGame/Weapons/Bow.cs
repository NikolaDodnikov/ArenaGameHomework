using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArenaGame.Heroes;

namespace ArenaGame.Weapons
{
    public class Bow : IWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }

        public Bow(string name)
        {
            Name = name;
            AttackDamage = 12;
            BlockingPower = 0;
        }
        public void SpecialAbilty(Hero hero)
        {
            if(hero is Archer)
            {
                AttackDamage += 1.8;
            }
            
        }
    }
}
