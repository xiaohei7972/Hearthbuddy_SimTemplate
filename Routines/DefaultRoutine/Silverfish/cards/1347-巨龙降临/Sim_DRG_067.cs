using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DRG_067 : SimTemplate //* 巨魔蝙蝠骑士 Troll Batrider
	{
		//<b>Battlecry:</b> Deal 3 damage to a random enemy minion.
		//<b>战吼：</b>随机对一个敌方随从造成3点伤害。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			List<Minion> temp = (own.own) ? p.enemyMinions : p.ownMinions;
			int times = (own.own) ? p.getSpellDamageDamage(3) : p.getEnemySpellDamageDamage(3);
			if (temp.Count >= 1)
			{
				Minion enemy = temp[0];
				int minhp = 10000;
				foreach (Minion m in temp)
				{
					if (m.Hp >= times + 1 && minhp > m.Hp)
					{
						enemy = m;
						minhp = m.Hp;
					}
				}
				p.minionGetDamageOrHeal(enemy, times);
			}
		}
	}
}