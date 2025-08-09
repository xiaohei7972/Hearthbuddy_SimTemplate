using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //* 地穴领主 Crypt Lord
    //[x]<b>Taunt</b>After you summon a minion, gain +1 Health.
    //<b>嘲讽</b>在你召唤一个随从后，获得+1生命值。 
    class Sim_ICC_808 : SimTemplate
    {
        public override void onMinionWasSummoned(Playfield p, Minion triggerEffectMinion, Minion summonedMinion)
        {
            if (triggerEffectMinion.entitiyID != summonedMinion.entitiyID && triggerEffectMinion.entitiyID != summonedMinion.entitiyID && triggerEffectMinion.own == summonedMinion.own)
            {
                p.minionGetBuffed(triggerEffectMinion, 0, 1);
            }
        }

    }
}