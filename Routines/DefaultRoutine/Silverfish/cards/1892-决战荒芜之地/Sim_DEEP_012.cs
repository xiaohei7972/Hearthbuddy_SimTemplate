using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 恶魔猎手 费用：1 攻击力：1 生命值：1
	//Shadestone Skulker
	//影石潜伏者
	//[x]<b>Rush</b>. <b>Battlecry:</b> Take your_weapon and gain its stats._<b>Deathrattle:</b> Give it back.
	//<b>突袭</b>。<b>战吼：</b>夺取你的武器并获得其属性值。<b>亡语：</b>还回武器。
	class Sim_DEEP_012 : SimTemplate
	{

        CardDB.Card stolenWeapon = null; // 用于存储被盗取的武器

        public override void getBattlecryEffect(Playfield p, Minion ownMinion, Minion target, int choice)
        {
            // 处理战吼效果
            if (ownMinion.own && p.ownWeapon.Durability > 0)
            {
                // 夺取武器
                stolenWeapon = p.ownWeapon.card;
                target.Angr += p.ownWeapon.Angr;
                target.Hp += p.ownWeapon.Durability;

                // 移除玩家的武器
                p.lowerWeaponDurability(p.ownWeapon.Durability, true);
            }
        }

        public override void onDeathrattle(Playfield p, Minion m)
        {
            // 处理亡语效果
            if (stolenWeapon != null)
            {
                // 还回武器
                p.equipWeapon(stolenWeapon, true);
                stolenWeapon = null; // 清空存储的武器
            }
        }
    }
}
