using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleRPGv22
{
    class Mag : klasaPostaci
    {
        // konstruktory
        public Mag()
        {

        }

        public Mag(string name)
        {
            CharName = name;

            CharHp = 250;

            CharMp = 350;

            CharLvl = 1;

            CharLp = 1;

            CharStr = 4;

            CharInt = 10;

            CharDex = 7;

            SkillAvailable = false;

            SkillLearned = false;
        }

        // metody
        public override void doBasicAttack()
        {

        }

        public override void useSkill()
        {

        }
    }
}
