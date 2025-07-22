using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_326 : SimTemplate //* 光辉晶簇 luminousgeode
	{
		//在一个友方随从受到治疗后，使其获得+2攻击力。
        public override void onACharGotHealed(Playfield p, Minion triggerEffectMinion, int charsGotHealed)
        {
            if (charsGotHealed > 0 && !triggerEffectMinion.isHero)
            {
                p.minionGetBuffed(triggerEffectMinion, 2, 0);
            }
        }
		
	}
}
