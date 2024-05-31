using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArenaGame.Heroes;

namespace ArenaGame.Weapons
{
    public class Mace : IWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }

        public Mace(string name)
        {
            Name = name;
            AttackDamage = 50;
            BlockingPower = 15;
        }
        public void SpecialAbilty(Hero hero)
        {
           if (hero is Knight)
            {
                AttackDamage *= 2.5;
            }
           else if(hero is Assassin)
            {
                AttackDamage *= 1.25;
            }
            else
            {
                AttackDamage *= 0.25;
            }
        }
    }
}
