
using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_WON_065 : SimTemplate // 避免报错
    {
		

        public override void onMinionWasSummoned(Playfield p, Minion m, Minion summonedMinion)
{
    if (m.own == summonedMinion.own && summonedMinion.handcard.card.type == CardDB.cardtype.MOB)
    {
        p.minionGetBuffed(summonedMinion, 0, 1);
    }
}
 
    }
}
