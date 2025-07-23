using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 德鲁伊 费用：2
	//Rake
	//斜掠
	//[x]Give your hero +2 Attackthis turn. Deal damageequal to your hero'sAttack to a minion.
	//在本回合中，使你的英雄获得+2攻击力。对一个随从造成等同于你的英雄攻击力的伤害。
	class Sim_NX2_012 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			Minion hero = ownplay ? p.ownHero : p.enemyHero;
			p.minionGetTempBuff(hero, 2, 0);
            hero.updateReadyness();
			if (target != null)
			{
				int damage = ownplay ? p.getSpellDamageDamage(hero.Angr) : p.getEnemySpellDamageDamage(hero.Angr);
				p.minionGetDamageOrHeal(target, damage);
			}

		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 只能是随从
			};
		}

	}
}
