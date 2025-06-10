using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BRM_015 : SimTemplate //* 复仇打击 Revenge
//Deal $1 damage to all minions. If you have 12 or less Health, deal $3 damage instead.
//对所有随从造成$1点伤害。如果你的生命值小于或等于12点，则改为造成$3点伤害。 
	{
		
		
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int dmg = 1;
			int heroHealth = (ownplay) ? p.ownHero.Hp : p.enemyHero.Hp;
			if(heroHealth <= 12) dmg = 3;
			
            dmg = (ownplay) ? p.getSpellDamageDamage(dmg) : p.getEnemySpellDamageDamage(dmg);
            p.allMinionsGetDamage(dmg);
		}
	}
}