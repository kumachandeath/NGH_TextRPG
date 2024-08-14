using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NGH_TextRPG.MonsterFolder
{
    public class Monster
    {
        private string name;
        public int curHP;
        public int maxHP;
        public int attack;
        public int defense;
        public float critical;
        public float evasion;

        public int exp;
        public int level;
        public int gold;

        public string Name { get; set; }

        public Monster(string name) 
        {
            this.name = name;
            
        }
    }
}
