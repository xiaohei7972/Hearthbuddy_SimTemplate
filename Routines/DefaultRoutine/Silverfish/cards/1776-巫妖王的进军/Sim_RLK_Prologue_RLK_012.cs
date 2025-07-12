using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//武器 巫妖王 费用：3 攻击力：3 耐久度：0
	//Soulbreaker
	//断魂
	//After your hero attacks and kills a minion, gain 2 <b>Corpses</b>.
	//在你的英雄攻击并消灭一个随从后，获得2份<b>残骸</b>。
	class Sim_RLK_Prologue_RLK_012 : SimTemplate
	{
		CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.RLK_Prologue_RLK_012);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.equipWeapon(weapon, ownplay);
		}

		public override void onHeroattack(Playfield p, Minion own, Minion target)
		{
			// 检查己方英雄是否装备了“断魂”
			if (own.own && p.ownWeapon.card.cardIDenum == CardDB.cardIDEnum.RLK_Prologue_RLK_012)
			{
				if (!target.isHero && target.Hp <= 0)
				{
					p.addCorpses(2);
				}

			}
		}

	}
}
