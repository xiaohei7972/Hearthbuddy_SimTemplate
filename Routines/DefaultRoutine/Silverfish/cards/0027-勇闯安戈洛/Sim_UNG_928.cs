using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_928 : SimTemplate //* 焦油爬行者 Tar Creeper
//<b>Taunt</b>Has +2 Attack during your opponent's turn.
//<b>嘲讽</b>在你对手的回合获得+2攻击力。 
	{
		

        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            if (triggerEffectMinion.own == turnEndOfOwner)
            {
                p.minionGetBuffed(triggerEffectMinion, 2, 0);
            }
        }

        public override void onTurnStartTrigger(Playfield p, Minion triggerEffectMinion, bool turnStartOfOwner)
        {
            if (triggerEffectMinion.own == turnStartOfOwner)
            {
                p.minionGetBuffed(triggerEffectMinion, -2, 0);
            }
        }
    }
}