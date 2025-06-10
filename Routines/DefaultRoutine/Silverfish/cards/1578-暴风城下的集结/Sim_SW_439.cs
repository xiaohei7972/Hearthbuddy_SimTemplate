using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SW_439 : SimTemplate //* 活泼的松鼠 Vibrant Squirrel
	{
		//[x]<b>Deathrattle:</b> Shuffle 4 Acornsinto your deck. When drawn,summon a 2/1 Squirrel.
		//<b>亡语：</b>将四张橡果洗入你的牌库。当抽到橡果时，召唤一只2/1的松鼠。
		public override void onDeathrattle(Playfield p, Minion m)
		{
			if (m.own) p.ownDeckSize += 4;
			else p.enemyDeckSize += 4;
		}
		
	}
}
