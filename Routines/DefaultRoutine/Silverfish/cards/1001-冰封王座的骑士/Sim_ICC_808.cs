using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_808: SimTemplate //* 地穴领主 Crypt Lord
//[x]<b>Taunt</b>After you summon a minion, gain +1 Health.
//<b>嘲讽</b>在你召唤一个随从后，获得+1生命值。 
    {
        
        
        public override void onMinionWasSummoned(Playfield p, Minion m, Minion summonedMinion)
        {
            if (m.entitiyID != summonedMinion.entitiyID && m.own == summonedMinion.own)
            {
                p.minionGetBuffed(m, 0, 1);
            }
        }
    }
}