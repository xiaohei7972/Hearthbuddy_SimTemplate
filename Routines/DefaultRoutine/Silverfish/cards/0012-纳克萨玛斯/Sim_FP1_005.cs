using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_FP1_005 : SimTemplate //* 纳克萨玛斯之影 Shade of Naxxramas
//<b>Stealth.</b> At the start of your turn, gain +1/+1.
//<b>潜行。</b>在你的回合开始时，获得+1/+1。 
	{



        public override void onTurnStartTrigger(Playfield p, Minion triggerEffectMinion, bool turnStartOfOwner)
        {
            if (triggerEffectMinion.own == turnStartOfOwner)
            {
                p.minionGetBuffed(triggerEffectMinion,1,1);
            }
        }

	}
}