using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GIL_817 : SimTemplate //* 玻璃骑士 The Glass Knight
//[x]<b>Divine Shield</b>Whenever you restore Health,gain <b>Divine Shield</b>.
//<b>圣盾</b>每当有角色获得你的治疗时，获得<b>圣盾</b>。 
	{
		
        
        public override void onACharGotHealed(Playfield p, Minion triggerEffectMinion, int charsGotHealed)
        {
			if (charsGotHealed != 0 )
			{	
                triggerEffectMinion.divineshild = true;
			}
        }
	}
}