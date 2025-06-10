using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_187 : SimTemplate //* 奥术吞噬者 Arcane Devourer
	{
		//Whenever you cast a spell, gain +2/+2.
		//每当你施放一个法术，便获得+2/+2。
        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion triggerEffectMinion)
        {
            if (triggerEffectMinion.own == wasOwnCard && hc.card.type == CardDB.cardtype.SPELL)
            {
                p.minionGetBuffed(triggerEffectMinion, 2, 2);
            }
        }		
		
	}
}
