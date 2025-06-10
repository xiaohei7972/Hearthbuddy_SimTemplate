using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_OG_209 : SimTemplate //* 升腾者海纳泽尔 Hallazeal the Ascended
//Whenever your spells deal damage, restore that much Health to your hero.
//每当你的法术造成伤害时，为你的英雄恢复等量的生命值。 
	{
		
		
        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool ownplay, Minion m)
        {
            if (m.own == ownplay && hc.card.type == CardDB.cardtype.SPELL)
            {
                Minion target = (ownplay) ? p.ownHero : p.enemyHero;
                p.minionGetDamageOrHeal(target, -5);
            }
        }
    }
}