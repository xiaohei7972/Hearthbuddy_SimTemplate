using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOE_086 : SimTemplate //* 集合石 Summoning Stone
//Whenever you cast a spell, summon a random minion of the same Cost.
//每当你施放一个法术，随机召唤一个法力值消耗相同的随从。 
	{
		
		
        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion triggerEffectMinion)
        {
            if (triggerEffectMinion.own == wasOwnCard && hc.card.type == CardDB.cardtype.SPELL)
            {
                int pos = (wasOwnCard) ? p.ownMinions.Count : p.enemyMinions.Count;
                p.callKid(p.getRandomCardForManaMinion(hc.manacost), pos, wasOwnCard);
            }
        }
	}
}