using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_127 : SimTemplate //* 冰雪亡魂 icerevenant
	{
		//每当你施放一个冰霜法术，便获得+2/+2。
        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion triggerEffectMinion)
        {
            if (hc.card.type == CardDB.cardtype.SPELL && wasOwnCard == triggerEffectMinion.own && hc.card.SpellSchool == CardDB.SpellSchool.FROST && !triggerEffectMinion.silenced)
            {
                p.minionGetBuffed(triggerEffectMinion, 2, 2);
            }

        }
		
	}
}
