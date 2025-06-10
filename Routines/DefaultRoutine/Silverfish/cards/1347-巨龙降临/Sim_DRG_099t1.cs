using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DRG_099t1 : SimTemplate //* 屠戮 Decimation
	{
		//Deal 5 damage to the enemy hero. Restore 5 Health to your hero.
		//对敌方英雄造成5点伤害。为你的英雄恢复5点生命值。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int dmg = (ownplay) ? p.getSpellDamageDamage(5) : p.getEnemySpellDamageDamage(5);
			p.minionGetDamageOrHeal(ownplay ? p.enemyHero : p.ownHero, dmg);
			int heal = (ownplay) ? p.getSpellHeal(5) : p.getEnemySpellHeal(5);
		}
	}
}