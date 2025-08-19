using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//武器 萨满祭司 费用：2 攻击力：1 耐久度：0
	//Rune Dagger
	//符文匕首
	//After your hero attacks, gain <b>Spell Damage +1</b> this turn.
	//在你的英雄攻击后，在本回合中获得<b>法术伤害+1</b>。
	class Sim_SCH_301 : SimTemplate
	{
		// CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.SCH_301);

		// public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		// {
		// 	p.equipWeapon(weapon, ownplay);
		// }

		public override void afterHeroattack(Playfield p, Minion own, Minion target)
		{
			// 检查己方英雄是否装备了“银剑”
			if (own.own && p.ownWeapon.card.cardIDenum == CardDB.cardIDEnum.SCH_301)
			{
				p.spellpower++;
				p.tempSpellPower++;
			}
		}

	}
}
