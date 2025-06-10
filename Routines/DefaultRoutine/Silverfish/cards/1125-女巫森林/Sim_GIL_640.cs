using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GIL_640 : SimTemplate //* 古董收藏家 Curio Collector
//Whenever you draw a card, gain +1/+1.
//每当你抽一张牌时，便获得+1/+1。 
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