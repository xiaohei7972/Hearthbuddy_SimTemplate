using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//武器 萨满祭司 费用：6 攻击力：3 耐久度：4
	//Horn of the Windlord
	//风领主的管号
	//[x]<b>Windfury</b>Whenever your heroattacks a minion, setits stats to 3/3.
	//<b>风怒</b>。每当你的英雄攻击随从时，将被攻击随从的属性值变为3/3。
	class Sim_JAM_011 : SimTemplate
	{
		// CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.JAM_011);
		// public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		// {
		// 	p.equipWeapon(weapon, ownplay);
		// }
		public override void onHeroattack(Playfield p, Minion own, Minion target)
		{
			// 检查是否是己方英雄并且装备的是“风领主的管号”
			if (own.own && p.ownWeapon.card.cardIDenum == CardDB.cardIDEnum.JAM_011)
			{
				if (target != null)
				{
					if (!target.isHero)
					{
						p.minionSetLifetoX(target, 3);
						p.minionSetLifetoX(target, 3);
					}
				}

			}

		}

	}
}
