using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_062 : SimTemplate //* 钴制卫士 Cobalt Guardian
//Whenever you summon a Mech, gain <b>Divine Shield</b>.
//每当你召唤一个机械，便获得<b>圣盾</b>。 
    {

        

        public override void onMinionIsSummoned(Playfield p, Minion triggerEffectMinion, Minion summonedMinion)
        {
            if (triggerEffectMinion.own==summonedMinion.own && (TAG_RACE)summonedMinion.handcard.card.race == TAG_RACE.MECHANICAL)
            {
                triggerEffectMinion.divineshild = true;
            }
        }



    }

}