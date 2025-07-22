using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_NEW1_038 : SimTemplate //* 格鲁尔 Gruul
	{
		//At the end of each turn, gain +1/+1 .
		//在每个回合结束时，获得+1/+1。
        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            p.minionGetBuffed(triggerEffectMinion, 1, 1);
        }
        

    }
}
