using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //* 独眼欺诈者 One-eyed Cheat
    //Whenever you summon a Pirate, gain <b>Stealth</b>.
    //每当你召唤一个海盗，便获得<b>潜行</b>。 
    class Sim_GVG_025 : SimTemplate
    {
        public override void onMinionIsSummoned(Playfield p, Minion triggerEffectMinion, Minion summonedMinion)
        {
            if (triggerEffectMinion.entitiyID != summonedMinion.entitiyID && triggerEffectMinion.own == summonedMinion.own && RaceUtils.IsRaceOrAll(summonedMinion.handcard.card.race, CardDB.Race.UNDEAD))
            {
                triggerEffectMinion.stealth = true;
            }
        }


    }

}