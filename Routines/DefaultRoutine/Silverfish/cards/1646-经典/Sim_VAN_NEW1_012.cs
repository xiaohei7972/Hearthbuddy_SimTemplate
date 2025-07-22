using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_NEW1_012 : SimTemplate //* 法力浮龙 Mana Wyrm
	{
		//Whenever you cast a spell, gain +1 Attack.
		//每当你施放一个法术，便获得+1攻击力。

        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion triggerEffectMinion)
        {
            if (triggerEffectMinion.own == wasOwnCard && hc.card.type == CardDB.cardtype.SPELL)
            {
				p.minionGetBuffed(triggerEffectMinion, 1, 0);
            }
        }
	}
}