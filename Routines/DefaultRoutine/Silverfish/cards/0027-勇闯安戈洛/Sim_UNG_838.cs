using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_838 : SimTemplate //* 焦油兽王 Tar Lord
//<b>Taunt</b>Has +4 Attack during your opponent’s turn.
//<b>嘲讽</b>在你对手的回合获得+4攻击力。 
	{
		

        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            if (triggerEffectMinion.own == turnEndOfOwner)
            {
                p.minionGetBuffed(triggerEffectMinion, 4, 0);
            }
        }

        public override void onTurnStartTrigger(Playfield p, Minion triggerEffectMinion, bool turnStartOfOwner)
        {
            if (triggerEffectMinion.own == turnStartOfOwner)
            {
                p.minionGetBuffed(triggerEffectMinion, -4, 0);
            }
        }
    }
}