using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 术士 费用：8
	//Black Hole
	//黑洞
	//Destroy all minions except Demons.
	//消灭所有非恶魔随从。
	class Sim_GDB_126 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			foreach (Minion minion in p.ownMinions.ToArray())
			{
				if (minion.untouchable || RaceUtils.MinionBelongsToRace(minion.handcard.card.GetRaces(), CardDB.Race.DEMON)) continue;
				p.minionGetDestroyed(minion);
			}

			foreach (Minion minion in p.enemyMinions.ToArray())
			{
				if (minion.untouchable || RaceUtils.MinionBelongsToRace(minion.handcard.card.GetRaces(), CardDB.Race.DEMON)) continue;
				p.minionGetDestroyed(minion);
			}
		}

	}
}
