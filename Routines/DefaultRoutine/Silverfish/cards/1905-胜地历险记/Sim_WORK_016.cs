using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//武器 恶魔猎手 费用：3 攻击力：3 耐久度：0
	//Infernal Stapler
	//狱火订书器
	//After your hero attacks, deal 3 damage to your hero.
	//在你的英雄攻击后，对你的英雄造成3点伤害。
	class Sim_WORK_016 : SimTemplate
	{
		CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.WORK_016);

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.equipWeapon(weapon, ownplay);
		}

		public override void onHeroattack(Playfield p, Minion own, Minion target)
		{
			// 检查己方英雄是否装备了“狱火订书器”
			if (own.own && p.ownWeapon.card.cardIDenum == CardDB.cardIDEnum.WORK_016)
			{
				p.minionGetDamageOrHeal(p.ownHero, 3);
			}

		}


	}
}
