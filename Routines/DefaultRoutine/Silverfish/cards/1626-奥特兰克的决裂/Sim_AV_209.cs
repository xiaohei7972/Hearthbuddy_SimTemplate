using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//武器 恶魔猎手 费用：1 攻击力：1 耐久度：0
	//Dreadprison Glaive
	//恐惧牢笼战刃
	//[x]<b>Honorable Kill:</b> Dealdamage equal to yourhero's Attack to theenemy hero.
	//<b>荣誉消灭：</b>对敌方英雄造成等同于你英雄的攻击力的伤害。
	class Sim_AV_209 : SimTemplate
	{
		// CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.AV_209);
		// public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		// {
		// 	p.equipWeapon(weapon, ownplay);
		// }

		public override void OnHonorableKill(Playfield p, Weapon w, Minion target)
		{
			Minion hero = !target.own ? p.enemyHero : p.ownHero;
			Minion hero1 = target.own ? p.enemyHero : p.ownHero;

			p.minionGetDamageOrHeal(hero, hero1.Angr);

		}

	}
}
