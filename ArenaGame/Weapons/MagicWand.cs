using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArenaGame.Heroes;

namespace ArenaGame.Weapons
{
    public class MagicWand : IWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }

        public MagicWand(string name)
        {
            Name = name;
            AttackDamage = 10;
            BlockingPower = 1;
        }
   

        public void SpecialAbilty(Hero hero)
        {
            Random random = new Random();
            if (hero is Wizard)
            {
                int randomNum = random.Next(2);
                if (randomNum == 0)
                {
                    AttackDamage *= 8;
                }
                else
                {
                    AttackDamage += 5;
                }

            }
            else
            {
                AttackDamage = 1;
            }
        }
    }
}
