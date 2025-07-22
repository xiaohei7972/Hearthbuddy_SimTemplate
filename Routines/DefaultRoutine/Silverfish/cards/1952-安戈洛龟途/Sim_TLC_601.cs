using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 战士 费用：4
	//Shellnado
	//龟甲旋风
	//Spend up to 5 Armor. For each spent, deal 1 damage to all minions.
	//消耗最多5点护甲值。每消耗一点，对所有随从造成1点伤害。
	class Sim_TLC_601 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			Minion hero = ownplay ? p.ownHero : p.enemyHero;
			int damage = ownplay ? p.getSpellDamageDamage(1) : p.getEnemySpellDamageDamage(1);
			for (int i = 0; i < 5 && hero.armor > 1; i++)
			{
				hero.armor -= 1;
				p.allMinionsGetDamage(damage);
			}
			
		}
	}

}

