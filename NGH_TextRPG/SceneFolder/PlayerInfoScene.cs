using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGH_TextRPG.SceneFolder
{
    internal class PlayerInfoScene : Scene
    {
        public PlayerInfoScene(Game game) : base(game)
        { 

        }
        public override void Enter()
        {
            Console.WriteLine("플레이어의 상태를 표시합니다.");
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
            Console.WriteLine("스테이터스창");
            Console.WriteLine($"레벨 : {game.player.level}");
            Console.WriteLine($"경험치 : {game.player.exp} / {game.player.reqExp}");
            Console.WriteLine($"소지금 : {game.player.gold}");
            Console.WriteLine($"체력 : {game.player.maxHP}");
            Console.WriteLine($"공격력 : {game.player.attack}");
            Console.WriteLine($"방어력 : {game.player.defense}");
            Console.WriteLine($"크리티컬 : {game.player.critical}");
            Console.WriteLine($"회피 : {game.player.evasion}");
            Console.WriteLine();
            Console.WriteLine("마을로 돌아가려면 아무 키나 눌러주세요.");
        }

        public override void Update()
        {
            game.ChangeScene(SceneType.Hometown);
        }
    }
}
