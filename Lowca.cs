using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleRPGv22
{
    class Lowca : klasaPostaci
    {
        // konstruktory
        public Lowca()
        {

        }

        public Lowca(string name)
        {
            CharName = name;

            CharHp = 400;

            CharMp = 200;

            CharLvl = 1;

            CharLp = 1;

            CharStr = 7;

            CharInt = 4;

            CharDex = 10;

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
