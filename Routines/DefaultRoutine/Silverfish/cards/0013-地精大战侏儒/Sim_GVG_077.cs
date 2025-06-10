using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_077 : SimTemplate //* 心能魔像 Anima Golem
//At the end of each turn, destroy this minion if it's your only one.
//在每个回合结束时，如果该随从是你唯一的随从，则消灭该随从。 
    {

        

        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            if (triggerEffectMinion.own)
            {
                if (p.ownMinions.Count == 1)
                {
                    p.minionGetDestroyed(triggerEffectMinion);
                }
            }
            else
            {
                if (p.enemyMinions.Count == 1)
                {
                    p.minionGetDestroyed(triggerEffectMinion);
                }
            }
        }


    }

}