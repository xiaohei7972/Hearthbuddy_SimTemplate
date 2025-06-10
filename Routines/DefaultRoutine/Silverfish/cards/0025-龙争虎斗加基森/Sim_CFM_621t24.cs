using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_621t24 : SimTemplate //* 金棘草 Goldthorn
//Give your minions +4 Health.
//使你的所有随从获得+4生命值。 
	{
		
		
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
			p.allMinionOfASideGetBuffed(ownplay, 0, 4);
		}
	}
}