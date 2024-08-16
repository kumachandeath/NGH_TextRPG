using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGH_TextRPG.SceneFolder
{
    internal class DevilCastleScene : Scene
    {

        public DevilCastleScene(Game game) : base(game) 
        {

        }

        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine("마왕성으로 이동합니다...");
            Thread.Sleep(2000);
        }

        public override void Exit()
        {
            
        }

        public override void Input()
        {
            Console.ReadLine();
        }

        public override void Render()
        {
            Console.Clear();
            Console.WriteLine("마왕성에 도착했다. 몇층으로 갈까?");
            Console.WriteLine("1. 1층(레벨 1~5 추천)");
            Console.WriteLine("2. 2층(레벨 5~15 추천)");
            Console.WriteLine("3. 3층(레벨 15~25 추천)");
            Console.WriteLine("4. 4층(레벨 25~35 추천)");
            Console.WriteLine("5. 알현실(레벨 40 추천)");
            Console.WriteLine("0. 마을로 돌아가기(하루가 지나지 않음)");
            Console.Write("선택 : ");
        }

        public override void Update()
        {
            
        }
    }
}
