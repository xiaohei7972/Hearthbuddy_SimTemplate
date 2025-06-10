using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 潜行者 费用：5
	//Shadow Word: Steal
	//暗言术：窃
	//Return an enemy minion to YOUR hand.
	//将一个敌方随从移回<b>你</b>的手牌。
	class Sim_DEEP_021 : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (target != null && !target.own) // 确保目标是敌方随从
            {
                // 将目标随从移回玩家的手牌
                p.minionReturnToHand(target, ownplay, target.handcard.getManaCost(p));
            }
        }
    }
}
