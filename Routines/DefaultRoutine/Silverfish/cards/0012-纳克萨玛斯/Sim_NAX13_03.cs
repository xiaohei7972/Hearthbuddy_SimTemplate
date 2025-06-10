using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_NAX13_03 : SimTemplate //* 增压 Supercharge
//Give your minions +2 Health.
//使你的所有随从获得+2生命值。 
	{
		
		
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
			p.allMinionOfASideGetBuffed(ownplay, 0, 2);
		}
	}
}