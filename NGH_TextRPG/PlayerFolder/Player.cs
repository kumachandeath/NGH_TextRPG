using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NGH_TextRPG.PlayerFolder
{
    public class Player
    {
        public int curHP;
        public int maxHP;
        public int attack;
        public int defense;
        public float critical;
        public float evasion;

        public int exp;
        public int reqExp;
        public int level;
        public int gold;

        public Player()
        {
            maxHP = 50;
            curHP = maxHP;
            attack = 10;
            defense = 10;
            critical = 5.0f;
            evasion = 5.0f;

            exp = 0;
            reqExp = 5;
            level = 1;
            gold = 0;
        }

        public int LevelUp(int exp)
        {
            return level++;
        }
    }
}

