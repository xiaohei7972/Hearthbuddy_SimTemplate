using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_OG_286 : SimTemplate //* 暮光尊者 Twilight Elder
//At the end of your turn, give your C'Thun +1/+1 <i>(wherever it is).</i>
//在你的回合结束时，使你的克苏恩获得+1/+1<i>（无论它在哪里）。</i> 
	{
		
		
        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            if (triggerEffectMinion.own == turnEndOfOwner)
            {
                if (triggerEffectMinion.own) p.cthunGetBuffed(1, 1, 0);
            }
        }
	}
}