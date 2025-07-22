using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_060 : SimTemplate //* 猩红法力浮龙 Red Mana Wyrm
//Whenever you cast a spell, gain +2 Attack.
//每当你施放一个法术，便获得+2攻击力。 
	{
		

        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion triggerEffectMinion)
        {
            if (triggerEffectMinion.own == wasOwnCard && hc.card.type == CardDB.cardtype.SPELL)
            {
                p.minionGetBuffed(triggerEffectMinion, 2, 0);
            }
        }
    }
}