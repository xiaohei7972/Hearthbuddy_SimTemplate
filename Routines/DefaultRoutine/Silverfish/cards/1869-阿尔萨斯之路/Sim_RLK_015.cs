using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 巫妖王 费用：3
	//Howling Blast
	//凛风冲击
	//[x]Deal $3 damage to anenemy and <b>Freeze</b> it.Deal $1 damage to allother enemies.
	//对一个敌人造成$3点伤害并将其<b>冻结</b>。对所有其他敌人造成$1点伤害。
	class Sim_RLK_015 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				int dmg = (ownplay) ? p.getSpellDamageDamage(3) : p.getEnemySpellDamageDamage(3);
				int dmg1 = (ownplay) ? p.getSpellDamageDamage(1) : p.getEnemySpellDamageDamage(1);
				List<Minion> minions = ownplay ? p.ownMinions : p.enemyMinions;
				if (ownplay) minions.Add(p.enemyHero);
				else minions.Add(p.ownHero);

				p.minionGetDamageOrHeal(target, dmg);
				p.minionGetFrozen(target);
				foreach (Minion minion in minions)
				{
					if (target.entitiyID == minion.entitiyID) continue;
					p.minionGetDamageOrHeal(minion, dmg1);
				}
				
			}
		}
		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), //需要一个目标
				new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET), //目标只能是敌人
            };
		}
		
	}
}
