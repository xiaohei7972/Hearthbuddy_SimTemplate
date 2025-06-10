using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_100 : SimTemplate //* 游学者周卓 Lorewalker Cho
	{
		//Whenever a player casts a spell, put a copy into the other player’s hand.
		//每当一个玩家施放一个法术，复制该法术，将其置入另一个玩家的手牌。
        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion triggerEffectMinion)
        {
            if (hc.card.type == CardDB.cardtype.SPELL)
            {
                p.drawACard(hc.card.nameEN, !wasOwnCard, true);
            }
        }

	}
}