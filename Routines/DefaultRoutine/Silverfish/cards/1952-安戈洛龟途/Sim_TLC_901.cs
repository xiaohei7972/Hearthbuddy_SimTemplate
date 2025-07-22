using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 恶魔猎手 费用：2
	//Fumigate
	//烟雾熏蒸
	//Deal $3 damage to a minion and all others of the same minion type.
	//对一个随从及所有相同类型的其他随从造成$3点伤害。
	class Sim_TLC_901 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				CardDB.Race race = target.handcard.card.race;
				List<Minion> minions = new List<Minion>();
				minions.AddRange(p.ownMinions);
				minions.AddRange(p.enemyMinions);
				minions.Remove(target);
				int damage = ownplay ? p.getSpellDamageDamage(3) : p.getEnemySpellDamageDamage(3);
				p.minionGetDamageOrHeal(target, damage);
				minions.ForEach((m) =>
				{
					if (m.handcard.card.race == race)
						p.minionGetDamageOrHeal(m, damage);
				});
			}
		}


		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 只能是随从
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET), // 只能是敌方
            };
		}

	}
}
