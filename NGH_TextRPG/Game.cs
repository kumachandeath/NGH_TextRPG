using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NGH_TextRPG.PlayerFolder;
using NGH_TextRPG.MonsterFolder;
using NGH_TextRPG.SceneFolder;

namespace NGH_TextRPG
{
    public class Game
    {
        private Scene[] scenes;
        private Scene curScene;
        public Scene CurScene { get { return curScene; } }

        public static int daysLeft = 100;
        
        public Game()
        {
            Player player = new Player();
        }

        public void Run()
        {

        }
    }
}
