using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_049 : SimTemplate //* 雷霆崖勇士 Thunder Bluff Valiant
//<b>Inspire:</b> Give your Totems +2 Attack.
//<b>激励：</b>使你的图腾获得+2攻击力。 
	{
		

		public override void onInspire(Playfield p, Minion m, bool own)
        {
			if (m.own == own)
			{
				List<Minion> temp = (own) ? p.ownMinions : p.enemyMinions;
				foreach (Minion mnn in temp)
				{
					if ((TAG_RACE)mnn.handcard.card.race == TAG_RACE.TOTEM)
					{
						p.minionGetBuffed(mnn, 2, 0);
					}
				}
			}
        }
	}
}