using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_231 : SimTemplate //* 奥术工匠 Arcane Artificer
//Whenever you cast a spell, gain Armor equal to its_Cost.
//每当你施放一个法术，便获得等同于其法力值消耗的护甲值。 
	{
		

        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion triggerEffectMinion)
        {
            if (triggerEffectMinion.own == wasOwnCard && hc.card.type == CardDB.cardtype.SPELL)
            {
				int heal = (wasOwnCard) ? p.getMinionHeal(3) : p.getEnemyMinionHeal(3);
				p.minionGetDamageOrHeal(wasOwnCard ? p.ownHero : p.enemyHero, -heal);
            }
        }
	}
}