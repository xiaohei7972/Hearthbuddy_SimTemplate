using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SW_445 : SimTemplate //* 灵能魔 Psyfiend
	{
		//After you cast a Shadow spell, deal 2 damage to each Hero.
		//在你施放一个暗影法术后，对双方英雄造成2点伤害。
        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion triggerEffectMinion)
        {
            if (triggerEffectMinion.own == wasOwnCard && hc.card.type == CardDB.cardtype.SPELL && hc.card.SpellSchool == CardDB.SpellSchool.SHADOW)
            {
                p.minionGetDamageOrHeal(p.ownHero, 2);
                p.minionGetDamageOrHeal(p.enemyHero, 2);
            }
        }

    }
}
