using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_774 : SimTemplate //* 特殊坐骑商人 Exotic Mountseller
//Whenever you cast a spell, summon a random3-Cost Beast.
//每当你施放一个法术，随机召唤一个法力值消耗为（3）的野兽。 
	{
		
		
        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion triggerEffectMinion)
        {
            if (triggerEffectMinion.own == wasOwnCard && hc.card.type == CardDB.cardtype.SPELL)
            {
                int pos = (wasOwnCard) ? p.ownMinions.Count : p.enemyMinions.Count;
                p.callKid(p.getRandomCardForManaMinion(3), pos, wasOwnCard);
            }
        }
	}
}