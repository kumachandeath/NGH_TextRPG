using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGH_TextRPG
{
    public abstract class StatusData
    {
        protected int curHP;
        public int CurHP { get { return curHP; } }

        protected int maxHP;
        public int MaxHp { get { return maxHP; } }

        protected int attack;
        public int Attack { get { return attack; } }

        protected int defense;
        public int Defense {  get { return defense; } }

        protected float critical;
        public float Critical {  get { return critical; } }

        protected float evasion;
        public float Evasion { get { return evasion; } }

        protected int exp;
        public int Exp { get { return exp; } }

        protected int level;
        public int Level { get { return level; } }

        protected int gold;
        public int Gold { get { return gold; } set { gold = value; } }
        
    }
}
