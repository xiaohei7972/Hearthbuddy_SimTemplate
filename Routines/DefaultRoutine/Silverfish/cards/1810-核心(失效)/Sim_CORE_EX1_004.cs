using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //* Young Priestess
    //At the end of your turn, give another random friendly minion +1 Health.
    // public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
    class Sim_CORE_EX1_004 : SimTemplate
    {
        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            if (triggerEffectMinion.own == turnEndOfOwner)
            {
                List<Minion> tmp = triggerEffectMinion.own ? p.ownMinions : p.enemyMinions;
                foreach (Minion m in tmp)
                {
                    if (triggerEffectMinion.entitiyID == m.entitiyID) continue;
                    p.minionGetBuffed(m, 0, 1);
                    break;
                }
            }
        }
        
        // {
        //     if (triggerEffectMinion.own == turnEndOfOwner)
        //     {
        //         List<Minion> tmp = turnEndOfOwner ? p.ownMinions : p.enemyMinions;
        //         int count = tmp.Count;
        //         if (count > 1)
        //         {
        //             Minion mnn = null;
        //             if (triggerEffectMinion.entitiyID != tmp[0].entitiyID) mnn = tmp[0];
        //             else mnn = tmp[1];

        //             for (int i = 1; i < count; i++)
        //             {
        //                 if (triggerEffectMinion.entitiyID == tmp[i].entitiyID) continue;
        //                 if (tmp[i].Hp < mnn.Hp) mnn = tmp[i]; //take the weakest
        //             }
        //             if (mnn != null) p.minionGetBuffed(mnn, 0, 1);
        //         }
        //     }
        // }

    }
}