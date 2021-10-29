using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleRPGv22
{
    class klasaPostaci
    {
        // Atrybuty klasy

        private string _charName;

        public string CharName
        {
            get { return _charName; }

            set { if(value.Length < 10 && value.Length > 0)
                    {
                        _charName = value;
                    }    
                }

        }

        private int _charLvl;

        public int CharLvl
        {
            get { return _charLvl; }

            set { _charLvl = value; }
        }

        private int _charLp;

        public int CharLp
        {
            get { return _charLp; }

            set { _charLp = value; }
        }

        private int _charHp;
        public int CharHp
        {
            get { return _charHp; }

            set { _charHp = value; }
        }

        private int _charMp;

        public int CharMp
        {
            get { return _charMp; }

            set { _charMp = value; }
        }

        private int _charStr;

        public int CharStr
        {
            get { return _charStr; }

            set { _charStr = value; }
        }

        private int _charInt;

        public int CharInt
        {
            get { return _charInt; }

            set { _charInt = value; }
        }

        private int _charDex;

        public int CharDex
        {
            get { return _charDex; }

            set { _charDex = value; }
        }

        private bool _skillLearned;

        public bool SkillLearned
        {
            get { return _skillLearned; }

            set { _skillLearned = value; }
        }

        private bool _skillAvailable;
        public bool SkillAvailable
        {
            get { return _skillAvailable; }

            set { _skillAvailable = value; }
        }




        // Konstruktory
        public klasaPostaci()
        {

        }


        // Metody klasy

        public virtual void doBasicAttack()
        {

        }

        public virtual void useSkill()
        {

        }

        public void setAttribute(int attToSet, int attReceived)
        {
            attToSet = attReceived;
        }
    }
}
