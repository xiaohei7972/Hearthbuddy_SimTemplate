using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //* 钴制卫士 Cobalt Guardian
    //Whenever you summon a Mech, gain <b>Divine Shield</b>.
    //每当你召唤一个机械，便获得<b>圣盾</b>。 
    class Sim_GVG_062 : SimTemplate
    {
        public override void onMinionIsSummoned(Playfield p, Minion triggerEffectMinion, Minion summonedMinion)
        {
            if (triggerEffectMinion.entitiyID != summonedMinion.entitiyID && triggerEffectMinion.own == summonedMinion.own && RaceUtils.IsRaceOrAll(summonedMinion.handcard.card.race, CardDB.Race.UNDEAD))
            {
                triggerEffectMinion.divineshild = true;
            }
        }

    }

}