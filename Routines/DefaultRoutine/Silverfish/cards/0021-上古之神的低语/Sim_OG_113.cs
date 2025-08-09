using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //* 夜色镇议员 Darkshire Councilman
    //[x]After you summon a minion, gain +1 Attack.
    //在你召唤一个随从后，获得+1攻击力。 
    class Sim_OG_113 : SimTemplate
    {
        public override void onMinionWasSummoned(Playfield p, Minion triggerEffectMinion, Minion summonedMinion)
        {
            if (triggerEffectMinion.entitiyID != summonedMinion.entitiyID && triggerEffectMinion.own == summonedMinion.own)
            {
                p.minionGetBuffed(triggerEffectMinion, 1, 0);
            }
        }

    }
}