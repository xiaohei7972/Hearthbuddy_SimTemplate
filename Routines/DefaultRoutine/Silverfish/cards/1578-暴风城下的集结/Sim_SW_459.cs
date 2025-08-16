using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 猎人 费用：3 攻击力：1 生命值：6
	//Stormwind Piper
	//暴风城吹笛人
	//After this minion attacks,give your Beasts +1/+1.
	//在本随从攻击后，使你的野兽获得+1/+1。
	class Sim_SW_459 : SimTemplate
	{
		public override void afterMinionAttack(Playfield p, Minion attacker, Minion defender, bool dontcount)
		{
			foreach (Minion minion in attacker.own ? p.ownMinions : p.enemyMinions)
			{
				if (RaceUtils.IsRaceOrAll(minion.handcard.card.race, CardDB.Race.PET))
				{
					p.minionGetBuffed(minion, 1, 1);
				}
			}
		}

	}
}
