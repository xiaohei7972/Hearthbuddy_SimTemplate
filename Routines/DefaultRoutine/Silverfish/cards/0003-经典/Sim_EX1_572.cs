using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_572 : SimTemplate //* 伊瑟拉 Ysera
	{
		//At the end of your turn, add_a Dream Card to_your hand.
		//在你的回合结束时，将一张梦境牌置入你的手牌。

        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            if (triggerEffectMinion.own == turnEndOfOwner)
            {
                p.drawACard(CardDB.cardNameEN.yseraawakens, turnEndOfOwner, true);
            }
        }

	}
}