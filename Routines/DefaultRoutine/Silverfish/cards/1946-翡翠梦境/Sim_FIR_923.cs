using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 萨满祭司 费用：2
	//Flames of the Firelord
	//炎魔之火
	//[x]Deal $4 damage to a randomenemy minion. If you'reholding a card that costs(8) or more, deal $8 instead.
	//随机对一个敌方随从造成$4点伤害。如果你的手牌中有法力值消耗大于或等于（8）点的牌，改为造成$8点。
	class Sim_FIR_923 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			bool eightCostCard = false;
			int damage;

			foreach (Handmanager.Handcard owncard in p.owncards)
			{
				if (owncard.card.cost >= 8)
				{
					eightCostCard = true;
					break;
				}
			}

			if (!eightCostCard)
			{
				damage = ownplay ? p.getSpellDamageDamage(4) : p.getEnemySpellDamageDamage(4);
				target = p.getEnemyCharTargetForRandomSingleDamage(damage, true);
			}
			else
			{
				damage = ownplay ? p.getSpellDamageDamage(8) : p.getEnemySpellDamageDamage(8);
				target = p.getEnemyCharTargetForRandomSingleDamage(damage, true);
			}

			p.minionGetDamageOrHeal(target, 2, true);

		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_MINIMUM_ENEMY_MINIONS, 1), // 目标敌方场面最少要有一个随从
			};
		}

	}
}
