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
        StatusData playerStatusData = new StatusData();

        public Player()
        {
            playerStatusData.maxHP = 50;
            playerStatusData.curHP = playerStatusData.maxHP;
            playerStatusData.attack = 10;
            playerStatusData.defense = 10;
            playerStatusData.critical = 5.0f;
            playerStatusData.evasion = 5.0f;

            playerStatusData.exp = 0;
            playerStatusData.level = 1;
            playerStatusData.gold = 0;
        }

        public int LevelUp(int exp)
        {
            return playerStatusData.level++;
        }
    }
}

