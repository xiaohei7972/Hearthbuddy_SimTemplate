using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 术士 费用：1
	//Soulfreeze
	//灵魂冻结
	//<b>Freeze</b> a minionand its neighbors. Deal damage to your hero equal to the number <b>Frozen</b>.
	//<b>冻结</b>一个随从及其相邻随从，对你的英雄造成等同于所<b>冻结</b>随从数量的伤害。
	class Sim_DEEP_032 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int FrozenMinionNums = 0;
			if (target != null)
			{
				FrozenMinionNums++;
				p.minionGetFrozen(target);
				List<Minion> temp = (target.own) ? p.ownMinions : p.enemyMinions;
				foreach (Minion m in temp)
				{
					if (target.zonepos == m.zonepos + 1 || target.zonepos + 1 == m.zonepos)
					{
						p.minionGetFrozen(m);
						FrozenMinionNums++;
					}
				}
				int damage = ownplay ? p.getSpellDamageDamage(FrozenMinionNums) : p.getEnemySpellDamageDamage(FrozenMinionNums);
				p.minionGetDamageOrHeal(ownplay ? p.ownHero : p.enemyHero, damage);

			}
		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 只能是随从
				// new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET), // 只能是友方
			};
		}
	}
}
