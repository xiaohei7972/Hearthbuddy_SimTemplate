using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DRG_071 : SimTemplate //* 厄运信天翁 Bad Luck Albatross
	{
		//<b>Deathrattle:</b> Shuffle two 1/1 Albatross into your opponent's deck.
		//<b>亡语：</b>将两张1/1的信天翁洗入你对手的牌库。
		public override void onDeathrattle(Playfield p, Minion m)
		{
			if (m.own)
			{
				p.enemyDeckSize += 2;
			}
			else
			{

				p.ownDeckSize += 2;
			}
		}
	}
}