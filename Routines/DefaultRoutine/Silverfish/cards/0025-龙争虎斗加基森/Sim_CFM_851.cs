using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_851 : SimTemplate //* 勇敢的记者 Daring Reporter
//Whenever your opponent draws a card, gain +1/+1.
//每当你的对手抽一张牌时，便获得+1/+1。 
	{
		

        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            if (triggerEffectMinion.own == turnEndOfOwner)
            {
                p.minionGetBuffed(triggerEffectMinion, 1, 1);
            }
        }
	}
}