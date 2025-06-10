using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GIL_833 : SimTemplate //* 森林向导 Forest Guide
//At the end of your turn, both players draw a card.
//在你的回合结束时，双方玩家各抽一张牌。 
	{
		

        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            if (triggerEffectMinion.own == turnEndOfOwner)
            {
                p.drawACard(CardDB.cardNameEN.unknown, true);
                p.drawACard(CardDB.cardNameEN.unknown, false);
            }
        }
	}
}