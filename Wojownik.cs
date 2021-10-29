using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleRPGv22
{
    class Wojownik : klasaPostaci
    {
        // konstruktory
        public Wojownik()
        {

        }
        public Wojownik(string name)
        {
            CharName = name;

            CharHp = 500;

            CharMp = 100;

            CharLvl = 1;

            CharLp = 1;

            CharStr = 10;

            CharInt = 4;

            CharDex = 7;

            SkillAvailable = false;

            SkillLearned = false;
        }

        // metody :

        public override void doBasicAttack()
        {
            
        }

        public override void useSkill()
        {
            
        }


    }
}
