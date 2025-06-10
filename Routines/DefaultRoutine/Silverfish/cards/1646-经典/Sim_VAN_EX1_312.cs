using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_312 : SimTemplate //* 扭曲虚空 Twisting Nether
	{
		//Destroy all minions.
		//消灭所有随从。

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            p.allMinionsGetDestroyed();
		}

	}
}