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
        public string check;

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
            Console.WriteLine("1.강철검\t\t2.은철검\t\t3.금강검");
            Console.WriteLine("100G\t\t1000G\t\t10000G\t\t");
            Console.WriteLine("4.강철갑옷\t\t5.은철갑옷\t\t6.금강갑옷");
            Console.WriteLine("100G\t\t1000G\t\t10000G\t\t");
            Console.WriteLine("7.공방부적\t\t8.치명부적\t\t9.회피부적");
            Console.WriteLine("500G\t\t10000G\t\t10000G\t\t");
            Console.WriteLine("0. 마을로 돌아가기(하루를 끝낸다)");
            Console.Write("선택 : ");
        }

        public override void Update()
        {
            switch (input)
            {
                case "0":
                    Console.WriteLine("마을로 돌아갑니다.");
                    Thread.Sleep(2000);
                    Console.WriteLine("하루가 지났습니다.");
                    Game.daysLeft--;
                    game.ChangeScene(SceneType.Hometown);
                    break;
                case "1":
                    if (game.player.gold >= 100)
                    {
                        Console.WriteLine("강철검을 구매하시겠습니까?(Y/N)");
                        check = Console.ReadLine();
                        switch (check)
                        {
                            case "y":
                            case "Y":
                                Console.WriteLine("강철검을 구매합니다.");
                                game.player.gold -= 100;

                                break;
                        }
                    }


                    break;
            }
        }
    }
}
