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
        private bool isRunning;

        private Scene[] scenes;
        private Scene curScene;
        public Scene CurScene { get { return curScene; } }

        public static int daysLeft = 100;

        public Player player = new Player();
        public Equipment equipment = new Equipment();

        public void Run()
        {
            Start();
            while (isRunning)
            {
                Render();
                Input();
                Update();
            }
            End();
        }

        public void ChangeScene(SceneType sceneType)
        {
            curScene.Exit();
            curScene = scenes[(int)sceneType];
            curScene.Enter();
        }

        public void Over()
        {
            isRunning = false;
        }

        private void Start()
        {
            isRunning = true;

            scenes = new Scene[(int)SceneType.Size];
            scenes[(int)SceneType.Title] = new TitleScene(this);
            scenes[(int)SceneType.Hometown] = new HomeTownScene(this);
            scenes[(int)SceneType.Shop] = new ShopScene(this);
            scenes[(int)SceneType.Trainingroom] = new TrainingRoomScene(this);
            scenes[(int)SceneType.Devilcastle] = new DevilCastleScene(this);
            scenes[(int)SceneType.Playerinfo] = new PlayerInfoScene(this);
            scenes[(int)SceneType.Battle] = new BattleScene(this);

            curScene = scenes[(int)SceneType.Title];
            curScene.Enter();
        }

        private void End()
        {
            curScene.Exit();
        }

        private void Render()
        {
            curScene.Render();
        }

        private void Input()
        {
            curScene.Input();
        }

        private void Update()
        {
            curScene.Update();
        }

    }
}
