using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//地标 德鲁伊 费用：1
	//Cenarion Hold
	//塞纳里奥要塞
	//[x]Your next <b>Choose One</b>card this turn has botheffects combined.
	//在本回合中，你的下一张<b>抉择</b>牌同时拥有两种效果。
	class Sim_WON_015 : SimTemplate
	{
        public override void useLocation(Playfield p, Minion triggerMinion, Minion target)
        {
            // 激活效果，使得下一张抉择牌拥有两种效果
            if (triggerMinion.handcard.card.CooldownTurn == 0) p.nextChooseOneHasBothEffects = true;
        }
    }
}
