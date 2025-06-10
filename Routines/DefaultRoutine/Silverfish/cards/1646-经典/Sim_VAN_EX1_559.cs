using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_559 : SimTemplate //* 大法师安东尼达斯 Archmage Antonidas
	{
		//Whenever you cast a spell, add a 'Fireball' spell to_your hand.
		//每当你施放一个法术，将一张“火球术”法术牌置入你的手牌。
        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion triggerEffectMinion)
        {
            if (wasOwnCard == triggerEffectMinion.own && hc.card.type == CardDB.cardtype.SPELL)
            {
                p.drawACard(CardDB.cardNameEN.fireball, wasOwnCard, true);
            }
        }

	}
}