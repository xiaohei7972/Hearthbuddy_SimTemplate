using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DRG_057 : SimTemplate //* 热气球 Hot Air Balloon
	{
		//At the start of your turn, gain +1 Health.
		//在你的回合开始时，获得+1生命值。
		public override void onTurnStartTrigger(Playfield p, Minion triggerEffectMinion, bool turnStartOfOwner)
        {//回合开始触发
            if(triggerEffectMinion.own == turnStartOfOwner)
			{
				p.minionGetBuffed(triggerEffectMinion, 0, 1);//生命值+1
			}
        }
		
	}
}
