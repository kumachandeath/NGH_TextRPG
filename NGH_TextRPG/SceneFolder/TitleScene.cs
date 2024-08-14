using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGH_TextRPG.SceneFolder
{
    internal class TitleScene : Scene
    {
        public TitleScene(Game game) : base(game) 
        { 
        }

        public override void Enter()
        {
            
        }

        public override void Exit()
        {
            
        }

        public override void Input()
        {
            Console.ReadKey();
        }

        public override void Render()
        {
            Console.Clear();
            Console.WriteLine("세계에 위기가 닥쳤다.");
            Thread.Sleep(2000);
            Console.WriteLine("마왕이 부활한 것이다.");
            Thread.Sleep(2000);
            Console.WriteLine("마왕을 물리치러 여행을 떠나자.");
            Thread.Sleep(2000);
            Console.WriteLine("검사의 여행!");
            Thread.Sleep(2000);
        }

        public override void Update()
        {
            game.ChangeScene(SceneType.Hometown);
        }
    }
}
