using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GIL_664 : SimTemplate //* 三眼乌鸦 Vex Crow
//Whenever you cast a spell, summon a random2-Cost minion.
//每当你施放一个法术，随机召唤一个法力值消耗为（2）的随从。 
	{
		
		
        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion triggerEffectMinion)
        {
            if (triggerEffectMinion.own == wasOwnCard && hc.card.type == CardDB.cardtype.SPELL)
            {
                int pos = (wasOwnCard) ? p.ownMinions.Count : p.enemyMinions.Count;
                p.callKid(p.getRandomCardForManaMinion(2), pos, wasOwnCard);
            }
        }
	}
}