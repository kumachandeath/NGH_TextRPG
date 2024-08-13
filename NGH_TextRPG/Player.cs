using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NGH_TextRPG
{
    internal class Player
    {


        public Player()
        {
            StatusData playerStatusData = new StatusData();
            playerStatusData.hp = 50;
            playerStatusData.attack = 10;
            playerStatusData.defense = 10;
            playerStatusData.critical = 5.0f;
            playerStatusData.evasion = 5.0f;

            playerStatusData.exp = 0;
            playerStatusData.level = 1;
            playerStatusData.gold = 0;
        }
    }
}

