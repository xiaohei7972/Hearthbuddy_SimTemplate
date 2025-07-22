using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_OG_334 : SimTemplate //* 兜帽侍僧 Hooded Acolyte
//Whenever a character is healed, give yourC'Thun +1/+1 <i>(wherever it is).</i>
//每当一个角色获得治疗时，使你的克苏恩获得+1/+1<i>（无论它在哪里）。</i> 
	{
		

        public override void onACharGotHealed(Playfield p, Minion triggerEffectMinion, int charsGotHealed)
        {
            p.cthunGetBuffed(charsGotHealed, charsGotHealed, 0);
        }
	}
}