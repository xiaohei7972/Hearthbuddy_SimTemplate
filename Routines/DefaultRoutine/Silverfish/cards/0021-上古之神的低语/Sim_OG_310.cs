using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_OG_310 : SimTemplate //* 夜色镇执法官 Steward of Darkshire
//Whenever you summon a 1-Health minion, give it <b>Divine Shield</b>.
//每当你召唤一个生命值为1的随从，便使其获得<b>圣盾</b>。 
	{
		

        public override void onMinionWasSummoned(Playfield p, Minion m, Minion summonedMinion)
        {
            if (summonedMinion.Hp == 1 && m.own == summonedMinion.own && m.entitiyID != summonedMinion.entitiyID)
            {
                summonedMinion.divineshild = true;
            }
        }
    }
}