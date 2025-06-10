using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_OG_284 : SimTemplate //* 暮光地卜师 Twilight Geomancer
//[x]<b>Taunt</b><b>Battlecry:</b> Give your C'Thun<b>Taunt</b> <i>(wherever it is).</i>
//<b>嘲讽</b>，<b>战吼：</b>使你的克苏恩获得<b>嘲讽</b><i>（无论它在哪里）。</i> 
	{
		
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if (own.own) p.cthunGetBuffed(0, 0, 1);
		}
	}
}