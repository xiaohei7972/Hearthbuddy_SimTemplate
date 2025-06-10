using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_OG_255 : SimTemplate //* 厄运召唤者 Doomcaller
//<b>Battlecry:</b> Give your C'Thun +2/+2 <i>(wherever it is).</i> If it's dead, shuffle it into your deck.
//<b>战吼：</b>使你的克苏恩获得+2/+2<i>（无论它在哪里）。</i>如果克苏恩死亡，将其洗入你的牌库。 
	{
		
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.cthunGetBuffed(2, 2, 0);
		}
	}
}