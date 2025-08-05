using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 德鲁伊 费用：3
	//Swipe
	//横扫
	//Deal $4 damage to an enemy and $1 damage to all other enemies.
	//对一个敌人造成$4点伤害，并对所有其他敌人造成$1点伤害。
	class Sim_CORE_CS2_012 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				int dmg = (ownplay) ? p.getSpellDamageDamage(4) : p.getEnemySpellDamageDamage(4);
				int dmg1 = (ownplay) ? p.getSpellDamageDamage(1) : p.getEnemySpellDamageDamage(1);

				List<Minion> temp = (ownplay) ? p.enemyMinions : p.ownMinions;
				temp.Remove(target);
				if (ownplay) temp.Add(p.enemyHero);
				else temp.Add(p.ownHero);

				p.minionGetDamageOrHeal(target, dmg);
				foreach (Minion minion in temp)
				{
					p.minionGetDamageOrHeal(minion, dmg1);

				}

			}
		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), //需要一个目标
				new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET), //目标只能是敌方
			};
		}

	}
}
