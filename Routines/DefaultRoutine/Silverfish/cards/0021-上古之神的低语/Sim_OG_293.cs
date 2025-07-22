using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_OG_293 : SimTemplate //* 黑暗鸦人 Dark Arakkoa
//[x]<b>Taunt</b><b>Battlecry:</b> Give your C'Thun+3/+3 <i>(wherever it is).</i>
//<b>嘲讽</b>，<b>战吼：</b>使你的克苏恩获得+3/+3<i>（无论它在哪里）。</i> 
	{
		
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if (own.own) p.cthunGetBuffed(3, 3, 0);
		}
	}
}