using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_NEW1_021 : SimTemplate //* 末日预言者 Doomsayer
	{
		//At the start of your turn, destroy ALL minions.
		//在你的回合开始时，消灭所有随从。

        public override void onTurnStartTrigger(Playfield p, Minion triggerEffectMinion, bool turnStartOfOwner)
        {
            if (turnStartOfOwner == triggerEffectMinion.own)
            {
                foreach (Minion m in p.ownMinions)
                {
                    if (m.entitiyID == triggerEffectMinion.entitiyID) continue;
                    if (m.playedThisTurn || m.playedPrevTurn)
                    {
                        if (PenalityManager.Instance.ownSummonFromDeathrattle.ContainsKey(m.name)) continue;
                        p.evaluatePenality += (m.Hp * 2 + m.Angr * 2) * 2;
                    }
                }
                p.allMinionsGetDestroyed();
            }
        }
	}
}