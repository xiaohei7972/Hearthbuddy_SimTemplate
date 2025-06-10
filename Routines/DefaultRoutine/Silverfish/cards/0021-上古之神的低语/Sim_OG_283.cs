using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_OG_283 : SimTemplate //* 克苏恩的侍从 C'Thun's Chosen
//[x]<b>Divine Shield</b><b>Battlecry:</b> Give your C'Thun+2/+2 <i>(wherever it is).</i>
//<b>圣盾</b>，<b>战吼：</b>使你的克苏恩获得+2/+2<i>（无论它在哪里）。</i> 
	{
		
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (own.own) p.cthunGetBuffed(2, 2, 0);
		}
	}
}