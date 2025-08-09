using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //* Murloc Tidecaller
    //Whenever you summon a Murloc, gain +1 Attack.
    class Sim_CORE_EX1_509 : SimTemplate
    {
        public override void onMinionIsSummoned(Playfield p, Minion triggerEffectMinion, Minion summonedMinion)
        {
            if (triggerEffectMinion.entitiyID != summonedMinion.entitiyID && triggerEffectMinion.own == summonedMinion.own && (TAG_RACE)summonedMinion.handcard.card.race == TAG_RACE.MURLOC)
            {
                p.minionGetBuffed(triggerEffectMinion, 1, 0);
            }
        }

    }
}