using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGH_TextRPG.SceneFolder
{
   

    internal class HomeTownScene : Scene
    {
        private string input;

        public HomeTownScene(Game game) : base(game)
        {
        }

        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine("마을로 진입합니다...");
            Thread.Sleep(2000);
        }

        public override void Exit()
        {
            
        }

        public override void Input()
        {
            input = Console.ReadLine();
        }

        public override void Render()
        {
            Console.Clear();
            Console.WriteLine("오늘은 어떤 일을 할까?");
            Console.WriteLine("1. 상점");
            Console.WriteLine("2. 훈련장");
            Console.WriteLine("3. 마왕성");
            Console.WriteLine("4. 상태 확인");
            Console.Write("선택 : ");
        }

        public override void Update()
        {
            switch (input)
            {
                case "1":
                    game.ChangeScene(SceneType.Shop);
                    break;
                case "2":
                    game.ChangeScene(SceneType.Trainingroom);
                    break;
                case "3":
                    game.ChangeScene(SceneType.Devilcastle);
                    break;
                case "4":
                    game.ChangeScene(SceneType.Playerinfo);
                    break;
                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    game.ChangeScene(SceneType.Hometown);
                    break;
            }
        }
    }
}
