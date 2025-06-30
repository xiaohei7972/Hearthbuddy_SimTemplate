using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//武器 恶魔猎手 费用：4 攻击力：2 耐久度：0
	//Defiled Spear
	//亵渎之矛
	//[x]After your hero attacks an enemy, deal your hero'sAttack damage to anotherrandom enemy.
	//在你的英雄攻击一个敌人后，随机对另一个敌人造成等同于你的英雄攻击力的伤害。
	class Sim_EDR_842 : SimTemplate
	{
		CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EDR_842);

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.equipWeapon(weapon, ownplay);
		}

		public override void onHeroattack(Playfield p, Minion own, Minion target)
		{
			// 检查己方英雄是否装备了“亵渎之矛”
			if (own.own && p.ownWeapon.card.cardIDenum == CardDB.cardIDEnum.EDR_842)
			{
				if (target != null)
				{
					int damage = p.ownHero.Angr;
					List<Minion> possibleTargets = !own.own ? p.enemyMinions : p.ownMinions;

					// 将英雄加入到可能的目标中
					if (!own.own)
					{
						possibleTargets.Add(p.enemyHero);
					}
					else
					{
						possibleTargets.Add(p.ownHero);
					}
					// 删除原来攻击的目标
					foreach (Minion minion in possibleTargets)
					{
						if (minion == target)
						{
							possibleTargets.Remove(minion);
							break;
						}
					}

					// 从可能的目标中随机选择一个
					Minion target2 = possibleTargets[p.getRandomNumber(0, possibleTargets.Count - 1)];

					// 对选定的目标造成伤害
					if (target2 != null)
					{
						p.minionGetDamageOrHeal(target2, damage);
					}
				}
			}
		}


	}
}
