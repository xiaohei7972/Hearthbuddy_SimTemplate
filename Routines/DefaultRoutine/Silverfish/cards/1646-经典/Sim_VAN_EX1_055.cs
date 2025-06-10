using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_055 : SimTemplate //* 魔瘾者 Mana Addict
	{
		//Whenever you cast a spell, gain +2 Attack this turn.
		//在本回合中，每当你施放一个法术，便获得+2攻击力。
        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion triggerEffectMinion)
        {
            if (triggerEffectMinion.own == wasOwnCard && hc.card.type == CardDB.cardtype.SPELL)
            {
                p.minionGetTempBuff(triggerEffectMinion, 2, 0);
            }
        }

	}
}