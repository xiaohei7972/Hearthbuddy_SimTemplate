using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //* 夜色镇执法官 Steward of Darkshire
    //Whenever you summon a 1-Health minion, give it <b>Divine Shield</b>.
    //每当你召唤一个生命值为1的随从，便使其获得<b>圣盾</b>。 
    class Sim_OG_310 : SimTemplate
    {
        public override void onMinionWasSummoned(Playfield p, Minion triggerEffectMinion, Minion summonedMinion)
        {
            if (summonedMinion.Hp == 1 && triggerEffectMinion.own == summonedMinion.own && triggerEffectMinion.entitiyID != summonedMinion.entitiyID)
            {
                summonedMinion.divineshild = true;
            }
        }
        
    }
}