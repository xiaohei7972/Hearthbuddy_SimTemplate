using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_664 : SimTemplate //* 雷矛救援站 stormpikeaidstation
	{
		//在你的回合结束时，使你的随从获得+2生命值。持续3回合。
        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            foreach (Minion m in p.ownMinions)
            {
                p.minionGetBuffed(m, 0, 2);
            }
        }
		
	}
}
