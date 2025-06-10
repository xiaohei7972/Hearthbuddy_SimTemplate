using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 战士 费用：1
	//Cup o' Muscle
	//腱力金杯
	//[x]Give a minion in__your hand +2/+1. <i>(Last Drink!)</i>
	//使你手牌中的一张随从牌获得+2/+1。<i>（最后一杯！）</i>
	class Sim_VAC_338t2 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 随机从手牌中找到一张随从牌，优先选择费用最低的随从
            Handmanager.Handcard hc = p.searchRandomMinionInHand(p.owncards, searchmode.searchLowestCost, GAME_TAGs.Mob);

            if (hc != null)
            {
                // 为该随从牌增加+2攻击力和+1生命值
                hc.addattack += 2;
                hc.addHp += 1;
            }
        }

    }
}
