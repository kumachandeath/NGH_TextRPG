using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGH_TextRPG.SceneFolder
{
    internal class TrainingRoomScene : Scene
    {
        public string input;

        public TrainingRoomScene(Game game) : base(game) 
        { 

        }

        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine("훈련장으로 이동합니다...");
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
            Console.WriteLine("오늘은 어떤 훈련을 하시겠습니까?");
            Console.WriteLine("1. 체력 훈련");
            Console.WriteLine("2. 공격력 훈련");
            Console.WriteLine("3. 방어력 훈련");
            Console.WriteLine("4. 치명타 훈련");
            Console.WriteLine("5. 회피 훈련");
            Console.WriteLine("0. 마을로 돌아가기(하루를 끝낸다.)");
            Console.Write("선택 : ");
        }

        public override void Update()
        {
            switch (input)
            {
                case "0":
                    Console.Clear();
                    Console.WriteLine("마을로 돌아갑니다.");
                    Thread.Sleep(2000);
                    Console.WriteLine("하루가 지났습니다.");
                    Game.daysLeft--;
                    game.ChangeScene(SceneType.Hometown);
                    break;
                case "1":
                    Console.Clear();
                    Console.WriteLine("체력 훈련을 시작합니다.");
                    game.player.maxHP += 5 + (int)(game.player.maxHP * 0.1f);
                    Thread.Sleep(2000);
                    Console.WriteLine("훈련을 마치고 녹초가 되었습니다. 마을로 귀환합니다.");
                    Thread.Sleep(2000);
                    Console.WriteLine("하루를 끝마칩니다.");
                    Game.daysLeft--;
                    Thread.Sleep(2000);
                    game.ChangeScene(SceneType.Hometown);
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("공격력 훈련을 시작합니다.");
                    game.player.attack += 1 + (int)(game.player.attack * 0.1f);
                    Thread.Sleep(2000);
                    Console.WriteLine("훈련을 마치고 녹초가 되었습니다. 마을로 귀환합니다.");
                    Thread.Sleep(2000);
                    Console.WriteLine("하루를 끝마칩니다.");
                    Game.daysLeft--;
                    Thread.Sleep(2000);
                    game.ChangeScene(SceneType.Hometown);
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("방어력 훈련을 시작합니다.");
                    game.player.defense += 1 + (int)(game.player.defense * 0.1f);
                    Thread.Sleep(2000);
                    Console.WriteLine("훈련을 마치고 녹초가 되었습니다. 마을로 귀환합니다.");
                    Thread.Sleep(2000);
                    Console.WriteLine("하루를 끝마칩니다.");
                    Game.daysLeft--;
                    Thread.Sleep(2000);
                    game.ChangeScene(SceneType.Hometown);
                    break;
                case "4":
                    Console.Clear();
                    Console.WriteLine("크리티컬 훈련을 시작합니다.");
                    game.player.critical += 2;
                    Thread.Sleep(2000);
                    Console.WriteLine("훈련을 마치고 녹초가 되었습니다. 마을로 귀환합니다.");
                    Thread.Sleep(2000);
                    Console.WriteLine("하루를 끝마칩니다.");
                    Game.daysLeft--;
                    Thread.Sleep(2000);
                    game.ChangeScene(SceneType.Hometown);
                    break;
                case "5":
                    Console.Clear();
                    Console.WriteLine("회피 훈련을 시작합니다.");
                    game.player.evasion += 2;
                    Thread.Sleep(2000);
                    Console.WriteLine("훈련을 마치고 녹초가 되었습니다. 마을로 귀환합니다.");
                    Thread.Sleep(2000);
                    Console.WriteLine("하루를 끝마칩니다.");
                    Game.daysLeft--;
                    Thread.Sleep(2000);
                    game.ChangeScene(SceneType.Hometown);
                    break;
                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    break;
            }
        }
    }
}
