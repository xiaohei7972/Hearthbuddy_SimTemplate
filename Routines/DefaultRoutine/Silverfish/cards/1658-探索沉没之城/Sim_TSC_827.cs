using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TSC_827 : SimTemplate //* 凶恶的滑矛纳迦 Vicious Slitherspear
//在你施放一个法术后，直到你的下个回合，获得+1攻击力。
//After you cast a spell, gain +1 Attack until your next turn.

    {
        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion triggerEffectMinion)
        {
            if (triggerEffectMinion.own == wasOwnCard && hc.card.type == CardDB.cardtype.SPELL)
            {
                p.minionGetTempBuff(triggerEffectMinion, 1, 0);
            }
        }
    }
}
