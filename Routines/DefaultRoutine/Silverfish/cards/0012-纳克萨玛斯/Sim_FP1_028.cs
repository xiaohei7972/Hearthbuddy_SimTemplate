using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_FP1_028 : SimTemplate //* 送葬者 Undertaker
	{
		//Whenever you summon a minion with <b>Deathrattle</b>, gain +1/+1.
		//每当你召唤一个具有<b>亡语</b>的随从，便获得+1/+1。
        public override void onMinionIsSummoned(Playfield p, Minion triggerEffectMinion, Minion summonedMinion)
        {
            if (triggerEffectMinion.own == summonedMinion.own)
            {
                if (summonedMinion.handcard.card.deathrattle) p.minionGetBuffed(triggerEffectMinion,1,1);
            }
        }

	}
}
