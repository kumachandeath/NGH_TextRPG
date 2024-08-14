using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGH_TextRPG.SceneFolder
{
    public class ShopScene : Scene
    {
        public string input;

        public ShopScene(Game game) : base(game) 
        {

        }

        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine("상점에 들어갑니다...");
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
            Console.WriteLine("상점에 어서오세요!");
            Thread.Sleep(2000);
            Console.WriteLine("오늘은 무엇을 사실건가요?");
            Thread.Sleep(2000);
            Console.WriteLine("1. 무기 상점");
            Console.WriteLine("2. 방어구 상점");
            Console.WriteLine("3. 액세서리 상점");
            Console.WriteLine("4. 배틀용 아이템 상점");
            Console.WriteLine("0. 마을로 돌아가기(하루를 끝낸다)");
            Console.Write("선택 : ");
        }

        public override void Update()
        {
            switch (input)
            {
                case "0":
            }
        }
    }
}
