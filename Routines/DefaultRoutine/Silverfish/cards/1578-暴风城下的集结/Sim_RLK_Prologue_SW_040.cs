using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HREngine.Bots
{
	//法术 恶魔猎手 费用：2
	//Fel Barrage
	//邪能弹幕
	//[x]Deal $2 damage tothe lowest Healthenemy, twice.
	//对生命值最低的敌人造成$2点伤害两次。
	class Sim_RLK_Prologue_SW_040 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			for (int i = 0; i < 2; i++)
			{
				int damage = ownplay ? p.getSpellDamageDamage(2) : p.getEnemySpellDamageDamage(2);
				List<Minion> minions = ownplay ? p.enemyMinions : p.ownMinions;
				if (ownplay)
				{
					minions.Add(p.enemyHero);
				}
				else
				{
					minions.Add(p.ownHero);
				}
				Minion target1 = p.searchRandomMinion(minions, searchmode.searchLowestHP);
				p.minionGetDamageOrHeal(target1, damage);
			}

		}
		
	}
}
