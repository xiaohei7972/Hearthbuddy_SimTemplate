using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_760 : SimTemplate //* 暗金教水晶侍女 Kabal Crystal Runner
//Costs (2) less for each <b>Secret</b> you've played this_game.
//在本局对战中，你每使用一张奥秘牌就会使法力值消耗减少（2）点。 
	{
		public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool ownplay, Handmanager.Handcard triggerhc)
		{
			if (ownplay && hc.card.Secret)
            {
				triggerhc.manacost = triggerhc.getManaCost(p);
			}
		}
	}
}
