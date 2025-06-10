using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_104 : SimTemplate //* 大胖 Hobgoblin
//Whenever you play a 1-Attack minion, give it +2/+2.
//每当你使用一张攻击力为1的随从牌，便使该牌所召唤的随从获得+2/+2。 
    {
        

        public override void onMinionWasSummoned(Playfield p, Minion m, Minion summonedMinion)
        {
            if (summonedMinion.playedFromHand && summonedMinion.Angr == 1 && m.own == summonedMinion.own && m.entitiyID != summonedMinion.entitiyID)
            {
                p.minionGetBuffed(summonedMinion, 2, 2);
            }
        }
    }
}