using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 猎人 费用：4
	//Greatwolf's Ferocity
	//巨狼的狂暴
	//Deal $4 damage to the enemy hero.
	//对敌方英雄造成$4点伤害。
	class Sim_EDR_263a : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice, Handmanager.Handcard hc)
		{
			int dmg = (ownplay) ? p.getSpellDamageDamage(4) : p.getEnemySpellDamageDamage(4);
            p.minionGetDamageOrHeal(p.enemyHero, dmg);
        }
		
	}
}
