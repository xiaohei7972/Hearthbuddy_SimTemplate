using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：8 攻击力：5 生命值：5
	//Invincible
	//无敌
	//[x]<b>Reborn</b><b>Battlecry and Deathrattle:</b>Give another random friendly_____Undead +5/+5 and <b>Taunt</b>.____
	//<b>复生。</b><b>战吼，亡语：</b>随机使另一个友方亡灵获得+5/+5和<b>嘲讽</b>。
	class Sim_RLK_592 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			List<Minion> tmp = own.own ? p.ownMinions : p.enemyMinions;
			foreach (Minion minion in tmp)
			{
				if (own.entitiyID != minion.entitiyID && RaceUtils.IsRaceOrAll(minion.handcard.card.race, CardDB.Race.UNDEAD))
				{
					p.minionGetBuffed(minion, 5, 5);
					minion.taunt = true;
					if (own.own) p.anzOwnTaunt++;
					else p.anzEnemyTaunt++;
					break;
				}
			}
		}

		public override void onDeathrattle(Playfield p, Minion m)
		{
			List<Minion> tmp = m.own ? p.ownMinions : p.enemyMinions;
			foreach (Minion minion in tmp)
			{
				if (m.entitiyID != minion.entitiyID && RaceUtils.IsRaceOrAll(minion.handcard.card.race, CardDB.Race.UNDEAD))
				{
					p.minionGetBuffed(minion, 5, 5);
					minion.taunt = true;
					if (m.own) p.anzOwnTaunt++;
					else p.anzEnemyTaunt++;
					break;
				}
			}

		}

	}
}
