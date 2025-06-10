using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_KAR_035 : SimTemplate //* 宴会牧师 Priest of the Feast
//Whenever you cast a spell, restore #3 Health toyour hero.
//每当你施放一个法术，为你的英雄恢复#3点生命值。 
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