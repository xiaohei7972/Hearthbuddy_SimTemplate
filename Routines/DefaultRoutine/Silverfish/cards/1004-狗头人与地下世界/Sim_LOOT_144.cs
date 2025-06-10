using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_144 : SimTemplate //* 藏宝巨龙 Hoarding Dragon
//<b>Deathrattle:</b> Give your opponent two Coins.
//<b>亡语：</b>使你的对手获得两个幸运币。 
	{


		public override void onDeathrattle(Playfield p, Minion m)
		{
            p.drawACard(CardDB.cardNameEN.thecoin, !m.own);
            p.drawACard(CardDB.cardNameEN.thecoin, !m.own);
		}


	}
}