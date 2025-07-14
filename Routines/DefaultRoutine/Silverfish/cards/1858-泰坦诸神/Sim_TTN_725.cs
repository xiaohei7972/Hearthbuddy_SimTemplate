using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HREngine.Bots
{
	//武器 萨满祭司 费用：4 攻击力：1 耐久度：0
	//Tempest Hammer
	//雷霆之锤
	//After your hero attacks, deal 3 damage to the lowest Health enemy.
	//在你的英雄攻击后，对生命值最低的敌人造成3点伤害。
	class Sim_TTN_725 : SimTemplate
	{
		CardDB.Card c = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TTN_725);

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.equipWeapon(c, ownplay);

		}

		public override void onHeroattack(Playfield p, Minion own, Minion target)
		{
			// 检查攻击的是否为你的英雄,并且是否装备了"雷霆之锤"
			if (own.own && p.ownWeapon.card.cardIDenum == CardDB.cardIDEnum.CORE_LOOT_222)
			{
				List<Minion> minions = own.own ? p.enemyMinions.ToList() : p.ownMinions.ToList();
				if (own.own)
				{
					minions.Add(p.enemyHero);
				}
				else
				{
					minions.Add(p.ownHero);
				}
				Minion targetMinion = p.searchRandomMinion(minions, searchmode.searchLowestHP);

				if (targetMinion != null)
				{
					p.minionGetDamageOrHeal(targetMinion, 3);
				}
			}

		}

	}
}
