using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGH_TextRPG.PlayerFolder
{
    public class Equipment
    {
        public string weapon;
        public string armor;
        public string accesory;

        public Equipment()
        {
            weapon = "목검";
            armor = "천갑옷";
            accesory = "없음";
        }

        public string ChangeWeapon(string name)
        {
            // 이름을 넣으면 그에 맞는 스탯으로 변경하는 기능 구현.
            return name;
        }

        public string ChangeArmor(string name)
        {
            // 이름을 넣으면 그에 맞는 스탯으로 변경하는 기능 구현.
            return name;
        }

        public string ChangeAccessory(string name)
        {
            // 이름을 넣으면 그에 맞는 스탯으로 변경하는 기능 구현.
            return name;
        }
    }
}
