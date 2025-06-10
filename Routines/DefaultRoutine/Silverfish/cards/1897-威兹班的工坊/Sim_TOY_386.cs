using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：1 攻击力：2 生命值：1
	//Giftwrapped Whelp
	//礼盒雏龙
	//<b>Battlecry:</b> If you're holding a Dragon, give it and this minion +1/+1.
	//<b>战吼：</b>如果你的手牌中有龙牌，使该龙牌和本随从获得+1/+1。
	class Sim_TOY_386 : SimTemplate
	{

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 遍历手牌，寻找龙牌
            foreach (Handmanager.Handcard hc in p.owncards)
            {
                if ((TAG_RACE)hc.card.race == TAG_RACE.DRAGON)
                {
                    // 如果找到龙牌，使其获得+1/+1
                    hc.addattack++;
                    hc.addHp++;

                    // 同时，使本随从获得+1/+1
                    p.minionGetBuffed(own, 1, 1);

                    // 只处理第一张找到的龙牌，找到后立即跳出循环
                    break;
                }
            }
        }
    }
}
