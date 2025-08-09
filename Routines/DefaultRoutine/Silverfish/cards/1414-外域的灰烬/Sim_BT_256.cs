using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //* 龙喉监工 Dragonmaw Overseer
    //At the end of your turn, give another friendly minion +2/+2.
    //在你的回合结束时，使另一个友方随从获得+2/+2。
    class Sim_BT_256 : SimTemplate
    {
        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            if (triggerEffectMinion.own == turnEndOfOwner)
            {
                List<Minion> tmp = triggerEffectMinion.own ? p.ownMinions : p.enemyMinions;
                foreach (Minion m in tmp)
                {
                    if (triggerEffectMinion.entitiyID == m.entitiyID) continue;
                    p.minionGetBuffed(m, 2, 2);
                    break;
                }
            }
        }

    }
}
