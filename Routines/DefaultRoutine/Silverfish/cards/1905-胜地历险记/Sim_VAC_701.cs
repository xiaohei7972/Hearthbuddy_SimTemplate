using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 牧师 费用：3 攻击力：3 生命值：3
	//Swarthy Swordshiner
	//刀剑保养师
	//<b>Battlecry:</b> Set the Attack and Durability of your weapon to 3.
	//<b>战吼：</b>将你的武器的攻击力和耐久度变为3。
	class Sim_VAC_701 : SimTemplate
	{

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (own.own && p.ownWeapon.Durability > 0)
            {
                p.ownWeapon.Angr = 3; // 设置武器攻击力为3
                p.ownWeapon.Durability = 3; // 设置武器耐久度为3
                p.ownHero.Angr = p.ownWeapon.Angr; // 更新英雄攻击力
                p.ownHero.updateReadyness(); // 更新英雄的准备状态
            }
        }
    }
}
