using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SW_441 : SimTemplate //* 纳鲁碎片 Shard of the Naaru
	{
		//<b>Tradeable</b><b>Silence</b> all enemy minions.
		//<b>可交易</b><b>沉默</b>所有敌方随从。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.allMinionsGetSilenced(!ownplay);
		}

	}
}
